using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[4]; //creating an array of 4elements
            arr[0] = 11;
            arr[1] = 22;
            arr[2] = 33;
            arr[3] = 44;
            //using for loop 
            for (int i = 0; i < 4; i++)
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