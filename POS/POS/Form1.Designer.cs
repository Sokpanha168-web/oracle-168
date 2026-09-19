namespace POS_204_oracle
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblBreadcrumb = new System.Windows.Forms.Label();
            this.lblStatusPill = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.picBrandLogo = new System.Windows.Forms.PictureBox();
            this.lblBrandBadge = new System.Windows.Forms.Label();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.pnlUserSection = new System.Windows.Forms.Panel();
            this.picUserAvatar = new System.Windows.Forms.PictureBox();
            this.lbluser = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelNav = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblNavSystem = new System.Windows.Forms.Label();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.lblNavInventory = new System.Windows.Forms.Label();
            this.btnSuppler = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.lblNavSales = new System.Windows.Forms.Label();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.MainTab = new System.Windows.Forms.TabControl();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBrandLogo)).BeginInit();
            this.pnlUserSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).BeginInit();
            this.panelNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.panelTop.Controls.Add(this.lblBreadcrumb);
            this.panelTop.Controls.Add(this.lblStatusPill);
            this.panelTop.Controls.Add(this.lblClock);
            this.panelTop.Controls.Add(this.picBrandLogo);
            this.panelTop.Controls.Add(this.lblBrandBadge);
            this.panelTop.Controls.Add(this.lblAppTitle);
            this.panelTop.Controls.Add(this.pnlUserSection);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1600, 69);
            this.panelTop.TabIndex = 0;
            // 
            // lblBreadcrumb
            // 
            this.lblBreadcrumb.AutoSize = true;
            this.lblBreadcrumb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadcrumb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.lblBreadcrumb.Location = new System.Drawing.Point(295, 25);
            this.lblBreadcrumb.Name = "lblBreadcrumb";
            this.lblBreadcrumb.Size = new System.Drawing.Size(185, 20);
            this.lblBreadcrumb.TabIndex = 5;
            this.lblBreadcrumb.Text = "SYSTEM  ›  DASHBOARD";
            // 
            // lblStatusPill
            // 
            this.lblStatusPill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblStatusPill.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusPill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.lblStatusPill.Location = new System.Drawing.Point(520, 20);
            this.lblStatusPill.Name = "lblStatusPill";
            this.lblStatusPill.Size = new System.Drawing.Size(135, 28);
            this.lblStatusPill.TabIndex = 6;
            this.lblStatusPill.Text = "● SYSTEM ONLINE";
            this.lblStatusPill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClock
            // 
            this.lblClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClock.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.lblClock.Location = new System.Drawing.Point(660, 22);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(320, 26);
            this.lblClock.TabIndex = 7;
            this.lblClock.Text = "--:--:-- --";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picBrandLogo
            // 
            this.picBrandLogo.Location = new System.Drawing.Point(19, 12);
            this.picBrandLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picBrandLogo.Name = "picBrandLogo";
            this.picBrandLogo.Size = new System.Drawing.Size(51, 45);
            this.picBrandLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBrandLogo.TabIndex = 4;
            this.picBrandLogo.TabStop = false;
            this.picBrandLogo.Visible = false;
            // 
            // lblBrandBadge
            // 
            this.lblBrandBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblBrandBadge.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandBadge.ForeColor = System.Drawing.Color.White;
            this.lblBrandBadge.Location = new System.Drawing.Point(19, 15);
            this.lblBrandBadge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrandBadge.Name = "lblBrandBadge";
            this.lblBrandBadge.Size = new System.Drawing.Size(51, 39);
            this.lblBrandBadge.TabIndex = 0;
            this.lblBrandBadge.Text = "⚡ POS";
            this.lblBrandBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(77, 18);
            this.lblAppTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(206, 30);
            this.lblAppTitle.TabIndex = 1;
            this.lblAppTitle.Text = "SALE PRO SYSTEM";
            // 
            // pnlUserSection
            // 
            this.pnlUserSection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUserSection.Controls.Add(this.picUserAvatar);
            this.pnlUserSection.Controls.Add(this.lbluser);
            this.pnlUserSection.Controls.Add(this.btnLogout);
            this.pnlUserSection.Location = new System.Drawing.Point(987, 10);
            this.pnlUserSection.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUserSection.Name = "pnlUserSection";
            this.pnlUserSection.Size = new System.Drawing.Size(600, 49);
            this.pnlUserSection.TabIndex = 3;
            // 
            // picUserAvatar
            // 
            this.picUserAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picUserAvatar.Image = global::POS_204_oracle.Properties.Resources.icons8_user_24;
            this.picUserAvatar.Location = new System.Drawing.Point(93, 10);
            this.picUserAvatar.Margin = new System.Windows.Forms.Padding(4);
            this.picUserAvatar.Name = "picUserAvatar";
            this.picUserAvatar.Size = new System.Drawing.Size(32, 30);
            this.picUserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picUserAvatar.TabIndex = 0;
            this.picUserAvatar.TabStop = false;
            this.picUserAvatar.Click += new System.EventHandler(this.picUserAvatar_Click);
            // 
            // lbluser
            // 
            this.lbluser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbluser.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.White;
            this.lbluser.Location = new System.Drawing.Point(133, 12);
            this.lbluser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(320, 25);
            this.lbluser.TabIndex = 1;
            this.lbluser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(467, 7);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(117, 34);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Sign Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.panelNav.Controls.Add(this.btnExit);
            this.panelNav.Controls.Add(this.btnSetting);
            this.panelNav.Controls.Add(this.btnUser);
            this.panelNav.Controls.Add(this.btnReport);
            this.panelNav.Controls.Add(this.lblNavSystem);
            this.panelNav.Controls.Add(this.btnSuppler);
            this.panelNav.Controls.Add(this.btnCategory);
            this.panelNav.Controls.Add(this.btnStock);
            this.panelNav.Controls.Add(this.btnProduct);
            this.panelNav.Controls.Add(this.lblNavInventory);
            this.panelNav.Controls.Add(this.btnCustomer);
            this.panelNav.Controls.Add(this.btnSale);
            this.panelNav.Controls.Add(this.btnDashboard);
            this.panelNav.Controls.Add(this.lblNavSales);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 69);
            this.panelNav.Margin = new System.Windows.Forms.Padding(4);
            this.panelNav.Name = "panelNav";
            this.panelNav.Padding = new System.Windows.Forms.Padding(12, 10, 12, 12);
            this.panelNav.Size = new System.Drawing.Size(293, 793);
            this.panelNav.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(12, 737);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(269, 44);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "⏻  Exit System";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.btnSetting.Location = new System.Drawing.Point(12, 470);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(269, 44);
            this.btnSetting.TabIndex = 8;
            this.btnSetting.Tag = "SETTINGS";
            this.btnSetting.Text = "⚙️  Company & Settings";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.btnUser.Location = new System.Drawing.Point(12, 426);
            this.btnUser.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(269, 44);
            this.btnUser.TabIndex = 1;
            this.btnUser.Tag = "USER";
            this.btnUser.Text = "👤  Users Management";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.btnReport.Location = new System.Drawing.Point(12, 382);
            this.btnReport.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(269, 44);
            this.btnReport.TabIndex = 7;
            this.btnReport.Tag = "REPORTS";
            this.btnReport.Text = "📈  Reports & Analytics";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // lblNavSystem
            // 
            this.lblNavSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNavSystem.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(253)))));
            this.lblNavSystem.Location = new System.Drawing.Point(12, 354);
            this.lblNavSystem.Margin = new System.Windows.Forms.Padding(0);
            this.lblNavSystem.Name = "lblNavSystem";
            this.lblNavSystem.Padding = new System.Windows.Forms.Padding(6, 6, 0, 4);
            this.lblNavSystem.Size = new System.Drawing.Size(269, 28);
            this.lblNavSystem.TabIndex = 10;
            this.lblNavSystem.Text = "MANAGEMENT & SYSTEM";
            this.lblNavSystem.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnSuppler
            // 
            this.btnSuppler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnSuppler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuppler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSuppler.FlatAppearance.BorderSize = 0;
            this.btnSuppler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSuppler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.btnSuppler.Location = new System.Drawing.Point(12, 310);
            this.btnSuppler.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnSuppler.Name = "btnSuppler";
            this.btnSuppler.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnSuppler.Size = new System.Drawing.Size(269, 44);
            this.btnSuppler.TabIndex = 3;
            this.btnSuppler.Tag = "SUPPLIER";
            this.btnSuppler.Text = "🏢  Suppliers";
            this.btnSuppler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppler.UseVisualStyleBackColor = false;
            this.btnSuppler.Click += new System.EventHandler(this.btnSuppler_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.btnCategory.Location = new System.Drawing.Point(12, 266);
            this.btnCategory.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnCategory.Size = new System.Drawing.Size(269, 44);
            this.btnCategory.TabIndex = 2;
            this.btnCategory.Tag = "CATEGORY";
            this.btnCategory.Text = "📑  Categories";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.btnStock.Location = new System.Drawing.Point(12, 222);
            this.btnStock.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnStock.Name = "btnStock";
            this.btnStock.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnStock.Size = new System.Drawing.Size(269, 44);
            this.btnStock.TabIndex = 4;
            this.btnStock.Tag = "STOCK";
            this.btnStock.Text = "📊  Stock & Inventory";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.btnProduct.Location = new System.Drawing.Point(12, 178);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnProduct.Size = new System.Drawing.Size(269, 44);
            this.btnProduct.TabIndex = 4;
            this.btnProduct.Tag = "PRODUCT";
            this.btnProduct.Text = "📦  Products Catalog";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // lblNavInventory
            // 
            this.lblNavInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNavInventory.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(253)))));
            this.lblNavInventory.Location = new System.Drawing.Point(12, 150);
            this.lblNavInventory.Margin = new System.Windows.Forms.Padding(0);
            this.lblNavInventory.Name = "lblNavInventory";
            this.lblNavInventory.Padding = new System.Windows.Forms.Padding(6, 6, 0, 4);
            this.lblNavInventory.Size = new System.Drawing.Size(269, 28);
            this.lblNavInventory.TabIndex = 9;
            this.lblNavInventory.Text = "INVENTORY & CATALOG";
            this.lblNavInventory.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.btnCustomer.Location = new System.Drawing.Point(12, 106);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnCustomer.Size = new System.Drawing.Size(269, 44);
            this.btnCustomer.TabIndex = 5;
            this.btnCustomer.Tag = "CUSTOMER";
            this.btnCustomer.Text = "👥  Customers";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSale.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSale.FlatAppearance.BorderSize = 0;
            this.btnSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.btnSale.Location = new System.Drawing.Point(12, 62);
            this.btnSale.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnSale.Name = "btnSale";
            this.btnSale.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnSale.Size = new System.Drawing.Size(269, 44);
            this.btnSale.TabIndex = 6;
            this.btnSale.Tag = "SALES";
            this.btnSale.Text = "🛒  Sales & POS";
            this.btnSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.btnDashboard.Location = new System.Drawing.Point(12, 38);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(269, 44);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Tag = "DASHBOARD";
            this.btnDashboard.Text = "📊  Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // lblNavSales
            // 
            this.lblNavSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNavSales.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(253)))));
            this.lblNavSales.Location = new System.Drawing.Point(12, 10);
            this.lblNavSales.Margin = new System.Windows.Forms.Padding(0);
            this.lblNavSales.Name = "lblNavSales";
            this.lblNavSales.Padding = new System.Windows.Forms.Padding(6, 0, 0, 4);
            this.lblNavSales.Size = new System.Drawing.Size(269, 28);
            this.lblNavSales.TabIndex = 0;
            this.lblNavSales.Text = "TERMINAL & SALES";
            this.lblNavSales.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // MainTab
            // 
            this.MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTab.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.MainTab.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTab.ItemSize = new System.Drawing.Size(140, 34);
            this.MainTab.Location = new System.Drawing.Point(293, 69);
            this.MainTab.Margin = new System.Windows.Forms.Padding(4);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(1307, 793);
            this.MainTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainTab.TabIndex = 2;
            this.MainTab.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.MainTab_DrawItem);
            this.MainTab.SelectedIndexChanged += new System.EventHandler(this.MainTab_SelectedIndexChanged);
            this.MainTab.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainTab_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1600, 862);
            this.Controls.Add(this.MainTab);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1194, 666);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBrandLogo)).EndInit();
            this.pnlUserSection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).EndInit();
            this.panelNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblBrandBadge;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblBreadcrumb;
        private System.Windows.Forms.Label lblStatusPill;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Panel pnlUserSection;
        private System.Windows.Forms.PictureBox picUserAvatar;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Label lblNavSales;
        private System.Windows.Forms.Label lblNavInventory;
        private System.Windows.Forms.Label lblNavSystem;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnSuppler;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picBrandLogo;
        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.Timer timerClock;
    }
}
