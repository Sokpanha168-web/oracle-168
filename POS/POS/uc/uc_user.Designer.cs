namespace POS_204_oracle.uc
{
    partial class uc_user
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
            this.pnl_2 = new System.Windows.Forms.Panel();
            this.pnlInputCard = new System.Windows.Forms.Panel();
            this.lblInputTitle = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtuserID = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cbotype = new System.Windows.Forms.ComboBox();
            this.chkstatus = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnl_3 = new System.Windows.Forms.Panel();
            this.pnlGridCard = new System.Windows.Forms.Panel();
            this.dg_user = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnl_1.SuspendLayout();
            this.pnlHeaderCard.SuspendLayout();
            this.pnl_2.SuspendLayout();
            this.pnlInputCard.SuspendLayout();
            this.pnl_3.SuspendLayout();
            this.pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_user)).BeginInit();
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
            this.pnlHeaderCard.BackColor = System.Drawing.Color.White;
            this.pnlHeaderCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeaderCard.Controls.Add(this.label1);
            this.pnlHeaderCard.Controls.Add(this.btnNew);
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
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "USER MANAGEMENT";
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
            this.btnNew.Image = global::POS_204_oracle.Properties.Resources.icons8_user_24;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(1065, 11);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.btnNew.Size = new System.Drawing.Size(152, 42);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "   New User";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pnl_2
            // 
            this.pnl_2.Controls.Add(this.pnlInputCard);
            this.pnl_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_2.Location = new System.Drawing.Point(0, 89);
            this.pnl_2.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_2.Name = "pnl_2";
            this.pnl_2.Padding = new System.Windows.Forms.Padding(16, 7, 16, 7);
            this.pnl_2.Size = new System.Drawing.Size(1267, 320);
            this.pnl_2.TabIndex = 1;
            // 
            // pnlInputCard
            // 
            this.pnlInputCard.BackColor = System.Drawing.Color.White;
            this.pnlInputCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInputCard.Controls.Add(this.lblInputTitle);
            this.pnlInputCard.Controls.Add(this.lblUserID);
            this.pnlInputCard.Controls.Add(this.txtuserID);
            this.pnlInputCard.Controls.Add(this.lblUserName);
            this.pnlInputCard.Controls.Add(this.txtusername);
            this.pnlInputCard.Controls.Add(this.lblPassword);
            this.pnlInputCard.Controls.Add(this.txtpassword);
            this.pnlInputCard.Controls.Add(this.lblFullName);
            this.pnlInputCard.Controls.Add(this.txtfullname);
            this.pnlInputCard.Controls.Add(this.lblType);
            this.pnlInputCard.Controls.Add(this.cbotype);
            this.pnlInputCard.Controls.Add(this.chkstatus);
            this.pnlInputCard.Controls.Add(this.btnSave);
            this.pnlInputCard.Controls.Add(this.btnClose);
            this.pnlInputCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInputCard.Location = new System.Drawing.Point(16, 7);
            this.pnlInputCard.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInputCard.Name = "pnlInputCard";
            this.pnlInputCard.Size = new System.Drawing.Size(1235, 306);
            this.pnlInputCard.TabIndex = 0;
            // 
            // lblInputTitle
            // 
            this.lblInputTitle.AutoSize = true;
            this.lblInputTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblInputTitle.Location = new System.Drawing.Point(24, 15);
            this.lblInputTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInputTitle.Name = "lblInputTitle";
            this.lblInputTitle.Size = new System.Drawing.Size(165, 25);
            this.lblInputTitle.TabIndex = 12;
            this.lblInputTitle.Text = "User Information";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblUserID.Location = new System.Drawing.Point(27, 59);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(61, 20);
            this.lblUserID.TabIndex = 13;
            this.lblUserID.Text = "User ID";
            // 
            // txtuserID
            // 
            this.txtuserID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtuserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtuserID.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserID.Location = new System.Drawing.Point(27, 84);
            this.txtuserID.Margin = new System.Windows.Forms.Padding(4);
            this.txtuserID.Name = "txtuserID";
            this.txtuserID.ReadOnly = true;
            this.txtuserID.Size = new System.Drawing.Size(266, 29);
            this.txtuserID.TabIndex = 6;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblUserName.Location = new System.Drawing.Point(333, 59);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(80, 20);
            this.lblUserName.TabIndex = 14;
            this.lblUserName.Text = "Username";
            // 
            // txtusername
            // 
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtusername.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(333, 84);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(333, 29);
            this.txtusername.TabIndex = 7;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblPassword.Location = new System.Drawing.Point(707, 59);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 20);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Password";
            // 
            // txtpassword
            // 
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpassword.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(707, 84);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '•';
            this.txtpassword.Size = new System.Drawing.Size(333, 29);
            this.txtpassword.TabIndex = 8;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblFullName.Location = new System.Drawing.Point(27, 135);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(80, 20);
            this.lblFullName.TabIndex = 16;
            this.lblFullName.Text = "Full Name";
            // 
            // txtfullname
            // 
            this.txtfullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfullname.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfullname.Location = new System.Drawing.Point(27, 160);
            this.txtfullname.Margin = new System.Windows.Forms.Padding(4);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(466, 29);
            this.txtfullname.TabIndex = 9;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblType.Location = new System.Drawing.Point(533, 135);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(76, 20);
            this.lblType.TabIndex = 17;
            this.lblType.Text = "User Role";
            // 
            // cbotype
            // 
            this.cbotype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotype.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotype.FormattingEnabled = true;
            this.cbotype.Location = new System.Drawing.Point(533, 160);
            this.cbotype.Margin = new System.Windows.Forms.Padding(4);
            this.cbotype.Name = "cbotype";
            this.cbotype.Size = new System.Drawing.Size(265, 29);
            this.cbotype.TabIndex = 10;
            // 
            // chkstatus
            // 
            this.chkstatus.AutoSize = true;
            this.chkstatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkstatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.chkstatus.Location = new System.Drawing.Point(840, 162);
            this.chkstatus.Margin = new System.Windows.Forms.Padding(4);
            this.chkstatus.Name = "chkstatus";
            this.chkstatus.Size = new System.Drawing.Size(130, 24);
            this.chkstatus.TabIndex = 11;
            this.chkstatus.Text = "Active Account";
            this.chkstatus.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(27, 228);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 44);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save User";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnClose.Location = new System.Drawing.Point(200, 228);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 44);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnl_3
            // 
            this.pnl_3.Controls.Add(this.pnlGridCard);
            this.pnl_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_3.Location = new System.Drawing.Point(0, 409);
            this.pnl_3.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_3.Name = "pnl_3";
            this.pnl_3.Padding = new System.Windows.Forms.Padding(16, 7, 16, 15);
            this.pnl_3.Size = new System.Drawing.Size(1267, 391);
            this.pnl_3.TabIndex = 2;
            // 
            // pnlGridCard
            // 
            this.pnlGridCard.BackColor = System.Drawing.Color.White;
            this.pnlGridCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGridCard.Controls.Add(this.dg_user);
            this.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridCard.Location = new System.Drawing.Point(16, 7);
            this.pnlGridCard.Margin = new System.Windows.Forms.Padding(4);
            this.pnlGridCard.Name = "pnlGridCard";
            this.pnlGridCard.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.pnlGridCard.Size = new System.Drawing.Size(1235, 369);
            this.pnlGridCard.TabIndex = 0;
            // 
            // dg_user
            // 
            this.dg_user.AllowUserToAddRows = false;
            this.dg_user.AllowUserToDeleteRows = false;
            this.dg_user.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dg_user.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_user.BackgroundColor = System.Drawing.Color.White;
            this.dg_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_user.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_user.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_user.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_user.ColumnHeadersHeight = 36;
            this.dg_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_user.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_user.DefaultCellStyle = dataGridViewCellStyle3;
            this.dg_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_user.EnableHeadersVisualStyles = false;
            this.dg_user.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.dg_user.Location = new System.Drawing.Point(11, 10);
            this.dg_user.Margin = new System.Windows.Forms.Padding(4);
            this.dg_user.MultiSelect = false;
            this.dg_user.Name = "dg_user";
            this.dg_user.ReadOnly = true;
            this.dg_user.RowHeadersVisible = false;
            this.dg_user.RowHeadersWidth = 51;
            this.dg_user.RowTemplate.Height = 32;
            this.dg_user.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_user.Size = new System.Drawing.Size(1211, 347);
            this.dg_user.TabIndex = 0;
            this.dg_user.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_user_CellClick);
            this.dg_user.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // uc_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.pnl_3);
            this.Controls.Add(this.pnl_2);
            this.Controls.Add(this.pnl_1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uc_user";
            this.Size = new System.Drawing.Size(1267, 800);
            this.Load += new System.EventHandler(this.uc_user_Load);
            this.pnl_1.ResumeLayout(false);
            this.pnlHeaderCard.ResumeLayout(false);
            this.pnlHeaderCard.PerformLayout();
            this.pnl_2.ResumeLayout(false);
            this.pnlInputCard.ResumeLayout(false);
            this.pnlInputCard.PerformLayout();
            this.pnl_3.ResumeLayout(false);
            this.pnlGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_1;
        private System.Windows.Forms.Panel pnlHeaderCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel pnl_2;
        private System.Windows.Forms.Panel pnlInputCard;
        private System.Windows.Forms.Label lblInputTitle;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtuserID;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbotype;
        private System.Windows.Forms.CheckBox chkstatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnl_3;
        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.DataGridView dg_user;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
    }
}
