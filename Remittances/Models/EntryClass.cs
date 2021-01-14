using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remittances.Models
{
    class EntryClass
    {
        private DataAccess dac = new DataAccess();
        public DataTable get_all_Entries()
        {            
            DataTable dt = new DataTable();
            dt = dac.SelectData("sp_get_all_Entries", null);
            dac.Close();
            return dt;
        }

        public DataTable get_EntryID(string officer)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@officer", SqlDbType.VarChar, 30);
            param[0].Value = officer;
            //dal.Open();
            DataTable dt = new DataTable();
            dt = dac.SelectData("sp_get_EntryID", param);
            dac.Close();
            return dt;
        }

        public DataTable SearchEntry(string sr)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@sr", SqlDbType.VarChar, 50);
            param[0].Value = sr;

            //dal.Open();
            DataTable dt = new DataTable();
            dt = dac.SelectData("sp_SearchEntry", param);
            dac.Close();
            return dt;
        }
        public void Add_Entry(string eAction, string eRef, string officer, DateTime eDate)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[4];
            
            param[0] = new SqlParameter("@eAction", SqlDbType.VarChar, 50);
            param[0].Value = eAction;

            param[1] = new SqlParameter("@eRef", SqlDbType.VarChar, 30);
            param[1].Value = eRef;

            param[2] = new SqlParameter("@officer", SqlDbType.VarChar, 30);
            param[2].Value = officer;

            param[3] = new SqlParameter("@eDate", SqlDbType.DateTime);
            param[3].Value = eDate;

            dac.Open();
            dac.ExecuteCommand("sp_add_Entry", param);
            dac.Close();
        }
        public void Delete_Logins_Entry(string eAction)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@eAction", SqlDbType.VarChar,50);
            param[0].Value = eAction;

            dac.Open();
            dac.ExecuteCommand("sp_delete_Logins_Entry", param);
            dac.Close();
        }
        public void Delete_all_Logins_Entries()
        {
            dac.Open();
            dac.ExecuteCommand("sp_delete_all_Logins_Entries", null);
            dac.Close();
        }

    }
}
