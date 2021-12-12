using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            const double oran = 2.54;
            Console.Write("inç değerini giriniz:");
            double inch = Convert.ToDouble(Console.ReadLine());

            double santim = inch * oran;
            Console.WriteLine("inç değerinin cm karşılığı: " + santim);

            Console.ReadLine();

        }
    }
}
