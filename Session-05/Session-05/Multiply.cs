using System;

namespace Session5
{

    public class Multiply
    {


        public string GetD()
        {
            int[] array1 = { 2, 4, 9, 12 };
            int[] array2 = { 1, 3, 7, 10 };
            int[] arrayTotal = new int[16];
            int t = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
             
                    arrayTotal[t] = array1[i] * array2[j];
                    t++;

                }
            }
            Console.WriteLine("array1 = { 2, 4, 9, 12 }\nArray2 = { 1, 3, 7, 10 }\nThe numbers of new array are: ");
            foreach (int item in arrayTotal)
            {
                Console.WriteLine(item);

            }

            return "These was the numbers of the 2 multiplied arrays\n";




        }
    }
}
