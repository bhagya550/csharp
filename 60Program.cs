﻿using System;

class Program
{
    public static void Main(string[] args)
    {
        int num;
        program p = new program();
        Console.WriteLine("Enter a decimal number: ");
        num = int.Parse(Console.ReadLine());
        Console.Write("The binary equivalent of num is :");
        p.binaryconversion(num);
        Console.ReadLine();
    }
}
public class program
{
    public int binaryconversion(int num)
    {
        int bin;
        if (num != 0)
        {
            bin = (num % 2) + 10 * binaryconversion(num / 2);
            Console.Write(bin);
            return 0;
        }
        else
        {
            return 0;
        }

    }
}