using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib_DataLayer;
using LIb_Bussiness;


namespace Lib_BusinessLayer
{
    public class LoginBL
    {
        private LoginDL _LoginDL= new LoginDL();
        public List<Admin> BL_LoginAuthentication(string username, string password)
        {
                
            List<Admin> lstUserPpties = new List<Admin>();
            DataSet ds = new DataSet();
            try
            {

                ds = _LoginDL.DL_Admin_Login(username, password);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Admin _UserProperties = new Admin();
                        _UserProperties.AID = Int16.Parse(dr["AID"].ToString());
                        _UserProperties.UserName = dr["UserName"].ToString();
                        _UserProperties.NAME = dr["Name"].ToString();
                        lstUserPpties.Add(_UserProperties);
                        _UserProperties =null;

                    }
                

                }
            }
            catch
            {

            }
            return lstUserPpties;
        }
    }
}
