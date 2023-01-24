namespace Bilgi_Yarisi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnBasla = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblsoruSayisi = new System.Windows.Forms.Label();
            this.lblYanlısSayisi = new System.Windows.Forms.Label();
            this.lblDogruSayisi = new System.Windows.Forms.Label();
            this.lblSoru = new System.Windows.Forms.Label();
            this.lblYanlis = new System.Windows.Forms.Label();
            this.lblDogru = new System.Windows.Forms.Label();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.lblSayac = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSoruCevap = new System.Windows.Forms.Label();
            this.lblDogruCevap = new System.Windows.Forms.Label();
            this.Sorular = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.OrangeRed;
            this.btnA.Location = new System.Drawing.Point(12, 225);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(227, 51);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.OrangeRed;
            this.btnB.Location = new System.Drawing.Point(263, 225);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(227, 51);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.OrangeRed;
            this.btnC.Location = new System.Drawing.Point(12, 304);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(227, 51);
            this.btnC.TabIndex = 4;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.OrangeRed;
            this.btnD.Location = new System.Drawing.Point(263, 304);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(227, 51);
            this.btnD.TabIndex = 3;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.OrangeRed;
            this.btnBasla.Location = new System.Drawing.Point(151, 374);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(227, 63);
            this.btnBasla.TabIndex = 5;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Chocolate;
            this.groupBox1.Controls.Add(this.lblsoruSayisi);
            this.groupBox1.Controls.Add(this.lblYanlısSayisi);
            this.groupBox1.Controls.Add(this.lblDogruSayisi);
            this.groupBox1.Controls.Add(this.lblSoru);
            this.groupBox1.Controls.Add(this.lblYanlis);
            this.groupBox1.Controls.Add(this.lblDogru);
            this.groupBox1.Location = new System.Drawing.Point(556, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 229);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İstatistiker ";
            // 
            // lblsoruSayisi
            // 
            this.lblsoruSayisi.AutoSize = true;
            this.lblsoruSayisi.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoruSayisi.Location = new System.Drawing.Point(197, 164);
            this.lblsoruSayisi.Name = "lblsoruSayisi";
            this.lblsoruSayisi.Size = new System.Drawing.Size(29, 35);
            this.lblsoruSayisi.TabIndex = 5;
            this.lblsoruSayisi.Text = "0";
            // 
            // lblYanlısSayisi
            // 
            this.lblYanlısSayisi.AutoSize = true;
            this.lblYanlısSayisi.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYanlısSayisi.Location = new System.Drawing.Point(197, 115);
            this.lblYanlısSayisi.Name = "lblYanlısSayisi";
            this.lblYanlısSayisi.Size = new System.Drawing.Size(29, 35);
            this.lblYanlısSayisi.TabIndex = 4;
            this.lblYanlısSayisi.Text = "0";
            // 
            // lblDogruSayisi
            // 
            this.lblDogruSayisi.AutoSize = true;
            this.lblDogruSayisi.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogruSayisi.Location = new System.Drawing.Point(197, 61);
            this.lblDogruSayisi.Name = "lblDogruSayisi";
            this.lblDogruSayisi.Size = new System.Drawing.Size(29, 35);
            this.lblDogruSayisi.TabIndex = 3;
            this.lblDogruSayisi.Text = "0";
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoru.Location = new System.Drawing.Point(26, 164);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(155, 35);
            this.lblSoru.TabIndex = 2;
            this.lblSoru.Text = "Soru Sayisi:";
            // 
            // lblYanlis
            // 
            this.lblYanlis.AutoSize = true;
            this.lblYanlis.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYanlis.Location = new System.Drawing.Point(17, 115);
            this.lblYanlis.Name = "lblYanlis";
            this.lblYanlis.Size = new System.Drawing.Size(176, 35);
            this.lblYanlis.TabIndex = 1;
            this.lblYanlis.Text = "Yanlış  Sayisi:";
            // 
            // lblDogru
            // 
            this.lblDogru.AutoSize = true;
            this.lblDogru.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogru.Location = new System.Drawing.Point(18, 61);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(173, 35);
            this.lblDogru.TabIndex = 0;
            this.lblDogru.Text = "Doğru Sayisi:";
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaniye.Location = new System.Drawing.Point(549, 20);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(123, 40);
            this.lblSaniye.TabIndex = 6;
            this.lblSaniye.Text = "Saniye:";
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayac.Location = new System.Drawing.Point(667, 20);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(34, 40);
            this.lblSayac.TabIndex = 9;
            this.lblSayac.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSoruCevap
            // 
            this.lblSoruCevap.AutoSize = true;
            this.lblSoruCevap.Location = new System.Drawing.Point(322, 484);
            this.lblSoruCevap.Name = "lblSoruCevap";
            this.lblSoruCevap.Size = new System.Drawing.Size(72, 28);
            this.lblSoruCevap.TabIndex = 10;
            this.lblSoruCevap.Text = "label1";
            this.lblSoruCevap.Visible = false;
            // 
            // lblDogruCevap
            // 
            this.lblDogruCevap.AutoSize = true;
            this.lblDogruCevap.Location = new System.Drawing.Point(501, 484);
            this.lblDogruCevap.Name = "lblDogruCevap";
            this.lblDogruCevap.Size = new System.Drawing.Size(72, 28);
            this.lblDogruCevap.TabIndex = 11;
            this.lblDogruCevap.Text = "label2";
            this.lblDogruCevap.Visible = false;
            // 
            // Sorular
            // 
            this.Sorular.Location = new System.Drawing.Point(-1, -6);
            this.Sorular.Name = "Sorular";
            this.Sorular.Size = new System.Drawing.Size(491, 191);
            this.Sorular.TabIndex = 12;
            this.Sorular.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(870, 449);
            this.Controls.Add(this.Sorular);
            this.Controls.Add(this.lblDogruCevap);
            this.Controls.Add(this.lblSoruCevap);
            this.Controls.Add(this.lblSayac);
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Bilgi Yarışması ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.Label lblYanlis;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Label lblsoruSayisi;
        private System.Windows.Forms.Label lblYanlısSayisi;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Label lblSayac;
        private System.Windows.Forms.Label lblSoruCevap;
        private System.Windows.Forms.Label lblDogruCevap;
        private System.Windows.Forms.RichTextBox Sorular;
        public System.Windows.Forms.Label lblDogruSayisi;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

