using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIb_Bussiness
{
   public  class Rent
    {
        private int _RID;
        private String _BookName;
        private int _SID;
        private int _Days;
        private String _IssueDate;
        private String _ReturnDate;
        private int _Status;

        public int RID { get => _RID; set => _RID = value; }
        public string BookName { get => _BookName; set => _BookName = value; }
        public int SID { get => _SID; set => _SID = value; }
        public int Days { get => _Days; set => _Days = value; }
        public string IssueDate { get => _IssueDate; set => _IssueDate = value; }
        public string ReturnDate { get => _ReturnDate; set => _ReturnDate = value; }
        public int Status { get => _Status; set => _Status = value; }
    }
}
