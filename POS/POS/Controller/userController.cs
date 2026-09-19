using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace POS_204_oracle.Controller
{
    internal class userController
    {
        OracleCommand cmd_user = new OracleCommand();
        OracleDataAdapter da_user = new OracleDataAdapter();
        DataTable dt_user = new DataTable();

        public DataTable CheckLogin(String user_name,String user_password ) {
            dt_user = new DataTable();
            cmd_user = new OracleCommand();
            da_user = new OracleDataAdapter();

            cmd_user.Connection = Program.con;
            cmd_user.CommandType = CommandType.Text;
            cmd_user.CommandText = "select * from tbl_user " +
                "where upper(user_name)=:user_name and " +
                "user_password=:user_password and user_status=1";
            cmd_user.Parameters.Add(new OracleParameter("user_name", user_name.ToUpper()));
            cmd_user.Parameters.Add(new OracleParameter("user_password", user_password));
            da_user.SelectCommand = cmd_user;
            da_user.Fill(dt_user);





            return  dt_user;
        }


        public DataTable GetAllUsers() {
            dt_user = new DataTable();
            cmd_user = new OracleCommand();
            

            cmd_user.Connection = Program.con;
            cmd_user.CommandType = CommandType.Text;
            cmd_user.CommandText = "select * from tbl_user";
            da_user.SelectCommand = cmd_user;
            da_user.Fill(dt_user);
            return dt_user;
        }

        public int InsertUser(String user_name, String user_password, int user_status, String full_name, String user_type)
        {
            int x = 0;
            cmd_user = new OracleCommand();
            try
            {
                cmd_user.Connection = Program.con;
                cmd_user.CommandType = CommandType.Text;
                cmd_user.CommandText = "insert into tbl_user(user_name,user_password,user_status,full_name,user_type) " +
                    "values (:user_name,:user_password,:user_status,:full_name,:user_type )";
                cmd_user.Parameters.Add(new OracleParameter("user_name", user_name));
                cmd_user.Parameters.Add(new OracleParameter("user_password", user_password));
                cmd_user.Parameters.Add(new OracleParameter("user_status", user_status));
                cmd_user.Parameters.Add(new OracleParameter("full_name", full_name));
                cmd_user.Parameters.Add(new OracleParameter("user_type", user_type));

                x = cmd_user.ExecuteNonQuery();
            }
            catch (Exception)
            {

                x = -1;
            }
            return x;
        }
        public int DeleteUser(int user_id) {
            int s = 0;
            try
            {
                cmd_user.Connection = Program.con;
                cmd_user.CommandType = CommandType.Text;
                cmd_user.CommandText = "Delete From tbl_user where user_id=:user_id";
                cmd_user.Parameters.Add(new OracleParameter("user_id", user_id));
                s = cmd_user.ExecuteNonQuery();
            }
            catch (Exception)
            {

                s = -1;
            }
            return s;
        }

        public int UpdateUser(int user_id ,String user_name, String user_password, int user_status, String full_name, String user_type)
        {
            int x = 0;
            cmd_user = new OracleCommand();
            try
            {
                cmd_user.Connection = Program.con;
                cmd_user.CommandType = CommandType.Text;
                cmd_user.CommandText = "update tbl_user set " +
                    "user_name=:user_name,user_password=:user_password," +
                    "user_status=:user_status,full_name=:full_name,user_type=:user_type " +
                    "where user_id=:user_id";
                cmd_user.Parameters.Add(new OracleParameter("user_name", user_name));
                cmd_user.Parameters.Add(new OracleParameter("user_password", user_password));
                cmd_user.Parameters.Add(new OracleParameter("user_status", user_status));
                cmd_user.Parameters.Add(new OracleParameter("full_name", full_name));
                cmd_user.Parameters.Add(new OracleParameter("user_type", user_type));
                cmd_user.Parameters.Add(new OracleParameter("user_id", user_id));

                x = cmd_user.ExecuteNonQuery();
            }
            catch (Exception)
            {

                x = -1;
            }
            return x;
        }


    }
}
