using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LIb_Bussiness;
using Lib_BusinessLayer;

namespace LibrarySystem.Student_Page
{
    public partial class MyAccount : System.Web.UI.Page
    {
        private StudentBL _StudentBL;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
            MultiView1.ActiveViewIndex = 0;
            List<Student> _StudentList = new List<Student>();
            _StudentBL = new StudentBL();

            _StudentList=_StudentBL.BL_Student_Select_BY_SID(Convert.ToInt32(Session["sid"].ToString()));
            lblnam.Text = _StudentList[0].STUDENTNAME.ToString();
            lblmobile.Text = _StudentList[0].MOBILE.ToString();
            lbladd.Text = _StudentList[0].ADD.ToString();
            lblcity.Text = _StudentList[0].CITY.ToString();
            lblpincode.Text = _StudentList[0].PINCODE.ToString();
            lblemail.Text = _StudentList[0].EMAIL.ToString();

        }
        protected void Button12_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
            List<Student> _StudentList = new List<Student>();
            _StudentBL = new StudentBL();
            _StudentList = _StudentBL.BL_Student_Select_BY_SID(Convert.ToInt32(Session["sid"].ToString()));

            lblnam.Text = _StudentList[0].STUDENTNAME.ToString();
            lblmobile.Text = _StudentList[0].MOBILE.ToString();
            lbladd.Text = _StudentList[0].ADD.ToString();
            lblcity.Text = _StudentList[0].CITY.ToString();
            lblpincode.Text = _StudentList[0].PINCODE.ToString();
            lblemail.Text = _StudentList[0].EMAIL.ToString();

        }
        protected void Button13_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;

            List<Student> _StudentList = new List<Student>();
            _StudentBL = new StudentBL();
            _StudentList = _StudentBL.BL_Student_Select_BY_SID(Convert.ToInt32(Session["sid"].ToString()));

            txtname.Text = _StudentList[0].STUDENTNAME.ToString();
            txtname0.Text = _StudentList[0].MOBILE.ToString();
            txtname1.Text = _StudentList[0].ADD.ToString();
            txtname2.Text = _StudentList[0].CITY.ToString();
            txtname3.Text = _StudentList[0].PINCODE.ToString();
            txtname4.Text = _StudentList[0].EMAIL.ToString();

        }
        protected void btnupdate_Click(object sender, EventArgs e)
        {

            int result = 0;
            _StudentBL = new StudentBL();
            result = _StudentBL.BL_Student_Update(Convert.ToInt32(Session["sid"].ToString()), txtname.Text, txtname4.Text, txtname0.Text, txtname1.Text, txtname2.Text, txtname3.Text);
            if (result != 0) { 
            MultiView1.ActiveViewIndex = 0;
            List<Student> _StudentList = new List<Student>();
            _StudentBL = new StudentBL();
            _StudentList = _StudentBL.BL_Student_Select_BY_SID(Convert.ToInt32(Session["sid"].ToString()));

            lblnam.Text = _StudentList[0].STUDENTNAME.ToString();
            lblmobile.Text = _StudentList[0].MOBILE.ToString();
            lbladd.Text = _StudentList[0].ADD.ToString();
            lblcity.Text = _StudentList[0].CITY.ToString();
            lblpincode.Text = _StudentList[0].PINCODE.ToString();
            lblemail.Text = _StudentList[0].EMAIL.ToString();
            }
        }
        protected void Button14_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
        }
        protected void Button15_Click(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                Label1.Text = "Enter Password";
            }
            else if (txtpass.Text != txtcpass.Text)
            {
                Label1.Text = "Password not same !!";
            }
            else
            {
                int result = 0;
                _StudentBL = new StudentBL();
                result =_StudentBL.BL_Student_change_Password(Convert.ToInt32(Session["sid"].ToString()), txtpass.Text);
              if (result != 0) { 
                Label1.Text = "Password has been changed !!";
                }

            }
            MultiView1.ActiveViewIndex = 2;
        }
    }
}