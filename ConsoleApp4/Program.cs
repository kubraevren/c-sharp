using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1, s2;
            Console.Write("1. sayıyı giriniz:");
            s1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. sayıyı giriniz.");
            s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("sayıların toplamı: " + (s1 + s2));
            Console.ReadLine();
        }
    }
}
