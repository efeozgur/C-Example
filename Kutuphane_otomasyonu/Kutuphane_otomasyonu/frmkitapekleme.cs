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
    public partial class frmkitapekleme : Form
    {
        public frmkitapekleme()
        {
            InitializeComponent();
        }


        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kutuphane.accdb");

        private void frmkitapekleme_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btn_ekle;
            this.CancelButton = btn_iptal;
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand ekle = new OleDbCommand("insert into kitap (barkodno,kitapadi,yazari,yayinevi,sayfasayisi,turu,stoksayisi,rafno,aciklama,kayittarihi) values (@barkodno,@kitapadi,@yazari,@yayinevi,@sayfasayisi,@turu,@stoksayisi,@rafno,@aciklama,@kayittarihi)", baglanti);
            ekle.Parameters.AddWithValue("@barkodno", txt_Barkod.Text);
            ekle.Parameters.AddWithValue("@kitapadi", txt_Kitapadi.Text);
            ekle.Parameters.AddWithValue("@yazari", txt_yazari.Text);
            ekle.Parameters.AddWithValue("@yayinevi", txt_yayinevi.Text);
            ekle.Parameters.AddWithValue("@sayfasayisi", txt_sayfasayisi.Text);
            ekle.Parameters.AddWithValue("@turu", cmb_Turu.Text);
            ekle.Parameters.AddWithValue("@stoksayisi", txt_stoksayisi.Text);
            ekle.Parameters.AddWithValue("@rafno", txt_Rafno.Text);
            ekle.Parameters.AddWithValue("@aciklama", txt_Aciklama.Text);
            ekle.Parameters.AddWithValue("@kayittarihi", DateTime.Now.ToShortDateString());

            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap kaydı yapıldı", "Kitap Kayıt İşlemleri");

            //Textboxların içine temizledik, ancak okuduğu kitap sayısını ellemedik.
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";                    
                }
            }
        }
    }
}
