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
    public partial class Addbranch : System.Web.UI.Page
    {
        private BranchBL _BranchBL;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblmsg.Text = "";
            if (Page.IsPostBack == false)
            {

                List<Branch> _BranchList = new List<Branch>();

                _BranchBL = new BranchBL();
                _BranchList = _BranchBL.BL_Branch_Select();
                
                GridView1.DataSource = _BranchList;
                GridView1.DataBind();
            }
        }
        protected void btnadd_Click(object sender, EventArgs e)
        {
            int result = 0;
            List<Branch> _BranchList = new List<Branch>();
            _BranchBL = new BranchBL();


            result = _BranchBL.BL_Branch_Insert(txtaddbranch.Text);
            if (result != 0)
            {


                lblmsg.Text = "Branch Added Successfully !!";

                _BranchList = _BranchBL.BL_Branch_Select();

                GridView1.DataSource = _BranchList;
                GridView1.DataBind();
                txtaddbranch.Text = "";
                txtaddbranch.Focus();
            }
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int bid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);

            int result = 0;
            List<Branch> _BranchList = new List<Branch>();
            _BranchBL = new BranchBL();


            result = _BranchBL.BL_Branch_Delete(bid);
            if (result != 0)
            {
                lblmsg.Text = "Branch Record Deleted !!";
                _BranchList = _BranchBL.BL_Branch_Select();

                GridView1.DataSource = _BranchList;
                GridView1.DataBind();
            }
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            List<Branch> _BranchList = new List<Branch>();

            _BranchBL = new BranchBL();
            _BranchList = _BranchBL.BL_Branch_Select();

            GridView1.DataSource = _BranchList;
            GridView1.DataBind();

        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            List<Branch> _BranchList = new List<Branch>();

            _BranchBL = new BranchBL();
            _BranchList = _BranchBL.BL_Branch_Select();

            GridView1.DataSource = _BranchList;
            GridView1.DataBind();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int bid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            TextBox bname = GridView1.Rows[e.RowIndex].Cells[2].Controls[0] as TextBox;

            int result = 0;
            List<Branch> _BranchList = new List<Branch>();
            _BranchBL = new BranchBL();


            result = _BranchBL.BL_Branch_Update(bid,bname.Text);
            if (result != 0)
            {

                lblmsg.Text = "Branch Record Updated !!";
                GridView1.EditIndex = -1;
                _BranchList = _BranchBL.BL_Branch_Select();

                GridView1.DataSource = _BranchList;
                GridView1.DataBind();
            }
        }
    }
}