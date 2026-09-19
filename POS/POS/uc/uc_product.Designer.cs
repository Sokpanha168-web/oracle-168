namespace POS_204_oracle.uc
{
    partial class uc_product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_1 = new System.Windows.Forms.Panel();
            this.pnlHeaderCard = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.pnl_2 = new System.Windows.Forms.Panel();
            this.pnlInputCard = new System.Windows.Forms.Panel();
            this.lblInputTitle = new System.Windows.Forms.Label();
            this.lblProID = new System.Windows.Forms.Label();
            this.txtproid = new System.Windows.Forms.TextBox();
            this.lblProName = new System.Windows.Forms.Label();
            this.txtproname = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbocategoryid = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cbosupplierid = new System.Windows.Forms.ComboBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtcost = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.NumericUpDown();
            this.chkstock = new System.Windows.Forms.CheckBox();
            this.chkstatus = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.btnBrowsePhoto = new System.Windows.Forms.Button();
            this.btnClearPhoto = new System.Windows.Forms.Button();
            this.pnl_3 = new System.Windows.Forms.Panel();
            this.pnlGridCard = new System.Windows.Forms.Panel();
            this.dg_product = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnl_1.SuspendLayout();
            this.pnlHeaderCard.SuspendLayout();
            this.pnl_2.SuspendLayout();
            this.pnlInputCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.pnl_3.SuspendLayout();
            this.pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_product)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_1
            // 
            this.pnl_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.pnl_1.Controls.Add(this.pnlHeaderCard);
            this.pnl_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_1.Location = new System.Drawing.Point(0, 0);
            this.pnl_1.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Padding = new System.Windows.Forms.Padding(16, 15, 16, 7);
            this.pnl_1.Size = new System.Drawing.Size(1469, 89);
            this.pnl_1.TabIndex = 0;
            // 
            // pnlHeaderCard
            // 
            this.pnlHeaderCard.BackColor = System.Drawing.Color.White;
            this.pnlHeaderCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeaderCard.Controls.Add(this.label1);
            this.pnlHeaderCard.Controls.Add(this.btnNew);
            this.pnlHeaderCard.Controls.Add(this.txtid);
            this.pnlHeaderCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeaderCard.Location = new System.Drawing.Point(16, 15);
            this.pnlHeaderCard.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeaderCard.Name = "pnlHeaderCard";
            this.pnlHeaderCard.Size = new System.Drawing.Size(1437, 67);
            this.pnlHeaderCard.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "PRODUCT MANAGEMENT";
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(1267, 11);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(152, 42);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "+ New Product";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(307, 12);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(65, 22);
            this.txtid.TabIndex = 6;
            this.txtid.Visible = false;
            // 
            // pnl_2
            // 
            this.pnl_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.pnl_2.Controls.Add(this.pnlInputCard);
            this.pnl_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_2.Location = new System.Drawing.Point(0, 89);
            this.pnl_2.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_2.Name = "pnl_2";
            this.pnl_2.Padding = new System.Windows.Forms.Padding(16, 7, 16, 7);
            this.pnl_2.Size = new System.Drawing.Size(1469, 271);
            this.pnl_2.TabIndex = 1;
            // 
            // pnlInputCard
            // 
            this.pnlInputCard.BackColor = System.Drawing.Color.White;
            this.pnlInputCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInputCard.Controls.Add(this.lblInputTitle);
            this.pnlInputCard.Controls.Add(this.lblProID);
            this.pnlInputCard.Controls.Add(this.txtproid);
            this.pnlInputCard.Controls.Add(this.lblProName);
            this.pnlInputCard.Controls.Add(this.txtproname);
            this.pnlInputCard.Controls.Add(this.lblCategory);
            this.pnlInputCard.Controls.Add(this.cbocategoryid);
            this.pnlInputCard.Controls.Add(this.lblSupplier);
            this.pnlInputCard.Controls.Add(this.cbosupplierid);
            this.pnlInputCard.Controls.Add(this.lblCost);
            this.pnlInputCard.Controls.Add(this.txtcost);
            this.pnlInputCard.Controls.Add(this.lblPrice);
            this.pnlInputCard.Controls.Add(this.txtprice);
            this.pnlInputCard.Controls.Add(this.chkstock);
            this.pnlInputCard.Controls.Add(this.chkstatus);
            this.pnlInputCard.Controls.Add(this.btnSave);
            this.pnlInputCard.Controls.Add(this.btnClose);
            this.pnlInputCard.Controls.Add(this.lblPhoto);
            this.pnlInputCard.Controls.Add(this.picProduct);
            this.pnlInputCard.Controls.Add(this.btnBrowsePhoto);
            this.pnlInputCard.Controls.Add(this.btnClearPhoto);
            this.pnlInputCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInputCard.Location = new System.Drawing.Point(16, 7);
            this.pnlInputCard.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInputCard.Name = "pnlInputCard";
            this.pnlInputCard.Size = new System.Drawing.Size(1437, 257);
            this.pnlInputCard.TabIndex = 0;
            // 
            // lblInputTitle
            // 
            this.lblInputTitle.AutoSize = true;
            this.lblInputTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblInputTitle.Location = new System.Drawing.Point(24, 15);
            this.lblInputTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInputTitle.Name = "lblInputTitle";
            this.lblInputTitle.Size = new System.Drawing.Size(148, 25);
            this.lblInputTitle.TabIndex = 16;
            this.lblInputTitle.Text = "Product Details";
            // 
            // lblProID
            // 
            this.lblProID.AutoSize = true;
            this.lblProID.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblProID.Location = new System.Drawing.Point(27, 54);
            this.lblProID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProID.Name = "lblProID";
            this.lblProID.Size = new System.Drawing.Size(84, 20);
            this.lblProID.TabIndex = 17;
            this.lblProID.Text = "Product ID";
            // 
            // txtproid
            // 
            this.txtproid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtproid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtproid.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.txtproid.Location = new System.Drawing.Point(27, 79);
            this.txtproid.Margin = new System.Windows.Forms.Padding(4);
            this.txtproid.Name = "txtproid";
            this.txtproid.ReadOnly = true;
            this.txtproid.Size = new System.Drawing.Size(146, 29);
            this.txtproid.TabIndex = 0;
            // 
            // lblProName
            // 
            this.lblProName.AutoSize = true;
            this.lblProName.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblProName.Location = new System.Drawing.Point(195, 54);
            this.lblProName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProName.Name = "lblProName";
            this.lblProName.Size = new System.Drawing.Size(121, 20);
            this.lblProName.TabIndex = 18;
            this.lblProName.Text = "Product Name *";
            // 
            // txtproname
            // 
            this.txtproname.BackColor = System.Drawing.Color.White;
            this.txtproname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtproname.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtproname.Location = new System.Drawing.Point(195, 79);
            this.txtproname.Margin = new System.Windows.Forms.Padding(4);
            this.txtproname.Name = "txtproname";
            this.txtproname.Size = new System.Drawing.Size(319, 29);
            this.txtproname.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblCategory.Location = new System.Drawing.Point(536, 54);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(84, 20);
            this.lblCategory.TabIndex = 19;
            this.lblCategory.Text = "Category *";
            // 
            // cbocategoryid
            // 
            this.cbocategoryid.BackColor = System.Drawing.Color.White;
            this.cbocategoryid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocategoryid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbocategoryid.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocategoryid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cbocategoryid.FormattingEnabled = true;
            this.cbocategoryid.Location = new System.Drawing.Point(536, 79);
            this.cbocategoryid.Margin = new System.Windows.Forms.Padding(4);
            this.cbocategoryid.Name = "cbocategoryid";
            this.cbocategoryid.Size = new System.Drawing.Size(265, 29);
            this.cbocategoryid.TabIndex = 2;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblSupplier.Location = new System.Drawing.Point(824, 54);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(77, 20);
            this.lblSupplier.TabIndex = 20;
            this.lblSupplier.Text = "Supplier *";
            // 
            // cbosupplierid
            // 
            this.cbosupplierid.BackColor = System.Drawing.Color.White;
            this.cbosupplierid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosupplierid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbosupplierid.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbosupplierid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cbosupplierid.FormattingEnabled = true;
            this.cbosupplierid.Location = new System.Drawing.Point(824, 79);
            this.cbosupplierid.Margin = new System.Windows.Forms.Padding(4);
            this.cbosupplierid.Name = "cbosupplierid";
            this.cbosupplierid.Size = new System.Drawing.Size(265, 29);
            this.cbosupplierid.TabIndex = 3;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblCost.Location = new System.Drawing.Point(27, 126);
            this.lblCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(65, 20);
            this.lblCost.TabIndex = 21;
            this.lblCost.Text = "Cost ($)";
            // 
            // txtcost
            // 
            this.txtcost.BackColor = System.Drawing.Color.White;
            this.txtcost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcost.DecimalPlaces = 2;
            this.txtcost.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtcost.Location = new System.Drawing.Point(27, 150);
            this.txtcost.Margin = new System.Windows.Forms.Padding(4);
            this.txtcost.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(147, 29);
            this.txtcost.TabIndex = 4;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblPrice.Location = new System.Drawing.Point(195, 126);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(68, 20);
            this.lblPrice.TabIndex = 22;
            this.lblPrice.Text = "Price ($)";
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.Color.White;
            this.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprice.DecimalPlaces = 2;
            this.txtprice.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtprice.Location = new System.Drawing.Point(195, 150);
            this.txtprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtprice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(147, 29);
            this.txtprice.TabIndex = 5;
            // 
            // chkstock
            // 
            this.chkstock.AutoSize = true;
            this.chkstock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkstock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.chkstock.Location = new System.Drawing.Point(373, 153);
            this.chkstock.Margin = new System.Windows.Forms.Padding(4);
            this.chkstock.Name = "chkstock";
            this.chkstock.Size = new System.Drawing.Size(85, 24);
            this.chkstock.TabIndex = 6;
            this.chkstock.Text = "Is Stock";
            this.chkstock.UseVisualStyleBackColor = true;
            // 
            // chkstatus
            // 
            this.chkstatus.AutoSize = true;
            this.chkstatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.chkstatus.Location = new System.Drawing.Point(507, 153);
            this.chkstatus.Margin = new System.Windows.Forms.Padding(4);
            this.chkstatus.Name = "chkstatus";
            this.chkstatus.Size = new System.Drawing.Size(123, 24);
            this.chkstatus.TabIndex = 7;
            this.chkstatus.Text = "Active Status";
            this.chkstatus.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(27, 199);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 42);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save Product";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnClose.Location = new System.Drawing.Point(184, 199);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 42);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblPhoto.Location = new System.Drawing.Point(1138, 40);
            this.lblPhoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(110, 20);
            this.lblPhoto.TabIndex = 23;
            this.lblPhoto.Text = "Product Photo";
            // 
            // picProduct
            // 
            this.picProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.picProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProduct.Location = new System.Drawing.Point(1138, 64);
            this.picProduct.Margin = new System.Windows.Forms.Padding(4);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(160, 115);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 24;
            this.picProduct.TabStop = false;
            // 
            // btnBrowsePhoto
            // 
            this.btnBrowsePhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnBrowsePhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowsePhoto.FlatAppearance.BorderSize = 0;
            this.btnBrowsePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowsePhoto.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnBrowsePhoto.ForeColor = System.Drawing.Color.White;
            this.btnBrowsePhoto.Location = new System.Drawing.Point(1138, 187);
            this.btnBrowsePhoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowsePhoto.Name = "btnBrowsePhoto";
            this.btnBrowsePhoto.Size = new System.Drawing.Size(115, 36);
            this.btnBrowsePhoto.TabIndex = 25;
            this.btnBrowsePhoto.Text = "📷 Browse...";
            this.btnBrowsePhoto.UseVisualStyleBackColor = false;
            this.btnBrowsePhoto.Click += new System.EventHandler(this.btnBrowsePhoto_Click);
            // 
            // btnClearPhoto
            // 
            this.btnClearPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.btnClearPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearPhoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnClearPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPhoto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnClearPhoto.Location = new System.Drawing.Point(1260, 187);
            this.btnClearPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearPhoto.Name = "btnClearPhoto";
            this.btnClearPhoto.Size = new System.Drawing.Size(38, 36);
            this.btnClearPhoto.TabIndex = 26;
            this.btnClearPhoto.Text = "✕";
            this.btnClearPhoto.UseVisualStyleBackColor = false;
            this.btnClearPhoto.Click += new System.EventHandler(this.btnClearPhoto_Click);
            // 
            // pnl_3
            // 
            this.pnl_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.pnl_3.Controls.Add(this.pnlGridCard);
            this.pnl_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_3.Location = new System.Drawing.Point(0, 360);
            this.pnl_3.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_3.Name = "pnl_3";
            this.pnl_3.Padding = new System.Windows.Forms.Padding(16, 7, 16, 15);
            this.pnl_3.Size = new System.Drawing.Size(1469, 440);
            this.pnl_3.TabIndex = 2;
            // 
            // pnlGridCard
            // 
            this.pnlGridCard.BackColor = System.Drawing.Color.White;
            this.pnlGridCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGridCard.Controls.Add(this.dg_product);
            this.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridCard.Location = new System.Drawing.Point(16, 7);
            this.pnlGridCard.Margin = new System.Windows.Forms.Padding(4);
            this.pnlGridCard.Name = "pnlGridCard";
            this.pnlGridCard.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.pnlGridCard.Size = new System.Drawing.Size(1437, 418);
            this.pnlGridCard.TabIndex = 0;
            // 
            // dg_product
            // 
            this.dg_product.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.dg_product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_product.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_product.ColumnHeadersHeight = 36;
            this.dg_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_product.DefaultCellStyle = dataGridViewCellStyle3;
            this.dg_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_product.EnableHeadersVisualStyles = false;
            this.dg_product.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dg_product.Location = new System.Drawing.Point(11, 10);
            this.dg_product.Margin = new System.Windows.Forms.Padding(4);
            this.dg_product.MultiSelect = false;
            this.dg_product.Name = "dg_product";
            this.dg_product.ReadOnly = true;
            this.dg_product.RowHeadersVisible = false;
            this.dg_product.RowHeadersWidth = 51;
            this.dg_product.RowTemplate.Height = 32;
            this.dg_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_product.Size = new System.Drawing.Size(1413, 396);
            this.dg_product.TabIndex = 0;
            this.dg_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_product_CellClick);
            this.dg_product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_product_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Image = global::POS_204_oracle.Properties.Resources.icons8_edit_30;
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Delete";
            this.Column2.Image = global::POS_204_oracle.Properties.Resources.icons8_trash_24;
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // uc_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.pnl_3);
            this.Controls.Add(this.pnl_2);
            this.Controls.Add(this.pnl_1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uc_product";
            this.Size = new System.Drawing.Size(1469, 800);
            this.Load += new System.EventHandler(this.uc_product_Load);
            this.pnl_1.ResumeLayout(false);
            this.pnlHeaderCard.ResumeLayout(false);
            this.pnlHeaderCard.PerformLayout();
            this.pnl_2.ResumeLayout(false);
            this.pnlInputCard.ResumeLayout(false);
            this.pnlInputCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.pnl_3.ResumeLayout(false);
            this.pnlGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_1;
        private System.Windows.Forms.Panel pnlHeaderCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Panel pnl_2;
        private System.Windows.Forms.Panel pnlInputCard;
        private System.Windows.Forms.Label lblInputTitle;
        private System.Windows.Forms.Label lblProID;
        private System.Windows.Forms.TextBox txtproid;
        private System.Windows.Forms.Label lblProName;
        private System.Windows.Forms.TextBox txtproname;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbocategoryid;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cbosupplierid;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.NumericUpDown txtcost;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown txtprice;
        private System.Windows.Forms.CheckBox chkstock;
        private System.Windows.Forms.CheckBox chkstatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Button btnBrowsePhoto;
        private System.Windows.Forms.Button btnClearPhoto;
        private System.Windows.Forms.Panel pnl_3;
        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.DataGridView dg_product;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
    }
}
