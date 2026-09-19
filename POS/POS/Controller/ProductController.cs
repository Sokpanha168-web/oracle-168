using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace POS_204_oracle.Controller
{
    internal class ProductController
    {
        OracleCommand cmd = new OracleCommand();
        OracleDataAdapter da = new OracleDataAdapter();
        DataTable dt = new DataTable();

        static bool columnChecked = false;

        public static void EnsureProductImageColumn()
        {
            if (columnChecked) return;
            try
            {
                if (Program.con.State != ConnectionState.Open) Program.con.Open();
                using (OracleCommand c = new OracleCommand("ALTER TABLE tbl_product ADD (product_image BLOB)", Program.con))
                {
                    c.ExecuteNonQuery();
                }
            }
            catch
            {
                // Column already exists or alter not permitted
            }
            columnChecked = true;
        }

        public DataTable GetAll()
        {
            dt = new DataTable();
            cmd = new OracleCommand();
            cmd.Connection = Program.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from v_product";
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        public int Insert(string product_name, int category_id, int supplier_id, int user_id, int is_stock, decimal product_cost, decimal product_price, int product_status, byte[] photoBytes = null)
        {
            EnsureProductImageColumn();
            int newId = 0;
            try
            {
                if (Program.con.State != ConnectionState.Open) Program.con.Open();

                cmd = new OracleCommand();
                cmd.Connection = Program.con;
                cmd.CommandType = CommandType.Text;

                string sql = "INSERT INTO tbl_product (product_name, category_id, supplier_id, user_id, is_stock, product_cost, product_price, product_status) " +
                             "VALUES (:product_name, :category_id, :supplier_id, :user_id, :is_stock, :product_cost, :product_price, :product_status) " +
                             "RETURNING product_id INTO :product_id";

                cmd.CommandText = sql;
                cmd.Parameters.Add(new OracleParameter("product_name", product_name));
                cmd.Parameters.Add(new OracleParameter("category_id", category_id));
                cmd.Parameters.Add(new OracleParameter("supplier_id", supplier_id));
                cmd.Parameters.Add(new OracleParameter("user_id", user_id));
                cmd.Parameters.Add(new OracleParameter("is_stock", is_stock));
                cmd.Parameters.Add(new OracleParameter("product_cost", product_cost));
                cmd.Parameters.Add(new OracleParameter("product_price", product_price));
                cmd.Parameters.Add(new OracleParameter("product_status", product_status));

                OracleParameter pId = new OracleParameter("product_id", Oracle.ManagedDataAccess.Client.OracleDbType.Decimal, ParameterDirection.Output);
                cmd.Parameters.Add(pId);

                cmd.ExecuteNonQuery();

                if (pId.Value != null && pId.Value != DBNull.Value)
                {
                    newId = Convert.ToInt32(pId.Value.ToString());
                }

                if (newId <= 0)
                {
                    using (OracleCommand cmdMax = new OracleCommand("SELECT NVL(MAX(product_id), 0) FROM tbl_product", Program.con))
                    {
                        newId = Convert.ToInt32(cmdMax.ExecuteScalar());
                    }
                }

                // Save photo if provided
                if (newId > 0 && photoBytes != null && photoBytes.Length > 0)
                {
                    SavePhotoToDisk(newId, photoBytes);
                    SavePhotoToDb(newId, photoBytes);
                }

                return newId > 0 ? 1 : -1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int Update(int product_id, string product_name, int category_id, int supplier_id, int is_stock, decimal product_cost, decimal product_price, int product_status, byte[] photoBytes = null, bool photoChanged = false)
        {
            EnsureProductImageColumn();
            int x = 0;
            cmd = new OracleCommand();
            try
            {
                if (Program.con.State != ConnectionState.Open) Program.con.Open();

                cmd.Connection = Program.con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE tbl_product SET " +
                    "product_name=:product_name, " +
                    "category_id=:category_id, " +
                    "supplier_id=:supplier_id, " +
                    "is_stock=:is_stock, " +
                    "product_cost=:product_cost, " +
                    "product_price=:product_price, " +
                    "product_status=:product_status " +
                    "WHERE product_id=:product_id";

                cmd.Parameters.Add(new OracleParameter("product_name", product_name));
                cmd.Parameters.Add(new OracleParameter("category_id", category_id));
                cmd.Parameters.Add(new OracleParameter("supplier_id", supplier_id));
                cmd.Parameters.Add(new OracleParameter("is_stock", is_stock));
                cmd.Parameters.Add(new OracleParameter("product_cost", product_cost));
                cmd.Parameters.Add(new OracleParameter("product_price", product_price));
                cmd.Parameters.Add(new OracleParameter("product_status", product_status));
                cmd.Parameters.Add(new OracleParameter("product_id", product_id));

                x = cmd.ExecuteNonQuery();

                if (photoChanged)
                {
                    if (photoBytes != null && photoBytes.Length > 0)
                    {
                        SavePhotoToDisk(product_id, photoBytes);
                        SavePhotoToDb(product_id, photoBytes);
                    }
                    else
                    {
                        DeletePhotoFromDisk(product_id);
                        SavePhotoToDb(product_id, null);
                    }
                }
            }
            catch (Exception)
            {
                x = -1;
            }
            return x;
        }

        public void GetTransactionCount(int product_id, out int salesCount, out int stockCount)
        {
            salesCount = 0;
            stockCount = 0;
            try
            {
                if (Program.con.State != ConnectionState.Open) Program.con.Open();

                using (OracleCommand c = new OracleCommand("SELECT COUNT(*) FROM tbl_sale_detail WHERE product_id = :id", Program.con))
                {
                    c.BindByName = true;
                    c.Parameters.Add(new OracleParameter("id", product_id));
                    object res = c.ExecuteScalar();
                    if (res != null && res != DBNull.Value) salesCount = Convert.ToInt32(res);
                }

                using (OracleCommand c = new OracleCommand("SELECT COUNT(*) FROM tbl_stock_transaction WHERE product_id = :id", Program.con))
                {
                    c.BindByName = true;
                    c.Parameters.Add(new OracleParameter("id", product_id));
                    object res = c.ExecuteScalar();
                    if (res != null && res != DBNull.Value) stockCount = Convert.ToInt32(res);
                }
            }
            catch { }
        }

        public int Deactivate(int product_id)
        {
            try
            {
                if (Program.con.State != ConnectionState.Open) Program.con.Open();
                using (OracleCommand c = new OracleCommand("UPDATE tbl_product SET product_status = 0 WHERE product_id = :id", Program.con))
                {
                    c.BindByName = true;
                    c.Parameters.Add(new OracleParameter("id", product_id));
                    return c.ExecuteNonQuery();
                }
            }
            catch { return -1; }
        }

        public int ForceDelete(int product_id)
        {
            OracleTransaction tr = null;
            try
            {
                if (Program.con.State != ConnectionState.Open) Program.con.Open();
                tr = Program.con.BeginTransaction();

                using (OracleCommand c = new OracleCommand("DELETE FROM tbl_sale_detail WHERE product_id = :id", Program.con))
                {
                    c.Transaction = tr;
                    c.BindByName = true;
                    c.Parameters.Add(new OracleParameter("id", product_id));
                    c.ExecuteNonQuery();
                }

                using (OracleCommand c = new OracleCommand("DELETE FROM tbl_stock_transaction WHERE product_id = :id", Program.con))
                {
                    c.Transaction = tr;
                    c.BindByName = true;
                    c.Parameters.Add(new OracleParameter("id", product_id));
                    c.ExecuteNonQuery();
                }

                int s = 0;
                using (OracleCommand c = new OracleCommand("DELETE FROM tbl_product WHERE product_id = :id", Program.con))
                {
                    c.Transaction = tr;
                    c.BindByName = true;
                    c.Parameters.Add(new OracleParameter("id", product_id));
                    s = c.ExecuteNonQuery();
                }

                tr.Commit();
                DeletePhotoFromDisk(product_id);
                return s;
            }
            catch (Exception)
            {
                if (tr != null)
                {
                    try { tr.Rollback(); } catch { }
                }
                return -1;
            }
        }

        public int Delete(int product_id)
        {
            int s = 0;
            try
            {
                if (Program.con.State != ConnectionState.Open) Program.con.Open();

                using (OracleCommand c = new OracleCommand("DELETE FROM tbl_product WHERE product_id = :product_id", Program.con))
                {
                    c.BindByName = true;
                    c.Parameters.Add(new OracleParameter("product_id", product_id));
                    s = c.ExecuteNonQuery();
                }

                DeletePhotoFromDisk(product_id);
            }
            catch (Exception)
            {
                s = -1;
            }
            return s;
        }

        public void SavePhotoToDisk(int productId, byte[] photoBytes)
        {
            try
            {
                string dir = Path.Combine(Application.StartupPath, "Images", "Products");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                string filePath = Path.Combine(dir, $"{productId}.png");
                File.WriteAllBytes(filePath, photoBytes);
            }
            catch { }
        }

        public void DeletePhotoFromDisk(int productId)
        {
            try
            {
                string filePath = Path.Combine(Application.StartupPath, "Images", "Products", $"{productId}.png");
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
            }
            catch { }
        }

        public void SavePhotoToDb(int productId, byte[] photoBytes)
        {
            try
            {
                if (Program.con.State != ConnectionState.Open) Program.con.Open();

                using (OracleCommand c = new OracleCommand("UPDATE tbl_product SET product_image = :img WHERE product_id = :id", Program.con))
                {
                    OracleParameter p = new OracleParameter("img", Oracle.ManagedDataAccess.Client.OracleDbType.Blob);
                    p.Value = (photoBytes != null && photoBytes.Length > 0) ? (object)photoBytes : DBNull.Value;
                    c.Parameters.Add(p);
                    c.Parameters.Add(new OracleParameter("id", productId));
                    c.ExecuteNonQuery();
                }
            }
            catch { }
        }

        public byte[] GetProductPhotoBytes(int productId)
        {
            // Check disk first
            string filePath = Path.Combine(Application.StartupPath, "Images", "Products", $"{productId}.png");
            if (File.Exists(filePath))
            {
                try
                {
                    return File.ReadAllBytes(filePath);
                }
                catch { }
            }

            // Check database
            try
            {
                if (Program.con.State != ConnectionState.Open) Program.con.Open();

                using (OracleCommand c = new OracleCommand("SELECT product_image FROM tbl_product WHERE product_id = :id", Program.con))
                {
                    c.Parameters.Add(new OracleParameter("id", productId));
                    object obj = c.ExecuteScalar();
                    if (obj != null && obj != DBNull.Value)
                    {
                        byte[] bytes = (byte[])obj;
                        // Cache to disk
                        SavePhotoToDisk(productId, bytes);
                        return bytes;
                    }
                }
            }
            catch { }

            return null;
        }
    }
}
