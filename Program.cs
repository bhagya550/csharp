//7 - create a integer array of  3 elements and display the elements using for loop
 // and foreach loop
  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[3]; //creating an array of 3 elements
            arr[0] = 11;
            arr[1] = 22;
            arr[2] = 33;
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
