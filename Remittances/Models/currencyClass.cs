using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remittances.Models
{
    class currencyClass
    {
        private DataAccess dac = new DataAccess();
        public DataTable get_all_currencies()
        {
            //dal.Open();
            DataTable dt = new DataTable();
            dt = dac.SelectData("sp_get_all_currencies", null);
            dac.Close();
            return dt;
        }

        public DataTable get_KassRate(string currencyName)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@currency_name", SqlDbType.VarChar, 50);
            param[0].Value = currencyName;
            //dal.Open();
            DataTable dt = new DataTable();
            dt = dac.SelectData("sp_get_KassRate", param);
            dac.Close();
            return dt;
        }

        public DataTable SearchCurrency(string sr)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@sr", SqlDbType.VarChar, 50);
            param[0].Value = sr;

            //dal.Open();
            DataTable dt = new DataTable();
            dt = dac.SelectData("sp_SearchCurrency", param);
            dac.Close();
            return dt;
        }

        public void Delete_Currency(string id)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dac.Open();
            dac.ExecuteCommand("sp_delete_Currency", param);
            dac.Close();
        }

        public void Add_Currency(string currency_code, string currency_name, string country, float ex_rateUSD)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@currency_code", SqlDbType.VarChar, 20);
            param[0].Value = currency_code;

            param[1] = new SqlParameter("@currency_name", SqlDbType.VarChar, 20);
            param[1].Value = currency_name;

            param[2] = new SqlParameter("@country", SqlDbType.VarChar, 20);
            param[2].Value = country;

            param[3] = new SqlParameter("@ex_rateUSD", SqlDbType.Float);
            param[3].Value = ex_rateUSD;

            dac.Open();
            dac.ExecuteCommand("sp_add_Currency", param);
            dac.Close();
        }


        public void Edit_Currency(int id , string currency_code, string currency_name, string country, float ex_rateUSD)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@currency_code", SqlDbType.VarChar, 20);
            param[1].Value = currency_code;

            param[2] = new SqlParameter("@currency_name", SqlDbType.VarChar, 20);
            param[2].Value = currency_name;

            param[3] = new SqlParameter("@country", SqlDbType.VarChar, 20);
            param[3].Value = country;

            param[4] = new SqlParameter("@ex_rateUSD", SqlDbType.Float);
            param[4].Value = ex_rateUSD;

            dac.Open();
            dac.ExecuteCommand("sp_update_Currency", param);
            dac.Close();
        }

    }
}
