using POS_204_oracle.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace POS_204_oracle.uc
{
    public partial class uc_sale : UserControl
    {
        private SaleController saleCtrl = new SaleController();
        private ProductController prodCtrl = new ProductController();
        private DataTable dtActiveProducts;
        private int selectedProductId = 0;
        private int activeCategoryId = 0;
        private int lastSavedSaleId = 0;
        private int editingSaleId = 0;
        private bool isCalculating = false;
        private bool isUserPaidEdited = false;

        public uc_sale()
        {
            InitializeComponent();
        }

        private void uc_sale_Load(object sender, EventArgs e)
        {
            try
            {
                // Set Cashier info
                string user = string.IsNullOrEmpty(Program.UserName) ? "Admin" : Program.UserName;
                lblCashier.Text = $"Cashier: {user}  |  {DateTime.Now:M/d/yyyy}";

                // Setup Sale defaults
                ResetSaleForm();

                // Load Customers
                LoadCustomers();

                // Load Categories & Filter Buttons
                LoadCategoryFilter();

                // Load Products & Render Cards
                LoadAndRenderProducts();

                // Initial calculation
                AutoSum();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing Sale screen: " + ex.Message, "Sale Init Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F5)
            {
                btnSaveSale_Click(this, EventArgs.Empty);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ResetSaleForm()
        {
            editingSaleId = 0;
            txtSaleNo.Text = "SO-" + DateTime.Now.ToString("yyyyMMddHHmmss");
            dtpSaleDate.Value = DateTime.Now;
            txtSelectedProd.Clear();
            txtSellPrice.Clear();
            lblAvailStockVal.Text = "- units";
            selectedProductId = 0;
            numQtyOut.Value = 1;
            txtItemNotes.Clear();
            numDiscount.Value = 0;
            dgCart.Rows.Clear();
            btnSaveSale.Text = "💳 PAY & COMPLETE ORDER";
            if (lblOrderTitle != null) lblOrderTitle.Text = "CURRENT ORDER";
            if (lblOrderBadge != null) lblOrderBadge.Text = $"#SO-{DateTime.Now:HHmmss}";
            if (cboPayMethod != null && cboPayMethod.Items.Count > 0) cboPayMethod.SelectedIndex = 0;
            isUserPaidEdited = false;
            if (txtPaidAmount != null) txtPaidAmount.Text = "0.00";
            AutoSum();
        }

        private void LoadCustomers()
        {
            try
            {
                DataTable dt = saleCtrl.GetCustomers();
                DataTable dtCust = new DataTable();
                dtCust.Columns.Add("customer_id", typeof(int));
                dtCust.Columns.Add("customer_name", typeof(string));

                dtCust.Rows.Add(0, "Walk-in Customer");
                foreach (DataRow r in dt.Rows)
                {
                    dtCust.Rows.Add(Convert.ToInt32(r["customer_id"]), r["customer_name"].ToString());
                }

                cboCustomer.DataSource = dtCust;
                cboCustomer.DisplayMember = "customer_name";
                cboCustomer.ValueMember = "customer_id";
                cboCustomer.SelectedIndex = 0;
            }
            catch { }
        }

        private void LoadCategoryFilter()
        {
            try
            {
                DataTable dt = saleCtrl.GetCategories();

                flpCategories.SuspendLayout();
                flpCategories.Controls.Clear();

                // 1. All Categories Button
                btnCatAll = new Button
                {
                    Text = "All",
                    Tag = 0,
                    Size = new Size(65, 28),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(16, 185, 129), // Emerald
                    ForeColor = Color.FromArgb(10, 14, 23),
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    Cursor = Cursors.Hand,
                    Margin = new Padding(3, 2, 3, 2)
                };
                btnCatAll.FlatAppearance.BorderSize = 0;
                btnCatAll.Click += CategoryButton_Click;
                flpCategories.Controls.Add(btnCatAll);

                // 2. Category Buttons from DB
                foreach (DataRow r in dt.Rows)
                {
                    int catId = Convert.ToInt32(r["category_id"]);
                    string catName = r["category_name"].ToString();

                    Button btnCat = new Button
                    {
                        Text = catName,
                        Tag = catId,
                        AutoSize = true,
                        Height = 28,
                        MinimumSize = new Size(70, 28),
                        FlatStyle = FlatStyle.Flat,
                        BackColor = Color.FromArgb(24, 34, 54),
                        ForeColor = Color.FromArgb(148, 163, 184),
                        Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                        Cursor = Cursors.Hand,
                        Margin = new Padding(3, 2, 3, 2)
                    };
                    btnCat.FlatAppearance.BorderSize = 0;
                    btnCat.Click += CategoryButton_Click;
                    flpCategories.Controls.Add(btnCat);
                }

                flpCategories.ResumeLayout();
            }
            catch { }
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            activeCategoryId = Convert.ToInt32(btn.Tag);

            // Update button styles
            foreach (Control c in flpCategories.Controls)
            {
                if (c is Button b)
                {
                    if (b == btn)
                    {
                        b.BackColor = Color.FromArgb(16, 185, 129);
                        b.ForeColor = Color.FromArgb(10, 14, 23);
                    }
                    else
                    {
                        b.BackColor = Color.FromArgb(24, 34, 54);
                        b.ForeColor = Color.FromArgb(148, 163, 184);
                    }
                }
            }

            FilterAndRenderProducts();
        }

        private void LoadAndRenderProducts()
        {
            try
            {
                dtActiveProducts = saleCtrl.GetActiveProducts();
                FilterAndRenderProducts();
            }
            catch { }
        }

        private void FilterAndRenderProducts()
        {
            if (dtActiveProducts == null) return;

            string search = txtSearchProd.Text.Trim().ToUpper();

            DataView dv = dtActiveProducts.DefaultView;
            string filter = "1=1";

            if (activeCategoryId > 0)
            {
                filter += $" AND category_id = {activeCategoryId}";
            }

            if (!string.IsNullOrEmpty(search))
            {
                // Escape single quotes for DataView RowFilter
                string safeSearch = search.Replace("'", "''");
                filter += $" AND (product_name LIKE '%{safeSearch}%' OR Convert(product_id, 'System.String') = '{safeSearch}')";
            }

            dv.RowFilter = filter;
            RenderProductCards(dv.ToTable());
        }

        private void RenderProductCards(DataTable dt)
        {
            flpProducts.SuspendLayout();
            flpProducts.Controls.Clear();

            if (dt.Rows.Count == 0)
            {
                Label lblEmpty = new Label
                {
                    Text = "No products found in this category.",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10F, FontStyle.Italic),
                    ForeColor = Color.FromArgb(148, 163, 184),
                    Padding = new Padding(16)
                };
                flpProducts.Controls.Add(lblEmpty);
                flpProducts.ResumeLayout();
                return;
            }

            foreach (DataRow r in dt.Rows)
            {
                int prodId = Convert.ToInt32(r["product_id"]);
                string prodName = r["product_name"].ToString();
                decimal price = Convert.ToDecimal(r["product_price"]);
                decimal stock = Convert.ToDecimal(r["is_stock"]);

                Panel card = new Panel
                {
                    Width = 142,
                    Height = 175,
                    BackColor = Color.FromArgb(20, 28, 45),
                    Margin = new Padding(6),
                    Cursor = Cursors.Hand,
                    Tag = prodId
                };

                bool isHovered = false;
                card.Paint += (s, pe) =>
                {
                    Color borderColor = isHovered ? Color.FromArgb(16, 185, 129) : Color.FromArgb(38, 52, 80);
                    using (Pen pen = new Pen(borderColor, isHovered ? 2 : 1))
                    {
                        pe.Graphics.DrawRectangle(pen, 0, 0, card.Width - 1, card.Height - 1);
                    }
                };

                // Product Image
                PictureBox pb = new PictureBox
                {
                    Dock = DockStyle.Top,
                    Height = 90,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BackColor = Color.FromArgb(10, 14, 23),
                    Tag = prodId
                };

                byte[] photoBytes = prodCtrl.GetProductPhotoBytes(prodId);
                if (photoBytes != null && photoBytes.Length > 0)
                {
                    try
                    {
                        using (MemoryStream ms = new MemoryStream(photoBytes))
                        {
                            pb.Image = Image.FromStream(ms);
                        }
                    }
                    catch
                    {
                        pb.Image = null;
                    }
                }

                // Fallback icon if no photo
                if (pb.Image == null)
                {
                    pb.Paint += (s, pe) =>
                    {
                        pe.Graphics.DrawString("📦", new Font("Segoe UI", 24), Brushes.SlateGray, new PointF(48, 22));
                    };
                }

                // Name label
                Label lblName = new Label
                {
                    Dock = DockStyle.Top,
                    Height = 32,
                    Text = prodName,
                    Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(248, 250, 252),
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoEllipsis = true,
                    Tag = prodId
                };

                // Stock label (pill style)
                Label lblStock = new Label
                {
                    Dock = DockStyle.Top,
                    Height = 18,
                    Text = stock <= 0 ? "● Out of Stock" : $"● {stock:N0} in stock",
                    Font = new Font("Segoe UI", 7.5F, stock <= 0 ? FontStyle.Bold : FontStyle.Regular),
                    ForeColor = stock <= 0 ? Color.FromArgb(239, 68, 68) : Color.FromArgb(16, 185, 129),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Tag = prodId
                };

                // Price label
                Label lblPrice = new Label
                {
                    Dock = DockStyle.Bottom,
                    Height = 28,
                    Text = $"${price:N2}",
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(16, 185, 129),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Tag = prodId
                };

                // Routed click & hover handlers
                EventHandler onCardClick = (s, pe) =>
                {
                    OnProductCardClicked(prodId);
                };

                EventHandler onEnter = (s, pe) =>
                {
                    isHovered = true;
                    card.BackColor = Color.FromArgb(26, 36, 58);
                    card.Invalidate();
                };

                EventHandler onLeave = (s, pe) =>
                {
                    isHovered = false;
                    card.BackColor = Color.FromArgb(20, 28, 45);
                    card.Invalidate();
                };

                card.Click += onCardClick;
                pb.Click += onCardClick;
                lblName.Click += onCardClick;
                lblStock.Click += onCardClick;
                lblPrice.Click += onCardClick;

                card.MouseEnter += onEnter;
                pb.MouseEnter += onEnter;
                lblName.MouseEnter += onEnter;
                lblStock.MouseEnter += onEnter;
                lblPrice.MouseEnter += onEnter;

                card.MouseLeave += onLeave;
                pb.MouseLeave += onLeave;
                lblName.MouseLeave += onLeave;
                lblStock.MouseLeave += onLeave;
                lblPrice.MouseLeave += onLeave;

                // Add in reverse order of docking
                card.Controls.Add(lblStock);
                card.Controls.Add(lblName);
                card.Controls.Add(lblPrice);
                card.Controls.Add(pb);

                flpProducts.Controls.Add(card);
            }

            flpProducts.ResumeLayout();
        }

        private void OnProductCardClicked(int prodId)
        {
            if (dtActiveProducts == null) return;

            DataRow foundRow = null;
            foreach (DataRow r in dtActiveProducts.Rows)
            {
                if (Convert.ToInt32(r["product_id"]) == prodId)
                {
                    foundRow = r;
                    break;
                }
            }

            if (foundRow == null) return;

            string prodName = foundRow["product_name"].ToString();
            decimal price = Convert.ToDecimal(foundRow["product_price"]);
            decimal stock = Convert.ToDecimal(foundRow["is_stock"]);

            // Update Quick Info Card
            selectedProductId = prodId;
            txtSelectedProd.Text = prodName;
            txtSellPrice.Text = $"${price:N2}";
            lblAvailStockVal.Text = $"{stock:N0} units";
            lblAvailStockVal.ForeColor = stock <= 0 ? Color.FromArgb(220, 38, 38) : Color.FromArgb(16, 185, 129);
            numQtyOut.Maximum = Math.Max(1, stock);
            numQtyOut.Value = 1;

            if (stock <= 0)
            {
                MessageBox.Show($"Product '{prodName}' is Out of Stock (0 units available).", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Direct Add to Cart & Auto Sum!
            AddToCart(prodId, prodName, 1, price);
        }

        private decimal GetAvailableStock(int prodId)
        {
            if (dtActiveProducts != null)
            {
                foreach (DataRow r in dtActiveProducts.Rows)
                {
                    if (Convert.ToInt32(r["product_id"]) == prodId)
                    {
                        return Convert.ToDecimal(r["is_stock"]);
                    }
                }
            }
            return 0;
        }

        private void AddToCart(int prodId, string prodName, decimal qtyToAdd, decimal unitPrice)
        {
            decimal availStock = GetAvailableStock(prodId);

            if (availStock <= 0)
            {
                MessageBox.Show($"Product '{prodName}' is Out of Stock (0 units available).", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if product is already in cart
            foreach (DataGridViewRow row in dgCart.Rows)
            {
                if (row.Cells["colCartProdId"].Value != null && Convert.ToInt32(row.Cells["colCartProdId"].Value) == prodId)
                {
                    decimal currentQty = Convert.ToDecimal(row.Cells["colCartQty"].Value);
                    decimal newQty = currentQty + qtyToAdd;

                    if (newQty > availStock)
                    {
                        MessageBox.Show($"Cannot add more '{prodName}'.\n\nAvailable stock: {availStock:N0} unit(s)\nAlready in cart: {currentQty:N0} unit(s)\nRequested: +{qtyToAdd:N0}", "Stock Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    row.Cells["colCartQty"].Value = newQty;
                    row.Cells["colCartTotal"].Value = $"${(newQty * unitPrice):N2}";

                    AutoSum();
                    return;
                }
            }

            // Not in cart: check if requested qty exceeds stock
            if (qtyToAdd > availStock)
            {
                MessageBox.Show($"Cannot add {qtyToAdd:N0} units of '{prodName}'. Available stock is only {availStock:N0} unit(s).", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Not in cart: add new row
            int rowIndex = dgCart.Rows.Add(
                prodId,
                prodName,
                "−",
                qtyToAdd,
                "+",
                $"${unitPrice:N2}",
                $"${(qtyToAdd * unitPrice):N2}",
                "✕"
            );

            // Format action button
            dgCart.Rows[rowIndex].Cells["colCartAction"].Style.ForeColor = Color.FromArgb(239, 68, 68);
            dgCart.Rows[rowIndex].Cells["colCartAction"].Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgCart.Rows[rowIndex].Cells["colCartQtyMinus"].Style.ForeColor = Color.FromArgb(239, 68, 68);
            dgCart.Rows[rowIndex].Cells["colCartQtyMinus"].Style.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgCart.Rows[rowIndex].Cells["colCartQtyPlus"].Style.ForeColor = Color.FromArgb(16, 185, 129);
            dgCart.Rows[rowIndex].Cells["colCartQtyPlus"].Style.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            AutoSum();
        }

        private void AutoSum()
        {
            if (isCalculating) return;
            isCalculating = true;

            try
            {
                decimal subTotal = 0;
                decimal totalItems = 0;

                foreach (DataGridViewRow row in dgCart.Rows)
                {
                    if (row.Cells["colCartQty"].Value != null && row.Cells["colCartPrice"].Value != null)
                    {
                        decimal qty = 0;
                        decimal.TryParse(row.Cells["colCartQty"].Value.ToString(), out qty);

                        string priceStr = row.Cells["colCartPrice"].Value.ToString().Replace("$", "").Trim();
                        decimal price = 0;
                        decimal.TryParse(priceStr, out price);

                        decimal lineTotal = qty * price;
                        row.Cells["colCartTotal"].Value = $"${lineTotal:N2}";

                        subTotal += lineTotal;
                        totalItems += qty;
                    }
                }

                decimal discount = numDiscount.Value;
                if (discount > subTotal) discount = subTotal;
                decimal grandTotal = Math.Max(0, subTotal - discount);

                lblTotalItemsVal.Text = totalItems.ToString("N0");
                lblSubTotalVal.Text = $"${subTotal:N2}";
                lblGrandTotalVal.Text = $"${grandTotal:N2}";

                if (lblGrandTotalKHR != null)
                {
                    lblGrandTotalKHR.Text = $"KHR ~ {(grandTotal * 4100m):N0} ៛";
                }

                if (btnSaveSale != null)
                {
                    btnSaveSale.Text = grandTotal > 0 ? $"💳 PAY & COMPLETE (${grandTotal:N2})" : "💳 PAY & COMPLETE ORDER";
                }

                if (txtPaidAmount != null)
                {
                    if (!isUserPaidEdited || string.IsNullOrWhiteSpace(txtPaidAmount.Text) || txtPaidAmount.Text == "0.00" || txtPaidAmount.Text == "0")
                    {
                        txtPaidAmount.Text = grandTotal.ToString("0.00");
                    }
                    RecalculateSalePayment();
                }
            }
            finally
            {
                isCalculating = false;
            }
        }

        private decimal GetCurrentGrandTotal()
        {
            decimal subTotal = 0;
            foreach (DataGridViewRow row in dgCart.Rows)
            {
                if (row.Cells["colCartQty"].Value != null && row.Cells["colCartPrice"].Value != null)
                {
                    decimal qty = 0;
                    decimal.TryParse(row.Cells["colCartQty"].Value.ToString(), out qty);
                    string priceStr = row.Cells["colCartPrice"].Value.ToString().Replace("$", "").Trim();
                    decimal price = 0;
                    decimal.TryParse(priceStr, out price);
                    subTotal += (qty * price);
                }
            }
            decimal discount = numDiscount.Value;
            if (discount > subTotal) discount = subTotal;
            return Math.Max(0, subTotal - discount);
        }

        private void RecalculateSalePayment()
        {
            if (lblChangeVal == null || txtPaidAmount == null || pnlChangeCard == null) return;

            decimal grandTotal = GetCurrentGrandTotal();
            string text = txtPaidAmount.Text.Trim().Replace("$", "");
            decimal paid = 0;
            decimal.TryParse(text, System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, out paid);

            decimal change = paid - grandTotal;
            decimal khr = change * 4100m;

            if (change >= 0)
            {
                lblChangeTitle.Text = "CHANGE DUE";
                lblChangeTitle.ForeColor = Color.FromArgb(148, 163, 184);
                lblChangeVal.Text = $"+ ${change:N2} ({khr:N0} ៛)";
                lblChangeVal.ForeColor = Color.FromArgb(16, 185, 129); // Emerald
                pnlChangeCard.BackColor = Color.FromArgb(20, 28, 45);
            }
            else
            {
                lblChangeTitle.Text = "UNDERPAID / DUE";
                lblChangeTitle.ForeColor = Color.FromArgb(248, 113, 113);
                lblChangeVal.Text = $"- ${Math.Abs(change):N2} ({(Math.Abs(change) * 4100m):N0} ៛)";
                lblChangeVal.ForeColor = Color.FromArgb(239, 68, 68); // Red
                pnlChangeCard.BackColor = Color.FromArgb(36, 18, 24);
            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            if (!isCalculating)
            {
                isUserPaidEdited = true;
            }
            RecalculateSalePayment();
        }

        private void txtPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == '.' && !txtPaidAmount.Text.Contains(".")) return;
            e.Handled = true;
        }

        private void btnExactPay_Click(object sender, EventArgs e)
        {
            decimal grandTotal = GetCurrentGrandTotal();
            txtPaidAmount.Text = grandTotal.ToString("0.00");
            isUserPaidEdited = false;
            RecalculateSalePayment();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (selectedProductId <= 0)
            {
                MessageBox.Show("Please select or click a product first.", "Product Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal qty = numQtyOut.Value;
            if (qty <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string priceStr = txtSellPrice.Text.Replace("$", "").Trim();
            decimal price = 0;
            decimal.TryParse(priceStr, out price);

            AddToCart(selectedProductId, txtSelectedProd.Text, qty, price);
        }

        private void btnClearSelected_Click(object sender, EventArgs e)
        {
            selectedProductId = 0;
            txtSelectedProd.Clear();
            txtSellPrice.Clear();
            lblAvailStockVal.Text = "- units";
            numQtyOut.Value = 1;
            txtItemNotes.Clear();
        }

        private void dgCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgCart.Columns[e.ColumnIndex].Name;
            if (colName == "colCartAction")
            {
                dgCart.Rows.RemoveAt(e.RowIndex);
                AutoSum();
            }
            else if (colName == "colCartQtyPlus")
            {
                int prodId = Convert.ToInt32(dgCart.Rows[e.RowIndex].Cells["colCartProdId"].Value);
                string prodName = dgCart.Rows[e.RowIndex].Cells["colCartProdName"].Value?.ToString() ?? "Product";
                decimal availStock = GetAvailableStock(prodId);
                decimal currentQty = Convert.ToDecimal(dgCart.Rows[e.RowIndex].Cells["colCartQty"].Value);
                if (currentQty + 1 > availStock)
                {
                    MessageBox.Show($"Cannot add more '{prodName}'. Available stock is only {availStock:N0} unit(s).", "Stock Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dgCart.Rows[e.RowIndex].Cells["colCartQty"].Value = currentQty + 1;
                AutoSum();
            }
            else if (colName == "colCartQtyMinus")
            {
                decimal currentQty = Convert.ToDecimal(dgCart.Rows[e.RowIndex].Cells["colCartQty"].Value);
                if (currentQty <= 1)
                {
                    dgCart.Rows.RemoveAt(e.RowIndex);
                }
                else
                {
                    dgCart.Rows[e.RowIndex].Cells["colCartQty"].Value = currentQty - 1;
                }
                AutoSum();
            }
        }

        private void dgCart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // If Qty was edited in grid
            if (dgCart.Columns[e.ColumnIndex].Name == "colCartQty")
            {
                if (dgCart.Rows[e.RowIndex].Cells["colCartProdId"].Value != null)
                {
                    int prodId = Convert.ToInt32(dgCart.Rows[e.RowIndex].Cells["colCartProdId"].Value);
                    string prodName = dgCart.Rows[e.RowIndex].Cells["colCartProdName"].Value != null ? dgCart.Rows[e.RowIndex].Cells["colCartProdName"].Value.ToString() : "Product";
                    decimal availStock = GetAvailableStock(prodId);

                    decimal qty = 0;
                    if (decimal.TryParse(dgCart.Rows[e.RowIndex].Cells["colCartQty"].Value?.ToString(), out qty))
                    {
                        if (qty > availStock)
                        {
                            MessageBox.Show($"Quantity for '{prodName}' cannot exceed available stock ({availStock:N0} unit(s)).", "Stock Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dgCart.Rows[e.RowIndex].Cells["colCartQty"].Value = availStock;
                        }
                        else if (qty <= 0)
                        {
                            dgCart.Rows[e.RowIndex].Cells["colCartQty"].Value = 1;
                        }
                    }
                    else
                    {
                        dgCart.Rows[e.RowIndex].Cells["colCartQty"].Value = 1;
                    }
                }
                AutoSum();
            }
        }

        private void numDiscount_ValueChanged(object sender, EventArgs e)
        {
            AutoSum();
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            if (dgCart.Rows.Count > 0)
            {
                var confirm = MessageBox.Show("Clear all items from the current cart?", "Clear Cart", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    ResetSaleForm();
                }
            }
            else
            {
                ResetSaleForm();
            }
        }

        private void btnSaveSale_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgCart.Rows.Count == 0)
                {
                    MessageBox.Show("The cart is empty. Please click on products to add items to the sale.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Build SaleItem list
                List<SaleItem> items = new List<SaleItem>();
                foreach (DataGridViewRow row in dgCart.Rows)
                {
                    int prodId = Convert.ToInt32(row.Cells["colCartProdId"].Value);
                    string prodName = row.Cells["colCartProdName"].Value.ToString();
                    decimal qty = Convert.ToDecimal(row.Cells["colCartQty"].Value);

                    string priceStr = row.Cells["colCartPrice"].Value.ToString().Replace("$", "").Trim();
                    decimal price = Convert.ToDecimal(priceStr);

                    if (qty <= 0) continue;

                    items.Add(new SaleItem
                    {
                        ProductId = prodId,
                        ProductName = prodName,
                        Qty = qty,
                        Price = price,
                        DiscountPercent = 0,
                        ItemSubTotal = qty * price,
                        DiscountAmount = 0,
                        ItemGrandTotal = qty * price
                    });
                }

                if (items.Count == 0)
                {
                    MessageBox.Show("No valid items with quantity > 0 in cart.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Stock validation check before creating new sale
                if (editingSaleId <= 0)
                {
                    foreach (var item in items)
                    {
                        decimal avail = GetAvailableStock(item.ProductId);
                        if (item.Qty > avail)
                        {
                            MessageBox.Show($"Cannot save sale. Product '{item.ProductName}' only has {avail:N0} unit(s) in stock, but cart requires {item.Qty:N0}.", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                // Customer
                int customerId = 0;
                if (cboCustomer.SelectedValue != null)
                {
                    int.TryParse(cboCustomer.SelectedValue.ToString(), out customerId);
                }

                DateTime saleDate = dtpSaleDate.Value;
                string notes = txtItemNotes.Text.Trim();

                // Direct numeric calculation from items (independent of UI formatting / culture)
                decimal subTotal = 0;
                foreach (var it in items)
                {
                    subTotal += it.ItemGrandTotal;
                }
                decimal discount = numDiscount.Value;
                if (discount > subTotal) discount = subTotal;
                decimal grandTotal = Math.Max(0, subTotal - discount);

                // Direct in-sale payment without secondary forms
                string paidText = txtPaidAmount.Text.Trim().Replace("$", "");
                if (!decimal.TryParse(paidText, System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, out decimal paidAmount) || paidAmount < 0)
                {
                    MessageBox.Show("Please enter a valid payment amount.", "Invalid Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPaidAmount.Focus();
                    txtPaidAmount.SelectAll();
                    return;
                }

                if (paidAmount < grandTotal)
                {
                    decimal shortAmount = grandTotal - paidAmount;
                    var res = MessageBox.Show(
                        $"The customer has paid ${paidAmount:N2}, which is ${shortAmount:N2} less than the Grand Total (${grandTotal:N2}).\n\nDo you want to proceed and save this sale?",
                        "Underpaid Warning",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );
                    if (res != DialogResult.Yes)
                    {
                        txtPaidAmount.Focus();
                        txtPaidAmount.SelectAll();
                        return;
                    }
                }

                string paymentMethod = cboPayMethod.SelectedItem != null ? cboPayMethod.SelectedItem.ToString() : "Cash";

                // Append payment method into notes if not cash
                string fullNotes = notes;
                if (!string.IsNullOrEmpty(paymentMethod) && paymentMethod != "Cash")
                {
                    fullNotes = string.IsNullOrWhiteSpace(fullNotes) ? $"[Paid via {paymentMethod}]" : $"{fullNotes} | [Paid via {paymentMethod}]";
                }

                string error;
                int savedId = 0;
                int activeUserId = Program.UserID > 0 ? Program.UserID : 0;

                if (editingSaleId > 0)
                {
                    // UPDATE existing sale
                    savedId = saleCtrl.UpdateSale(
                        editingSaleId,
                        saleDate,
                        customerId,
                        fullNotes,
                        4100,
                        subTotal,
                        discount,
                        grandTotal,
                        paidAmount,
                        items,
                        out error
                    );
                }
                else
                {
                    // INSERT new sale
                    savedId = saleCtrl.InsertSale(
                        saleDate,
                        customerId,
                        fullNotes,
                        4100,
                        activeUserId,
                        subTotal,
                        discount,
                        grandTotal,
                        paidAmount,
                        items,
                        out error
                    );
                }

                if (savedId > 0)
                {
                    lastSavedSaleId = savedId;
                    decimal changeDue = Math.Max(0, paidAmount - grandTotal);
                    decimal changeKHR = changeDue * 4100m;

                    string actionMsg = editingSaleId > 0
                        ? $"Sale #{savedId} updated successfully!\n\nPaid: ${paidAmount:N2} via {paymentMethod}\nChange Due: ${changeDue:N2} ({changeKHR:N0} ៛)"
                        : $"Sale #{savedId} completed successfully!\n\nPaid: ${paidAmount:N2} via {paymentMethod}\nChange Due: ${changeDue:N2} ({changeKHR:N0} ៛)\n\nInventory stock has been deducted.";

                    MessageBox.Show(actionMsg, "Payment & Sale Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset form and reload products to show new stock on cards
                    isUserPaidEdited = false;
                    ResetSaleForm();
                    LoadAndRenderProducts();
                }
                else
                {
                    MessageBox.Show("Failed to save sale: " + error, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving sale: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (lastSavedSaleId > 0)
            {
                PrintReceipt(lastSavedSaleId);
            }
            else if (dgCart.Rows.Count > 0)
            {
                MessageBox.Show("Please click 'Save Sale' first to save and print the receipt.", "Save Sale First", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No recent sale to print.", "Print Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PrintReceipt(int saleId)
        {
            try
            {
                SaleReceipt receipt = saleCtrl.GetReceipt(saleId);
                if (receipt != null)
                {
                    using (frm_receipt frm = new frm_receipt(receipt))
                    {
                        frm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Could not retrieve receipt data for Sale #" + saleId, "Receipt Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error printing receipt: " + ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchProd_TextChanged(object sender, EventArgs e)
        {
            FilterAndRenderProducts();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            txtSearchProd.Focus();
            txtSearchProd.SelectAll();
        }

        private void btnCatAll_Click(object sender, EventArgs e)
        {
            CategoryButton_Click(btnCatAll, EventArgs.Empty);
        }

        // ==================== SALES HISTORY & CRUD ====================

        private void btnToggleHistory_Click(object sender, EventArgs e)
        {
            pnlHistoryView.Visible = !pnlHistoryView.Visible;
            if (pnlHistoryView.Visible)
            {
                pnlHistoryView.BringToFront();
                LoadSalesHistory();
            }
        }

        private void btnHistBack_Click(object sender, EventArgs e)
        {
            pnlHistoryView.Visible = false;
        }

        private void LoadSalesHistory()
        {
            try
            {
                string search = txtHistSearch.Text.Trim();
                DataTable dt = saleCtrl.GetSalesFiltered(null, null, null, search);
                dgHistory.DataSource = dt;

                if (dgHistory.Columns.Contains("sale_id"))
                {
                    dgHistory.Columns["sale_id"].HeaderText = "Sale #";
                    dgHistory.Columns["sale_id"].Width = 80;
                    dgHistory.Columns["sale_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (dgHistory.Columns.Contains("sale_date"))
                {
                    dgHistory.Columns["sale_date"].HeaderText = "Date";
                    dgHistory.Columns["sale_date"].Width = 120;
                }
                if (dgHistory.Columns.Contains("customer_name"))
                {
                    dgHistory.Columns["customer_name"].HeaderText = "Customer";
                    dgHistory.Columns["customer_name"].Width = 160;
                }
                if (dgHistory.Columns.Contains("cashier"))
                {
                    dgHistory.Columns["cashier"].HeaderText = "Cashier";
                    dgHistory.Columns["cashier"].Width = 110;
                }
                if (dgHistory.Columns.Contains("sub_total"))
                {
                    dgHistory.Columns["sub_total"].HeaderText = "Subtotal";
                    dgHistory.Columns["sub_total"].Width = 95;
                    dgHistory.Columns["sub_total"].DefaultCellStyle.Format = "C2";
                    dgHistory.Columns["sub_total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgHistory.Columns.Contains("sale_discount"))
                {
                    dgHistory.Columns["sale_discount"].HeaderText = "Discount";
                    dgHistory.Columns["sale_discount"].Width = 85;
                    dgHistory.Columns["sale_discount"].DefaultCellStyle.Format = "C2";
                    dgHistory.Columns["sale_discount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgHistory.Columns.Contains("sale_grand_total"))
                {
                    dgHistory.Columns["sale_grand_total"].HeaderText = "Total ($)";
                    dgHistory.Columns["sale_grand_total"].Width = 105;
                    dgHistory.Columns["sale_grand_total"].DefaultCellStyle.Format = "C2";
                    dgHistory.Columns["sale_grand_total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgHistory.Columns["sale_grand_total"].DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                    dgHistory.Columns["sale_grand_total"].DefaultCellStyle.ForeColor = Color.FromArgb(37, 99, 235);
                }
                if (dgHistory.Columns.Contains("paid"))
                {
                    dgHistory.Columns["paid"].HeaderText = "Paid ($)";
                    dgHistory.Columns["paid"].Width = 105;
                    dgHistory.Columns["paid"].DefaultCellStyle.Format = "C2";
                    dgHistory.Columns["paid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgHistory.Columns["paid"].DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                    dgHistory.Columns["paid"].DefaultCellStyle.ForeColor = Color.FromArgb(5, 150, 105);
                    dgHistory.Columns["paid"].Visible = true;
                }
                if (dgHistory.Columns.Contains("exchange_rate")) dgHistory.Columns["exchange_rate"].Visible = false;
                if (dgHistory.Columns.Contains("sale_notes"))
                {
                    dgHistory.Columns["sale_notes"].HeaderText = "Notes";
                    dgHistory.Columns["sale_notes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch { }
        }

        private void txtHistSearch_TextChanged(object sender, EventArgs e)
        {
            LoadSalesHistory();
        }

        private void btnHistRefresh_Click(object sender, EventArgs e)
        {
            LoadSalesHistory();
        }

        private void btnHistLoadSale_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgHistory.CurrentRow == null || dgHistory.CurrentRow.Index < 0)
                {
                    MessageBox.Show("Please select a sale from the list to load.", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int saleId = Convert.ToInt32(dgHistory.CurrentRow.Cells["sale_id"].Value);

                DataTable dtDetails = saleCtrl.GetSaleDetails(saleId);
                if (dtDetails.Rows.Count == 0)
                {
                    MessageBox.Show("No items found for Sale #" + saleId, "Sale Items", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Switch to POS view
                pnlHistoryView.Visible = false;

                // Load sale details into cart
                editingSaleId = saleId;
                btnSaveSale.Text = $"Update Sale #{saleId}";
                txtSaleNo.Text = "SO-" + saleId.ToString();

                dgCart.Rows.Clear();
                foreach (DataRow r in dtDetails.Rows)
                {
                    int pId = Convert.ToInt32(r["product_id"]);
                    string pName = r["product_name"].ToString();
                    decimal qty = Convert.ToDecimal(r["sale_qty"]);
                    decimal price = Convert.ToDecimal(r["sale_price"]);
                    decimal total = Convert.ToDecimal(r["item_grand_total"]);

                    int idx = dgCart.Rows.Add(pId, pName, "−", qty, "+", $"${price:N2}", $"${total:N2}", "✕");
                    dgCart.Rows[idx].Cells["colCartAction"].Style.ForeColor = Color.FromArgb(239, 68, 68);
                    dgCart.Rows[idx].Cells["colCartAction"].Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    dgCart.Rows[idx].Cells["colCartQtyMinus"].Style.ForeColor = Color.FromArgb(239, 68, 68);
                    dgCart.Rows[idx].Cells["colCartQtyMinus"].Style.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    dgCart.Rows[idx].Cells["colCartQtyPlus"].Style.ForeColor = Color.FromArgb(16, 185, 129);
                    dgCart.Rows[idx].Cells["colCartQtyPlus"].Style.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                }

                // Set discount & notes
                if (dgHistory.CurrentRow.Cells["sale_discount"].Value != null)
                {
                    decimal disc;
                    if (decimal.TryParse(dgHistory.CurrentRow.Cells["sale_discount"].Value.ToString(), out disc))
                    {
                        numDiscount.Value = disc;
                    }
                }
                if (dgHistory.CurrentRow.Cells["sale_notes"].Value != null)
                {
                    txtItemNotes.Text = dgHistory.CurrentRow.Cells["sale_notes"].Value.ToString();
                }

                AutoSum();

                MessageBox.Show($"Sale #{saleId} loaded into cart! You can add/remove items or adjust quantities and click 'Update Sale'.", "Sale Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sale: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHistDeleteSale_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgHistory.CurrentRow == null || dgHistory.CurrentRow.Index < 0)
                {
                    MessageBox.Show("Please select a sale to delete.", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int saleId = Convert.ToInt32(dgHistory.CurrentRow.Cells["sale_id"].Value);

                var confirm = MessageBox.Show($"Are you sure you want to permanently delete Sale #{saleId}?\n\nThis will automatically restore product quantities back to stock inventory.", "Confirm Delete Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    int rows = saleCtrl.DeleteSale(saleId);
                    if (rows > 0)
                    {
                        MessageBox.Show($"Sale #{saleId} deleted and inventory stock restored.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSalesHistory();
                        LoadAndRenderProducts(); // Refresh stock on cards
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete sale.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting sale: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHistPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgHistory.CurrentRow == null || dgHistory.CurrentRow.Index < 0)
                {
                    MessageBox.Show("Please select a sale to print receipt.", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int saleId = Convert.ToInt32(dgHistory.CurrentRow.Cells["sale_id"].Value);
                PrintReceipt(saleId);
            }
            catch { }
        }
    }
}
