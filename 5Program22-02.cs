﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Person
    {
        public String name;
        public String address;
    }
    public class Student : Person
    {
        public int rno;
        public int marks;
    }
    class TestInheritance
    {
        public static void Main(string[] args)
        {
            Student p1 = new Student();//creating object of child class\
            p1.rno = 123;
            p1.name = "amitabh";
            p1.address = "mumbai";
            p1.marks = 888;

            Console.WriteLine("rno: " + p1.rno);
            Console.WriteLine("name: " + p1.name);
            Console.WriteLine("address: " + p1.address);
            Console.WriteLine("marks: " + p1.marks);

        }
    }

}

