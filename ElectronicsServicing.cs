using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{

    public class WearableServicing : ElectronicsServicing
    {
        public override  DateTime CalculateValidity(int duration)
        {

            DateTime ep=base.CalculateValidity(duration);


            DateTime dt1=MfgDate.AddYears(-duration);
            return dt1;
        }


    }


    public class ElectronicsServicing:ElectronicProducts
    {
        public virtual DateTime CalculateValidity(int duration)
        {

            //int y= MfgDate.Year + Noyrs;
            //return MfgDate.Day + MfgDate.Month + y;

            DateTime dt=base.CalculateValidity(duration);
            DateTime ServicingValidTill;
            if (dt.Year>2002) 
            {
                ServicingValidTill=dt.AddYears(duration);
            
            }
            else
            {
                ServicingValidTill = base.MfgDate;
            }

            return ServicingValidTill;

        }
    }
}
