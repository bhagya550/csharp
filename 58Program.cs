﻿using System;

class functionexcercise
{
    static void Main()
    {
        decimal fact;
        Console.Write("Enter a number : ");
        int num = Convert.ToInt32(Console.ReadLine());
        fact = Factorial(num);
        Console.WriteLine("The factorial of number {0} is  {1}", num, fact);
        Console.ReadLine();
    }
    static decimal Factorial(int n1)
    {
        // The bottom of the recursion
        if (n1 == 0)
        {
            return 1;
        }
        // Recursive call: the method calls itself
        else
        {
            return n1 * Factorial(n1 - 1);
        }
    }
}