namespace POS_204_oracle.uc
{
    partial class uc_report
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.cardHeader = new MaterialSkin.Controls.MaterialCard();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnModeSales = new Krypton.Toolkit.KryptonButton();
            this.btnModeInventory = new Krypton.Toolkit.KryptonButton();
            this.btnModeCustomers = new Krypton.Toolkit.KryptonButton();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.cardFilters = new MaterialSkin.Controls.MaterialCard();
            this.lblPreset = new System.Windows.Forms.Label();
            this.cboPreset = new Krypton.Toolkit.KryptonComboBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cboCustomer = new Krypton.Toolkit.KryptonComboBox();
            this.btnPrint = new Krypton.Toolkit.KryptonButton();
            this.pnlKpis = new System.Windows.Forms.Panel();
            this.cardKpi1 = new MaterialSkin.Controls.MaterialCard();
            this.lblKpi1Title = new System.Windows.Forms.Label();
            this.lblKpi1Val = new System.Windows.Forms.Label();
            this.cardKpi2 = new MaterialSkin.Controls.MaterialCard();
            this.lblKpi2Title = new System.Windows.Forms.Label();
            this.lblKpi2Val = new System.Windows.Forms.Label();
            this.cardKpi3 = new MaterialSkin.Controls.MaterialCard();
            this.lblKpi3Title = new System.Windows.Forms.Label();
            this.lblKpi3Val = new System.Windows.Forms.Label();
            this.cardKpi4 = new MaterialSkin.Controls.MaterialCard();
            this.lblKpi4Title = new System.Windows.Forms.Label();
            this.lblKpi4Val = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.cardGrid = new MaterialSkin.Controls.MaterialCard();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.dgReport = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            this.cardHeader.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.cardFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPreset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCustomer)).BeginInit();
            this.pnlKpis.SuspendLayout();
            this.cardKpi1.SuspendLayout();
            this.cardKpi2.SuspendLayout();
            this.cardKpi3.SuspendLayout();
            this.cardKpi4.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReport)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.pnlTop.Controls.Add(this.cardHeader);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1600, 94);
            this.pnlTop.TabIndex = 0;
            // 
            // cardHeader
            // 
            this.cardHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.cardHeader.Controls.Add(this.lblTitle);
            this.cardHeader.Controls.Add(this.btnModeSales);
            this.cardHeader.Controls.Add(this.btnModeInventory);
            this.cardHeader.Controls.Add(this.btnModeCustomers);
            this.cardHeader.Depth = 0;
            this.cardHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cardHeader.Location = new System.Drawing.Point(19, 7);
            this.cardHeader.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.cardHeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardHeader.Name = "cardHeader";
            this.cardHeader.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.cardHeader.Size = new System.Drawing.Size(1563, 79);
            this.cardHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblTitle.Location = new System.Drawing.Point(19, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(270, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BUSINESS INTELLIGENCE";
            // 
            // btnModeSales
            // 
            this.btnModeSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModeSales.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnModeSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModeSales.Location = new System.Drawing.Point(987, 17);
            this.btnModeSales.Margin = new System.Windows.Forms.Padding(4);
            this.btnModeSales.Name = "btnModeSales";
            this.btnModeSales.Size = new System.Drawing.Size(173, 44);
            this.btnModeSales.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnModeSales.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.btnModeSales.StateCommon.Border.Rounding = 6F;
            this.btnModeSales.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.btnModeSales.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnModeSales.TabIndex = 2;
            this.btnModeSales.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnModeSales.Values.Text = "Sales Report";
            this.btnModeSales.Click += new System.EventHandler(this.btnModeSales_Click);
            // 
            // btnModeInventory
            // 
            this.btnModeInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModeInventory.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnModeInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModeInventory.Location = new System.Drawing.Point(1173, 17);
            this.btnModeInventory.Margin = new System.Windows.Forms.Padding(4);
            this.btnModeInventory.Name = "btnModeInventory";
            this.btnModeInventory.Size = new System.Drawing.Size(187, 44);
            this.btnModeInventory.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btnModeInventory.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnModeInventory.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.btnModeInventory.StateCommon.Border.Rounding = 6F;
            this.btnModeInventory.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnModeInventory.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnModeInventory.TabIndex = 3;
            this.btnModeInventory.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnModeInventory.Values.Text = "Stock Report";
            this.btnModeInventory.Click += new System.EventHandler(this.btnModeInventory_Click);
            // 
            // btnModeCustomers
            // 
            this.btnModeCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModeCustomers.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnModeCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModeCustomers.Location = new System.Drawing.Point(1373, 17);
            this.btnModeCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.btnModeCustomers.Name = "btnModeCustomers";
            this.btnModeCustomers.Size = new System.Drawing.Size(173, 44);
            this.btnModeCustomers.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btnModeCustomers.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnModeCustomers.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.btnModeCustomers.StateCommon.Border.Rounding = 6F;
            this.btnModeCustomers.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnModeCustomers.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnModeCustomers.TabIndex = 4;
            this.btnModeCustomers.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnModeCustomers.Values.Text = "Customers";
            this.btnModeCustomers.Click += new System.EventHandler(this.btnModeCustomers_Click);
            // 
            // pnlFilters
            // 
            this.pnlFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.pnlFilters.Controls.Add(this.cardFilters);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilters.Location = new System.Drawing.Point(0, 94);
            this.pnlFilters.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(1600, 89);
            this.pnlFilters.TabIndex = 1;
            // 
            // cardFilters
            // 
            this.cardFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.cardFilters.Controls.Add(this.lblPreset);
            this.cardFilters.Controls.Add(this.cboPreset);
            this.cardFilters.Controls.Add(this.lblFrom);
            this.cardFilters.Controls.Add(this.dtpFrom);
            this.cardFilters.Controls.Add(this.lblTo);
            this.cardFilters.Controls.Add(this.dtpTo);
            this.cardFilters.Controls.Add(this.lblCustomer);
            this.cardFilters.Controls.Add(this.cboCustomer);
            this.cardFilters.Controls.Add(this.btnPrint);
            this.cardFilters.Depth = 0;
            this.cardFilters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cardFilters.Location = new System.Drawing.Point(19, 7);
            this.cardFilters.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.cardFilters.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardFilters.Name = "cardFilters";
            this.cardFilters.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.cardFilters.Size = new System.Drawing.Size(1563, 71);
            this.cardFilters.TabIndex = 0;
            // 
            // lblPreset
            // 
            this.lblPreset.AutoSize = true;
            this.lblPreset.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPreset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblPreset.Location = new System.Drawing.Point(19, 22);
            this.lblPreset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreset.Name = "lblPreset";
            this.lblPreset.Size = new System.Drawing.Size(58, 20);
            this.lblPreset.TabIndex = 0;
            this.lblPreset.Text = "Period:";
            // 
            // cboPreset
            // 
            this.cboPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPreset.DropDownWidth = 110;
            this.cboPreset.Items.AddRange(new object[] {
            "Today",
            "This Week",
            "This Month",
            "All Time",
            "Custom"});
            this.cboPreset.Location = new System.Drawing.Point(91, 17);
            this.cboPreset.Margin = new System.Windows.Forms.Padding(4);
            this.cboPreset.Name = "cboPreset";
            this.cboPreset.Size = new System.Drawing.Size(147, 30);
            this.cboPreset.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cboPreset.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.cboPreset.StateCommon.ComboBox.Border.Rounding = 6F;
            this.cboPreset.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cboPreset.TabIndex = 1;
            this.cboPreset.SelectedIndexChanged += new System.EventHandler(this.cboPreset_SelectedIndexChanged);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblFrom.Location = new System.Drawing.Point(253, 22);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(50, 20);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "From:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dtpFrom.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.dtpFrom.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.dtpFrom.CustomFormat = "yyyy-MM-dd";
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(309, 17);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(139, 27);
            this.dtpFrom.TabIndex = 3;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTo.Location = new System.Drawing.Point(463, 22);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(30, 20);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "To:";
            // 
            // dtpTo
            // 
            this.dtpTo.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dtpTo.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.dtpTo.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.dtpTo.CustomFormat = "yyyy-MM-dd";
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(500, 17);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(139, 27);
            this.dtpTo.TabIndex = 5;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblCustomer.Location = new System.Drawing.Point(660, 22);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(82, 20);
            this.lblCustomer.TabIndex = 6;
            this.lblCustomer.Text = "Customer:";
            // 
            // cboCustomer
            // 
            this.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomer.DropDownWidth = 140;
            this.cboCustomer.Location = new System.Drawing.Point(753, 17);
            this.cboCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(187, 30);
            this.cboCustomer.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cboCustomer.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.cboCustomer.StateCommon.ComboBox.Border.Rounding = 6F;
            this.cboCustomer.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cboCustomer.TabIndex = 7;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Location = new System.Drawing.Point(1420, 12);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(127, 44);
            this.btnPrint.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btnPrint.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnPrint.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.btnPrint.StateCommon.Border.Rounding = 6F;
            this.btnPrint.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnPrint.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnPrint.Values.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pnlKpis
            // 
            this.pnlKpis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.pnlKpis.Controls.Add(this.cardKpi1);
            this.pnlKpis.Controls.Add(this.cardKpi2);
            this.pnlKpis.Controls.Add(this.cardKpi3);
            this.pnlKpis.Controls.Add(this.cardKpi4);
            this.pnlKpis.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKpis.Location = new System.Drawing.Point(0, 183);
            this.pnlKpis.Margin = new System.Windows.Forms.Padding(4);
            this.pnlKpis.Name = "pnlKpis";
            this.pnlKpis.Size = new System.Drawing.Size(1600, 123);
            this.pnlKpis.TabIndex = 2;
            // 
            // cardKpi1
            // 
            this.cardKpi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.cardKpi1.Controls.Add(this.lblKpi1Title);
            this.cardKpi1.Controls.Add(this.lblKpi1Val);
            this.cardKpi1.Depth = 0;
            this.cardKpi1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cardKpi1.Location = new System.Drawing.Point(19, 7);
            this.cardKpi1.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.cardKpi1.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardKpi1.Name = "cardKpi1";
            this.cardKpi1.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.cardKpi1.Size = new System.Drawing.Size(367, 105);
            this.cardKpi1.TabIndex = 0;
            // 
            // lblKpi1Title
            // 
            this.lblKpi1Title.AutoSize = true;
            this.lblKpi1Title.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblKpi1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblKpi1Title.Location = new System.Drawing.Point(19, 15);
            this.lblKpi1Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKpi1Title.Name = "lblKpi1Title";
            this.lblKpi1Title.Size = new System.Drawing.Size(125, 20);
            this.lblKpi1Title.TabIndex = 0;
            this.lblKpi1Title.Text = "TOTAL REVENUE";
            // 
            // lblKpi1Val
            // 
            this.lblKpi1Val.AutoSize = true;
            this.lblKpi1Val.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblKpi1Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblKpi1Val.Location = new System.Drawing.Point(16, 44);
            this.lblKpi1Val.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKpi1Val.Name = "lblKpi1Val";
            this.lblKpi1Val.Size = new System.Drawing.Size(88, 37);
            this.lblKpi1Val.TabIndex = 1;
            this.lblKpi1Val.Text = "$0.00";
            // 
            // cardKpi2
            // 
            this.cardKpi2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.cardKpi2.Controls.Add(this.lblKpi2Title);
            this.cardKpi2.Controls.Add(this.lblKpi2Val);
            this.cardKpi2.Depth = 0;
            this.cardKpi2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cardKpi2.Location = new System.Drawing.Point(407, 7);
            this.cardKpi2.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.cardKpi2.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardKpi2.Name = "cardKpi2";
            this.cardKpi2.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.cardKpi2.Size = new System.Drawing.Size(367, 105);
            this.cardKpi2.TabIndex = 1;
            // 
            // lblKpi2Title
            // 
            this.lblKpi2Title.AutoSize = true;
            this.lblKpi2Title.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblKpi2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.lblKpi2Title.Location = new System.Drawing.Point(19, 15);
            this.lblKpi2Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKpi2Title.Name = "lblKpi2Title";
            this.lblKpi2Title.Size = new System.Drawing.Size(116, 20);
            this.lblKpi2Title.TabIndex = 0;
            this.lblKpi2Title.Text = "TOTAL ORDERS";
            // 
            // lblKpi2Val
            // 
            this.lblKpi2Val.AutoSize = true;
            this.lblKpi2Val.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblKpi2Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblKpi2Val.Location = new System.Drawing.Point(16, 44);
            this.lblKpi2Val.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKpi2Val.Name = "lblKpi2Val";
            this.lblKpi2Val.Size = new System.Drawing.Size(33, 37);
            this.lblKpi2Val.TabIndex = 1;
            this.lblKpi2Val.Text = "0";
            // 
            // cardKpi3
            // 
            this.cardKpi3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.cardKpi3.Controls.Add(this.lblKpi3Title);
            this.cardKpi3.Controls.Add(this.lblKpi3Val);
            this.cardKpi3.Depth = 0;
            this.cardKpi3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cardKpi3.Location = new System.Drawing.Point(793, 7);
            this.cardKpi3.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.cardKpi3.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardKpi3.Name = "cardKpi3";
            this.cardKpi3.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.cardKpi3.Size = new System.Drawing.Size(367, 105);
            this.cardKpi3.TabIndex = 2;
            // 
            // lblKpi3Title
            // 
            this.lblKpi3Title.AutoSize = true;
            this.lblKpi3Title.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblKpi3Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblKpi3Title.Location = new System.Drawing.Point(19, 15);
            this.lblKpi3Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKpi3Title.Name = "lblKpi3Title";
            this.lblKpi3Title.Size = new System.Drawing.Size(134, 20);
            this.lblKpi3Title.TabIndex = 0;
            this.lblKpi3Title.Text = "TOTAL DISCOUNT";
            // 
            // lblKpi3Val
            // 
            this.lblKpi3Val.AutoSize = true;
            this.lblKpi3Val.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblKpi3Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblKpi3Val.Location = new System.Drawing.Point(16, 44);
            this.lblKpi3Val.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKpi3Val.Name = "lblKpi3Val";
            this.lblKpi3Val.Size = new System.Drawing.Size(88, 37);
            this.lblKpi3Val.TabIndex = 1;
            this.lblKpi3Val.Text = "$0.00";
            // 
            // cardKpi4
            // 
            this.cardKpi4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.cardKpi4.Controls.Add(this.lblKpi4Title);
            this.cardKpi4.Controls.Add(this.lblKpi4Val);
            this.cardKpi4.Depth = 0;
            this.cardKpi4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cardKpi4.Location = new System.Drawing.Point(1180, 7);
            this.cardKpi4.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.cardKpi4.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardKpi4.Name = "cardKpi4";
            this.cardKpi4.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.cardKpi4.Size = new System.Drawing.Size(367, 105);
            this.cardKpi4.TabIndex = 3;
            // 
            // lblKpi4Title
            // 
            this.lblKpi4Title.AutoSize = true;
            this.lblKpi4Title.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblKpi4Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.lblKpi4Title.Location = new System.Drawing.Point(19, 15);
            this.lblKpi4Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKpi4Title.Name = "lblKpi4Title";
            this.lblKpi4Title.Size = new System.Drawing.Size(145, 20);
            this.lblKpi4Title.TabIndex = 0;
            this.lblKpi4Title.Text = "AVG ORDER VALUE";
            // 
            // lblKpi4Val
            // 
            this.lblKpi4Val.AutoSize = true;
            this.lblKpi4Val.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblKpi4Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblKpi4Val.Location = new System.Drawing.Point(16, 44);
            this.lblKpi4Val.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKpi4Val.Name = "lblKpi4Val";
            this.lblKpi4Val.Size = new System.Drawing.Size(88, 37);
            this.lblKpi4Val.TabIndex = 1;
            this.lblKpi4Val.Text = "$0.00";
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.pnlGrid.Controls.Add(this.cardGrid);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 306);
            this.pnlGrid.Margin = new System.Windows.Forms.Padding(4);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1600, 679);
            this.pnlGrid.TabIndex = 3;
            // 
            // cardGrid
            // 
            this.cardGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.cardGrid.Controls.Add(this.lblGridTitle);
            this.cardGrid.Controls.Add(this.dgReport);
            this.cardGrid.Depth = 0;
            this.cardGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cardGrid.Location = new System.Drawing.Point(19, 7);
            this.cardGrid.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.cardGrid.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.cardGrid.Size = new System.Drawing.Size(1563, 655);
            this.cardGrid.TabIndex = 0;
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblGridTitle.Location = new System.Drawing.Point(19, 15);
            this.lblGridTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(228, 25);
            this.lblGridTitle.TabIndex = 0;
            this.lblGridTitle.Text = "Detailed Report Records";
            // 
            // dgReport
            // 
            this.dgReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.dgReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.dgReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReport.Location = new System.Drawing.Point(19, 49);
            this.dgReport.Margin = new System.Windows.Forms.Padding(4);
            this.dgReport.Name = "dgReport";
            this.dgReport.RowHeadersWidth = 51;
            this.dgReport.Size = new System.Drawing.Size(1525, 588);
            this.dgReport.TabIndex = 1;
            // 
            // uc_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlKpis);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.pnlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uc_report";
            this.Size = new System.Drawing.Size(1600, 985);
            this.Load += new System.EventHandler(this.uc_report_Load);
            this.pnlTop.ResumeLayout(false);
            this.cardHeader.ResumeLayout(false);
            this.cardHeader.PerformLayout();
            this.pnlFilters.ResumeLayout(false);
            this.cardFilters.ResumeLayout(false);
            this.cardFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPreset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCustomer)).EndInit();
            this.pnlKpis.ResumeLayout(false);
            this.cardKpi1.ResumeLayout(false);
            this.cardKpi1.PerformLayout();
            this.cardKpi2.ResumeLayout(false);
            this.cardKpi2.PerformLayout();
            this.cardKpi3.ResumeLayout(false);
            this.cardKpi3.PerformLayout();
            this.cardKpi4.ResumeLayout(false);
            this.cardKpi4.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            this.cardGrid.ResumeLayout(false);
            this.cardGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private MaterialSkin.Controls.MaterialCard cardHeader;
        private System.Windows.Forms.Label lblTitle;
        private Krypton.Toolkit.KryptonButton btnModeSales;
        private Krypton.Toolkit.KryptonButton btnModeInventory;
        private Krypton.Toolkit.KryptonButton btnModeCustomers;
        private System.Windows.Forms.Panel pnlFilters;
        private MaterialSkin.Controls.MaterialCard cardFilters;
        private System.Windows.Forms.Label lblPreset;
        private Krypton.Toolkit.KryptonComboBox cboPreset;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblCustomer;
        private Krypton.Toolkit.KryptonComboBox cboCustomer;
        private Krypton.Toolkit.KryptonButton btnPrint;
        private System.Windows.Forms.Panel pnlKpis;
        private MaterialSkin.Controls.MaterialCard cardKpi1;
        private System.Windows.Forms.Label lblKpi1Title;
        private System.Windows.Forms.Label lblKpi1Val;
        private MaterialSkin.Controls.MaterialCard cardKpi2;
        private System.Windows.Forms.Label lblKpi2Title;
        private System.Windows.Forms.Label lblKpi2Val;
        private MaterialSkin.Controls.MaterialCard cardKpi3;
        private System.Windows.Forms.Label lblKpi3Title;
        private System.Windows.Forms.Label lblKpi3Val;
        private MaterialSkin.Controls.MaterialCard cardKpi4;
        private System.Windows.Forms.Label lblKpi4Title;
        private System.Windows.Forms.Label lblKpi4Val;
        private System.Windows.Forms.Panel pnlGrid;
        private MaterialSkin.Controls.MaterialCard cardGrid;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.DataGridView dgReport;
    }
}
