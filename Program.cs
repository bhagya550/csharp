using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp
{
    class Book
    {
        int Bookid;
        string title, author;
        int price;
        //creating a constructor with no. parameters
        public Book()
        {
            Bookid = 1;
            title = "Oracle";
            author = "jemes";
            price = 200;
        }
        public void display()
        {
            Console.WriteLine("book id=" + Bookid);
            Console.WriteLine("book title=" + title);
            Console.WriteLine("book author=" + author);
            Console.WriteLine("price=" + price);
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            Book B = new Book();//this will call constructor automatically
            B.display();
            Console.ReadLine();

        }
    }
}