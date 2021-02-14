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
   public class BranchDL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LibrarySystemConnectionString"].ToString());

        public DataSet DL_Branch_Select()
        {

            try
            {
                SqlDataAdapter _sqlDataAdapter;
                SqlCommand cmd = new SqlCommand("BRANCH_SELECT", con);
                cmd.CommandType = CommandType.StoredProcedure;
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

        public int DL_Branch_Insert(String Branch_name)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("BRANCH_INSERT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BRANCHNAME", Branch_name);
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

        public int DL_Branch_Update(int BID, String Branch_name)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("BRANCH_UPDATE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BID", BID);
                cmd.Parameters.AddWithValue("@BRANCHNAME", Branch_name);
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


        public DataSet DL_Branch_select_PID(int BID)
        {

            try
            {
                SqlDataAdapter _sqlDataAdapter;
                SqlCommand cmd = new SqlCommand("BRANCH_SELECT_BY_BID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BID", BID);
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

      



        public int DL_Branch_Delete(int BID)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("BRANCH_DELETE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BRANCHID", BID);

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
    }
}
