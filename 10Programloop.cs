using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class csharpExercise
{
    static void Main(string[] args)
    {

        int num, last;

        // Reading number
        Console.Write("Enter any number: ");
        num = Convert.ToInt32(Console.ReadLine());

        last = num % 10;
        Console.WriteLine("The last digit of entered number: " + last);

        while (num >= 10)
        {
            num = num / 10;
        }

        Console.WriteLine("The first digit of entered number: " + num);

        Console.ReadLine();
    }
}
