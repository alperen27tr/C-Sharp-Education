using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratYucedagDersNotu3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, toplam;
            int UzunKenar, KisaKenar,Cevre,Alan;

            Console.WriteLine("Birinci Sayıyı Giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci Sayıyı Giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            toplam = sayi1 + sayi2;
            Console.WriteLine("Sayıların Toplamı: "+toplam);
            
            Console.WriteLine();
            Console.WriteLine("********* Çevre Ve Alan Hesaplama ********");
            Console.WriteLine();

            Console.WriteLine("Dikdörtgenin Uzun Kenarını Giriniz: ");
            UzunKenar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dikdörtgenin Kısa Kenarını Giriniz: ");
            KisaKenar = Convert.ToInt32(Console.ReadLine());

            Cevre = 2 * UzunKenar + 2 * KisaKenar;
            Console.WriteLine("Dikdörtgenin Çevresi: "+Cevre);

            Alan = UzunKenar * KisaKenar;
            Console.WriteLine("Dikdörtgenin Alanı: "+Alan);


            Console.ReadLine();
        }
    }
}
