﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class csharpExercise
{
    static void Main(string[] args)
    {
        float amount, rate, intrest, time, ci, a;

        /*Reading amount, rate of intrest
        and period in years from user
        */

        Console.Write("Type the amount : ");
        amount = Convert.ToInt32(Console.ReadLine());

        Console.Write("Type the interest rate : ");
        rate = Convert.ToInt32(Console.ReadLine());

        Console.Write("Type the period in years: ");
        time = Convert.ToInt32(Console.ReadLine());

        intrest = 1 + (rate / 100);

        // ci=pow(intrest,time);
        ci = 1;
        for (a = 1; a <= time; a++)
            ci = ci * intrest;

        ci = amount * ci - amount;

        Console.WriteLine("Your compound interest is : " + ci);



        Console.ReadLine();
    }
}
