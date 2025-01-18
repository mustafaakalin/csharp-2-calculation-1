using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // girilen iki farklı sayıdan büyük olanı gösteren uygulama
            // Console.WriteLine("1. sayıyı giriniz: ");
            // int sayi1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("2. sayıyı giriniz: ");
            // int sayi2 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Büyük olan sayı: " + BuyukOlan(sayi1, sayi2));

            // girilen sayının faktöriyelini hesaplayan uygulama
            Console.WriteLine("Faktöriyelini hesaplamak istediğiniz sayıyı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Faktöriyel: " + Faktoriyel(sayi));


            Console.ReadLine();
        }

        static int BuyukOlan(int a, int b)
        {
            return Math.Max(a, b);
        }
        static int Faktoriyel(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            int sonuc = 1;
            for (int i = 2; i <= n; i++)
            {
                sonuc *= i;
            }
            return sonuc;
        }
    }
}