using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace POS_204_oracle.Controller
{

    internal class CategoryController
    {
        OracleCommand cmd = new OracleCommand();
        OracleDataAdapter da = new OracleDataAdapter();
        DataTable dt = new DataTable();


        public DataTable GetAll()
        {
            dt = new DataTable();
            cmd = new OracleCommand();


            cmd.Connection = Program.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tbl_category";
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        public int Insert(String category_name,int category_status, String category_notes)
        {
            int x = 0;
            cmd = new OracleCommand();
            try
            {
                cmd.Connection = Program.con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into tbl_category(category_name,category_status,category_notes) " +
                    "values (:category_name,:category_status,:category_notes)";
                cmd.Parameters.Add(new OracleParameter("category_name", category_name));
                cmd.Parameters.Add(new OracleParameter("category_status", category_status));
                cmd.Parameters.Add(new OracleParameter("category_notes", category_notes));
                x = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                x = -1;
            }
            return x;
        }
        public int Delete(int category_id)
        {
            int s = 0;
            try
            {
                cmd.Connection = Program.con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete From tbl_category where category_id=:category_id";
                cmd.Parameters.Add(new OracleParameter("category_id", category_id));
                s = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                s = -1;
            }
            return s;
        }

        public int Update(int category_id,String category_name, int category_status, String category_notes)
        {
            int x = 0;
            cmd = new OracleCommand();
            try
            {
                cmd.Connection = Program.con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update tbl_category set " +
                    "category_name=:category_name,category_status=:category_status," +
                    "category_notes=:category_notes where category_id=:category_id ";
                cmd.Parameters.Add(new OracleParameter("category_name", category_name));
                cmd.Parameters.Add(new OracleParameter("category_status", category_status));
                cmd.Parameters.Add(new OracleParameter("category_notes", category_notes));
                cmd.Parameters.Add(new OracleParameter("category_id", category_id));


                x = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                x = -1;
            }
            return x;
        }

    }
}
