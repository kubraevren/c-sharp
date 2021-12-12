using System;

namespace ax_b
{
    class Program
    {
        static void Main(string[] args)
        {
            sayiIsteme:
            Console.Write("sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 0)
                Console.WriteLine("karesi:" + sayi * sayi);
            else
                goto sayiIsteme;

            Console.ReadLine();

        }
    }
}
