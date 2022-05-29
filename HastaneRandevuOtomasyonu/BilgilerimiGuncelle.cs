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
    public partial class BilgilerimiGuncelle : Form
    {
        public BilgilerimiGuncelle()
        {
            InitializeComponent();
        }

        private void BilgilerimiGuncelle_Load(object sender, EventArgs e)
        {
            frmKayitOl frmKayitOl = new frmKayitOl();
            txtAd.Text = frmKayitOl.bilgiler[0];
            txtSoyad.Text = frmKayitOl.bilgiler[1];
            txtTcNo.Text = frmKayitOl.bilgiler[2];
            txtTelefonNo.Text= frmKayitOl.bilgiler[3];
            txtEmail.Text= frmKayitOl.bilgiler[4];
            txtDogumYeri.Text= frmKayitOl.bilgiler[5];
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKayitOl.bilgiler[0] = txtAd.Text;
            frmKayitOl.bilgiler[1] = txtSoyad.Text;
            frmKayitOl.bilgiler[2] = txtTcNo.Text;
            frmKayitOl.bilgiler[3] = txtTelefonNo.Text;
            frmKayitOl.bilgiler[4] = txtEmail.Text;
            frmKayitOl.bilgiler[5] = txtDogumYeri.Text;
            MessageBox.Show("Değişiklik Başarılı Bir Şekilde Kaydedildi!");
        }
    }
}
