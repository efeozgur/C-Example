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
    public partial class frmuyelisteleme : Form
    {
        public frmuyelisteleme()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kutuphane.accdb");

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Tcno.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();

        }

        private void txt_Tcno_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from uyelik where tc like '"+txt_Tcno.Text+"'", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txt_Yas.Text= read["yas"].ToString();
                cmb_Cinsiyet.Text= read["cinsiyet"].ToString();
                txt_Telefon.Text= read["telefon"].ToString();
                txt_Adres.Text= read["adres"].ToString();
                txt_Email.Text=read["email"].ToString();
                txt_OkuduguKitap.Text = read["okukitapsayisi"].ToString();

            }
            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tablo.Tables["uyelik"].Clear();
            baglanti.Open();

            OleDbDataAdapter ara = new OleDbDataAdapter("select * from uyelik where tc like '%"+textBox1.Text+"%'", baglanti);
            ara.Fill(tablo,"uyelik");
            dataGridView1.DataSource = tablo.Tables["uyelik"];
            baglanti.Close();
        }

        DataSet tablo = new DataSet();
        private void uyelistele()
        {
            baglanti.Open();   
            OleDbDataAdapter listele = new OleDbDataAdapter("select * from uyelik", baglanti);
            listele.Fill(tablo,"uyelik");
            dataGridView1.DataSource = tablo.Tables["uyelik"];
            baglanti.Close();
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kaydı silmek istediğinizden emin misiniz?", "Silme İşlemleri", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                OleDbCommand sil = new OleDbCommand("delete from uyelik where tc=@tc", baglanti);
                sil.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
                sil.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi gerçekleşti", "Silme İşlemleri");
                tablo.Tables["uyelik"].Clear();
                uyelistele();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
           
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            OleDbCommand kayitguncelle = new OleDbCommand("update uyelik set adsoyad='"+txtAdSoyad.Text+"', yas='"+txt_Yas.Text+"', cinsiyet='"+cmb_Cinsiyet.Text+"', telefon='"+txt_Telefon.Text+"', adres='"+txt_Adres.Text+"', email='"+txt_Email.Text+"', okukitapsayisi='"+txt_OkuduguKitap.Text+"' where tc='" +txt_Tcno.Text+"'", baglanti);
            kayitguncelle.ExecuteNonQuery();         
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi gerçekleşti", "Güncelleme İşlemleri");
            tablo.Tables["uyelik"].Clear();
            uyelistele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
           
        }

        private void frmuyelisteleme_Load(object sender, EventArgs e)
        {
            uyelistele();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
