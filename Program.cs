//11 example of methods or function in csharp
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
        //method with no parameters and returing no value
        static void displaygreetings()
        {
            Console.WriteLine("happy birthdday");
        }
        static void Main(string[] args)
        {

            displaygreetings();
            Console.ReadLine();

        }
    }
}

