namespace YılanOyunu
{
    partial class AnaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            OyunTahtasi = new Panel();
            label1 = new Label();
            button1 = new Button();
            SüreKutu = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // OyunTahtasi
            // 
            OyunTahtasi.BackColor = Color.FromArgb(128, 255, 128);
            OyunTahtasi.Location = new Point(10, 100);
            OyunTahtasi.Name = "OyunTahtasi";
            OyunTahtasi.Size = new Size(600, 600);
            OyunTahtasi.TabIndex = 1;
           
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 31);
            label1.TabIndex = 3;
            label1.Text = "Süre:";
            // 
            // button1
            // 
            button1.Location = new Point(442, 25);
            button1.Name = "button1";
            button1.Size = new Size(94, 71);
            button1.TabIndex = 4;
            button1.Text = "Başla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SüreKutu
            // 
            SüreKutu.AutoSize = true;
            SüreKutu.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            SüreKutu.Location = new Point(95, 9);
            SüreKutu.Name = "SüreKutu";
            SüreKutu.Size = new Size(27, 31);
            SüreKutu.TabIndex = 5;
            SüreKutu.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label3.Location = new Point(210, 9);
            label3.Name = "label3";
            label3.Size = new Size(69, 31);
            label3.TabIndex = 6;
            label3.Text = "Skor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label4.Location = new Point(285, 9);
            label4.Name = "label4";
            label4.Size = new Size(27, 31);
            label4.TabIndex = 7;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label5.Location = new Point(167, 54);
            label5.Name = "label5";
            label5.Size = new Size(145, 31);
            label5.TabIndex = 8;
            label5.Text = "Yüksek Skor:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label6.Location = new Point(318, 54);
            label6.Name = "label6";
            label6.Size = new Size(27, 31);
            label6.TabIndex = 9;
            label6.Text = "0";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 500;
            timer2.Tick += timer2_Tick;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 723);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(SüreKutu);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(OyunTahtasi);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AnaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            
            KeyUp += Form1_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel OyunTahtasi;
        private Label label1;
        private Button button1;
        private Label SüreKutu;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
