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

namespace POS_204_oracle
{
    public partial class frm_login : Form
    {
        userController user = new userController();
        DataTable dt_user = new DataTable();

        private Point dragCursorPoint;
        private Point dragFormPoint;
        private bool dragging = false;

        public frm_login()
        {
            InitializeComponent();
            lbl1.Visible = true;
            lbl2.Visible = true;
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void frm_login_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(203, 213, 225), 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
      
         //   btnlogin.PerformClick();
       //    btnlogin_Click(sender, e);
         
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            if (txtusername.TextLength == 0)
            {
                lbl1.Visible = true;
            }
            else
            {
                lbl1.Visible = false;
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            if (this.txtpassword.Text == "")
            {
                lbl2.Visible = true;

            }
            else
            {
                lbl2.Visible = false;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtpassword.Text == "")
            {
                return;
            }
            dt_user = user.CheckLogin(txtusername.Text,txtpassword.Text);

            if (dt_user.Rows.Count > 0)
            {
                Program.UserID =Convert.ToInt32(dt_user.Rows[0]["User_ID"]);
                Program.UserName = dt_user.Rows[0]["User_Name"].ToString();
                Program.UserPassword = dt_user.Rows[0]["user_password"].ToString();
                Program.UserType = dt_user.Rows[0]["user_type"].ToString();
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtusername_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpassword.Focus();
                txtpassword.SelectAll();
            }
        }

        private void txtpassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                txtusername.Focus();
                btnlogin.PerformClick();
            }
        }
    }
}
