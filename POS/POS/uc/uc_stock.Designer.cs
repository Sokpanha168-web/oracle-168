namespace POS_204_oracle.uc
{
    partial class uc_stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnHeaderStockIn = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlKpi = new System.Windows.Forms.Panel();
            this.pnlCard4 = new System.Windows.Forms.Panel();
            this.lblKpiUnitsVal = new System.Windows.Forms.Label();
            this.lblKpiUnitsTitle = new System.Windows.Forms.Label();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.lblKpiOutStockVal = new System.Windows.Forms.Label();
            this.lblKpiOutStockTitle = new System.Windows.Forms.Label();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.lblKpiInStockVal = new System.Windows.Forms.Label();
            this.lblKpiInStockTitle = new System.Windows.Forms.Label();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.lblKpiTotalProdsVal = new System.Windows.Forms.Label();
            this.lblKpiTotalProdsTitle = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblFilterCount = new System.Windows.Forms.Label();
            this.cboStatusFilter = new System.Windows.Forms.ComboBox();
            this.lblStatusFilter = new System.Windows.Forms.Label();
            this.cboCategoryFilter = new System.Windows.Forms.ComboBox();
            this.lblCatFilter = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlStockIn = new System.Windows.Forms.Panel();
            this.pnlStockInCard = new System.Windows.Forms.Panel();
            this.btnCloseStockIn = new System.Windows.Forms.Button();
            this.btnSaveStockIn = new System.Windows.Forms.Button();
            this.txtInNotes = new System.Windows.Forms.TextBox();
            this.lblInNotes = new System.Windows.Forms.Label();
            this.nudInCost = new System.Windows.Forms.NumericUpDown();
            this.lblInCost = new System.Windows.Forms.Label();
            this.nudInQty = new System.Windows.Forms.NumericUpDown();
            this.lblInQty = new System.Windows.Forms.Label();
            this.lblInCurStock = new System.Windows.Forms.Label();
            this.cboInProduct = new System.Windows.Forms.ComboBox();
            this.lblInProduct = new System.Windows.Forms.Label();
            this.lblStockInTitle = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgInventory = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlKpi.SuspendLayout();
            this.pnlCard4.SuspendLayout();
            this.pnlCard3.SuspendLayout();
            this.pnlCard2.SuspendLayout();
            this.pnlCard1.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlStockIn.SuspendLayout();
            this.pnlStockInCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInQty)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.pnlHeader.Controls.Add(this.btnHeaderStockIn);
            this.pnlHeader.Controls.Add(this.btnRefresh);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(21, 12, 21, 12);
            this.pnlHeader.Size = new System.Drawing.Size(1600, 79);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnHeaderStockIn
            // 
            this.btnHeaderStockIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHeaderStockIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnHeaderStockIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHeaderStockIn.FlatAppearance.BorderSize = 0;
            this.btnHeaderStockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeaderStockIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHeaderStockIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.btnHeaderStockIn.Location = new System.Drawing.Point(1227, 17);
            this.btnHeaderStockIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHeaderStockIn.Name = "btnHeaderStockIn";
            this.btnHeaderStockIn.Size = new System.Drawing.Size(213, 44);
            this.btnHeaderStockIn.TabIndex = 1;
            this.btnHeaderStockIn.Text = "+ Receive Stock";
            this.btnHeaderStockIn.UseVisualStyleBackColor = false;
            this.btnHeaderStockIn.Click += new System.EventHandler(this.btnHeaderStockIn_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnRefresh.Location = new System.Drawing.Point(1453, 17);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(127, 44);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblTitle.Location = new System.Drawing.Point(21, 10);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(294, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PRODUCT STOCK CATALOG";
            // 
            // pnlKpi
            // 
            this.pnlKpi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.pnlKpi.Controls.Add(this.pnlCard4);
            this.pnlKpi.Controls.Add(this.pnlCard3);
            this.pnlKpi.Controls.Add(this.pnlCard2);
            this.pnlKpi.Controls.Add(this.pnlCard1);
            this.pnlKpi.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKpi.Location = new System.Drawing.Point(0, 79);
            this.pnlKpi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlKpi.Name = "pnlKpi";
            this.pnlKpi.Padding = new System.Windows.Forms.Padding(21, 10, 21, 10);
            this.pnlKpi.Size = new System.Drawing.Size(1600, 89);
            this.pnlKpi.TabIndex = 1;
            // 
            // pnlCard4
            // 
            this.pnlCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.pnlCard4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard4.Controls.Add(this.lblKpiUnitsVal);
            this.pnlCard4.Controls.Add(this.lblKpiUnitsTitle);
            this.pnlCard4.Location = new System.Drawing.Point(1187, 10);
            this.pnlCard4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCard4.Name = "pnlCard4";
            this.pnlCard4.Size = new System.Drawing.Size(366, 66);
            this.pnlCard4.TabIndex = 3;
            // 
            // lblKpiUnitsVal
            // 
            this.lblKpiUnitsVal.AutoSize = true;
            this.lblKpiUnitsVal.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblKpiUnitsVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.lblKpiUnitsVal.Location = new System.Drawing.Point(13, 30);
            this.lblKpiUnitsVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKpiUnitsVal.Name = "lblKpiUnitsVal";
            this.lblKpiUnitsVal.Size = new System.Drawing.Size(82, 30);
            this.lblKpiUnitsVal.TabIndex = 1;
            this.lblKpiUnitsVal.Text = "0 Units";
            // 
            // lblKpiUnitsTitle
            // 
            this.lblKpiUnitsTitle.AutoSize = true;
            this.lblKpiUnitsTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblKpiUnitsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblKpiUnitsTitle.Location = new System.Drawing.Point(13, 7);
            this.lblKpiUnitsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKpiUnitsTitle.Name = "lblKpiUnitsTitle";
            this.lblKpiUnitsTitle.Size = new System.Drawing.Size(185, 17);
            this.lblKpiUnitsTitle.TabIndex = 0;
            this.lblKpiUnitsTitle.Text = "TOTAL QUANTITY ON HAND";
            // 
            // pnlCard3
            // 
            this.pnlCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.pnlCard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard3.Controls.Add(this.lblKpiOutStockVal);
            this.pnlCard3.Controls.Add(this.lblKpiOutStockTitle);
            this.pnlCard3.Location = new System.Drawing.Point(797, 10);
            this.pnlCard3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCard3.Name = "pnlCard3";
            this.pnlCard3.Size = new System.Drawing.Size(366, 66);
            this.pnlCard3.TabIndex = 2;
            // 
            // lblKpiOutStockVal
            // 
            this.lblKpiOutStockVal.AutoSize = true;
            this.lblKpiOutStockVal.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblKpiOutStockVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblKpiOutStockVal.Location = new System.Drawing.Point(13, 30);
            this.lblKpiOutStockVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKpiOutStockVal.Name = "lblKpiOutStockVal";
            this.lblKpiOutStockVal.Size = new System.Drawing.Size(85, 30);
            this.lblKpiOutStockVal.TabIndex = 1;
            this.lblKpiOutStockVal.Text = "0 Items";
            // 
            // lblKpiOutStockTitle
            // 
            this.lblKpiOutStockTitle.AutoSize = true;
            this.lblKpiOutStockTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblKpiOutStockTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblKpiOutStockTitle.Location = new System.Drawing.Point(13, 7);
            this.lblKpiOutStockTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKpiOutStockTitle.Name = "lblKpiOutStockTitle";
            this.lblKpiOutStockTitle.Size = new System.Drawing.Size(173, 17);
            this.lblKpiOutStockTitle.TabIndex = 0;
            this.lblKpiOutStockTitle.Text = "OUT OF STOCK PRODUCTS";
            // 
            // pnlCard2
            // 
            this.pnlCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.pnlCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard2.Controls.Add(this.lblKpiInStockVal);
            this.pnlCard2.Controls.Add(this.lblKpiInStockTitle);
            this.pnlCard2.Location = new System.Drawing.Point(409, 10);
            this.pnlCard2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCard2.Name = "pnlCard2";
            this.pnlCard2.Size = new System.Drawing.Size(366, 66);
            this.pnlCard2.TabIndex = 1;
            // 
            // lblKpiInStockVal
            // 
            this.lblKpiInStockVal.AutoSize = true;
            this.lblKpiInStockVal.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblKpiInStockVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblKpiInStockVal.Location = new System.Drawing.Point(13, 30);
            this.lblKpiInStockVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKpiInStockVal.Name = "lblKpiInStockVal";
            this.lblKpiInStockVal.Size = new System.Drawing.Size(85, 30);
            this.lblKpiInStockVal.TabIndex = 1;
            this.lblKpiInStockVal.Text = "0 Items";
            // 
            // lblKpiInStockTitle
            // 
            this.lblKpiInStockTitle.AutoSize = true;
            this.lblKpiInStockTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblKpiInStockTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblKpiInStockTitle.Location = new System.Drawing.Point(13, 7);
            this.lblKpiInStockTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKpiInStockTitle.Name = "lblKpiInStockTitle";
            this.lblKpiInStockTitle.Size = new System.Drawing.Size(139, 17);
            this.lblKpiInStockTitle.TabIndex = 0;
            this.lblKpiInStockTitle.Text = "IN STOCK PRODUCTS";
            // 
            // pnlCard1
            // 
            this.pnlCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.pnlCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard1.Controls.Add(this.lblKpiTotalProdsVal);
            this.pnlCard1.Controls.Add(this.lblKpiTotalProdsTitle);
            this.pnlCard1.Location = new System.Drawing.Point(21, 10);
            this.pnlCard1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCard1.Name = "pnlCard1";
            this.pnlCard1.Size = new System.Drawing.Size(366, 66);
            this.pnlCard1.TabIndex = 0;
            // 
            // lblKpiTotalProdsVal
            // 
            this.lblKpiTotalProdsVal.AutoSize = true;
            this.lblKpiTotalProdsVal.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblKpiTotalProdsVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblKpiTotalProdsVal.Location = new System.Drawing.Point(13, 30);
            this.lblKpiTotalProdsVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKpiTotalProdsVal.Name = "lblKpiTotalProdsVal";
            this.lblKpiTotalProdsVal.Size = new System.Drawing.Size(85, 30);
            this.lblKpiTotalProdsVal.TabIndex = 1;
            this.lblKpiTotalProdsVal.Text = "0 Items";
            // 
            // lblKpiTotalProdsTitle
            // 
            this.lblKpiTotalProdsTitle.AutoSize = true;
            this.lblKpiTotalProdsTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblKpiTotalProdsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblKpiTotalProdsTitle.Location = new System.Drawing.Point(13, 7);
            this.lblKpiTotalProdsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKpiTotalProdsTitle.Name = "lblKpiTotalProdsTitle";
            this.lblKpiTotalProdsTitle.Size = new System.Drawing.Size(120, 17);
            this.lblKpiTotalProdsTitle.TabIndex = 0;
            this.lblKpiTotalProdsTitle.Text = "TOTAL PRODUCTS";
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.pnlFilter.Controls.Add(this.lblFilterCount);
            this.pnlFilter.Controls.Add(this.cboStatusFilter);
            this.pnlFilter.Controls.Add(this.lblStatusFilter);
            this.pnlFilter.Controls.Add(this.cboCategoryFilter);
            this.pnlFilter.Controls.Add(this.lblCatFilter);
            this.pnlFilter.Controls.Add(this.txtSearch);
            this.pnlFilter.Controls.Add(this.lblSearch);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 168);
            this.pnlFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(21, 10, 21, 10);
            this.pnlFilter.Size = new System.Drawing.Size(1600, 59);
            this.pnlFilter.TabIndex = 2;
            // 
            // lblFilterCount
            // 
            this.lblFilterCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilterCount.AutoSize = true;
            this.lblFilterCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFilterCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.lblFilterCount.Location = new System.Drawing.Point(1400, 18);
            this.lblFilterCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilterCount.Name = "lblFilterCount";
            this.lblFilterCount.Size = new System.Drawing.Size(129, 20);
            this.lblFilterCount.TabIndex = 6;
            this.lblFilterCount.Text = "Showing: 0 items";
            // 
            // cboStatusFilter
            // 
            this.cboStatusFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cboStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboStatusFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cboStatusFilter.FormattingEnabled = true;
            this.cboStatusFilter.Items.AddRange(new object[] {
            "All Status",
            "In Stock",
            "Out of Stock"});
            this.cboStatusFilter.Location = new System.Drawing.Point(827, 15);
            this.cboStatusFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboStatusFilter.Name = "cboStatusFilter";
            this.cboStatusFilter.Size = new System.Drawing.Size(199, 28);
            this.cboStatusFilter.TabIndex = 5;
            this.cboStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cboStatusFilter_SelectedIndexChanged);
            // 
            // lblStatusFilter
            // 
            this.lblStatusFilter.AutoSize = true;
            this.lblStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatusFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblStatusFilter.Location = new System.Drawing.Point(720, 18);
            this.lblStatusFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusFilter.Name = "lblStatusFilter";
            this.lblStatusFilter.Size = new System.Drawing.Size(99, 20);
            this.lblStatusFilter.TabIndex = 4;
            this.lblStatusFilter.Text = "Stock Status:";
            // 
            // cboCategoryFilter
            // 
            this.cboCategoryFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cboCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoryFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboCategoryFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cboCategoryFilter.FormattingEnabled = true;
            this.cboCategoryFilter.Location = new System.Drawing.Point(487, 15);
            this.cboCategoryFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCategoryFilter.Name = "cboCategoryFilter";
            this.cboCategoryFilter.Size = new System.Drawing.Size(212, 28);
            this.cboCategoryFilter.TabIndex = 3;
            this.cboCategoryFilter.SelectedIndexChanged += new System.EventHandler(this.cboCategoryFilter_SelectedIndexChanged);
            // 
            // lblCatFilter
            // 
            this.lblCatFilter.AutoSize = true;
            this.lblCatFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCatFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblCatFilter.Location = new System.Drawing.Point(400, 18);
            this.lblCatFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCatFilter.Name = "lblCatFilter";
            this.lblCatFilter.Size = new System.Drawing.Size(77, 20);
            this.lblCatFilter.TabIndex = 2;
            this.lblCatFilter.Text = "Category:";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtSearch.Location = new System.Drawing.Point(100, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(272, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSearch.Location = new System.Drawing.Point(21, 18);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(59, 20);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";
            // 
            // pnlStockIn
            // 
            this.pnlStockIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.pnlStockIn.Controls.Add(this.pnlStockInCard);
            this.pnlStockIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStockIn.Location = new System.Drawing.Point(0, 227);
            this.pnlStockIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlStockIn.Name = "pnlStockIn";
            this.pnlStockIn.Padding = new System.Windows.Forms.Padding(21, 10, 21, 10);
            this.pnlStockIn.Size = new System.Drawing.Size(1600, 172);
            this.pnlStockIn.TabIndex = 3;
            this.pnlStockIn.Visible = false;
            // 
            // pnlStockInCard
            // 
            this.pnlStockInCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.pnlStockInCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStockInCard.Controls.Add(this.btnCloseStockIn);
            this.pnlStockInCard.Controls.Add(this.btnSaveStockIn);
            this.pnlStockInCard.Controls.Add(this.txtInNotes);
            this.pnlStockInCard.Controls.Add(this.lblInNotes);
            this.pnlStockInCard.Controls.Add(this.nudInCost);
            this.pnlStockInCard.Controls.Add(this.lblInCost);
            this.pnlStockInCard.Controls.Add(this.nudInQty);
            this.pnlStockInCard.Controls.Add(this.lblInQty);
            this.pnlStockInCard.Controls.Add(this.lblInCurStock);
            this.pnlStockInCard.Controls.Add(this.cboInProduct);
            this.pnlStockInCard.Controls.Add(this.lblInProduct);
            this.pnlStockInCard.Controls.Add(this.lblStockInTitle);
            this.pnlStockInCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStockInCard.Location = new System.Drawing.Point(21, 10);
            this.pnlStockInCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlStockInCard.Name = "pnlStockInCard";
            this.pnlStockInCard.Padding = new System.Windows.Forms.Padding(21, 12, 21, 12);
            this.pnlStockInCard.Size = new System.Drawing.Size(1558, 152);
            this.pnlStockInCard.TabIndex = 0;
            // 
            // btnCloseStockIn
            // 
            this.btnCloseStockIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btnCloseStockIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseStockIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.btnCloseStockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseStockIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCloseStockIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnCloseStockIn.Location = new System.Drawing.Point(1327, 92);
            this.btnCloseStockIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCloseStockIn.Name = "btnCloseStockIn";
            this.btnCloseStockIn.Size = new System.Drawing.Size(127, 42);
            this.btnCloseStockIn.TabIndex = 11;
            this.btnCloseStockIn.Text = "✕ Close";
            this.btnCloseStockIn.UseVisualStyleBackColor = false;
            this.btnCloseStockIn.Click += new System.EventHandler(this.btnCloseStockIn_Click);
            // 
            // btnSaveStockIn
            // 
            this.btnSaveStockIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnSaveStockIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveStockIn.FlatAppearance.BorderSize = 0;
            this.btnSaveStockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStockIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveStockIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.btnSaveStockIn.Location = new System.Drawing.Point(1120, 92);
            this.btnSaveStockIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveStockIn.Name = "btnSaveStockIn";
            this.btnSaveStockIn.Size = new System.Drawing.Size(193, 42);
            this.btnSaveStockIn.TabIndex = 10;
            this.btnSaveStockIn.Text = "💾 Save Stock In";
            this.btnSaveStockIn.UseVisualStyleBackColor = false;
            this.btnSaveStockIn.Click += new System.EventHandler(this.btnSaveStockIn_Click);
            // 
            // txtInNotes
            // 
            this.txtInNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtInNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtInNotes.Location = new System.Drawing.Point(800, 100);
            this.txtInNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInNotes.Name = "txtInNotes";
            this.txtInNotes.Size = new System.Drawing.Size(292, 27);
            this.txtInNotes.TabIndex = 9;
            // 
            // lblInNotes
            // 
            this.lblInNotes.AutoSize = true;
            this.lblInNotes.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblInNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblInNotes.Location = new System.Drawing.Point(797, 76);
            this.lblInNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInNotes.Name = "lblInNotes";
            this.lblInNotes.Size = new System.Drawing.Size(96, 19);
            this.lblInNotes.TabIndex = 8;
            this.lblInNotes.Text = "Notes / Ref #";
            // 
            // nudInCost
            // 
            this.nudInCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.nudInCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudInCost.DecimalPlaces = 2;
            this.nudInCost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudInCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.nudInCost.Location = new System.Drawing.Point(633, 100);
            this.nudInCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudInCost.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudInCost.Name = "nudInCost";
            this.nudInCost.Size = new System.Drawing.Size(140, 27);
            this.nudInCost.TabIndex = 7;
            // 
            // lblInCost
            // 
            this.lblInCost.AutoSize = true;
            this.lblInCost.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblInCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblInCost.Location = new System.Drawing.Point(629, 76);
            this.lblInCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInCost.Name = "lblInCost";
            this.lblInCost.Size = new System.Drawing.Size(91, 19);
            this.lblInCost.TabIndex = 6;
            this.lblInCost.Text = "Unit Cost ($)";
            // 
            // nudInQty
            // 
            this.nudInQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.nudInQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudInQty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudInQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.nudInQty.Location = new System.Drawing.Point(487, 100);
            this.nudInQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudInQty.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudInQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInQty.Name = "nudInQty";
            this.nudInQty.Size = new System.Drawing.Size(127, 27);
            this.nudInQty.TabIndex = 5;
            this.nudInQty.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblInQty
            // 
            this.lblInQty.AutoSize = true;
            this.lblInQty.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblInQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblInQty.Location = new System.Drawing.Point(483, 76);
            this.lblInQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInQty.Name = "lblInQty";
            this.lblInQty.Size = new System.Drawing.Size(108, 19);
            this.lblInQty.TabIndex = 4;
            this.lblInQty.Text = "Add Quantity *";
            // 
            // lblInCurStock
            // 
            this.lblInCurStock.AutoSize = true;
            this.lblInCurStock.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblInCurStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.lblInCurStock.Location = new System.Drawing.Point(160, 76);
            this.lblInCurStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInCurStock.Name = "lblInCurStock";
            this.lblInCurStock.Size = new System.Drawing.Size(178, 19);
            this.lblInCurStock.TabIndex = 3;
            this.lblInCurStock.Text = "(Current: 0 units on hand)";
            // 
            // cboInProduct
            // 
            this.cboInProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cboInProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboInProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cboInProduct.FormattingEnabled = true;
            this.cboInProduct.Location = new System.Drawing.Point(21, 100);
            this.cboInProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboInProduct.Name = "cboInProduct";
            this.cboInProduct.Size = new System.Drawing.Size(439, 28);
            this.cboInProduct.TabIndex = 2;
            this.cboInProduct.SelectedIndexChanged += new System.EventHandler(this.cboInProduct_SelectedIndexChanged);
            // 
            // lblInProduct
            // 
            this.lblInProduct.AutoSize = true;
            this.lblInProduct.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblInProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblInProduct.Location = new System.Drawing.Point(19, 76);
            this.lblInProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInProduct.Name = "lblInProduct";
            this.lblInProduct.Size = new System.Drawing.Size(116, 19);
            this.lblInProduct.TabIndex = 1;
            this.lblInProduct.Text = "Select Product *";
            // 
            // lblStockInTitle
            // 
            this.lblStockInTitle.AutoSize = true;
            this.lblStockInTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStockInTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblStockInTitle.Location = new System.Drawing.Point(16, 12);
            this.lblStockInTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockInTitle.Name = "lblStockInTitle";
            this.lblStockInTitle.Size = new System.Drawing.Size(279, 23);
            this.lblStockInTitle.TabIndex = 0;
            this.lblStockInTitle.Text = "RECEIVE GOODS / ADD STOCK IN";
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.pnlGrid.Controls.Add(this.dgInventory);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 399);
            this.pnlGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(21, 5, 21, 20);
            this.pnlGrid.Size = new System.Drawing.Size(1600, 527);
            this.pnlGrid.TabIndex = 4;
            // 
            // dgInventory
            // 
            this.dgInventory.AllowUserToAddRows = false;
            this.dgInventory.AllowUserToDeleteRows = false;
            this.dgInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.dgInventory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.dgInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgInventory.ColumnHeadersHeight = 38;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgInventory.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgInventory.EnableHeadersVisualStyles = false;
            this.dgInventory.Location = new System.Drawing.Point(21, 5);
            this.dgInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgInventory.MultiSelect = false;
            this.dgInventory.Name = "dgInventory";
            this.dgInventory.ReadOnly = true;
            this.dgInventory.RowHeadersVisible = false;
            this.dgInventory.RowHeadersWidth = 51;
            this.dgInventory.RowTemplate.Height = 36;
            this.dgInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInventory.Size = new System.Drawing.Size(1558, 502);
            this.dgInventory.TabIndex = 0;
            this.dgInventory.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgInventory_CellFormatting);
            this.dgInventory.DoubleClick += new System.EventHandler(this.dgInventory_DoubleClick);
            // 
            // uc_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlStockIn);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlKpi);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "uc_stock";
            this.Size = new System.Drawing.Size(1600, 926);
            this.Load += new System.EventHandler(this.uc_stock_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlKpi.ResumeLayout(false);
            this.pnlCard4.ResumeLayout(false);
            this.pnlCard4.PerformLayout();
            this.pnlCard3.ResumeLayout(false);
            this.pnlCard3.PerformLayout();
            this.pnlCard2.ResumeLayout(false);
            this.pnlCard2.PerformLayout();
            this.pnlCard1.ResumeLayout(false);
            this.pnlCard1.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlStockIn.ResumeLayout(false);
            this.pnlStockInCard.ResumeLayout(false);
            this.pnlStockInCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInQty)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnHeaderStockIn;
        private System.Windows.Forms.Panel pnlKpi;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblKpiTotalProdsTitle;
        private System.Windows.Forms.Label lblKpiTotalProdsVal;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblKpiInStockTitle;
        private System.Windows.Forms.Label lblKpiInStockVal;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Label lblKpiOutStockTitle;
        private System.Windows.Forms.Label lblKpiOutStockVal;
        private System.Windows.Forms.Panel pnlCard4;
        private System.Windows.Forms.Label lblKpiUnitsTitle;
        private System.Windows.Forms.Label lblKpiUnitsVal;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblCatFilter;
        private System.Windows.Forms.ComboBox cboCategoryFilter;
        private System.Windows.Forms.Label lblStatusFilter;
        private System.Windows.Forms.ComboBox cboStatusFilter;
        private System.Windows.Forms.Label lblFilterCount;
        private System.Windows.Forms.Panel pnlStockIn;
        private System.Windows.Forms.Panel pnlStockInCard;
        private System.Windows.Forms.Label lblStockInTitle;
        private System.Windows.Forms.Label lblInProduct;
        private System.Windows.Forms.ComboBox cboInProduct;
        private System.Windows.Forms.Label lblInCurStock;
        private System.Windows.Forms.Label lblInQty;
        private System.Windows.Forms.NumericUpDown nudInQty;
        private System.Windows.Forms.Label lblInCost;
        private System.Windows.Forms.NumericUpDown nudInCost;
        private System.Windows.Forms.Label lblInNotes;
        private System.Windows.Forms.TextBox txtInNotes;
        private System.Windows.Forms.Button btnSaveStockIn;
        private System.Windows.Forms.Button btnCloseStockIn;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgInventory;
    }
}
