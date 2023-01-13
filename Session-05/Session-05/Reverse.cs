using System;

namespace Session5
{

    public class Reverse
    {


        public string Get()
        {
            string name = "nikos";
            string namereversed = "";
            for (int i = name.Length-1; i >= 0; i--)
            {
                namereversed = namereversed + name[i];

            }


            return namereversed;

        }

    }
}