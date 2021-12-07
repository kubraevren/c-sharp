using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uzun kenarı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kısa kenarı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dikdörtgenin çevresi : " + (sayi1 + sayi2) * 2);
            Console.WriteLine("Dikdörtgenin alanı : " + (sayi1 * sayi2));

            Console.ReadLine();




        }
    }
}
