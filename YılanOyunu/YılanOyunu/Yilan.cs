using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YılanOyunu
{
    internal class Yilan:Elma
    {
        static int sayac = 0;
        public Panel kafa = new Panel();
        public List<Panel> gövdetoplayıcı = new List <Panel> ();
        public int x  = 300;
        public int y  = 300;
        int kuyruk = 0 ;


        //10-610 soldan sağa
        //100-700 yukardan aşağı
        public void kafaekle(Panel OyunTahtasi) 
        {
            kafa.BackColor = Color.Brown;
            kafa.Location = new Point (x, y);
            kafa.Width = 30;
            kafa.Height = 30;
            OyunTahtasi.Controls.Add (kafa);
        }


        public void kafahareketi(int yeniX, int yeniY)
        {
            x = yeniX;
            y = yeniY;
            kafa.Location = new Point(x, y);
        }

        public void govdeekle(Panel OyunTahtasi)
        {
            Panel yeniGovde = new Panel();
            kuyruk++;
            yeniGovde.Name = "gövde" + kuyruk;
            yeniGovde.BackColor = Color.Yellow;
            yeniGovde.Width = 30;
            yeniGovde.Height = 30; 
            gövdetoplayıcı.Add(yeniGovde);
            OyunTahtasi.Controls.Add(yeniGovde);
        }


        public void gövdehareketi()
        {
            if (gövdetoplayıcı.Count == 0) return;

            // Son segmentten başlayarak her segmenti bir öncekine taşı
            for (int i = gövdetoplayıcı.Count - 1; i > 0; i--)
            {
                gövdetoplayıcı[i].Location = gövdetoplayıcı[i - 1].Location;
            }
            // İlk gövde parçası kafanın eski konumuna gelir
            gövdetoplayıcı[0].Location = kafa.Location;
        }

    }
}
