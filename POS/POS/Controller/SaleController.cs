using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;

namespace POS_204_oracle.Controller
{
    public class SaleItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Qty { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal ItemSubTotal { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal ItemGrandTotal { get; set; }
    }

    public class SaleReceipt
    {
        public int SaleId { get; set; }
        public DateTime SaleDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CashierName { get; set; }
        public decimal SubTotal { get; set; }
        public decimal SaleDiscount { get; set; }
        public decimal GrandTotalUSD { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal GrandTotalKHR { get; set; }
        public decimal Paid { get; set; }
        public decimal ChangeUSD { get; set; }
        public decimal ChangeKHR { get; set; }
        public string SaleNotes { get; set; }
        public List<SaleItem> Items { get; set; } = new List<SaleItem>();
    }

    public class SaleController
    {
        public SaleController()
        {
            EnsureSaleSchema();
        }

        public static void EnsureSaleSchema()
        {
            try
            {
                if (Program.con.State != ConnectionState.Open)
                {
                    Program.con.Open();
                }
                using (OracleCommand cmd = Program.con.CreateCommand())
                {
                    try
                    {
                        cmd.CommandText = "ALTER TABLE tbl_sale MODIFY paid NUMBER(12, 2)";
                        cmd.ExecuteNonQuery();
                    }
                    catch { }

                    try
                    {
                        cmd.CommandText = "ALTER TABLE tbl_sale MODIFY customer_id NULL";
                        cmd.ExecuteNonQuery();
                    }
                    catch { }
                }
            }
            catch { }
        }

        public DataTable GetAllSales()
        {
            return GetSalesFiltered(null, null, null, null);
        }

        public DataTable GetSalesFiltered(DateTime? fromDate, DateTime? toDate, int? customerId, string search)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT s.sale_id, s.sale_date, NVL(c.customer_name, 'Walk-in') AS customer_name, " +
                             "NVL(u.user_name, 'System') AS cashier, s.sub_total, s.sale_discount, " +
                             "s.sale_grand_total, s.paid, s.exchange_rate, s.sale_notes " +
                             "FROM tbl_sale s " +
                             "LEFT JOIN tbl_customer c ON s.customer_id = c.customer_id " +
                             "LEFT JOIN tbl_user u ON s.user_id = u.user_id " +
                             "WHERE 1=1 ";

                List<OracleParameter> parameters = new List<OracleParameter>();

                if (fromDate.HasValue)
                {
                    sql += " AND s.sale_date >= :p_from_date ";
                    parameters.Add(new OracleParameter("p_from_date", OracleDbType.Date) { Value = fromDate.Value.Date });
                }
                if (toDate.HasValue)
                {
                    sql += " AND s.sale_date <= :p_to_date ";
                    parameters.Add(new OracleParameter("p_to_date", OracleDbType.Date) { Value = toDate.Value.Date.AddDays(1).AddSeconds(-1) });
                }
                if (customerId.HasValue && customerId.Value > 0)
                {
                    sql += " AND s.customer_id = :p_cust_id ";
                    parameters.Add(new OracleParameter("p_cust_id", customerId.Value));
                }
                if (!string.IsNullOrWhiteSpace(search))
                {
                    sql += " AND (TO_CHAR(s.sale_id) LIKE :p_search OR UPPER(c.customer_name) LIKE :p_search OR UPPER(u.user_name) LIKE :p_search) ";
                    parameters.Add(new OracleParameter("p_search", "%" + search.Trim().ToUpper() + "%"));
                }

                sql += " ORDER BY s.sale_id DESC";

                using (OracleCommand cmd = new OracleCommand(sql, Program.con))
                {
                    cmd.BindByName = true;
                    cmd.CommandType = CommandType.Text;
                    foreach (var p in parameters)
                    {
                        cmd.Parameters.Add(p);
                    }
                    using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception)
            {
            }
            return dt;
        }

        public DataTable GetSaleDetails(int saleId)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT d.sale_detail_id, d.sale_id, d.product_id, NVL(p.product_name, 'Product #' || d.product_id) AS product_name, " +
                             "d.sale_qty, d.sale_price, d.item_discount, d.item_sub_total, " +
                             "d.discoun_amount, d.item_grand_total " +
                             "FROM tbl_sale_detail d " +
                             "LEFT JOIN tbl_product p ON d.product_id = p.product_id " +
                             "WHERE d.sale_id = :p_sale_id " +
                             "ORDER BY d.sale_detail_id ASC";
                using (OracleCommand cmd = new OracleCommand(sql, Program.con))
                {
                    cmd.BindByName = true;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new OracleParameter("p_sale_id", saleId));
                    using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception)
            {
            }
            return dt;
        }

        public DataTable GetActiveProducts()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT p.product_id, p.product_name, p.product_price, p.product_cost, " +
                             "NVL(p.is_stock, 0) AS is_stock, p.product_status, " +
                             "p.category_id, NVL(c.category_name, 'General') AS category_name " +
                             "FROM tbl_product p " +
                             "LEFT JOIN tbl_category c ON p.category_id = c.category_id " +
                             "WHERE p.product_status = 1 ORDER BY p.product_name ASC";
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
            }
            return dt;
        }

        public DataTable GetCategories()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT category_id, category_name FROM tbl_category WHERE category_status = 1 ORDER BY category_name ASC";
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
            }
            return dt;
        }

        public DataTable GetCustomers()
        {
            DataTable dt = new DataTable();
            try
            {
                using (OracleCommand cmd = new OracleCommand("SELECT customer_id, customer_name FROM tbl_customer ORDER BY customer_name ASC", Program.con))
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
            }
            return dt;
        }

        public int InsertSale(
            DateTime saleDate,
            int customerId,
            string saleNotes,
            decimal exchangeRate,
            int userId,
            decimal subTotal,
            decimal saleDiscount,
            decimal grandTotal,
            decimal paid,
            List<SaleItem> items,
            out string errorMessage)
        {
            errorMessage = "";
            if (items == null || items.Count == 0)
            {
                errorMessage = "Cart is empty. Please add items to sale.";
                return -1;
            }

            if (Program.con.State != ConnectionState.Open)
            {
                Program.con.Open();
            }

            using (OracleTransaction tran = Program.con.BeginTransaction())
            {
                try
                {
                    int newSaleId = 0;

                    int validUserId = 0;
                    if (userId > 0)
                    {
                        using (OracleCommand cmdChk = new OracleCommand("SELECT COUNT(*) FROM tbl_user WHERE user_id = :p_uid", Program.con))
                        {
                            cmdChk.Transaction = tran;
                            cmdChk.BindByName = true;
                            cmdChk.Parameters.Add(new OracleParameter("p_uid", userId));
                            if (Convert.ToInt32(cmdChk.ExecuteScalar()) > 0)
                            {
                                validUserId = userId;
                            }
                        }
                    }

                    if (validUserId <= 0)
                    {
                        using (OracleCommand cmdU = new OracleCommand("SELECT NVL(MIN(user_id), 0) FROM tbl_user", Program.con))
                        {
                            cmdU.Transaction = tran;
                            object uObj = cmdU.ExecuteScalar();
                            if (uObj != null && uObj != DBNull.Value)
                            {
                                validUserId = Convert.ToInt32(uObj);
                            }
                        }
                    }
                    userId = validUserId;

                    string insertSaleSql = "INSERT INTO tbl_sale (" +
                        "sale_date, customer_id, sale_notes, exchange_rate, user_id, " +
                        "sub_total, sale_discount, sale_grand_total, paid" +
                        ") VALUES (" +
                        ":p_sale_date, :p_customer_id, :p_sale_notes, :p_exchange_rate, :p_user_id, " +
                        ":p_sub_total, :p_sale_discount, :p_grand_total, :p_paid" +
                        ") RETURNING sale_id INTO :p_sale_id";

                    using (OracleCommand cmdSale = new OracleCommand(insertSaleSql, Program.con))
                    {
                        cmdSale.Transaction = tran;
                        cmdSale.BindByName = true;
                        cmdSale.CommandType = CommandType.Text;
                        cmdSale.Parameters.Add(new OracleParameter("p_sale_date", OracleDbType.Date) { Value = saleDate });
                        cmdSale.Parameters.Add(new OracleParameter("p_customer_id", customerId > 0 ? (object)customerId : DBNull.Value));
                        cmdSale.Parameters.Add(new OracleParameter("p_sale_notes", string.IsNullOrEmpty(saleNotes) ? (object)DBNull.Value : saleNotes));
                        cmdSale.Parameters.Add(new OracleParameter("p_exchange_rate", exchangeRate));
                        cmdSale.Parameters.Add(new OracleParameter("p_user_id", userId));
                        cmdSale.Parameters.Add(new OracleParameter("p_sub_total", subTotal));
                        cmdSale.Parameters.Add(new OracleParameter("p_sale_discount", saleDiscount));
                        cmdSale.Parameters.Add(new OracleParameter("p_grand_total", grandTotal));
                        cmdSale.Parameters.Add(new OracleParameter("p_paid", paid));

                        OracleParameter pSaleId = new OracleParameter("p_sale_id", OracleDbType.Decimal, ParameterDirection.Output);
                        cmdSale.Parameters.Add(pSaleId);

                        cmdSale.ExecuteNonQuery();

                        if (pSaleId.Value != null && pSaleId.Value != DBNull.Value)
                        {
                            newSaleId = Convert.ToInt32(pSaleId.Value.ToString());
                        }
                    }

                    if (newSaleId <= 0)
                    {
                        using (OracleCommand cmdMax = new OracleCommand("SELECT NVL(MAX(sale_id), 0) FROM tbl_sale", Program.con))
                        {
                            cmdMax.Transaction = tran;
                            newSaleId = Convert.ToInt32(cmdMax.ExecuteScalar());
                        }
                    }

                    string insertDetailSql = "INSERT INTO tbl_sale_detail (" +
                        "sale_id, product_id, sale_qty, sale_price, item_discount, " +
                        "item_sub_total, discoun_amount, item_grand_total" +
                        ") VALUES (" +
                        ":p_sale_id, :p_product_id, :p_sale_qty, :p_sale_price, :p_item_discount, " +
                        ":p_item_sub_total, :p_discount_amount, :p_item_grand_total" +
                        ")";

                    string deductStockSql = "UPDATE tbl_product SET is_stock = GREATEST(0, NVL(is_stock, 0) - :p_qty) WHERE product_id = :p_product_id";

                    foreach (var item in items)
                    {
                        using (OracleCommand cmdDetail = new OracleCommand(insertDetailSql, Program.con))
                        {
                            cmdDetail.Transaction = tran;
                            cmdDetail.BindByName = true;
                            cmdDetail.CommandType = CommandType.Text;
                            cmdDetail.Parameters.Add(new OracleParameter("p_sale_id", newSaleId));
                            cmdDetail.Parameters.Add(new OracleParameter("p_product_id", item.ProductId));
                            cmdDetail.Parameters.Add(new OracleParameter("p_sale_qty", item.Qty));
                            cmdDetail.Parameters.Add(new OracleParameter("p_sale_price", item.Price));
                            cmdDetail.Parameters.Add(new OracleParameter("p_item_discount", item.DiscountPercent));
                            cmdDetail.Parameters.Add(new OracleParameter("p_item_sub_total", item.ItemSubTotal));
                            cmdDetail.Parameters.Add(new OracleParameter("p_discount_amount", item.DiscountAmount));
                            cmdDetail.Parameters.Add(new OracleParameter("p_item_grand_total", item.ItemGrandTotal));

                            cmdDetail.ExecuteNonQuery();
                        }

                        // Deduct stock in real-time
                        try
                        {
                            using (OracleCommand cmdStock = new OracleCommand(deductStockSql, Program.con))
                            {
                                cmdStock.Transaction = tran;
                                cmdStock.BindByName = true;
                                cmdStock.CommandType = CommandType.Text;
                                cmdStock.Parameters.Add(new OracleParameter("p_qty", item.Qty));
                                cmdStock.Parameters.Add(new OracleParameter("p_product_id", item.ProductId));
                                cmdStock.ExecuteNonQuery();
                            }

                            try
                            {
                                StockController.EnsureStockTables();
                                decimal balanceAfter = 0;
                                using (OracleCommand cmdBal = new OracleCommand("SELECT NVL(is_stock, 0) FROM tbl_product WHERE product_id = :p_bal_pid", Program.con))
                                {
                                    cmdBal.Transaction = tran;
                                    cmdBal.BindByName = true;
                                    cmdBal.Parameters.Add(new OracleParameter("p_bal_pid", item.ProductId));
                                    object bObj = cmdBal.ExecuteScalar();
                                    if (bObj != null && bObj != DBNull.Value) balanceAfter = Convert.ToDecimal(bObj);
                                }

                                int nextTrId = 1;
                                using (OracleCommand cmdTrMax = new OracleCommand("SELECT NVL(MAX(trans_id), 0) + 1 FROM tbl_stock_transaction", Program.con))
                                {
                                    cmdTrMax.Transaction = tran;
                                    nextTrId = Convert.ToInt32(cmdTrMax.ExecuteScalar());
                                }

                                string insertStockLog = @"INSERT INTO tbl_stock_transaction 
                                    (trans_id, trans_date, product_id, trans_type, qty, unit_cost, total_cost, user_id, ref_no, notes, balance_after) 
                                    VALUES 
                                    (:p_trans_id, SYSDATE, :p_product_id, 'SALE OUT', :p_qty, :p_unit_cost, :p_total_cost, :p_user_id, :p_ref_no, :p_notes, :p_balance_after)";

                                using (OracleCommand cmdLog = new OracleCommand(insertStockLog, Program.con))
                                {
                                    cmdLog.Transaction = tran;
                                    cmdLog.BindByName = true;
                                    cmdLog.Parameters.Add(new OracleParameter("p_trans_id", nextTrId));
                                    cmdLog.Parameters.Add(new OracleParameter("p_product_id", item.ProductId));
                                    cmdLog.Parameters.Add(new OracleParameter("p_qty", -1 * item.Qty));
                                    cmdLog.Parameters.Add(new OracleParameter("p_unit_cost", item.Price));
                                    cmdLog.Parameters.Add(new OracleParameter("p_total_cost", item.ItemGrandTotal));
                                    cmdLog.Parameters.Add(new OracleParameter("p_user_id", userId > 0 ? (object)userId : DBNull.Value));
                                    cmdLog.Parameters.Add(new OracleParameter("p_ref_no", "SO-" + newSaleId.ToString()));
                                    cmdLog.Parameters.Add(new OracleParameter("p_notes", $"POS Sale #{newSaleId} to Customer #{customerId}"));
                                    cmdLog.Parameters.Add(new OracleParameter("p_balance_after", balanceAfter));
                                    cmdLog.ExecuteNonQuery();
                                }
                            }
                            catch { }
                        }
                        catch { }
                    }

                    tran.Commit();
                    return newSaleId;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    errorMessage = ex.Message;
                    return -1;
                }
            }
        }

        public int UpdateSale(
            int saleId,
            DateTime saleDate,
            int customerId,
            string saleNotes,
            decimal exchangeRate,
            decimal subTotal,
            decimal saleDiscount,
            decimal grandTotal,
            decimal paid,
            List<SaleItem> items,
            out string errorMessage)
        {
            errorMessage = "";
            if (items == null || items.Count == 0)
            {
                errorMessage = "Sale must contain at least one item.";
                return -1;
            }

            if (Program.con.State != ConnectionState.Open)
            {
                Program.con.Open();
            }

            using (OracleTransaction tran = Program.con.BeginTransaction())
            {
                try
                {
                    // 1. Restore stock of previous items in this sale
                    DataTable dtOld = new DataTable();
                    using (OracleCommand cmdOld = new OracleCommand("SELECT product_id, sale_qty FROM tbl_sale_detail WHERE sale_id = :p_sale_id", Program.con))
                    {
                        cmdOld.Transaction = tran;
                        cmdOld.BindByName = true;
                        cmdOld.Parameters.Add(new OracleParameter("p_sale_id", saleId));
                        using (OracleDataAdapter da = new OracleDataAdapter(cmdOld))
                        {
                            da.Fill(dtOld);
                        }
                    }

                    foreach (DataRow r in dtOld.Rows)
                    {
                        int pid = Convert.ToInt32(r["product_id"]);
                        decimal qty = Convert.ToDecimal(r["sale_qty"]);
                        using (OracleCommand cmdRest = new OracleCommand("UPDATE tbl_product SET is_stock = NVL(is_stock, 0) + :p_qty WHERE product_id = :p_pid", Program.con))
                        {
                            cmdRest.Transaction = tran;
                            cmdRest.BindByName = true;
                            cmdRest.Parameters.Add(new OracleParameter("p_qty", qty));
                            cmdRest.Parameters.Add(new OracleParameter("p_pid", pid));
                            cmdRest.ExecuteNonQuery();
                        }
                    }

                    // 2. Delete old sale detail rows
                    using (OracleCommand cmdDel = new OracleCommand("DELETE FROM tbl_sale_detail WHERE sale_id = :p_sale_id", Program.con))
                    {
                        cmdDel.Transaction = tran;
                        cmdDel.BindByName = true;
                        cmdDel.Parameters.Add(new OracleParameter("p_sale_id", saleId));
                        cmdDel.ExecuteNonQuery();
                    }

                    // 3. Update tbl_sale
                    string updateSaleSql = "UPDATE tbl_sale SET " +
                        "sale_date = :p_sale_date, " +
                        "customer_id = :p_customer_id, " +
                        "sale_notes = :p_sale_notes, " +
                        "exchange_rate = :p_exchange_rate, " +
                        "sub_total = :p_sub_total, " +
                        "sale_discount = :p_sale_discount, " +
                        "sale_grand_total = :p_grand_total, " +
                        "paid = :p_paid " +
                        "WHERE sale_id = :p_sale_id";

                    using (OracleCommand cmdUpd = new OracleCommand(updateSaleSql, Program.con))
                    {
                        cmdUpd.Transaction = tran;
                        cmdUpd.BindByName = true;
                        cmdUpd.Parameters.Add(new OracleParameter("p_sale_date", OracleDbType.Date) { Value = saleDate });
                        cmdUpd.Parameters.Add(new OracleParameter("p_customer_id", customerId > 0 ? (object)customerId : DBNull.Value));
                        cmdUpd.Parameters.Add(new OracleParameter("p_sale_notes", string.IsNullOrEmpty(saleNotes) ? (object)DBNull.Value : saleNotes));
                        cmdUpd.Parameters.Add(new OracleParameter("p_exchange_rate", exchangeRate));
                        cmdUpd.Parameters.Add(new OracleParameter("p_sub_total", subTotal));
                        cmdUpd.Parameters.Add(new OracleParameter("p_sale_discount", saleDiscount));
                        cmdUpd.Parameters.Add(new OracleParameter("p_grand_total", grandTotal));
                        cmdUpd.Parameters.Add(new OracleParameter("p_paid", paid));
                        cmdUpd.Parameters.Add(new OracleParameter("p_sale_id", saleId));
                        cmdUpd.ExecuteNonQuery();
                    }

                    // 4. Insert new items and deduct new stock
                    string insertDetailSql = "INSERT INTO tbl_sale_detail (" +
                        "sale_id, product_id, sale_qty, sale_price, item_discount, " +
                        "item_sub_total, discoun_amount, item_grand_total" +
                        ") VALUES (" +
                        ":p_sale_id, :p_product_id, :p_sale_qty, :p_sale_price, :p_item_discount, " +
                        ":p_item_sub_total, :p_discount_amount, :p_item_grand_total" +
                        ")";

                    string deductStockSql = "UPDATE tbl_product SET is_stock = GREATEST(0, NVL(is_stock, 0) - :p_qty) WHERE product_id = :p_product_id";

                    foreach (var item in items)
                    {
                        using (OracleCommand cmdDetail = new OracleCommand(insertDetailSql, Program.con))
                        {
                            cmdDetail.Transaction = tran;
                            cmdDetail.BindByName = true;
                            cmdDetail.Parameters.Add(new OracleParameter("p_sale_id", saleId));
                            cmdDetail.Parameters.Add(new OracleParameter("p_product_id", item.ProductId));
                            cmdDetail.Parameters.Add(new OracleParameter("p_sale_qty", item.Qty));
                            cmdDetail.Parameters.Add(new OracleParameter("p_sale_price", item.Price));
                            cmdDetail.Parameters.Add(new OracleParameter("p_item_discount", item.DiscountPercent));
                            cmdDetail.Parameters.Add(new OracleParameter("p_item_sub_total", item.ItemSubTotal));
                            cmdDetail.Parameters.Add(new OracleParameter("p_discount_amount", item.DiscountAmount));
                            cmdDetail.Parameters.Add(new OracleParameter("p_item_grand_total", item.ItemGrandTotal));
                            cmdDetail.ExecuteNonQuery();
                        }

                        using (OracleCommand cmdStock = new OracleCommand(deductStockSql, Program.con))
                        {
                            cmdStock.Transaction = tran;
                            cmdStock.BindByName = true;
                            cmdStock.Parameters.Add(new OracleParameter("p_qty", item.Qty));
                            cmdStock.Parameters.Add(new OracleParameter("p_product_id", item.ProductId));
                            cmdStock.ExecuteNonQuery();
                        }
                    }

                    tran.Commit();
                    return saleId;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    errorMessage = ex.Message;
                    return -1;
                }
            }
        }

        public int DeleteSale(int saleId)
        {
            if (Program.con.State != ConnectionState.Open)
            {
                Program.con.Open();
            }

            using (OracleTransaction tran = Program.con.BeginTransaction())
            {
                try
                {
                    // Restore stock if desired
                    try
                    {
                        DataTable dtDetails = GetSaleDetails(saleId);
                        foreach (DataRow r in dtDetails.Rows)
                        {
                            int prodId = Convert.ToInt32(r["product_id"]);
                            decimal qty = Convert.ToDecimal(r["sale_qty"]);
                            using (OracleCommand cmdStock = new OracleCommand("UPDATE tbl_product SET is_stock = NVL(is_stock, 0) + :p_qty WHERE product_id = :p_prod_id", Program.con))
                            {
                                cmdStock.Transaction = tran;
                                cmdStock.BindByName = true;
                                cmdStock.Parameters.Add(new OracleParameter("p_qty", qty));
                                cmdStock.Parameters.Add(new OracleParameter("p_prod_id", prodId));
                                cmdStock.ExecuteNonQuery();
                            }
                        }
                    }
                    catch { }

                    using (OracleCommand cmdDetail = new OracleCommand("DELETE FROM tbl_sale_detail WHERE sale_id = :p_sale_id", Program.con))
                    {
                        cmdDetail.Transaction = tran;
                        cmdDetail.BindByName = true;
                        cmdDetail.Parameters.Add(new OracleParameter("p_sale_id", saleId));
                        cmdDetail.ExecuteNonQuery();
                    }

                    using (OracleCommand cmdSale = new OracleCommand("DELETE FROM tbl_sale WHERE sale_id = :p_sale_id", Program.con))
                    {
                        cmdSale.Transaction = tran;
                        cmdSale.BindByName = true;
                        cmdSale.Parameters.Add(new OracleParameter("p_sale_id", saleId));
                        int rows = cmdSale.ExecuteNonQuery();
                        tran.Commit();
                        return rows;
                    }
                }
                catch (Exception)
                {
                    tran.Rollback();
                    return -1;
                }
            }
        }

        public SaleReceipt GetReceipt(int saleId)
        {
            SaleReceipt receipt = new SaleReceipt { SaleId = saleId };
            try
            {
                string sql = "SELECT s.sale_id, s.sale_date, NVL(c.customer_name, 'Walk-in') AS customer_name, " +
                             "c.customer_phone, NVL(u.user_name, 'Cashier') AS cashier, " +
                             "s.sub_total, s.sale_discount, s.sale_grand_total, s.paid, s.exchange_rate, s.sale_notes " +
                             "FROM tbl_sale s " +
                             "LEFT JOIN tbl_customer c ON s.customer_id = c.customer_id " +
                             "LEFT JOIN tbl_user u ON s.user_id = u.user_id " +
                             "WHERE s.sale_id = :p_sale_id";
                using (OracleCommand cmd = new OracleCommand(sql, Program.con))
                {
                    cmd.BindByName = true;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new OracleParameter("p_sale_id", saleId));
                    using (OracleDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            receipt.SaleDate = r["sale_date"] != DBNull.Value ? Convert.ToDateTime(r["sale_date"]) : DateTime.Now;
                            receipt.CustomerName = r["customer_name"].ToString();
                            receipt.CustomerPhone = r["customer_phone"] != DBNull.Value ? r["customer_phone"].ToString() : "";
                            receipt.CashierName = r["cashier"].ToString();
                            receipt.SubTotal = r["sub_total"] != DBNull.Value ? Convert.ToDecimal(r["sub_total"]) : 0m;
                            receipt.SaleDiscount = r["sale_discount"] != DBNull.Value ? Convert.ToDecimal(r["sale_discount"]) : 0m;
                            receipt.GrandTotalUSD = r["sale_grand_total"] != DBNull.Value ? Convert.ToDecimal(r["sale_grand_total"]) : 0m;
                            receipt.ExchangeRate = r["exchange_rate"] != DBNull.Value ? Convert.ToDecimal(r["exchange_rate"]) : 4100m;
                            receipt.GrandTotalKHR = receipt.GrandTotalUSD * receipt.ExchangeRate;
                            receipt.Paid = r["paid"] != DBNull.Value ? Convert.ToDecimal(r["paid"]) : 0m;
                            receipt.ChangeUSD = Math.Max(0, receipt.Paid - receipt.GrandTotalUSD);
                            receipt.ChangeKHR = receipt.ChangeUSD * receipt.ExchangeRate;
                            receipt.SaleNotes = r["sale_notes"] != DBNull.Value ? r["sale_notes"].ToString() : "";
                        }
                    }
                }

                DataTable dtItems = GetSaleDetails(saleId);
                foreach (DataRow row in dtItems.Rows)
                {
                    receipt.Items.Add(new SaleItem
                    {
                        ProductId = Convert.ToInt32(row["product_id"]),
                        ProductName = row["product_name"].ToString(),
                        Qty = Convert.ToDecimal(row["sale_qty"]),
                        Price = Convert.ToDecimal(row["sale_price"]),
                        DiscountPercent = Convert.ToDecimal(row["item_discount"]),
                        ItemSubTotal = Convert.ToDecimal(row["item_sub_total"]),
                        DiscountAmount = Convert.ToDecimal(row["discoun_amount"]),
                        ItemGrandTotal = Convert.ToDecimal(row["item_grand_total"])
                    });
                }
            }
            catch (Exception) { }
            return receipt;
        }
    }
}
