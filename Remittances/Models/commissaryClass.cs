using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remittances.Models
{
    class commissaryClass
    {
        private DataAccess dal = new DataAccess();
        public DataTable get_all_commissaries()
        {
            //dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("sp_get_all_commissaries", null);
            dal.Close();
            return dt;
        }

        //public DataTable get_Curr_commissary(string commissary_name)
        //{
        //    SqlParameter[] param = new SqlParameter[1];
        //    param[0] = new SqlParameter("@commissary_name", SqlDbType.VarChar,50);
        //    param[0].Value = commissary_name;
        //    //dal.Open();
        //    DataTable dt = new DataTable();
        //    dt = dal.SelectData("sp_get_Curr_commissary", param);
        //    dal.Close();
        //    return dt;
        //}

        public void changeMandopAcc(int commissaryID, float account)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@commissaryID", SqlDbType.Int);
            param[0].Value = commissaryID;

            param[1] = new SqlParameter("@account", SqlDbType.Float);
            param[1].Value = account;

            dal.Open();
            dal.ExecuteCommand("sp_changeMandopAcc", param);
            dal.Close();
        }
        
    }
}
