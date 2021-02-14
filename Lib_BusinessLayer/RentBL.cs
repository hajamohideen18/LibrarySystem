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
  
   public class RentBL
    {

        private RentDL _RentDL = new RentDL();


        public int BL_RENT_Insert(String BNAME, int SID, int DAYS)
        {

            int result = 0;
            try
            {

                result = _RentDL.DL_RENT_Insert( BNAME,  SID,  DAYS);


            }
            catch { }
            return result;

        }

        public int BL_RENT_SELECT_RETURN(int RID, int STATUS, int bid)
        {

            int result = 0;
            try
            {

                result = _RentDL.DL_RENT_SELECT_RETURN(RID, STATUS, bid);


            }
            catch { }
            return result;

        }

        public List<Rent> BL_Student_Select_BY_SID_BName_Status(int SID, String BNAME,int Status)
        {

            List<Rent> lstUserPpties = new List<Rent>();
            DataSet ds = new DataSet();
            try
            {

                ds = _RentDL.DL_Rent_Select_BY_SID_and_BNAME_and_STATUS(SID,BNAME,Status);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Rent _UserProperties = new Rent();
                        _UserProperties.RID = Int16.Parse(dr["RID"].ToString());
                        _UserProperties.BookName = dr["BookName"].ToString();
                        _UserProperties.SID = Int16.Parse( dr["SID"].ToString());
                        _UserProperties.Days = Int16.Parse(dr["Days"].ToString());
                        _UserProperties.IssueDate = dr["IssueDate"].ToString();
                        _UserProperties.ReturnDate = dr["ReturnDate"].ToString();
                        _UserProperties.Status = Int16.Parse( dr["Status"].ToString());
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


        public List<Rent> BL_Student_Select_BY_SID_Status(int SID, int Status)
        {

            List<Rent> lstUserPpties = new List<Rent>();
            DataSet ds = new DataSet();
            try
            {

                ds = _RentDL.DL_Rent_Select_BY_SID_STATUS(SID, Status);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Rent _UserProperties = new Rent();
                        _UserProperties.RID = Int16.Parse(dr["RID"].ToString());
                        _UserProperties.BookName = dr["BookName"].ToString();
                        _UserProperties.SID = Int16.Parse(dr["SID"].ToString());
                        _UserProperties.Days = Int16.Parse(dr["Days"].ToString());
                        _UserProperties.IssueDate = dr["IssueDate"].ToString();
                        _UserProperties.ReturnDate = dr["ReturnDate"].ToString();
                        _UserProperties.Status = Int16.Parse(dr["Status"].ToString());
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

        public List<Rent> DL_RENT_SELECT_SID_and_BNAME_and_STATUS(int SID, String BName, int Status)
        {

            List<Rent> lstUserPpties = new List<Rent>();
            DataSet ds = new DataSet();
            try
            {

                ds = _RentDL.DL_RENT_SELECT_SID_and_BNAME_and_STATUS(SID,BName, Status);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Rent _UserProperties = new Rent();
                        _UserProperties.RID = Int16.Parse(dr["RID"].ToString());
                        _UserProperties.BookName = dr["BookName"].ToString();
                        _UserProperties.SID = Int16.Parse(dr["SID"].ToString());
                        _UserProperties.Days = Int16.Parse(dr["Days"].ToString());
                        _UserProperties.IssueDate = dr["IssueDate"].ToString();
                        _UserProperties.ReturnDate = dr["ReturnDate"].ToString();
                        _UserProperties.Status = Int16.Parse(dr["Status"].ToString());
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
