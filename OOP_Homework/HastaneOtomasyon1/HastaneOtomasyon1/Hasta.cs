using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon1
{
    internal class Hasta : Hastane
    {
        public string YatisTarihi { get; set; }
        public string PoliklinikBilgisi { get; set; }

        public Hasta(string ad, string soyad, string tc, string cinsiyet, string yatisTarihi, string poliklinikBilgisi)
            : base(ad, soyad, tc, cinsiyet)
        {
            YatisTarihi = yatisTarihi;
            PoliklinikBilgisi = poliklinikBilgisi;
        }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"Yatış Tarihi: {YatisTarihi} Poliklinik Bilgisi: {PoliklinikBilgisi}");
        }
    }
}
