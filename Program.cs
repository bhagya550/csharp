//accept the value from users//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp2
{
     class Employee
    {
        public int empno;
        public string empname;

        public float salary;

    }
    class program
    {
        static void Main()
        {
            //creating an object (instance) of employee class
            //syntax classname objectname=new classname();
            Employee emp = new Employee();
            Console.WriteLine("enter employee no");
            emp.empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee name");
            emp.empname=Console.ReadLine();
            Console.WriteLine("enter employee salary");
            emp.salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("empno"+emp.empno);
            Console.WriteLine("empname" + emp.empname);
            Console.WriteLine("salary" + emp.salary);
            Console.ReadLine();

                
                
        }

    }
}