namespace POS_204_oracle.uc
{
    partial class uc_dashboard
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
            this.flpActions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefresh = new Krypton.Toolkit.KryptonButton();
            this.btnQuickReport = new Krypton.Toolkit.KryptonButton();
            this.btnQuickCustomer = new Krypton.Toolkit.KryptonButton();
            this.btnQuickProduct = new Krypton.Toolkit.KryptonButton();
            this.btnQuickSale = new Krypton.Toolkit.KryptonButton();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlKpis = new System.Windows.Forms.Panel();
            this.tblKpis = new System.Windows.Forms.TableLayoutPanel();
            this.cardRev = new MaterialSkin.Controls.MaterialCard();
            this.lblRevVal = new System.Windows.Forms.Label();
            this.lblRevTitle = new System.Windows.Forms.Label();
            this.cardOrd = new MaterialSkin.Controls.MaterialCard();
            this.lblOrdVal = new System.Windows.Forms.Label();
            this.lblOrdTitle = new System.Windows.Forms.Label();
            this.cardProd = new MaterialSkin.Controls.MaterialCard();
            this.lblProdVal = new System.Windows.Forms.Label();
            this.lblProdTitle = new System.Windows.Forms.Label();
            this.cardCust = new MaterialSkin.Controls.MaterialCard();
            this.lblCustVal = new System.Windows.Forms.Label();
            this.lblCustTitle = new System.Windows.Forms.Label();
            this.pnlAlert = new System.Windows.Forms.Panel();
            this.lblAlert = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.tblBody = new System.Windows.Forms.TableLayoutPanel();
            this.tblMiddle = new System.Windows.Forms.TableLayoutPanel();
            this.cardChart = new MaterialSkin.Controls.MaterialCard();
            this.pnlChart = new System.Windows.Forms.Panel();
            this.lblChartTitle = new System.Windows.Forms.Label();
            this.cardTopProds = new MaterialSkin.Controls.MaterialCard();
            this.dgTopProds = new System.Windows.Forms.DataGridView();
            this.lblTopTitle = new System.Windows.Forms.Label();
            this.cardRecent = new MaterialSkin.Controls.MaterialCard();
            this.dgRecentSales = new System.Windows.Forms.DataGridView();
            this.lblRecentTitle = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.cardHeader.SuspendLayout();
            this.flpActions.SuspendLayout();
            this.pnlKpis.SuspendLayout();
            this.tblKpis.SuspendLayout();
            this.cardRev.SuspendLayout();
            this.cardOrd.SuspendLayout();
            this.cardProd.SuspendLayout();
            this.cardCust.SuspendLayout();
            this.pnlAlert.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.tblBody.SuspendLayout();
            this.tblMiddle.SuspendLayout();
            this.cardChart.SuspendLayout();
            this.cardTopProds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTopProds)).BeginInit();
            this.cardRecent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecentSales)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.cardHeader);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(12, 8, 12, 4);
            this.pnlTop.Size = new System.Drawing.Size(1600, 76);
            this.pnlTop.TabIndex = 0;
            // 
            // cardHeader
            // 
            this.cardHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.cardHeader.Controls.Add(this.flpActions);
            this.cardHeader.Controls.Add(this.lblWelcome);
            this.cardHeader.Depth = 0;
            this.cardHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardHeader.Location = new System.Drawing.Point(12, 8);
            this.cardHeader.Margin = new System.Windows.Forms.Padding(0);
            this.cardHeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardHeader.Name = "cardHeader";
            this.cardHeader.Padding = new System.Windows.Forms.Padding(14, 8, 14, 8);
            this.cardHeader.Size = new System.Drawing.Size(1576, 64);
            this.cardHeader.TabIndex = 0;
            // 
            // flpActions
            // 
            this.flpActions.AutoSize = true;
            this.flpActions.Controls.Add(this.btnRefresh);
            this.flpActions.Controls.Add(this.btnQuickReport);
            this.flpActions.Controls.Add(this.btnQuickCustomer);
            this.flpActions.Controls.Add(this.btnQuickProduct);
            this.flpActions.Controls.Add(this.btnQuickSale);
            this.flpActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpActions.Location = new System.Drawing.Point(1002, 8);
            this.flpActions.Name = "flpActions";
            this.flpActions.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.flpActions.Size = new System.Drawing.Size(560, 48);
            this.flpActions.TabIndex = 2;
            this.flpActions.WrapContents = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Location = new System.Drawing.Point(457, 7);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 36);
            this.btnRefresh.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnRefresh.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(145)))), ((int)(((byte)(178)))));
            this.btnRefresh.StateCommon.Border.Rounding = 6F;
            this.btnRefresh.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnRefresh.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRefresh.Values.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnQuickReport
            // 
            this.btnQuickReport.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnQuickReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuickReport.Location = new System.Drawing.Point(351, 7);
            this.btnQuickReport.Name = "btnQuickReport";
            this.btnQuickReport.Size = new System.Drawing.Size(100, 36);
            this.btnQuickReport.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btnQuickReport.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.btnQuickReport.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.btnQuickReport.StateCommon.Border.Rounding = 6F;
            this.btnQuickReport.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnQuickReport.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnQuickReport.TabIndex = 3;
            this.btnQuickReport.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnQuickReport.Values.Text = "Reports";
            this.btnQuickReport.Click += new System.EventHandler(this.btnQuickReport_Click);
            // 
            // btnQuickCustomer
            // 
            this.btnQuickCustomer.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnQuickCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuickCustomer.Location = new System.Drawing.Point(235, 7);
            this.btnQuickCustomer.Name = "btnQuickCustomer";
            this.btnQuickCustomer.Size = new System.Drawing.Size(110, 36);
            this.btnQuickCustomer.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btnQuickCustomer.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.btnQuickCustomer.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.btnQuickCustomer.StateCommon.Border.Rounding = 6F;
            this.btnQuickCustomer.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnQuickCustomer.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnQuickCustomer.TabIndex = 2;
            this.btnQuickCustomer.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnQuickCustomer.Values.Text = "Customers";
            this.btnQuickCustomer.Click += new System.EventHandler(this.btnQuickCustomer_Click);
            // 
            // btnQuickProduct
            // 
            this.btnQuickProduct.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnQuickProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuickProduct.Location = new System.Drawing.Point(124, 7);
            this.btnQuickProduct.Name = "btnQuickProduct";
            this.btnQuickProduct.Size = new System.Drawing.Size(105, 36);
            this.btnQuickProduct.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btnQuickProduct.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.btnQuickProduct.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(80)))));
            this.btnQuickProduct.StateCommon.Border.Rounding = 6F;
            this.btnQuickProduct.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnQuickProduct.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnQuickProduct.TabIndex = 1;
            this.btnQuickProduct.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnQuickProduct.Values.Text = "Products";
            this.btnQuickProduct.Click += new System.EventHandler(this.btnQuickProduct_Click);
            // 
            // btnQuickSale
            // 
            this.btnQuickSale.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnQuickSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuickSale.Location = new System.Drawing.Point(3, 7);
            this.btnQuickSale.Name = "btnQuickSale";
            this.btnQuickSale.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnQuickSale.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.btnQuickSale.OverrideDefault.Border.Rounding = 6F;
            this.btnQuickSale.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnQuickSale.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnQuickSale.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.btnQuickSale.OverrideFocus.Border.Rounding = 6F;
            this.btnQuickSale.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnQuickSale.Size = new System.Drawing.Size(115, 36);
            this.btnQuickSale.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnQuickSale.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.btnQuickSale.StateCommon.Border.Rounding = 6F;
            this.btnQuickSale.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnQuickSale.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnQuickSale.TabIndex = 0;
            this.btnQuickSale.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnQuickSale.Values.Text = "＋ New Sale";
            this.btnQuickSale.Click += new System.EventHandler(this.btnQuickSale_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblWelcome.Location = new System.Drawing.Point(14, 18);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(262, 28);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "⚡ Analytics & Dashboard";
            this.lblWelcome.UseMnemonic = false;
            // 
            // pnlKpis
            // 
            this.pnlKpis.Controls.Add(this.tblKpis);
            this.pnlKpis.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKpis.Location = new System.Drawing.Point(0, 76);
            this.pnlKpis.Margin = new System.Windows.Forms.Padding(0);
            this.pnlKpis.Name = "pnlKpis";
            this.pnlKpis.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.pnlKpis.Size = new System.Drawing.Size(1600, 94);
            this.pnlKpis.TabIndex = 1;
            // 
            // tblKpis
            // 
            this.tblKpis.ColumnCount = 4;
            this.tblKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblKpis.Controls.Add(this.cardRev, 0, 0);
            this.tblKpis.Controls.Add(this.cardOrd, 1, 0);
            this.tblKpis.Controls.Add(this.cardProd, 2, 0);
            this.tblKpis.Controls.Add(this.cardCust, 3, 0);
            this.tblKpis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblKpis.Location = new System.Drawing.Point(12, 4);
            this.tblKpis.Margin = new System.Windows.Forms.Padding(0);
            this.tblKpis.Name = "tblKpis";
            this.tblKpis.RowCount = 1;
            this.tblKpis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblKpis.Size = new System.Drawing.Size(1576, 86);
            this.tblKpis.TabIndex = 0;
            // 
            // cardRev
            // 
            this.cardRev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.cardRev.Controls.Add(this.lblRevVal);
            this.cardRev.Controls.Add(this.lblRevTitle);
            this.cardRev.Depth = 0;
            this.cardRev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardRev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardRev.Location = new System.Drawing.Point(0, 0);
            this.cardRev.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.cardRev.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardRev.Name = "cardRev";
            this.cardRev.Padding = new System.Windows.Forms.Padding(14, 8, 14, 8);
            this.cardRev.Size = new System.Drawing.Size(390, 86);
            this.cardRev.TabIndex = 0;
            // 
            // lblRevVal
            // 
            this.lblRevVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRevVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblRevVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblRevVal.Location = new System.Drawing.Point(14, 28);
            this.lblRevVal.Name = "lblRevVal";
            this.lblRevVal.Size = new System.Drawing.Size(362, 50);
            this.lblRevVal.TabIndex = 1;
            this.lblRevVal.Text = "$0.00";
            this.lblRevVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRevTitle
            // 
            this.lblRevTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRevTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRevTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.lblRevTitle.Location = new System.Drawing.Point(14, 8);
            this.lblRevTitle.Name = "lblRevTitle";
            this.lblRevTitle.Size = new System.Drawing.Size(362, 20);
            this.lblRevTitle.TabIndex = 0;
            this.lblRevTitle.Text = "TOTAL REVENUE";
            this.lblRevTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cardOrd
            // 
            this.cardOrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.cardOrd.Controls.Add(this.lblOrdVal);
            this.cardOrd.Controls.Add(this.lblOrdTitle);
            this.cardOrd.Depth = 0;
            this.cardOrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardOrd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardOrd.Location = new System.Drawing.Point(398, 0);
            this.cardOrd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cardOrd.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardOrd.Name = "cardOrd";
            this.cardOrd.Padding = new System.Windows.Forms.Padding(14, 8, 14, 8);
            this.cardOrd.Size = new System.Drawing.Size(386, 86);
            this.cardOrd.TabIndex = 1;
            // 
            // lblOrdVal
            // 
            this.lblOrdVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrdVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblOrdVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.lblOrdVal.Location = new System.Drawing.Point(14, 28);
            this.lblOrdVal.Name = "lblOrdVal";
            this.lblOrdVal.Size = new System.Drawing.Size(358, 50);
            this.lblOrdVal.TabIndex = 1;
            this.lblOrdVal.Text = "0";
            this.lblOrdVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrdTitle
            // 
            this.lblOrdTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOrdTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblOrdTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.lblOrdTitle.Location = new System.Drawing.Point(14, 8);
            this.lblOrdTitle.Name = "lblOrdTitle";
            this.lblOrdTitle.Size = new System.Drawing.Size(358, 20);
            this.lblOrdTitle.TabIndex = 0;
            this.lblOrdTitle.Text = "TOTAL ORDERS";
            this.lblOrdTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cardProd
            // 
            this.cardProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.cardProd.Controls.Add(this.lblProdVal);
            this.cardProd.Controls.Add(this.lblProdTitle);
            this.cardProd.Depth = 0;
            this.cardProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardProd.Location = new System.Drawing.Point(792, 0);
            this.cardProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cardProd.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardProd.Name = "cardProd";
            this.cardProd.Padding = new System.Windows.Forms.Padding(14, 8, 14, 8);
            this.cardProd.Size = new System.Drawing.Size(386, 86);
            this.cardProd.TabIndex = 2;
            // 
            // lblProdVal
            // 
            this.lblProdVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProdVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblProdVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.lblProdVal.Location = new System.Drawing.Point(14, 28);
            this.lblProdVal.Name = "lblProdVal";
            this.lblProdVal.Size = new System.Drawing.Size(358, 50);
            this.lblProdVal.TabIndex = 1;
            this.lblProdVal.Text = "0";
            this.lblProdVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProdTitle
            // 
            this.lblProdTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProdTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblProdTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(139)))), ((int)(((byte)(250)))));
            this.lblProdTitle.Location = new System.Drawing.Point(14, 8);
            this.lblProdTitle.Name = "lblProdTitle";
            this.lblProdTitle.Size = new System.Drawing.Size(358, 20);
            this.lblProdTitle.TabIndex = 0;
            this.lblProdTitle.Text = "ACTIVE PRODUCTS";
            this.lblProdTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cardCust
            // 
            this.cardCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.cardCust.Controls.Add(this.lblCustVal);
            this.cardCust.Controls.Add(this.lblCustTitle);
            this.cardCust.Depth = 0;
            this.cardCust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardCust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardCust.Location = new System.Drawing.Point(1186, 0);
            this.cardCust.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.cardCust.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardCust.Name = "cardCust";
            this.cardCust.Padding = new System.Windows.Forms.Padding(14, 8, 14, 8);
            this.cardCust.Size = new System.Drawing.Size(390, 86);
            this.cardCust.TabIndex = 3;
            // 
            // lblCustVal
            // 
            this.lblCustVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCustVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblCustVal.Location = new System.Drawing.Point(14, 28);
            this.lblCustVal.Name = "lblCustVal";
            this.lblCustVal.Size = new System.Drawing.Size(362, 50);
            this.lblCustVal.TabIndex = 1;
            this.lblCustVal.Text = "0";
            this.lblCustVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustTitle
            // 
            this.lblCustTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCustTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCustTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.lblCustTitle.Location = new System.Drawing.Point(14, 8);
            this.lblCustTitle.Name = "lblCustTitle";
            this.lblCustTitle.Size = new System.Drawing.Size(362, 20);
            this.lblCustTitle.TabIndex = 0;
            this.lblCustTitle.Text = "TOTAL CUSTOMERS";
            this.lblCustTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlAlert
            // 
            this.pnlAlert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(18)))), ((int)(((byte)(24)))));
            this.pnlAlert.Controls.Add(this.lblAlert);
            this.pnlAlert.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAlert.Location = new System.Drawing.Point(0, 170);
            this.pnlAlert.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAlert.Name = "pnlAlert";
            this.pnlAlert.Padding = new System.Windows.Forms.Padding(12, 0, 12, 4);
            this.pnlAlert.Size = new System.Drawing.Size(1600, 36);
            this.pnlAlert.TabIndex = 2;
            this.pnlAlert.Visible = false;
            // 
            // lblAlert
            // 
            this.lblAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAlert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAlert.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblAlert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.lblAlert.Location = new System.Drawing.Point(12, 0);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(1576, 32);
            this.lblAlert.TabIndex = 0;
            this.lblAlert.Text = "⚠️ Low stock warning: Click here to inspect inventory items.";
            this.lblAlert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAlert.Click += new System.EventHandler(this.lblAlert_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.tblBody);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 206);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(12, 4, 12, 8);
            this.pnlBody.Size = new System.Drawing.Size(1600, 779);
            this.pnlBody.TabIndex = 3;
            // 
            // tblBody
            // 
            this.tblBody.ColumnCount = 1;
            this.tblBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBody.Controls.Add(this.tblMiddle, 0, 0);
            this.tblBody.Controls.Add(this.cardRecent, 0, 1);
            this.tblBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBody.Location = new System.Drawing.Point(12, 4);
            this.tblBody.Margin = new System.Windows.Forms.Padding(0);
            this.tblBody.Name = "tblBody";
            this.tblBody.RowCount = 2;
            this.tblBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.tblBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tblBody.Size = new System.Drawing.Size(1576, 767);
            this.tblBody.TabIndex = 0;
            // 
            // tblMiddle
            // 
            this.tblMiddle.ColumnCount = 2;
            this.tblMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.tblMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tblMiddle.Controls.Add(this.cardChart, 0, 0);
            this.tblMiddle.Controls.Add(this.cardTopProds, 1, 0);
            this.tblMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMiddle.Location = new System.Drawing.Point(0, 0);
            this.tblMiddle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.tblMiddle.Name = "tblMiddle";
            this.tblMiddle.RowCount = 1;
            this.tblMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMiddle.Size = new System.Drawing.Size(1576, 402);
            this.tblMiddle.TabIndex = 0;
            // 
            // cardChart
            // 
            this.cardChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.cardChart.Controls.Add(this.pnlChart);
            this.cardChart.Controls.Add(this.lblChartTitle);
            this.cardChart.Depth = 0;
            this.cardChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardChart.Location = new System.Drawing.Point(0, 0);
            this.cardChart.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.cardChart.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardChart.Name = "cardChart";
            this.cardChart.Padding = new System.Windows.Forms.Padding(14, 8, 14, 8);
            this.cardChart.Size = new System.Drawing.Size(1004, 402);
            this.cardChart.TabIndex = 0;
            // 
            // pnlChart
            // 
            this.pnlChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(35)))));
            this.pnlChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChart.Location = new System.Drawing.Point(14, 32);
            this.pnlChart.Margin = new System.Windows.Forms.Padding(0);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Size = new System.Drawing.Size(976, 362);
            this.pnlChart.TabIndex = 1;
            this.pnlChart.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChart_Paint);
            // 
            // lblChartTitle
            // 
            this.lblChartTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChartTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblChartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblChartTitle.Location = new System.Drawing.Point(14, 8);
            this.lblChartTitle.Name = "lblChartTitle";
            this.lblChartTitle.Size = new System.Drawing.Size(976, 24);
            this.lblChartTitle.TabIndex = 0;
            this.lblChartTitle.Text = "Past 7-Days Revenue Trend";
            this.lblChartTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cardTopProds
            // 
            this.cardTopProds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.cardTopProds.Controls.Add(this.dgTopProds);
            this.cardTopProds.Controls.Add(this.lblTopTitle);
            this.cardTopProds.Depth = 0;
            this.cardTopProds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardTopProds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardTopProds.Location = new System.Drawing.Point(1012, 0);
            this.cardTopProds.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.cardTopProds.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardTopProds.Name = "cardTopProds";
            this.cardTopProds.Padding = new System.Windows.Forms.Padding(14, 8, 14, 8);
            this.cardTopProds.Size = new System.Drawing.Size(564, 402);
            this.cardTopProds.TabIndex = 1;
            // 
            // dgTopProds
            // 
            this.dgTopProds.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(35)))));
            this.dgTopProds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgTopProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTopProds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTopProds.Location = new System.Drawing.Point(14, 32);
            this.dgTopProds.Margin = new System.Windows.Forms.Padding(0);
            this.dgTopProds.Name = "dgTopProds";
            this.dgTopProds.RowHeadersWidth = 51;
            this.dgTopProds.Size = new System.Drawing.Size(536, 362);
            this.dgTopProds.TabIndex = 1;
            // 
            // lblTopTitle
            // 
            this.lblTopTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTopTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTopTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblTopTitle.Location = new System.Drawing.Point(14, 8);
            this.lblTopTitle.Name = "lblTopTitle";
            this.lblTopTitle.Size = new System.Drawing.Size(536, 24);
            this.lblTopTitle.TabIndex = 0;
            this.lblTopTitle.Text = "Top Selling Products";
            this.lblTopTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cardRecent
            // 
            this.cardRecent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.cardRecent.Controls.Add(this.dgRecentSales);
            this.cardRecent.Controls.Add(this.lblRecentTitle);
            this.cardRecent.Depth = 0;
            this.cardRecent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardRecent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardRecent.Location = new System.Drawing.Point(0, 410);
            this.cardRecent.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.cardRecent.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardRecent.Name = "cardRecent";
            this.cardRecent.Padding = new System.Windows.Forms.Padding(14, 8, 14, 8);
            this.cardRecent.Size = new System.Drawing.Size(1576, 357);
            this.cardRecent.TabIndex = 1;
            // 
            // dgRecentSales
            // 
            this.dgRecentSales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(35)))));
            this.dgRecentSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgRecentSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRecentSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRecentSales.Location = new System.Drawing.Point(14, 32);
            this.dgRecentSales.Margin = new System.Windows.Forms.Padding(0);
            this.dgRecentSales.Name = "dgRecentSales";
            this.dgRecentSales.RowHeadersWidth = 51;
            this.dgRecentSales.Size = new System.Drawing.Size(1548, 317);
            this.dgRecentSales.TabIndex = 1;
            // 
            // lblRecentTitle
            // 
            this.lblRecentTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRecentTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblRecentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblRecentTitle.Location = new System.Drawing.Point(14, 8);
            this.lblRecentTitle.Name = "lblRecentTitle";
            this.lblRecentTitle.Size = new System.Drawing.Size(1548, 24);
            this.lblRecentTitle.TabIndex = 0;
            this.lblRecentTitle.Text = "Recent Sales Orders";
            this.lblRecentTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uc_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlAlert);
            this.Controls.Add(this.pnlKpis);
            this.Controls.Add(this.pnlTop);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "uc_dashboard";
            this.Size = new System.Drawing.Size(1600, 985);
            this.Load += new System.EventHandler(this.uc_dashboard_Load);
            this.pnlTop.ResumeLayout(false);
            this.cardHeader.ResumeLayout(false);
            this.cardHeader.PerformLayout();
            this.flpActions.ResumeLayout(false);
            this.pnlKpis.ResumeLayout(false);
            this.tblKpis.ResumeLayout(false);
            this.cardRev.ResumeLayout(false);
            this.cardOrd.ResumeLayout(false);
            this.cardProd.ResumeLayout(false);
            this.cardCust.ResumeLayout(false);
            this.pnlAlert.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.tblBody.ResumeLayout(false);
            this.tblMiddle.ResumeLayout(false);
            this.cardChart.ResumeLayout(false);
            this.cardTopProds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTopProds)).EndInit();
            this.cardRecent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRecentSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private MaterialSkin.Controls.MaterialCard cardHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.FlowLayoutPanel flpActions;
        private Krypton.Toolkit.KryptonButton btnQuickSale;
        private Krypton.Toolkit.KryptonButton btnQuickProduct;
        private Krypton.Toolkit.KryptonButton btnQuickCustomer;
        private Krypton.Toolkit.KryptonButton btnQuickReport;
        private Krypton.Toolkit.KryptonButton btnRefresh;
        private System.Windows.Forms.Panel pnlKpis;
        private System.Windows.Forms.TableLayoutPanel tblKpis;
        private MaterialSkin.Controls.MaterialCard cardRev;
        private System.Windows.Forms.Label lblRevTitle;
        private System.Windows.Forms.Label lblRevVal;
        private MaterialSkin.Controls.MaterialCard cardOrd;
        private System.Windows.Forms.Label lblOrdTitle;
        private System.Windows.Forms.Label lblOrdVal;
        private MaterialSkin.Controls.MaterialCard cardProd;
        private System.Windows.Forms.Label lblProdTitle;
        private System.Windows.Forms.Label lblProdVal;
        private MaterialSkin.Controls.MaterialCard cardCust;
        private System.Windows.Forms.Label lblCustTitle;
        private System.Windows.Forms.Label lblCustVal;
        private System.Windows.Forms.Panel pnlAlert;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.TableLayoutPanel tblBody;
        private System.Windows.Forms.TableLayoutPanel tblMiddle;
        private MaterialSkin.Controls.MaterialCard cardChart;
        private System.Windows.Forms.Label lblChartTitle;
        private System.Windows.Forms.Panel pnlChart;
        private MaterialSkin.Controls.MaterialCard cardTopProds;
        private System.Windows.Forms.Label lblTopTitle;
        private System.Windows.Forms.DataGridView dgTopProds;
        private MaterialSkin.Controls.MaterialCard cardRecent;
        private System.Windows.Forms.Label lblRecentTitle;
        private System.Windows.Forms.DataGridView dgRecentSales;
    }
}
