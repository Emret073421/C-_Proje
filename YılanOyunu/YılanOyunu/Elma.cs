using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace YılanOyunu
{
    internal class Elma
    {

       //10-610 soldan sağa
       //100-700 yukardan aşağı

        
        private static Random R = new Random();
        
       
        private int[] eleman = new int[30];
       
        //Rastgele index seçilen kısım
        private int indexx;
        private int indexy;

        //Elmanın konumunun aktarıldığı kısım
        public int xekseni;
        public int yekseni;

        public Panel elma = new Panel();

        //Elmayı Oluşturan kod bloğu
        public void ElmaOluştur(Panel OyunTahtası) 
        {
            rastgele();
            elma.BackColor = Color.Red;
            elma.Location = new Point(xekseni, yekseni);
            elma.Width = 30;
            elma.Height = 30;
            OyunTahtası.Controls.Add(elma);
        }

        //Elmayı yerleştiren kod bloğu
        public void rastgele()
        {
            //Konum için sayılar oluşturulur
            for (int i = 0 ; i < 20; i++)
            {
                int a =(i*30);
                eleman[i] = a;
            }

            //Rastgele indisler seçilir
            indexx = R.Next(0,20);
            indexy = R.Next(0,20);

            //seçilen indisler elemana aktarılır ve elman eksenlere aktarılır
            xekseni = eleman[indexx];
            yekseni = eleman[indexy];
            
        }

    }
}
