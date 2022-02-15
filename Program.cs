using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(String[] args)
        {
            //wap to accept 2no. and display addition of two no.//
            int num1, num2, res;
            Console.WriteLine("enter number1");


            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2");


            num2 = Convert.ToInt32(Console.ReadLine());
            res = num1 + num2;
            Console.WriteLine("addition="+res);
            Console.ReadLine();







        }
    }
}