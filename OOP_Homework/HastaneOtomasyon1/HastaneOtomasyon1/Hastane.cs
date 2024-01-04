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
        public string TC { get; }
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
            Console.WriteLine($"Ad: {Ad}\nSoyad: {Soyad}\nTC: {TC}\nCinsiyet: {Cinsiyet}");
        }

        public virtual void HastaBilgileri(ArrayList hastaListesi)
        {
            Console.WriteLine("Hasta Bilgileri:");
            foreach (Hastane hasta in hastaListesi)
            {
                hasta.BilgileriYazdir();
                Console.WriteLine("-----------------------");
            }
        }
    }
}
