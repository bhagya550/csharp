﻿using System;
public class program
{
    public static void Main()
    {
        int num, i, j = 0, lrg, lrg2nd;
        int[] arr1 = new int[50];

        Console.Write("Input the size of array : ");
        num = Convert.ToInt32(Console.ReadLine());

        //Stored values into the array
        Console.Write("Input {0} elements in the array :\n", num);
        for (i = 0; i < num; i++)
        {
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }
        // find location of the largest element in the array 
        lrg = 0;

        for (i = 0; i < num; i++)
        {
            if (lrg < arr1[i])
            {
                lrg = arr1[i];
                j = i;
            }
        }
        // ignore the largest element and find the 2nd largest element in the array 
        lrg2nd = 0;
        for (i = 0; i < num; i++)
        {
            if (i == j)
            {
                i++;  //ignoring the largest element 
                i--;
            }
            else
            {
                if (lrg2nd < arr1[i])
                {
                    lrg2nd = arr1[i];
                }
            }
        }

        Console.Write("The Second largest element in the array is :  {0} \n\n", lrg2nd);
        Console.ReadLine();
    }
}
