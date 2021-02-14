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
    public partial class BookReturn : System.Web.UI.Page
    {
  
        private StudentBL _StudentBL;
        private BookBL _BookBL;
        private RentBL _RentBL;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblmsg.Text = "";
            lblbook.Text = "";
            if (Page.IsPostBack == false)
            {


                List<Student> _StudentList = new List<Student>();
                _StudentBL = new StudentBL();

                _StudentList = _StudentBL.BL_STUDENT_SELECT_RENT_BOOK(0);

                drppublication.DataSource = _StudentList;
                drppublication.DataTextField = "STUDENTNAME";
                drppublication.DataValueField = "SID";
                drppublication.DataBind();
                drppublication.Items.Insert(0, "SELECT");
                drpbook.Items.Insert(0, "SELECT");
            }
        }
        protected void Button12_Click(object sender, EventArgs e)
        {
            if (drppublication.SelectedIndex == 0)
            {

                lblmsg.Text = "Select Student First !!";
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

                List<Book> _BookList = new List<Book>();
                _BookBL = new BookBL();

                _BookList = _BookBL.BL_BOOK_Select_BY_BNAME(drpbook.SelectedItem.Text);

                ViewState["BBID"] = _BookList[0].BID.ToString();
                lblbname.Text = _BookList[0].BookName.ToString();
                lblauthor.Text = _BookList[0].Author.ToString();
                lblbran.Text = _BookList[0].Branch.ToString();
                lblpub.Text = _BookList[0].Publication.ToString();
                lblprice.Text = _BookList[0].Price.ToString();

                Image2.ImageUrl = _BookList[0].Image.ToString();


                List<Student> _StudentList = new List<Student>();
                _StudentBL = new StudentBL();

                _StudentList = _StudentBL.BL_Student_Select_BY_SID(Convert.ToInt32(drppublication.SelectedValue));
                lblstudent.Text = _StudentList[0].STUDENTNAME.ToString();


                List<Rent> __RentList = new List<Rent>();
                _RentBL = new RentBL();
                __RentList = _RentBL.BL_Student_Select_BY_SID_BName_Status(Convert.ToInt32(drppublication.SelectedValue), drpbook.SelectedItem.Text, 0);
               
                lbldays.Text = __RentList[0].Days.ToString();
                lblidate.Text = __RentList[0].IssueDate.ToString();
                ViewState["RRID"] = __RentList[0].RID.ToString();
              
                
            }
        }
        protected void drppublication_SelectedIndexChanged(object sender, EventArgs e)

        { 
            if(drppublication.SelectedValue != "0") { 
            List<Rent> __RentList = new List<Rent>();
            _RentBL = new RentBL();
            __RentList = _RentBL.BL_Student_Select_BY_SID_Status(Convert.ToInt32(drppublication.SelectedValue), 0);


            drpbook.DataSource = __RentList;
            drpbook.DataTextField = "BookName";
            drpbook.DataValueField = "RID";
            drpbook.DataBind();
            drpbook.Items.Insert(0, "SELECT");
            }
        }
        protected void btnreturnbook_Click(object sender, EventArgs e)
        {

            int result = 0;
            _RentBL = new RentBL();
            result = _RentBL.BL_RENT_SELECT_RETURN(Convert.ToInt32(ViewState["RRID"].ToString()), 1, Convert.ToInt32(ViewState["BBID"].ToString()));


       if (result != 0) { 
                lblbook.Text = "Book Returd Successfully !!";
                lblbook.ForeColor = System.Drawing.Color.Green;
            }

        }
    }
}