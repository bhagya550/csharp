using System;
class Program
{
    static void Main()
    {
        int[] arr = new int[100]; ;
        int size, i, j, temp;

        //Reads size of the array
        Console.WriteLine("Enter size of the array: ");
        size = Convert.ToInt32(Console.ReadLine());
        //Reads elements in array
        Console.WriteLine("Enter elements in the array: ");
        for (i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        //Sorting an array in ascending order

        for (i = 0; i < size; i++)
        {
            for (j = i + 1; j < size; j++)
            {
                //If there is a smaller element found on right of the array then swap it.
                if (arr[j] < arr[i])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        //Printing the sorted array in ascending order

        Console.WriteLine("Elements of array in sorted ascending order:");
        for (i = 0; i < size; i++)
        {
            Console.WriteLine(arr[i]);
        }
        Console.ReadLine();
    }

}
