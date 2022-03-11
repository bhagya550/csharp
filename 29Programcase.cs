using System;

class Program
{

    static void Main(string[] args)
    {

        int num1 = 0, num2 = 0;

        //Reading two numbers from user
        Console.WriteLine("Enter two numbers to find maximum number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());

        // Condition to check maximum number

        switch (num1 > num2)
        {
            case true:
                Console.WriteLine(num1 + " is Maximum number");
                break;

            case false:
                Console.WriteLine(num2 + " is Maximum number");
                break;

        }

        Console.ReadLine();

    }

}

