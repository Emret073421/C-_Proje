namespace Mayın_Tarlası_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Button[,] buttons;
        int size;
        int xeksen;
        int yeksen;
        int bombs;
        int skor;
        int sayac;
        private bool[,] mines;
        private void button1_Click(object sender, EventArgs e)
        {
            if (buttons != null)
            {
                foreach (var button in buttons)
                {
                    if (button != null)
                        this.Controls.Remove(button);
                }
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Oyuna başlamak için lütfen bir sayı giriniz.");
            }
            else
            {
                size = Convert.ToInt32(textBox1.Text);
            }

            if (size > 16)
            {
                MessageBox.Show("Oyuna başlamak için lütfen onaltı veya onaltıdan daha küçük bir sayı giriniz.");
            }
            else if (size <= 2)
            {
                MessageBox.Show("Oyuna başlamak için lütfen  bir sayı giriniz.");
            }
            else
            {
                skor = 0;
                sayac = 0;
                textBox2.Text = skor.ToString();
                buttons = new Button[size, size];
                mayın();
                mayıntarlası();

            }
        }
        private void boyutlar()
        {
            int x = Convert.ToInt32(textBox1.Text);

            if (x == 3) { xeksen = 385; yeksen = 425; }
            if (x == 4) { xeksen = 355; yeksen = 395; }
            if (x == 5) { xeksen = 325; yeksen = 365; }
            if (x == 6) { xeksen = 295; yeksen = 335; }
            if (x == 7) { xeksen = 265; yeksen = 305; }
            if (x == 8) { xeksen = 235; yeksen = 275; }
            if (x == 9) { xeksen = 205; yeksen = 245; }
            if (x == 10) { xeksen = 175; yeksen = 215; }
            if (x == 11) { xeksen = 145; yeksen = 185; }
            if (x == 12) { xeksen = 115; yeksen = 155; }
            if (x == 13) { xeksen = 85; yeksen = 125; }
            if (x == 14) { xeksen = 55; yeksen = 95; }
            if (x == 15) { xeksen = 25; yeksen = 65; }
            if (x == 16) { xeksen = 25; yeksen = 65; }
        }
        private void mayıntarlası()
        {
            boyutlar();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Button btn = new Button();

                    btn.Size = new Size(50, 50);
                    btn.BackColor = Color.DarkGreen;
                    btn.Location = new Point(xeksen + j * 55, yeksen + i * 55);
                    btn.Tag = new Point(i, j);

                    this.Controls.Add(btn);
                    buttons[i, j] = btn;

                    btn.Click += (s, e) =>
                    {
                        Button clickedButton = (Button)s;
                        Point coords = (Point)clickedButton.Tag;
                        int x = coords.X;
                        int y = coords.Y;
                        int k = 0;

                        if (mines[x, y])
                        {

                            foreach (var button in buttons)
                            {
                                if (button != null)
                                    this.Controls.Remove(button);
                            }
                            MessageBox.Show("Mayına bastığınız için kayıp ettiniz.Skorunuz;" + " " + textBox2.Text);
                        }

                        else
                        {
                            clickedButton.BackColor = Color.LightGreen; 
                            skor++;
                            textBox2.Text = skor.ToString();
                            sayac++;
                            if (sayac == (size * size) - bombs)
                            {
                                MessageBox.Show("Tebrikler bütün güvenli bölgeleri buldunuz. Skorunuz:" + " " + textBox2.Text);
                                foreach (var button in buttons)
                                {
                                    if (button != null)
                                        this.Controls.Remove(button);
                                }
                            }
                        }


                        if (x > 0 && y > 0 && mines[x - 1, y - 1]) k++;
                        if (x > 0 && mines[x - 1, y]) k++;
                        if (y > 0 && mines[x, y - 1]) k++;
                        if (x < size - 1 && y < size - 1 && mines[x + 1, y + 1]) k++;
                        if (x < size - 1 && mines[x + 1, y]) k++;
                        if (y < size - 1 && mines[x, y + 1]) k++;
                        if (x > 0 && y < size - 1 && mines[x - 1, y + 1]) k++;
                        if (x < size - 1 && y > 0 && mines[x + 1, y - 1]) k++;
                        clickedButton.Text = k.ToString();
                    };
                }
            }
        }
        private void mayın()
        {

            mines = new bool[size, size];

            Random random = new Random();
            bombs = (size * size * 20) / 100;

            int m = 1;

            while (m <= bombs)
            {
                int x = random.Next(0, size);
                int y = random.Next(0, size);

                if (!mines[x, y])
                {
                    mines[x, y] = true;
                    m++;
                }
            }
        }

    }
}


