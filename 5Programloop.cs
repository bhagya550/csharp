using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class csharpExercise
{
    static void Main(string[] args)
    {

        int num, total;

        //Reading number
        Console.WriteLine("Enter any number: ");
        num = Convert.ToInt32(Console.ReadLine());

        //Adding sum of digit in total variable
        for (total = 0; num > 0; num = num / 10)
            total = total + (num % 10);

        //Printing sum of digit
        Console.WriteLine("Sum of digits: " + total);

        Console.ReadLine();
    }
}