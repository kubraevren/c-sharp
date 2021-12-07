using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, kare;
            Console.Write("Sayıyı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            kare = sayi * sayi;
            Console.Write("Sayının karesi: " + kare);
            Console.Read();

        }
    }
}
