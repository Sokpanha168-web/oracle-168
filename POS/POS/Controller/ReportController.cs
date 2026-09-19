using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.IO;
using System.Text;

namespace POS_204_oracle.Controller
{
    public class SalesReportSummary
    {
        public decimal TotalRevenue { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal NetSales { get; set; }
        public int TotalOrders { get; set; }
        public decimal AverageOrderValue { get; set; }
        public decimal TotalItemsSold { get; set; }
    }

    public class InventoryReportSummary
    {
        public int TotalProducts { get; set; }
        public int TotalInStock { get; set; }
        public int TotalLowStock { get; set; }
        public int TotalOutOfStock { get; set; }
        public decimal TotalValuationCost { get; set; }
        public decimal TotalValuationRetail { get; set; }
    }

    public class ReportController
    {
        public DataTable GetSalesReport(DateTime fromDate, DateTime toDate, int? customerId = null)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT s.sale_id AS \"Order ID\", " +
                             "TO_CHAR(s.sale_date, 'YYYY-MM-DD HH24:MI') AS \"Date\", " +
                             "NVL(c.customer_name, 'Walk-in') AS \"Customer\", " +
                             "NVL(u.user_name, 'Cashier') AS \"Cashier\", " +
                             "NVL(SUM(d.sale_qty), 0) AS \"Items Sold\", " +
                             "s.sub_total AS \"Sub Total ($)\", " +
                             "s.sale_discount AS \"Discount ($)\", " +
                             "s.sale_grand_total AS \"Grand Total ($)\", " +
                             "s.paid AS \"Paid ($)\" " +
                             "FROM tbl_sale s " +
                             "LEFT JOIN tbl_customer c ON s.customer_id = c.customer_id " +
                             "LEFT JOIN tbl_user u ON s.user_id = u.user_id " +
                             "LEFT JOIN tbl_sale_detail d ON s.sale_id = d.sale_id " +
                             "WHERE s.sale_date >= :from_d AND s.sale_date <= :to_d ";

                if (customerId.HasValue && customerId.Value > 0)
                {
                    sql += " AND s.customer_id = :cust_id ";
                }

                sql += "GROUP BY s.sale_id, s.sale_date, c.customer_name, u.user_name, s.sub_total, s.sale_discount, s.sale_grand_total, s.paid " +
                       "ORDER BY s.sale_id DESC";

                using (OracleCommand cmd = new OracleCommand(sql, Program.con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new OracleParameter("from_d", OracleDbType.Date) { Value = fromDate.Date });
                    cmd.Parameters.Add(new OracleParameter("to_d", OracleDbType.Date) { Value = toDate.Date.AddDays(1).AddSeconds(-1) });
                    if (customerId.HasValue && customerId.Value > 0)
                    {
                        cmd.Parameters.Add(new OracleParameter("cust_id", customerId.Value));
                    }

                    using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception) { }
            return dt;
        }

        public SalesReportSummary GetSalesSummary(DateTime fromDate, DateTime toDate, int? customerId = null)
        {
            SalesReportSummary summary = new SalesReportSummary();
            try
            {
                string sql = "SELECT COUNT(DISTINCT s.sale_id) AS ord_cnt, " +
                             "NVL(SUM(s.sub_total), 0) AS sub_tot, " +
                             "NVL(SUM(s.sale_discount), 0) AS disc_tot, " +
                             "NVL(SUM(s.sale_grand_total), 0) AS grand_tot, " +
                             "NVL(SUM(d.sale_qty), 0) AS items_tot " +
                             "FROM tbl_sale s " +
                             "LEFT JOIN tbl_sale_detail d ON s.sale_id = d.sale_id " +
                             "WHERE s.sale_date >= :from_d AND s.sale_date <= :to_d ";

                if (customerId.HasValue && customerId.Value > 0)
                {
                    sql += " AND s.customer_id = :cust_id ";
                }

                using (OracleCommand cmd = new OracleCommand(sql, Program.con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new OracleParameter("from_d", OracleDbType.Date) { Value = fromDate.Date });
                    cmd.Parameters.Add(new OracleParameter("to_d", OracleDbType.Date) { Value = toDate.Date.AddDays(1).AddSeconds(-1) });
                    if (customerId.HasValue && customerId.Value > 0)
                    {
                        cmd.Parameters.Add(new OracleParameter("cust_id", customerId.Value));
                    }

                    using (OracleDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            summary.TotalOrders = r["ord_cnt"] != DBNull.Value ? Convert.ToInt32(r["ord_cnt"]) : 0;
                            summary.TotalRevenue = r["sub_tot"] != DBNull.Value ? Convert.ToDecimal(r["sub_tot"]) : 0m;
                            summary.TotalDiscount = r["disc_tot"] != DBNull.Value ? Convert.ToDecimal(r["disc_tot"]) : 0m;
                            summary.NetSales = r["grand_tot"] != DBNull.Value ? Convert.ToDecimal(r["grand_tot"]) : 0m;
                            summary.TotalItemsSold = r["items_tot"] != DBNull.Value ? Convert.ToDecimal(r["items_tot"]) : 0m;
                            summary.AverageOrderValue = summary.TotalOrders > 0 ? (summary.NetSales / summary.TotalOrders) : 0m;
                        }
                    }
                }
            }
            catch (Exception) { }
            return summary;
        }

        public DataTable GetInventoryReport()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT p.product_id AS \"Product ID\", " +
                             "p.product_name AS \"Product Name\", " +
                             "NVL(c.category_name, 'None') AS \"Category\", " +
                             "NVL(s.supplier_name, 'None') AS \"Supplier\", " +
                             "NVL(p.is_stock, 0) AS \"Stock Qty\", " +
                             "NVL(p.product_cost, 0) AS \"Unit Cost ($)\", " +
                             "NVL(p.product_price, 0) AS \"Sale Price ($)\", " +
                             "(NVL(p.is_stock, 0) * NVL(p.product_cost, 0)) AS \"Valuation (Cost)\", " +
                             "(NVL(p.is_stock, 0) * NVL(p.product_price, 0)) AS \"Valuation (Retail)\", " +
                             "CASE " +
                             "  WHEN NVL(p.is_stock, 0) <= 0 THEN 'Out of Stock' " +
                             "  WHEN NVL(p.is_stock, 0) <= 5 THEN 'Low Stock' " +
                             "  ELSE 'In Stock' " +
                             "END AS \"Status\" " +
                             "FROM tbl_product p " +
                             "LEFT JOIN tbl_category c ON p.category_id = c.category_id " +
                             "LEFT JOIN tbl_supplier s ON p.supplier_id = s.supplier_id " +
                             "WHERE p.product_status = 1 " +
                             "ORDER BY p.product_name ASC";
                using (OracleCommand cmd = new OracleCommand(sql, Program.con))
                using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            catch (Exception) { }
            return dt;
        }

        public InventoryReportSummary GetInventorySummary()
        {
            InventoryReportSummary summary = new InventoryReportSummary();
            try
            {
                string sql = "SELECT COUNT(*) AS total_p, " +
                             "NVL(SUM(CASE WHEN NVL(is_stock, 0) > 5 THEN 1 ELSE 0 END), 0) AS in_stk, " +
                             "NVL(SUM(CASE WHEN NVL(is_stock, 0) > 0 AND NVL(is_stock, 0) <= 5 THEN 1 ELSE 0 END), 0) AS low_stk, " +
                             "NVL(SUM(CASE WHEN NVL(is_stock, 0) <= 0 THEN 1 ELSE 0 END), 0) AS out_stk, " +
                             "NVL(SUM(NVL(is_stock, 0) * NVL(product_cost, 0)), 0) AS cost_val, " +
                             "NVL(SUM(NVL(is_stock, 0) * NVL(product_price, 0)), 0) AS retail_val " +
                             "FROM tbl_product WHERE product_status = 1";
                using (OracleCommand cmd = new OracleCommand(sql, Program.con))
                using (OracleDataReader r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        summary.TotalProducts = r["total_p"] != DBNull.Value ? Convert.ToInt32(r["total_p"]) : 0;
                        summary.TotalInStock = r["in_stk"] != DBNull.Value ? Convert.ToInt32(r["in_stk"]) : 0;
                        summary.TotalLowStock = r["low_stk"] != DBNull.Value ? Convert.ToInt32(r["low_stk"]) : 0;
                        summary.TotalOutOfStock = r["out_stk"] != DBNull.Value ? Convert.ToInt32(r["out_stk"]) : 0;
                        summary.TotalValuationCost = r["cost_val"] != DBNull.Value ? Convert.ToDecimal(r["cost_val"]) : 0m;
                        summary.TotalValuationRetail = r["retail_val"] != DBNull.Value ? Convert.ToDecimal(r["retail_val"]) : 0m;
                    }
                }
            }
            catch (Exception) { }
            return summary;
        }

        public DataTable GetCustomerReport()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT c.customer_id AS \"Customer ID\", " +
                             "c.customer_name AS \"Customer Name\", " +
                             "c.customer_phone AS \"Phone\", " +
                             "c.customer_email AS \"Email\", " +
                             "COUNT(s.sale_id) AS \"Orders Placed\", " +
                             "NVL(SUM(s.sale_grand_total), 0) AS \"Total Spent ($)\", " +
                             "ROUND(NVL(AVG(s.sale_grand_total), 0), 2) AS \"Avg Order ($)\", " +
                             "TO_CHAR(MAX(s.sale_date), 'YYYY-MM-DD') AS \"Last Purchase\" " +
                             "FROM tbl_customer c " +
                             "LEFT JOIN tbl_sale s ON c.customer_id = s.customer_id " +
                             "GROUP BY c.customer_id, c.customer_name, c.customer_phone, c.customer_email " +
                             "ORDER BY \"Total Spent ($)\" DESC";
                using (OracleCommand cmd = new OracleCommand(sql, Program.con))
                using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            catch (Exception) { }
            return dt;
        }

        public static bool ExportToCsv(DataTable dt, string filePath)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                // Headers
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    string colName = dt.Columns[i].ColumnName.Replace("\"", "\"\"");
                    sb.Append($"\"{colName}\"");
                    if (i < dt.Columns.Count - 1) sb.Append(",");
                }
                sb.AppendLine();

                // Rows
                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        string val = row[i]?.ToString()?.Replace("\"", "\"\"") ?? "";
                        sb.Append($"\"{val}\"");
                        if (i < dt.Columns.Count - 1) sb.Append(",");
                    }
                    sb.AppendLine();
                }

                File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
