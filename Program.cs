//create a class employee having fiels empno,empname,and salary//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp
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
            //creating an ob]ect (instance) of employee class
            //syntax classname objectname=new classname();
            Employee emp = new Employee(1);
            emp.empname = "sahil";
            emp.salary = 12345.2f;
            Console.WriteLine("empno" + emp.empno);
            Console.WriteLine("empname" + emp.empname);
            Console.WriteLine("salary" + emp.salary);
            Console.ReadLine();
        }

    }
}