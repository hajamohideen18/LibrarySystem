using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LIb_Bussiness;
using Lib_BusinessLayer;

namespace LibrarySystem
{
    public partial class BookIssue : System.Web.UI.Page
    {
        private BranchBL _BranchBL;
        private PublicationBL _PublicationBLL;
        private BookBL _BookBL;
        private StudentBL _StudentBL;
        private RentBL _RentBL;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblissue.Text = "";
            lblmsg.Text = "";
            if (Page.IsPostBack == false)
            {

                List<Branch> _BranchList = new List<Branch>();
                _BranchBL = new BranchBL();
                _BranchList = _BranchBL.BL_Branch_Select();


                drpbranch.DataSource = _BranchList;
                drpbranch.DataTextField = "BranchName";
                drpbranch.DataValueField = "BranchID";
                drpbranch.DataBind();
                drpbranch.Items.Insert(0, "SELECT");
              
                List<Publication> _PublicationList = new List<Publication>();
                _PublicationBLL = new PublicationBL();
                _PublicationList = _PublicationBLL.BL_Publication_Select();

                drppublication.DataSource = _PublicationList;
                drppublication.DataTextField = "PublicationName";
                drppublication.DataValueField = "PID";
                drppublication.DataBind();
                drppublication.Items.Insert(0, "SELECT");
                drpbook.Items.Insert(0, "SELECT");
            }
        }
        protected void drppublication_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Book> _BOOKList = new List<Book>();
            _BookBL = new BookBL();
            _BOOKList = _BookBL.BL_BOOK_Select_BY_Publication(drppublication.SelectedItem.Text);


            
            drpbook.DataSource = _BOOKList;
            drpbook.DataTextField = "BookName";
            drpbook.DataValueField = "BID";
            drpbook.DataBind();
            drpbook.Items.Insert(0, "SELECT");
        }
        protected void Button12_Click(object sender, EventArgs e)
        {
            if (drppublication.SelectedIndex == 0)
            {

                lblmsg.Text = "Select Publication !!";
                lblmsg.ForeColor = System.Drawing.Color.Red; MultiView1.ActiveViewIndex = -1;
            }
            else if (drpbook.SelectedIndex == 0)
            {
                lblmsg.Text = "Select Book !!";
                lblmsg.ForeColor = System.Drawing.Color.Red; MultiView1.ActiveViewIndex = -1;
            }
            else
            {
                MultiView1.ActiveViewIndex = 0;

                List<Book> _BOOKList = new List<Book>();
                _BookBL = new BookBL();
                _BOOKList = _BookBL.BL_BOOK_Select_BY_BNAME(drpbook.SelectedItem.Text);

                if (_BOOKList.Count > 0)
                {
                    ViewState["BBID"] = _BOOKList[0].BID.ToString();
                    lblbname.Text = _BOOKList[0].BookName.ToString();
                    lblauthor.Text = _BOOKList[0].Author.ToString();
                    lblbran.Text = _BOOKList[0].Branch.ToString();
                    lblpub.Text = _BOOKList[0].Publication.ToString();
                    lblprice.Text = _BOOKList[0].Price.ToString();
                    lblqnt.Text = _BOOKList[0].Quantites.ToString();
                    lblaqnt.Text = _BOOKList[0].AvailableQnt.ToString();
                    lblrqnt.Text = _BOOKList[0].RentQnt.ToString();
                    lbldetail.Text = _BOOKList[0].Detail.ToString();
                    Image2.ImageUrl = _BOOKList[0].Image.ToString();
                }
                drpstudent.Items.Clear();
                drpstudent.Items.Insert(0, "SELECT");
            }
        }
        protected void btnissue_Click(object sender, EventArgs e)
        {
            _RentBL = new RentBL();
            _BookBL = new BookBL();
            try
            {
                if (TextBox1.Text == "")
                {
                    lblissue.Text = "Enter Days !!";
                }
                else
                {
                    if (Convert.ToInt32(lblaqnt.Text) == 0)
                    {
                        lblissue.Text = "Book Stock Empty !!";
                    }
                    else
                    {
                        List<Rent> _RentList = new List<Rent>();
                        _RentBL = new RentBL();
                        _RentList =_RentBL.BL_Student_Select_BY_SID_BName_Status( Convert.ToInt32(drpstudent.SelectedValue), lblbname.Text, 0);
                        

                        if (_RentList.Count != 0)
                        {
                            lblissue.Text = "Student can't get copies of same book !!";
                        }
                        else
                        {
                            _RentList = _RentBL.BL_Student_Select_BY_SID_Status(Convert.ToInt32(drpstudent.SelectedValue), 0);

                     
                            if (_RentList.Count == 3)
                            {
                                lblissue.Text = "A student has maximum 3 books !!";
                            }
                            else
                            {
                                int result = 0;
                                int result1 = 0;
                                result = _RentBL.BL_RENT_Insert(lblbname.Text, Convert.ToInt32(drpstudent.SelectedValue), Convert.ToInt32(TextBox1.Text));

                                result1 =_BookBL.BL_Book_ISSUE_TO_STUDENT(Convert.ToInt32(ViewState["BBID"].ToString()));
                                lblissue.Text = "Book Issued to " + drpstudent.SelectedItem.Text;


                                List<Book> _BOOKList = new List<Book>();
                              
                                _BOOKList = _BookBL.BL_BOOK_Select_BY_BID(Convert.ToInt32(ViewState["BBID"]));
                                if (_BOOKList.Count > 0)
                                {
                                    ViewState["BBID"] = _BOOKList[0].BID.ToString();
                                    lblbname.Text = _BOOKList[0].BookName.ToString();
                                    lblauthor.Text = _BOOKList[0].Author.ToString();
                                    lblbran.Text = _BOOKList[0].Branch.ToString();
                                    lblpub.Text = _BOOKList[0].Publication.ToString();
                                    lblprice.Text = _BOOKList[0].Price.ToString();
                                    lblqnt.Text = _BOOKList[0].Quantites.ToString();
                                    lblaqnt.Text = _BOOKList[0].AvailableQnt.ToString();
                                    lblrqnt.Text = _BOOKList[0].RentQnt.ToString();
                                    lbldetail.Text = _BOOKList[0].Detail.ToString();
                                    Image2.ImageUrl = _BOOKList[0].Image.ToString();
                                }
                                TextBox1.Text = "";
                                drpstudent.Items.Clear();
                                drpstudent.Items.Insert(0, "SELECT");


                                List<Branch> _BranchList = new List<Branch>();
                                _BranchBL = new BranchBL();
                                _BranchList = _BranchBL.BL_Branch_Select();


                                drpbranch.DataSource = _BranchList;
                                drpbranch.DataTextField = "BranchName";
                                drpbranch.DataValueField = "BranchID";
                                drpbranch.DataBind();
                                drpbranch.Items.Insert(0, "SELECT");

                          
                            }
                        }
                    }
                }
            }
            catch
            {
                lblissue.Text = "Sorry !!! Error !!!";
            }
        }
        protected void drpbranch_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            List<Student> _StudentList = new List<Student>();
            _StudentBL = new StudentBL();

            _StudentList = _StudentBL.BL_Student_Select_BY_Branch(drpbranch.SelectedItem.Text);

            
            drpstudent.DataSource = _StudentList;
            drpstudent.DataTextField = "STUDENTNAME";
            drpstudent.DataValueField = "SID";
            drpstudent.DataBind();
            drpstudent.Items.Insert(0, "SELECT");
        }
    }
}