namespace POS_204_oracle.uc
{
    partial class ucSupplier
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
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.txtsupplierid = new System.Windows.Forms.TextBox();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.txtsupplername = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtsuppliercontact = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtsupplernotes = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnl_3 = new System.Windows.Forms.Panel();
            this.pnlGridCard = new System.Windows.Forms.Panel();
            this.dg_supplier = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnl_1.SuspendLayout();
            this.pnlHeaderCard.SuspendLayout();
            this.pnl_2.SuspendLayout();
            this.pnlInputCard.SuspendLayout();
            this.pnl_3.SuspendLayout();
            this.pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_supplier)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_1
            // 
            this.pnl_1.Controls.Add(this.pnlHeaderCard);
            this.pnl_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_1.Location = new System.Drawing.Point(0, 0);
            this.pnl_1.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Padding = new System.Windows.Forms.Padding(16, 15, 16, 7);
            this.pnl_1.Size = new System.Drawing.Size(1267, 89);
            this.pnl_1.TabIndex = 0;
            // 
            // pnlHeaderCard
            // 
            this.pnlHeaderCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.pnlHeaderCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeaderCard.Controls.Add(this.label1);
            this.pnlHeaderCard.Controls.Add(this.btnNew);
            this.pnlHeaderCard.Controls.Add(this.txtid);
            this.pnlHeaderCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeaderCard.Location = new System.Drawing.Point(16, 15);
            this.pnlHeaderCard.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeaderCard.Name = "pnlHeaderCard";
            this.pnlHeaderCard.Size = new System.Drawing.Size(1235, 67);
            this.pnlHeaderCard.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "SUPPLIER MANAGEMENT";
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.btnNew.Location = new System.Drawing.Point(1065, 11);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(152, 42);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "+ New Supplier";
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
            this.pnl_2.Controls.Add(this.pnlInputCard);
            this.pnl_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_2.Location = new System.Drawing.Point(0, 89);
            this.pnl_2.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_2.Name = "pnl_2";
            this.pnl_2.Padding = new System.Windows.Forms.Padding(16, 7, 16, 7);
            this.pnl_2.Size = new System.Drawing.Size(1267, 271);
            this.pnl_2.TabIndex = 1;
            // 
            // pnlInputCard
            // 
            this.pnlInputCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.pnlInputCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInputCard.Controls.Add(this.lblInputTitle);
            this.pnlInputCard.Controls.Add(this.lblSupplierID);
            this.pnlInputCard.Controls.Add(this.txtsupplierid);
            this.pnlInputCard.Controls.Add(this.lblSupplierName);
            this.pnlInputCard.Controls.Add(this.txtsupplername);
            this.pnlInputCard.Controls.Add(this.lblContact);
            this.pnlInputCard.Controls.Add(this.txtsuppliercontact);
            this.pnlInputCard.Controls.Add(this.lblNotes);
            this.pnlInputCard.Controls.Add(this.txtsupplernotes);
            this.pnlInputCard.Controls.Add(this.btnSave);
            this.pnlInputCard.Controls.Add(this.btnClose);
            this.pnlInputCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInputCard.Location = new System.Drawing.Point(16, 7);
            this.pnlInputCard.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInputCard.Name = "pnlInputCard";
            this.pnlInputCard.Size = new System.Drawing.Size(1235, 257);
            this.pnlInputCard.TabIndex = 0;
            // 
            // lblInputTitle
            // 
            this.lblInputTitle.AutoSize = true;
            this.lblInputTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblInputTitle.Location = new System.Drawing.Point(24, 15);
            this.lblInputTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInputTitle.Name = "lblInputTitle";
            this.lblInputTitle.Size = new System.Drawing.Size(151, 25);
            this.lblInputTitle.TabIndex = 12;
            this.lblInputTitle.Text = "Supplier Details";
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSupplierID.Location = new System.Drawing.Point(27, 59);
            this.lblSupplierID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(86, 20);
            this.lblSupplierID.TabIndex = 13;
            this.lblSupplierID.Text = "Supplier ID";
            // 
            // txtsupplierid
            // 
            this.txtsupplierid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtsupplierid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsupplierid.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsupplierid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtsupplierid.Location = new System.Drawing.Point(27, 84);
            this.txtsupplierid.Margin = new System.Windows.Forms.Padding(4);
            this.txtsupplierid.Name = "txtsupplierid";
            this.txtsupplierid.ReadOnly = true;
            this.txtsupplierid.Size = new System.Drawing.Size(213, 29);
            this.txtsupplierid.TabIndex = 6;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSupplierName.Location = new System.Drawing.Point(267, 59);
            this.lblSupplierName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(112, 20);
            this.lblSupplierName.TabIndex = 14;
            this.lblSupplierName.Text = "Supplier Name";
            // 
            // txtsupplername
            // 
            this.txtsupplername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtsupplername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsupplername.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsupplername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtsupplername.Location = new System.Drawing.Point(267, 84);
            this.txtsupplername.Margin = new System.Windows.Forms.Padding(4);
            this.txtsupplername.Name = "txtsupplername";
            this.txtsupplername.Size = new System.Drawing.Size(399, 29);
            this.txtsupplername.TabIndex = 7;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblContact.Location = new System.Drawing.Point(693, 59);
            this.lblContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(63, 20);
            this.lblContact.TabIndex = 15;
            this.lblContact.Text = "Contact";
            // 
            // txtsuppliercontact
            // 
            this.txtsuppliercontact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtsuppliercontact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsuppliercontact.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsuppliercontact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtsuppliercontact.Location = new System.Drawing.Point(693, 84);
            this.txtsuppliercontact.Margin = new System.Windows.Forms.Padding(4);
            this.txtsuppliercontact.Name = "txtsuppliercontact";
            this.txtsuppliercontact.Size = new System.Drawing.Size(333, 29);
            this.txtsuppliercontact.TabIndex = 8;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblNotes.Location = new System.Drawing.Point(27, 129);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(51, 20);
            this.lblNotes.TabIndex = 16;
            this.lblNotes.Text = "Notes";
            // 
            // txtsupplernotes
            // 
            this.txtsupplernotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtsupplernotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsupplernotes.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsupplernotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtsupplernotes.Location = new System.Drawing.Point(27, 154);
            this.txtsupplernotes.Margin = new System.Windows.Forms.Padding(4);
            this.txtsupplernotes.Name = "txtsupplernotes";
            this.txtsupplernotes.Size = new System.Drawing.Size(999, 29);
            this.txtsupplernotes.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.btnSave.Location = new System.Drawing.Point(27, 199);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 39);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save Supplier";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnClose.Location = new System.Drawing.Point(200, 199);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 39);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnl_3
            // 
            this.pnl_3.Controls.Add(this.pnlGridCard);
            this.pnl_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_3.Location = new System.Drawing.Point(0, 360);
            this.pnl_3.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_3.Name = "pnl_3";
            this.pnl_3.Padding = new System.Windows.Forms.Padding(16, 7, 16, 15);
            this.pnl_3.Size = new System.Drawing.Size(1267, 440);
            this.pnl_3.TabIndex = 2;
            // 
            // pnlGridCard
            // 
            this.pnlGridCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.pnlGridCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGridCard.Controls.Add(this.dg_supplier);
            this.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridCard.Location = new System.Drawing.Point(16, 7);
            this.pnlGridCard.Margin = new System.Windows.Forms.Padding(4);
            this.pnlGridCard.Name = "pnlGridCard";
            this.pnlGridCard.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.pnlGridCard.Size = new System.Drawing.Size(1235, 418);
            this.pnlGridCard.TabIndex = 0;
            // 
            // dg_supplier
            // 
            this.dg_supplier.AllowUserToAddRows = false;
            this.dg_supplier.AllowUserToDeleteRows = false;
            this.dg_supplier.AllowUserToResizeRows = false;
            this.dg_supplier.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.dg_supplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_supplier.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_supplier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_supplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_supplier.ColumnHeadersHeight = 36;
            this.dg_supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_supplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_supplier.DefaultCellStyle = dataGridViewCellStyle3;
            this.dg_supplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_supplier.EnableHeadersVisualStyles = false;
            this.dg_supplier.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.dg_supplier.Location = new System.Drawing.Point(11, 10);
            this.dg_supplier.Margin = new System.Windows.Forms.Padding(4);
            this.dg_supplier.MultiSelect = false;
            this.dg_supplier.Name = "dg_supplier";
            this.dg_supplier.ReadOnly = true;
            this.dg_supplier.RowHeadersVisible = false;
            this.dg_supplier.RowHeadersWidth = 51;
            this.dg_supplier.RowTemplate.Height = 32;
            this.dg_supplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_supplier.Size = new System.Drawing.Size(1211, 396);
            this.dg_supplier.TabIndex = 0;
            this.dg_supplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_supplier_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Edit";
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
            // ucSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.pnl_3);
            this.Controls.Add(this.pnl_2);
            this.Controls.Add(this.pnl_1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucSupplier";
            this.Size = new System.Drawing.Size(1267, 800);
            this.Load += new System.EventHandler(this.ucSupplier_Load);
            this.pnl_1.ResumeLayout(false);
            this.pnlHeaderCard.ResumeLayout(false);
            this.pnlHeaderCard.PerformLayout();
            this.pnl_2.ResumeLayout(false);
            this.pnlInputCard.ResumeLayout(false);
            this.pnlInputCard.PerformLayout();
            this.pnl_3.ResumeLayout(false);
            this.pnlGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_supplier)).EndInit();
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
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.TextBox txtsupplierid;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.TextBox txtsupplername;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtsuppliercontact;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtsupplernotes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnl_3;
        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.DataGridView dg_supplier;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
    }
}
