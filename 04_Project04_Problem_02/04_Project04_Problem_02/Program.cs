using System;

namespace _04_Project04_Problem_02
{
    class Program
    {
        static void Main(string[] args)
        {

            // Maaş + prim şeklinde çalışan bir işçi ; sattığı ürün miktarına göre prim almaktadır. Eğer işçi 1-8 arasında ürün satarsa ürün başına 22 TL , 9-15 ürün satarsa ürün başına 25 TL , 16-25 ürün satarsa ürün başına 30 TL ek prim kazanan işçin ay sonundaki net maaşını hesaplayan programı yazınız. (Maaş ve satılan ürün sayısı klavyeden girilecek)

            int maaş, prim, sattığı_ürün;

            Console.WriteLine("Lütfen Satılan Ürün Miktarını Giriniz");
            sattığı_ürün = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen Ayıp Olmazsa Maaşını giriver");
            maaş = int.Parse(Console.ReadLine());

            if (sattığı_ürün >= 1 && sattığı_ürün <= 8)
            {
                prim = 22 * sattığı_ürün;
                maaş = maaş + prim;
            }

            else if (sattığı_ürün >= 9 && sattığı_ürün <= 15)
            {
                prim = 25 * sattığı_ürün;
                maaş = maaş + prim;
            }

            else if (sattığı_ürün >= 16 && sattığı_ürün <= 25)
            {
                prim = 30 * sattığı_ürün;
                maaş += prim;
            }

            else
            {
                Console.WriteLine("Gardaşım Benim Beynim O gada Çalışmıyi");
            }

            Console.WriteLine("Son Eklenen Primlerden Sonra Maaşınız" + maaş);
        }
    }
}
