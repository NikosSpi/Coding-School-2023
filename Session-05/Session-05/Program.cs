using Session5;

using System.Globalization;

internal class Program
{

    public static void Main(string[] args)
    {
        /* 1. Write a C# program that reverses a given string (your name). */

        Reverse reverse = new Reverse();

        Console.WriteLine(reverse.Get());

        

        /* 2. Write a C# program that asks the user for an integer (n) and gives them
        the possibility to choose between computing the sum and computing
        the product of 1,…,n. */

        Choose choose = new Choose();

        Console.WriteLine(choose.GetB());

        Console.ReadLine();


    }
}