using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace POS_204_oracle
{
    public partial class frm_payment : Form
    {
        private decimal _grandTotal = 0m;
        private decimal _exchangeRate = 4100m;

        public decimal GrandTotal => _grandTotal;
        public decimal AmountPaid { get; private set; }
        public decimal ChangeDue { get; private set; }
        public string PaymentMethod { get; private set; } = "Cash";
        public bool AutoPrintReceipt => chkPrintReceipt.Checked;

        public frm_payment()
        {
            InitializeComponent();
        }

        public frm_payment(decimal grandTotal, decimal exchangeRate = 4100m) : this()
        {
            _grandTotal = Math.Max(0m, grandTotal);
            _exchangeRate = exchangeRate > 0 ? exchangeRate : 4100m;
        }

        private void frm_payment_Load(object sender, EventArgs e)
        {
            lblDueUSD.Text = "$" + _grandTotal.ToString("N2");
            lblDueKHR.Text = $"KHR ~ {(_grandTotal * _exchangeRate):N0} ៛";

            txtPaid.Text = _grandTotal.ToString("0.00");
            RecalculateChange();

            this.BeginInvoke(new Action(() =>
            {
                txtPaid.Focus();
                txtPaid.SelectAll();
            }));
        }

        private void RecalculateChange()
        {
            string text = txtPaid.Text.Trim().Replace("$", "");
            if (decimal.TryParse(text, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal paid))
            {
                AmountPaid = paid;
                ChangeDue = paid - _grandTotal;

                if (ChangeDue >= 0)
                {
                    pnlChangeCard.BackColor = Color.FromArgb(236, 253, 245);
                    lblChangeCaption.Text = "CHANGE DUE TO CUSTOMER";
                    lblChangeCaption.ForeColor = Color.FromArgb(6, 95, 70);
                    lblChangeVal.Text = "+ $" + ChangeDue.ToString("N2");
                    lblChangeVal.ForeColor = Color.FromArgb(4, 120, 87);
                    lblChangeKHR.Text = $"KHR ~ {(ChangeDue * _exchangeRate):N0} ៛";
                    lblChangeKHR.ForeColor = Color.FromArgb(5, 150, 105);
                }
                else
                {
                    pnlChangeCard.BackColor = Color.FromArgb(254, 242, 242);
                    lblChangeCaption.Text = "AMOUNT STILL DUE (UNDERPAID)";
                    lblChangeCaption.ForeColor = Color.FromArgb(153, 27, 27);
                    lblChangeVal.Text = "- $" + Math.Abs(ChangeDue).ToString("N2");
                    lblChangeVal.ForeColor = Color.FromArgb(220, 38, 38);
                    lblChangeKHR.Text = $"Short: {(Math.Abs(ChangeDue) * _exchangeRate):N0} ៛";
                    lblChangeKHR.ForeColor = Color.FromArgb(220, 38, 38);
                }
            }
            else
            {
                AmountPaid = 0m;
                ChangeDue = -_grandTotal;
                pnlChangeCard.BackColor = Color.FromArgb(254, 242, 242);
                lblChangeCaption.Text = "INVALID AMOUNT ENTERED";
                lblChangeCaption.ForeColor = Color.FromArgb(153, 27, 27);
                lblChangeVal.Text = "$0.00";
                lblChangeVal.ForeColor = Color.FromArgb(220, 38, 38);
                lblChangeKHR.Text = "Enter numbers only";
                lblChangeKHR.ForeColor = Color.FromArgb(220, 38, 38);
            }

            pnlChangeCard.Invalidate();
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            RecalculateChange();
        }

        private void txtPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
       
            if (char.IsControl(e.KeyChar)) return;

    
            if (char.IsDigit(e.KeyChar)) return;

        
            if (e.KeyChar == '.' && !txtPaid.Text.Contains(".")) return;

   
            e.Handled = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string text = txtPaid.Text.Trim().Replace("$", "");
            if (!decimal.TryParse(text, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal paid) || paid < 0)
            {
                MessageBox.Show("Please enter a valid positive payment amount.", "Invalid Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPaid.Focus();
                txtPaid.SelectAll();
                return;
            }

            if (paid < _grandTotal)
            {
                decimal shortAmount = _grandTotal - paid;
                var res = MessageBox.Show(
                    $"The customer has only paid ${paid:N2}, which is ${shortAmount:N2} less than the Grand Total (${_grandTotal:N2}).\n\nDo you want to proceed and save this sale?",
                    "Underpaid Notice",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (res != DialogResult.Yes)
                {
                    txtPaid.Focus();
                    txtPaid.SelectAll();
                    return;
                }
            }

            AmountPaid = paid;
            ChangeDue = Math.Max(0m, paid - _grandTotal);

            //if (rbQR.Checked) PaymentMethod = "KHQR / Bank Transfer";
            //else if (rbCard.Checked) PaymentMethod = "Credit / Debit Card";
            //else PaymentMethod = "Cash";

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frm_payment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnCancel_Click(sender, e);
            }
        }

        private void pnlDueCard_Paint(object sender, PaintEventArgs e)
        {
            using (Pen p = new Pen(Color.FromArgb(59, 130, 246), 1.5f))
            {
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawRectangle(p, 0, 0, pnlDueCard.Width - 1, pnlDueCard.Height - 1);
            }
        }

        private void pnlCashReceived_Paint(object sender, PaintEventArgs e)
        {
            using (Pen p = new Pen(Color.FromArgb(148, 163, 184), 1.5f))
            {
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawRectangle(p, 0, 0, pnlCashReceived.Width - 1, pnlCashReceived.Height - 1);
            }
        }

        private void pnlChangeCard_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = ChangeDue >= 0 ? Color.FromArgb(16, 185, 129) : Color.FromArgb(239, 68, 68);
            using (Pen p = new Pen(borderColor, 1.5f))
            {
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawRectangle(p, 0, 0, pnlChangeCard.Width - 1, pnlChangeCard.Height - 1);
            }
        }

        private void pnlBottom_Paint(object sender, PaintEventArgs e)
        {
            using (Pen p = new Pen(Color.FromArgb(148, 163, 184), 1.5f))
            {
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawLine(p, 0, 0, pnlBottom.Width, 0);
            }
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
