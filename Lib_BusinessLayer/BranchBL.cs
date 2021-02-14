using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib_DataLayer;
using LIb_Bussiness;
using System.Data;

namespace Lib_BusinessLayer
{
    public class BranchBL
    {
        private BranchDL _BranchDL = new BranchDL();
        public List<Branch> BL_Branch_Select()
        {

            List<Branch> lstUserPpties = new List<Branch>();
            DataSet ds = new DataSet();
            try
            {

                ds = _BranchDL.DL_Branch_Select();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Branch _UserProperties = new Branch();
                        _UserProperties.BranchID = Int16.Parse(dr["BranchID"].ToString());
                        _UserProperties.BranchName = dr["BranchName"].ToString();
                     
                        lstUserPpties.Add(_UserProperties);
                        _UserProperties = null;

                    }


                }
            }
            catch
            {

            }
            return lstUserPpties;
        }


       

        public int BL_Branch_Update(int BID, String Branch_name)
        {
            int _result = 0;
            try
            {

                _result = _BranchDL.DL_Branch_Update(BID, Branch_name);

            }

            catch
            {

            }
            return _result;
        }


        public int BL_Branch_Insert(String Branch_name)
        {
            int _result = 0;
            try
            {

                _result = _BranchDL.DL_Branch_Insert(Branch_name);

            }

            catch
            {

            }
            return _result;
        }

        public int BL_Branch_Delete(int BID)
        {
            int _result = 0;
            try
            {

                _result = _BranchDL.DL_Branch_Delete(BID);

            }

            catch
            {

            }
            return _result;
        }




    }
}
