using System;

namespace Session5
{

    public class Choose
    {


        public int GetB()
        {
            int sum = 0;
            int product = 1;
            int integer, choose;

            Console.WriteLine("Please give an ineteger: ");
            integer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please type 1 if you need to compute the sum or 2 if you need to compute the product: ");
            choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                for (int i = 0; i <= integer; i++)
                {
                    sum = sum + i;
                }
                return sum;

            }
            if (choose == 2)
            {
                for (int j = 1; j <= integer +1; j++)
                {
                    product = product * j;
                }
                return product;
            }
            return integer;
            




        }
    }
}
 