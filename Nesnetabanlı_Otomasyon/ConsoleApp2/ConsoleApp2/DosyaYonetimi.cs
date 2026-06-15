using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp2
{
    // Statik Sınıf (Utility Class)
    public static class DosyaYonetimi
    {
        // Kapsülleme (Encapsulation) - Private Alanlar (Sabitler)
        private const string Yol = @"C:\Users\emret\OneDrive\Masaüstü\Proje2\ConsoleApp2\ConsoleApp2\urunler.csv";
        private const string PersonelYol = @"C:\Users\emret\OneDrive\Masaüstü\Proje2\ConsoleApp2\ConsoleApp2\personeller.csv";
        public const string AlimDosyaYolu = @"C:\Users\emret\OneDrive\Masaüstü\Proje2\ConsoleApp2\ConsoleApp2\alimlar.csv";
        public const string SatisDosyaYolu = @"C:\Users\emret\OneDrive\Masaüstü\Proje2\ConsoleApp2\ConsoleApp2\satislar.csv";

        // Metotlar (Methods)
        public static void VerileriKaydet(List<Urun> liste)
        {
            using (StreamWriter sw = new StreamWriter(Yol))
            {
                foreach (var u in liste)
                {
                    string tip = u.GetType().Name; // "Urun", "GidaUrunu" veya "TeknolojiUrunu"
                    sw.WriteLine($"{u.Barkod};{u.Ad};{u.Stok};{u.AlisFiyati};{u.SatisFiyati};{tip}");
                }
            }
        }

        public static List<Urun> VerileriYukle()
        {
            List<Urun> liste = new List<Urun>();
            if (!File.Exists(Yol)) return liste;

            foreach (var satir in File.ReadAllLines(Yol))
            {
                var v = satir.Split(';');
                if (v.Length >= 5)
                {
                    string barkod = v[0];
                    string ad = v[1];
                    int stok = int.Parse(v[2]);
                    double alis = double.Parse(v[3]);
                    double satis = double.Parse(v[4]);
                    
                    if (v.Length >= 6)
                    {
                        string tip = v[5];
                        if (tip == "GidaUrunu") liste.Add(new GidaUrunu(barkod, ad, stok, alis, satis));
                        else if (tip == "TeknolojiUrunu") liste.Add(new TeknolojiUrunu(barkod, ad, stok, alis, satis));
                        else if (tip == "TemizlikUrunu") liste.Add(new TemizlikUrunu(barkod, ad, stok, alis, satis));
                        else liste.Add(new Urun(barkod, ad, stok, alis, satis));
                    }
                    else
                    {
                        liste.Add(new Urun(barkod, ad, stok, alis, satis));
                    }
                }
            }
            return liste;
        }

        public static void PersonelleriKaydet(List<Personel> liste)
        {
            using (StreamWriter sw = new StreamWriter(PersonelYol))
            {
                foreach (var p in liste)
                    sw.WriteLine($"{p.Tc};{p.Ad};{p.Soyad};{p.KullaniciAdi};{p.Sifre};{p.Yetki}");
            }
        }

        public static List<Personel> PersonelleriYukle()
        {
            List<Personel> liste = new List<Personel>();
            if (!File.Exists(PersonelYol)) return liste;

            foreach (var satir in File.ReadAllLines(PersonelYol))
            {
                var v = satir.Split(';');
                if (v.Length >= 6)
                {
                    liste.Add(new Personel(v[0], v[1], v[2], v[3], v[4], v[5]));
                }
            }
            return liste;
        }

        public static void AlimKaydet(string ad, int adet, double birimAlisFiyati)
        {
            using (StreamWriter sw = new StreamWriter(AlimDosyaYolu, true))
            {
                string tarih = DateTime.Now.ToString("dd.MM.yyyy");
                string saat = DateTime.Now.ToString("HH:mm");
                double toplamMaliyet = adet * birimAlisFiyati;
                sw.WriteLine($"{tarih};{saat};{ad};{adet};{birimAlisFiyati};{toplamMaliyet}");
            }
        }

        public static void SatisKaydet(Sepet sepet)
        {
            using (StreamWriter sw = new StreamWriter(SatisDosyaYolu, true))
            {
                string tarih = DateTime.Now.ToString("dd.MM.yyyy");
                string saat = DateTime.Now.ToString("HH:mm");

                foreach (var item in sepet.GetUrunler())
                {
                    sw.WriteLine($"{tarih};{saat};{item.Urun.Ad};{item.Adet};{item.Urun.SatisFiyati};{item.AraToplam}");
                }
            }
        }
    }
}
