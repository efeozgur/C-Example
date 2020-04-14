namespace Kutuphane_otomasyonu
{
    partial class frmkitaplisteleme
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
            this.cmb_Turu = new System.Windows.Forms.ComboBox();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.txt_Rafno = new System.Windows.Forms.TextBox();
            this.txt_stoksayisi = new System.Windows.Forms.TextBox();
            this.txt_sayfasayisi = new System.Windows.Forms.TextBox();
            this.txt_yayinevi = new System.Windows.Forms.TextBox();
            this.txt_yazari = new System.Windows.Forms.TextBox();
            this.txt_Kitapadi = new System.Windows.Forms.TextBox();
            this.txt_Barkod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Turu
            // 
            this.cmb_Turu.FormattingEnabled = true;
            this.cmb_Turu.Items.AddRange(new object[] {
            "Hikaye",
            "Roman",
            "Çocuk"});
            this.cmb_Turu.Location = new System.Drawing.Point(116, 264);
            this.cmb_Turu.Name = "cmb_Turu";
            this.cmb_Turu.Size = new System.Drawing.Size(195, 26);
            this.cmb_Turu.TabIndex = 22;
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.Location = new System.Drawing.Point(116, 405);
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(195, 24);
            this.txt_Aciklama.TabIndex = 27;
            // 
            // txt_Rafno
            // 
            this.txt_Rafno.Location = new System.Drawing.Point(116, 358);
            this.txt_Rafno.Name = "txt_Rafno";
            this.txt_Rafno.Size = new System.Drawing.Size(195, 24);
            this.txt_Rafno.TabIndex = 26;
            // 
            // txt_stoksayisi
            // 
            this.txt_stoksayisi.Location = new System.Drawing.Point(116, 311);
            this.txt_stoksayisi.Name = "txt_stoksayisi";
            this.txt_stoksayisi.Size = new System.Drawing.Size(195, 24);
            this.txt_stoksayisi.TabIndex = 23;
            // 
            // txt_sayfasayisi
            // 
            this.txt_sayfasayisi.Location = new System.Drawing.Point(116, 217);
            this.txt_sayfasayisi.Name = "txt_sayfasayisi";
            this.txt_sayfasayisi.Size = new System.Drawing.Size(195, 24);
            this.txt_sayfasayisi.TabIndex = 19;
            // 
            // txt_yayinevi
            // 
            this.txt_yayinevi.Location = new System.Drawing.Point(116, 170);
            this.txt_yayinevi.Name = "txt_yayinevi";
            this.txt_yayinevi.Size = new System.Drawing.Size(195, 24);
            this.txt_yayinevi.TabIndex = 17;
            // 
            // txt_yazari
            // 
            this.txt_yazari.Location = new System.Drawing.Point(116, 123);
            this.txt_yazari.Name = "txt_yazari";
            this.txt_yazari.Size = new System.Drawing.Size(195, 24);
            this.txt_yazari.TabIndex = 15;
            // 
            // txt_Kitapadi
            // 
            this.txt_Kitapadi.Location = new System.Drawing.Point(116, 76);
            this.txt_Kitapadi.Name = "txt_Kitapadi";
            this.txt_Kitapadi.Size = new System.Drawing.Size(195, 24);
            this.txt_Kitapadi.TabIndex = 13;
            // 
            // txt_Barkod
            // 
            this.txt_Barkod.Location = new System.Drawing.Point(116, 29);
            this.txt_Barkod.Name = "txt_Barkod";
            this.txt_Barkod.Size = new System.Drawing.Size(195, 24);
            this.txt_Barkod.TabIndex = 12;
            this.txt_Barkod.TextChanged += new System.EventHandler(this.txt_Barkod_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 18);
            this.label9.TabIndex = 25;
            this.label9.Text = "Açıklama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "Raf No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "Stok Sayısı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Türü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Sayfa Sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Yayınevi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Yazarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kitap Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "K.Barkod No";
            // 
            // btn_sil
            // 
            this.btn_sil.ForeColor = System.Drawing.Color.Black;
            this.btn_sil.Location = new System.Drawing.Point(125, 495);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(98, 35);
            this.btn_sil.TabIndex = 41;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.ForeColor = System.Drawing.Color.Black;
            this.btn_cikis.Location = new System.Drawing.Point(234, 444);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(75, 86);
            this.btn_cikis.TabIndex = 40;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.ForeColor = System.Drawing.Color.Black;
            this.btn_guncelle.Location = new System.Drawing.Point(125, 444);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(98, 35);
            this.btn_guncelle.TabIndex = 39;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(395, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 18);
            this.label10.TabIndex = 44;
            this.label10.Text = "Barkod Noya göre Arama : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(613, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 24);
            this.textBox1.TabIndex = 43;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(337, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(519, 476);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // frmkitaplisteleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(868, 550);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.cmb_Turu);
            this.Controls.Add(this.txt_Aciklama);
            this.Controls.Add(this.txt_Rafno);
            this.Controls.Add(this.txt_stoksayisi);
            this.Controls.Add(this.txt_sayfasayisi);
            this.Controls.Add(this.txt_yayinevi);
            this.Controls.Add(this.txt_yazari);
            this.Controls.Add(this.txt_Kitapadi);
            this.Controls.Add(this.txt_Barkod);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmkitaplisteleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Listeleme İşlemleri";
            this.Load += new System.EventHandler(this.frmkitaplisteleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Turu;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.TextBox txt_Rafno;
        private System.Windows.Forms.TextBox txt_stoksayisi;
        private System.Windows.Forms.TextBox txt_sayfasayisi;
        private System.Windows.Forms.TextBox txt_yayinevi;
        private System.Windows.Forms.TextBox txt_yazari;
        private System.Windows.Forms.TextBox txt_Kitapadi;
        private System.Windows.Forms.TextBox txt_Barkod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}