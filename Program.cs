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
            // wap to print no from 2 to 20 using while loop
            int i, j;
            for (i = 2; i < 10; i++)
            {
                for (j = 2; j <= 20; j++)
                {
                    Console.Write(j + "\t");
                }
                Console.WriteLine();

            }
            Console.ReadLine();

        }
    }
}
