using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon1
{
    internal class Hasta : Hastane
    {
        public DateTime YatisTarihi { get; set; }
        public string PoliklinikBilgisi { get; set; }

        public Hasta(string ad, string soyad, string tc, string cinsiyet, DateTime yatisTarihi, string poliklinikBilgisi)
            : base(ad, soyad, tc, cinsiyet)
        {
            YatisTarihi = yatisTarihi;
            PoliklinikBilgisi = poliklinikBilgisi;
        }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"Yatış Tarihi: {YatisTarihi}\nPoliklinik Bilgisi: {PoliklinikBilgisi}");
        }
    }
}
