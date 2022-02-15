//2 do while loop//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // wap to print no from 1 to 10 using while loop
            int i = 1;
            do
            {
                Console.Write("i = " + i);
                i++;
            } while (i <= 10);
            Console.ReadLine();

        }
    }
}

