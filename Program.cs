using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp5
{
    public class Program
    { 
        static void Main(String[]args)
    {
        //wap to accept radius and print area of circle//
        int radius;
        float area, circ;
        Console.WriteLine("enter radius ");
        radius = Convert.ToInt32(Console.ReadLine());
        area = (float)3.14 * radius * radius;
        circ = (float)2 * 3.14f * radius;
        Console.WriteLine("area" + area);
        Console.WriteLine("circ" + circ);
        Console.WriteLine();

    }

}
}