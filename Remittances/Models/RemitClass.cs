using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remittances.Models
{
    class RemitClass
    {
        private DataAccess dal = new DataAccess();
        public DataTable get_all_remits()
        {
            //dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("sp_get_all_remits", null);
            dal.Close();
            return dt;
        }

        public void Adding_Remit(string remitType, int s_commissaryID, int r_commissaryID,
            int s_countryID, DateTime date, int r_countryID,float amount, float USDrate, float amountDLV, float cost,
            float commission,string currency, string sender_name, string recipient_name,
            string remit_state, string note)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[16];            

            param[0] = new SqlParameter("@remitType", SqlDbType.VarChar, 15);
            param[0].Value = remitType;

            param[1] = new SqlParameter("@s_commissaryID", SqlDbType.Int);
            param[1].Value = s_commissaryID;

            param[2] = new SqlParameter("@r_commissaryID", SqlDbType.Int);
            param[2].Value = r_commissaryID;

            param[3] = new SqlParameter("@s_countryID", SqlDbType.Int);
            param[3].Value = s_countryID;

            param[4] = new SqlParameter("@date", SqlDbType.DateTime);
            param[4].Value = date;

            param[5] = new SqlParameter("@r_countryID", SqlDbType.Int);
            param[5].Value = r_countryID;

            param[6] = new SqlParameter("@amount", SqlDbType.Float);
            param[6].Value = amount;

            param[7] = new SqlParameter("@USDrate", SqlDbType.Float);
            param[7].Value = USDrate;

            param[8] = new SqlParameter("@amountDLV", SqlDbType.Float);
            param[8].Value = amountDLV;

            param[9] = new SqlParameter("@cost", SqlDbType.Float);
            param[9].Value = cost;

            param[10] = new SqlParameter("@commission", SqlDbType.Float);
            param[10].Value = commission;

            param[11] = new SqlParameter("@currency", SqlDbType.VarChar, 10);
            param[11].Value = currency;

            param[12] = new SqlParameter("@sender_name", SqlDbType.VarChar, 50);
            param[12].Value = sender_name;

            param[13] = new SqlParameter("@recipient_name", SqlDbType.VarChar, 50);
            param[13].Value = recipient_name;

            param[14] = new SqlParameter("@remit_state", SqlDbType.VarChar, 15);
            param[14].Value = remit_state;

            param[15] = new SqlParameter("@note", SqlDbType.VarChar, 50);
            param[15].Value = note;
            dal.Open();
            dal.ExecuteCommand("sp_add_remit", param);
            dal.Close();
        }
    }
}
