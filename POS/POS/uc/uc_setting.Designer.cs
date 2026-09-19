namespace POS_204_oracle.uc
{
    partial class uc_setting
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblSaveStatus = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlReceiptCard = new System.Windows.Forms.Panel();
            this.nudExchangeRate = new System.Windows.Forms.NumericUpDown();
            this.lblExchangeRate = new System.Windows.Forms.Label();
            this.txtReceiptFooter = new System.Windows.Forms.TextBox();
            this.lblReceiptFooter = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblContactTitle = new System.Windows.Forms.Label();
            this.pnlBrandingCard = new System.Windows.Forms.Panel();
            this.pnlPreviewBox = new System.Windows.Forms.Panel();
            this.lblPreviewBrandSlogan = new System.Windows.Forms.Label();
            this.lblPreviewBrandName = new System.Windows.Forms.Label();
            this.picPreviewLogo = new System.Windows.Forms.PictureBox();
            this.lblPreviewTitle = new System.Windows.Forms.Label();
            this.btnClearLogo = new System.Windows.Forms.Button();
            this.btnBrowseLogo = new System.Windows.Forms.Button();
            this.picLogoPreview = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.txtSlogan = new System.Windows.Forms.TextBox();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBrandingTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlReceiptCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExchangeRate)).BeginInit();
            this.pnlBrandingCard.SuspendLayout();
            this.pnlPreviewBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(24, 12, 24, 12);
            this.pnlHeader.Size = new System.Drawing.Size(1200, 72);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.AutoScroll = true;
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.pnlBody.Controls.Add(this.pnlFooter);
            this.pnlBody.Controls.Add(this.pnlReceiptCard);
            this.pnlBody.Controls.Add(this.pnlBrandingCard);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 72);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(24);
            this.pnlBody.Size = new System.Drawing.Size(1200, 678);
            this.pnlBody.TabIndex = 1;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFooter.Controls.Add(this.lblSaveStatus);
            this.pnlFooter.Controls.Add(this.btnReset);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Location = new System.Drawing.Point(24, 560);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(20);
            this.pnlFooter.Size = new System.Drawing.Size(1140, 70);
            this.pnlFooter.TabIndex = 2;
            // 
            // lblSaveStatus
            // 
            this.lblSaveStatus.AutoSize = true;
            this.lblSaveStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSaveStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblSaveStatus.Location = new System.Drawing.Point(435, 26);
            this.lblSaveStatus.Name = "lblSaveStatus";
            this.lblSaveStatus.Size = new System.Drawing.Size(0, 21);
            this.lblSaveStatus.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnReset.Location = new System.Drawing.Point(256, 14);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(160, 42);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "🔄 Reset Defaults";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.btnSave.Location = new System.Drawing.Point(20, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 42);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "💾 Save Settings";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlReceiptCard
            // 
            this.pnlReceiptCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.pnlReceiptCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReceiptCard.Controls.Add(this.nudExchangeRate);
            this.pnlReceiptCard.Controls.Add(this.lblExchangeRate);
            this.pnlReceiptCard.Controls.Add(this.txtReceiptFooter);
            this.pnlReceiptCard.Controls.Add(this.lblReceiptFooter);
            this.pnlReceiptCard.Controls.Add(this.txtAddress);
            this.pnlReceiptCard.Controls.Add(this.lblAddress);
            this.pnlReceiptCard.Controls.Add(this.txtEmail);
            this.pnlReceiptCard.Controls.Add(this.lblEmail);
            this.pnlReceiptCard.Controls.Add(this.txtPhone);
            this.pnlReceiptCard.Controls.Add(this.lblPhone);
            this.pnlReceiptCard.Controls.Add(this.lblContactTitle);
            this.pnlReceiptCard.Location = new System.Drawing.Point(604, 24);
            this.pnlReceiptCard.Name = "pnlReceiptCard";
            this.pnlReceiptCard.Padding = new System.Windows.Forms.Padding(24);
            this.pnlReceiptCard.Size = new System.Drawing.Size(560, 520);
            this.pnlReceiptCard.TabIndex = 1;
            // 
            // nudExchangeRate
            // 
            this.nudExchangeRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.nudExchangeRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudExchangeRate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.nudExchangeRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.nudExchangeRate.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudExchangeRate.Location = new System.Drawing.Point(22, 327);
            this.nudExchangeRate.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudExchangeRate.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudExchangeRate.Name = "nudExchangeRate";
            this.nudExchangeRate.Size = new System.Drawing.Size(240, 30);
            this.nudExchangeRate.TabIndex = 9;
            this.nudExchangeRate.Value = new decimal(new int[] {
            4100,
            0,
            0,
            0});
            // 
            // lblExchangeRate
            // 
            this.lblExchangeRate.AutoSize = true;
            this.lblExchangeRate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblExchangeRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblExchangeRate.Location = new System.Drawing.Point(22, 305);
            this.lblExchangeRate.Name = "lblExchangeRate";
            this.lblExchangeRate.Size = new System.Drawing.Size(213, 20);
            this.lblExchangeRate.TabIndex = 10;
            this.lblExchangeRate.Text = "Default Exchange Rate (USD)";
            // 
            // txtReceiptFooter
            // 
            this.txtReceiptFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtReceiptFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReceiptFooter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtReceiptFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtReceiptFooter.Location = new System.Drawing.Point(22, 230);
            this.txtReceiptFooter.Multiline = true;
            this.txtReceiptFooter.Name = "txtReceiptFooter";
            this.txtReceiptFooter.Size = new System.Drawing.Size(512, 60);
            this.txtReceiptFooter.TabIndex = 8;
            // 
            // lblReceiptFooter
            // 
            this.lblReceiptFooter.AutoSize = true;
            this.lblReceiptFooter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblReceiptFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblReceiptFooter.Location = new System.Drawing.Point(22, 210);
            this.lblReceiptFooter.Name = "lblReceiptFooter";
            this.lblReceiptFooter.Size = new System.Drawing.Size(176, 20);
            this.lblReceiptFooter.TabIndex = 11;
            this.lblReceiptFooter.Text = "Receipt Footer Message";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtAddress.Location = new System.Drawing.Point(22, 136);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(512, 60);
            this.txtAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblAddress.Location = new System.Drawing.Point(22, 116);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(167, 20);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Physical Store Address";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtEmail.Location = new System.Drawing.Point(280, 78);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(254, 30);
            this.txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblEmail.Location = new System.Drawing.Point(280, 58);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(108, 20);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email Address";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtPhone.Location = new System.Drawing.Point(22, 78);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(240, 30);
            this.txtPhone.TabIndex = 5;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblPhone.Location = new System.Drawing.Point(22, 58);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(167, 20);
            this.lblPhone.TabIndex = 14;
            this.lblPhone.Text = "Store Phone Number *";
            // 
            // lblContactTitle
            // 
            this.lblContactTitle.AutoSize = true;
            this.lblContactTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblContactTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblContactTitle.Location = new System.Drawing.Point(20, 18);
            this.lblContactTitle.Name = "lblContactTitle";
            this.lblContactTitle.Size = new System.Drawing.Size(230, 28);
            this.lblContactTitle.TabIndex = 15;
            this.lblContactTitle.Text = " Store Contact & Receipt";
            // 
            // pnlBrandingCard
            // 
            this.pnlBrandingCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.pnlBrandingCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBrandingCard.Controls.Add(this.pnlPreviewBox);
            this.pnlBrandingCard.Controls.Add(this.btnClearLogo);
            this.pnlBrandingCard.Controls.Add(this.btnBrowseLogo);
            this.pnlBrandingCard.Controls.Add(this.picLogoPreview);
            this.pnlBrandingCard.Controls.Add(this.lblLogo);
            this.pnlBrandingCard.Controls.Add(this.txtSlogan);
            this.pnlBrandingCard.Controls.Add(this.lblSlogan);
            this.pnlBrandingCard.Controls.Add(this.txtName);
            this.pnlBrandingCard.Controls.Add(this.lblName);
            this.pnlBrandingCard.Controls.Add(this.lblBrandingTitle);
            this.pnlBrandingCard.Location = new System.Drawing.Point(24, 24);
            this.pnlBrandingCard.Name = "pnlBrandingCard";
            this.pnlBrandingCard.Padding = new System.Windows.Forms.Padding(24);
            this.pnlBrandingCard.Size = new System.Drawing.Size(560, 520);
            this.pnlBrandingCard.TabIndex = 0;
            // 
            // pnlPreviewBox
            // 
            this.pnlPreviewBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.pnlPreviewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPreviewBox.Controls.Add(this.lblPreviewBrandSlogan);
            this.pnlPreviewBox.Controls.Add(this.lblPreviewBrandName);
            this.pnlPreviewBox.Controls.Add(this.picPreviewLogo);
            this.pnlPreviewBox.Controls.Add(this.lblPreviewTitle);
            this.pnlPreviewBox.Location = new System.Drawing.Point(22, 356);
            this.pnlPreviewBox.Name = "pnlPreviewBox";
            this.pnlPreviewBox.Size = new System.Drawing.Size(512, 140);
            this.pnlPreviewBox.TabIndex = 5;
            // 
            // lblPreviewBrandSlogan
            // 
            this.lblPreviewBrandSlogan.AutoSize = true;
            this.lblPreviewBrandSlogan.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPreviewBrandSlogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblPreviewBrandSlogan.Location = new System.Drawing.Point(90, 66);
            this.lblPreviewBrandSlogan.Name = "lblPreviewBrandSlogan";
            this.lblPreviewBrandSlogan.Size = new System.Drawing.Size(204, 20);
            this.lblPreviewBrandSlogan.TabIndex = 0;
            this.lblPreviewBrandSlogan.Text = "Quality Products & Best Service";
            // 
            // lblPreviewBrandName
            // 
            this.lblPreviewBrandName.AutoSize = true;
            this.lblPreviewBrandName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPreviewBrandName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblPreviewBrandName.Location = new System.Drawing.Point(88, 38);
            this.lblPreviewBrandName.Name = "lblPreviewBrandName";
            this.lblPreviewBrandName.Size = new System.Drawing.Size(284, 28);
            this.lblPreviewBrandName.TabIndex = 1;
            this.lblPreviewBrandName.Text = "POINT OF SALE PRO SYSTEM";
            // 
            // picPreviewLogo
            // 
            this.picPreviewLogo.BackColor = System.Drawing.Color.Transparent;
            this.picPreviewLogo.Location = new System.Drawing.Point(16, 34);
            this.picPreviewLogo.Name = "picPreviewLogo";
            this.picPreviewLogo.Size = new System.Drawing.Size(64, 56);
            this.picPreviewLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreviewLogo.TabIndex = 6;
            this.picPreviewLogo.TabStop = false;
            // 
            // lblPreviewTitle
            // 
            this.lblPreviewTitle.AutoSize = true;
            this.lblPreviewTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblPreviewTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.lblPreviewTitle.Location = new System.Drawing.Point(14, 10);
            this.lblPreviewTitle.Name = "lblPreviewTitle";
            this.lblPreviewTitle.Size = new System.Drawing.Size(213, 17);
            this.lblPreviewTitle.TabIndex = 7;
            this.lblPreviewTitle.Text = "LIVE TOP BAR HEADER PREVIEW:";
            // 
            // btnClearLogo
            // 
            this.btnClearLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btnClearLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearLogo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.btnClearLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLogo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnClearLogo.Location = new System.Drawing.Point(225, 248);
            this.btnClearLogo.Name = "btnClearLogo";
            this.btnClearLogo.Size = new System.Drawing.Size(170, 32);
            this.btnClearLogo.TabIndex = 4;
            this.btnClearLogo.Text = "✕ Remove Logo";
            this.btnClearLogo.UseVisualStyleBackColor = false;
            this.btnClearLogo.Click += new System.EventHandler(this.btnClearLogo_Click);
            // 
            // btnBrowseLogo
            // 
            this.btnBrowseLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnBrowseLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseLogo.FlatAppearance.BorderSize = 0;
            this.btnBrowseLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseLogo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnBrowseLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.btnBrowseLogo.Location = new System.Drawing.Point(225, 202);
            this.btnBrowseLogo.Name = "btnBrowseLogo";
            this.btnBrowseLogo.Size = new System.Drawing.Size(170, 36);
            this.btnBrowseLogo.TabIndex = 3;
            this.btnBrowseLogo.Text = "Browse Logo...";
            this.btnBrowseLogo.UseVisualStyleBackColor = false;
            this.btnBrowseLogo.Click += new System.EventHandler(this.btnBrowseLogo_Click);
            // 
            // picLogoPreview
            // 
            this.picLogoPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.picLogoPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogoPreview.Location = new System.Drawing.Point(22, 198);
            this.picLogoPreview.Name = "picLogoPreview";
            this.picLogoPreview.Size = new System.Drawing.Size(190, 140);
            this.picLogoPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoPreview.TabIndex = 3;
            this.picLogoPreview.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblLogo.Location = new System.Drawing.Point(22, 175);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(114, 20);
            this.lblLogo.TabIndex = 7;
            this.lblLogo.Text = "Company Logo";
            // 
            // txtSlogan
            // 
            this.txtSlogan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtSlogan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSlogan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSlogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtSlogan.Location = new System.Drawing.Point(22, 136);
            this.txtSlogan.Name = "txtSlogan";
            this.txtSlogan.Size = new System.Drawing.Size(512, 30);
            this.txtSlogan.TabIndex = 2;
            this.txtSlogan.TextChanged += new System.EventHandler(this.txtSlogan_TextChanged);
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSlogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSlogan.Location = new System.Drawing.Point(22, 116);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(121, 20);
            this.lblSlogan.TabIndex = 8;
            this.lblSlogan.Text = "Tagline / Slogan";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtName.Location = new System.Drawing.Point(22, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(512, 31);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblName.Location = new System.Drawing.Point(22, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(184, 20);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Company / Store Name *";
            // 
            // lblBrandingTitle
            // 
            this.lblBrandingTitle.AutoSize = true;
            this.lblBrandingTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBrandingTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblBrandingTitle.Location = new System.Drawing.Point(20, 18);
            this.lblBrandingTitle.Name = "lblBrandingTitle";
            this.lblBrandingTitle.Size = new System.Drawing.Size(238, 28);
            this.lblBrandingTitle.TabIndex = 10;
            this.lblBrandingTitle.Text = "Company Identity & Logo";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblTitle.Location = new System.Drawing.Point(22, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(338, 31);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "COMPANY & SYSTEM SETTINGS";
            // 
            // uc_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "uc_setting";
            this.Size = new System.Drawing.Size(1200, 750);
            this.Load += new System.EventHandler(this.uc_setting_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlReceiptCard.ResumeLayout(false);
            this.pnlReceiptCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExchangeRate)).EndInit();
            this.pnlBrandingCard.ResumeLayout(false);
            this.pnlBrandingCard.PerformLayout();
            this.pnlPreviewBox.ResumeLayout(false);
            this.pnlPreviewBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;

        private System.Windows.Forms.Panel pnlBody;

        private System.Windows.Forms.Panel pnlBrandingCard;
        private System.Windows.Forms.Label lblBrandingTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.TextBox txtSlogan;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox picLogoPreview;
        private System.Windows.Forms.Button btnBrowseLogo;
        private System.Windows.Forms.Button btnClearLogo;

        private System.Windows.Forms.Panel pnlPreviewBox;
        private System.Windows.Forms.Label lblPreviewTitle;
        private System.Windows.Forms.PictureBox picPreviewLogo;
        private System.Windows.Forms.Label lblPreviewBrandName;

        private System.Windows.Forms.Panel pnlReceiptCard;
        private System.Windows.Forms.Label lblContactTitle;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblReceiptFooter;
        private System.Windows.Forms.TextBox txtReceiptFooter;
        private System.Windows.Forms.Label lblExchangeRate;
        private System.Windows.Forms.NumericUpDown nudExchangeRate;

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblSaveStatus;
        private System.Windows.Forms.Label lblPreviewBrandSlogan;
        private System.Windows.Forms.Label lblTitle;
    }
}
