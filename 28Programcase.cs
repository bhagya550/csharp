using System;

class Program
{

    static void Main(string[] args)
    {

        char gender;

        //Reading gender from user
        Console.WriteLine("Enter gender (M/m or F/f): ");
        gender = Convert.ToChar(Console.ReadLine());


        // checking vowel and consonant
        switch (gender)
        {
            case 'M':
            case 'm':
                Console.WriteLine("MALE");
                break;

            case 'F':
            case 'f':
                Console.WriteLine("FEMALE");
                break;

            default:
                Console.WriteLine("Unspecified Gender");
                break;
        }

        Console.ReadLine();

    }

}
