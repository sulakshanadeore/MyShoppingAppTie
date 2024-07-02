using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class ElectronicProducts:Products
    {
        public int Watt { get; set; }

        public int Rating { get; set; }

        public new DateTime   CalculateValidity(int duration)
        
        {

            //int y= MfgDate.Year + Noyrs;
            //return MfgDate.Day + MfgDate.Month + y;

            return MfgDate.AddYears(duration);

        }

    }
}
