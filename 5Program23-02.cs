﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Account
    {
        public int actno;
        public int balance = 1000;

        public virtual String deposit(int actno, int amount)
        {
            return "deposit method of account class";
        }
        public String showbalance()
        {
            return "balance amount : " + balance;
        }
    }

    class Current : Account
    {
        //overriding the base class deposit method
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            return "amount deposited successfully in current class";
        }
    }
    public class TestBase
    {
        public static void Main()
        {
            //runtime polymorphism : base class reference variable having instance of derieved class current
            Account act = new Current();
            Console.WriteLine("enter account no ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter amount to be deposited ");
            int amount = Convert.ToInt32(Console.ReadLine());

            String res = act.deposit(actno, amount);
            Console.WriteLine("account no is " + act.actno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);

        }
    }

}

