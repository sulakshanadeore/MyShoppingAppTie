using EntityLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace MyAmazonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BoxingUnboxingDemo();

            //WorkingWithMethodsToAcceptAndDisplayData();

            Employee emp = new Employee("Anita", 10,80000d);
            Console.WriteLine(emp.FirstName);
            Console.WriteLine(emp.Deptno);
            Console.WriteLine(emp.Salary);


            ElectronicProducts p=new ElectronicProducts();
            //Console.WriteLine("Enter productid ");
            //p.ProductID = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter name");
            //p.ProductName = Console.ReadLine();
            //Console.WriteLine("Enter price");
            //p.Price = Convert.ToInt64(Console.ReadLine());
            //Console.WriteLine("Etner status");
            //p.ProductStatus = Convert.ToChar(Console.ReadLine());

            //Console.WriteLine("Whether available");
            //p.Availability = Convert.ToBoolean(Console.ReadLine());
          //  Console.WriteLine("Enter Manufacturing Date");
            //p.MfgDate = Convert.ToDateTime(Console.ReadLine());

            //Console.WriteLine("Enter watt capacity");
            //p.Watt = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Manufacture Date:" + p.MfgDate );
            //Console.WriteLine($"Manufacture Date:  {p.MfgDate}");

            //DateTime validTill=p.CalculateValidity(10);
            //Console.WriteLine(validTill);


            WearableServicing es=new  WearableServicing();
            es.MfgDate = DateTime.Now;
            DateTime serviceValidity=es.CalculateValidity(10);
            Console.WriteLine(serviceValidity);
            Console.ReadLine();



        }

        private static void WorkingWithMethodsToAcceptAndDisplayData()
        {
            Console.WriteLine("Enter customer name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter city");
            string city = Console.ReadLine();
            Console.WriteLine("Enter age");
            int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter latitude");
            //short lat=Convert.ToInt16(Console.ReadLine());


            Customer c = new Customer(name, city, age);

            c.PrintData();
        }

        private static void BoxingUnboxingDemo()
        {
            int i = 10;
            object o;
            o = i;
            Console.WriteLine(o);
            int j;
            j = (int)o;
        }
    }
}


