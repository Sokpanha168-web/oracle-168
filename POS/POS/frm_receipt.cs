using POS_204_oracle.Controller;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace POS_204_oracle
{
    public partial class frm_receipt : Form
    {
        private SaleReceipt receipt;

        public frm_receipt(SaleReceipt receipt)
        {
            InitializeComponent();
            this.receipt = receipt;
            RenderReceipt();
        }

        private void RenderReceipt()
        {
            if (receipt == null) return;

            var cfg = SettingController.Current ?? new CompanySettings();
            string compName = string.IsNullOrWhiteSpace(cfg.CompanyName) ? "POINT OF SALE PRO SYSTEM" : cfg.CompanyName;
            string compAddress = string.IsNullOrWhiteSpace(cfg.CompanyAddress) ? "Phnom Penh, Cambodia" : cfg.CompanyAddress;
            string compPhone = string.IsNullOrWhiteSpace(cfg.CompanyPhone) ? "Tel: +855 (0) 12 345 678" : "Tel: " + cfg.CompanyPhone;
            string footer = string.IsNullOrWhiteSpace(cfg.ReceiptFooter) ? "THANK YOU FOR YOUR PURCHASE! Please come again!" : cfg.ReceiptFooter;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("========================================");
            sb.AppendLine(CenterText(compName, 40));
            if (!string.IsNullOrWhiteSpace(compAddress)) sb.AppendLine(CenterText(compAddress, 40));
            if (!string.IsNullOrWhiteSpace(compPhone)) sb.AppendLine(CenterText(compPhone, 40));
            sb.AppendLine("========================================");
            sb.AppendLine($" Receipt No : #{receipt.SaleId:D6}");
            sb.AppendLine($" Date/Time  : {receipt.SaleDate:yyyy-MM-dd HH:mm:ss}");
            sb.AppendLine($" Cashier    : {receipt.CashierName}");
            sb.AppendLine($" Customer   : {receipt.CustomerName}");
            if (!string.IsNullOrWhiteSpace(receipt.CustomerPhone))
            {
                sb.AppendLine($" Phone      : {receipt.CustomerPhone}");
            }
            sb.AppendLine("----------------------------------------");
            sb.AppendLine(" ITEM              QTY   PRICE    TOTAL");
            sb.AppendLine("----------------------------------------");

            foreach (var it in receipt.Items)
            {
                string name = it.ProductName.Length > 16 ? it.ProductName.Substring(0, 14) + ".." : it.ProductName.PadRight(16);
                string qty = it.Qty.ToString("0").PadLeft(4);
                string price = $"${it.Price:0.00}".PadLeft(8);
                string total = $"${it.ItemGrandTotal:0.00}".PadLeft(9);
                sb.AppendLine($"{name} {qty} {price} {total}");
                if (it.DiscountPercent > 0)
                {
                    sb.AppendLine($"  (Disc {it.DiscountPercent:0}%: -${it.DiscountAmount:0.00})");
                }
            }

            sb.AppendLine("----------------------------------------");
            sb.AppendLine($" Subtotal    : ${receipt.SubTotal:N2}".PadLeft(39));
            if (receipt.SaleDiscount > 0)
            {
                sb.AppendLine($" Discount    : -${receipt.SaleDiscount:N2}".PadLeft(39));
            }
            sb.AppendLine($" GRAND TOTAL : ${receipt.GrandTotalUSD:N2}".PadLeft(39));
            sb.AppendLine($" Cash Paid   : ${receipt.Paid:N2}".PadLeft(39));
            sb.AppendLine($" Change      : ${receipt.ChangeUSD:N2}".PadLeft(39));
            sb.AppendLine("========================================");
            sb.AppendLine(CenterText(footer, 40));
            sb.AppendLine("========================================");

            txtReceipt.Text = sb.ToString();
        }

        private string CenterText(string text, int width)
        {
            if (string.IsNullOrEmpty(text)) return "";
            if (text.Length >= width) return text.Substring(0, width);
            int left = (width - text.Length) / 2;
            return text.PadLeft(left + text.Length).PadRight(width);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += (s, ev) =>
                {
                    using (Font printFont = new Font("Consolas", 9F))
                    {
                        ev.Graphics.DrawString(txtReceipt.Text, printFont, Brushes.Black, 20, 20);
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

        private void txtReceipt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
