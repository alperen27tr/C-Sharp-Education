using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon1
{
    internal class Doktor : HastaneCalisanlari
    {
        public int DiplomaNo { get; private set; }
        public string Brans { get; set; }

        public Doktor(string ad, string soyad, string tc, string cinsiyet, int sicilNo, double ekGosterge, string departman, int diplomaNo, string brans)
            : base(ad, soyad, tc, cinsiyet, sicilNo, ekGosterge, departman)
        {
            DiplomaNo = diplomaNo;
            Brans = brans;
        }


        //Doktor Bilgileri:
        //Hastane Çalışanı: Dr.Ahmet Öztürk, Sicil No: 201, Çalıştığı Departman: Nefroloji
        //Maaş: 20000.0 TL
        public override void BilgileriYazdir()
        {
            Console.WriteLine($"Doktor Bilgileri:\nAd:{Ad} {Soyad} Sicil No:{SicilNo} Çalıştığı Departman:{CalistigiDepartman}");
        }

        public virtual void MaasHesapla()
        {
            base.MaasHesapla();
        }
    }
}
