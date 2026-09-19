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
    public partial class uc_user : UserControl
    {

        BindingSource bs_user = new BindingSource();
        userController users = new userController();


        public uc_user()
        {
            InitializeComponent();
             pnl_2.Visible = false;
            txtuserID.Enabled = false;
            cbotype.Items.Add("ADMIN");
            cbotype.Items.Add("USER");
            Program.MyDG(dg_user);
   



        }



        private void btnNew_Click(object sender, EventArgs e)
        {

            pnl_2.Visible = true;
            pnl_1.Enabled = false;
            pnl_3.Visible = false;

            bs_user.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int s = 0;

            if (chkstatus.Checked == true)
            {
                s = 1;
            }
            else
            {
                s = 0;
            }


            if (txtuserID.Text == "")
            {
                int x = 0;
                x = users.InsertUser(txtusername.Text, txtpassword.Text, s, txtfullname.Text, cbotype.Text);

                if (x > 0)
                {
                    MessageBox.Show("Data Inserted");
                    pnl_2.Visible = false;
                    pnl_1.Enabled = true;
                    pnl_3.Visible = true;
                    bs_user.DataSource = users.GetAllUsers();
                }
                else
                {
                    MessageBox.Show("Failed to Insert DATA");
                }
            }
            else
            {

                int x = 0;
                x = users.UpdateUser(Convert.ToInt32(txtuserID.Text), 
                    txtusername.Text, txtpassword.Text, s, 
                    txtfullname.Text, cbotype.Text);

                if (x > 0)
                {
                    MessageBox.Show("Data Updated");
                    pnl_2.Visible = false;
                    pnl_1.Enabled = true;
                    pnl_3.Visible = true;
                    bs_user.DataSource = users.GetAllUsers();
                }
                else
                {
                    MessageBox.Show("Failed to Uopate DATA");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnl_2.Visible = false;
            pnl_1.Enabled = true;
            pnl_3.Visible = true;
            bs_user.CancelEdit();
        }



        private void uc_user_Load(object sender, EventArgs e)
        {
            bs_user.DataSource = users.GetAllUsers();
            dg_user.DataSource = bs_user;


            txtuserID.DataBindings.Add("text", bs_user, "user_id", true);
            txtusername.DataBindings.Add("text", bs_user, "user_name", true);
            txtpassword.DataBindings.Add("text", bs_user, "user_password", true);
            txtfullname.DataBindings.Add("text", bs_user, "full_name", true);
            cbotype.DataBindings.Add("Text", bs_user, "user_type", true);
            chkstatus.DataBindings.Add("checked", bs_user, "user_status", true);





            dg_user.Columns[0].DisplayIndex = dg_user.ColumnCount - 1;
            dg_user.Columns[1].DisplayIndex = dg_user.ColumnCount - 1;
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void dg_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int user_id;
            if (e.ColumnIndex == 1)
            {
                int x = 0;
                user_id =Convert.ToInt32(dg_user.Rows[e.RowIndex].Cells[2].Value);
                //   user_id = int.Parse(dg_user.Rows[e.RowIndex].Cells[2].Value.ToString());
                DialogResult rs;
                rs = MessageBox.Show("Delete ?", "", MessageBoxButtons.YesNo);
                if (rs == DialogResult.No)
                {
                    return;
                }

                x = users.DeleteUser(user_id);

                if (x > 0)
                {
                    MessageBox.Show("Data Deleted");
                    bs_user.DataSource = users.GetAllUsers();
                }
                else
                {
                    MessageBox.Show("Failed to Delete");
                }





           

            }


            if (e.ColumnIndex == 0)
            {
                pnl_2.Visible = true;
                pnl_3.Visible = false;
                pnl_1.Enabled = false;
            }




        }
    }
}
