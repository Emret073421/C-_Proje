using System;

namespace ConsoleApp2
{
    public class Personel
    {
        // Kapsülleme (Encapsulation) - Private Alanlar
        private string _tc;
        private string _ad;
        private string _soyad;
        private string _kullaniciAdi;
        private string _sifre;
        private string _yetki; // "Admin" veya "Personel"

        // Özellikler (Properties) (Daraltılmış Söz Dizimi)
        public string Tc { get => _tc; set => _tc = value; }
        public string Ad { get => _ad; set => _ad = value; }
        public string Soyad { get => _soyad; set => _soyad = value; }
        public string KullaniciAdi { get => _kullaniciAdi; set => _kullaniciAdi = value; }
        public string Sifre { get => _sifre; set => _sifre = value; }
        public string Yetki { get => _yetki; set => _yetki = value; }

        // Kurucu Metot (Constructor)
        public Personel(string tc, string ad, string soyad, string kullaniciAdi, string sifre, string yetki)
        {
            _tc = tc;
            _ad = ad;
            _soyad = soyad;
            _kullaniciAdi = kullaniciAdi;
            _sifre = sifre;
            _yetki = yetki;
        }
    }
}
