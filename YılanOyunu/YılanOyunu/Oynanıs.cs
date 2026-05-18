using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YılanOyunu
{
    internal class Oynanıs : Yilan
    {

        //10-610 soldan sağa
        //100-700 yukardan aşağı
        // Oyunu başlatan bitiren değişken
        public bool Devam = true;

        //Oyun Yönleri
        public string[] yön = { "Yukarı", "Asagı", "Saga", "Sola" };
        public string anlık = "Saga";

        //Hareket için kullanılan değişkenler
        public int ykafa = 300;
        public int xkafa = 300;

        //Tahtanın Sınırları
        public void sınırlar (int YeniX , int YeniY , Panel OyunTahtasi)
        {
            if (YeniX == -30 || YeniX == 600 || YeniY == -30 || YeniY == 600) 
            {
                MessageBox.Show("Kaybettiniz");
                Devam = false;
            } 
        }

        
    }
}
