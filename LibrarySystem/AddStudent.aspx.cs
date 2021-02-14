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
    public partial class AddStudent : System.Web.UI.Page
    {
        private BranchBL _BranchBL;
        private StudentBL _StudentBL;
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
            }


        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            _StudentBL = new StudentBL();
            int result = 0;
                string gen = "";
                if (rdomale.Checked == true)
                {
                    gen = "Male";
                }
                else
                {
                    gen = "Female";
                }
                if (FileUpload1.HasFile)
                {
                    FileUpload1.SaveAs(Server.MapPath("~/img/") + FileUpload1.FileName);

                result =_StudentBL.BL_Student_Insert(txtsname.Text, drpbranch.SelectedItem.Text, txtmobile.Text, txtaddress.Text, txtcity.Text, txtpincode.Text, "", gen, txtemail.Text, txtpass.Text, "~/img/" + FileUpload1.FileName);
                        if (result!= 0 ) {
                            lblmsg.Text = "Student Added Successfully !!";
                        }
                    
                 

                }
                else
                {

                result = _StudentBL.BL_Student_Insert(txtsname.Text, drpbranch.SelectedItem.Text, txtmobile.Text, txtaddress.Text, txtcity.Text, txtpincode.Text, "", gen, txtemail.Text, txtpass.Text, "~/img/std.png");
                    if (result != 0)
                    {
                        lblmsg.Text = "Student Added Successfully !!";
                    }

                
                }
                txtsname.Text = ""; drpbranch.SelectedIndex = 0;
                txtmobile.Text = "";
                txtaddress.Text = ""; txtcity.Text = "";
                txtpincode.Text = "";
                txtemail.Text = "";
                txtpass.Text = "";
               


            
        }
    }
    
}