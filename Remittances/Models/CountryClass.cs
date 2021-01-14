using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remittances.Models
{
    class CountryClass
    {
        private DataAccess dac = new DataAccess();
        public DataTable get_all_countries()
        {
            //dal.Open();
            DataTable dt = new DataTable();
            dt = dac.SelectData("sp_get_all_countries", null);
            dac.Close();
            return dt;
        }

        public DataTable get_countryID(string country_name)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@country_name", SqlDbType.VarChar, 50);
            param[0].Value = country_name;
            //dal.Open();
            DataTable dt = new DataTable();
            dt = dac.SelectData("sp_get_countryID", param);
            dac.Close();
            return dt;
        }

        public void Add_Country(string country_name, string currency)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@country_name", SqlDbType.VarChar, 50);
            param[0].Value = country_name;

            param[1] = new SqlParameter("@currency", SqlDbType.VarChar, 20);
            param[1].Value = currency;
           
            dac.Open();
            dac.ExecuteCommand("sp_add_Country", param);
            dac.Close();
        }


        public void Edit_Country(int country_id, string country_name, string currency)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@country_id", SqlDbType.Int);
            param[0].Value = country_id;

            param[1] = new SqlParameter("@country_name", SqlDbType.VarChar, 50);
            param[1].Value = country_name;

            param[2] = new SqlParameter("@currency", SqlDbType.VarChar, 20);
            param[2].Value = currency;

            dac.Open();
            dac.ExecuteCommand("sp_update_Country", param);
            dac.Close();
        }
        
        
        public DataTable SearchCountry(string sr)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@sr", SqlDbType.VarChar, 50);
            param[0].Value = sr;

            //dal.Open();
            DataTable dt = new DataTable();
            dt = dac.SelectData("sp_SearchCountry", param);
            dac.Close();
            return dt;
        }

        public void Delete_Country(int country_id)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@country_id", SqlDbType.Int);
            param[0].Value = country_id;

            dac.Open();
            dac.ExecuteCommand("sp_delete_Country", param);
            dac.Close();
        }
    }
}
