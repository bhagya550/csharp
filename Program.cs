using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(String[]args)
        {
            //wap to accept no.from the user and print square//
            int num, sq;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            sq = num * num;
            Console.WriteLine("sq=" + sq);
            Console.ReadLine();
                
        
        }
    }
}