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
    public partial class Studenteport : System.Web.UI.Page
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
                MultiView1.ActiveViewIndex = -1;
            }
        }
        protected void Button11_Click(object sender, EventArgs e)
        {
            if (drpbranch.SelectedIndex == 0)
            {
                lblmsg.Text = "Select Branch !!";
                MultiView1.ActiveViewIndex = -1;
            }
            else
            {
                List<Student> _StudentList = new List<Student>();
                _StudentBL = new StudentBL();

                _StudentList = _StudentBL.BL_Student_Select_BY_Branch(drpbranch.SelectedItem.Text);
                GridView1.DataSource = _StudentList;
                GridView1.DataBind();
                MultiView1.ActiveViewIndex = 0;
                lbl.Text = GridView1.Rows.Count.ToString() + " Student Found.";
            }
        }
        protected void btnseach_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text == "")
            {
                lblmsg.Text = "Enter student name !!";
            }
            else
            {
                List<Student> _StudentList = new List<Student>();
                _StudentBL = new StudentBL();
                _StudentList = _StudentBL.BL_Student_Select_BY_NAME(txtsearch.Text + "%");
                GridView1.DataSource = _StudentList;
                GridView1.DataBind();
                MultiView1.ActiveViewIndex = 0;
                lbl.Text = GridView1.Rows.Count.ToString() + " Student Found.";
            }
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
            List<Student> _StudentList = new List<Student>();
            _StudentBL = new StudentBL();
            _StudentList = _StudentBL.BL_Student_Select_BY_SID(Convert.ToInt32(e.CommandArgument.ToString()));

            lblid.Text = _StudentList[0].SID.ToString();
            lblname.Text = _StudentList[0].STUDENTNAME.ToString();
            lblbranch.Text = _StudentList[0].BRANCHNAME.ToString();
            lblmobile.Text = _StudentList[0].MOBILE.ToString();
            lbladdress.Text = _StudentList[0].ADD.ToString();
            lblcity.Text = _StudentList[0].CITY.ToString();
            lblpin.Text = _StudentList[0].PINCODE.ToString();
            //  DateTime dobb = Convert.ToDateTime(SDT.Rows[0]["dob"].ToString());
            //   lbldob.Text = dobb.GetDateTimeFormats()[7].ToString();
            lblemai.Text = _StudentList[0].EMAIL.ToString();
            lblpass.Text = _StudentList[0].Pass.ToString();
        }
        protected void Button12_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }
    }
}