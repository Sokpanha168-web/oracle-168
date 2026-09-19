using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;

namespace POS_204_oracle.Controller
{
    public class StockKPIs
    {
        public int TotalProducts { get; set; }
        public decimal TotalUnits { get; set; }
        public decimal TotalCostValue { get; set; }
        public decimal TotalRetailValue { get; set; }
        public int LowStockCount { get; set; }
        public int OutOfStockCount { get; set; }
    }

    public class StockController
    {
        private static bool tableChecked = false;

        public static void EnsureStockTables()
        {
            if (tableChecked) return;
            try
            {
                if (Program.con.State != ConnectionState.Open) Program.con.Open();

                // Check if tbl_stock_transaction exists
                bool exists = false;
                using (OracleCommand checkCmd = new OracleCommand(
                    "SELECT COUNT(*) FROM user_tables WHERE UPPER(table_name) = 'TBL_STOCK_TRANSACTION'", Program.con))
                {
                    exists = Convert.ToInt32(checkCmd.ExecuteScalar()) > 0;
                }

                if (!exists)
                {
                    string ddl = @"CREATE TABLE tbl_stock_transaction (
                        trans_id NUMBER NOT NULL PRIMARY KEY,
                        trans_date DATE DEFAULT SYSDATE NOT NULL,
                        product_id NUMBER NOT NULL,
                        trans_type VARCHAR2(30) NOT NULL,
                        qty NUMBER NOT NULL,
                        unit_cost NUMBER(12, 2) DEFAULT 0,
                        total_cost NUMBER(12, 2) DEFAULT 0,
                        supplier_id NUMBER NULL,
                        user_id NUMBER NULL,
                        ref_no VARCHAR2(60) NULL,
                        notes VARCHAR2(250) NULL,
                        balance_after NUMBER NULL
                    )";

                    using (OracleCommand createCmd = new OracleCommand(ddl, Program.con))
                    {
                        createCmd.ExecuteNonQuery();
                    }
                }

                // Ensure is_stock column has enough precision for quantity
                try
                {
                    using (OracleCommand alterCmd = new OracleCommand("ALTER TABLE tbl_product MODIFY (is_stock NUMBER(12, 2))", Program.con))
                    {
                        alterCmd.ExecuteNonQuery();
                    }
                }
                catch { }
            }
            catch
            {
                // Silently ignore if table already exists
            }
            tableChecked = true;
        }

        public DataTable GetInventory(string search = null, int? categoryId = null, string statusFilter = null)
        {
            EnsureStockTables();
            DataTable dt = new DataTable();
            try
            {
                if (Program.con.State != ConnectionState.Open) Program.con.Open();

                string sql = @"SELECT 
                    p.product_id,
                    p.product_name,
                    p.category_id,
                    NVL(c.category_name, 'General') AS category_name,
                    p.supplier_id,
                    NVL(s.supplier_name, 'N/A') AS supplier_name,
                    NVL(p.is_stock, 0) AS is_stock,
                    NVL(p.product_cost, 0) AS product_cost,
                    NVL(p.product_price, 0) AS product_price,
                    (NVL(p.product_price, 0) - NVL(p.product_cost, 0)) AS margin,
                    (NVL(p.is_stock, 0) * NVL(p.product_cost, 0)) AS total_cost_val,
                    (NVL(p.is_stock, 0) * NVL(p.product_price, 0)) AS total_retail_val,
                    CASE 
                        WHEN NVL(p.is_stock, 0) <= 0 THEN 'Out of Stock'
                        ELSE 'In Stock'
                    END AS stock_status
                    FROM tbl_product p
                    LEFT JOIN tbl_category c ON p.category_id = c.category_id
                    LEFT JOIN tbl_supplier s ON p.supplier_id = s.supplier_id
                    WHERE p.product_status = 1";

                List<OracleParameter> parameters = new List<OracleParameter>();

                if (!string.IsNullOrWhiteSpace(search))
                {
                    sql += " AND (UPPER(p.product_name) LIKE :search OR TO_CHAR(p.product_id) = :searchExact)";
                    parameters.Add(new OracleParameter("search", "%" + search.Trim().ToUpper() + "%"));
                    parameters.Add(new OracleParameter("searchExact", search.Trim()));
                }

                if (categoryId.HasValue && categoryId.Value > 0)
                {
                    sql += " AND p.category_id = :cat_id";
                    parameters.Add(new OracleParameter("cat_id", categoryId.Value));
                }

                if (!string.IsNullOrWhiteSpace(statusFilter) && statusFilter != "All")
                {
                    if (statusFilter == "In Stock")
                    {
                        sql += " AND NVL(p.is_stock, 0) > 0";
                    }
                    else if (statusFilter == "Out of Stock")
                    {
                        sql += " AND NVL(p.is_stock, 0) <= 0";
                    }
                }

                sql += " ORDER BY p.product_name ASC";

                using (OracleCommand cmd = new OracleCommand(sql, Program.con))
                {
                    foreach (var p in parameters) cmd.Parameters.Add(p);
                    using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch { }
            return dt;
        }

        public StockKPIs GetStockKPIs()
        {
            EnsureStockTables();
            StockKPIs kpi = new StockKPIs();
            try
            {
                if (Program.con.State != ConnectionState.Open) Program.con.Open();

                string sql = @"SELECT 
                    COUNT(*) AS total_prods,
                    NVL(SUM(NVL(is_stock, 0)), 0) AS total_units,
                    NVL(SUM(NVL(is_stock, 0) * NVL(product_cost, 0)), 0) AS total_cost_val,
                    NVL(SUM(NVL(is_stock, 0) * NVL(product_price, 0)), 0) AS total_retail_val,
                    NVL(SUM(CASE WHEN NVL(is_stock, 0) > 0 AND NVL(is_stock, 0) <= 5 THEN 1 ELSE 0 END), 0) AS low_stk,
                    NVL(SUM(CASE WHEN NVL(is_stock, 0) <= 0 THEN 1 ELSE 0 END), 0) AS out_stk
                    FROM tbl_product WHERE product_status = 1";

                using (OracleCommand cmd = new OracleCommand(sql, Program.con))
                using (OracleDataReader r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        kpi.TotalProducts = r["total_prods"] != DBNull.Value ? Convert.ToInt32(r["total_prods"]) : 0;
                        kpi.TotalUnits = r["total_units"] != DBNull.Value ? Convert.ToDecimal(r["total_units"]) : 0;
                        kpi.TotalCostValue = r["total_cost_val"] != DBNull.Value ? Convert.ToDecimal(r["total_cost_val"]) : 0;
                        kpi.TotalRetailValue = r["total_retail_val"] != DBNull.Value ? Convert.ToDecimal(r["total_retail_val"]) : 0;
                        kpi.LowStockCount = r["low_stk"] != DBNull.Value ? Convert.ToInt32(r["low_stk"]) : 0;
                        kpi.OutOfStockCount = r["out_stk"] != DBNull.Value ? Convert.ToInt32(r["out_stk"]) : 0;
                    }
                }
            }
            catch { }
            return kpi;
        }

        public bool StockIn(
            int productId,
            int supplierId,
            decimal qty,
            decimal unitCost,
            DateTime transDate,
            string refNo,
            string notes,
            int userId,
            out string errorMessage)
        {
            errorMessage = "";
            EnsureStockTables();

            if (qty <= 0)
            {
                errorMessage = "Quantity received must be greater than zero.";
                return false;
            }

            if (Program.con.State != ConnectionState.Open) Program.con.Open();

            using (OracleTransaction tran = Program.con.BeginTransaction())
            {
                try
                {
                    // 1. Update Product stock and unit cost
                    string updateSql = "UPDATE tbl_product SET " +
                                       "is_stock = NVL(is_stock, 0) + :qty, " +
                                       "product_cost = :cost " +
                                       "WHERE product_id = :id";

                    using (OracleCommand cmdUp = new OracleCommand(updateSql, Program.con))
                    {
                        cmdUp.Transaction = tran;
                        cmdUp.Parameters.Add(new OracleParameter("qty", qty));
                        cmdUp.Parameters.Add(new OracleParameter("cost", unitCost));
                        cmdUp.Parameters.Add(new OracleParameter("id", productId));
                        cmdUp.ExecuteNonQuery();
                    }

                    // 2. Fetch new balance
                    decimal balanceAfter = 0;
                    using (OracleCommand cmdBal = new OracleCommand("SELECT NVL(is_stock, 0) FROM tbl_product WHERE product_id = :id", Program.con))
                    {
                        cmdBal.Transaction = tran;
                        cmdBal.Parameters.Add(new OracleParameter("id", productId));
                        object obj = cmdBal.ExecuteScalar();
                        if (obj != null && obj != DBNull.Value)
                        {
                            balanceAfter = Convert.ToDecimal(obj);
                        }
                    }

                    // 3. Get next transaction ID
                    int nextTransId = 1;
                    using (OracleCommand cmdMax = new OracleCommand("SELECT NVL(MAX(trans_id), 0) + 1 FROM tbl_stock_transaction", Program.con))
                    {
                        cmdMax.Transaction = tran;
                        object obj = cmdMax.ExecuteScalar();
                        if (obj != null && obj != DBNull.Value)
                        {
                            nextTransId = Convert.ToInt32(obj);
                        }
                    }

                    // 4. Insert into tbl_stock_transaction
                    decimal totalCost = qty * unitCost;
                    string insertTransSql = @"INSERT INTO tbl_stock_transaction 
                        (trans_id, trans_date, product_id, trans_type, qty, unit_cost, total_cost, supplier_id, user_id, ref_no, notes, balance_after) 
                        VALUES 
                        (:trans_id, :trans_date, :product_id, :trans_type, :qty, :unit_cost, :total_cost, :supplier_id, :user_id, :ref_no, :notes, :balance_after)";

                    using (OracleCommand cmdTrans = new OracleCommand(insertTransSql, Program.con))
                    {
                        cmdTrans.Transaction = tran;
                        cmdTrans.Parameters.Add(new OracleParameter("trans_id", nextTransId));
                        cmdTrans.Parameters.Add(new OracleParameter("trans_date", OracleDbType.Date) { Value = transDate });
                        cmdTrans.Parameters.Add(new OracleParameter("product_id", productId));
                        cmdTrans.Parameters.Add(new OracleParameter("trans_type", "STOCK IN"));
                        cmdTrans.Parameters.Add(new OracleParameter("qty", qty));
                        cmdTrans.Parameters.Add(new OracleParameter("unit_cost", unitCost));
                        cmdTrans.Parameters.Add(new OracleParameter("total_cost", totalCost));
                        cmdTrans.Parameters.Add(new OracleParameter("supplier_id", supplierId > 0 ? (object)supplierId : DBNull.Value));
                        cmdTrans.Parameters.Add(new OracleParameter("user_id", userId > 0 ? (object)userId : DBNull.Value));
                        cmdTrans.Parameters.Add(new OracleParameter("ref_no", string.IsNullOrWhiteSpace(refNo) ? (object)DBNull.Value : refNo));
                        cmdTrans.Parameters.Add(new OracleParameter("notes", string.IsNullOrWhiteSpace(notes) ? (object)DBNull.Value : notes));
                        cmdTrans.Parameters.Add(new OracleParameter("balance_after", balanceAfter));
                        cmdTrans.ExecuteNonQuery();
                    }

                    // 5. Optionally also record into tbl_purchase for historical compatibility
                    try
                    {
                        int nextPurchId = 1;
                        using (OracleCommand cmdPurchMax = new OracleCommand("SELECT NVL(MAX(purchase_id), 0) + 1 FROM tbl_purchase", Program.con))
                        {
                            cmdPurchMax.Transaction = tran;
                            nextPurchId = Convert.ToInt32(cmdPurchMax.ExecuteScalar());
                        }

                        string insertPurchSql = @"INSERT INTO tbl_purchase 
                            (purchase_id, purchase_date, user_id, purchase_qty, purchase_price, purchase_notes) 
                            VALUES 
                            (:pid, :pdate, :puid, :pqty, :pprice, :pnotes)";

                        using (OracleCommand cmdPurch = new OracleCommand(insertPurchSql, Program.con))
                        {
                            cmdPurch.Transaction = tran;
                            cmdPurch.Parameters.Add(new OracleParameter("pid", nextPurchId));
                            cmdPurch.Parameters.Add(new OracleParameter("pdate", OracleDbType.Date) { Value = transDate });
                            cmdPurch.Parameters.Add(new OracleParameter("puid", userId > 0 ? userId : 1));
                            cmdPurch.Parameters.Add(new OracleParameter("pqty", qty));
                            cmdPurch.Parameters.Add(new OracleParameter("pprice", unitCost));
                            cmdPurch.Parameters.Add(new OracleParameter("pnotes", $"Product #{productId} Ref: {refNo} {notes}"));
                            cmdPurch.ExecuteNonQuery();
                        }
                    }
                    catch { }

                    tran.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    errorMessage = ex.Message;
                    return false;
                }
            }
        }

        public bool StockAdjust(
            int productId,
            string adjustReason,
            decimal qtyChange,
            string notes,
            int userId,
            out string errorMessage)
        {
            errorMessage = "";
            EnsureStockTables();

            if (qtyChange == 0)
            {
                errorMessage = "Adjustment quantity cannot be zero.";
                return false;
            }

            if (Program.con.State != ConnectionState.Open) Program.con.Open();

            using (OracleTransaction tran = Program.con.BeginTransaction())
            {
                try
                {
                    // 1. Update Product stock
                    string updateSql = "UPDATE tbl_product SET is_stock = GREATEST(0, NVL(is_stock, 0) + :qty) WHERE product_id = :id";
                    using (OracleCommand cmdUp = new OracleCommand(updateSql, Program.con))
                    {
                        cmdUp.Transaction = tran;
                        cmdUp.Parameters.Add(new OracleParameter("qty", qtyChange));
                        cmdUp.Parameters.Add(new OracleParameter("id", productId));
                        cmdUp.ExecuteNonQuery();
                    }

                    // 2. Fetch new balance
                    decimal balanceAfter = 0;
                    decimal currentCost = 0;
                    using (OracleCommand cmdBal = new OracleCommand("SELECT NVL(is_stock, 0), NVL(product_cost, 0) FROM tbl_product WHERE product_id = :id", Program.con))
                    {
                        cmdBal.Transaction = tran;
                        cmdBal.Parameters.Add(new OracleParameter("id", productId));
                        using (OracleDataReader r = cmdBal.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                balanceAfter = Convert.ToDecimal(r[0]);
                                currentCost = Convert.ToDecimal(r[1]);
                            }
                        }
                    }

                    // 3. Get next transaction ID
                    int nextTransId = 1;
                    using (OracleCommand cmdMax = new OracleCommand("SELECT NVL(MAX(trans_id), 0) + 1 FROM tbl_stock_transaction", Program.con))
                    {
                        cmdMax.Transaction = tran;
                        object obj = cmdMax.ExecuteScalar();
                        if (obj != null && obj != DBNull.Value)
                        {
                            nextTransId = Convert.ToInt32(obj);
                        }
                    }

                    // 4. Insert into tbl_stock_transaction
                    string insertTransSql = @"INSERT INTO tbl_stock_transaction 
                        (trans_id, trans_date, product_id, trans_type, qty, unit_cost, total_cost, user_id, ref_no, notes, balance_after) 
                        VALUES 
                        (:trans_id, SYSDATE, :product_id, :trans_type, :qty, :unit_cost, :total_cost, :user_id, :ref_no, :notes, :balance_after)";

                    using (OracleCommand cmdTrans = new OracleCommand(insertTransSql, Program.con))
                    {
                        cmdTrans.Transaction = tran;
                        cmdTrans.Parameters.Add(new OracleParameter("trans_id", nextTransId));
                        cmdTrans.Parameters.Add(new OracleParameter("product_id", productId));
                        cmdTrans.Parameters.Add(new OracleParameter("trans_type", "ADJUSTMENT"));
                        cmdTrans.Parameters.Add(new OracleParameter("qty", qtyChange));
                        cmdTrans.Parameters.Add(new OracleParameter("unit_cost", currentCost));
                        cmdTrans.Parameters.Add(new OracleParameter("total_cost", Math.Abs(qtyChange) * currentCost));
                        cmdTrans.Parameters.Add(new OracleParameter("user_id", userId > 0 ? (object)userId : DBNull.Value));
                        cmdTrans.Parameters.Add(new OracleParameter("ref_no", "ADJ-" + DateTime.Now.ToString("yyyyMMddHHmmss")));
                        cmdTrans.Parameters.Add(new OracleParameter("notes", $"Reason: {adjustReason}. {notes}"));
                        cmdTrans.Parameters.Add(new OracleParameter("balance_after", balanceAfter));
                        cmdTrans.ExecuteNonQuery();
                    }

                    tran.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    errorMessage = ex.Message;
                    return false;
                }
            }
        }

        public bool StockSetExact(
            int productId,
            decimal exactPhysicalCount,
            string notes,
            int userId,
            out string errorMessage)
        {
            errorMessage = "";
            EnsureStockTables();

            if (exactPhysicalCount < 0)
            {
                errorMessage = "Physical count cannot be negative.";
                return false;
            }

            if (Program.con.State != ConnectionState.Open) Program.con.Open();

            using (OracleTransaction tran = Program.con.BeginTransaction())
            {
                try
                {
                    decimal currentStock = 0;
                    decimal currentCost = 0;
                    using (OracleCommand cmdOld = new OracleCommand("SELECT NVL(is_stock, 0), NVL(product_cost, 0) FROM tbl_product WHERE product_id = :id", Program.con))
                    {
                        cmdOld.Transaction = tran;
                        cmdOld.Parameters.Add(new OracleParameter("id", productId));
                        using (OracleDataReader r = cmdOld.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                currentStock = Convert.ToDecimal(r[0]);
                                currentCost = Convert.ToDecimal(r[1]);
                            }
                        }
                    }

                    decimal diff = exactPhysicalCount - currentStock;
                    if (diff == 0)
                    {
                        errorMessage = "Count matches current stock already. No change needed.";
                        return false;
                    }

                    // Update stock
                    using (OracleCommand cmdUp = new OracleCommand("UPDATE tbl_product SET is_stock = :exact WHERE product_id = :id", Program.con))
                    {
                        cmdUp.Transaction = tran;
                        cmdUp.Parameters.Add(new OracleParameter("exact", exactPhysicalCount));
                        cmdUp.Parameters.Add(new OracleParameter("id", productId));
                        cmdUp.ExecuteNonQuery();
                    }

                    // Next trans ID
                    int nextTransId = 1;
                    using (OracleCommand cmdMax = new OracleCommand("SELECT NVL(MAX(trans_id), 0) + 1 FROM tbl_stock_transaction", Program.con))
                    {
                        cmdMax.Transaction = tran;
                        nextTransId = Convert.ToInt32(cmdMax.ExecuteScalar());
                    }

                    // Insert movement log
                    string insertTransSql = @"INSERT INTO tbl_stock_transaction 
                        (trans_id, trans_date, product_id, trans_type, qty, unit_cost, total_cost, user_id, ref_no, notes, balance_after) 
                        VALUES 
                        (:trans_id, SYSDATE, :product_id, :trans_type, :qty, :unit_cost, :total_cost, :user_id, :ref_no, :notes, :balance_after)";

                    using (OracleCommand cmdTrans = new OracleCommand(insertTransSql, Program.con))
                    {
                        cmdTrans.Transaction = tran;
                        cmdTrans.Parameters.Add(new OracleParameter("trans_id", nextTransId));
                        cmdTrans.Parameters.Add(new OracleParameter("product_id", productId));
                        cmdTrans.Parameters.Add(new OracleParameter("trans_type", "AUDIT SET"));
                        cmdTrans.Parameters.Add(new OracleParameter("qty", diff));
                        cmdTrans.Parameters.Add(new OracleParameter("unit_cost", currentCost));
                        cmdTrans.Parameters.Add(new OracleParameter("total_cost", Math.Abs(diff) * currentCost));
                        cmdTrans.Parameters.Add(new OracleParameter("user_id", userId > 0 ? (object)userId : DBNull.Value));
                        cmdTrans.Parameters.Add(new OracleParameter("ref_no", "AUDIT-" + DateTime.Now.ToString("yyyyMMddHHmmss")));
                        cmdTrans.Parameters.Add(new OracleParameter("notes", $"Physical count set to {exactPhysicalCount} (diff: {diff:+0;-0;0}). {notes}"));
                        cmdTrans.Parameters.Add(new OracleParameter("balance_after", exactPhysicalCount));
                        cmdTrans.ExecuteNonQuery();
                    }

                    tran.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    errorMessage = ex.Message;
                    return false;
                }
            }
        }

        public DataTable GetStockHistory(DateTime? fromDate, DateTime? toDate, int? productId, string transType, string search)
        {
            EnsureStockTables();
            DataTable dt = new DataTable();
            try
            {
                if (Program.con.State != ConnectionState.Open) Program.con.Open();

                string sql = @"SELECT 
                    t.trans_id,
                    TO_CHAR(t.trans_date, 'YYYY-MM-DD HH24:MI') AS trans_date_str,
                    NVL(t.ref_no, 'TR-' || t.trans_id) AS ref_no,
                    t.product_id,
                    NVL(p.product_name, 'Product #' || t.product_id) AS product_name,
                    NVL(c.category_name, 'General') AS category_name,
                    t.trans_type,
                    t.qty,
                    t.unit_cost,
                    t.total_cost,
                    NVL(t.balance_after, 0) AS balance_after,
                    NVL(s.supplier_name, '—') AS supplier_name,
                    NVL(u.user_name, 'System') AS user_name,
                    t.notes
                    FROM tbl_stock_transaction t
                    LEFT JOIN tbl_product p ON t.product_id = p.product_id
                    LEFT JOIN tbl_category c ON p.category_id = c.category_id
                    LEFT JOIN tbl_supplier s ON t.supplier_id = s.supplier_id
                    LEFT JOIN tbl_user u ON t.user_id = u.user_id
                    WHERE 1=1";

                List<OracleParameter> parameters = new List<OracleParameter>();

                if (fromDate.HasValue)
                {
                    sql += " AND t.trans_date >= :from_date";
                    parameters.Add(new OracleParameter("from_date", OracleDbType.Date) { Value = fromDate.Value.Date });
                }

                if (toDate.HasValue)
                {
                    sql += " AND t.trans_date <= :to_date";
                    parameters.Add(new OracleParameter("to_date", OracleDbType.Date) { Value = toDate.Value.Date.AddDays(1).AddSeconds(-1) });
                }

                if (productId.HasValue && productId.Value > 0)
                {
                    sql += " AND t.product_id = :pid";
                    parameters.Add(new OracleParameter("pid", productId.Value));
                }

                if (!string.IsNullOrWhiteSpace(transType) && transType != "All Types")
                {
                    sql += " AND t.trans_type = :ttype";
                    parameters.Add(new OracleParameter("ttype", transType.ToUpper()));
                }

                if (!string.IsNullOrWhiteSpace(search))
                {
                    sql += " AND (UPPER(p.product_name) LIKE :search OR UPPER(t.ref_no) LIKE :search OR UPPER(t.notes) LIKE :search)";
                    parameters.Add(new OracleParameter("search", "%" + search.Trim().ToUpper() + "%"));
                }

                sql += " ORDER BY t.trans_date DESC, t.trans_id DESC";

                using (OracleCommand cmd = new OracleCommand(sql, Program.con))
                {
                    foreach (var p in parameters) cmd.Parameters.Add(p);
                    using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch { }
            return dt;
        }

        public DataTable GetActiveProducts()
        {
            DataTable dt = new DataTable();
            try
            {
                if (Program.con.State != ConnectionState.Open) Program.con.Open();
                string sql = "SELECT product_id, product_name, NVL(is_stock, 0) AS is_stock, NVL(product_cost, 0) AS product_cost, NVL(product_price, 0) AS product_price, category_id, supplier_id FROM tbl_product WHERE product_status = 1 ORDER BY product_name ASC";
                using (OracleCommand cmd = new OracleCommand(sql, Program.con))
                using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            catch { }
            return dt;
        }

        public DataTable GetSuppliers()
        {
            DataTable dt = new DataTable();
            try
            {
                if (Program.con.State != ConnectionState.Open) Program.con.Open();
                string sql = "SELECT supplier_id, supplier_name FROM tbl_supplier ORDER BY supplier_name ASC";
                using (OracleCommand cmd = new OracleCommand(sql, Program.con))
                using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            catch { }
            return dt;
        }

        public DataTable GetCategories()
        {
            DataTable dt = new DataTable();
            try
            {
                if (Program.con.State != ConnectionState.Open) Program.con.Open();
                string sql = "SELECT category_id, category_name FROM tbl_category WHERE category_status = 1 ORDER BY category_name ASC";
                using (OracleCommand cmd = new OracleCommand(sql, Program.con))
                using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            catch { }
            return dt;
        }
    }
}
