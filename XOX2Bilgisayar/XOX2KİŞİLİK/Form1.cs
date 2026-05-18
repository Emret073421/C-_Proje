using System.Diagnostics.Eventing.Reader;

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

        
        private void Tersi_Belirle()
        {
            

            string to = "";
            string tx = "";
            if (x)
            {
                tx = "X";
                
            }
            else
            {
                tx = "O";
                
            }

            string tk = kullaniciX.Text;
            //Yatay
            if (button1.Text == tx && button2.Text == tx && button3.Text == tx)
            {

                MessageBox.Show(tk + " " + "Kazandı", "Tebrikler");
                Temizle();
                x_sayac++;
                xPuan.Text = x_sayac.ToString();
                islem_sayısı = 0;

            }
            if (button4.Text == tx && button5.Text == tx && button6.Text == tx)
            {

                MessageBox.Show(tk + " " + "Kazandı", "Tebrikler");
                Temizle();
                x_sayac++;
                xPuan.Text = x_sayac.ToString();
                islem_sayısı = 0;

            }
            if (button7.Text == tx && button8.Text == tx && button9.Text == tx)
            {

                MessageBox.Show(tk + " " + "Kazandı", "Tebrikler");
                Temizle();
                x_sayac++;
                xPuan.Text = x_sayac.ToString();
                islem_sayısı = 0;

            }

            //Dikey
            if (button1.Text == tx && button4.Text == tx && button7.Text == tx)
            {

                MessageBox.Show(tk + " " + "Kazandı", "Tebrikler");
                Temizle();
                x_sayac++;
                xPuan.Text = x_sayac.ToString();
                islem_sayısı = 0;

            }
            if (button2.Text == tx && button5.Text == tx && button8.Text == tx)
            {

                MessageBox.Show(tk + " " + "Kazandı", "Tebrikler");
                Temizle();
                x_sayac++;
                xPuan.Text = x_sayac.ToString();
                islem_sayısı = 0;

            }
            if (button3.Text == tx && button6.Text == tx && button9.Text == tx)
            {

                MessageBox.Show(tk + " " + "Kazandı", "Tebrikler");
                Temizle();
                x_sayac++;
                xPuan.Text = x_sayac.ToString();
                islem_sayısı = 0;
            }

            //Köşegen
            if (button1.Text == tx && button5.Text == tx && button9.Text == tx)
            {

                MessageBox.Show(tk + " " + "Kazandı", "Tebrikler");
                Temizle();
                x_sayac++;
                xPuan.Text = x_sayac.ToString();
                islem_sayısı = 0;

            }
            if (button3.Text == tx && button5.Text == tx && button7.Text == tx)
            {

                MessageBox.Show(tk + " " + "Kazandı", "Tebrikler");
                Temizle();
                x_sayac++;
                xPuan.Text = x_sayac.ToString();
                islem_sayısı = 0;

            }

            if (islem_sayısı == 9)
            {
                berabere();
            }

        }

        private void O_Belirle()
        {
            string to = "";
            string tx = "";
            if (x)
            {
                to = "O";
                
            }
            else
            {
                to = "X";
                
            }
            string ty = kullanıcıY.Text;
            //Yatay
            if (button1.Text == to && button2.Text == to && button3.Text == to)
            {

                MessageBox.Show(ty + " " + "Kazandı", "Tebrikler");
                Temizle();
                o_sayac++;
                yPuan.Text = o_sayac.ToString();
                islem_sayısı = 0;

            }
            if (button4.Text == to && button5.Text == to && button6.Text == to)
            {

                MessageBox.Show(ty + " " + "Kazandı", "Tebrikler");
                Temizle();
                o_sayac++;
                yPuan.Text = o_sayac.ToString();
                islem_sayısı = 0;

            }
            if (button7.Text == to && button8.Text == to && button9.Text == to)
            {

                MessageBox.Show(ty + " " + "Kazandı", "Tebrikler");
                Temizle();
                o_sayac++;
                yPuan.Text = o_sayac.ToString();
                islem_sayısı = 0;

            }

            //Dikey
            if (button1.Text == to && button4.Text == to && button7.Text == to)
            {

                MessageBox.Show(ty + " " + "Kazandı", "Tebrikler");
                Temizle();
                o_sayac++;
                yPuan.Text = o_sayac.ToString();
                islem_sayısı = 0;

            }
            if (button2.Text == to && button5.Text == to && button8.Text == to)
            {

                MessageBox.Show(ty + " " + "Kazandı", "Tebrikler");
                Temizle();
                o_sayac++;
                yPuan.Text = o_sayac.ToString();
                islem_sayısı = 0;

            }
            if (button3.Text == to && button6.Text == to && button9.Text == to)
            {

                MessageBox.Show(ty + " " + "Kazandı", "Tebrikler");
                Temizle();
                o_sayac++;
                yPuan.Text = o_sayac.ToString();
                islem_sayısı = 0;
            }

            //Köşegen
            if (button1.Text == to && button5.Text == to && button9.Text == to)
            {

                MessageBox.Show(ty + " " + "Kazandı", "Tebrikler");
                Temizle();
                o_sayac++;
                yPuan.Text = o_sayac.ToString();
                islem_sayısı = 0;

            }
            if (button3.Text == to && button5.Text == to && button7.Text == to)
            {

                MessageBox.Show(ty + " " + "Kazandı", "Tebrikler");
                Temizle();
                o_sayac++;
                yPuan.Text = o_sayac.ToString();
                islem_sayısı = 0;

            }

            if (islem_sayısı == 9)
            {
                berabere();
            }
        }

        public void berabere()
        {
            if (islem_sayısı == 9)
            {
                MessageBox.Show("Berabere Kaldınız", "Tebrikler");
                X_sıra = true;
                O_sıra = false;
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

        }

        private void Tolu_Tik(object sender, EventArgs e)
        {

            Button bd = (Button)sender;

            if (x) 
            {
                if (X_sıra)
                {
                    X_sıra = false;
                    O_sıra = true;

                    bd.Text = "X";
                    bd.Enabled = false;

                    islem_sayısı++;
                    Tersi_Belirle();
                }

                else if (O_sıra)
                {
                    X_sıra = true;
                    O_sıra = false;

                    bilgisayar();
                }
            }
            else {
                if (X_sıra)
                {
                    X_sıra = false;
                    O_sıra = true;

                    bilgisayar();
                    
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


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            X_sıra = false;
            O_sıra = false;
        }
        
        private void bilgisayar()
        {
            string to = "";
            string tx = "";
            if (x)
            {
                 to = "O";
                 tx = "X";
            }
            else
            {
                 to = "X";
                 tx = "O";
            }

            //Y Kısmı----------------------------------------------------------------------------
            //Yatay Sıra 1
            if (button1.Text == to && button2.Text == to && string.IsNullOrEmpty(button3.Text))
            {
                button3.Text = to;
                button3.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button1.Text == to && button3.Text == to && string.IsNullOrEmpty(button2.Text))
            {
                button2.Text = to;
                button2.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button2.Text == to && button3.Text == to && string.IsNullOrEmpty(button1.Text))
            {
                button1.Text = to;
                button1.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            //Yatay Sıra 2
            if (button4.Text == to && button5.Text == to && string.IsNullOrEmpty(button6.Text))
            {
                button6.Text = to;
                button6.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button5.Text == to && button6.Text == to && string.IsNullOrEmpty(button4.Text))
            {
                button4.Text = to;
                button4.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button4.Text == to && button6.Text == to && string.IsNullOrEmpty(button5.Text))
            {
                button5.Text = to;
                button5.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            //Yatay Sıra 3

            if (button7.Text == to && button8.Text == to && string.IsNullOrEmpty(button9.Text))
            {
                button9.Text = to;
                button9.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button7.Text == to && button9.Text == to && string.IsNullOrEmpty(button8.Text))
            {
                button8.Text = to;
                button8.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button8.Text == to && button9.Text == to && string.IsNullOrEmpty(button7.Text))
            {
                button7.Text = to;
                button7.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            //Dikey Sıra 1
            if (button1.Text == to && button4.Text == to && string.IsNullOrEmpty(button7.Text))
            {
                button7.Text = to;
                button7.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button1.Text == to && button7.Text == to && string.IsNullOrEmpty(button4.Text))
            {
                button4.Text = to;
                button4.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button4.Text == to && button7.Text == to && string.IsNullOrEmpty(button1.Text))
            {
                button1.Text = to;
                button1.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }
            //Dikey Sıra 2
            if (button2.Text == to && button5.Text == to && string.IsNullOrEmpty(button8.Text))
            {
                button8.Text = to;
                button8.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button2.Text == to && button8.Text == to && string.IsNullOrEmpty(button5.Text))
            {
                button5.Text = to;
                button5.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button8.Text == to && button5.Text == to && string.IsNullOrEmpty(button2.Text))
            {
                button2.Text = to;
                button2.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }
            //Dikey Sıra 3
            if (button3.Text == to && button6.Text == to && string.IsNullOrEmpty(button9.Text))
            {
                button9.Text = to;
                button9.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button3.Text == to && button9.Text == to && string.IsNullOrEmpty(button6.Text))
            {
                button6.Text = to;
                button6.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button6.Text == to && button9.Text == to && string.IsNullOrEmpty(button3.Text))
            {
                button3.Text = to;
                button3.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            //Soldan Sağa Çapraz
            if (button1.Text == to && button5.Text == to && string.IsNullOrEmpty(button9.Text))
            {
                button9.Text = to;
                button9.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button1.Text == to && button9.Text == to && string.IsNullOrEmpty(button5.Text))
            {
                button5.Text = to;
                button5.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button5.Text == to && button9.Text == to && string.IsNullOrEmpty(button1.Text))
            {
                button1.Text = to;
                button1.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            //Sağdan Sola Çapraz
            if (button3.Text == to && button5.Text == to && string.IsNullOrEmpty(button7.Text))
            {
                button7.Text = to;
                button7.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button3.Text == to && button7.Text == to && string.IsNullOrEmpty(button5.Text))
            {
                button5.Text = to;
                button5.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button5.Text == to && button7.Text == to && string.IsNullOrEmpty(button3.Text))
            {
                button3.Text = to;
                button3.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            //X Kısmı 1 --------------------------------------------------------------------------
            //X Köşe Hamle Yaparsa

            if (button1.Text == tx && string.IsNullOrEmpty(button5.Text))
            {
                button5.Text = to;
                button5.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button3.Text == tx && string.IsNullOrEmpty(button5.Text))
            {
                button5.Text = to;
                button5.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button7.Text == tx && string.IsNullOrEmpty(button5.Text))
            {
                button5.Text = to;
                button5.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button9.Text == tx && string.IsNullOrEmpty(button5.Text))
            {
                button5.Text = to;
                button5.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }


            if (button2.Text == tx && string.IsNullOrEmpty(button5.Text))
            {
                button5.Text = to;
                button5.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button4.Text == tx && string.IsNullOrEmpty(button5.Text))
            {
                button5.Text = to;
                button5.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button6.Text == tx && string.IsNullOrEmpty(button5.Text))
            {
                button5.Text = to;
                button5.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button8.Text == tx && string.IsNullOrEmpty(button5.Text))
            {
                button5.Text = to;
                button5.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            //X Kısmı 2 --------------------------------------------------------------------------
            //Yatay Sıra 1
            if (button1.Text == tx && button2.Text == tx && string.IsNullOrEmpty(button3.Text))
            {
                button3.Text = to;
                button3.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button1.Text == tx && button3.Text == tx && string.IsNullOrEmpty(button2.Text))
            {
                button2.Text = to;
                button2.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button2.Text == tx && button3.Text == tx && string.IsNullOrEmpty(button1.Text))
            {
                button1.Text = to;
                button1.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            //Yatay Sıra 2
            if (button4.Text == tx && button5.Text == tx && string.IsNullOrEmpty(button6.Text))
            {
                button6.Text = to;
                button6.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button5.Text == tx && button6.Text == tx && string.IsNullOrEmpty(button4.Text))
            {
                button4.Text = to;
                button4.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button4.Text == tx && button6.Text == tx && string.IsNullOrEmpty(button5.Text))
            {
                button5.Text = to;
                button5.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            //Yatay Sıra 3

            if (button7.Text == tx && button8.Text == tx && string.IsNullOrEmpty(button9.Text))
            {
                button9.Text = to;
                button9.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button7.Text == tx && button9.Text == tx && string.IsNullOrEmpty(button8.Text))
            {
                button8.Text = to;
                button8.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button8.Text == tx && button9.Text == tx && string.IsNullOrEmpty(button7.Text))
            {
                button7.Text = to;
                button7.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            //Dikey Sıra 1
            if (button1.Text == tx && button4.Text == tx && string.IsNullOrEmpty(button7.Text))
            {
                button7.Text = to;
                button7.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button1.Text == tx && button7.Text == tx && string.IsNullOrEmpty(button4.Text))
            {
                button4.Text = to;
                button4.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button4.Text == tx && button7.Text == tx && string.IsNullOrEmpty(button1.Text))
            {
                button1.Text = to;
                button1.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }
            //Dikey Sıra 2
            if (button2.Text == tx && button5.Text == tx && string.IsNullOrEmpty(button8.Text))
            {
                button8.Text = to;
                button8.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button2.Text == tx && button8.Text == tx && string.IsNullOrEmpty(button5.Text))
            {
                button5.Text = to;
                button5.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button8.Text == tx && button5.Text == tx && string.IsNullOrEmpty(button2.Text))
            {
                button2.Text = to;
                button2.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }
            //Dikey Sıra 3
            if (button3.Text == tx && button6.Text == tx && string.IsNullOrEmpty(button9.Text))
            {
                button9.Text = to;
                button9.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button3.Text == tx && button9.Text == tx && string.IsNullOrEmpty(button6.Text))
            {
                button6.Text = to;
                button6.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button6.Text == tx && button9.Text == tx && string.IsNullOrEmpty(button3.Text))
            {
                button3.Text = to;
                button3.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            //Soldan Sağa Çapraz
            if (button1.Text == tx && button5.Text == tx && string.IsNullOrEmpty(button9.Text))
            {
                button9.Text = to;
                button9.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button1.Text == tx && button9.Text == tx && string.IsNullOrEmpty(button5.Text))
            {
                button5.Text = to;
                button5.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button5.Text == tx && button9.Text == tx && string.IsNullOrEmpty(button1.Text))
            {
                button1.Text = to;
                button1.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            //Sağdan Sola Çapraz
            if (button3.Text == tx && button5.Text == tx && string.IsNullOrEmpty(button7.Text))
            {
                button7.Text = to;
                button7.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button3.Text == tx && button7.Text == tx && string.IsNullOrEmpty(button5.Text))
            {
                button5.Text = to;
                button5.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            if (button5.Text == tx && button7.Text == tx && string.IsNullOrEmpty(button3.Text))
            {
                button3.Text = to;
                button3.Enabled = false;
                islem_sayısı++;
                O_Belirle();
                return;
            }

            //Random

            else
            {
                // Rastgele hareket yap
                List<Button> buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
                List<Button> emptyButtons = buttons.Where(b => string.IsNullOrEmpty(b.Text)).ToList();

                if (emptyButtons.Count > 0)
                {
                    Random rand = new Random();
                    int index = rand.Next(emptyButtons.Count);
                    Button chosenButton = emptyButtons[index];
                    chosenButton.Text = to;
                    chosenButton.Enabled = false;
                    islem_sayısı++;
                    O_Belirle();

                }
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            X_sıra = true;
            O_sıra = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Temizle();
            X_sıra = false;
            O_sıra = false;

            xPuan.Text = "";
            yPuan.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void xPuan_TextChanged(object sender, EventArgs e)
        {

        }
        bool x = true;
        
        private void button12_Click(object sender, EventArgs e)
        {
            
            if (x)
            {
                x= false;
                string gcc = textBox1.Text;
                textBox1.Text = textBox2.Text;
                textBox2.Text = gcc;
            }
            else
            {
                x = true; string 
                gcc = textBox1.Text;
                textBox1.Text = textBox2.Text;
                textBox2.Text = gcc;
            }
        }
    }
}
