using System;
using System.Collections.Generic;
using System.Text;

namespace HomeW14_Celsius.Kelvin
{
    public class Celsius
    {
        public double Degree { get; set; }
        public Celsius (double c)
        {
            Degree = c;
        }
        public static implicit operator Celsius(Kelvin kelvin)
        {
            return new Celsius(kelvin.Degree - 273);
        }
    }

}
