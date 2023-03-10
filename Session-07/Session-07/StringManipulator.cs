using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{


    public class StringManipulator
    {

        public string Text { get; set; }

        public virtual string Manipulate()
        {

            return string.Empty;
        }

    }

    public class StringConvert : StringManipulator
    {


        public override string Manipulate()
        {
            // “Convert” you must check if the Input is a decimal number and convert it to binary.
            int n, i;
            int[] a = new int[10];
            string newNumber = "noInt";
            if (int.TryParse(Text, out n))
            {
                newNumber = "";
               n = int.Parse(Text);

                for (i = 0; n > 0; i++)
                {
                    a[i] = n % 2;
                    n = n / 2;
                }

                for (i = i - 1; i >= 0; i--)
                {
                    newNumber += (a[i]).ToString();
                }
            }
            return newNumber;
           
        }
    }

    public class StringReverse : StringManipulator
    {

        public override string Manipulate()
        {
            string namereversed = "";
            for (int i = Text.Length - 1; i >= 0; i--)
            {
                namereversed = namereversed + Text
                    [i];

            }


            return namereversed;
        }

    }

    public class StringUppercase : StringManipulator
    {

        public override string Manipulate()
        {

            if (!(Text is string)) {
                return "no string";
            }

            string[] words = Text.Split(null);

            string bigger =  "";
            for (int i = 0; i < words.Length; i++)
            {
                if (bigger.Length < words[i].Length) {
                    bigger = words[i];
                }
            }

            
            return bigger.ToUpper();
        }
    }

}