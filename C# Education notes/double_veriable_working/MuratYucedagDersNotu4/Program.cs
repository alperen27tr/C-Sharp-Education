using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratYucedagDersNotu4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sinav1,sinav2,sinav3,proje,ortalama;
            string isim, soyisim, numara;

            Console.WriteLine("************* Ögrenci Kimlik Bilgileri ***********");

            Console.Write("Adınız: ");
            isim = Console.ReadLine();

            Console.Write("Soy İsminiz: ");
            soyisim = Console.ReadLine();

            Console.Write("Öğrenci Numaranız: ");
            numara = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("*********** Sınav Ortalama Hesaplama *************");

            Console.Write("1.Sınav Notunuz: ");
            sinav1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2.Sınav Notunuzu Giriniz: ");
            sinav2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("3.Sınav Notunuzu Giriniz: ");
            sinav3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Proje Notunuzu Giriniz: ");
            proje = Convert.ToDouble(Console.ReadLine());

            ortalama= (sinav1 + sinav2 + sinav3 + proje)/4;
            Console.WriteLine("Ortalamanız: " + ortalama);




            Console.Read();
        }
    }
}
