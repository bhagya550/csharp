using System;

class Program
{

    static void Main(string[] args)
    {

        int num;

        //Reading a number from user
        Console.Write("Enter any number to check even or odd: ");
        num = Convert.ToInt32(Console.ReadLine());

        switch (num % 2)
        {
            //If n%2 == 0
            case 0:
                Console.WriteLine(num + " is even number");
                break;

            //Else if n%2 == 1
            case 1:
                Console.WriteLine(num + " is odd number");
                break;
        }
        Console.ReadLine();

    }

}
