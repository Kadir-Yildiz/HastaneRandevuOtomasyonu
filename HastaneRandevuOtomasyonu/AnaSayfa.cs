using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevuOtomasyonu
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
            
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            RandevuAl randevuAl = new RandevuAl();
            randevuAl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RandevuListele randevuListele = new RandevuListele();
            randevuListele.Show();

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BilgilerimiGuncelle bilgilerimiGuncelle = new BilgilerimiGuncelle();
            bilgilerimiGuncelle.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SifreDegistir sifreDegistir = new SifreDegistir();
            sifreDegistir.Show();
        }
    }
}
