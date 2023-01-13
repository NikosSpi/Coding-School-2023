using System;

namespace Session5
{

    public class Choose
    {


        public string GetB()
        {
            string name = "kostas";
            string namereversed = "";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                namereversed = namereversed + name[i];

            }


            return namereversed;

        }

    }
}