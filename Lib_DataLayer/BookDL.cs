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
  
    public class BookDL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LibrarySystemConnectionString"].ToString());


        public int DL_Book_Insert(String BNAME, String AUTHOR, String DETAIL, String PRICE, String PUBLICATION, String BRANCH, String QUANTITIES, String AVAILABLEQNT, String RENTQNT, String img)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("BOOK_INSERT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BNAME", BNAME);
                cmd.Parameters.AddWithValue("@AUTHOR", AUTHOR);
                cmd.Parameters.AddWithValue("@DETAIL", DETAIL);
                cmd.Parameters.AddWithValue("@PRICE", PRICE);
                cmd.Parameters.AddWithValue("@PUBLICATION", PUBLICATION);
                cmd.Parameters.AddWithValue("@BRANCH", BRANCH);
                cmd.Parameters.AddWithValue("@QUANTITIES", QUANTITIES);
                cmd.Parameters.AddWithValue("@AVAILABLEQNT", AVAILABLEQNT);
                cmd.Parameters.AddWithValue("@RENTQNT", RENTQNT);
                cmd.Parameters.AddWithValue("@img", img);
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

        public int DL_Book_Issue_TO_Student(int BID)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("BOOK_ISSUE_TO_STUDENT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BID", BID);
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

        public DataSet DL_Book_Select_by_Branch(String Branch_name)
        {

            try
            {
                SqlDataAdapter _sqlDataAdapter;
                SqlCommand cmd = new SqlCommand("BOOK_SELECT_By_BRANCH", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BRANCH", Branch_name);
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


        public DataSet DL_Book_Select_by_Publication(String Publication)
        {

            try
            {
                SqlDataAdapter _sqlDataAdapter;
                SqlCommand cmd = new SqlCommand("BOOK_SELECT_By_PUBLICATION", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PUB", Publication);
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
        public DataSet DL_Book_Select_by_BNAME(String BNAME)
        {

            try
            {
                SqlDataAdapter _sqlDataAdapter;
                SqlCommand cmd = new SqlCommand("BOOK_SELECT_By_BNAME", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BNAME ", BNAME);
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


        public DataSet DL_Book_Select_by_BID(int BID)
        {

            try
            {
                SqlDataAdapter _sqlDataAdapter;
                SqlCommand cmd = new SqlCommand("BOOK_SELECT_By_BID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@bid", BID);
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
