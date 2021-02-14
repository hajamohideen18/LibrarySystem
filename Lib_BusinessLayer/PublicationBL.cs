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
  public  class PublicationBL
    {

        private PublicationDL _PublicationDL = new PublicationDL();
        public List<Publication> BL_Publication_Select()
        {

            List<Publication> lstUserPpties = new List<Publication>();
            DataSet ds = new DataSet();
            try
            {

                ds = _PublicationDL.DL_Publication_Select();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Publication _UserProperties = new Publication();
                        _UserProperties.PID = Int16.Parse(dr["PID"].ToString());
                        _UserProperties.PublicationName = dr["Publication"].ToString();
                        _UserProperties.EntryDate = dr["EntryDate"].ToString();
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


        public List<Publication> BL_Publication_Select_BY_PID(int PID)
        {

            List<Publication> lstUserPpties = new List<Publication>();
            DataSet ds = new DataSet();
            try
            {

                ds = _PublicationDL.DL_Publication_select_PID(PID);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Publication _UserProperties = new Publication();
                        _UserProperties.PID = Int16.Parse(dr["PID"].ToString());
                        _UserProperties.PublicationName = dr["Publication"].ToString();
                        _UserProperties.EntryDate = dr["EntryDate"].ToString();
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
        public List<Book> BL_BOOK_Select_BY_PNAME(String PNAME)
        {

            List<Book> lstUserPpties = new List<Book>();
            DataSet ds = new DataSet();
            try
            {

                ds = _PublicationDL.DL_Book_select_PNAME(PNAME);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Book _UserProperties = new Book();
                        _UserProperties.BID = Int16.Parse(dr["BookID"].ToString());
                        _UserProperties.BookName = dr["BookName"].ToString();
                        _UserProperties.Author = dr["Author"].ToString();
                        _UserProperties.Detail = dr["Detail"].ToString();
                        _UserProperties.Price = dr["Price"].ToString();
                        _UserProperties.Publication = dr["Publication"].ToString();
                        _UserProperties.Branch = dr["Branch"].ToString();
                        _UserProperties.Quantites = dr["Quantities"].ToString();
                        _UserProperties.AvailableQnt = dr["AvailableQnt"].ToString();
                        _UserProperties.RentQnt = dr["RentQnt"].ToString();
                        _UserProperties.Image = dr["Image"].ToString();
                        _UserProperties.EntryDate = dr["EntryDate"].ToString();
                    


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


        public int BL_Publication_Update(int PID,String Publication_name)
        {
            int _result = 0;
            try
            {

                _result = _PublicationDL.DL_Publication_Update(PID,Publication_name);

            }

            catch
            {

            }
            return _result;
        }


        public int BL_Publication_Insert(String Publication_name)
        {
            int _result = 0;
            try { 
           
                _result = _PublicationDL.DL_Publication_Insert(Publication_name);
                           
                }
            
            catch
            {

            }
            return _result;
        }

        public int BL_Publication_Delete(int PID)
        {
            int _result = 0;
            try
            {

                _result = _PublicationDL.DL_Publication_Delete(PID);

            }

            catch
            {

            }
            return _result;
        }






    }
}
