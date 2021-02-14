using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LIb_Bussiness;
using Lib_BusinessLayer;
namespace LibrarySystem
{
    public partial class Default : System.Web.UI.Page
    {
        private LoginBL _LoginBL;
        private StudentBL _studentBL;

        protected void Page_Load(object sender, EventArgs e)
        {
            lbl.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Admin> _LoginUser = new List<Admin>();
            List<Student> _StudentUser = new List<Student>();

            _LoginBL = new LoginBL();
            _studentBL = new StudentBL();
            if (rdolibrary.Checked == true)
            {

                   try
                {
                    _LoginUser = _LoginBL.BL_LoginAuthentication(txtuname.Text, txtupass.Text);

                    if(_LoginUser.Count  >0)
                    {
                        Session["aid"] = _LoginUser[0].AID.ToString();
                        Session["email"] = _LoginUser[0].UserName.ToString();
                        Session["name"] = _LoginUser[0].NAME.ToString();
                        Response.Redirect("Home.aspx",false);


                    }else
                    {
                        lbl.Text = "Invalid Credential";
                    }

                   
                }
                catch (Exception ex)
                {
                    Response.Redirect("The Error is " + ex);
                }
                finally
                {
                   
                }
            }
            else
            {
                _StudentUser =_studentBL.BL_StudentAuthentication(txtuname.Text, txtupass.Text);
                if (_StudentUser.Count > 0)
                {

                    Session["sid"] = _StudentUser[0].SID.ToString();
                    Session["email"] = txtuname.Text;
                    Response.Redirect("Student_Page/Default.aspx");
                }
                else
                {
                    lbl.Text = "Invalid Credential";
                }


            }



        }


    }
    }
