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
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        private StudentBL _studentBL;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sid"] == null)
            {
                Response.Redirect("../Default.aspx");
            }
            _studentBL = new StudentBL();
            List<Student> _StudentList = new List<Student>();
            _StudentList =_studentBL.BL_Student_Select_BY_SID(Convert.ToInt32(Session["sid"].ToString()));

            Image2.ImageUrl = _StudentList[0].Img.ToString();
            lblname.Text = _StudentList[0].STUDENTNAME.ToString();

        }
        protected void Button11_Click(object sender, EventArgs e)
        {

        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            Session["sid"] = null;
            Response.Redirect("../Default.aspx");
        }
    }
}