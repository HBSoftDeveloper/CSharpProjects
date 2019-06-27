using System;

namespace _06_Project06Problem_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru3:Klavyeden girilen kilo ve boy bilgisine göre vücut kütle indexini hesaplayan programı yazınız. Çıkan değere göre zayıf şişman gibi sonuç üretilecek. Değerlere ait tablo  altta verilmiştir.

            double Kilo, Boy, VKİ, puan;

            Console.WriteLine("Lütfen Boyunuzu Santimetre Cinsinden Giriniz");
            Boy = double.Parse(Console.ReadLine())/100;

            Console.WriteLine("Lütfen Kilonuzu Kilogram Cinsinden Giriniz");
            Kilo = double.Parse(Console.ReadLine());

            VKİ = Kilo / (Boy*Boy) ;

            Console.WriteLine("Vücut Kitle İndexi: "+VKİ);

            if (VKİ < 20)
            {
                Console.WriteLine("Verdiğiniz Bilgilere Göre Vüçüt ölçünüz: Zayıf");
            }

            else if (VKİ >= 20 && VKİ <= 24.9)
            {
                Console.WriteLine("Verdiğiniz Bilgilere Göre Vüçüt ölçünüz: Normal");
            }

            else if (VKİ > 24.9 && VKİ <= 29.9)
            {
                Console.WriteLine("Verdiğiniz Bilgilere Göre Vüçüt ölçünüz: Hafif Şişman");
            }

            else if (VKİ > 29.9 && VKİ <= 34.9)
            {
                Console.WriteLine("Verdiğiniz Bilgilere Göre Vüçüt ölçünüz: Şişman");
            }


            else if (VKİ > 34.9 && VKİ <= 44.9)
            {
                Console.WriteLine("Verdiğiniz Bilgilere Göre Vüçüt ölçünüz: Sağlık Açısından Önemli");
            }

            else if (VKİ > 44.9 && VKİ <= 49.9)
            {
                Console.WriteLine("Verdiğiniz Bilgilere Göre Vüçüt ölçünüz: Aşırı Şişman");
            }

            else 
            {
                Console.WriteLine("Verdiğiniz Bilgilere Göre Vüçüt ölçünüz: (Morbid) Yani Ölümcül Şişmanlık");
            }
            Console.WriteLine();

            Console.WriteLine("Uygulamamızı 1-5 Arası Puanlayınız");
            puan = double.Parse(Console.ReadLine());

            if (puan >= 1 && puan <=3)
            {
                Console.WriteLine("Niye Düşük Puan Veriyon Lan Göt ");
            }

           else if (puan >= 4 && puan <= 7)
            {
                Console.WriteLine("Puanınız İçin Teşekkürler");
            }

           else if (puan >= 8 && puan <= 10)
            {
                Console.WriteLine("---I love You Baby----");
            }
        }
    }
}
