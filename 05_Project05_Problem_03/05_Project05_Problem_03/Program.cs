using System;

namespace _05_Project05_Problem_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru2: Bir üniversite öğrencisinin bir dersten aldığı üç farklı not ile yıl sonu notu hesaplanmaktadır. Bunlar vize sınavı , final sınavı ve proje notu. Vize sınavının %3’u final sınavının %40’ı ve proje notunun %20’si alınarak not hesaplanmaktadır. Bu bilgilere göre vize , final ve proje notu klavyeden girilen bir öğrencinin dönem sonu notunu hesaplayan programı yazınız.

            double VN, FN, PN, YN;
            Console.WriteLine("Lütfen Vize Notunuzu Giriniz");
            VN = double.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen Final Notunuzu Girinz");
            FN = double.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen Proje Notnuzu Giriniz");
            PN = double.Parse(Console.ReadLine());

            YN = VN * 0.4 + FN * 0.4 + PN * 0.2;

            Console.WriteLine("Yıl Sonu Notunuz: "+YN);

        }
    }
}
