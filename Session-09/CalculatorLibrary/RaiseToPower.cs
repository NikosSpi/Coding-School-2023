﻿namespace CalculatorLibrary
{


    public class RaiseToPower
    {

        public decimal Do(decimal? x, decimal? y)
        {

            decimal ret = 0;
            double valx = Convert.ToDouble(x);
            double valy = Convert.ToDouble(y);  

            if (x != null && y != null)
            {
               // ret = Math.Pow( valx, valy);
            }

            return ret;
        }

    }
}