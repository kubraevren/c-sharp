using System;

namespace final1
{
    class Program
    {
        static void Main(string[] args)
        {
            // hem for hem while kullanarak faktoriyel hesaplama:

            /* int f = 1; 
            Console.WriteLine("bir sayı giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int sayac = 1; sayac <= n; sayac++)
            {
                f = f * sayac;

            }
            Console.WriteLine(f); */

            int f = 1;
            int sayac = 1;
            Console.WriteLine("bir sayı giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());

            while (sayac <= n)
            {
                f *= sayac;
                sayac++;
            }

            Console.WriteLine("faktoriyel: " + f);



        }
    }
}
