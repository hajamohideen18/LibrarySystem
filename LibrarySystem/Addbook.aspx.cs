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
    public partial class Addbook : System.Web.UI.Page
    {
        private BranchBL _BranchBL;
        private PublicationBL _PublicationBLL;
        private BookBL _BookBL;
        protected void Page_Load(object sender, EventArgs e)
        {
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

            }
        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            int result = 0;
            _BookBL = new BookBL();
            if (FileUpload1.HasFile)
            {
                
                FileUpload1.SaveAs(Server.MapPath("~/Book/") + FileUpload1.FileName);

                result = _BookBL.BL_Book_Insert(txtbname.Text, txtauthor.Text, txtdetail.Text, (txtprice.Text), drppublication.SelectedItem.Text, drpbranch.SelectedItem.Text, (txtqnt.Text), txtqnt.Text, "0", "~/Book/" + FileUpload1.FileName.ToString());


                if (result != 0)
                {
                    lblmsg.Text = "Book Added Successfullly !!";
                    txtauthor.Text = "";
                    txtbname.Text = "";
                    txtdetail.Text = "";
                    txtprice.Text = "";
                    txtqnt.Text = "";
                    drpbranch.SelectedIndex = 0;
                    drppublication.SelectedIndex = 0;
                    txtbname.Focus();
                }
            }
            else
            {
                lblmsg.Text = "Please, Select Book Image First !!";
            }
        }

     }
    
}