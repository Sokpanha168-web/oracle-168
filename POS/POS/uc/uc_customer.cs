using POS_204_oracle.Controller;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace POS_204_oracle.uc
{
    public partial class uc_customer : UserControl
    {
        private BindingSource bs = new BindingSource();
        private CustomerController customer = new CustomerController();

        public uc_customer()
        {
            InitializeComponent();
            pnl_2.Visible = false;
            Program.MyDG(dg_customer);
            txtcustomerid.Enabled = false;
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

        private void uc_customer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            bs.DataSource = customer.GetAll();
            dg_customer.DataSource = bs;

            txtcustomerid.DataBindings.Clear();
            txtcustomername.DataBindings.Clear();
            txtcustomerphone.DataBindings.Clear();
            txtcustomeremail.DataBindings.Clear();
            txtcustomeraddress.DataBindings.Clear();
            txtcustomernotes.DataBindings.Clear();
            txtid.DataBindings.Clear();

            txtcustomerid.DataBindings.Add("Text", bs, "customer_id", true);
            txtcustomername.DataBindings.Add("Text", bs, "customer_name", true);
            
            // Safe binding for optional columns
            DataTable dt = bs.DataSource as DataTable;
            if (dt != null)
            {
                if (dt.Columns.Contains("customer_phone"))
                    txtcustomerphone.DataBindings.Add("Text", bs, "customer_phone", true);
                if (dt.Columns.Contains("customer_email"))
                    txtcustomeremail.DataBindings.Add("Text", bs, "customer_email", true);
                if (dt.Columns.Contains("customer_address"))
                    txtcustomeraddress.DataBindings.Add("Text", bs, "customer_address", true);
                if (dt.Columns.Contains("customer_notes"))
                    txtcustomernotes.DataBindings.Add("Text", bs, "customer_notes", true);
            }

            txtid.DataBindings.Add("Text", bs, "customer_id", true);

            // Set column headers nicely if they exist
            if (dg_customer.Columns.Contains("customer_id"))
                dg_customer.Columns["customer_id"].HeaderText = "ID";
            if (dg_customer.Columns.Contains("customer_name"))
                dg_customer.Columns["customer_name"].HeaderText = "Customer Name";
            if (dg_customer.Columns.Contains("customer_phone"))
                dg_customer.Columns["customer_phone"].HeaderText = "Phone";
            if (dg_customer.Columns.Contains("customer_email"))
                dg_customer.Columns["customer_email"].HeaderText = "Email";
            if (dg_customer.Columns.Contains("customer_address"))
                dg_customer.Columns["customer_address"].HeaderText = "Address";
            if (dg_customer.Columns.Contains("customer_notes"))
                dg_customer.Columns["customer_notes"].HeaderText = "Notes";

            if (dg_customer.Columns.Count >= 2)
            {
                dg_customer.Columns[0].DisplayIndex = dg_customer.ColumnCount - 1;
                dg_customer.Columns[1].DisplayIndex = dg_customer.ColumnCount - 1;
            }

            Program.full_dg(dg_customer);
            UpdateSelectedCustomerStats();
        }

        private void UpdateSelectedCustomerStats()
        {
            if (int.TryParse(txtcustomerid.Text, out int customerId) && customerId > 0)
            {
                CustomerStats stats = customer.GetCustomerStats(customerId);
                string lastDate = stats.LastOrderDate.HasValue ? stats.LastOrderDate.Value.ToString("yyyy-MM-dd") : "None";
                lblStats.Text = $"📊 Total Orders: {stats.TotalOrders}   |   Total Spent: ${stats.TotalSpent:N2}   |   Last Order: {lastDate}";
            }
            else
            {
                lblStats.Text = "📊 Total Orders: 0   |   Total Spent: $0.00   |   Last Order: None";
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bs.AddNew();
            EnableBTN(true);
            txtcustomername.Focus();
            lblStats.Text = "✨ Creating new customer record...";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            bs.CancelEdit();
            EnableBTN(false);
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtsearch.Text = "";
            LoadData();
            Program.MySN(this, "Customer list refreshed", Color.Teal);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtcustomername.Text.Trim();
            string phone = txtcustomerphone.Text.Trim();
            string email = txtcustomeremail.Text.Trim();
            string address = txtcustomeraddress.Text.Trim();
            string notes = txtcustomernotes.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                Program.MySN(this, "Customer name is required!", Color.Orange);
                txtcustomername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtcustomerid.Text))
            {
                int x = customer.Insert(name, phone, email, address, notes);
                if (x > 0)
                {
                    Program.MySN(this, "Customer Inserted Successfully", Color.Green);
                    EnableBTN(false);
                    LoadData();
                }
                else
                {
                    Program.MySN(this, "Failed to Insert Customer", Color.Red);
                }
            }
            else
            {
                int customerId = Convert.ToInt32(txtcustomerid.Text);
                int x = customer.Update(customerId, name, phone, email, address, notes);
                if (x > 0)
                {
                    Program.MySN(this, "Customer Updated Successfully", Color.Green);
                    EnableBTN(false);
                    LoadData();
                }
                else
                {
                    Program.MySN(this, "Failed to Update Customer", Color.Red);
                }
            }
        }

        private void dg_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Column 0 is Edit icon
            if (e.ColumnIndex == 0)
            {
                EnableBTN(true);
                txtcustomername.Focus();
            }
            // Column 1 is Delete icon
            else if (e.ColumnIndex == 1)
            {
                if (string.IsNullOrEmpty(txtid.Text))
                {
                    Program.MySN(this, "Select a customer to delete", Color.Orange);
                    return;
                }

                DialogResult rs = MessageBox.Show(
                    $"Are you sure you want to delete customer '{txtcustomername.Text}'?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (rs == DialogResult.Yes)
                {
                    int customerId = Convert.ToInt32(txtid.Text);
                    int x = customer.Delete(customerId);
                    if (x > 0)
                    {
                        Program.MySN(this, "Customer Deleted", Color.Green);
                        LoadData();
                    }
                    else
                    {
                        Program.MySN(this, "Cannot delete customer (in use in sales orders or error)", Color.Red);
                    }
                }
            }
        }

        private void dg_customer_SelectionChanged(object sender, EventArgs e)
        {
            UpdateSelectedCustomerStats();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsearch.Text))
            {
                bs.DataSource = customer.GetAll();
            }
            else
            {
                bs.DataSource = customer.Search(txtsearch.Text.Trim());
            }
            UpdateSelectedCustomerStats();
        }
    }
}
