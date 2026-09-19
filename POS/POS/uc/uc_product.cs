using POS_204_oracle.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_204_oracle.uc
{
    public partial class uc_product : UserControl
    {
        BindingSource bs_product = new BindingSource();
        ProductController product = new ProductController();

        BindingSource bs_category = new BindingSource();
        CategoryController category = new CategoryController();

        BindingSource bs_suppler = new BindingSource();
        SupplierController supplier = new SupplierController();

        private byte[] currentPhotoBytes = null;
        private bool photoChanged = false;

        public uc_product()
        {
            InitializeComponent();
            pnl_2.Visible = false;
            Program.MyDG(dg_product);
            txtproid.Enabled = false;
        }

        public void EnableBTN(bool b)
        {
            if (b)
            {
                pnl_1.Enabled = false;
                pnl_2.Visible = true;
                pnl_3.Visible = false;
            }
            else
            {
                pnl_1.Enabled = true;
                pnl_2.Visible = false;
                pnl_3.Visible = true;
            }
        }

        private void uc_product_Load(object sender, EventArgs e)
        {
            try
            {
                bs_product.DataSource = product.GetAll();
                bs_category.DataSource = category.GetAll();
                bs_suppler.DataSource = supplier.GetAll();
                dg_product.DataSource = bs_product;

                txtproid.DataBindings.Add("text", bs_product, "product_id", true);
                txtproname.DataBindings.Add("text", bs_product, "product_name", true);

                cbocategoryid.DataSource = bs_category;
                cbocategoryid.DisplayMember = "category_name";
                cbocategoryid.ValueMember = "category_id";

                cbosupplierid.DataSource = bs_suppler;
                cbosupplierid.DisplayMember = "supplier_name";
                cbosupplierid.ValueMember = "supplier_id";

                cbocategoryid.DataBindings.Add("selectedvalue", bs_product, "category_id", true);
                cbosupplierid.DataBindings.Add("selectedvalue", bs_product, "supplier_id", true);

                txtprice.DataBindings.Add("value", bs_product, "product_price", true);
                txtcost.DataBindings.Add("value", bs_product, "product_cost", true);
                chkstatus.DataBindings.Add("checked", bs_product, "product_status", true);
                chkstock.DataBindings.Add("checked", bs_product, "is_stock", true);

                Program.full_dg(dg_product);

                // Reorder action columns to the end
                if (dg_product.Columns.Count > 2)
                {
                    dg_product.Columns[0].DisplayIndex = dg_product.Columns.Count - 1;
                    dg_product.Columns[1].DisplayIndex = dg_product.Columns.Count - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bs_product.AddNew();
            EnableBTN(true);
            chkstatus.Checked = true;
            chkstock.Checked = true;
            txtcost.Value = 0;
            txtprice.Value = 0;
            txtproname.Focus();

            picProduct.Image = null;
            currentPhotoBytes = null;
            photoChanged = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            bs_product.CancelEdit();
            EnableBTN(false);
            picProduct.Image = null;
            currentPhotoBytes = null;
            photoChanged = false;
        }

        private void btnBrowsePhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Product Photo";
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp;*.webp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.webp;*.gif|All files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        byte[] bytes = File.ReadAllBytes(ofd.FileName);
                        using (MemoryStream ms = new MemoryStream(bytes))
                        {
                            picProduct.Image = new Bitmap(Image.FromStream(ms));
                        }
                        currentPhotoBytes = bytes;
                        photoChanged = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not load image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnClearPhoto_Click(object sender, EventArgs e)
        {
            picProduct.Image = null;
            currentPhotoBytes = null;
            photoChanged = true;
        }

        private void LoadProductPhoto(int proId)
        {
            try
            {
                byte[] bytes = product.GetProductPhotoBytes(proId);
                if (bytes != null && bytes.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(bytes))
                    {
                        picProduct.Image = new Bitmap(Image.FromStream(ms));
                    }
                    currentPhotoBytes = bytes;
                }
                else
                {
                    picProduct.Image = null;
                    currentPhotoBytes = null;
                }
                photoChanged = false;
            }
            catch
            {
                picProduct.Image = null;
                currentPhotoBytes = null;
                photoChanged = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtproname.Text))
            {
                Program.MySN(this, "Please enter a product name.", Color.OrangeRed);
                txtproname.Focus();
                return;
            }

            if (cbocategoryid.SelectedValue == null)
            {
                Program.MySN(this, "Please select a category.", Color.OrangeRed);
                cbocategoryid.Focus();
                return;
            }

            if (cbosupplierid.SelectedValue == null)
            {
                Program.MySN(this, "Please select a supplier.", Color.OrangeRed);
                cbosupplierid.Focus();
                return;
            }

            int catId = Convert.ToInt32(cbocategoryid.SelectedValue);
            int supId = Convert.ToInt32(cbosupplierid.SelectedValue);
            int isStock = chkstock.Checked ? 1 : 0;
            int status = chkstatus.Checked ? 1 : 0;
            decimal cost = txtcost.Value;
            decimal price = txtprice.Value;

            if (string.IsNullOrWhiteSpace(txtproid.Text))
            {
                int res = product.Insert(txtproname.Text.Trim(), catId, supId, Program.UserID, isStock, cost, price, status, currentPhotoBytes);
                if (res > 0)
                {
                    Program.MySN(this, "Product Added Successfully", Color.Green);
                    bs_product.CancelEdit();
                    EnableBTN(false);
                    bs_product.DataSource = product.GetAll();
                    picProduct.Image = null;
                    currentPhotoBytes = null;
                    photoChanged = false;
                }
                else
                {
                    Program.MySN(this, "Error Adding Product", Color.Red);
                }
            }
            else
            {
                int proId = Convert.ToInt32(txtproid.Text);
                int res = product.Update(proId, txtproname.Text.Trim(), catId, supId, isStock, cost, price, status, currentPhotoBytes, photoChanged);
                if (res > 0)
                {
                    Program.MySN(this, "Product Updated Successfully", Color.Green);
                    bs_product.CancelEdit();
                    EnableBTN(false);
                    bs_product.DataSource = product.GetAll();
                    picProduct.Image = null;
                    currentPhotoBytes = null;
                    photoChanged = false;
                }
                else
                {
                    Program.MySN(this, "Error Updating Product", Color.Red);
                }
            }
        }

        private void dg_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 0)
            {
                EnableBTN(true);
                if (int.TryParse(txtproid.Text, out int proId))
                {
                    LoadProductPhoto(proId);
                }
            }
            else if (e.ColumnIndex == 1)
            {
                if (e.RowIndex < 0 || e.RowIndex >= dg_product.Rows.Count) return;

                int proId = 0;
                string proName = "this product";

                var row = dg_product.Rows[e.RowIndex];
                if (row.Cells["product_id"] != null && row.Cells["product_id"].Value != null)
                {
                    int.TryParse(row.Cells["product_id"].Value.ToString(), out proId);
                }
                else if (row.Cells["PRODUCT_ID"] != null && row.Cells["PRODUCT_ID"].Value != null)
                {
                    int.TryParse(row.Cells["PRODUCT_ID"].Value.ToString(), out proId);
                }
                else if (int.TryParse(txtproid.Text, out int pid))
                {
                    proId = pid;
                }

                if (row.Cells["product_name"] != null && row.Cells["product_name"].Value != null)
                {
                    proName = row.Cells["product_name"].Value.ToString();
                }
                else if (row.Cells["PRODUCT_NAME"] != null && row.Cells["PRODUCT_NAME"].Value != null)
                {
                    proName = row.Cells["PRODUCT_NAME"].Value.ToString();
                }

                if (proId <= 0) return;

                product.GetTransactionCount(proId, out int salesCount, out int stockCount);

                if (salesCount > 0 || stockCount > 0)
                {
                    string msg = $"Product '{proName}' (ID: {proId}) has transaction history:\n" +
                                 $"• {salesCount} sale records\n" +
                                 $"• {stockCount} stock log records\n\n" +
                                 "Because sales receipts depend on this product, standard deletion is blocked to protect data.\n\n" +
                                 "Choose an option:\n" +
                                 "• [Yes]  = ARCHIVE / DEACTIVATE (Recommended - hides from POS Sales, preserves history)\n" +
                                 "• [No]   = FORCE PERMANENT DELETE (Deletes product and clears test records)\n" +
                                 "• [Cancel] = Do nothing";

                    DialogResult rs = MessageBox.Show(msg, "Product Has Transactions - Confirm Action", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (rs == DialogResult.Yes)
                    {
                        int res = product.Deactivate(proId);
                        if (res > 0)
                        {
                            Program.MySN(this, $"Product '{proName}' Archived/Deactivated", Color.Green);
                            bs_product.DataSource = product.GetAll();
                        }
                        else
                        {
                            Program.MySN(this, "Error Archiving Product", Color.Red);
                        }
                    }
                    else if (rs == DialogResult.No)
                    {
                        var confirmForce = MessageBox.Show(
                            $"WARNING: Are you sure you want to FORCE DELETE '{proName}'?\n\nThis will permanently delete the product along with its {salesCount} sale records and {stockCount} stock transactions!",
                            "Confirm Force Delete",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Stop
                        );

                        if (confirmForce == DialogResult.Yes)
                        {
                            int res = product.ForceDelete(proId);
                            if (res > 0)
                            {
                                Program.MySN(this, $"Product '{proName}' Permanently Deleted", Color.Green);
                                bs_product.DataSource = product.GetAll();
                            }
                            else
                            {
                                Program.MySN(this, "Error Deleting Product", Color.Red);
                            }
                        }
                    }
                }
                else
                {
                    DialogResult rs = MessageBox.Show($"Are you sure you want to delete product '{proName}' (ID: {proId})?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        int res = product.Delete(proId);
                        if (res > 0)
                        {
                            Program.MySN(this, "Product Deleted Successfully", Color.Green);
                            bs_product.DataSource = product.GetAll();
                        }
                        else
                        {
                            Program.MySN(this, "Error Deleting Product", Color.Red);
                        }
                    }
                }
            }
        }

        private void dg_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
