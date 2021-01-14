using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remittances.Models
{
    class MatchClass
    {
        private DataAccess dac = new DataAccess();
        public DataTable get_all_Matches()
        {
            DataTable dt = new DataTable();
            dt = dac.SelectData("sp_get_all_Matches", null);
            dac.Close();
            return dt;
        }

        public DataTable get_MatchID(string acc_id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@acc_id", SqlDbType.VarChar, 50);
            param[0].Value = acc_id;
            //dal.Open();
            DataTable dt = new DataTable();
            dt = dac.SelectData("sp_get_MatchID", param);
            dac.Close();
            return dt;
        }

        public DataTable SearchMatch(string sr)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@sr", SqlDbType.VarChar, 50);
            param[0].Value = sr;

            //dal.Open();
            DataTable dt = new DataTable();
            dt = dac.SelectData("sp_SearchMatch", param);
            dac.Close();
            return dt;
        }
        public void Add_Match(string acc_id, string currency, float creditor, 
            float deptor,DateTime mDate ,  string mNote)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@acc_id", SqlDbType.VarChar, 50);
            param[0].Value = acc_id;

            param[1] = new SqlParameter("@currency", SqlDbType.VarChar, 20);
            param[1].Value = currency;

            param[2] = new SqlParameter("@creditor", SqlDbType.Float);
            param[2].Value = creditor;

            param[3] = new SqlParameter("@deptor", SqlDbType.Float);
            param[3].Value = deptor;

            param[4] = new SqlParameter("@mDate", SqlDbType.DateTime);
            param[4].Value = mDate;

            param[5] = new SqlParameter("@mNote", SqlDbType.VarChar, 100);
            param[5].Value = mNote;

            dac.Open();
            dac.ExecuteCommand("sp_add_Match", param);
            dac.Close();
        }
        public void Edit_Match(int match_id,string acc_id, string currency, float creditor,
            float deptor, DateTime mDate, string mNote)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@match_id", SqlDbType.Int);
            param[0].Value = match_id;

            param[1] = new SqlParameter("@acc_id", SqlDbType.VarChar, 50);
            param[1].Value = acc_id;

            param[2] = new SqlParameter("@currency", SqlDbType.VarChar, 20);
            param[2].Value = currency;

            param[3] = new SqlParameter("@creditor", SqlDbType.Float);
            param[3].Value = creditor;

            param[4] = new SqlParameter("@deptor", SqlDbType.Float);
            param[4].Value = deptor;

            param[5] = new SqlParameter("@mDate", SqlDbType.DateTime);
            param[5].Value = mDate;

            param[6] = new SqlParameter("@mNote", SqlDbType.VarChar, 100);
            param[6].Value = mNote;

            dac.Open();
            dac.ExecuteCommand("sp_update_Match", param);
            dac.Close();
        }
        public void Delete_Match(int match_id)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@match_id", SqlDbType.Int);
            param[0].Value = match_id;

            dac.Open();
            dac.ExecuteCommand("sp_delete_Match", param);
            dac.Close();
        }
    }
}
