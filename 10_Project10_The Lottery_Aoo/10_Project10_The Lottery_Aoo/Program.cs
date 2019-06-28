using System;

namespace _10_Project10_The_Lottery_Aoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random R = new Random(); // Rastgele Sayı Türetme

            char karar;

            int[] UN = new int[6];
            int[] RN = new int[6];
            int[] TN = new int[0];

            int adet = 0;
            int x;

        Etiket:

            Console.Clear(); // Console Ekranını Temizlemek İçin
            adet = 0;

            Array.Resize(ref TN, 0); // Diziyi Yeniden Boyuntlandırmak İçin

            for (int i = 0; i < UN.Length; i++)
            {
                Console.Write("{0}. Sayıyı Giriniz: ",i+1);
                UN[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < RN.Length; i++)
            {
                do
                {
                    x = R.Next(1, 50);
                    
                } while (Array.IndexOf(RN,x)!=-1);

                RN[i] = x;
            }

            for (int i = 0; i < UN.Length; i++)
            {
                for (int j = 0; j < RN.Length; j++)
                {
                    if (UN[i] == RN[j])
                    {
                        adet++;
                        Array.Resize(ref TN, adet);
                        TN[adet-1] = UN[i];
                        
                    }
                }
            }

            Console.WriteLine();

            Console.WriteLine("Girdiğiniz Sayılar");

            foreach (int item in UN)
            {
                Console.Write(item + " - ");
            }

            Console.WriteLine();

            Console.WriteLine("Girdiğiniz Sayılar Sıralı");

            Array.Sort(UN);

            foreach (int item in UN)
            {
                Console.Write(item + " - ");
            }

            Console.WriteLine();

            Console.WriteLine("Sayısal Loto Sayıları");

            foreach (int item in RN)
            {
                Console.Write(item + " - ");
            }

            Console.WriteLine();

            Console.WriteLine("Girdiğiniz Sayılar Sıralı");

            Array.Sort(RN);

            foreach (int item in RN)
            {
                Console.Write(item + " - ");
            }

            Console.WriteLine();

            Console.WriteLine("Tutturduğunuz Sayılar");

            foreach (int item in TN)
            {
                Console.Write(item + " - ");
            }

            Console.WriteLine();

            Console.WriteLine("Tutturduğunuz Sayılar Sıralı");

            Array.Sort(TN);

            foreach (int item in TN)
            {
                Console.Write(item + " - ");
            }

            Console.WriteLine();

            Console.WriteLine("Bildiğiniz Adet:{0}",adet);

            Console.WriteLine("Tekrar Oynamak İster misiniz?(E/H)");
            karar =Convert.ToChar(Console.ReadLine());

            if (karar == 'E' || karar == 'e')
            {
                goto Etiket;
            }

            else
            {
                Console.WriteLine("Bir Daha Bekleriz...");
                Environment.Exit(0);
            }
        }
    }
}
