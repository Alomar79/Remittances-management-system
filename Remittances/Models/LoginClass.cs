using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remittances.Models
{
    class LoginClass
    {
        private DataAccess dal = new DataAccess();
        public DataTable login(string user_id, string pwd)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@user_id", SqlDbType.VarChar, 50);
            param[0].Value = user_id;

            param[1] = new SqlParameter("@pwd", SqlDbType.VarChar, 50);
            param[1].Value = pwd;

            //dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("sp_login", param);
            //dal.Close();
            return dt;
        }

        public DataTable Search_User(string criteria)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@criteria", SqlDbType.VarChar, 50);
            param[0].Value = criteria;



            //dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("sp_SearchUser", param);
            //dal.Close();
            return dt;
        }
        public void Add_User(string id, string fullname, string pwd, string userType)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@user_id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            param[1] = new SqlParameter("@fullname", SqlDbType.VarChar, 50);
            param[1].Value = fullname;

            param[2] = new SqlParameter("@pwd", SqlDbType.VarChar, 50);
            param[2].Value = pwd;

            param[3] = new SqlParameter("@userType", SqlDbType.VarChar, 50);
            param[3].Value = userType;


            dal.Open();
            dal.ExecuteCommand("sp_add_user", param);
            dal.Close();
        }

        public void Edit_User(string id, string fullname, string pwd, string userType)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@user_id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            param[1] = new SqlParameter("@fullname", SqlDbType.VarChar, 50);
            param[1].Value = fullname;

            param[2] = new SqlParameter("@pwd", SqlDbType.VarChar, 50);
            param[2].Value = pwd;

            param[3] = new SqlParameter("@userType", SqlDbType.VarChar, 50);
            param[3].Value = userType;


            dal.Open();
            dal.ExecuteCommand("sp_edit_user", param);
            dal.Close();
        }

        public void Delete_User(string id)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@user_id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            dal.Open();
            dal.ExecuteCommand("sp_delete_user", param);
            dal.Close();
        }
    }
}
