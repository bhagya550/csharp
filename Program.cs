using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[3]; //creating an array of 3 elements
            arr[0] = 22;
            arr[1] = 44;
            arr[2] = 66;
            //using for loop 
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("arr = " + arr[i]);
            }
            //for each loop
            //syntax foreach (datatype variable in arrayname) { //code }
            foreach (int i in arr)
            {
                Console.WriteLine("arr = " + i);
            }
            Console.ReadLine();
        }
    }
}

