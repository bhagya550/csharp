//Example of array list//
using System;
using System.Collections;
namespace ConsoleApp6
{

    class Program
    {

        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("amit");
            ar.Add("raj");
            ar.Add("dilip");
            //displaying values of arraylist
            foreach (Object obj in ar)
            {
                Console.WriteLine("student name " + obj);
            }





        }
    }
}

