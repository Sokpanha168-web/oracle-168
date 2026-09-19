using Oracle.ManagedDataAccess.Client;
using POS_204_oracle.uc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_204_oracle
{
    public static class Program
    {
        public static int UserID;
        public static string UserName;
        public static string UserType;
        public static string UserPassword;
        public static OracleConnection con = new OracleConnection();

        public static bool IsAdmin => string.IsNullOrEmpty(UserType) || string.Equals(UserType, "ADMIN", StringComparison.OrdinalIgnoreCase);

        public static bool CanAccessModule(string moduleName)
        {
            if (IsAdmin) return true;
            if (string.IsNullOrEmpty(moduleName)) return false;

            switch (moduleName.Trim().ToUpperInvariant())
            {
                case "DASHBOARD":
                case "SALES":
                case "SALE":
                case "CUSTOMER":
                case "CUSTOMERS":
                    return true;
                default:
                    return false;
            }
        }
        public static void MySN(UserControl u, String msg, Color c)
        {
            MessageBox.Show(msg);
        }
        public static void OpenConnection() {
            try
            {
                con.ConnectionString = string.IsNullOrEmpty(Properties.Settings.Default.con_str)
                    ? "User Id=panha;DATA SOURCE=localhost:1521/FREE;PASSWORD=123"
                    : Properties.Settings.Default.con_str;
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        
        public static void full_dg(DataGridView dg)
        {
            int sum_col_width = 0;
            int sum_col_width_full = 0;
            for (int i = 0; i < dg.ColumnCount - 2; i++)
            {
                sum_col_width += dg.Columns[i].Width;
            }
            sum_col_width_full = sum_col_width + dg.Columns[dg.ColumnCount-1].Width;
            if (sum_col_width_full >= dg.Width)
            {
                return;
            }
            dg.Columns[dg.ColumnCount - 1].Width = dg.Width - sum_col_width - 120;
        }

        public static void MyDG(DataGridView dg) {
            dg.BorderStyle = BorderStyle.None;
            dg.BackgroundColor = Color.White;
            dg.AllowUserToAddRows = false;
            dg.AllowUserToResizeRows = false;
            dg.ReadOnly = true;
            dg.RowHeadersVisible = false;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.MultiSelect = false;
            dg.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dg.RowTemplate.Height = 50;
            dg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dg.EnableHeadersVisualStyles = false;
            dg.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            dg.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dg.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dg.ColumnHeadersHeight = 40;

        }



        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                OpenConnection();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                Application.Run(new frm_login());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
 
        }
    }
}
