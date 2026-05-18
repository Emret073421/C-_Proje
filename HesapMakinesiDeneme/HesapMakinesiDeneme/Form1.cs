using System.Diagnostics.Eventing.Reader;

namespace HesapMakinesiDeneme
{
    public partial class Form1 : Form
    {

        double birincisayi;
        double ikincisayi;
        double sonuc;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            e.Handled = true;
        }

        //Ekrana Yazdýrma
        private void TopluSayiClick(object sender, EventArgs e)
        {
            Button BTNsayi = (Button)sender;

            textBox1.Text += BTNsayi.Text;
        }
        Button BTNOperator;
        private void TopluOperatorClick(object sender, EventArgs e)
        {
            BTNOperator = (Button)sender;

            //Hata Kontrolü
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Bir Sayý Giriniz.");
            }
            //Ýlk Operatör Seçimi
            else if (label3.Text == ".")
            {
                switch (BTNOperator.Text)
                {
                    case "+": label2.Text = BTNOperator.Text; break;
                    case "-": label2.Text = BTNOperator.Text; break;
                    case "x": label2.Text = BTNOperator.Text; break;
                    case "%": label2.Text = BTNOperator.Text; break;
                }
                label3.Text = textBox1.Text;
                birincisayi = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            //Hesaolama
            else if (textBox1.Text != "" && label2.Text != "" && label2.Text == BTNOperator.Text && label3.Text != ".")
            {
                hesapla();
            } 
            
        }
        //Temizleme
        private void temizleBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = ".";
            label3.Text = ".";
        }
        //Silme
        private void SilBtn_Click(object sender, EventArgs e)
        {
            string kutu = textBox1.Text;
            int kutuGeniþligi = kutu.Length;
            textBox1.Text = "";

            int i = 0;
            while (i < kutuGeniþligi - 1)
            {
                textBox1.Text += kutu[i];
                i++;
            }
        }

        //Hesaplama eþittir butonu
        private void esittirBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Bir Sayý Giriniz.");
            }
            else if (textBox1.Text != "" && label2.Text != "" && label2.Text == BTNOperator.Text && label3.Text != ".")
            {
                hesapla();
            }
        }
        //Hesaplama eþittir butonu olmadan
        public void hesapla()
        {
            ikincisayi = Convert.ToDouble(textBox1.Text);
            switch (BTNOperator.Text)
            {
                case "+": sonuc = birincisayi + ikincisayi; break;
                case "-": sonuc = birincisayi - ikincisayi; break;
                case "x": sonuc = birincisayi * ikincisayi; break;
                case "%": sonuc = birincisayi / ikincisayi; break;
            }
            textBox1.Text = sonuc.ToString();
            label2.Text = ".";
            label3.Text = ".";
        }
    }
}