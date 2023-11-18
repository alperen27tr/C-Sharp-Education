using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratYucedag_if_else_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi,sayi2;
            Console.WriteLine("****** Girilen Sayı Negatifmi Pozitifmi Bulma **********");

            Console.WriteLine("Sayı Giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi >= 0)
            {
                Console.WriteLine("Sayı Pozitif ");            
            }
            else
            {
                Console.WriteLine("Sayı Negatif");
            }

            Console.WriteLine();
            Console.WriteLine("****** Girilen Sayı Tek mi Çift mi Bulma **********");
            
            Console.WriteLine("Sayı Giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            
            if (sayi2 % 2 == 0)
            {
                Console.WriteLine("Girdiğiniz Sayı Çift");
            }
            else
            {
                Console.WriteLine("Girdiğiniz Sayı Tek");
            }



            Console.Read();
        }
    }
}
