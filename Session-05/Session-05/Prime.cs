using System;
using System.Collections.Generic;

namespace Session5
{

    public class Prime
    {


        public string GetC()
        {
            int divisors = 0;
            int integer;

            Console.WriteLine("Please give an integer to find the prime numbers: ");
            integer = Convert.ToInt32(Console.ReadLine());

            List<int> numbers = new List<int>();

            for (int j = 1; j <= integer; j++)
            {
                divisors = 0;
                for (int i = 1; i <= j; i++)
                {
                    if (j % i == 0)
                    {
                        divisors++;
                    }

                }
                if (divisors == 2)
                {
                    numbers.Add(j);
                }


            }

            foreach (int item in numbers)
            {
                Console.WriteLine("prime number: " + item);
            }

            return "these are all the prime numbers";

        }
    }
}
