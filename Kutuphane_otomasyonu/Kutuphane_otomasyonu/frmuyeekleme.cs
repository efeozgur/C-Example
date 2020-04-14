using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kutuphane_otomasyonu
{
    public partial class frmuyeekleme : Form
    {
        public frmuyeekleme()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kutuphane.accdb");

        private void frmuyeekleme_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btn_ekle;
            this.CancelButton = btn_cikis;

        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand ekle = new OleDbCommand("insert into uyelik (tc,adsoyad,yas,cinsiyet,telefon,adres,email,okukitapsayisi) values (@tc,@adsoyad,@yas,@cinsiyet,@telefon,@adres,@email,@okukitapsayisi)", baglanti);
            ekle.Parameters.AddWithValue("@tc", txt_Tcno.Text);
            ekle.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            ekle.Parameters.AddWithValue("@yas", txt_Yas.Text);
            ekle.Parameters.AddWithValue("@cinsiyet", cmb_Cinsiyet.Text);
            ekle.Parameters.AddWithValue("@telefon", txt_Telefon.Text);
            ekle.Parameters.AddWithValue("@adres", txt_Adres.Text);
            ekle.Parameters.AddWithValue("@email", txt_Email.Text);
            ekle.Parameters.AddWithValue("@okukitapsayisi", txt_OkuduguKitap.Text);
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye kaydı yapıldı", "Üye Kayıt İşlemleri");

            //Textboxların içine temizledik, ancak okuduğu kitap sayısını ellemedik.
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (item != txt_OkuduguKitap)
                    {
                        item.Text = "";    
                    }                    
                }
            }

        }
    }
}
