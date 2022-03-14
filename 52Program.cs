using System;

public class functionexcercise
{
    public static int Countspaces(string str)
    {
        int spcctr = 0;
        string strone;
        for (int i = 0; i < str.Length; i++)
        {
            strone = str.Substring(i, 1);
            if (strone == " ")
                spcctr++;
        }
        return spcctr;
    }
    public static void Main()
    {
        string strtwo;
        Console.Write("Please Enter a string : ");
        strtwo = Console.ReadLine();
        Console.WriteLine("\"" + strtwo + "\"" + " contains {0} spaces", Countspaces(strtwo));
        Console.ReadLine();
    }
}