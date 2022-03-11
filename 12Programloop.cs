using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class csharpExercise
{
    static void Main(string[] args)
    {

        int num, rev = 0;

        // Reading number
        Console.Write("Enter any number: ");
        num = Convert.ToInt32(Console.ReadLine());

        //finding reverse number using while loop
        while (num > 0)
        {
            rev = rev * 10;
            rev = rev + num % 10;
            num = num / 10;
        }

        Console.Write("Reversed number is = " + rev);

        Console.ReadLine();
    }
}