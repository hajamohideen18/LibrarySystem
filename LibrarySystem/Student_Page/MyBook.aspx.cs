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
    public partial class MyBook : System.Web.UI.Page
    {
        private RentBL _RentBL;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btntaken_Click(object sender, EventArgs e)
        {
            _RentBL = new RentBL();
            List<Rent> _RentList = new List<Rent>();
            
            _RentList=_RentBL.BL_Student_Select_BY_SID_Status(Convert.ToInt32(Session["sid"].ToString()), 0);
            GridView1.DataSource = _RentList;
            GridView1.DataBind();
            MultiView1.ActiveViewIndex = 0;
            lblb.Text = GridView1.Rows.Count.ToString();
        }
        protected void btnreturn_Click(object sender, EventArgs e)
        {
            _RentBL = new RentBL();
            List<Rent> _RentList = new List<Rent>();

            _RentList = _RentBL.BL_Student_Select_BY_SID_Status(Convert.ToInt32(Session["sid"].ToString()), 1);
            GridView2.DataSource = _RentList;
            GridView2.DataBind();
            MultiView1.ActiveViewIndex = 1;
            lblr.Text = GridView2.Rows.Count.ToString();
        }
    }
}