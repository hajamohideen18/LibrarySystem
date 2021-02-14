using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib_DataLayer;
using LIb_Bussiness;
using System.Data;

namespace Lib_BusinessLayer
{
 public   class StudentBL
    {
        private StudentDL _StudentDL = new StudentDL();
        public int BL_Student_Insert(String STUDENTNAME, String BRANCHNAME, String MOBILE, String ADD, String CITY,
          String PINCODE, String DOB, String GENDER, String EMAIL, String pass, String img)
        {
            int result = 0;
            try
            {
               
                result = _StudentDL.DL_Student_Insert(STUDENTNAME, BRANCHNAME, MOBILE, ADD, CITY,
                 PINCODE, DOB, GENDER, EMAIL, pass, img);


            }
            catch { }
            return result;
        }

        public int BL_Student_Update(int SID, String STUDENTNAME, String EMAIL, String MOBILE, String ADD, String CITY,
         String PINCODE)
        {
            int result = 0;
            try
            {

                result = _StudentDL.DL_Student_Update( SID,  STUDENTNAME,  EMAIL,  MOBILE,  ADD,  CITY,PINCODE);


            }
            catch { }
            return result;
        }

        public int BL_Student_change_Password(int SID,String Pass)
        {
            int result = 0;
            try
            {

                result = _StudentDL.DL_STUDENT_CHANGE_PASSWORD(SID, Pass);
            }
            catch { }
            return result;

        }




        public List<Student> BL_Student_Select_BY_Branch(String Branch)
        {

            List<Student> lstUserPpties = new List<Student>();
            DataSet ds = new DataSet();
            try
            {

                ds = _StudentDL.DL_Student_Select_BY_Branch(Branch);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Student _UserProperties = new Student();
                        _UserProperties.SID = Int16.Parse(dr["SID"].ToString());
                        _UserProperties.STUDENTNAME = dr["StudentName"].ToString();
                        _UserProperties.BRANCHNAME = dr["BranchName"].ToString();
                        _UserProperties.MOBILE = dr["Mobile"].ToString();
                        _UserProperties.ADD = dr["Address"].ToString();
                        _UserProperties.CITY = dr["City"].ToString();
                        _UserProperties.PINCODE = dr["Pincode"].ToString();
                        _UserProperties.DOB = dr["DOB"].ToString();
                        _UserProperties.GENDER = dr["Gender"].ToString();
                        _UserProperties.EMAIL = dr["Email"].ToString();
                        _UserProperties.Pass = dr["Password"].ToString();
                        _UserProperties.Img = dr["Image"].ToString();
                     


                        lstUserPpties.Add(_UserProperties);
                        _UserProperties = null;

                    }


                }
            }
            catch
            {

            }
            return lstUserPpties;
        }

        public List<Student> BL_STUDENT_SELECT_RENT_BOOK(int Status)
        {

            List<Student> lstUserPpties = new List<Student>();
            DataSet ds = new DataSet();
            try
            {

                ds = _StudentDL.DL_STUDENT_SELECT_RENT_BOOK(Status);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Student _UserProperties = new Student();
                        _UserProperties.SID = Int16.Parse(dr["SID"].ToString());
                        _UserProperties.STUDENTNAME = dr["StudentName"].ToString();
                        lstUserPpties.Add(_UserProperties);
                        _UserProperties = null;

                    }


                }
            }
            catch
            {

            }
            return lstUserPpties;
        }

        public List<Student> BL_Student_Select_BY_NAME(String Name)
        {

            List<Student> lstUserPpties = new List<Student>();
            DataSet ds = new DataSet();
            try
            {

                ds = _StudentDL.DL_Student_Select_BY_Name(Name);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Student _UserProperties = new Student();
                        _UserProperties.SID = Int16.Parse(dr["SID"].ToString());
                        _UserProperties.STUDENTNAME = dr["StudentName"].ToString();
                        _UserProperties.BRANCHNAME = dr["BranchName"].ToString();
                        _UserProperties.MOBILE = dr["Mobile"].ToString();
                        _UserProperties.ADD = dr["Address"].ToString();
                        _UserProperties.CITY = dr["City"].ToString();
                        _UserProperties.PINCODE = dr["Pincode"].ToString();
                        _UserProperties.DOB = dr["DOB"].ToString();
                        _UserProperties.GENDER = dr["Gender"].ToString();
                        _UserProperties.EMAIL = dr["Email"].ToString();
                        _UserProperties.Pass = dr["Password"].ToString();
                        _UserProperties.Img = dr["Image"].ToString();



                        lstUserPpties.Add(_UserProperties);
                        _UserProperties = null;

                    }


                }
            }
            catch
            {

            }
            return lstUserPpties;
        }


        public List<Student> BL_Student_Select_BY_SID(int SID)
        {

            List<Student> lstUserPpties = new List<Student>();
            DataSet ds = new DataSet();
            try
            {

                ds = _StudentDL.DL_Student_Select_BY_SID(SID);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Student _UserProperties = new Student();
                        _UserProperties.SID = Int16.Parse(dr["SID"].ToString());
                        _UserProperties.STUDENTNAME = dr["StudentName"].ToString();
                        _UserProperties.BRANCHNAME = dr["BranchName"].ToString();
                        _UserProperties.MOBILE = dr["Mobile"].ToString();
                        _UserProperties.ADD = dr["Address"].ToString();
                        _UserProperties.CITY = dr["City"].ToString();
                        _UserProperties.PINCODE = dr["Pincode"].ToString();
                        _UserProperties.DOB = dr["DOB"].ToString();
                        _UserProperties.GENDER = dr["Gender"].ToString();
                        _UserProperties.EMAIL = dr["Email"].ToString();
                        _UserProperties.Pass = dr["Password"].ToString();
                        _UserProperties.Img = dr["Image"].ToString();



                        lstUserPpties.Add(_UserProperties);
                        _UserProperties = null;

                    }


                }
            }
            catch
            {

            }
            return lstUserPpties;
        }


        public List<Student> BL_StudentAuthentication(string username, string password)
        {

            List<Student> lstUserPpties = new List<Student>();
            DataSet ds = new DataSet();
            try
            {

                ds = _StudentDL.DL_Student_Login(username, password);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Student _UserProperties = new Student();
                        _UserProperties.SID = Int16.Parse(dr["SID"].ToString());
                        _UserProperties.STUDENTNAME = dr["StudentName"].ToString();
                        _UserProperties.BRANCHNAME = dr["BranchName"].ToString();
                        _UserProperties.MOBILE = dr["Mobile"].ToString();
                        _UserProperties.ADD = dr["Address"].ToString();
                        _UserProperties.CITY = dr["City"].ToString();
                        _UserProperties.PINCODE = dr["Pincode"].ToString();
                        _UserProperties.DOB = dr["DOB"].ToString();
                        _UserProperties.GENDER = dr["Gender"].ToString();
                        _UserProperties.EMAIL = dr["Email"].ToString();
                        _UserProperties.Pass = dr["Password"].ToString();
                        _UserProperties.Img = dr["Image"].ToString();


                        lstUserPpties.Add(_UserProperties);
                        _UserProperties = null;

                    }


                }
            }
            catch
            {

            }
            return lstUserPpties;
        }
    }


}

