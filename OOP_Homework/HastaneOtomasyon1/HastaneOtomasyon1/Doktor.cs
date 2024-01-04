using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon1
{
    internal class Doktor : HastaneCalisanlari
    {
        public int DiplomaNo { get; }
        public string Brans { get; set; }

        public Doktor(string ad, string soyad, string tc, string cinsiyet, int sicilNo, double ekGosterge, string departman, int diplomaNo, string brans)
            : base(ad, soyad, tc, cinsiyet, sicilNo, ekGosterge, departman)
        {
            DiplomaNo = diplomaNo;
            Brans = brans;
        }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"Diploma No: {DiplomaNo}\nBranş: {Brans}");
        }

        public override void MaasHesapla()
        {
            base.MaasHesapla();
        }
    }
}
