using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace POS_204_oracle.Controller
{
    public class CustomerStats
    {
        public int TotalOrders { get; set; }
        public decimal TotalSpent { get; set; }
        public DateTime? LastOrderDate { get; set; }
    }

    public class CustomerController
    {
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT customer_id, customer_name, customer_phone, customer_email, customer_address, customer_notes " +
                             "FROM tbl_customer ORDER BY customer_id DESC";
                using (OracleCommand cmd = new OracleCommand(sql, Program.con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception)
            {
                // Fallback in case optional columns do not exist
                try
                {
                    using (OracleCommand cmd = new OracleCommand("SELECT customer_id, customer_name, customer_notes FROM tbl_customer ORDER BY customer_id DESC", Program.con))
                    using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                catch (Exception) { }
            }
            return dt;
        }

        public int Insert(string customer_name, string customer_phone, string customer_email, string customer_address, string customer_notes)
        {
            int result = 0;
            try
            {
                string sql = "INSERT INTO tbl_customer(customer_name, customer_phone, customer_email, customer_address, customer_notes) " +
                             "VALUES (:customer_name, :customer_phone, :customer_email, :customer_address, :customer_notes)";
                using (OracleCommand cmd = new OracleCommand(sql, Program.con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new OracleParameter("customer_name", customer_name ?? ""));
                    cmd.Parameters.Add(new OracleParameter("customer_phone", string.IsNullOrEmpty(customer_phone) ? (object)DBNull.Value : customer_phone));
                    cmd.Parameters.Add(new OracleParameter("customer_email", string.IsNullOrEmpty(customer_email) ? (object)DBNull.Value : customer_email));
                    cmd.Parameters.Add(new OracleParameter("customer_address", string.IsNullOrEmpty(customer_address) ? (object)DBNull.Value : customer_address));
                    cmd.Parameters.Add(new OracleParameter("customer_notes", string.IsNullOrEmpty(customer_notes) ? (object)DBNull.Value : customer_notes));
                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                // Fallback for base columns
                try
                {
                    using (OracleCommand cmd = new OracleCommand("INSERT INTO tbl_customer(customer_name, customer_notes) VALUES (:customer_name, :customer_notes)", Program.con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add(new OracleParameter("customer_name", customer_name ?? ""));
                        cmd.Parameters.Add(new OracleParameter("customer_notes", string.IsNullOrEmpty(customer_notes) ? (object)DBNull.Value : customer_notes));
                        result = cmd.ExecuteNonQuery();
                    }
                }
                catch { result = -1; }
            }
            return result;
        }

        // Overload for backward compatibility
        public int Insert(string customer_name, string customer_notes)
        {
            return Insert(customer_name, null, null, null, customer_notes);
        }

        public int Update(int customer_id, string customer_name, string customer_phone, string customer_email, string customer_address, string customer_notes)
        {
            int result = 0;
            try
            {
                string sql = "UPDATE tbl_customer SET " +
                             "customer_name = :customer_name, " +
                             "customer_phone = :customer_phone, " +
                             "customer_email = :customer_email, " +
                             "customer_address = :customer_address, " +
                             "customer_notes = :customer_notes " +
                             "WHERE customer_id = :customer_id";
                using (OracleCommand cmd = new OracleCommand(sql, Program.con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new OracleParameter("customer_name", customer_name ?? ""));
                    cmd.Parameters.Add(new OracleParameter("customer_phone", string.IsNullOrEmpty(customer_phone) ? (object)DBNull.Value : customer_phone));
                    cmd.Parameters.Add(new OracleParameter("customer_email", string.IsNullOrEmpty(customer_email) ? (object)DBNull.Value : customer_email));
                    cmd.Parameters.Add(new OracleParameter("customer_address", string.IsNullOrEmpty(customer_address) ? (object)DBNull.Value : customer_address));
                    cmd.Parameters.Add(new OracleParameter("customer_notes", string.IsNullOrEmpty(customer_notes) ? (object)DBNull.Value : customer_notes));
                    cmd.Parameters.Add(new OracleParameter("customer_id", customer_id));
                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                try
                {
                    using (OracleCommand cmd = new OracleCommand("UPDATE tbl_customer SET customer_name = :customer_name, customer_notes = :customer_notes WHERE customer_id = :customer_id", Program.con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add(new OracleParameter("customer_name", customer_name ?? ""));
                        cmd.Parameters.Add(new OracleParameter("customer_notes", string.IsNullOrEmpty(customer_notes) ? (object)DBNull.Value : customer_notes));
                        cmd.Parameters.Add(new OracleParameter("customer_id", customer_id));
                        result = cmd.ExecuteNonQuery();
                    }
                }
                catch { result = -1; }
            }
            return result;
        }

        // Overload for backward compatibility
        public int Update(int customer_id, string customer_name, string customer_notes)
        {
            return Update(customer_id, customer_name, null, null, null, customer_notes);
        }

        public int Delete(int customer_id)
        {
            int result = 0;
            try
            {
                using (OracleCommand cmd = new OracleCommand("DELETE FROM tbl_customer WHERE customer_id = :customer_id", Program.con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new OracleParameter("customer_id", customer_id));
                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                result = -1;
            }
            return result;
        }

        public DataTable Search(string keyword)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT customer_id, customer_name, customer_phone, customer_email, customer_address, customer_notes " +
                             "FROM tbl_customer " +
                             "WHERE UPPER(customer_name) LIKE :kw " +
                             "   OR UPPER(NVL(customer_phone, ' ')) LIKE :kw " +
                             "   OR UPPER(NVL(customer_email, ' ')) LIKE :kw " +
                             "   OR UPPER(NVL(customer_address, ' ')) LIKE :kw " +
                             "ORDER BY customer_id DESC";
                using (OracleCommand cmd = new OracleCommand(sql, Program.con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new OracleParameter("kw", "%" + (keyword ?? "").Trim().ToUpper() + "%"));
                    using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception)
            {
                try
                {
                    using (OracleCommand cmd = new OracleCommand("SELECT customer_id, customer_name, customer_notes FROM tbl_customer WHERE UPPER(customer_name) LIKE :kw ORDER BY customer_id DESC", Program.con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add(new OracleParameter("kw", "%" + (keyword ?? "").Trim().ToUpper() + "%"));
                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
                catch { }
            }
            return dt;
        }

        public CustomerStats GetCustomerStats(int customerId)
        {
            CustomerStats stats = new CustomerStats();
            try
            {
                string sql = "SELECT COUNT(sale_id) AS total_orders, " +
                             "NVL(SUM(sale_grand_total), 0) AS total_spent, " +
                             "MAX(sale_date) AS last_order_date " +
                             "FROM tbl_sale WHERE customer_id = :customer_id";
                using (OracleCommand cmd = new OracleCommand(sql, Program.con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new OracleParameter("customer_id", customerId));
                    using (OracleDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            stats.TotalOrders = r["total_orders"] != DBNull.Value ? Convert.ToInt32(r["total_orders"]) : 0;
                            stats.TotalSpent = r["total_spent"] != DBNull.Value ? Convert.ToDecimal(r["total_spent"]) : 0m;
                            if (r["last_order_date"] != DBNull.Value)
                            {
                                stats.LastOrderDate = Convert.ToDateTime(r["last_order_date"]);
                            }
                        }
                    }
                }
            }
            catch (Exception) { }
            return stats;
        }
    }
}
