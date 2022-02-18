using System;
namespace circle
{
    class circle
    {
        float radius;
        float area;
        float circ;

        public void areaa(float radius)
                {
           area = 3.14f * radius * radius;
        }
        public void displayarea()
        {
            Console.WriteLine("area of circle =" + area);
        }

        public void circum(float radius)
        {
            circ = 2 * 3.14f * radius;
        }
        public void displayacirc()
        {
            Console.WriteLine("circle of circumference =" + circ);
        }
    }
    class @circlee
    {
        static void Main()
        {
            circle cir = new circle();
           Console.WriteLine("enter radius");
            float radius = Convert.ToSingle(Console.ReadLine());

           cir.areaa(radius);
            cir.displayarea();
            cir.circum(radius);
            cir.displayacirc();

            Console.ReadLine();

       }

    }
}