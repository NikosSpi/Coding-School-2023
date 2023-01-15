using System;

namespace Session5
{

    public class Sort
    {


        public string GetF()
        {
            int[] array = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
            
            int reverse;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (array[i] < array[j])
                    {
                        reverse = array[i];
                        array[i] = array[j];
                        array[j] = reverse;

                    }

                }
            }
            Console.WriteLine("\narray = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 }\nWe need to sort this array.");
            foreach (int item in array)
            {
                Console.WriteLine(item);

            }

            return "This was the sorted array";




        }
    }
}

