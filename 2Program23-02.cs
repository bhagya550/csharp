//C# Runtime Polymorphism Example//

//Let's see a another example of runtime polymorphism in C# where we are having two derived classes.//

    using System;  
    public class Shape
{
    public virtual void draw()
    {
        Console.WriteLine("drawing...");
    }
}
public class Rectangle : Shape
{
    public override void draw()
    {
        Console.WriteLine("drawing rectangle...");
    }

}
public class Circle : Shape
{
    public override void draw()
    {
        Console.WriteLine("drawing circle...");
    }

}
public class TestPolymorphism
{
    public static void Main()
    {
        Shape s;
        s = new Shape();
        s.draw();
        s = new Rectangle();
        s.draw();
        s = new Circle();
        s.draw();

    }
}

