using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Customer
    {
        string _custname,_custcity;
        int _age;
        public Customer()
        {
                
        }

        public Customer(string custname,string city,int age)
        {
            this._custname = custname;
            this._custcity = city;
            this._age = age;
        }

        public void PrintData()
        {

            Console.WriteLine(this._custname);
            Console.WriteLine(this._custcity);
            Console.WriteLine(this._age);
        }

    }
}
