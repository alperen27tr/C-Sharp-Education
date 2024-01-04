using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon1
{
    internal class HastaneCalisanlari:Hastane
    {
        public int SicilNo { get; private set; }
        public double EkGosterge { get; set; }
        public string CalistigiDepartman { get; set; }

        public HastaneCalisanlari(string ad, string soyad, string tc, string cinsiyet, int sicilNo, double ekGosterge, string departman)
            : base(ad, soyad, tc, cinsiyet)
        {
            SicilNo = sicilNo;
            EkGosterge = ekGosterge;
            CalistigiDepartman = departman;
        }
        //Hastane Çalışanı Bilgileri:
          // Hastane Çalışanı: Mehmet Nakkaş, Sicil No: 101, Çalıştığı Departman: Acil Servis
       // Maaş: 15000.0 TL
        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"sicilno:{SicilNo} çalıştığı departman: {CalistigiDepartman}");
        }

        public virtual void MaasHesapla()
        {
            double maas = 0;

            if (EkGosterge == 1500)
            {
                maas = 15000;
            }
            else if (EkGosterge > 1500 && EkGosterge <= 2200)
            {
                maas = 20000;
            }
            else if (EkGosterge > 2200 && EkGosterge <= 3000)
            {
                maas = 30000;
            }
            else if (EkGosterge > 3000 && EkGosterge <= 3600)
            {
                maas = 40000;
            }
            Console.WriteLine($"Maaş: {maas} TL");
        }

    }
}
