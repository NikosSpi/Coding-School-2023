using Session_04;
using System.Globalization;

internal class Program
{

    public static void Main(string[] args)
    {
        // ex1 answer


        HelloName helloName = new HelloName();
        Console.WriteLine(helloName.Get());

        // ex2 answer (το αφήνω έτσι γιατί θα ήθελα άν έχουμε χρόνο αύριο να το δούμε μαζί)


        int numOne = 148;

        int numTwo = 12;

        int sum = numOne + numTwo;

        int div = numOne / numTwo;


        ExTwo exTwo = new ExTwo();
        Console.WriteLine(exTwo.GetNums());

        Console.WriteLine("The sum of the two numbers is: " + sum);
        Console.WriteLine("The division of the two numbers is: " + div);



        //ex3 Write a C# program to print the result of the specified operations

        int alfa = -1 + (5 * 6);
        Console.WriteLine("First operation: " + alfa);

        int bita = 38 + (5 % 7);
        Console.WriteLine("Second operation: " + bita);

        int gamma = 14 + (-3 * 6) / 7;
        Console.WriteLine("Third operation: " + gamma);

        double x = 7;
        double z = Math.Sqrt(x);
        double delta = 2 + (13 / 6) * 6 + z;
        Console.WriteLine("Fourth operation: " + delta);

        double a = 6;
        double b = 5;
        double c = Math.Pow(a, 4);
        double d = Math.Pow(b, 7);
        double thita = (c + d) / (9 % 4);
        Console.WriteLine("Fifth operation: " + thita);

        /*ex4 C# program that assigns an age (number) (for example 20) and 
         a gender(string) (for example female) and displays something like: 
         "You are female and look younger than 20." */

        string sex = "female";
        int age = 23;
        Console.WriteLine("You are " + sex + " and look younger than " + age + ".");

        /* ex5 Write a C# program that takes an integer representing seconds (for 
           example 45678) and converts it to : minutes, hours, days, years */

        int seconds = 45678;

        int minutes = seconds / 60;
        Console.WriteLine("The seconds converted to minutes are: " + minutes);

        int hours = minutes / 60;
        Console.WriteLine("The seconds converted to hours are: " + hours);

        double days = hours / (double) 24;
        Console.WriteLine("The seconds converted to days are: " + days);

        double years = days / (double) 365;
        Console.WriteLine("The seconds converted to years are: " + years);

        // ex6 Rewrite Program #5 using .Net Libraries.


        DateTime dt1 = DateTime.UtcNow;
        DateTime dt2 = DateTime.UtcNow.AddSeconds(45678);
        TimeSpan tp;
        tp = dt2 - dt1;
        Console.WriteLine("The seconds converted to minutes are: " + tp.TotalMinutes);
        Console.WriteLine("The seconds converted to hours are: " + tp.TotalHours);
        Console.WriteLine("The seconds converted to days are: " + tp.TotalDays);
        Console.WriteLine("The seconds converted to years are: " + (tp.TotalDays/365));



        /* ex7 Write a C# program to convert from celsius degrees to Kelvin and 
           Fahrenheit. */

        double celsius = 20;

        double kelvin = celsius + 273.15;
        Console.WriteLine("The temperature is: " + kelvin + " Kelvin");

        double f = celsius / (double)5;
        double fahrenheit = (f * 9) + 32;
        Console.WriteLine("The temperature is: " + fahrenheit + " Fahrenheit");





















        Console.ReadLine();




    }
}