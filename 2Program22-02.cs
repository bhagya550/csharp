//calling base class method//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Animal
    {
        public void eat()
        {
            Console.WriteLine("eating...");
        }
    }

    public class Dog : Animal
    {
        public void eat()
        {
            base.eat(); //this will class base class method eat
            Console.WriteLine("eating bread...");
        }

    }
    public class TestBase
    {
        public static void Main()
        {
            Dog g = new Dog();
            g.eat();
        }
    }

}



