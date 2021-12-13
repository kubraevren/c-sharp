using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n , s = 0;
            Console.Write("n giriniz:");
            n = Convert.ToInt32(Console.ReadLine());
        basla:
             s += 2;
                Console.WriteLine(s);
            if (s < n-1)
                goto basla;
            
            
            Console.ReadLine();
        }

    }
}
