using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int dogru = 0, yanlis = 0, soru = 0, sayac = 15;
        private Button sender;

        private void Buton()
        {
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnA.Enabled = false;
            btnBasla.Enabled = true;
        }

        private void Cevap()
        {
            switch (soru)
            {
                case 1: btnC.BackColor = Color.Green; break;
                case 2: btnA.BackColor = Color.Green; break;
                case 3: btnB.BackColor = Color.Green; break;
                case 4: btnD.BackColor = Color.Green; break;
                case 5: btnC.BackColor = Color.Green; break;
                case 6: btnD.BackColor = Color.Green; break;
                case 7: btnA.BackColor = Color.Green; break;
                case 8: btnC.BackColor = Color.Green; break;
                case 9: btnB.BackColor = Color.Green; break;
                default: btnA.BackColor = Color.Green; break;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            Buton();

            Button btn = (sender as Button);
            btn.BackColor = Color.Yellow;

            Application.DoEvents();
            Thread.Sleep(1000);

            if (lblSoruCevap.Text == lblDogruCevap.Text)
            {
                btn.BackColor = Color.Green;
            }
            else
            {
                btn.BackColor = Color.Red;
                Cevap();
            }

            lblSoruCevap.Text = btnA.Text;

            Sonuc();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            Buton();

            Button btn = (sender as Button);
            btn.BackColor = Color.Yellow;

            Application.DoEvents();
            Thread.Sleep(1000);

            if (lblSoruCevap.Text == lblDogruCevap.Text)
            {
                btn.BackColor = Color.Green;
            }
            else
            {
                btn.BackColor = Color.Red;
                Cevap();
            }

            lblSoruCevap.Text = btnB.Text;

            Sonuc();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Buton();

            Button btn = (sender as Button);
            btn.BackColor = Color.Yellow;

            Application.DoEvents();
            Thread.Sleep(1000);

            if (lblSoruCevap.Text == lblDogruCevap.Text)
            {
                btn.BackColor = Color.Green;
            }
            else
            {
                btn.BackColor = Color.Red;
                Cevap();
            }

            lblSoruCevap.Text = btnC.Text;

            Sonuc();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            btn.BackColor = Color.Yellow;

            Application.DoEvents();
            Thread.Sleep(1000);

            Buton();

            if (lblSoruCevap.Text == lblDogruCevap.Text)
            {
                btn.BackColor = Color.Green;
            }
            else
            {
                btn.BackColor = Color.Red;
                Cevap();
            }

            lblSoruCevap.Text = btnD.Text;

            Sonuc();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Buton();
        }

        private void Sonuc()
        {
            if (lblSoruCevap.Text == lblDogruCevap.Text)
            {
                dogru++;
                lblDogruSayisi.Text = dogru.ToString();

                timer1.Stop();
            }
            else
            {
                yanlis++;
                lblYanlısSayisi.Text = yanlis.ToString();

                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            lblSayac.Text = sayac.ToString();

            if (sayac == 0)
            {
                timer1.Stop();

                Buton();

                MessageBox.Show("Doğru cevap: " + lblDogruCevap.Text);
            }

        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            sayac = 15;
            timer1.Start();

            btnA.BackColor = Color.OrangeRed;
            btnB.BackColor = Color.OrangeRed;
            btnC.BackColor = Color.OrangeRed;
            btnD.BackColor = Color.OrangeRed;

            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnBasla.Enabled = false;

            soru++;

            lblsoruSayisi.Text = soru.ToString();

            btnBasla.Text = "Sonraki";

            if (soru == 1)
            {
                Sorular.Text = "Sefiller, kitabının yazarı kimdir?";

                btnA.Text = "William Shakespeare";
                btnB.Text = "Balzac";
                btnC.Text = "Victor Hugo";
                btnD.Text = "Franz Kafka";

                lblDogruCevap.Text = btnC.Text;
            }
            else if (soru == 2)
            {
                Sorular.Text = "Waterloo Savaşı ne zaman yapıldı?";

                btnA.Text = "1815";
                btnB.Text = "1816";
                btnC.Text = "1817";
                btnD.Text = "1818";

                lblDogruCevap.Text = btnA.Text;
            }
            else if (soru == 3)
            {
                sayac = 30;

                Sorular.Text = "'Kizil Gezegen' olarak bilenen gezegen hangisidir?";

                btnA.Text = "Jupiter";
                btnB.Text = "Mars";
                btnC.Text = "Satürn";
                btnD.Text = "Plüto";

                lblDogruCevap.Text = btnB.Text;
            }
            else if (soru == 4)
            {
                sayac = 30;

                Sorular.Text = "Bilim adamı bir dede ve torunu konu alan yabancı dizi hangisidir?";

                btnA.Text = "South Park";
                btnB.Text = "Simpsons";
                btnC.Text = "Fortuna";
                btnD.Text = "Rick and Morty";

                lblDogruCevap.Text = btnD.Text;
            }
            else if (soru == 5)
            {
                sayac = 30;

                Sorular.Text = "Ferman padişahınsa dağlar bizimdir, sözü hangi Halk Şairi'ne aittir?";

                btnA.Text = "Köroğlu";
                btnB.Text = "Kayıkçı Kul Mustafa";
                btnC.Text = "Dadaloğlu";
                btnD.Text = "Aşık Ömer";

                lblDogruCevap.Text = btnC.Text;
            }
            else if (soru == 6)
            {
                sayac = 30;

                Sorular.Text = "Nutuk, hangi yıllar arasını anlatmaktadır?";

                btnA.Text = "1916-1924";
                btnB.Text = "1917-1925";
                btnC.Text = "1918-1926";
                btnD.Text = "1919-1927";

                lblDogruCevap.Text = btnD.Text;
            }
            else if (soru == 7)
            {
                sayac = 30;

                Sorular.Text = "Süngerbob'un evcil hayvanın ismi nedir?";

                btnA.Text = "Gary";
                btnB.Text = "Bolt";
                btnC.Text = "Perry";
                btnD.Text = "Karabaş";

                lblDogruCevap.Text = btnA.Text;
            }
            else if (soru == 8)
            {
                sayac = 30;

                Sorular.Text = "Star Wars film serisinde Anakin Skywalker karakterinin astromech droidi hangisidir?";

                btnA.Text = "R2-A6";
                btnB.Text = "R2-C4";
                btnC.Text = "R2-D2";
                btnD.Text = "R2-X2";

                lblDogruCevap.Text = btnC.Text;
            }
            else if (soru == 9)
            {
                sayac = 30;

                Sorular.Text = "Sherlock Holmes'ün yakın arkadaşı ve ortağı kimdir?";

                btnA.Text = "Dr. Strange";
                btnB.Text = "Dr. Watson";
                btnC.Text = "Dr. Doom";
                btnD.Text = "Dr. Evil";

                lblDogruCevap.Text = btnB.Text;
            }
            else if (soru == 10)
            {
                sayac = 30;

                Sorular.Text = "Dark Souls, oyunun oyun yönetmeni kimdir?";

                btnA.Text = "Hidetaka Miyazaki";
                btnB.Text = "Alec Robbins";
                btnC.Text = "Patrice Désilets";
                btnD.Text = "Adam Badowski";

                lblDogruCevap.Text = btnA.Text;
            }
            else
            {
                timer1.Stop();

                lblsoruSayisi.Text = "10";

                MessageBox.Show("Doğru sayısı: " + dogru.ToString() + "\nYanlış Sayısı: " + yanlis.ToString());
            }
        }
    }
}
