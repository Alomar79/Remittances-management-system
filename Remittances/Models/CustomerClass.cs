using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remittances.Models
{
    class CustomerClass
    {
        private DataAccess dac = new DataAccess();
        public DataTable get_all_Customers()
        {
            //dal.Open();
            DataTable dt = new DataTable();
            dt = dac.SelectData("sp_get_all_Customers", null);
            dac.Close();
            return dt;
        }

        public DataTable get_CustomerID(string fullname)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@fullname", SqlDbType.VarChar, 50);
            param[0].Value = fullname;
            //dal.Open();
            DataTable dt = new DataTable();
            dt = dac.SelectData("sp_get_customerID", param);
            dac.Close();
            return dt;
        }

        public void Add_Customer(string fullname, string national_id, 
            string country, string mob, string note)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@fullname", SqlDbType.VarChar, 50);
            param[0].Value = fullname;

            param[1] = new SqlParameter("@national_id", SqlDbType.VarChar, 20);
            param[1].Value = national_id;

            param[2] = new SqlParameter("@country", SqlDbType.VarChar, 50);
            param[2].Value = country;

            param[3] = new SqlParameter("@mob", SqlDbType.VarChar, 20);
            param[3].Value = mob;

            param[4] = new SqlParameter("@note", SqlDbType.VarChar, 100);
            param[4].Value = note;

            dac.Open();
            dac.ExecuteCommand("sp_add_Customer", param);
            dac.Close();
        }


        public void Edit_Customer(int customer_id, string fullname, string national_id,
            string country, string mob, string note)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@customer_id", SqlDbType.Int);
            param[0].Value = customer_id;

            param[1] = new SqlParameter("@fullname", SqlDbType.VarChar, 50);
            param[1].Value = fullname;

            param[2] = new SqlParameter("@national_id", SqlDbType.VarChar, 20);
            param[2].Value = national_id;

            param[3] = new SqlParameter("@country", SqlDbType.VarChar, 50);
            param[3].Value = country;

            param[4] = new SqlParameter("@mob", SqlDbType.VarChar, 20);
            param[4].Value = mob;

            param[5] = new SqlParameter("@note", SqlDbType.VarChar, 100);
            param[5].Value = note;

            dac.Open();
            dac.ExecuteCommand("sp_update_Customer", param);
            dac.Close();
        }


        public DataTable SearchCustomer(string sr)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@sr", SqlDbType.VarChar, 50);
            param[0].Value = sr;

            //dal.Open();
            DataTable dt = new DataTable();
            dt = dac.SelectData("sp_SearchCustomer", param);
            dac.Close();
            return dt;
        }

        public void Delete_Customer(int customer_id)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@customer_id", SqlDbType.Int);
            param[0].Value = customer_id;

            dac.Open();
            dac.ExecuteCommand("sp_delete_Customer", param);
            dac.Close();
        }
    }
}
