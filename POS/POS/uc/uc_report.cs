using POS_204_oracle.Controller;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace POS_204_oracle.uc
{
    public partial class uc_report : UserControl
    {
        private enum ReportMode { Sales, Inventory, Customers }
        private ReportMode currentMode = ReportMode.Sales;
        private ReportController reportCtrl = new ReportController();
        private CustomerController custCtrl = new CustomerController();
        private DataTable currentTable;

        public uc_report()
        {
            InitializeComponent();
        }

        private void uc_report_Load(object sender, EventArgs e)
        {
            Program.MyDG(dgReport);

            // Populate Presets
            cboPreset.SelectedIndex = 2; // "This Month" default
            dtpFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpTo.Value = DateTime.Now;

            LoadCustomerDropdown();
            SwitchMode(ReportMode.Sales);
        }

        private void LoadCustomerDropdown()
        {
            try
            {
                DataTable dtCust = custCtrl.GetAll();
                DataTable dtCombo = new DataTable();
                dtCombo.Columns.Add("customer_id", typeof(int));
                dtCombo.Columns.Add("customer_name", typeof(string));

                dtCombo.Rows.Add(0, "-- All Customers --");
                foreach (DataRow r in dtCust.Rows)
                {
                    dtCombo.Rows.Add(Convert.ToInt32(r["customer_id"]), r["customer_name"].ToString());
                }

                cboCustomer.DataSource = dtCombo;
                cboCustomer.DisplayMember = "customer_name";
                cboCustomer.ValueMember = "customer_id";
                cboCustomer.SelectedIndex = 0;
            }
            catch { }
        }

        private void cboPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            switch (cboPreset.SelectedItem?.ToString())
            {
                case "Today":
                    dtpFrom.Value = now.Date;
                    dtpTo.Value = now.Date;
                    break;
                case "This Week":
                    int diff = (7 + (now.DayOfWeek - DayOfWeek.Monday)) % 7;
                    dtpFrom.Value = now.AddDays(-1 * diff).Date;
                    dtpTo.Value = now.Date;
                    break;
                case "This Month":
                    dtpFrom.Value = new DateTime(now.Year, now.Month, 1);
                    dtpTo.Value = now.Date;
                    break;
                case "All Time":
                    dtpFrom.Value = new DateTime(2020, 1, 1);
                    dtpTo.Value = now.Date;
                    break;
                case "Custom":
                    // Keep user dates
                    break;
            }
        }

        private void SwitchMode(ReportMode mode)
        {
            currentMode = mode;

            // Update mode buttons styling
            Color activeBg = Color.FromArgb(16, 185, 129);
            Color activeText = Color.FromArgb(10, 14, 23);
            Color inActiveBg = Color.FromArgb(24, 34, 54);
            Color inActiveText = Color.FromArgb(148, 163, 184);

            btnModeSales.StateCommon.Back.Color1 = mode == ReportMode.Sales ? activeBg : inActiveBg;
            btnModeSales.StateCommon.Back.Color2 = mode == ReportMode.Sales ? activeBg : inActiveBg;
            btnModeSales.StateCommon.Content.ShortText.Color1 = mode == ReportMode.Sales ? activeText : inActiveText;

            btnModeInventory.StateCommon.Back.Color1 = mode == ReportMode.Inventory ? activeBg : inActiveBg;
            btnModeInventory.StateCommon.Back.Color2 = mode == ReportMode.Inventory ? activeBg : inActiveBg;
            btnModeInventory.StateCommon.Content.ShortText.Color1 = mode == ReportMode.Inventory ? activeText : inActiveText;

            btnModeCustomers.StateCommon.Back.Color1 = mode == ReportMode.Customers ? activeBg : inActiveBg;
            btnModeCustomers.StateCommon.Back.Color2 = mode == ReportMode.Customers ? activeBg : inActiveBg;
            btnModeCustomers.StateCommon.Content.ShortText.Color1 = mode == ReportMode.Customers ? activeText : inActiveText;

            pnlFilters.Visible = (mode == ReportMode.Sales);

            RunReport();
        }

        private void btnModeSales_Click(object sender, EventArgs e)
        {
            SwitchMode(ReportMode.Sales);
        }

        private void btnModeInventory_Click(object sender, EventArgs e)
        {
            SwitchMode(ReportMode.Inventory);
        }

        private void btnModeCustomers_Click(object sender, EventArgs e)
        {
            SwitchMode(ReportMode.Customers);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            RunReport();
        }

        public void RunReport()
        {
            switch (currentMode)
            {
                case ReportMode.Sales:
                    RunSalesReport();
                    break;
                case ReportMode.Inventory:
                    RunInventoryReport();
                    break;
                case ReportMode.Customers:
                    RunCustomerReport();
                    break;
            }
        }

        private void RunSalesReport()
        {
            DateTime f = dtpFrom.Value;
            DateTime t = dtpTo.Value;
            int? custId = null;
            if (cboCustomer.SelectedValue != null && Convert.ToInt32(cboCustomer.SelectedValue) > 0)
            {
                custId = Convert.ToInt32(cboCustomer.SelectedValue);
            }

            var summary = reportCtrl.GetSalesSummary(f, t, custId);
            currentTable = reportCtrl.GetSalesReport(f, t, custId);

            lblKpi1Title.Text = "TOTAL NET SALES";
            lblKpi1Val.Text = $"${summary.NetSales:N2}";

            lblKpi2Title.Text = "TOTAL ORDERS";
            lblKpi2Val.Text = summary.TotalOrders.ToString("N0");

            lblKpi3Title.Text = "TOTAL DISCOUNTS";
            lblKpi3Val.Text = $"${summary.TotalDiscount:N2}";

            lblKpi4Title.Text = "AVG ORDER VALUE";
            lblKpi4Val.Text = $"${summary.AverageOrderValue:N2}";

            lblGridTitle.Text = $"Sales Orders ({f:yyyy-MM-dd} to {t:yyyy-MM-dd}) - {currentTable.Rows.Count} record(s)";
            dgReport.DataSource = currentTable;
            Program.full_dg(dgReport);
        }

        private void RunInventoryReport()
        {
            var summary = reportCtrl.GetInventorySummary();
            currentTable = reportCtrl.GetInventoryReport();

            lblKpi1Title.Text = "TOTAL PRODUCTS";
            lblKpi1Val.Text = summary.TotalProducts.ToString("N0");

            lblKpi2Title.Text = "IN STOCK";
            lblKpi2Val.Text = summary.TotalInStock.ToString("N0");

            lblKpi3Title.Text = "LOW / OUT OF STOCK";
            lblKpi3Val.Text = $"{summary.TotalLowStock} low / {summary.TotalOutOfStock} out";

            lblKpi4Title.Text = "RETAIL VALUATION";
            lblKpi4Val.Text = $"${summary.TotalValuationRetail:N2}";

            lblGridTitle.Text = $"Inventory Stock & Valuation - {currentTable.Rows.Count} product(s)";
            dgReport.DataSource = currentTable;
            Program.full_dg(dgReport);
        }

        private void RunCustomerReport()
        {
            currentTable = reportCtrl.GetCustomerReport();

            decimal totalSpent = 0m;
            int withOrders = 0;
            string topCustomer = "None";
            decimal maxSpent = 0m;

            foreach (DataRow r in currentTable.Rows)
            {
                int ords = Convert.ToInt32(r["Orders Placed"]);
                decimal spent = Convert.ToDecimal(r["Total Spent ($)"]);
                totalSpent += spent;
                if (ords > 0) withOrders++;
                if (spent > maxSpent)
                {
                    maxSpent = spent;
                    topCustomer = r["Customer Name"].ToString();
                }
            }

            lblKpi1Title.Text = "CUSTOMER REVENUE";
            lblKpi1Val.Text = $"${totalSpent:N2}";

            lblKpi2Title.Text = "TOTAL CUSTOMERS";
            lblKpi2Val.Text = currentTable.Rows.Count.ToString("N0");

            lblKpi3Title.Text = "ACTIVE BUYERS";
            lblKpi3Val.Text = withOrders.ToString("N0");

            lblKpi4Title.Text = "TOP SPENDER";
            lblKpi4Val.Text = topCustomer;

            lblGridTitle.Text = $"Customer Lifetime Spending - {currentTable.Rows.Count} customer(s)";
            dgReport.DataSource = currentTable;
            Program.full_dg(dgReport);
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            if (currentTable == null || currentTable.Rows.Count == 0)
            {
                Program.MySN(this, "No report data to export", Color.Orange);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV Files (*.csv)|*.csv";
                sfd.FileName = $"{currentMode}_Report_{DateTime.Now:yyyyMMdd_HHmm}.csv";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    bool ok = ReportController.ExportToCsv(currentTable, sfd.FileName);
                    if (ok)
                    {
                        Program.MySN(this, "Report exported to CSV successfully!", Color.Green);
                    }
                    else
                    {
                        Program.MySN(this, "Failed to export report file", Color.Red);
                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (currentTable == null || currentTable.Rows.Count == 0)
            {
                Program.MySN(this, "No report data to print", Color.Orange);
                return;
            }

            try
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += (s, ev) =>
                {
                    Graphics g = ev.Graphics;
                    using (Font titleFont = new Font("Segoe UI", 12F, FontStyle.Bold))
                    using (Font headerFont = new Font("Segoe UI", 8.5F, FontStyle.Bold))
                    using (Font cellFont = new Font("Segoe UI", 8F))
                    using (Pen borderPen = new Pen(Color.LightGray))
                    {
                        g.DrawString($"POINT OF SALE PRO - {currentMode.ToString().ToUpper()} REPORT", titleFont, Brushes.Black, 20, 20);
                        g.DrawString($"Generated: {DateTime.Now:yyyy-MM-dd HH:mm:ss} | Total Records: {currentTable.Rows.Count}", cellFont, Brushes.Gray, 20, 45);

                        int y = 75;
                        int colCount = Math.Min(currentTable.Columns.Count, 7);
                        int colWidth = (ev.MarginBounds.Width) / colCount;

                        // Draw table header
                        for (int c = 0; c < colCount; c++)
                        {
                            Rectangle rect = new Rectangle(20 + (c * colWidth), y, colWidth, 24);
                            g.FillRectangle(Brushes.LightGray, rect);
                            g.DrawRectangle(borderPen, rect);
                            g.DrawString(currentTable.Columns[c].ColumnName, headerFont, Brushes.Black, rect);
                        }

                        y += 24;

                        // Draw rows (up to 35 rows per page)
                        int maxRows = Math.Min(currentTable.Rows.Count, 35);
                        for (int r = 0; r < maxRows; r++)
                        {
                            for (int c = 0; c < colCount; c++)
                            {
                                Rectangle rect = new Rectangle(20 + (c * colWidth), y, colWidth, 20);
                                g.DrawRectangle(borderPen, rect);
                                string val = currentTable.Rows[r][c]?.ToString() ?? "";
                                if (val.Length > 18) val = val.Substring(0, 16) + "..";
                                g.DrawString(val, cellFont, Brushes.Black, rect);
                            }
                            y += 20;
                        }
                    }
                };

                PrintDialog dlg = new PrintDialog();
                dlg.Document = pd;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pd.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Printing error: " + ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
