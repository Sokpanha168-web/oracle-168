using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_204_oracle.Controller
{
    internal class SupplierController
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
            cmd.CommandText = "select * from tbl_supplier";
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        public int Insert(String supplier_name, String supplier_contact, String supplier_notes)
        {
            int x = 0;
            cmd = new OracleCommand();
            try
            {
                cmd.Connection = Program.con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into tbl_supplier(supplier_name,supplier_contact,supplier_notes) " +
                    "values (:supplier_name,:supplier_contact,:supplier_notes)";
                cmd.Parameters.Add(new OracleParameter("supplier_name", supplier_name));
                cmd.Parameters.Add(new OracleParameter("supplier_contact", supplier_contact));
                cmd.Parameters.Add(new OracleParameter("supplier_notes", supplier_notes));
                x = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                x = -1;
            }
            return x;
        }
        public int Delete(int supplier_id)
        {
            int s = 0;
            try
            {
                cmd.Connection = Program.con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete From tbl_supplier where supplier_id=:supplier_id";
                cmd.Parameters.Add(new OracleParameter("supplier_id", supplier_id));
                s = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                s = -1;
            }
            return s;
        }

        public int Update(int supplier_id, String supplier_name, String supplier_contact, String supplier_notes)
        {
            int x = 0;
            cmd = new OracleCommand();
            try
            {
                cmd.Connection = Program.con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update tbl_supplier set " +
                    "supplier_name=:supplier_name,supplier_contact=:supplier_contact," +
                    "supplier_notes=:supplier_notes where supplier_id=:supplier_id ";
                cmd.Parameters.Add(new OracleParameter("supplier_name", supplier_name));
                cmd.Parameters.Add(new OracleParameter("supplier_contact", supplier_contact));
                cmd.Parameters.Add(new OracleParameter("supplier_notes", supplier_notes));
                cmd.Parameters.Add(new OracleParameter("supplier_id", supplier_id));


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
