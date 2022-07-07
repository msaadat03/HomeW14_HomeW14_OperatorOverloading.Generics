using System;

namespace HomeW14_ReviewLessonsTasks
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Implicit
            //Manat manat = new Manat(340);

            //Dollar dollar = manat;
            //Console.WriteLine(dollar.Usd);

            //string name = "123";
            //Console.WriteLine(int.Parse(name));
            //Console.WriteLine(int.Parse(name).GetType());

            //string name = "123C";
            //Console.WriteLine(int.Parse(name));
            //Console.WriteLine(int.Parse(name).GetType());

            //int age = 77;
            //Console.WriteLine(age.ToString());
            //Console.WriteLine(age.ToString().GetType());


            //DateTime date = DateTime.Now;
            //var result = date.ToString("MM/dd/yyyy");
            //Console.WriteLine(result);

            //DateTime date = DateTime.Now;
            //var result = date.ToString("H:mm");
            //Console.WriteLine(result);

            //string name = "123";
            //var n = Convert.ToInt32(name);
            //Console.WriteLine(n);
            #endregion

        }
    }
}

    #region Implicit 
    //    public class Dollar
    //    {
    //        public double Usd { get; set; }
    //        public Dollar(double usd)
    //        {
    //            Usd = usd;

    //        }
    //    }

    //    public class Manat
    //    {
    //        public double Azn { get; set; }
    //        public Manat(double azn)
    //        {
    //            Azn = azn;
    //        }

    //        public static implicit operator Dollar(Manat manat)
    //        {
    //            return new Dollar(manat.Azn / 1.7);

    //        }
    //    }
    //}
    #endregion

    #region Explicit
    //        {
    //            Manat manat = new Manat(340);

    //            Dollar dollar = (Dollar) manat;

    //            Console.WriteLine(dollar.Usd);
    //        }
    //    }

    //    public class Dollar
    //    {
    //        public double Usd { get; set; }
    //        public Dollar(double usd)
    //        {
    //            Usd = usd;

    //        }
    //    }

    //    public class Manat
    //    {
    //        public double Azn { get; set; }
    //        public Manat(double azn)
    //        {
    //            Azn = azn;
    //        }

    //        public static explicit operator Dollar(Manat manat)
    //        {
    //            return new Dollar(manat.Azn / 1.7);
    //        }
    //}
    #endregion

