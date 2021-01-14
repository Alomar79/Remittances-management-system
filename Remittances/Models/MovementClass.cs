using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remittances.Models
{
    class MovementClass
    {
        private DataAccess dac = new DataAccess();
        public DataTable Get_all_movements()
        {
            DataTable dt = new DataTable();
            dt = dac.SelectData("sp_get_all_movements", null);
            dac.Close();
            return dt;
        }
        public DataTable Get_moves_ByAcc(string acc_id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@acc_id", SqlDbType.VarChar, 50);
            param[0].Value = acc_id;
            //dal.Open();
            DataTable dt = new DataTable();
            dt = dac.SelectData("sp_get_moves_ByAcc", param);
            dac.Close();
            return dt;
        }
        public DataTable Get_movID(string acc_id)
        {
            //SqlParameter[] param = new SqlParameter[1];
            //param[0] = new SqlParameter("@acc_id", SqlDbType.VarChar, 50);
            //param[0].Value = acc_id;
            ////dal.Open();
            DataTable dt = new DataTable();
            //dt = dac.SelectData("sp_get_movID", param);
            //dac.Close();
            return dt;
        }

        public DataTable SearchMove(string sr)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@sr", SqlDbType.VarChar, 50);
            param[0].Value = sr;

            //dal.Open();
            DataTable dt = new DataTable();
            dt = dac.SelectData("sp_SearchMove", param);
            dac.Close();
            return dt;
        }
        public void Add_Move(string mov_type,int remit_id, string acc_id,string our_acc_id, 
            string currency,float USDex_rate, float creditor, float deptor, DateTime mov_date, string note)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("@mov_type", SqlDbType.VarChar, 20);
            param[0].Value = mov_type;

            param[1] = new SqlParameter("@remit_id", SqlDbType.Int);
            param[1].Value = remit_id;

            param[2] = new SqlParameter("@acc_id", SqlDbType.VarChar, 50);
            param[2].Value = acc_id;

            param[3] = new SqlParameter("@our_acc_id", SqlDbType.VarChar, 50);
            param[3].Value = our_acc_id;

            param[4] = new SqlParameter("@currency", SqlDbType.VarChar, 20);
            param[4].Value = currency;

            param[5] = new SqlParameter("@USDex_rate", SqlDbType.Float);
            param[5].Value = USDex_rate;

            param[6] = new SqlParameter("@creditor", SqlDbType.Float);
            param[6].Value = creditor;

            param[7] = new SqlParameter("@deptor", SqlDbType.Float);
            param[7].Value = deptor;

            param[8] = new SqlParameter("@mov_date", SqlDbType.DateTime);
            param[8].Value = mov_date;

            param[9] = new SqlParameter("@note", SqlDbType.VarChar, 100);
            param[9].Value = note;

            dac.Open();
            dac.ExecuteCommand("sp_add_Movement", param);
            dac.Close();
        }
        public void Edit_Move(int match_id, string acc_id, string currency, float creditor,
            float deptor, DateTime mDate, string mNote)
        {
            //SqlCommand cmd = new SqlCommand();
            //SqlParameter[] param = new SqlParameter[7];

            //param[0] = new SqlParameter("@match_id", SqlDbType.Int);
            //param[0].Value = match_id;

            //param[1] = new SqlParameter("@acc_id", SqlDbType.VarChar, 50);
            //param[1].Value = acc_id;

            //param[2] = new SqlParameter("@currency", SqlDbType.VarChar, 20);
            //param[2].Value = currency;

            //param[3] = new SqlParameter("@creditor", SqlDbType.Float);
            //param[3].Value = creditor;

            //param[4] = new SqlParameter("@deptor", SqlDbType.Float);
            //param[4].Value = deptor;

            //param[5] = new SqlParameter("@mDate", SqlDbType.DateTime);
            //param[5].Value = mDate;

            //param[6] = new SqlParameter("@mNote", SqlDbType.VarChar, 100);
            //param[6].Value = mNote;

            //dac.Open();
            //dac.ExecuteCommand("sp_update_Match", param);
            //dac.Close();
        }
        public void Delete_Move(int mov_id)
        {
            //SqlCommand cmd = new SqlCommand();
            //SqlParameter[] param = new SqlParameter[1];

            //param[0] = new SqlParameter("@mov_id", SqlDbType.Int);
            //param[0].Value = mov_id;

            //dac.Open();
            //dac.ExecuteCommand("sp_delete_Move", param);
            //dac.Close();
        }
    }
}
