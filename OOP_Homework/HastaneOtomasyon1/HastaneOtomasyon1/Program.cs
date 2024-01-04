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

            Hasta hasta1 = new Hasta("Ahmet", "Yılmaz", "12345678901", "Erkek", "22.12.2023", "Dahiliye");
            

            hastaListesi.Add(hasta1);

            Console.WriteLine("Hasta Bilgileri:");
            foreach (Hastane hasta in hastaListesi)
            {
                hasta.BilgileriYazdir();
                Console.WriteLine("-----------------------");
            }
            Console.WriteLine("calişan bilgileri:");
            HastaneCalisanlari calisanlar = new HastaneCalisanlari("mehmet","aksoy","15326987536","erkek",152,1500,"cerrah");
            calisanlar.BilgileriYazdir();
            calisanlar.MaasHesapla();
            Console.WriteLine("-----------------------");
            Doktor doktor = new Doktor("Ali","Kılıç","12356983265","erkek",102,1800,"acil servis",528,"kbb");
            doktor.BilgileriYazdir();
            doktor.MaasHesapla();

            Console.ReadLine();
        }
    }
}
