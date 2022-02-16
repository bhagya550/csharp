//20 - example of local and shared variable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        //class level variable
        static int fact = 5; //shared variable
        static void factorial()
        {
            int fact = 1; // local variable 
            Console.WriteLine("value of fact local varialbe inside method " + fact);



        }
        static void Main(string[] args)
        {


            factorial();
            Console.WriteLine("fact inside main  = {0}", fact);
            Console.ReadLine();

        }
    }
}



