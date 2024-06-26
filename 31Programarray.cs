﻿using System;

namespace Program
{
    class twodmatrix
    {
        int p, r;
        int[,] a;
        int[] b;
        twodmatrix(int x, int y)
        {
            p = x;
            r = y;
            a = new int[p, r];
            b = new int[p * r];
        }
        public void readmatrix()
        {
            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    Console.Write("a[{0},{1}]=", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void printtwodimentionalarray()
        {
            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    Console.Write("{0}\t", a[i, j]);

                }
                Console.Write("\n");
            }
        }
        public void convert()
        {
            int k = 0;
            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    b[k++] = a[i, j];
                }
            }
        }
        public void printonedimentionalarray()
        {
            for (int i = 0; i < p * r; i++)
            {
                Console.WriteLine("{0}\t", b[i]);
            }
        }


        public static void Main(string[] args)
        {
            twodmatrix obj = new twodmatrix(2, 3);
            Console.WriteLine("Enter the Elements : ");
            obj.readmatrix();
            Console.WriteLine("\nGiven 2-D Array() is : ");
            obj.printtwodimentionalarray();
            obj.convert();
            Console.WriteLine("\nConverted 1-D Array is : ");
            obj.printonedimentionalarray();
            Console.ReadLine();
        }
    }
}
