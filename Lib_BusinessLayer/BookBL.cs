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
   public class BookBL
    {
        private BookDL _BookDL = new BookDL();
        public int BL_Book_Insert(String BNAME, String AUTHOR, String DETAIL, String PRICE, String PUBLICATION, String BRANCH, String QUANTITIES, String AVAILABLEQNT, String RENTQNT, String img)
        {
            int _result = 0;
            try
            {

                _result = _BookDL.DL_Book_Insert(BNAME, AUTHOR,  DETAIL,  PRICE, PUBLICATION,  BRANCH,  QUANTITIES,  AVAILABLEQNT,  RENTQNT,img);

            }

            catch
            {

            }
            return _result;
        }



        public int BL_Book_ISSUE_TO_STUDENT(int BID)
        {
            int _result = 0;
            try
            {

                _result = _BookDL.DL_Book_Issue_TO_Student(BID);

            }

            catch
            {

            }
            return _result;
        }



        public List<Book> BL_BOOK_Select_BY_Branch(String Branch)
        {

            List<Book> lstUserPpties = new List<Book>();
            DataSet ds = new DataSet();
            try
            {

                ds = _BookDL.DL_Book_Select_by_Branch(Branch);
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


        public List<Book> BL_BOOK_Select_BY_Publication(String Publication)
        {

            List<Book> lstUserPpties = new List<Book>();
            DataSet ds = new DataSet();
            try
            {

                ds = _BookDL.DL_Book_Select_by_Publication(Publication);
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


        public List<Book> BL_BOOK_Select_BY_BNAME(String BNAME)
        {

            List<Book> lstUserPpties = new List<Book>();
            DataSet ds = new DataSet();
            try
            {

                ds = _BookDL.DL_Book_Select_by_BNAME(BNAME);
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


        public List<Book> BL_BOOK_Select_BY_BID(int BID)
        {

            List<Book> lstUserPpties = new List<Book>();
            DataSet ds = new DataSet();
            try
            {

                ds = _BookDL.DL_Book_Select_by_BID(BID);
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


    }
}
