using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remittances.Models
{
    class AccountClass
    {
        DataAccess dac = new DataAccess();
        
        public DataTable get_lastAccountNo()
        {
            
            //dal.Open();
            DataTable dt = new DataTable();
            dt = dac.SelectData("sp_get_lastAccountNo", null);
            dac.Close();
            return dt;
        }
        public string getAccID(string Acc_owner,int x)
        {
            int y=0;
            switch (x)
            {
                case 1:
                    y = 11001;
                    break;
                case 2:
                    y = 44044;
                    break;
                case 3:
                    y = 77062;
                    break;
                case 4:
                    y = 88068;
                    break;
                case 5:
                    y = 95735;
                    break;
            }

            int no = Convert.ToInt32(this.get_lastAccountNo().Rows[0][0].ToString()) + y;
            return      no.ToString() + "-"+ Acc_owner;
        }

        public void Add_Account(string acc_id, string name, string acc_type, string country, string mob, string note)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@acc_id", SqlDbType.VarChar, 50);
            param[0].Value = acc_id;

            param[1] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            param[1].Value = name;

            param[2] = new SqlParameter("@acc_type", SqlDbType.VarChar, 30);
            param[2].Value = acc_type;

            param[3] = new SqlParameter("@country", SqlDbType.VarChar, 30);
            param[3].Value = country;

            param[4] = new SqlParameter("@mob", SqlDbType.VarChar, 30);
            param[4].Value = mob;

            param[5] = new SqlParameter("@note", SqlDbType.VarChar, 100);
            param[5].Value = note;


            dac.Open();
            dac.ExecuteCommand("sp_add_account", param);
            dac.Close();
        }

        
        public void Edit_Account(string acc_id, string name, string acc_type, string country, string mob, string note)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@acc_id", SqlDbType.VarChar, 50);
            param[0].Value = acc_id;

            param[1] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            param[1].Value = name;

            param[2] = new SqlParameter("@acc_type", SqlDbType.VarChar, 30);
            param[2].Value = acc_type;

            param[3] = new SqlParameter("@country", SqlDbType.VarChar, 30);
            param[3].Value = country;

            param[4] = new SqlParameter("@mob", SqlDbType.VarChar, 30);
            param[4].Value = mob;

            param[5] = new SqlParameter("@note", SqlDbType.VarChar, 100);
            param[5].Value = note;


            dac.Open();
            dac.ExecuteCommand("sp_update_account", param);
            dac.Close();
        }
        public DataTable get_all_Accounts()
        {
            //dal.Open();
            DataTable dt = new DataTable();
            dt = dac.SelectData("sp_get_all_accounts", null);
            dac.Close();
            return dt;
        }
        public DataTable SearchAccount(string sr)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@sr", SqlDbType.VarChar, 50);
            param[0].Value = sr;

            //dal.Open();
            DataTable dt = new DataTable();
            dt = dac.SelectData("sp_SearchAccount", param);
            dac.Close();
            return dt;
        }
        
    }
}
