using Session5;
using System.Collections.Generic;
using System.Globalization;

internal class Program
{

    public static void Main(string[] args)
    {
        /* 1. Write a C# program that reverses a given string (your name). */

        Reverse reverse = new Reverse();

        Console.WriteLine("The reversed name is: " +reverse.Get());

        

        /* 2. Write a C# program that asks the user for an integer (n) and gives them
        the possibility to choose between computing the sum and computing
        the product of 1,…,n. */

        Choose choose = new Choose();

        Console.WriteLine("\nThe result is: " +choose.GetB());


        /* 3.Write a C# program that asks the user for an integer (n) and finds all 
        the prime numbers from 1 to n. */

        Prime prime = new Prime();
        Console.WriteLine(prime.GetC());

        /* 4. Write a C# program to multiply all values from Array1 with all values 
        from Array2 and display the results in a new Array. */

        Multiply multiply = new Multiply();
        Console.WriteLine(multiply.GetD());

        /*5. Write a C# program to sort the given array of integers from the lowest 
        to the highest number.*/

        Sort sort = new Sort();
        Console.WriteLine(sort.GetF());


        Console.ReadLine();

    }
}