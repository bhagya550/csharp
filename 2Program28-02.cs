//example of arrayth method//
using System;
using System.Collections;
namespace ConsoleApp6
{

    class Program
    {

        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(11);
            ar.Add(12);
            ar.Add(13);
            //displaying values of arraylist
            foreach (int obj in ar)
            {
                Console.WriteLine("student rno " + obj);
            }


            Console.WriteLine("Capacity: {0} ", ar.Capacity);
            Console.WriteLine("Count: {0}", ar.Count);



        }
    }
}
