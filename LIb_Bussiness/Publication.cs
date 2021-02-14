using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIb_Bussiness
{
   public class Publication
    {
        private int _PID;
        private String _PublicationName;
        private String _EntryDate;

        public int PID { get => _PID; set => _PID = value; }
        public string PublicationName { get => _PublicationName; set => _PublicationName = value; }
        public string EntryDate { get => _EntryDate; set => _EntryDate = value; }
    }
}
