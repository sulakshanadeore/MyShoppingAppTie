using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class WearableProducts:ElectronicProducts
    {
        public string Color { get; set; }
        public new DateTime CalculateValidity(int duration)
        {
            DateTime dt;
                 
            if (duration > 10) {
            
            dt=base.CalculateValidity(duration);
            }
            else  {

               dt=base.MfgDate.AddDays(duration);
            }

            return dt;
        }


    }
}
