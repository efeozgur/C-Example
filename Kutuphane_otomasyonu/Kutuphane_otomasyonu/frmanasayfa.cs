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
    public partial class frmanasayfa : Form
    {
        public frmanasayfa()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_uyeekleme_Click(object sender, EventArgs e)
        {
            frmuyeekleme uyeekleme = new frmuyeekleme();
            uyeekleme.ShowDialog();
        }

        private void frmanasayfa_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_uyelisteleme_Click(object sender, EventArgs e)
        {
            frmuyelisteleme uyelistele = new frmuyelisteleme();
            uyelistele.ShowDialog();
        }

        private void btn_kitapekleme_Click(object sender, EventArgs e)
        {
            frmkitapekleme kitapekleme = new frmkitapekleme();
            kitapekleme.ShowDialog();
        }

        private void btn_kitaplisteleme_Click(object sender, EventArgs e)
        {
            frmkitaplisteleme kitaplistele = new frmkitaplisteleme();
            kitaplistele.ShowDialog();
        }

        private void btn_emanetverme_Click(object sender, EventArgs e)
        {
            frmkitapverme kitapverme = new frmkitapverme();
            kitapverme.ShowDialog();
        }

        private void btn_emanetalma_Click(object sender, EventArgs e)
        {
            frmkitapalma kitapalma = new frmkitapalma();
            kitapalma.ShowDialog();
        }

        private void btn_emanetlisteleme_Click(object sender, EventArgs e)
        {
            frmemanetkitapliste emanetliste = new frmemanetkitapliste();
            emanetliste.ShowDialog();
        }
    }
}
