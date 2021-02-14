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
    public partial class PublicationPL : System.Web.UI.Page
    {
        private PublicationBL _publicationBL;

        protected void Page_Load(object sender, EventArgs e)
        {

            lblmsg.Text = "";
            if (Page.IsPostBack == false)
            {

                List<Publication> _PubicationList = new List<Publication>();

                _publicationBL = new PublicationBL();

                _PubicationList = _publicationBL.BL_Publication_Select();
                GridView1.DataSource = _PubicationList;
                GridView1.DataBind();
            }

        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            int result = 0;
            List<Publication> _PubicationList = new List<Publication>();
            _publicationBL = new PublicationBL();


          result=  _publicationBL.BL_Publication_Insert(txtpub.Text);
            if (result != 0)
            {
                lblmsg.Text = "Publication Added Successfully !!";

                _PubicationList = _publicationBL.BL_Publication_Select();
                GridView1.DataSource = _PubicationList;
                GridView1.DataBind();
                txtpub.Text = "";
                txtpub.Focus();
            }

        }

        //protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        //{
        //    int bid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);

        //    PubDT = PubAdapter.Select_By_PID(bid);

        //    BDT = BAdapter.Select_By_Publication(PubDT.Rows[0]["publication"].ToString());
        //    if (BDT.Rows.Count > 0)
        //    {

        //        lblmsg.Text = "Please, delete all books of this publication.";
        //    }
        //    else
        //    {

        //        PubAdapter.Delete(bid);
        //        lblmsg.Text = "Record Deleted !!";
        //        PubDT = PubAdapter.Select();
        //        GridView1.DataSource = PubDT;
        //        GridView1.DataBind();
        //    }
        //}

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

            List<Publication> _PubicationList = new List<Publication>();
            _publicationBL = new PublicationBL();

            GridView1.EditIndex = e.NewEditIndex;
            _PubicationList = _publicationBL.BL_Publication_Select();
            GridView1.DataSource = _PubicationList;
            GridView1.DataBind();

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int result = 0;
            List<Publication> _PubicationList = new List<Publication>();
            _publicationBL = new PublicationBL();
            int pid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            TextBox pname = GridView1.Rows[e.RowIndex].Cells[2].Controls[0] as TextBox;

            result = _publicationBL.BL_Publication_Update(pid, pname.Text);

            if (result != 0) { 

            lblmsg.Text = "Record Updated !!";
            GridView1.EditIndex = -1;
            _PubicationList = _publicationBL.BL_Publication_Select();

            GridView1.DataSource = _PubicationList;
            GridView1.DataBind();
            
            }
        }


        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            List<Publication> _PubicationList = new List<Publication>();
            _publicationBL = new PublicationBL();
            GridView1.EditIndex = -1;
            _PubicationList = _publicationBL.BL_Publication_Select();
            GridView1.DataSource = _PubicationList;
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int Result = 0;
            int bid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);

            List<Publication> _PubicationList = new List<Publication>();
            List<Book> _BookList = new List<Book>();
            _publicationBL = new PublicationBL();

            _PubicationList = _publicationBL.BL_Publication_Select_BY_PID(bid);
            
            _BookList = _publicationBL.BL_BOOK_Select_BY_PNAME(_PubicationList[0].PublicationName.ToString());
                if (_BookList.Count > 0)
                {

                    lblmsg.Text = "Please, delete all books of this publication.";
                }
                else
                {

                   Result = _publicationBL.BL_Publication_Delete(bid);
            if(Result != 0) {       
                lblmsg.Text = "Record Deleted !!";
                    _PubicationList = _publicationBL.BL_Publication_Select();
                    GridView1.DataSource = _PubicationList;
                    GridView1.DataBind();
                }
            }
        }


    }
}