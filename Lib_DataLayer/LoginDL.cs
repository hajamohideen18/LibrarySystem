using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIb_Bussiness;


namespace Lib_DataLayer
{
    public  class LoginDL
    {
        
        SqlConnection con = new SqlConnection( ConfigurationManager.ConnectionStrings["LibrarySystemConnectionString"].ToString());
        public DataSet DL_Admin_Login(String UName,String Password)
        {
            
            try
            {
                SqlDataAdapter _sqlDataAdapter;
                SqlCommand cmd = new SqlCommand("ADMIN_SELECT_FOR_LOGIN", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@uname", UName);
                cmd.Parameters.AddWithValue("@pass", Password);
                con.Open();

                _sqlDataAdapter = new SqlDataAdapter(cmd);
                DataSet Result  = new DataSet();
                _sqlDataAdapter.Fill(Result);
                cmd.Dispose();
               
                return Result;

            }

            catch (Exception ex)
            {
                string strErrorMsq = ex.ToString();
                throw ex;
            }
            finally
            {
                con.Close();
            }

        }



    }
}
