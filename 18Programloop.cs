﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class csharpExercise
{
    static void Main(string[] args)
    {
        int num, i, f;

        /*Reading number      
         */

        Console.Write("Enter any number: ");
        num = Convert.ToInt32(Console.ReadLine());

        f = 0;
        i = 2;
        while (i <= num / 2)
        {
            if (num % i == 0)
            {
                f = 1;
                break;
            }
            i++;
        }
        if (f == 0)
            Console.WriteLine(num + " is a Prime Number");
        else
            Console.WriteLine(num + " is not a Prime Number");


        Console.ReadLine();
    }
}
