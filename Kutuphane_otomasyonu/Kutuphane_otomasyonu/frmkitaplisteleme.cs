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
    public partial class frmkitaplisteleme : Form
    {
        public frmkitaplisteleme()
        {
            InitializeComponent(); //kitap listeleme işlemleri
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kutuphane.accdb");

        DataSet tablo = new DataSet();
        private void kitaplistele()
        {
            baglanti.Open();
            OleDbDataAdapter listele = new OleDbDataAdapter("select * from kitap", baglanti);
            listele.Fill(tablo, "kitap");
            dataGridView1.DataSource = tablo.Tables["kitap"];
            baglanti.Close();
        }


        private void frmkitaplisteleme_Load(object sender, EventArgs e)
        {
            kitaplistele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Barkod.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
        }

        private void txt_Barkod_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from kitap where barkodno like '"+txt_Barkod.Text+"'", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txt_Kitapadi.Text = read[1].ToString();
                txt_yazari.Text = read[2].ToString();  
                txt_yayinevi.Text = read[3].ToString();
                txt_sayfasayisi.Text = read[4].ToString();
                cmb_Turu.Text = read[5].ToString();
                txt_stoksayisi.Text = read[6].ToString();
                txt_Rafno.Text = read[7].ToString();
                txt_Aciklama.Text = read[8].ToString();
                
            }
            baglanti.Close();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tablo.Tables["kitap"].Clear();
            baglanti.Open();

            OleDbDataAdapter ara = new OleDbDataAdapter("select * from kitap where barkodno like '%"+textBox1.Text+"%'", baglanti);
            ara.Fill(tablo, "kitap");
            dataGridView1.DataSource = tablo.Tables["kitap"];
            baglanti.Close();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            OleDbCommand kayitguncelle = new OleDbCommand("update kitap set kitapadi='"+txt_Kitapadi.Text+"', yazari='"+txt_yazari.Text+"', yayinevi='"+txt_yayinevi.Text+"', sayfasayisi='"+txt_sayfasayisi.Text+"', turu='"+cmb_Turu.Text+"', stoksayisi='"+txt_stoksayisi.Text+"', rafno='"+txt_Rafno.Text+"', aciklama='"+txt_Aciklama.Text+"' where barkodno='"+txt_Barkod.Text+"'", baglanti);
            kayitguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi gerçekleşti", "Güncelleme İşlemleri");
            tablo.Tables["kitap"].Clear();
            kitaplistele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kaydı silmek istediğinizden emin misiniz?", "Silme İşlemleri", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                OleDbCommand sil = new OleDbCommand("delete from kitap where barkodno=@barkodno", baglanti);
                sil.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
                sil.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi gerçekleşti", "Silme İşlemleri");
                tablo.Tables["kitap"].Clear();
                kitaplistele();
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
}
