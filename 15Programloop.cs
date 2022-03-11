using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class csharpExercise
{
    static void Main(string[] args)
    {
        int num, sum = 0, i, r;

        // Reading number
        Console.Write("Please enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        //Finding armstrong number or not
        for (i = num; i > 0; i = i / 10)
        {
            r = i % 10;
            sum = sum + r * r * r;
        }

        if (num == sum)
        {
            Console.WriteLine(num + " is an armstrong number.");
        }
        else
        {
            Console.WriteLine(num + " is not an armstrong number.");
        }

        Console.ReadLine();
    }
}