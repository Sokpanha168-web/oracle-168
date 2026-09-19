using POS_204_oracle.Controller;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace POS_204_oracle.uc
{
    public partial class uc_setting : UserControl
    {
        private SettingController settingCtrl = new SettingController();
        private byte[] currentLogoBytes = null;
        private bool logoChanged = false;

        public uc_setting()
        {
            InitializeComponent();
        }

        private void uc_setting_Load(object sender, EventArgs e)
        {
            LoadCurrentSettings();
        }

        private void LoadCurrentSettings()
        {
            try
            {
                CompanySettings s = settingCtrl.LoadSettings();

                txtName.Text = s.CompanyName;
                txtSlogan.Text = s.CompanySlogan;
                txtPhone.Text = s.CompanyPhone;
                txtEmail.Text = s.CompanyEmail;
                txtAddress.Text = s.CompanyAddress;
                txtReceiptFooter.Text = s.ReceiptFooter;

                if (s.ExchangeRate >= nudExchangeRate.Minimum && s.ExchangeRate <= nudExchangeRate.Maximum)
                {
                    nudExchangeRate.Value = s.ExchangeRate;
                }

                currentLogoBytes = s.LogoBytes;
                logoChanged = false;

                DisplayLogo();
                UpdateLiveBannerPreview();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading settings: " + ex.Message, "Settings Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayLogo()
        {
            if (currentLogoBytes != null && currentLogoBytes.Length > 0)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(currentLogoBytes))
                    {
                        Image img = Image.FromStream(ms);
                        picLogoPreview.Image = new Bitmap(img);
                        picPreviewLogo.Image = new Bitmap(img);
                        picPreviewLogo.Visible = true;
                    }
                }
                catch
                {
                    picLogoPreview.Image = null;
                    picPreviewLogo.Image = null;
                }
            }
            else
            {
                picLogoPreview.Image = null;
                picPreviewLogo.Image = null;
            }
        }

        private void UpdateLiveBannerPreview()
        {
            lblPreviewBrandName.Text = string.IsNullOrWhiteSpace(txtName.Text) ? "POINT OF SALE PRO SYSTEM" : txtName.Text.Trim();
            lblPreviewBrandSlogan.Text = string.IsNullOrWhiteSpace(txtSlogan.Text) ? "Quality Products & Best Service" : txtSlogan.Text.Trim();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            UpdateLiveBannerPreview();
        }

        private void txtSlogan_TextChanged(object sender, EventArgs e)
        {
            UpdateLiveBannerPreview();
        }

        private void btnBrowseLogo_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "Select Company Logo";
                    ofd.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.bmp;*.webp;*.ico)|*.png;*.jpg;*.jpeg;*.bmp;*.webp;*.ico|All Files (*.*)|*.*";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        FileInfo fi = new FileInfo(ofd.FileName);
                        if (fi.Length > 5 * 1024 * 1024)
                        {
                            MessageBox.Show("Selected image is larger than 5 MB. Please choose a smaller logo file.", "Image Too Large", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        currentLogoBytes = File.ReadAllBytes(ofd.FileName);
                        logoChanged = true;
                        DisplayLogo();
                        lblSaveStatus.Text = "Logo selected (Unsaved changes)";
                        lblSaveStatus.ForeColor = Color.FromArgb(217, 119, 6);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearLogo_Click(object sender, EventArgs e)
        {
            currentLogoBytes = null;
            logoChanged = true;
            DisplayLogo();
            lblSaveStatus.Text = "Logo removed (Unsaved changes)";
            lblSaveStatus.ForeColor = Color.FromArgb(217, 119, 6);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string companyName = txtName.Text.Trim();
                if (string.IsNullOrWhiteSpace(companyName))
                {
                    MessageBox.Show("Company Name cannot be empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus();
                    return;
                }

                CompanySettings s = new CompanySettings
                {
                    CompanyName = companyName,
                    CompanySlogan = txtSlogan.Text.Trim(),
                    CompanyPhone = txtPhone.Text.Trim(),
                    CompanyEmail = txtEmail.Text.Trim(),
                    CompanyAddress = txtAddress.Text.Trim(),
                    ReceiptFooter = txtReceiptFooter.Text.Trim(),
                    ExchangeRate = nudExchangeRate.Value,
                    LogoBytes = currentLogoBytes
                };

                string error;
                bool ok = settingCtrl.SaveSettings(s, currentLogoBytes, logoChanged, out error);

                if (ok)
                {
                    logoChanged = false;
                    lblSaveStatus.Text = "✓ Settings & company branding saved successfully!";
                    lblSaveStatus.ForeColor = Color.FromArgb(16, 185, 129);
                    MessageBox.Show("Company settings, logo, and receipt branding updated successfully!\nThe main header and receipts will now use your new branding.", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to save settings: " + error, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error saving settings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(
                "Are you sure you want to reset all company settings to default values?",
                "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                txtName.Text = "POINT OF SALE PRO SYSTEM";
                txtSlogan.Text = "Quality Products & Best Service";
                txtPhone.Text = "+855 (0) 12 345 678";
                txtEmail.Text = "info@possystem.com";
                txtAddress.Text = "Phnom Penh, Cambodia";
                txtReceiptFooter.Text = "THANK YOU FOR YOUR PURCHASE! Please come again!";
                nudExchangeRate.Value = 4100;
                currentLogoBytes = null;
                logoChanged = true;
                DisplayLogo();
                UpdateLiveBannerPreview();
                lblSaveStatus.Text = "Defaults restored (Click Save to apply)";
                lblSaveStatus.ForeColor = Color.FromArgb(217, 119, 6);
            }
        }
    }
}
