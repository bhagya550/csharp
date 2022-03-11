using System;
class Program
{
    static void Main()
    {
        int[] arr = new int[100];
        int i, num, size, position;

        // Reading array size & elements in the array
        Console.WriteLine("Enter size of the array: ");
        size = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter elements in the array: ");
        for (i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        //Reading element to insert & position of the element

        Console.WriteLine("Enter element to insert: ");
        num = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the element position: ");
        position = Convert.ToInt32(Console.ReadLine());

        //checking elements valis position

        if (position > size + 1 || position <= 0)
        {
            Console.WriteLine("Invalid position! Please enter position between 1 to " + num);
        }
        else
        {
            //Inserting element in an array & increasing the size of the array

            for (i = size; i >= position; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[position - 1] = num;
            size++;

            // Printing new array with new element

            Console.WriteLine("Array elements after insertion :");

            for (i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i] + "\t");
            }
        }

        Console.ReadLine();
    }

}
 