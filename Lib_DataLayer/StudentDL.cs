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
    
   public class StudentDL

    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LibrarySystemConnectionString"].ToString());

        public int DL_Student_Insert(String STUDENTNAME, String BRANCHNAME, String MOBILE, String ADD, String CITY, 
            String PINCODE, String DOB, String GENDER, String EMAIL,String pass,  String img)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("STUDENT_INSERT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@STUDENTNAME", STUDENTNAME);
                cmd.Parameters.AddWithValue("@BRANCHNAME", BRANCHNAME);
                cmd.Parameters.AddWithValue("@MOBILE", MOBILE);
                cmd.Parameters.AddWithValue("@ADD", ADD);
                cmd.Parameters.AddWithValue("@CITY", CITY);
                cmd.Parameters.AddWithValue("@PINCODE", PINCODE);
                cmd.Parameters.AddWithValue("@DOB", DOB);
                cmd.Parameters.AddWithValue("@GENDER", GENDER);
                cmd.Parameters.AddWithValue("@EMAIL", EMAIL);
                cmd.Parameters.AddWithValue("@pass", pass);
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


        public int DL_STUDENT_CHANGE_PASSWORD(int SID,String Pass)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("STUDENT_change_password", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sid", SID);
                cmd.Parameters.AddWithValue("@pass", Pass);

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

        public int DL_Student_Update( int SID,String STUDENTNAME, String EMAIL,  String MOBILE, String ADD, String CITY,
          String PINCODE)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("STUDENT_UPDATE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SID", SID);
                cmd.Parameters.AddWithValue("@STUDENTNAME", STUDENTNAME);
                cmd.Parameters.AddWithValue("@EMail", EMAIL);
                cmd.Parameters.AddWithValue("@MOBILE", MOBILE);
                cmd.Parameters.AddWithValue("@ADD", ADD);
                cmd.Parameters.AddWithValue("@CITY", CITY);
                cmd.Parameters.AddWithValue("@PINCODE", PINCODE);
               
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


        public DataSet DL_Student_Select_BY_Branch(String Branch)
        {

            try
            {
                SqlDataAdapter _sqlDataAdapter;
                SqlCommand cmd = new SqlCommand("STUDENT_SELECT_BY_branch", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@branch", Branch);
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

        public DataSet DL_STUDENT_SELECT_RENT_BOOK(int Status)
        {

            try
            {
                SqlDataAdapter _sqlDataAdapter;
                SqlCommand cmd = new SqlCommand("STUDENT_SELECT_RENT_BOOK", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@STATUS", Status);
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


        public DataSet DL_Student_Select_BY_Name(String Name)
        {

            try
            {
                SqlDataAdapter _sqlDataAdapter;
                SqlCommand cmd = new SqlCommand("STUDENT_SELECT_SEARCH", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", Name);
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

        

        public DataSet DL_Student_Select_BY_SID(int SID)
        {

            try
            {
                SqlDataAdapter _sqlDataAdapter;
                SqlCommand cmd = new SqlCommand("STUDENT_SELECT_BY_SID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SID", SID);
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

        public DataSet DL_Student_Login(String UName, String Password)
        {

            try
            {
                SqlDataAdapter _sqlDataAdapter;
                SqlCommand cmd = new SqlCommand("STUDENT_SELECT_LOGIN", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EMAIL", UName);
                cmd.Parameters.AddWithValue("@pass", Password);
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
