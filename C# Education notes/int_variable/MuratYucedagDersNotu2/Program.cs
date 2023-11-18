using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratYucedagDersNotu2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, toplam;
            sayi1 = 5;
            sayi2 = 7;
            toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);


            int a, b, c,d;
            a= 4;
            b = 8;
            c = a*b;

            Console.WriteLine("a * b = "+c);
            d = (a+b)/2;
            Console.WriteLine(d);

            string ogrenci_isim,ogrenci_soyisim,numara;
            int vize,final,ortalama;


            ogrenci_isim = "Alperen";
            ogrenci_soyisim = "Erdoğan";
            numara = "223010710019";

            Console.WriteLine(ogrenci_isim);
            Console.WriteLine(ogrenci_soyisim);
            Console.WriteLine(numara);

            Console.WriteLine("Vize Notunuzu Giriniz: ");
            vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final Notunuzu Giriniz: ");
            final = Convert.ToInt32(Console.ReadLine());

            ortalama = (vize+final)/2;
            Console.WriteLine("Sınav Ortalamanız: "+ ortalama );
            if (ortalama > 50)
                Console.WriteLine("Dersi geçtiniz ");
                else
                Console.WriteLine("Kaldınız ");
            


            Console.ReadLine();

            
        }
    }
}
