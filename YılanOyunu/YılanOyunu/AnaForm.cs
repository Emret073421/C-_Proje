using System.Runtime.CompilerServices;

namespace YılanOyunu
{
    public partial class AnaForm : Form
    {

        //10-610 soldan sağa
        //100-700 yukardan aşağı

        //Ana Kontrol 
        int skor = 0;
        int süre = 0;
        Oynanıs hareket = new Oynanıs();
        Yilan yilan = new Yilan();
        Elma elma = new Elma();

        public AnaForm()
        {
            InitializeComponent();
        }

        //Süre
        private void timer1_Tick(object sender, EventArgs e)
        {
            süre++;
            SüreKutu.Text = süre.ToString();
        }

        //Yılan Hızı 
        private void timer2_Tick(object sender, EventArgs e)
        {
            //Oynanıs taradında kafa için konum ayarlanıyor
            if (hareket.anlık == "Saga") hareket.xkafa += 30;
            if (hareket.anlık == "Sola") hareket.xkafa -= 30;
            if (hareket.anlık == "Yukarı") hareket.ykafa -= 30;
            if (hareket.anlık == "Asagı") hareket.ykafa += 30;

            //Oynanıs tarafında ayarlanan konum a ve b ye aktarılıyor
            int a = hareket.xkafa;
            int b = hareket.ykafa;

            //Yilan konumu 
            yilan.kafahareketi(a, b);
            // Oyun kontrol edildiği kısım oynanısta
            hareket.sınırlar(a, b , OyunTahtasi);
            //---------
            OyunKontrol();
            if (hareket.Devam == false)
            {
                OyunSifirla();
                if (skor > Convert.ToInt32(label6.Text))
                {
                    label6.Text = skor.ToString();
                    skor = 0;
                    label4.Text = skor.ToString();
                }
            }
            yilan.gövdehareketi();

        }

        //Oyunu Başlat
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            hareket.Devam = true;
            yilan.kafaekle(OyunTahtasi);
            elma.ElmaOluştur(OyunTahtasi);
        }

        //Hareket
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && hareket.anlık != "Asagı") hareket.anlık = hareket.yön[0]; //Yuları
            if (e.KeyCode == Keys.Down && hareket.anlık != "Yukarı") hareket.anlık = hareket.yön[1];//Asagı
            if (e.KeyCode == Keys.Right && hareket.anlık != "Sola") hareket.anlık = hareket.yön[2];//Saga
            if (e.KeyCode == Keys.Left && hareket.anlık != "Saga") hareket.anlık = hareket.yön[3];//Sola
        }

        //Oyunu Sıfırlama Metodu
        private void OyunSifirla()
        {
            // Timer durdur
            timer1.Stop();
            timer2.Stop();
            // Oyun tahtasını temizle
            OyunTahtasi.Controls.Clear();
            // Süreyi sıfırla
            süre = 0;
            SüreKutu.Text = "0";

            // Yılan ve elmayı yeniden oluştur
            hareket = new Oynanıs();
            yilan = new Yilan();
            elma = new Elma();

            MessageBox.Show("Oyun bitti! Yeniden başlamak için Start butonuna bas.");
        }


        //Kontrol
        public void OyunKontrol()
        {
            //Elmayı yiyip yemediğini kontrol ediyor
            if (elma.xekseni == hareket.xkafa && elma.yekseni == hareket.ykafa)
            {
                skor += 20;
                label4.Text = skor.ToString();
                yilan.govdeekle(OyunTahtasi);
                elma.ElmaOluştur(OyunTahtasi);
            }

            //Yılanın kuyruğunun çarpıp çarpmadığını kontrol ediyo
            if (yilan.gövdetoplayıcı.Count > 3)
            {
                for (int i = 3; i < yilan.gövdetoplayıcı.Count; i++)
                {
                    if (yilan.gövdetoplayıcı[i].Location == yilan.kafa.Location)
                    {
                        if (skor > Convert.ToInt32(label6.Text)) 
                        { 
                            label6.Text = skor.ToString();
                            skor = 0;
                            label4.Text = skor.ToString();
                        }
                        OyunSifirla();
                        break; // bulunca döngüden çık
                    }
                }

            }

        }        
    }
}
