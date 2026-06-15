using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class SepetItem
    {
        // Kapsülleme (Encapsulation) - Private Alanlar
        private Urun _urun;
        private int _adet;

        // Özellikler (Properties)
        public Urun Urun { get => _urun; set => _urun = value; }
        public int Adet { get => _adet; set => _adet = value; }
        public double AraToplam => _urun.SatisFiyati * _adet;

        // Kurucu Metot (Constructor)
        public SepetItem(Urun urun, int adet)
        {
            _urun = urun;
            _adet = adet;
        }
    }

    public class Sepet
    {
        // Kapsülleme (Encapsulation) - Private Alanlar
        private List<SepetItem> _liste = new List<SepetItem>();

        // Metotlar (Methods)
        public void Ekle(Urun u, int a) => _liste.Add(new SepetItem(u, a));
        public List<SepetItem> GetUrunler() => _liste;
        public void Temizle() => _liste.Clear();
    }
}
