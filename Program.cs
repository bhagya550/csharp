﻿//int and uint//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace program11
{
    class Class1
    {
        public static void Main()
        {
            int b = -25890;//signed
            Console.WriteLine("value"+b);
            Console.WriteLine("enter");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("value=" + b);
            //for negative as well as positive//
            uint b1 = 2389000;//unsigned
            Console.WriteLine("enter");
            b1 = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("value=" + b1);

        }
    }
}