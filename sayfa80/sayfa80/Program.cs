using System;

class Program //sayfa80 bırıncı odev
{
    static void Main()
    {
        try
        {
           
            Console.Write("Kaç adet sayı gireceksiniz? ");
            int adet = Convert.ToInt32(Console.ReadLine());

            double toplam = 0;

         
            for (int i = 0; i < adet; i++)
            {
                Console.Write($"{i + 1}. sayıyı giriniz: ");
                double sayi = Convert.ToDouble(Console.ReadLine());
                toplam += sayi;
            }

           
            double ortalama = toplam / adet;

          
            Console.WriteLine($"Girilen sayıların toplamı: {toplam}");
            Console.WriteLine($"Girilen sayıların ortalaması: {ortalama}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Geçerli bir sayı giriniz.");
        }
        Console.ReadKey();
    }
}
