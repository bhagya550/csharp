using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        //creating a user defined method displaygreeting
        //method with parameters parameters and returing no value
        static void factorial(int num)
        {
            int fact = 1;
            while (num > 0)
            {
                fact = fact * num;
                num--;
            }
            Console.WriteLine("fact = " + fact);

        }
        static void Main(string[] args)
        {
            int num = 6;
            factorial(num);
            Console.ReadLine();

        }
    }
}


