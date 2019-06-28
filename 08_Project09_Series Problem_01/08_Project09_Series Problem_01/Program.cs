using System;

namespace _08_Project09_Series_Problem_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 3 adet kişinin adı soyadı vize ve final notunu aldıktan sonra kişilerin geçme notunu hesaplayınız. Ve kullanıcıya hepsini gösteriniz.

            string[] AdSoyad = new string[3];
            double[] Vize = new double[3];
            double[] Final = new double[3];
            double[] Result = new double[3];

            for (int i = 0; i < AdSoyad.Length; i++)
            {
                Console.Write("{0}. Öğrencinin Adını Soyadını Giriniz:",i+1);
                AdSoyad[i] = Console.ReadLine();
                Console.Write("{0}. Öğrencinin Vize Notunu Giriniz:", i+1);
                Vize[i] = double.Parse(Console.ReadLine());

                Console.Write("{0}. Öğrencinin Final Notunu Giriniz:", i+1);
                Final[i] = double.Parse(Console.ReadLine());

                Result[i] = (Vize[i] * 0.4) + (Final[i] * 0.6);

                Console.WriteLine("**************************");
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
            }

            for (int i = 0; i < Vize.Length; i++)
            {
                if (Result[i] < 40)
                {
                    Console.WriteLine(AdSoyad[i]+" Sınav Sonucu:{0}",Result[i]);
                    Console.WriteLine("Dersten Geçemedi");
                }

                else
                {
                    Console.WriteLine(AdSoyad[i] + " Sınav Sonucu:{0}", Result[i]);
                    Console.WriteLine("Dersten Geçti");
                }
            }
        }
    }
}
