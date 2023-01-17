using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{

    
    public class ActionResolver
    {

        // PROPERTIES
        public MessageLogger Logger { get; set; }

        // CTOR
        public void ActionResolver(ActionEnum actionEnum, int number)
        {
        }

        //METHODS
          
          public int Convert(int number) {

            int n, i;
                    int[] a = new int[10];
                    Console.WriteLine("Enter the number to convert: ");
                    n = int.Parse(Console.ReadLine());
                    for (i = 0; n > 0; i++)
                    {
                        a[i] = n % 2;
                        n = n / 2;
                    }
                    Console.Write("Binary of the given number= ");
                    for (i = i - 1; i >= 0; i--)
                    {
                        Console.WriteLine(a[i]);
                    }

            return 0;
          }
        public string Upper(string phrase)
        {
            Console.WriteLine("Give your phrase");
            string phrase = Console.ReadLine();
            string upperCase = phrase.ToUpper();
            Console.WriteLine(upperCase);

            return upperCase;
            
        }
        public string Reverse(string input)
        {
                Console.WriteLine("Give your input");
                string input = Console.ReadLine();
                string namereversed = "";
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    namereversed = namereversed + input[i];

                }


                return namereversed;
        }
        /*public ActionResponse Execute(ActionRequest request)
        {


            return null;
        }
        */

    }
}
