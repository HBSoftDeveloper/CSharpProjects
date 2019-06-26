using System;

namespace _03_Project03_Loops_App
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Soru 1

            // Girilen 10 sayı içinde pozitif ve tek olan sayıların çarpımını yazdıran For döngüsü ile yapılmış Console örneği:

            //int x, Carpim = 1;

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("{0}. Sayıyı Giriniz: ",i+1);
            //    x = Convert.ToInt32(Console.ReadLine());

            //    if (x > 0 && x % 2 != 0)
            //    {
            //        //Carpim = Carpim * x;

            //        Carpim *= x;
            //    }

            //    Console.WriteLine();
            //}

            //Console.WriteLine("Çarpım= " + Carpim);

            #endregion

            #region Soru 2

            // Girilen bir metnin karakterlerini alt alta yazdırılmasını sağlama:

            //string Metin;

            //Console.WriteLine("Metni Giriniz: ");
            //Metin = Console.ReadLine();

            //for (int i = 0; i < Metin.Length; i++)
            //{
            //    Console.WriteLine(Metin[i]);
            //}

            //for (int i = Metin.Length-1; i >= 0; i--)
            //{
            //    Console.WriteLine(Metin[i]);
            //}

            #endregion

            #region Soru 3

            char karakter;

            for (karakter = 'a'; karakter <= 'z'; karakter++)
            {
                
                Console.Write("{0} ", karakter);
            }


            #endregion

            #region Soru 4
            Console.WriteLine();

            // For Döngüsü kullanarak Kullanıcıdan aldığı 10 adet sayıyı toplayarak ekranda gösteren uygulama.
            //int toplam = 0;
            //int number;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("{0}. Sayıyı Giriniz : ",i+1);
            //    number =int.Parse( Console.ReadLine());
            //    toplam += number;

            //}


            //Console.WriteLine("Toplam:"+toplam);

            #endregion

            #region Soru 5

            // Genişliği ve yüksekliği kullanıcı tarafından verilen dikdörtgen oluşturma örneği:

            int G, Y;

            Console.WriteLine("Genişliğini Giriniz: ");
            G = int.Parse(Console.ReadLine());

            Console.WriteLine("Yüksekliğini Giriniz: ");
            Y = int.Parse(Console.ReadLine());

            for (int i = 0; i < Y; i++)
            {
                for (int j = 0; j < G; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Üçgen İçin Yazıldı

            for (int i = 0; i < Y; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            #region Soru 6

            // Girilen stringteki “0” (Sıfır) adetini bulan ve ekrana yazdıran program örneği:

            string Kelime;
            int adet = 0;

            Console.WriteLine("Kelimeyi Giriniz: ");
            Kelime = Console.ReadLine();

            for (int i = 0; i < Kelime.Length; i++)
            {
                if (Kelime[i] == 'o' || Kelime[i] == 'O')
                {
                    adet++;
                    Console.WriteLine("{0}. Sırada O Var",i+1);
                }
            }

            Console.WriteLine("Toplam: "+adet+" O Harfi Var");

            #endregion

        }
    }
}
