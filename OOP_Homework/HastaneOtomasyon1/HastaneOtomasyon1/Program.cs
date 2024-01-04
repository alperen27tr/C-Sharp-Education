using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon1
{
    internal class Program
    {
        static void Main()
        {
            ArrayList hastaListesi = new ArrayList();

            Hasta hasta1 = new Hasta("Ahmet", "Yılmaz", "12345678901", "Erkek", DateTime.Now, "Dahiliye");
            Hasta hasta2 = new Hasta("Ayşe", "Kaya", "98765432109", "Kadın", DateTime.Now, "Cerrahi");

            hastaListesi.Add(hasta1);
            hastaListesi.Add(hasta2);

            foreach (Hastane hasta in hastaListesi)
            {
                hasta.BilgileriYazdir();
                Console.WriteLine("-----------------------");
            }

            Console.ReadLine();
        }
    }
}
