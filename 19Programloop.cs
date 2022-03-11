using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class csharpExercise
{
    static void Main(string[] args)
    {
        int num, i, rev;

        // Reading a number from user
        Console.Write("Enter any number: ");
        num = Convert.ToInt32(Console.ReadLine());

        rev = num;
        for (i = 0; num > 0; num = num / 10)
        {
            i = i * 10;
            i = i + (num % 10);
        }

        //Checking if reverse number is equal to original num or not.
        if (rev == i)
            Console.WriteLine(rev + " is a Palindrome Number.");
        else
            Console.WriteLine(rev + " is not a Palindrome Number.");


        Console.ReadLine();
    }
}

