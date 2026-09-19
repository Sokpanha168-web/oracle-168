namespace POS_204_oracle
{
    partial class frm_payment
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.chkPrintReceipt = new System.Windows.Forms.CheckBox();
            this.pnlChangeCard = new System.Windows.Forms.Panel();
            this.lblChangeKHR = new System.Windows.Forms.Label();
            this.lblChangeVal = new System.Windows.Forms.Label();
            this.lblChangeCaption = new System.Windows.Forms.Label();
            this.pnlCashReceived = new System.Windows.Forms.Panel();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.lblReceivedCaption = new System.Windows.Forms.Label();
            this.pnlDueCard = new System.Windows.Forms.Panel();
            this.lblDueKHR = new System.Windows.Forms.Label();
            this.lblDueUSD = new System.Windows.Forms.Label();
            this.lblDueCaption = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlChangeCard.SuspendLayout();
            this.pnlCashReceived.SuspendLayout();
            this.pnlDueCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(30)))));
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(480, 56);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(480, 56);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "⚡ CHECKOUT & PAYMENT";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.UseMnemonic = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(30)))));
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnConfirm);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 480);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(480, 68);
            this.pnlBottom.TabIndex = 1;
            this.pnlBottom.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBottom_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnCancel.Location = new System.Drawing.Point(122, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(252, 14);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(212, 40);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirm Payment";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.pnlBody.Controls.Add(this.chkPrintReceipt);
            this.pnlBody.Controls.Add(this.pnlChangeCard);
            this.pnlBody.Controls.Add(this.pnlCashReceived);
            this.pnlBody.Controls.Add(this.pnlDueCard);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 56);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(480, 424);
            this.pnlBody.TabIndex = 2;
            // 
            // chkPrintReceipt
            // 
            this.chkPrintReceipt.AutoSize = true;
            this.chkPrintReceipt.Checked = true;
            this.chkPrintReceipt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPrintReceipt.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.chkPrintReceipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.chkPrintReceipt.Location = new System.Drawing.Point(16, 388);
            this.chkPrintReceipt.Name = "chkPrintReceipt";
            this.chkPrintReceipt.Size = new System.Drawing.Size(325, 25);
            this.chkPrintReceipt.TabIndex = 3;
            this.chkPrintReceipt.Text = "Automatically print receipt after checkout";
            this.chkPrintReceipt.UseVisualStyleBackColor = true;
            // 
            // pnlChangeCard
            // 
            this.pnlChangeCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.pnlChangeCard.Controls.Add(this.lblChangeKHR);
            this.pnlChangeCard.Controls.Add(this.lblChangeVal);
            this.pnlChangeCard.Controls.Add(this.lblChangeCaption);
            this.pnlChangeCard.Location = new System.Drawing.Point(14, 178);
            this.pnlChangeCard.Name = "pnlChangeCard";
            this.pnlChangeCard.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.pnlChangeCard.Size = new System.Drawing.Size(450, 194);
            this.pnlChangeCard.TabIndex = 2;
            this.pnlChangeCard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChangeCard_Paint);
            // 
            // lblChangeKHR
            // 
            this.lblChangeKHR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChangeKHR.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblChangeKHR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblChangeKHR.Location = new System.Drawing.Point(226, 32);
            this.lblChangeKHR.Name = "lblChangeKHR";
            this.lblChangeKHR.Size = new System.Drawing.Size(210, 26);
            this.lblChangeKHR.TabIndex = 2;
            this.lblChangeKHR.Text = "KHR ~ 0 ៛";
            this.lblChangeKHR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChangeVal
            // 
            this.lblChangeVal.AutoSize = true;
            this.lblChangeVal.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblChangeVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.lblChangeVal.Location = new System.Drawing.Point(10, 24);
            this.lblChangeVal.Name = "lblChangeVal";
            this.lblChangeVal.Size = new System.Drawing.Size(155, 50);
            this.lblChangeVal.TabIndex = 1;
            this.lblChangeVal.Text = "+ $0.00";
            // 
            // lblChangeCaption
            // 
            this.lblChangeCaption.AutoSize = true;
            this.lblChangeCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblChangeCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.lblChangeCaption.Location = new System.Drawing.Point(12, 8);
            this.lblChangeCaption.Name = "lblChangeCaption";
            this.lblChangeCaption.Size = new System.Drawing.Size(211, 20);
            this.lblChangeCaption.TabIndex = 0;
            this.lblChangeCaption.Text = "CHANGE DUE TO CUSTOMER";
            // 
            // pnlCashReceived
            // 
            this.pnlCashReceived.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.pnlCashReceived.Controls.Add(this.txtPaid);
            this.pnlCashReceived.Controls.Add(this.lblReceivedCaption);
            this.pnlCashReceived.Location = new System.Drawing.Point(14, 94);
            this.pnlCashReceived.Name = "pnlCashReceived";
            this.pnlCashReceived.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.pnlCashReceived.Size = new System.Drawing.Size(450, 76);
            this.pnlCashReceived.TabIndex = 1;
            this.pnlCashReceived.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCashReceived_Paint);
            // 
            // txtPaid
            // 
            this.txtPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(35)))));
            this.txtPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaid.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.txtPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtPaid.Location = new System.Drawing.Point(12, 30);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(426, 41);
            this.txtPaid.TabIndex = 1;
            this.txtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPaid.TextChanged += new System.EventHandler(this.txtPaid_TextChanged);
            this.txtPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaid_KeyPress);
            // 
            // lblReceivedCaption
            // 
            this.lblReceivedCaption.AutoSize = true;
            this.lblReceivedCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblReceivedCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblReceivedCaption.Location = new System.Drawing.Point(10, 8);
            this.lblReceivedCaption.Name = "lblReceivedCaption";
            this.lblReceivedCaption.Size = new System.Drawing.Size(244, 20);
            this.lblReceivedCaption.TabIndex = 0;
            this.lblReceivedCaption.Text = "Cash Received from Customer ($)";
            // 
            // pnlDueCard
            // 
            this.pnlDueCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.pnlDueCard.Controls.Add(this.lblDueKHR);
            this.pnlDueCard.Controls.Add(this.lblDueUSD);
            this.pnlDueCard.Controls.Add(this.lblDueCaption);
            this.pnlDueCard.Location = new System.Drawing.Point(14, 12);
            this.pnlDueCard.Name = "pnlDueCard";
            this.pnlDueCard.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.pnlDueCard.Size = new System.Drawing.Size(450, 74);
            this.pnlDueCard.TabIndex = 0;
            this.pnlDueCard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDueCard_Paint);
            // 
            // lblDueKHR
            // 
            this.lblDueKHR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDueKHR.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDueKHR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblDueKHR.Location = new System.Drawing.Point(226, 32);
            this.lblDueKHR.Name = "lblDueKHR";
            this.lblDueKHR.Size = new System.Drawing.Size(210, 26);
            this.lblDueKHR.TabIndex = 2;
            this.lblDueKHR.Text = "KHR ~ 0 ៛";
            this.lblDueKHR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDueUSD
            // 
            this.lblDueUSD.AutoSize = true;
            this.lblDueUSD.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblDueUSD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblDueUSD.Location = new System.Drawing.Point(10, 22);
            this.lblDueUSD.Name = "lblDueUSD";
            this.lblDueUSD.Size = new System.Drawing.Size(116, 50);
            this.lblDueUSD.TabIndex = 1;
            this.lblDueUSD.Text = "$0.00";
            // 
            // lblDueCaption
            // 
            this.lblDueCaption.AutoSize = true;
            this.lblDueCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDueCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.lblDueCaption.Location = new System.Drawing.Point(12, 8);
            this.lblDueCaption.Name = "lblDueCaption";
            this.lblDueCaption.Size = new System.Drawing.Size(160, 20);
            this.lblDueCaption.TabIndex = 0;
            this.lblDueCaption.Text = "TOTAL AMOUNT DUE";
            // 
            // frm_payment
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(480, 548);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_payment";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "POS Checkout & Payment";
            this.Load += new System.EventHandler(this.frm_payment_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_payment_KeyDown);
            this.pnlTop.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlChangeCard.ResumeLayout(false);
            this.pnlChangeCard.PerformLayout();
            this.pnlCashReceived.ResumeLayout(false);
            this.pnlCashReceived.PerformLayout();
            this.pnlDueCard.ResumeLayout(false);
            this.pnlDueCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlDueCard;
        private System.Windows.Forms.Label lblDueCaption;
        private System.Windows.Forms.Label lblDueUSD;
        private System.Windows.Forms.Label lblDueKHR;
        private System.Windows.Forms.Panel pnlCashReceived;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.Label lblReceivedCaption;
        private System.Windows.Forms.Panel pnlChangeCard;
        private System.Windows.Forms.Label lblChangeCaption;
        private System.Windows.Forms.Label lblChangeVal;
        private System.Windows.Forms.Label lblChangeKHR;
        private System.Windows.Forms.CheckBox chkPrintReceipt;
    }
}
