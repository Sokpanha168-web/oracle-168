using POS_204_oracle.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace POS_204_oracle.uc
{
    public partial class uc_dashboard : UserControl
    {
        private DashboardController dashCtrl = new DashboardController();
        private List<DailySalesPoint> salesTrend = new List<DailySalesPoint>();
        private DashboardKpis currentKpis = new DashboardKpis();

        public uc_dashboard()
        {
            InitializeComponent();
        }

        private void uc_dashboard_Load(object sender, EventArgs e)
        {
            ApplyPermissions();
            ConfigureGrids();
            LoadDashboardData();
        }

        private void ApplyPermissions()
        {
            if (!Program.IsAdmin)
            {
                btnQuickProduct.Visible = false;
                btnQuickReport.Visible = false;
                lblAlert.Cursor = Cursors.Default;
            }
        }

        private void ConfigureGrids()
        {
            FormatGridBase(dgTopProds);
            FormatGridBase(dgRecentSales);
        }

        private void FormatGridBase(DataGridView dg)
        {
            dg.BorderStyle = BorderStyle.None;
            dg.BackgroundColor = Color.White;
            dg.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dg.GridColor = Color.FromArgb(241, 245, 249);
            dg.EnableHeadersVisualStyles = false;
            dg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dg.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            dg.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dg.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dg.ColumnHeadersHeight = 32;
            dg.RowTemplate.Height = 28;
            dg.DefaultCellStyle.Font = new Font("Segoe UI", 8.5F);
            dg.DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 242, 254);
            dg.DefaultCellStyle.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dg.RowHeadersVisible = false;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.MultiSelect = false;
            dg.ReadOnly = true;
            dg.AllowUserToAddRows = false;
            dg.AllowUserToResizeRows = false;
        }

        public void LoadDashboardData()
        {
            try
            {
                currentKpis = dashCtrl.GetKpis();
                lblRevVal.Text = $"${currentKpis.TotalRevenue:N2}";
                lblOrdVal.Text = currentKpis.TotalOrders.ToString("N0");
                lblProdVal.Text = currentKpis.TotalProducts.ToString("N0");
                lblCustVal.Text = currentKpis.TotalCustomers.ToString("N0");

                if (currentKpis.LowStockCount > 0)
                {
                    pnlAlert.Visible = true;
                    lblAlert.Text = Program.IsAdmin 
                        ? $"⚠️ Inventory Alert: {currentKpis.LowStockCount} product(s) are low in stock (<= 5 units remaining). Click here to manage stock."
                        : $"⚠️ Inventory Alert: {currentKpis.LowStockCount} product(s) are low in stock (<= 5 units remaining).";
                }
                else
                {
                    pnlAlert.Visible = false;
                }

                // 2. 7-Day Trend
                salesTrend = dashCtrl.GetLast7DaysSales();
                pnlChart.Invalidate();

                // 3. Top Selling Products
                var topList = dashCtrl.GetTopProducts(5);
                DataTable dtTop = new DataTable();
                dtTop.Columns.Add("Product", typeof(string));
                dtTop.Columns.Add("Qty Sold", typeof(decimal));
                dtTop.Columns.Add("Revenue ($)", typeof(string));
                foreach (var item in topList)
                {
                    dtTop.Rows.Add(item.ProductName, item.TotalQtySold, $"${item.TotalRevenue:N2}");
                }
                dgTopProds.DataSource = dtTop;
                FormatTopProductsGrid();

                // 4. Recent Sales
                DataTable dtRecent = dashCtrl.GetRecentSales(10);
                dgRecentSales.DataSource = dtRecent;
                FormatRecentSalesGrid();
            }
            catch (Exception)
            {
                // Handle graceful loading
            }
        }

        private void FormatTopProductsGrid()
        {
            if (dgTopProds.Columns.Contains("Product"))
            {
                dgTopProds.Columns["Product"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgTopProds.Columns["Product"].MinimumWidth = 90;
            }
            if (dgTopProds.Columns.Contains("Qty Sold"))
            {
                dgTopProds.Columns["Qty Sold"].Width = 75;
                dgTopProds.Columns["Qty Sold"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dgTopProds.Columns.Contains("Revenue ($)"))
            {
                dgTopProds.Columns["Revenue ($)"].Width = 85;
                dgTopProds.Columns["Revenue ($)"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgTopProds.Columns["Revenue ($)"].DefaultCellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
                dgTopProds.Columns["Revenue ($)"].DefaultCellStyle.ForeColor = Color.FromArgb(16, 185, 129);
            }
        }

        private void FormatRecentSalesGrid()
        {
            if (dgRecentSales.Columns.Contains("Order #"))
            {
                dgRecentSales.Columns["Order #"].Width = 70;
                dgRecentSales.Columns["Order #"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dgRecentSales.Columns.Contains("Date"))
            {
                dgRecentSales.Columns["Date"].Width = 135;
                dgRecentSales.Columns["Date"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
            }
            if (dgRecentSales.Columns.Contains("Customer"))
            {
                dgRecentSales.Columns["Customer"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgRecentSales.Columns["Customer"].MinimumWidth = 90;
            }
            if (dgRecentSales.Columns.Contains("Cashier"))
            {
                dgRecentSales.Columns["Cashier"].Width = 95;
            }
            if (dgRecentSales.Columns.Contains("Sub Total"))
            {
                dgRecentSales.Columns["Sub Total"].Width = 85;
                dgRecentSales.Columns["Sub Total"].DefaultCellStyle.Format = "$#,##0.00";
                dgRecentSales.Columns["Sub Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dgRecentSales.Columns.Contains("Discount"))
            {
                dgRecentSales.Columns["Discount"].Width = 75;
                dgRecentSales.Columns["Discount"].DefaultCellStyle.Format = "$#,##0.00";
                dgRecentSales.Columns["Discount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dgRecentSales.Columns.Contains("Grand Total ($)"))
            {
                dgRecentSales.Columns["Grand Total ($)"].Width = 95;
                dgRecentSales.Columns["Grand Total ($)"].DefaultCellStyle.Format = "$#,##0.00";
                dgRecentSales.Columns["Grand Total ($)"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgRecentSales.Columns["Grand Total ($)"].DefaultCellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
                dgRecentSales.Columns["Grand Total ($)"].DefaultCellStyle.ForeColor = Color.FromArgb(37, 99, 235);
            }
            if (dgRecentSales.Columns.Contains("Paid ($)"))
            {
                dgRecentSales.Columns["Paid ($)"].Width = 85;
                dgRecentSales.Columns["Paid ($)"].DefaultCellStyle.Format = "$#,##0.00";
                dgRecentSales.Columns["Paid ($)"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void pnlChart_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int w = pnlChart.Width;
            int h = pnlChart.Height;

            int padLeft = 44;
            int padRight = 16;
            int padTop = 22;
            int padBottom = 38;

            int chartW = w - padLeft - padRight;
            int chartH = h - padTop - padBottom;

            if (salesTrend == null || salesTrend.Count == 0 || chartW < 50 || chartH < 40)
            {
                using (Font f = new Font("Segoe UI", 9.5F))
                {
                    TextRenderer.DrawText(g, "No sales recorded in the past 7 days.", f, new Point(20, h / 2 - 10), Color.FromArgb(100, 116, 139));
                }
                return;
            }

            decimal maxRev = 0;
            foreach (var pt in salesTrend)
            {
                if (pt.Revenue > maxRev) maxRev = pt.Revenue;
            }
            if (maxRev <= 0) maxRev = 100m; // Default ceiling

            // Draw horizontal guide lines & Y-axis labels
            using (Pen linePen = new Pen(Color.FromArgb(226, 232, 240), 1))
            using (Font fAxis = new Font("Segoe UI", 7.5F))
            {
                for (int i = 0; i <= 4; i++)
                {
                    int y = padTop + (chartH * i) / 4;
                    g.DrawLine(linePen, padLeft, y, padLeft + chartW, y);
                    decimal val = maxRev - (maxRev * i / 4);
                    string label = "$" + (val >= 1000 ? (val / 1000m).ToString("0.#") + "k" : val.ToString("0"));
                    TextRenderer.DrawText(g, label, fAxis, new Rectangle(0, y - 8, padLeft - 5, 16), Color.FromArgb(148, 163, 184), TextFormatFlags.Right);
                }
            }

            // Draw solid baseline
            using (Pen basePen = new Pen(Color.FromArgb(203, 213, 225), 1.5F))
            {
                g.DrawLine(basePen, padLeft, padTop + chartH, padLeft + chartW, padTop + chartH);
            }

            int n = salesTrend.Count;
            int barSlot = chartW / n;
            int barW = Math.Max(16, Math.Min(36, barSlot - 14));

            using (Font fVal = new Font("Segoe UI", 8F, FontStyle.Bold))
            using (Font fDayName = new Font("Segoe UI", 7.5F, FontStyle.Bold))
            using (Font fDayDate = new Font("Segoe UI", 7F))
            using (SolidBrush dotBrush = new SolidBrush(Color.FromArgb(203, 213, 225)))
            {
                for (int i = 0; i < n; i++)
                {
                    var pt = salesTrend[i];
                    int xCenter = padLeft + (i * barSlot) + (barSlot / 2);
                    int x = xCenter - (barW / 2);

                    int barHeight = (int)((pt.Revenue / maxRev) * chartH);
                    if (barHeight < 4 && pt.Revenue > 0) barHeight = 4;
                    int y = padTop + chartH - barHeight;

                    // Bar brush gradient & value
                    if (barHeight > 0)
                    {
                        using (LinearGradientBrush brush = new LinearGradientBrush(
                            new Rectangle(x, y, barW, barHeight),
                            Color.FromArgb(59, 130, 246),
                            Color.FromArgb(37, 99, 235),
                            LinearGradientMode.Vertical))
                        {
                            g.FillRectangle(brush, x, y, barW, barHeight);
                        }

                        // Value label on top of bar
                        string revText = pt.Revenue % 1 == 0 ? $"${pt.Revenue:N0}" : $"${pt.Revenue:N2}";
                        Rectangle textRect = new Rectangle(x - 14, Math.Max(4, y - 18), barW + 28, 16);
                        TextRenderer.DrawText(g, revText, fVal, textRect, Color.FromArgb(15, 23, 42), TextFormatFlags.HorizontalCenter);
                    }
                    else
                    {
                        // 2px baseline indicator for 0 sales
                        g.FillRectangle(dotBrush, x, padTop + chartH - 2, barW, 2);
                    }

                    // 2-line Day and Date label below baseline
                    string dayName = pt.Date.ToString("ddd");
                    string dateStr = pt.Date.ToString("MM/dd");
                    Rectangle rDayName = new Rectangle(xCenter - (barSlot / 2), padTop + chartH + 3, barSlot, 14);
                    Rectangle rDayDate = new Rectangle(xCenter - (barSlot / 2), padTop + chartH + 17, barSlot, 14);
                    TextRenderer.DrawText(g, dayName, fDayName, rDayName, Color.FromArgb(51, 65, 85), TextFormatFlags.HorizontalCenter);
                    TextRenderer.DrawText(g, dateStr, fDayDate, rDayDate, Color.FromArgb(100, 116, 139), TextFormatFlags.HorizontalCenter);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
            Program.MySN(this, "Dashboard analytics refreshed", Color.Teal);
        }

        private void btnQuickSale_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Form1)?.AddPage2Tab(new uc_sale(), "SALES");
        }

        private void btnQuickProduct_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Form1)?.AddPage2Tab(new uc_product(), "PRODUCT");
        }

        private void btnQuickCustomer_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Form1)?.AddPage2Tab(new uc_customer(), "CUSTOMER");
        }

        private void btnQuickReport_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Form1)?.AddPage2Tab(new uc_report(), "REPORTS");
        }

        private void lblAlert_Click(object sender, EventArgs e)
        {
            if (Program.IsAdmin)
            {
                (this.ParentForm as Form1)?.AddPage2Tab(new uc_product(), "PRODUCT");
            }
        }
    }
}
