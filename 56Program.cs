using System;

class functionexcercise
{
    public static int Fibonaccisequence(int number)
    {
        int num1 = 0;
        int num2 = 1;

        for (int i = 0; i < number; i++)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp + num2;
        }
        return num1;
    }
    public static void Main()
    {
        Console.Write("Enter a number : ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The Fibonacci series of " + num + " numbers is :");
        for (int i = 0; i < num; i++)
        {
            Console.Write(Fibonaccisequence(i) + "  ");
        }
        Console.ReadLine();
    }
}

