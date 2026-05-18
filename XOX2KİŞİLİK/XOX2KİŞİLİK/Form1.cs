namespace XOX2KİŞİLİK
{
    public partial class Form1 : Form
    {
        bool X_sıra;
        bool O_sıra;

        int x_sayac = 0;
        int o_sayac = 0;

        int islem_sayısı = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void X_Belirle()
        {
            string tx = kullanıcıX.Text;

            //Yatay
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {

                MessageBox.Show(tx + " " + "Kazandı", "Tebrikler");
                Temizle();
                x_sayac++;
                xPuan.Text = x_sayac.ToString();

            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {

                MessageBox.Show(tx + " " + "Kazandı", "Tebrikler");
                Temizle();
                x_sayac++;
                xPuan.Text = x_sayac.ToString();

            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {

                MessageBox.Show(tx + " " + "Kazandı", "Tebrikler");
                Temizle();
                x_sayac++;
                xPuan.Text = x_sayac.ToString();

            }

            //Dikey
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {

                MessageBox.Show(tx + " " + "Kazandı", "Tebrikler");
                Temizle();
                x_sayac++;
                xPuan.Text = x_sayac.ToString();

            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {

                MessageBox.Show(tx + " " + "Kazandı", "Tebrikler");
                Temizle();
                x_sayac++;
                xPuan.Text = x_sayac.ToString();

            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {

                MessageBox.Show(tx + " " + "Kazandı", "Tebrikler");
                Temizle();
                x_sayac++;
                xPuan.Text = x_sayac.ToString();
            }

            //Köşegen
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {

                MessageBox.Show(tx + " " + "Kazandı", "Tebrikler");
                Temizle();
                x_sayac++;
                xPuan.Text = x_sayac.ToString();

            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {

                MessageBox.Show(tx + " " + "Kazandı", "Tebrikler");
                Temizle();
                x_sayac++;
                xPuan.Text = x_sayac.ToString();

            }

            if (islem_sayısı==9)
            {
                berabere();
            }

        }

        private void O_Belirle()
        {

            string ty = kullanıcıY.Text;
            //Yatay
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {

                MessageBox.Show(ty + " " + "Kazandı", "Tebrikler");
                Temizle();
                o_sayac++;
                yPuan.Text = o_sayac.ToString();

            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {

                MessageBox.Show(ty + " " + "Kazandı", "Tebrikler");
                Temizle();
                o_sayac++;
                yPuan.Text = o_sayac.ToString();

            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {

                MessageBox.Show(ty + " " + "Kazandı", "Tebrikler");
                Temizle();
                o_sayac++;
                yPuan.Text = o_sayac.ToString();

            }

            //Dikey
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {

                MessageBox.Show(ty + " " + "Kazandı", "Tebrikler");
                Temizle();
                o_sayac++;
                yPuan.Text = o_sayac.ToString();

            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {

                MessageBox.Show(ty + " " + "Kazandı", "Tebrikler");
                Temizle();
                o_sayac++;
                yPuan.Text = o_sayac.ToString();

            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {

                MessageBox.Show(ty + " " + "Kazandı", "Tebrikler");
                Temizle();
                o_sayac++;
                yPuan.Text = o_sayac.ToString();
            }

            //Köşegen
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {

                MessageBox.Show(ty + " " + "Kazandı", "Tebrikler");
                Temizle();
                o_sayac++;
                yPuan.Text = o_sayac.ToString();

            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {

                MessageBox.Show(ty + " " + "Kazandı", "Tebrikler");
                Temizle();
                o_sayac++;
                yPuan.Text = o_sayac.ToString();

            }

     

        }

        public void berabere()
        {
            if (islem_sayısı == 9)
            {
                MessageBox.Show("Berabere Kaldınız", "Tebrikler");
                Temizle();
            }


        }
        private void Temizle()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            X_sıra = true;
            O_sıra = false;

            islem_sayısı = 0;
        }

        private void Tolu_Tik(object sender, EventArgs e)
        {
            Button bd = (Button)sender;
            

            if (X_sıra)
            {
                X_sıra = false;
                O_sıra = true;

                bd.Text = "X";
                bd.Enabled = false;

                islem_sayısı++;
                X_Belirle();
            }

            else if (O_sıra)
            {
                X_sıra = true;
                O_sıra = false;

                bd.Text = "O";
                bd.Enabled = false;

                islem_sayısı++;
                O_Belirle();
            }

            

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            X_sıra = false;
            O_sıra = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(kullanıcıX.Text) || string.IsNullOrEmpty(kullanıcıY.Text))
            {
                MessageBox.Show("Lütfen oyuna başlamadan önce bir isim giriniz.", "Dikkat!");

            }
            else
            {
                X_sıra = true;
                O_sıra = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Temizle();
            X_sıra = false;
            O_sıra = false;

            xPuan.Text = "";
            yPuan.Text = "";
        }
    }
}
