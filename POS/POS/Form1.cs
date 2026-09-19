using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_204_oracle.Controller;

namespace POS_204_oracle
{
    public partial class Form1 : Form
    {
        private List<Button> navButtons;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            navButtons = new List<Button>
            {
                btnDashboard,
                btnUser,
                btnCategory,
                btnSuppler,
                btnProduct,
                btnStock,
                btnCustomer,
                btnSale,
                btnReport,
                btnSetting
            };
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            if (lblClock != null)
            {
                lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt  •  ddd, MMM dd yyyy");
            }
        }

        private void SetActiveNavButton(Button activeButton)
        {
            foreach (Button btn in navButtons)
            {
                if (btn == activeButton)
                {
                    btn.BackColor = Color.FromArgb(16, 185, 129); // Emerald active
                    btn.ForeColor = Color.FromArgb(10, 14, 23); // Dark text on bright emerald
                    btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                }
                else
                {
                    btn.BackColor = Color.FromArgb(13, 18, 30);
                    btn.ForeColor = Color.FromArgb(148, 163, 184);
                    btn.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                }
            }
        }

        public void AddPage2Tab(UserControl uc, string txt)
        {
            if (!Program.CanAccessModule(txt))
            {
                MessageBox.Show($"Access Denied: Your account role ({Program.UserType}) does not have permission to access the '{txt}' module.",
                                "Permission Denied",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            foreach (TabPage tp in MainTab.TabPages)
            {
                if (tp.Text == txt)
                {
                    MainTab.SelectedTab = tp;
                    SyncNavButtonWithTab(txt);
                    return;
                }
            }

            TabPage p = new TabPage();
            p.Text = txt;
            p.BackColor = UITheme.BgDark;
            p.ForeColor = UITheme.TextWhite;
            uc.Dock = DockStyle.Fill;
            p.Controls.Add(uc);
            MainTab.TabPages.Add(p);
            MainTab.SelectedTab = p;
            SyncNavButtonWithTab(txt);
        }

        private void SyncNavButtonWithTab(string tabTitle)
        {
            if (lblBreadcrumb != null && !string.IsNullOrEmpty(tabTitle))
            {
                lblBreadcrumb.Text = $"SYSTEM  ›  {tabTitle.ToUpper()}";
            }

            switch (tabTitle?.ToUpper())
            {
                case "DASHBOARD":
                    SetActiveNavButton(btnDashboard);
                    break;
                case "USER":
                    SetActiveNavButton(btnUser);
                    break;
                case "CATEGORY":
                    SetActiveNavButton(btnCategory);
                    break;
                case "SUPPLIER":
                    SetActiveNavButton(btnSuppler);
                    break;
                case "PRODUCT":
                    SetActiveNavButton(btnProduct);
                    break;
                case "STOCK":
                    SetActiveNavButton(btnStock);
                    break;
                case "CUSTOMER":
                    SetActiveNavButton(btnCustomer);
                    break;
                case "SALES":
                    SetActiveNavButton(btnSale);
                    break;
                case "REPORTS":
                    SetActiveNavButton(btnReport);
                    break;
                case "SETTINGS":
                    SetActiveNavButton(btnSetting);
                    break;
                default:
                    SetActiveNavButton(null);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string displayName = string.IsNullOrEmpty(Program.UserName) ? "Administrator" : Program.UserName;
            string displayRole = string.IsNullOrEmpty(Program.UserType) ? "Admin" : Program.UserType;
            lbluser.Text = $"{displayName} ({displayRole})";

            // Initialize clock text immediately
            timerClock_Tick(this, EventArgs.Empty);

            // Setup company branding
            SettingController.OnSettingsChanged += LoadCompanyBranding;
            SettingController settingCtrl = new SettingController();
            settingCtrl.LoadSettings();
            LoadCompanyBranding();

            // Apply role-based permissions
            ApplyPermissions();

            // Open DASHBOARD tab by default on load
            btnDashboard_Click(sender, e);
        }

        private void ApplyPermissions()
        {
            if (!Program.IsAdmin)
            {
                // Standard users can only access Dashboard, Sale, and Customer
                btnUser.Visible = false;
                btnCategory.Visible = false;
                btnSuppler.Visible = false;
                btnProduct.Visible = false;
                btnStock.Visible = false;
                btnReport.Visible = false;
                btnSetting.Visible = false;
                if (lblNavInventory != null) lblNavInventory.Visible = false;
                if (lblNavSystem != null) lblNavSystem.Visible = false;

                btnDashboard.Visible = true;
                btnCustomer.Visible = true;
                btnSale.Visible = true;
                if (lblNavSales != null) lblNavSales.Visible = true;
                btnExit.Visible = true;

                navButtons.RemoveAll(b => !b.Visible);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AddPage2Tab(new uc.uc_dashboard(), "DASHBOARD");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AddPage2Tab(new uc.uc_user(), "USER");
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            AddPage2Tab(new uc.ucCategory(), "CATEGORY");
        }

        private void btnSuppler_Click(object sender, EventArgs e)
        {
            AddPage2Tab(new uc.ucSupplier(), "SUPPLIER");
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            AddPage2Tab(new uc.uc_product(), "PRODUCT");
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            AddPage2Tab(new uc.uc_stock(), "STOCK");
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            AddPage2Tab(new uc.uc_customer(), "CUSTOMER");
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            AddPage2Tab(new uc.uc_sale(), "SALES");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            AddPage2Tab(new uc.uc_report(), "REPORTS");
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            AddPage2Tab(new uc.uc_setting(), "SETTINGS");
        }

        public void LoadCompanyBranding()
        {
            try
            {
                var s = SettingController.Current;
                if (s != null)
                {
                    if (!string.IsNullOrEmpty(s.CompanyName))
                    {
                        lblAppTitle.Text = s.CompanyName;
                    }

                    var logoImg = s.GetLogoImage();
                    if (logoImg != null)
                    {
                        picBrandLogo.Image = logoImg;
                        picBrandLogo.Visible = true;
                        lblBrandBadge.Visible = false;
                    }
                    else
                    {
                        picBrandLogo.Visible = false;
                        lblBrandBadge.Visible = true;
                    }
                }
            }
            catch { }
        }

        private bool isLoggingOut = false;

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are you sure you want to sign out?", "Confirm Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                isLoggingOut = true;
                Program.UserID = 0;
                Program.UserName = null;
                Program.UserType = null;
                Program.UserPassword = null;
                this.Close();
                frm_login login = new frm_login();
                login.Show();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (!isLoggingOut)
            {
                Application.Exit();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are you sure you want to exit the system?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MainTab_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= MainTab.TabPages.Count) return;

            TabPage page = MainTab.TabPages[e.Index];
            Rectangle rect = MainTab.GetTabRect(e.Index);
            bool isSelected = (MainTab.SelectedIndex == e.Index);

            // Tab background fill
            Color bgColor = isSelected ? UITheme.CardBg : UITheme.BgSidebar;
            using (SolidBrush bgBrush = new SolidBrush(bgColor))
            {
                e.Graphics.FillRectangle(bgBrush, rect);
            }

            // Top active accent line for selected tab
            if (isSelected)
            {
                using (SolidBrush accentBrush = new SolidBrush(UITheme.Primary))
                {
                    e.Graphics.FillRectangle(accentBrush, rect.X, rect.Y, rect.Width, 3);
                }
            }

            // Draw tab title
            string title = page.Text;
            using (Font tabFont = new Font("Segoe UI", 9F, isSelected ? FontStyle.Bold : FontStyle.Regular))
            {
                Color textColor = isSelected ? UITheme.TextWhite : UITheme.TextDim;
                Rectangle textRect = new Rectangle(rect.X + 10, rect.Y, rect.Width - 32, rect.Height);
                TextRenderer.DrawText(e.Graphics, title, tabFont, textRect, textColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }

            // Draw close '×' button
            Rectangle closeRect = new Rectangle(rect.Right - 22, rect.Top + (rect.Height - 16) / 2, 16, 16);
            using (Font closeFont = new Font("Segoe UI", 9F, FontStyle.Bold))
            {
                Color closeColor = isSelected ? UITheme.PrimaryHover : UITheme.TextDim;
                TextRenderer.DrawText(e.Graphics, "×", closeFont, closeRect, closeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }

        private void MainTab_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < MainTab.TabPages.Count; i++)
            {
                Rectangle r = MainTab.GetTabRect(i);
                Rectangle closeBtnRect = new Rectangle(r.Right - 22, r.Top + (r.Height - 16) / 2, 16, 16);
                if (closeBtnRect.Contains(e.Location))
                {
                    MainTab.TabPages.RemoveAt(i);
                    if (MainTab.TabPages.Count > 0)
                    {
                        SyncNavButtonWithTab(MainTab.SelectedTab.Text);
                    }
                    else
                    {
                        SetActiveNavButton(null);
                    }
                    break;
                }
            }
        }

        private void MainTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainTab.SelectedTab != null)
            {
                SyncNavButtonWithTab(MainTab.SelectedTab.Text);
            }
            else
            {
                SetActiveNavButton(null);
            }
        }

        private void picUserAvatar_Click(object sender, EventArgs e)
        {

        }
    }
}
