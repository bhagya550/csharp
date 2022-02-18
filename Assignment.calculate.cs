// - create a class calculate having fields num1, num2 and methods add, sub,mul,div//


using System;
namespace calculatee
{
    class calculate
    {
        int num1;
        int num2;
        int res;


        public void addition(int num1, int num2)
        {
            res = num1 + num2;

        }
        public void displayaddi()
        {
            Console.WriteLine("addition =" + res);

        }

       public void sub(int num1, int num2)
       {
            res = num1 - num2;

        }
        public void displaysub()
        {
            Console.WriteLine("substraction =" + res);

        }

       public void multi(int num1, int num2)
        {
            res = num1 * num2;

        }
      public void displaymulti()
        {
            Console.WriteLine("multiplication =" + res);

        }

        public void division(int num1, int num2)
        {
            res = num1 / num2;

        }
        public void displaydivi()
        {
           Console.WriteLine("division =" + res);

        }

    }
    class @calculateee
    {
        static void Main()
        {
            calculate cal = new calculate();

            Console.WriteLine("enter two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());


           cal.addition(num1, num2);
           cal.displayaddi();

            cal.sub(num1, num2);
            cal.displaysub();


            cal.multi(num1, num2);
            cal.displaymulti();

            cal.division(num1, num2);
           cal.displaydivi();
            Console.ReadLine();

       }
    }
}