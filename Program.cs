using System;
    
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // wap to print no from 1 to 10 using while loop
            int i, j;
            for (i = 1; i < 10; i++)
            {
                for (j = 1; j < i; j++)
                {
                    Console.Write(j + "\t");
                }
                Console.WriteLine();

            }
            Console.ReadLine();

        }
    }
}
