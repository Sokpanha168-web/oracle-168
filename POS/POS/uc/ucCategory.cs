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
    public partial class ucCategory : UserControl
    {
        BindingSource bs = new BindingSource();
        CategoryController category = new CategoryController();

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

        public ucCategory()
        {
            InitializeComponent();
            pnl_2.Visible = false;
            Program.MyDG(dg_category);
            txtcateid.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bs.AddNew();
            EnableBTN(true);
            chkstatus.Checked = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            EnableBTN(false);
            bs.CancelEdit();
        }

        private void ucCategory_Load(object sender, EventArgs e)
        {
            bs.DataSource = category.GetAll();
            dg_category.DataSource = bs;
            txtcateid.DataBindings.Add("text", bs, "category_id", true);
            txtcatename.DataBindings.Add("text", bs, "category_name", true);
            txtcatenote.DataBindings.Add("text", bs, "category_notes", true);
            chkstatus.DataBindings.Add("checked", bs, "category_status", true);
            txtid.DataBindings.Add("text", bs, "category_id", true);
            dg_category.Columns[0].DisplayIndex = dg_category.ColumnCount - 1;
            dg_category.Columns[1].DisplayIndex = dg_category.ColumnCount - 1;

            Program.full_dg(dg_category);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtcateid.Text == "")
            {
                int x = 0;
                x = category.Insert(
                    txtcatename.Text, Convert.ToInt32(chkstatus.Checked), txtcatenote.Text
                );
                if (x > 0)
                {
                    Program.MySN(this, "Data Inserted", Color.Green);
                    bs.CancelEdit();
                    EnableBTN(false);
                    bs.DataSource = category.GetAll();
                }
                else
                {
                    Program.MySN(this, "Error Insert", Color.Red);
                }
            }
            else
            {
                int x = 0;
                x = category.Update(
                    Convert.ToInt32(txtcateid.Text),
                    txtcatename.Text, Convert.ToInt32(chkstatus.Checked), txtcatenote.Text
                );
                if (x > 0)
                {
                    Program.MySN(this, "Data Updated", Color.Green);
                    bs.CancelEdit();
                    EnableBTN(false);
                    bs.DataSource = category.GetAll();
                }
                else
                {
                    Program.MySN(this, "Error Update", Color.Red);
                }
            }
        }

        private void dg_category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult rs; 
            if (e.ColumnIndex == 0)
            {
                EnableBTN(true);
            }

            if (e.ColumnIndex == 1)
            {
                if (txtid.Text == "")
                {
                    Program.MySN(this, "Select item to delete first", Color.Orange);
                    return;
                }

                rs = MessageBox.Show("Delete this category?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.No)
                {
                    return;
                }
                int x = 0;
                x = category.Delete(Convert.ToInt32(txtid.Text));
                if (x > 0)
                {
                    Program.MySN(this, "Data Deleted", Color.Green);
                    bs.DataSource = category.GetAll();
                }
                else
                {
                    Program.MySN(this, "Failed to Delete", Color.Red);
                }
            }
        }

        private void dg_category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
