using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIb_Bussiness
{
   public class Branch
    {
        private int _BranchID;
        private String _BranchName;

        public int BranchID { get => _BranchID; set => _BranchID = value; }
        public string BranchName { get => _BranchName; set => _BranchName = value; }
    }
}
