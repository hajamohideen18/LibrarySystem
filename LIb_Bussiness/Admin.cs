using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIb_Bussiness
{
   public  class Admin
    {
        private int _AID;
        private String _NAME;
        private String _UserName;
        private String _Password;
        private String _entryDate;
     
        public int AID { get => _AID; set => _AID = value; }
        public string NAME { get => _NAME; set => _NAME = value; }
        public string UserName { get => _UserName; set => _UserName = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string EntryDate { get => _entryDate; set => _entryDate = value; }
    }
}
