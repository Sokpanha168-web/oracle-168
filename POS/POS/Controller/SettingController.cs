using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace POS_204_oracle.Controller
{
    public class CompanySettings
    {
        public string CompanyName { get; set; } = "POINT OF SALE PRO SYSTEM";
        public string CompanySlogan { get; set; } = "Quality Products & Best Service";
        public string CompanyPhone { get; set; } = "+855 (0) 12 345 678";
        public string CompanyEmail { get; set; } = "info@possystem.com";
        public string CompanyAddress { get; set; } = "Phnom Penh, Cambodia";
        public string ReceiptFooter { get; set; } = "THANK YOU FOR YOUR PURCHASE! Please come again!";
        public decimal ExchangeRate { get; set; } = 4100m;
        public byte[] LogoBytes { get; set; }
        public bool HasCustomLogo => LogoBytes != null && LogoBytes.Length > 0;

        public Image GetLogoImage()
        {
            if (!HasCustomLogo) return null;
            try
            {
                using (MemoryStream ms = new MemoryStream(LogoBytes))
                {
                    return Image.FromStream(ms);
                }
            }
            catch
            {
                return null;
            }
        }
    }

    public class SettingController
    {
        private static bool tableChecked = false;
        public static CompanySettings Current { get; private set; } = new CompanySettings();
        public static event Action OnSettingsChanged;

        static SettingController()
        {
            LoadDiskCache();
        }

        public static void EnsureSettingTable()
        {
            if (tableChecked) return;
            try
            {
                if (Program.con.State != ConnectionState.Open) Program.con.Open();

                bool exists = false;
                using (OracleCommand checkCmd = new OracleCommand(
                    "SELECT COUNT(*) FROM user_tables WHERE UPPER(table_name) = 'TBL_SETTING'", Program.con))
                {
                    exists = Convert.ToInt32(checkCmd.ExecuteScalar()) > 0;
                }

                if (!exists)
                {
                    string ddl = @"CREATE TABLE tbl_setting (
                        setting_key VARCHAR2(50) NOT NULL PRIMARY KEY,
                        setting_value NVARCHAR2(500) NULL,
                        setting_blob BLOB NULL,
                        updated_at TIMESTAMP DEFAULT SYSTIMESTAMP
                    )";

                    using (OracleCommand createCmd = new OracleCommand(ddl, Program.con))
                    {
                        createCmd.ExecuteNonQuery();
                    }
                }
            }
            catch { }
            tableChecked = true;
        }

        public CompanySettings LoadSettings()
        {
            EnsureSettingTable();
            CompanySettings s = new CompanySettings();

            try
            {
                if (Program.con.State != ConnectionState.Open) Program.con.Open();

                using (OracleCommand cmd = new OracleCommand("SELECT setting_key, setting_value, setting_blob FROM tbl_setting", Program.con))
                using (OracleDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        string key = r["setting_key"]?.ToString()?.ToUpper();
                        string val = r["setting_value"] != DBNull.Value ? r["setting_value"].ToString() : "";

                        switch (key)
                        {
                            case "COMPANY_NAME":
                                if (!string.IsNullOrWhiteSpace(val)) s.CompanyName = val;
                                break;
                            case "COMPANY_SLOGAN":
                                s.CompanySlogan = val;
                                break;
                            case "COMPANY_PHONE":
                                s.CompanyPhone = val;
                                break;
                            case "COMPANY_EMAIL":
                                s.CompanyEmail = val;
                                break;
                            case "COMPANY_ADDRESS":
                                s.CompanyAddress = val;
                                break;
                            case "RECEIPT_FOOTER":
                                s.ReceiptFooter = val;
                                break;
                            case "EXCHANGE_RATE":
                                decimal rate;
                                if (decimal.TryParse(val, out rate) && rate > 0) s.ExchangeRate = rate;
                                break;
                            case "COMPANY_LOGO":
                                if (r["setting_blob"] != DBNull.Value)
                                {
                                    s.LogoBytes = (byte[])r["setting_blob"];
                                    SaveLogoToDisk(s.LogoBytes);
                                }
                                break;
                        }
                    }
                }
            }
            catch { }

            // If no logo from DB, check disk cache
            if (s.LogoBytes == null || s.LogoBytes.Length == 0)
            {
                s.LogoBytes = LoadLogoFromDisk();
            }

            Current = s;
            return Current;
        }

        public bool SaveSettings(CompanySettings s, byte[] newLogoBytes, bool logoChanged, out string error)
        {
            error = "";
            EnsureSettingTable();

            try
            {
                if (Program.con.State != ConnectionState.Open) Program.con.Open();

                UpsertKey("COMPANY_NAME", s.CompanyName);
                UpsertKey("COMPANY_SLOGAN", s.CompanySlogan);
                UpsertKey("COMPANY_PHONE", s.CompanyPhone);
                UpsertKey("COMPANY_EMAIL", s.CompanyEmail);
                UpsertKey("COMPANY_ADDRESS", s.CompanyAddress);
                UpsertKey("RECEIPT_FOOTER", s.ReceiptFooter);
                UpsertKey("EXCHANGE_RATE", s.ExchangeRate.ToString());

                if (logoChanged)
                {
                    if (newLogoBytes != null && newLogoBytes.Length > 0)
                    {
                        UpsertBlob("COMPANY_LOGO", newLogoBytes);
                        SaveLogoToDisk(newLogoBytes);
                        s.LogoBytes = newLogoBytes;
                    }
                    else
                    {
                        DeleteBlob("COMPANY_LOGO");
                        DeleteLogoFromDisk();
                        s.LogoBytes = null;
                    }
                }
                else
                {
                    s.LogoBytes = Current.LogoBytes;
                }

                Current = s;
                OnSettingsChanged?.Invoke();
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        private void UpsertKey(string key, string value)
        {
            string mergeSql = @"MERGE INTO tbl_setting s
                USING (SELECT :k AS setting_key, :v AS setting_value FROM dual) src
                ON (s.setting_key = src.setting_key)
                WHEN MATCHED THEN
                    UPDATE SET s.setting_value = src.setting_value, s.updated_at = SYSTIMESTAMP
                WHEN NOT MATCHED THEN
                    INSERT (setting_key, setting_value, updated_at) VALUES (src.setting_key, src.setting_value, SYSTIMESTAMP)";

            using (OracleCommand cmd = new OracleCommand(mergeSql, Program.con))
            {
                cmd.Parameters.Add(new OracleParameter("k", key));
                cmd.Parameters.Add(new OracleParameter("v", string.IsNullOrEmpty(value) ? (object)DBNull.Value : value));
                cmd.ExecuteNonQuery();
            }
        }

        private void UpsertBlob(string key, byte[] bytes)
        {
            string mergeSql = @"MERGE INTO tbl_setting s
                USING (SELECT :k AS setting_key FROM dual) src
                ON (s.setting_key = src.setting_key)
                WHEN MATCHED THEN
                    UPDATE SET s.setting_blob = :b, s.updated_at = SYSTIMESTAMP
                WHEN NOT MATCHED THEN
                    INSERT (setting_key, setting_blob, updated_at) VALUES (src.setting_key, :b, SYSTIMESTAMP)";

            using (OracleCommand cmd = new OracleCommand(mergeSql, Program.con))
            {
                cmd.Parameters.Add(new OracleParameter("k", key));
                OracleParameter pBlob = new OracleParameter("b", OracleDbType.Blob);
                pBlob.Value = (bytes != null && bytes.Length > 0) ? (object)bytes : DBNull.Value;
                cmd.Parameters.Add(pBlob);
                cmd.ExecuteNonQuery();
            }
        }

        private void DeleteBlob(string key)
        {
            using (OracleCommand cmd = new OracleCommand("UPDATE tbl_setting SET setting_blob = NULL, updated_at = SYSTIMESTAMP WHERE setting_key = :k", Program.con))
            {
                cmd.Parameters.Add(new OracleParameter("k", key));
                cmd.ExecuteNonQuery();
            }
        }

        public static void SaveLogoToDisk(byte[] bytes)
        {
            try
            {
                string dir = Path.Combine(Application.StartupPath, "Images");
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
                string filePath = Path.Combine(dir, "company_logo.png");
                File.WriteAllBytes(filePath, bytes);
            }
            catch { }
        }

        public static void DeleteLogoFromDisk()
        {
            try
            {
                string filePath = Path.Combine(Application.StartupPath, "Images", "company_logo.png");
                if (File.Exists(filePath)) File.Delete(filePath);
            }
            catch { }
        }

        public static byte[] LoadLogoFromDisk()
        {
            try
            {
                string filePath = Path.Combine(Application.StartupPath, "Images", "company_logo.png");
                if (File.Exists(filePath)) return File.ReadAllBytes(filePath);
            }
            catch { }
            return null;
        }

        private static void LoadDiskCache()
        {
            try
            {
                byte[] diskLogo = LoadLogoFromDisk();
                if (diskLogo != null && diskLogo.Length > 0)
                {
                    Current.LogoBytes = diskLogo;
                }
            }
            catch { }
        }
    }
}
