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
   public  class PublicationDL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LibrarySystemConnectionString"].ToString());

        public DataSet DL_Publication_Select()
        {

            try
            {
                SqlDataAdapter _sqlDataAdapter;
                SqlCommand cmd = new SqlCommand("PUBLICATION_SELECT", con);
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

        public int DL_Publication_Insert(String Publication_name)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("PUBLICATION_INSERT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PNAME", Publication_name);
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

        public int DL_Publication_Update(int PID,String Publication_name)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("PUBLICATION_UPDATE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PID", PID);
                cmd.Parameters.AddWithValue("@PNAME", Publication_name);
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


        public DataSet DL_Publication_select_PID(int PID)
        {

            try
            {
                SqlDataAdapter _sqlDataAdapter;
                SqlCommand cmd = new SqlCommand("PUBLICATION_SELECT_BY_PID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PID", PID);
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

        public DataSet DL_Book_select_PNAME(String PNAME)
        {

            try
            {
                SqlDataAdapter _sqlDataAdapter;
                SqlCommand cmd = new SqlCommand("BOOK_SELECT_By_PUBLICATION", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PUB", PNAME);
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




        public int DL_Publication_Delete(int PID)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("PUBLICATION_DELETE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PID", PID);
               
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
