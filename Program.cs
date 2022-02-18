using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp2
{
    class Employee
    {
        int empno;
        string empname;
        float salary;
        //creating methods
        public void getdata()
        {
            Console.WriteLine("enter employee no");
            empno = Convert.ToInt32(Console.ReadLine());
            empname = Console.ReadLine();
            Console.WriteLine("enter emplyee name");
            empname = Console.ReadLine();
            Console.WriteLine("enter employee salary");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        public void displaydata()
        {
            Console.WriteLine("empno" + empno);
            Console.WriteLine("empname" + empname);
            Console.WriteLine("salary" + salary);

        }

    }
    class program
    {
        static void Main()
        {
            Employee emp = new Employee();
            emp.getdata();
            Console.ReadLine();

        }
    }
}