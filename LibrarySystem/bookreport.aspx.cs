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
    public partial class bookreport : System.Web.UI.Page
    {
        private BranchBL _BranchBL;
        private PublicationBL _PublicationBLL;
        private BookBL _BookBL;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblmsg.Text = "";
            lblmsg0.Text = "";
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
                MultiView1.ActiveViewIndex = -1;


                List<Publication> _PublicationList = new List<Publication>();
                _PublicationBLL = new PublicationBL();
                _PublicationList = _PublicationBLL.BL_Publication_Select();





                drppublication.DataSource = _PublicationList;
                drppublication.DataTextField = "PublicationName";
                drppublication.DataValueField = "PID";
                drppublication.DataBind();
                drppublication.Items.Insert(0, "SELECT");

            
            }
        }
        protected void btnviewbranch_Click(object sender, EventArgs e)
        {
            if (drpbranch.SelectedIndex == 0)
            {
                lblmsg.Text = "Select Branch !!";
                lblmsg.ForeColor = System.Drawing.Color.Red;
                GridView1.DataSource = null;
                GridView1.DataBind(); MultiView1.ActiveViewIndex = -1;
            }
            else
            {

                List<Book> _BookList = new List<Book>();
                _BookBL = new BookBL();
                _BookList = _BookBL.BL_BOOK_Select_BY_Branch(drpbranch.SelectedItem.Text);
                GridView1.DataSource = _BookList;
                GridView1.DataBind();
                lblmsg0.Text = GridView1.Rows.Count.ToString() + " - Records Found.";

                MultiView1.ActiveViewIndex = 0;
            }
        }
        protected void btnviewpublication_Click(object sender, EventArgs e)
        {
            if (drppublication.SelectedIndex == 0)
            {
                GridView1.DataSource = null;
                GridView1.DataBind();
                lblmsg.Text = "Select Publication !!";
                lblmsg.ForeColor = System.Drawing.Color.Red; MultiView1.ActiveViewIndex = -1;
            }
            else
            {
                MultiView1.ActiveViewIndex = 0;

                List<Book> _BookList = new List<Book>();
                _PublicationBLL = new PublicationBL();
                _BookList = _PublicationBLL.BL_BOOK_Select_BY_PNAME(drppublication.SelectedItem.Text);         
                GridView1.DataSource = _BookList;
                GridView1.DataBind();
                lblmsg0.Text = GridView1.Rows.Count.ToString() + " - Records Found.";

            }
        }
        protected void Button11_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
       


            List<Book> _BookList = new List<Book>();
            _BookBL = new BookBL();
            _BookList = _BookBL.BL_BOOK_Select_BY_BID(Convert.ToInt32(e.CommandArgument.ToString()));



            if (_BookList.Count > 0)
            {
                MultiView1.ActiveViewIndex = 1;
                lblbname.Text = _BookList[0].BookName.ToString(); 
                lblauthor.Text = _BookList[0].Author.ToString();
                lblbran.Text = _BookList[0].Branch.ToString();
                lblpub.Text = _BookList[0].Publication.ToString();
                lblprice.Text = _BookList[0].Price.ToString();
                lblqnt.Text = _BookList[0].Quantites.ToString();
                lblaqnt.Text = _BookList[0].AvailableQnt.ToString();
                lblrqnt.Text = _BookList[0].RentQnt.ToString();
                lbldetail.Text = _BookList[0].Detail.ToString();
                Image2.ImageUrl = _BookList[0].Image.ToString();

            }
        }
    }
}