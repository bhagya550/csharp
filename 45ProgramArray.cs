﻿using System;
class Program
{
    public void sumAverageElements(int[] arr, int size)
    {

        int sum = 0;
        int average = 0;
        for (int i = 0; i < size; i++)
        {
            sum += arr[i];
        }
        average = sum / size;
        Console.WriteLine("Sum Of Array is : " + sum);
        Console.WriteLine("Average Of Array is : " + average);
        Console.ReadLine();
    }
    public static void Main(string[] args)
    {
        int size;
        Console.WriteLine("Enter the Size :");
        size = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine("Enter the Elements of the Array : ");
        for (int i = 0; i < size; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        int len = a.Length;
        Program p = new Program();
        p.sumAverageElements(a, len);
    }

}
