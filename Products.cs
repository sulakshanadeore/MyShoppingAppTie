using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Products
    {

		private int _prodid;

		public int ProductID
		{
			get { return _prodid; }
			set { _prodid = value; }
		}

		private string _prodname;

		public string ProductName
		{
			get { return _prodname; }
			set { _prodname = value; }
		}

        public long Price { get; set; }
		public string Description { get; set; }

        public char ProductStatus { get; set; }
        public bool Availability { get; set; }

        public DateTime  MfgDate { get; set; }

		public DateTime CalculateValidity(int duration)
		{

			//int y= MfgDate.Year + Noyrs;
			//return MfgDate.Day + MfgDate.Month + y;
			return MfgDate.AddMonths(duration);
		
		}


    }
}
