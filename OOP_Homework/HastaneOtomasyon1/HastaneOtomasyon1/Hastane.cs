using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon1
{
    internal class Hastane
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; private set; }
        public string Cinsiyet { get; set; }

        public Hastane(string ad, string soyad, string tc, string cinsiyet)
        {
            Ad = ad;
            Soyad = soyad;
            TC = tc;
            Cinsiyet = cinsiyet;
        }

        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Ad: {Ad} {Soyad} ");
        }

        public virtual void HastaBilgileri(ArrayList hastaListesi)
        {
            
            foreach (Hastane hasta in hastaListesi)
            {
                hasta.BilgileriYazdir();
                Console.WriteLine("-----------------------");
            }
        }
    }
}
