using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using POS_204_oracle.Controller;

namespace POS_204_oracle.uc
{
    public partial class ucSupplier : UserControl
    {
        SupplierController suppler = new SupplierController();
        BindingSource bs_suppler = new BindingSource();

        public ucSupplier()
        {
            InitializeComponent();
            pnl_2.Visible = false;
            Program.MyDG(dg_supplier);
            txtsupplierid.Enabled = false;
        }

        public void EnableBTN(bool b)
        {
            if (b == true)
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

        private void ucSupplier_Load(object sender, EventArgs e)
        {
            bs_suppler.DataSource = suppler.GetAll();
            dg_supplier.DataSource = bs_suppler;

            txtsupplierid.DataBindings.Add("text", bs_suppler, "supplier_id", true);
            txtsupplername.DataBindings.Add("text", bs_suppler, "supplier_name", true);
            txtsuppliercontact.DataBindings.Add("text", bs_suppler, "supplier_contact", true);
            txtsupplernotes.DataBindings.Add("text", bs_suppler, "supplier_notes", true);

            dg_supplier.Columns[0].DisplayIndex = dg_supplier.ColumnCount - 1;
            dg_supplier.Columns[1].DisplayIndex = dg_supplier.ColumnCount - 1;

            Program.full_dg(dg_supplier);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bs_suppler.AddNew();
            EnableBTN(true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            EnableBTN(false);
            bs_suppler.CancelEdit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtsupplierid.Text == "")
            {
                int x = suppler.Insert(txtsupplername.Text, txtsuppliercontact.Text, txtsupplernotes.Text);
                if (x > 0)
                {
                    Program.MySN(this, "Supplier Added Successfully", Color.Green);
                    bs_suppler.CancelEdit();
                    EnableBTN(false);
                    bs_suppler.DataSource = suppler.GetAll();
                }
                else
                {
                    Program.MySN(this, "Error Adding Supplier", Color.Red);
                }
            }
            else
            {
                int x = suppler.Update(Convert.ToInt32(txtsupplierid.Text), txtsupplername.Text, txtsuppliercontact.Text, txtsupplernotes.Text);
                if (x > 0)
                {
                    Program.MySN(this, "Supplier Updated Successfully", Color.Green);
                    bs_suppler.CancelEdit();
                    EnableBTN(false);
                    bs_suppler.DataSource = suppler.GetAll();
                }
                else
                {
                    Program.MySN(this, "Error Updating Supplier", Color.Red);
                }
            }
        }

        private void dg_supplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                EnableBTN(true);
            }
            if (e.ColumnIndex == 1)
            {
                if (txtsupplierid.Text == "") return;
                DialogResult rs = MessageBox.Show("Delete this supplier?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    int x = suppler.Delete(Convert.ToInt32(txtsupplierid.Text));
                    if (x > 0)
                    {
                        Program.MySN(this, "Supplier Deleted", Color.Green);
                        bs_suppler.DataSource = suppler.GetAll();
                    }
                }
            }
        }
    }
}
