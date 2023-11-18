using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratYucedagDers1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sehir;
            sehir = "Alperen";
            Console.WriteLine(sehir);

            
            
            string isim;
            Console.WriteLine("İsmininizi Giriniz: ");
            isim =  Console.ReadLine();
            Console.WriteLine("Hoşgeldiniz "+isim+" Bey ");

            
            
            string isim1, soyisim, sehir1, meslek;
            Console.WriteLine("İsminiz: ");
            isim1 = Console.ReadLine();
            
            Console.WriteLine("Soy İsminiz: ");
            soyisim = Console.ReadLine();

            Console.WriteLine("Yaşadığınız Şehir: ");
            sehir1 = Console.ReadLine();
            
            Console.WriteLine("Mesleğiniz: ");
            meslek = Console.ReadLine();

            Console.WriteLine("İsminiz: " + isim1 + " Soy İsminiz: " + soyisim + " Yaşadığınız Şehir: " + sehir1 + " Mesleğiniz: " + meslek );


            string isim2, soyisim2, sehir2;
            Console.WriteLine("isim: ");
            isim2 = Console.ReadLine();

            Console.WriteLine("Soyisim: ");
            soyisim2 = Console.ReadLine();

            Console.WriteLine("Şehir: ");
            sehir2 = Console.ReadLine();

            Console.WriteLine("İsim: {0} Soy İsim: {1} şehir: {2}" ,isim2,soyisim2,sehir2 );
            //burada 0.parameteye isim
            //1.parametreye soyisim
            //2.parametreye sehir ataması yaptık.
            Console.ReadLine();
        }
    }
}
