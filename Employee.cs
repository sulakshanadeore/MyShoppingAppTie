using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Employee
    {

        private string _fname;
        public string FirstName 
        {
            get { return _fname; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Not allowed");

                }
                else
                {


                    _fname = value;
                }
            }
        }

        private int _deptno;
        public int Deptno 
        {
            get { return _deptno; }
            set { _deptno = value; }    
        }


        public double Salary 
        {
            set;
            get;
        
        }




        public Employee()
        {
            
        }
        public Employee(string fname,int deptno,double sal)
        {
            FirstName = fname;
            Salary = sal;
            Deptno=deptno;

        }
    }
}
