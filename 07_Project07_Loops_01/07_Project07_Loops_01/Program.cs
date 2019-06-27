using System;

namespace _07_Project07_Loops_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-1000 arasındaki sayılarda hem 3 hemde 5 e bölünebilen sayıların adedini(kaç tane olduğunu) bulan programı yazınız. (Ekranda tek bir sonuç olacak)
            int sayaç, adet = 0;

            for ( sayaç = 1; sayaç <1000 ; ++sayaç)
            {
                if (sayaç%3==0 && sayaç%5==0)
                {
                    adet = adet + 1;
                }
                
            }

            Console.WriteLine("1 İle 1000 Arasında 3 ve 5 İle Tam Bölünebilen sayı adeti:" +adet );

        }
    }
}
