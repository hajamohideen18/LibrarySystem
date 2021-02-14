using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIb_Bussiness
{
   public class Book
    {

        private int _BID;
        private String _BookName;
        private String _Author;
        private String _Detail;
        private String _Price;
        private String _Publication;
        private String _Branch;
        private String _Quantites;
        private String _AvailableQnt;
        private String _RentQnt;
        private String _Image;
        private string _EntryDate;

        public int BID { get => _BID; set => _BID = value; }
        public string BookName { get => _BookName; set => _BookName = value; }
        public string Author { get => _Author; set => _Author = value; }
        public string Detail { get => _Detail; set => _Detail = value; }
        public string Price { get => _Price; set => _Price = value; }
        public string Publication { get => _Publication; set => _Publication = value; }
        public string Branch { get => _Branch; set => _Branch = value; }
        public string Quantites { get => _Quantites; set => _Quantites = value; }
        public string AvailableQnt { get => _AvailableQnt; set => _AvailableQnt = value; }
        public string RentQnt { get => _RentQnt; set => _RentQnt = value; }
        public string Image { get => _Image; set => _Image = value; }
        public string EntryDate { get => _EntryDate; set => _EntryDate = value; }
    }
}
