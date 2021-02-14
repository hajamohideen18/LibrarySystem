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
    public partial class Issuereport : System.Web.UI.Page
    {
        private BranchBL _BranchBL;
        private StudentBL _StudentBL;
        private RentBL _RentBL;
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl.Text = "";
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

        
                // MultiView1.ActiveViewIndex = -1;
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
        protected void Button11_Click(object sender, EventArgs e)
        {

        }
        protected void btnseach_Click(object sender, EventArgs e)
        {
            lbl.Text = "";
            if (drpbranch.SelectedItem.Text == "SELECT")
            {
                lbl.Text = "Select Branch First !!";

            }
            else if (drpstudent.SelectedItem.Text == "SELECT")
            {
                lbl.Text = "Select Student First !!";
            }
            else

            {
                List<Rent> _RentList = new List<Rent>();
                _RentBL = new RentBL();
                _RentList = _RentBL.BL_Student_Select_BY_SID_Status(Convert.ToInt32(drpstudent.SelectedValue), 0);
               
                GridView1.DataSource = _RentList;
                GridView1.DataBind();
                lbl.Text = "Total Records = " + _RentList.Count.ToString();
            }
        }
    }
}