using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon1
{
    internal class HastaneCalisanlari:Hastane
    {
        public int SicilNo { get; }
        public double EkGosterge { get; set; }
        public string CalistigiDepartman { get; set; }

        public HastaneCalisanlari(string ad, string soyad, string tc, string cinsiyet, int sicilNo, double ekGosterge, string departman)
            : base(ad, soyad, tc, cinsiyet)
        {
            SicilNo = sicilNo;
            EkGosterge = ekGosterge;
            CalistigiDepartman = departman;
        }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"Sicil No: {SicilNo}\nEk Gösterge: {EkGosterge}\nÇalıştığı Departman: {CalistigiDepartman}");
        }

        public virtual void MaasHesapla()
        {
            double maas = 0;

            if (EkGosterge == 1500)
                maas = 15000;
            else if (EkGosterge > 1500 && EkGosterge <= 2200)
                maas = 20000;
            else if (EkGosterge > 2200 && EkGosterge <= 3000)
                maas = 30000;
            else if (EkGosterge > 3000 && EkGosterge <= 3600)
                maas = 40000;

            Console.WriteLine($"Maaş: {maas} TL");
        }

    }
}
