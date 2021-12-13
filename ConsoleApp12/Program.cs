using System;


namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Merhaba Dünya");
            }
            //****************************************************
            int k = 1;
        yaz:
            Console.WriteLine("Merhaba Dünya");
            k += 1;
            if (k <= 5)
                goto yaz;

            //**************************************************

            int a = 1;
            while (a <= 10)
            {
                Console.WriteLine("Merhaba Dünya");
                a++;
            }



            Console.ReadLine();
        }
    }
}
