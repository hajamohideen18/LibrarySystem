using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIb_Bussiness
{
   public  class Student
    {
		private int _SID;
		private String _STUDENTNAME ;
	private String _BRANCHNAME ;
	 private String _MOBILE ;
	 private String _ADD ;
	 private String _CITY ;
	 private String _PINCODE ;
	private String _DOB ;
	private String _GENDER ;
	 private String _EMAIL ;
	private String _pass ;
	private String _img;

		public string STUDENTNAME { get => _STUDENTNAME; set => _STUDENTNAME = value; }
		public string BRANCHNAME { get => _BRANCHNAME; set => _BRANCHNAME = value; }
		public string MOBILE { get => _MOBILE; set => _MOBILE = value; }
		public string ADD { get => _ADD; set => _ADD = value; }
		public string CITY { get => _CITY; set => _CITY = value; }
		public string PINCODE { get => _PINCODE; set => _PINCODE = value; }
		public string DOB { get => _DOB; set => _DOB = value; }
		public string GENDER { get => _GENDER; set => _GENDER = value; }
		public string EMAIL { get => _EMAIL; set => _EMAIL = value; }
		public string Pass { get => _pass; set => _pass = value; }
		public string Img { get => _img; set => _img = value; }
		public int SID { get => _SID; set => _SID = value; }
	}
}
