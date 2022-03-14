using System;
class Program
{
    static void Main()
    {


        int[] array = new int[100];
        int size, i;


        //Reads size of the array
        Console.WriteLine("Enter size of the array: ");
        size = Convert.ToInt32(Console.ReadLine());

        //Reads elements in array
        Console.WriteLine("Enter elements in array: ");
        for (i = 0; i < size; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        //Print array in reversed order
        Console.WriteLine("\nArray in reverse order: ");
        for (i = size - 1; i >= 0; i--)
        {
            Console.Write("\t" + array[i]);
        }

        Console.ReadLine();
    }

}

