using System;

namespace final2
{
    class Program
    // . Ekrana metot kullanarak n defa “Merhaba” çıktısı veren
    // konsol uygulamasını yazınız. N değeri kullanıcıdan alınmalı
    // ve parametrik olarak metoda gönderilmelidir.
    {
        static void Main(string[] args)
        {
            //değiskenleri tanımlayalim
            int n;
            //konsoldan n değerini okuyalım
            Console.Write("n:");
            n = Convert.ToInt32(Console.ReadLine());
            //yaz isimli metodu n defa çallstıralım
            for (int i = 1; i <= n; i++)
                yaz();
            Console.Read(); } //bekle 
                              //yaz isimli parametresiz metot
        static void yaz()
        {
            Console.WriteLine("Merhaba");
        }
     
    }
}

