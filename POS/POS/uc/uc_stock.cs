using POS_204_oracle.Controller;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace POS_204_oracle.uc
{
    public partial class uc_stock : UserControl
    {
        private StockController stockCtrl = new StockController();
        private DataTable dtInventory;
        private DataTable dtActiveProducts;
        private bool isInitializing = true;

        public uc_stock()
        {
            InitializeComponent();
        }

        private void uc_stock_Load(object sender, EventArgs e)
        {
            try
            {
                isInitializing = true;

                // Configure DataGridView appearance
                ConfigureGridAppearance(dgInventory);

                // Setup Status Filter items (already in Designer, select "All Status")
                if (cboStatusFilter.Items.Count > 0)
                {
                    cboStatusFilter.SelectedIndex = 0; // "All Status"
                }

                // Load Category Filter dropdown
                LoadCategoryFilter();

                // Load Products for Stock In form
                LoadProductDropdown();

                isInitializing = false;

                // Initial Data Load
                RefreshCatalog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing Stock Catalog: " + ex.Message, "Stock Init Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isInitializing = false;
            }
        }

        private void ConfigureGridAppearance(DataGridView dg)
        {
            UITheme.ApplyGridTheme(dg);
            dg.BorderStyle = BorderStyle.None;
            dg.BackgroundColor = Color.FromArgb(240, 244, 249);
            dg.AllowUserToAddRows = false;
            dg.AllowUserToDeleteRows = false;
            dg.AllowUserToResizeRows = false;
            dg.ReadOnly = true;
            dg.RowHeadersVisible = false;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.MultiSelect = false;
            dg.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dg.GridColor = Color.FromArgb(226, 232, 240);
            dg.RowTemplate.Height = 40;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 246, 255);
            dg.DefaultCellStyle.BackColor = Color.White;
            dg.DefaultCellStyle.ForeColor = Color.FromArgb(15, 23, 42);
            dg.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dg.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);
            dg.DefaultCellStyle.Font = new Font("Segoe UI", 9.25F);

            dg.EnableHeadersVisualStyles = false;
            dg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dg.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(239, 246, 255);
            dg.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(30, 58, 138);
            dg.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dg.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 4, 6, 4);
            dg.ColumnHeadersHeight = 40;
            dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        public void RefreshCatalog()
        {
            LoadKPIs();
            LoadInventory();
        }

        private void LoadKPIs()
        {
            try
            {
                StockKPIs kpis = stockCtrl.GetStockKPIs();
                int inStockCount = Math.Max(0, kpis.TotalProducts - kpis.OutOfStockCount);

                lblKpiTotalProdsVal.Text = $"{kpis.TotalProducts:N0} Items";
                lblKpiInStockVal.Text = $"{inStockCount:N0} Items";
                lblKpiOutStockVal.Text = $"{kpis.OutOfStockCount:N0} Items";
                lblKpiUnitsVal.Text = $"{kpis.TotalUnits:N0} Units";
            }
            catch { }
        }

        private void LoadCategoryFilter()
        {
            try
            {
                DataTable dt = stockCtrl.GetCategories();
                DataTable dtFilter = new DataTable();
                dtFilter.Columns.Add("category_id", typeof(int));
                dtFilter.Columns.Add("category_name", typeof(string));

                dtFilter.Rows.Add(0, "-- All Categories --");
                foreach (DataRow r in dt.Rows)
                {
                    dtFilter.Rows.Add(Convert.ToInt32(r["category_id"]), r["category_name"].ToString());
                }

                cboCategoryFilter.DataSource = dtFilter;
                cboCategoryFilter.DisplayMember = "category_name";
                cboCategoryFilter.ValueMember = "category_id";
                cboCategoryFilter.SelectedIndex = 0;
            }
            catch { }
        }

        private void LoadProductDropdown()
        {
            try
            {
                dtActiveProducts = stockCtrl.GetActiveProducts();

                DataTable dtIn = new DataTable();
                dtIn.Columns.Add("product_id", typeof(int));
                dtIn.Columns.Add("display_name", typeof(string));
                dtIn.Rows.Add(0, "-- Select Product to Receive --");

                foreach (DataRow r in dtActiveProducts.Rows)
                {
                    int id = Convert.ToInt32(r["product_id"]);
                    string name = r["product_name"].ToString();
                    decimal stock = Convert.ToDecimal(r["is_stock"]);
                    decimal cost = Convert.ToDecimal(r["product_cost"]);

                    dtIn.Rows.Add(id, $"{name}  [Stock: {stock:N0} | Cost: ${cost:N2}]");
                }

                cboInProduct.DataSource = dtIn;
                cboInProduct.DisplayMember = "display_name";
                cboInProduct.ValueMember = "product_id";
                cboInProduct.SelectedIndex = 0;
                lblInCurStock.Text = "(Select a product)";
            }
            catch { }
        }

        private void LoadInventory()
        {
            try
            {
                string search = txtSearch.Text.Trim();

                int? catId = null;
                if (cboCategoryFilter.SelectedValue != null)
                {
                    int cId;
                    if (int.TryParse(cboCategoryFilter.SelectedValue.ToString(), out cId) && cId > 0)
                    {
                        catId = cId;
                    }
                }

                string status = null;
                if (cboStatusFilter.SelectedItem != null)
                {
                    string selected = cboStatusFilter.SelectedItem.ToString();
                    if (selected != "All Status" && selected != "-- All Status --")
                    {
                        status = selected;
                    }
                }

                dtInventory = stockCtrl.GetInventory(search, catId, status);
                dgInventory.DataSource = dtInventory;

                ConfigureInventoryColumns();

                lblFilterCount.Text = $"Showing: {dtInventory.Rows.Count:N0} products";
            }
            catch { }
        }

        private void ConfigureInventoryColumns()
        {
            if (dgInventory.Columns.Count == 0) return;

            if (dgInventory.Columns.Contains("product_id"))
            {
                dgInventory.Columns["product_id"].HeaderText = "ID";
                dgInventory.Columns["product_id"].Width = 65;
                dgInventory.Columns["product_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dgInventory.Columns.Contains("product_name"))
            {
                dgInventory.Columns["product_name"].HeaderText = "Product Name";
                dgInventory.Columns["product_name"].MinimumWidth = 190;
                dgInventory.Columns["product_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (dgInventory.Columns.Contains("category_name"))
            {
                dgInventory.Columns["category_name"].HeaderText = "Category";
                dgInventory.Columns["category_name"].Width = 130;
            }
            if (dgInventory.Columns.Contains("supplier_name"))
            {
                dgInventory.Columns["supplier_name"].HeaderText = "Supplier";
                dgInventory.Columns["supplier_name"].Width = 130;
            }
            if (dgInventory.Columns.Contains("product_cost"))
            {
                dgInventory.Columns["product_cost"].HeaderText = "Cost ($)";
                dgInventory.Columns["product_cost"].Width = 95;
                dgInventory.Columns["product_cost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dgInventory.Columns.Contains("product_price"))
            {
                dgInventory.Columns["product_price"].HeaderText = "Price ($)";
                dgInventory.Columns["product_price"].Width = 95;
                dgInventory.Columns["product_price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dgInventory.Columns.Contains("is_stock"))
            {
                dgInventory.Columns["is_stock"].HeaderText = "Qty on Hand";
                dgInventory.Columns["is_stock"].Width = 115;
                dgInventory.Columns["is_stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgInventory.Columns["is_stock"].DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            }
            if (dgInventory.Columns.Contains("stock_status"))
            {
                dgInventory.Columns["stock_status"].HeaderText = "Stock Status";
                dgInventory.Columns["stock_status"].Width = 130;
                dgInventory.Columns["stock_status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Hide unused calculation / ID columns
            if (dgInventory.Columns.Contains("category_id")) dgInventory.Columns["category_id"].Visible = false;
            if (dgInventory.Columns.Contains("supplier_id")) dgInventory.Columns["supplier_id"].Visible = false;
            if (dgInventory.Columns.Contains("margin")) dgInventory.Columns["margin"].Visible = false;
            if (dgInventory.Columns.Contains("total_cost_val")) dgInventory.Columns["total_cost_val"].Visible = false;
            if (dgInventory.Columns.Contains("total_retail_val")) dgInventory.Columns["total_retail_val"].Visible = false;
        }

        private void dgInventory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string colName = dgInventory.Columns[e.ColumnIndex].Name;

            // 1. Stock Status Badge Formatting
            if (colName == "stock_status" && e.Value != null)
            {
                string status = e.Value.ToString();
                if (status == "In Stock")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(37, 99, 235); // Royal blue
                    e.CellStyle.BackColor = Color.FromArgb(239, 246, 255); // Ice blue
                    e.CellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);
                    e.CellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
                    e.CellStyle.Font = new Font(dgInventory.Font, FontStyle.Bold);
                }
                else if (status == "Out of Stock")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(220, 38, 38); // Red
                    e.CellStyle.BackColor = Color.FromArgb(254, 242, 242); // Soft light red
                    e.CellStyle.SelectionForeColor = Color.FromArgb(185, 28, 28);
                    e.CellStyle.SelectionBackColor = Color.FromArgb(254, 226, 226);
                    e.CellStyle.Font = new Font(dgInventory.Font, FontStyle.Bold);
                }
            }
            // 2. Quantity On Hand Highlighting
            else if (colName == "is_stock" && e.Value != null)
            {
                decimal stockVal;
                if (decimal.TryParse(e.Value.ToString(), out stockVal))
                {
                    e.Value = stockVal.ToString("#,##0");
                    e.FormattingApplied = true;

                    if (stockVal <= 0)
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(220, 38, 38);
                        e.CellStyle.Font = new Font(dgInventory.Font, FontStyle.Bold);
                    }
                    else
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(15, 23, 42);
                        e.CellStyle.Font = new Font(dgInventory.Font, FontStyle.Bold);
                    }
                }
            }
            // 3. Price & Cost Currency Formatting
            else if ((colName == "product_cost" || colName == "product_price") && e.Value != null)
            {
                decimal priceVal;
                if (decimal.TryParse(e.Value.ToString(), out priceVal))
                {
                    e.Value = $"${priceVal:N2}";
                    e.FormattingApplied = true;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!isInitializing)
            {
                LoadInventory();
            }
        }

        private void cboCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isInitializing)
            {
                LoadInventory();
            }
        }

        private void cboStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isInitializing)
            {
                LoadInventory();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProductDropdown();
            RefreshCatalog();
        }

        private void btnHeaderStockIn_Click(object sender, EventArgs e)
        {
            pnlStockIn.Visible = !pnlStockIn.Visible;
            if (pnlStockIn.Visible)
            {
                btnHeaderStockIn.Text = "✕ Close Receive";
                cboInProduct.Focus();
            }
            else
            {
                btnHeaderStockIn.Text = "📥 + Receive Stock";
            }
        }

        private void btnCloseStockIn_Click(object sender, EventArgs e)
        {
            pnlStockIn.Visible = false;
            btnHeaderStockIn.Text = "📥 + Receive Stock";
        }

        private void cboInProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboInProduct.SelectedValue == null) return;

                int prodId;
                if (int.TryParse(cboInProduct.SelectedValue.ToString(), out prodId) && prodId > 0)
                {
                    if (dtActiveProducts != null)
                    {
                        foreach (DataRow r in dtActiveProducts.Rows)
                        {
                            if (Convert.ToInt32(r["product_id"]) == prodId)
                            {
                                decimal currentStock = Convert.ToDecimal(r["is_stock"]);
                                decimal currentCost = Convert.ToDecimal(r["product_cost"]);

                                lblInCurStock.Text = $"(Current: {currentStock:N0} units on hand)";
                                nudInCost.Value = currentCost;
                                return;
                            }
                        }
                    }
                }
                else
                {
                    lblInCurStock.Text = "(Select a product)";
                }
            }
            catch { }
        }

        private void dgInventory_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgInventory.CurrentRow == null || dgInventory.CurrentRow.Index < 0) return;

                int prodId = Convert.ToInt32(dgInventory.CurrentRow.Cells["product_id"].Value);

                // Open stock-in panel pre-selected to this product
                pnlStockIn.Visible = true;
                btnHeaderStockIn.Text = "✕ Close Receive";

                cboInProduct.SelectedValue = prodId;
                nudInQty.Value = 10;
                nudInQty.Focus();
            }
            catch { }
        }

        private void btnSaveStockIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboInProduct.SelectedValue == null)
                {
                    MessageBox.Show("Please select a product to receive.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int prodId;
                if (!int.TryParse(cboInProduct.SelectedValue.ToString(), out prodId) || prodId <= 0)
                {
                    MessageBox.Show("Please select a valid product to receive.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal qty = nudInQty.Value;
                if (qty <= 0)
                {
                    MessageBox.Show("Quantity must be greater than 0.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal unitCost = nudInCost.Value;
                string notes = txtInNotes.Text.Trim();
                string refNo = "RCV-" + DateTime.Now.ToString("yyyyMMddHHmm");

                string error;
                bool success = stockCtrl.StockIn(prodId, 0, qty, unitCost, DateTime.Now, refNo, notes, 1, out error);

                if (success)
                {
                    MessageBox.Show($"Stock added successfully! +{qty:N0} units added to product #{prodId}.", "Stock In Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset stock in controls
                    txtInNotes.Clear();
                    nudInQty.Value = 10;
                    pnlStockIn.Visible = false;
                    btnHeaderStockIn.Text = "📥 + Receive Stock";

                    // Refresh dropdowns & catalog
                    LoadProductDropdown();
                    RefreshCatalog();
                }
                else
                {
                    MessageBox.Show("Stock In failed: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving stock in: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
