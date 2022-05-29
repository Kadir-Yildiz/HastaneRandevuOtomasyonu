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
    public partial class SifreDegistir : Form
    {
        public SifreDegistir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (frmKayitOl.bilgiler[2]==txtTcNo.Text && frmKayitOl.bilgiler[6]== txtSifre.Text)
            {
                frmKayitOl.bilgiler[6] = txtYeniSifre.Text;
                MessageBox.Show("Şifreniz Değiştirilmiştir!");
                txtTcNo.Clear();
                txtYeniSifre.Clear();
                txtSifre.Clear();
            }
            else
            {
                MessageBox.Show("TC No veya Mevcut Şifre Yanlıştır, Tekrar Giriniz!");
            }

        }
    }
}
