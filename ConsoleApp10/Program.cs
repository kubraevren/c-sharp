using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0 ; int s = 0;
            sayiIsteme:
            Console.Write("n değeri giriniz:");
            n = Convert.ToInt32(Console.ReadLine());

            s += 1;
            Console.WriteLine(n);

            if (n != 5)
                goto sayiIsteme;
            else
                Console.Write("sayaç "+ s);

            Console.ReadLine();
        }
    }
}
