using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using LIb_Bussiness;

namespace Lib_DataLayer
{
   public class RentDL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LibrarySystemConnectionString"].ToString());

        public int DL_RENT_Insert(String BNAME, int SID, int DAYS)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("RENT_INSERT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BNAME", BNAME);
                cmd.Parameters.AddWithValue("@SID", SID);
                cmd.Parameters.AddWithValue("@DAYS", DAYS);
                   con.Open();
                int Result = cmd.ExecuteNonQuery();
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

        public int DL_RENT_SELECT_RETURN(int RID, int STATUS, int bid)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("RENT_SELECT_RETURN", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RID", RID);
                cmd.Parameters.AddWithValue("@STATUS", STATUS);
                cmd.Parameters.AddWithValue("@bid", bid);
                con.Open();
                int Result = cmd.ExecuteNonQuery();
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

        public DataSet DL_Rent_Select_BY_SID_and_BNAME_and_STATUS(int SID,String BName,int Status)
        {

            try
            {
                SqlDataAdapter _sqlDataAdapter;
                SqlCommand cmd = new SqlCommand("RENT_SELECT_SID_and_BNAME_and_STATUS", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BNAME", BName);
                cmd.Parameters.AddWithValue("@sid", SID);
                cmd.Parameters.AddWithValue("@status", Status);
                con.Open();

                _sqlDataAdapter = new SqlDataAdapter(cmd);
                DataSet Result = new DataSet();
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

        public DataSet DL_Rent_Select_BY_SID_STATUS(int SID, int Status)
        {

            try
            {
                SqlDataAdapter _sqlDataAdapter;
                SqlCommand cmd = new SqlCommand("RENT_SELECT_SID_STATUS", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sid", SID);
                cmd.Parameters.AddWithValue("@status", Status);
                con.Open();

                _sqlDataAdapter = new SqlDataAdapter(cmd);
                DataSet Result = new DataSet();
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

        public DataSet DL_RENT_SELECT_SID_and_BNAME_and_STATUS(int SID,String BName, int Status)
        {

            try
            {
                SqlDataAdapter _sqlDataAdapter;
                SqlCommand cmd = new SqlCommand("RENT_SELECT_SID_and_BNAME_and_STATUS", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sid", SID);
                cmd.Parameters.AddWithValue("@BNAME", BName);
                cmd.Parameters.AddWithValue("@status", Status);
                con.Open();

                _sqlDataAdapter = new SqlDataAdapter(cmd);
                DataSet Result = new DataSet();
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
