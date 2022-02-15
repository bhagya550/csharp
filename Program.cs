using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(String[] args)
        {
            //wap to accept 3 no. and display addition of 3 no.//
            int num1, num2, num3, res;
            Console.WriteLine("enter number1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number3");
            num3 = Convert.ToInt32(Console.ReadLine());
            res = num1 + num2 + num3;
            Console.WriteLine("addition=" + res);
            Console.ReadLine();
        }
    }
}






