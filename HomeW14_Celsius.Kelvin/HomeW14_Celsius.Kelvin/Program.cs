using System;

namespace HomeW14_Celsius.Kelvin
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Kelvin kelvin = new Kelvin(200);

            Celsius celsius = kelvin;

            Console.WriteLine(celsius.Degree);


        }
    }
}
