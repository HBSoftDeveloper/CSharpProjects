using System;

namespace _09_Project09_Series_Problem_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Örnek 1: Tanımlanan sayılar dizisi içerisindeki sayıları toplayan c# konsol uygulaması

            #region Soru 1

            //int[] Numbers = new int[] { 1, 2, 3, 4, 5, 6, 6, 7 };

            //int toplam = 0;

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    toplam += Numbers[i];
            //}

            //Console.WriteLine("Sayıların Toplamı: "+toplam);

            #endregion

            #region Soru 2

            // Kullanıcıya Klavyeden Kaç Adet Sayı Gireceğini Sorunuz.
            // Sonra gireceği sayı kadar dizi oluşturunuz. Sayıları Alınız.
            // Sayıları büyükten küçüğe ve küçükten büyüğe sıralayınız Ekradan gösteriniz.
            // Dizi içerisindeki çift sayıların çarpımını tek sayılarını toplamına bölünüz sonucu ekranda gösteriniz.

            int N; double Carpim=1, Toplam=0, Sonuc;

            Console.Write("Dizi Uzunluğunu Giriniz: ");
            N = Convert.ToInt32(Console.ReadLine());

            double[] Numbers = new double[N];

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write("{0}. Sayıyı Giriniz: ",i+1);
                Numbers[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Dizi İlk Sıralama");

            foreach (double item in Numbers)
            {
                Console.Write(item + " - ");
            }

            Console.WriteLine();
            Array.Sort(Numbers);

            Console.WriteLine("Küçükten Büyüğe Dizi Sıralaması");

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write(Numbers[i] + " - ");
            }

            Console.WriteLine();
            Array.Reverse(Numbers);

            Console.WriteLine("Büyükten Küçüğe Dizi Sıralaması");

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write(Numbers[i] + " - ");
            }

            foreach (double X in Numbers)
            {
                if (X%2 == 0)
                {
                    Carpim *= X;
                }

                else
                {
                    Toplam += X;
                }
            }

            Sonuc = Carpim / Toplam;

            Console.WriteLine();

            Console.WriteLine("Çarpım/Toplam: {0}/{1}={2}",Carpim,Toplam,Sonuc);


            #endregion

        }
    }
}
