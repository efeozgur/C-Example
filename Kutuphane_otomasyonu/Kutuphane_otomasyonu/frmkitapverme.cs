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
    public partial class frmkitapverme : Form
    {
        public frmkitapverme()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kutuphane.accdb");

        DataSet tablo = new DataSet();

        private void sepetlistele()
        {
            baglanti.Open();
            OleDbDataAdapter komut = new OleDbDataAdapter("select * from sepet", baglanti);
            komut.Fill(tablo, "sepet");
            dataGridView1.DataSource = tablo.Tables[0];
            baglanti.Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand ekle = new OleDbCommand("insert into sepet (barkodno,kitapadi,yazari,yayinevi,sayfasayisi,kitapsayisi,teslimtarihi,iadetarihi) values (@barkodno,@kitapadi,@yazari,@yayinevi,@sayfasayisi,@kitapsayisi,@teslimtarihi,@iadetarihi)", baglanti);
            ekle.Parameters.AddWithValue("@barkodno", txt_barkodno.Text);
            ekle.Parameters.AddWithValue("@kitapadi", txt_kitapadi.Text);
            ekle.Parameters.AddWithValue("@yazari", txt_yazari.Text);
            ekle.Parameters.AddWithValue("@yayinevi", txt_yayinevi.Text);
            ekle.Parameters.AddWithValue("@sayfasayisi", txt_sayfasayisi.Text);
            ekle.Parameters.AddWithValue("@kitapsayisi", txt_kitapsayisi.Text);
            ekle.Parameters.AddWithValue("@teslimtarihi", dt_teslimtarihi.Text);
            ekle.Parameters.AddWithValue("@iadetarihi", dt_iadetarihi.Text);
            
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Sepete eklendi", "Sepet İşlemleri");

            //Textboxların içine temizledik, ancak okuduğu kitap sayısını ellemedik.
            foreach (Control item in grp_kitapbilgi.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txt_kitapsayisi)
                    {
                        item.Text = "";    
                    }
                    
                }
            }
            tablo.Tables["sepet"].Clear();
            sepetlistele();
        }

        private void frmkitapverme_Load(object sender, EventArgs e)
        {
            sepetlistele();
        }

        private void txt_tcno_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from uyelik where tc like '"+txt_tcno.Text+"'", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txt_adsoyad.Text = read[1].ToString();
                txt_yas.Text = read[2].ToString();
                txt_telefonno.Text = read[4].ToString();
            }
            baglanti.Close();
            if (txt_tcno.Text == "")
            {
                foreach (Control item in grp_uyebilgi.Controls)
                {
                    item.Text = "";
                    label14.Text = "";
                }
            }
        }

        private void txt_barkodno_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from kitap where barkodno like '" +txt_barkodno.Text+"'", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txt_kitapadi.Text = read[1].ToString();
                txt_yazari.Text = read[2].ToString();
                txt_yayinevi.Text = read[3].ToString();
                txt_sayfasayisi.Text = read[4].ToString();
                txt_kitapsayisi.Text = read[6].ToString();
            }
            baglanti.Close();
            if (txt_barkodno.Text== "")
            {
                foreach (Control item in  grp_kitapbilgi.Controls)
                {
                    item.Text = "";                    
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from sepet where barkodno='"+dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString()+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi yapıldı", "Silme İşlemi");
            tablo.Tables["sepet"].Clear();
            sepetlistele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
