using System;

namespace _01_Project01_Problem_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, IT, FI;

            Console.Write("Düzgün Çokgenin Kenar Sayısını Giriniz: ");
            n = int.Parse(Console.ReadLine());

            FI = 180 - (360 / n);

            IT = FI * n;

            Console.WriteLine("Düzgün Çokgenin Tüm İç Açılar Toplamı:" + IT);

            Console.WriteLine("Düzgün Çokgenin Bir İç Açısı:{1} --Düzgün Çokgenin Tüm İç Açılar Toplamı:{2}",FI,IT);
            
        }
    }
}
