//10 example of break and continue
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
            int i = 0;
            while (true)
            {
                Console.WriteLine(i);
                i++;
                if (i <=20)
                    continue;
                else
                    break;
            }

            Console.ReadLine();

        }
    }
}

