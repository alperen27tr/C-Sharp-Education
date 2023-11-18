using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratYucedagDersNotu5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isim1,isim2,GirilenIsim,sehir; 
            isim1="Alperen";

            if (isim1 == "Alperen") 
            {
                Console.WriteLine("İsim Doğru ");
            }
            else
            {
                Console.WriteLine("İsim Yanlış ");
            }

            isim2 = "Ali";
            Console.WriteLine("İsminizi Giriniz: ");
            GirilenIsim = Console.ReadLine();
            
            {
                if (isim2 == GirilenIsim)
                { 
                    Console.WriteLine("İsim Doğru ");
                } 
                else
                {
                    Console.WriteLine("İsim Yanlış!! ");
                }
            }
            
            sehir = "Ankara";

            Console.WriteLine("Türkiye'nin başkenti neresidir? ");
            sehir = Console.ReadLine();

            if (sehir == "Ankara")
            {
                Console.WriteLine("Tebrikler! ");
            }
            else
            {
                Console.WriteLine("Yanlış Cevap :( ");
            }


            Console.Read();
        }
    }
}
