using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,s = 0;
         
            Console.WriteLine("n değeri giriniz:");
            n = Convert.ToInt32(Console.ReadLine());
            don:
            s += 1;
            Console.Write(s+ " ");
            if (s < n) goto don;
           

            Console.ReadLine();

        }
    }
}
