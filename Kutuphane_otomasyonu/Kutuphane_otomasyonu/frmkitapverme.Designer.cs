namespace Kutuphane_otomasyonu
{
    partial class frmkitapverme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grp_uyebilgi = new System.Windows.Forms.GroupBox();
            this.grp_kitapbilgi = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tcno = new System.Windows.Forms.TextBox();
            this.txt_adsoyad = new System.Windows.Forms.TextBox();
            this.txt_yas = new System.Windows.Forms.TextBox();
            this.txt_telefonno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_barkodno = new System.Windows.Forms.TextBox();
            this.txt_kitapadi = new System.Windows.Forms.TextBox();
            this.txt_yazari = new System.Windows.Forms.TextBox();
            this.txt_yayinevi = new System.Windows.Forms.TextBox();
            this.txt_sayfasayisi = new System.Windows.Forms.TextBox();
            this.txt_kitapsayisi = new System.Windows.Forms.TextBox();
            this.dt_teslimtarihi = new System.Windows.Forms.DateTimePicker();
            this.dt_iadetarihi = new System.Windows.Forms.DateTimePicker();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grp_uyebilgi.SuspendLayout();
            this.grp_kitapbilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(310, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(510, 422);
            this.dataGridView1.TabIndex = 0;
            // 
            // grp_uyebilgi
            // 
            this.grp_uyebilgi.Controls.Add(this.txt_telefonno);
            this.grp_uyebilgi.Controls.Add(this.txt_yas);
            this.grp_uyebilgi.Controls.Add(this.txt_adsoyad);
            this.grp_uyebilgi.Controls.Add(this.txt_tcno);
            this.grp_uyebilgi.Controls.Add(this.label4);
            this.grp_uyebilgi.Controls.Add(this.label3);
            this.grp_uyebilgi.Controls.Add(this.label2);
            this.grp_uyebilgi.Controls.Add(this.label1);
            this.grp_uyebilgi.Location = new System.Drawing.Point(12, 43);
            this.grp_uyebilgi.Name = "grp_uyebilgi";
            this.grp_uyebilgi.Size = new System.Drawing.Size(292, 156);
            this.grp_uyebilgi.TabIndex = 1;
            this.grp_uyebilgi.TabStop = false;
            this.grp_uyebilgi.Text = "Üye Bilgileri";
            // 
            // grp_kitapbilgi
            // 
            this.grp_kitapbilgi.Controls.Add(this.dt_iadetarihi);
            this.grp_kitapbilgi.Controls.Add(this.dt_teslimtarihi);
            this.grp_kitapbilgi.Controls.Add(this.txt_kitapsayisi);
            this.grp_kitapbilgi.Controls.Add(this.txt_sayfasayisi);
            this.grp_kitapbilgi.Controls.Add(this.txt_yayinevi);
            this.grp_kitapbilgi.Controls.Add(this.txt_yazari);
            this.grp_kitapbilgi.Controls.Add(this.txt_kitapadi);
            this.grp_kitapbilgi.Controls.Add(this.txt_barkodno);
            this.grp_kitapbilgi.Controls.Add(this.label12);
            this.grp_kitapbilgi.Controls.Add(this.label11);
            this.grp_kitapbilgi.Controls.Add(this.label10);
            this.grp_kitapbilgi.Controls.Add(this.label9);
            this.grp_kitapbilgi.Controls.Add(this.label8);
            this.grp_kitapbilgi.Controls.Add(this.label7);
            this.grp_kitapbilgi.Controls.Add(this.label6);
            this.grp_kitapbilgi.Controls.Add(this.label5);
            this.grp_kitapbilgi.Location = new System.Drawing.Point(12, 214);
            this.grp_kitapbilgi.Name = "grp_kitapbilgi";
            this.grp_kitapbilgi.Size = new System.Drawing.Size(292, 251);
            this.grp_kitapbilgi.TabIndex = 2;
            this.grp_kitapbilgi.TabStop = false;
            this.grp_kitapbilgi.Text = "Kitap Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C.No (Ara)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yaş";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon No";
            // 
            // txt_tcno
            // 
            this.txt_tcno.Location = new System.Drawing.Point(104, 27);
            this.txt_tcno.Name = "txt_tcno";
            this.txt_tcno.Size = new System.Drawing.Size(159, 24);
            this.txt_tcno.TabIndex = 4;
            this.txt_tcno.TextChanged += new System.EventHandler(this.txt_tcno_TextChanged);
            // 
            // txt_adsoyad
            // 
            this.txt_adsoyad.Location = new System.Drawing.Point(104, 57);
            this.txt_adsoyad.Name = "txt_adsoyad";
            this.txt_adsoyad.Size = new System.Drawing.Size(159, 24);
            this.txt_adsoyad.TabIndex = 5;
            // 
            // txt_yas
            // 
            this.txt_yas.Location = new System.Drawing.Point(104, 87);
            this.txt_yas.Name = "txt_yas";
            this.txt_yas.Size = new System.Drawing.Size(159, 24);
            this.txt_yas.TabIndex = 6;
            // 
            // txt_telefonno
            // 
            this.txt_telefonno.Location = new System.Drawing.Point(104, 117);
            this.txt_telefonno.Name = "txt_telefonno";
            this.txt_telefonno.Size = new System.Drawing.Size(159, 24);
            this.txt_telefonno.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Barkod No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Kitap Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Yazarı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Yayınevi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "Sayfa Sayısı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "Kitap Sayısı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 18);
            this.label11.TabIndex = 14;
            this.label11.Text = "Teslim Tarihi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 18);
            this.label12.TabIndex = 15;
            this.label12.Text = "İade Tarihi";
            // 
            // txt_barkodno
            // 
            this.txt_barkodno.Location = new System.Drawing.Point(104, 28);
            this.txt_barkodno.Name = "txt_barkodno";
            this.txt_barkodno.Size = new System.Drawing.Size(159, 24);
            this.txt_barkodno.TabIndex = 8;
            this.txt_barkodno.TextChanged += new System.EventHandler(this.txt_barkodno_TextChanged);
            // 
            // txt_kitapadi
            // 
            this.txt_kitapadi.Location = new System.Drawing.Point(104, 56);
            this.txt_kitapadi.Name = "txt_kitapadi";
            this.txt_kitapadi.Size = new System.Drawing.Size(159, 24);
            this.txt_kitapadi.TabIndex = 16;
            // 
            // txt_yazari
            // 
            this.txt_yazari.Location = new System.Drawing.Point(104, 84);
            this.txt_yazari.Name = "txt_yazari";
            this.txt_yazari.Size = new System.Drawing.Size(159, 24);
            this.txt_yazari.TabIndex = 17;
            // 
            // txt_yayinevi
            // 
            this.txt_yayinevi.Location = new System.Drawing.Point(104, 112);
            this.txt_yayinevi.Name = "txt_yayinevi";
            this.txt_yayinevi.Size = new System.Drawing.Size(159, 24);
            this.txt_yayinevi.TabIndex = 18;
            // 
            // txt_sayfasayisi
            // 
            this.txt_sayfasayisi.Location = new System.Drawing.Point(103, 140);
            this.txt_sayfasayisi.Name = "txt_sayfasayisi";
            this.txt_sayfasayisi.Size = new System.Drawing.Size(159, 24);
            this.txt_sayfasayisi.TabIndex = 19;
            // 
            // txt_kitapsayisi
            // 
            this.txt_kitapsayisi.Location = new System.Drawing.Point(104, 168);
            this.txt_kitapsayisi.Name = "txt_kitapsayisi";
            this.txt_kitapsayisi.Size = new System.Drawing.Size(159, 24);
            this.txt_kitapsayisi.TabIndex = 20;
            this.txt_kitapsayisi.Text = "1";
            this.txt_kitapsayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dt_teslimtarihi
            // 
            this.dt_teslimtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_teslimtarihi.Location = new System.Drawing.Point(102, 194);
            this.dt_teslimtarihi.Name = "dt_teslimtarihi";
            this.dt_teslimtarihi.Size = new System.Drawing.Size(161, 24);
            this.dt_teslimtarihi.TabIndex = 21;
            // 
            // dt_iadetarihi
            // 
            this.dt_iadetarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_iadetarihi.Location = new System.Drawing.Point(102, 222);
            this.dt_iadetarihi.Name = "dt_iadetarihi";
            this.dt_iadetarihi.Size = new System.Drawing.Size(161, 24);
            this.dt_iadetarihi.TabIndex = 22;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(88, 471);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 33);
            this.btn_ekle.TabIndex = 3;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Teslim Et";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(745, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(200, 471);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 6;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(307, 478);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 18);
            this.label13.TabIndex = 7;
            this.label13.Text = "Kayıtlı Kitap sayısı :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(480, 478);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 18);
            this.label14.TabIndex = 8;
            this.label14.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(307, 518);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(168, 18);
            this.label15.TabIndex = 9;
            this.label15.Text = "Sepetteki Kitap sayısı :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(481, 518);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 18);
            this.label16.TabIndex = 10;
            this.label16.Text = "0";
            // 
            // frmkitapverme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(837, 555);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.grp_kitapbilgi);
            this.Controls.Add(this.grp_uyebilgi);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmkitapverme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet Kitap Verme İşlemleri";
            this.Load += new System.EventHandler(this.frmkitapverme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grp_uyebilgi.ResumeLayout(false);
            this.grp_uyebilgi.PerformLayout();
            this.grp_kitapbilgi.ResumeLayout(false);
            this.grp_kitapbilgi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grp_uyebilgi;
        private System.Windows.Forms.GroupBox grp_kitapbilgi;
        private System.Windows.Forms.TextBox txt_telefonno;
        private System.Windows.Forms.TextBox txt_yas;
        private System.Windows.Forms.TextBox txt_adsoyad;
        private System.Windows.Forms.TextBox txt_tcno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_iadetarihi;
        private System.Windows.Forms.DateTimePicker dt_teslimtarihi;
        private System.Windows.Forms.TextBox txt_kitapsayisi;
        private System.Windows.Forms.TextBox txt_sayfasayisi;
        private System.Windows.Forms.TextBox txt_yayinevi;
        private System.Windows.Forms.TextBox txt_yazari;
        private System.Windows.Forms.TextBox txt_kitapadi;
        private System.Windows.Forms.TextBox txt_barkodno;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}