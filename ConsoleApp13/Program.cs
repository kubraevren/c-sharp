using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac,n,toplam = 0;
            Console.WriteLine("n değerini giriniz: ");
            n = Convert.ToInt32(Console.ReadLine());

             for (sayac=1;  sayac <= n; sayac++)
                 toplam = toplam + sayac;
                 Console.WriteLine("sayaç: "+sayac);
                 Console.WriteLine("toplam " + toplam); 
           /* int sayacc = 1;
            while (sayacc <= n)
            {
                toplam = toplam + sayacc;
                sayacc++;
            }
            Console.WriteLine("while ile toplamı " + toplam); */

            Console.ReadLine();

        }
    }
}
