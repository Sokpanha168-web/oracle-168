using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;

namespace POS_204_oracle.Controller
{
    public class DashboardKpis
    {
        public decimal TotalRevenue { get; set; }
        public int TotalOrders { get; set; }
        public int TotalProducts { get; set; }
        public int TotalCustomers { get; set; }
        public int LowStockCount { get; set; }
    }

    public class TopProductItem
    {
        public string ProductName { get; set; }
        public decimal TotalQtySold { get; set; }
        public decimal TotalRevenue { get; set; }
    }

    public class DailySalesPoint
    {
        public string DayLabel { get; set; }
        public DateTime Date { get; set; }
        public decimal Revenue { get; set; }
        public int Orders { get; set; }
    }

    public class DashboardController
    {
        public DashboardKpis GetKpis()
        {
            DashboardKpis kpi = new DashboardKpis();
            try
            {
                // Total revenue & orders
                using (OracleCommand cmd = new OracleCommand("SELECT NVL(SUM(sale_grand_total), 0) AS rev, COUNT(*) AS ord FROM tbl_sale", Program.con))
                using (OracleDataReader r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        kpi.TotalRevenue = r["rev"] != DBNull.Value ? Convert.ToDecimal(r["rev"]) : 0m;
                        kpi.TotalOrders = r["ord"] != DBNull.Value ? Convert.ToInt32(r["ord"]) : 0;
                    }
                }

                // Total products & low stock
                using (OracleCommand cmd = new OracleCommand("SELECT COUNT(*) AS total_p, NVL(SUM(CASE WHEN NVL(is_stock, 0) <= 5 THEN 1 ELSE 0 END), 0) AS low_p FROM tbl_product WHERE product_status = 1", Program.con))
                using (OracleDataReader r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        kpi.TotalProducts = r["total_p"] != DBNull.Value ? Convert.ToInt32(r["total_p"]) : 0;
                        kpi.LowStockCount = r["low_p"] != DBNull.Value ? Convert.ToInt32(r["low_p"]) : 0;
                    }
                }

                // Total customers
                using (OracleCommand cmd = new OracleCommand("SELECT COUNT(*) FROM tbl_customer", Program.con))
                {
                    object cObj = cmd.ExecuteScalar();
                    kpi.TotalCustomers = cObj != null && cObj != DBNull.Value ? Convert.ToInt32(cObj) : 0;
                }
            }
            catch (Exception) { }
            return kpi;
        }

        public DataTable GetRecentSales(int count = 10)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = $"SELECT s.sale_id AS \"Order #\", s.sale_date AS \"Date\", " +
                             $"NVL(c.customer_name, 'Walk-in') AS \"Customer\", " +
                             $"NVL(u.user_name, 'Cashier') AS \"Cashier\", " +
                             $"s.sub_total AS \"Sub Total\", s.sale_discount AS \"Discount\", " +
                             $"s.sale_grand_total AS \"Grand Total ($)\", s.paid AS \"Paid ($)\" " +
                             $"FROM tbl_sale s " +
                             $"LEFT JOIN tbl_customer c ON s.customer_id = c.customer_id " +
                             $"LEFT JOIN tbl_user u ON s.user_id = u.user_id " +
                             $"ORDER BY s.sale_id DESC " +
                             $"FETCH FIRST {count} ROWS ONLY";
                using (OracleCommand cmd = new OracleCommand(sql, Program.con))
                using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            catch (Exception)
            {
                // Fallback for Oracle without FETCH FIRST
                try
                {
                    string sql2 = $"SELECT * FROM (SELECT s.sale_id AS \"Order #\", s.sale_date AS \"Date\", " +
                                  $"NVL(c.customer_name, 'Walk-in') AS \"Customer\", " +
                                  $"NVL(u.user_name, 'Cashier') AS \"Cashier\", " +
                                  $"s.sub_total AS \"Sub Total\", s.sale_discount AS \"Discount\", " +
                                  $"s.sale_grand_total AS \"Grand Total ($)\", s.paid AS \"Paid ($)\" " +
                                  $"FROM tbl_sale s " +
                                  $"LEFT JOIN tbl_customer c ON s.customer_id = c.customer_id " +
                                  $"LEFT JOIN tbl_user u ON s.user_id = u.user_id " +
                                  $"ORDER BY s.sale_id DESC) WHERE ROWNUM <= {count}";
                    using (OracleCommand cmd2 = new OracleCommand(sql2, Program.con))
                    using (OracleDataAdapter da2 = new OracleDataAdapter(cmd2))
                    {
                        da2.Fill(dt);
                    }
                }
                catch { }
            }
            return dt;
        }

        public List<TopProductItem> GetTopProducts(int count = 5)
        {
            List<TopProductItem> list = new List<TopProductItem>();
            try
            {
                string sql = "SELECT NVL(p.product_name, 'Product #' || d.product_id) AS prod_name, " +
                             "SUM(d.sale_qty) AS qty_sold, " +
                             "SUM(d.item_grand_total) AS total_rev " +
                             "FROM tbl_sale_detail d " +
                             "LEFT JOIN tbl_product p ON d.product_id = p.product_id " +
                             "GROUP BY d.product_id, p.product_name " +
                             "ORDER BY qty_sold DESC " +
                             $"FETCH FIRST {count} ROWS ONLY";
                using (OracleCommand cmd = new OracleCommand(sql, Program.con))
                using (OracleDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new TopProductItem
                        {
                            ProductName = r["prod_name"].ToString(),
                            TotalQtySold = r["qty_sold"] != DBNull.Value ? Convert.ToDecimal(r["qty_sold"]) : 0m,
                            TotalRevenue = r["total_rev"] != DBNull.Value ? Convert.ToDecimal(r["total_rev"]) : 0m
                        });
                    }
                }
            }
            catch (Exception)
            {
                // Fallback ROWNUM
                try
                {
                    string sql2 = "SELECT * FROM (SELECT NVL(p.product_name, 'Product #' || d.product_id) AS prod_name, " +
                                  "SUM(d.sale_qty) AS qty_sold, " +
                                  "SUM(d.item_grand_total) AS total_rev " +
                                  "FROM tbl_sale_detail d " +
                                  "LEFT JOIN tbl_product p ON d.product_id = p.product_id " +
                                  "GROUP BY d.product_id, p.product_name " +
                                  $"ORDER BY qty_sold DESC) WHERE ROWNUM <= {count}";
                    using (OracleCommand cmd2 = new OracleCommand(sql2, Program.con))
                    using (OracleDataReader r2 = cmd2.ExecuteReader())
                    {
                        while (r2.Read())
                        {
                            list.Add(new TopProductItem
                            {
                                ProductName = r2["prod_name"].ToString(),
                                TotalQtySold = r2["qty_sold"] != DBNull.Value ? Convert.ToDecimal(r2["qty_sold"]) : 0m,
                                TotalRevenue = r2["total_rev"] != DBNull.Value ? Convert.ToDecimal(r2["total_rev"]) : 0m
                            });
                        }
                    }
                }
                catch { }
            }
            return list;
        }

        public List<DailySalesPoint> GetLast7DaysSales()
        {
            List<DailySalesPoint> points = new List<DailySalesPoint>();
            DateTime today = DateTime.Today;

            // Prepopulate last 7 days
            Dictionary<DateTime, DailySalesPoint> map = new Dictionary<DateTime, DailySalesPoint>();
            for (int i = 6; i >= 0; i--)
            {
                DateTime d = today.AddDays(-i);
                DailySalesPoint pt = new DailySalesPoint
                {
                    Date = d,
                    DayLabel = d.ToString("ddd (MM/dd)"),
                    Revenue = 0m,
                    Orders = 0
                };
                map[d] = pt;
                points.Add(pt);
            }

            try
            {
                DateTime startDate = today.AddDays(-6);
                string sql = "SELECT TRUNC(sale_date) AS s_date, COUNT(*) AS ord_count, NVL(SUM(sale_grand_total), 0) AS rev " +
                             "FROM tbl_sale " +
                             "WHERE sale_date >= :start_date " +
                             "GROUP BY TRUNC(sale_date) " +
                             "ORDER BY s_date ASC";
                using (OracleCommand cmd = new OracleCommand(sql, Program.con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new OracleParameter("start_date", OracleDbType.Date) { Value = startDate });
                    using (OracleDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            DateTime dt = Convert.ToDateTime(r["s_date"]).Date;
                            if (map.ContainsKey(dt))
                            {
                                map[dt].Revenue = Convert.ToDecimal(r["rev"]);
                                map[dt].Orders = Convert.ToInt32(r["ord_count"]);
                            }
                        }
                    }
                }
            }
            catch (Exception) { }

            return points;
        }
    }
}
