using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // Temel Sınıf
    public class Urun
    {
        // Kapsülleme (Encapsulation) - Private Alanlar
        private string _barkod;
        private string _ad;
        private int _stok;
        private double _alisFiyati;
        private double _satisFiyati;

        // Özellikler (Properties)
        public string Barkod => _barkod;
        public string Ad { get => _ad; set => _ad = value; }
        public int Stok { get => _stok; set => _stok = value; }
        public double AlisFiyati { get => _alisFiyati; set => _alisFiyati = value; }
        public double SatisFiyati { get => _satisFiyati; set => _satisFiyati = value; }
        public double Fiyat => _satisFiyati; // Program.cs'deki "Fiyat" kullanımı için

        // Kurucu Metot (Constructor)
        public Urun(string barkod, string ad, int stok, double alis, double satis)
        {
            _barkod = barkod;
            _ad = ad;
            _stok = stok;
            _alisFiyati = alis;
            _satisFiyati = satis;
        }

        // Metotlar (Methods)
        public void StokEkle(int miktar) => _stok += miktar;

        public bool SatisYap(int miktar)
        {
            if (_stok >= miktar) { _stok -= miktar; return true; }
            return false;
        }

        // Çok Biçimlilik (Polymorphism) 
        public virtual string UrunTurunuGetir()
        {
            return "Standart"; 
        }
    }

    // Kalıtım (Inheritance) 1
    public class GidaUrunu : Urun
    {
        public GidaUrunu(string barkod, string ad, int stok, double alis, double satis) 
            : base(barkod, ad, stok, alis, satis) { }

        // Çok Biçimlilik (Polymorphism) Metot Ezme
        public override string UrunTurunuGetir()
        {
            return "Gıda"; 
        }
    }

    // Kalıtım (Inheritance) 2
    public class TeknolojiUrunu : Urun
    {
        public TeknolojiUrunu(string barkod, string ad, int stok, double alis, double satis) 
            : base(barkod, ad, stok, alis, satis) { }

        // Çok Biçimlilik (Polymorphism) Metot Ezme
        public override string UrunTurunuGetir()
        {
            return "Teknoloji"; 
        }
    }

    // Kalıtım (Inheritance) 3
    public class TemizlikUrunu : Urun
    {
        public TemizlikUrunu(string barkod, string ad, int stok, double alis, double satis) 
            : base(barkod, ad, stok, alis, satis) { }

        // Çok Biçimlilik (Polymorphism) Metot Ezme
        public override string UrunTurunuGetir()
        {
            return "Temizlik"; 
        }
    }
}
