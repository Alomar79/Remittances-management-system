using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Remittances.Forms;

namespace Remittances.Models
{
    class DataAccess
    {
        SqlConnection cn; //, cn_restore;

        public DataAccess()
        {
            //string mode = Properties.Settings.Default.Mode;
            //if (mode == "SQL")
            //{
            //    cn = new SqlConnection(@"Server= " + Properties.Settings.Default.Server + "; database=" + Properties.Settings.Default.Database + "; Integrated Security=false; User ID=" + Properties.Settings.Default.ID + "; Password=" + Properties.Settings.Default.Password);
            //}
            //else
            //{
            //    cn = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + "; database=" + Properties.Settings.Default.Database + "; Integrated Security=true");
            //}

            cn = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + "; database=" + Properties.Settings.Default.Database + "; Integrated Security=true");

        }

        public void Open()
        {
            if (cn.State != ConnectionState.Open)
            {
                cn.Open();
            }
        }

        public void Close()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }

        public DataTable SelectData(string stored_Procedure, SqlParameter[] param)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_Procedure;
            cmd.Connection = cn;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            try
            {
                DA.Fill(dt);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "رسالة الخطأ");
            }

            return dt;
        }
        public void ExecuteCommand(string stored_Procedure, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_Procedure;
            cmd.Connection = cn;
            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }


            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "رسالة الخطأ");
                return;
            }
            
        }



        

    }
}
