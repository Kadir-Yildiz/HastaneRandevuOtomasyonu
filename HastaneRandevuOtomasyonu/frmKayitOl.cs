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
    public partial class frmKayitOl : Form
    {
        public static List<string> bilgiler = new List<string>();
        public frmKayitOl()
        {
            InitializeComponent();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Ad = txtAd.Text;
            person.Soyad = txtSoyad.Text;
            person.TcNo = txtTcNo.Text;
            person.TelefonNo = txtTelefonNo.Text;
            person.Email = txtEmail.Text;
            person.DogumYeri = txtDogumYeri.Text;
            person.DogumTarihi = dtpDogumTarihi.Value;
            person.Sifre = txtSifre.Text;
            if (person.Ad != "" && person.Soyad != "" && person.TcNo != "" && person.TelefonNo != "" && person.Email != "" && person.DogumYeri != "" && person.Sifre != "" && person.DogumTarihi < DateTime.Today && person.TcNo.Length == 11 && person.TelefonNo.Length == 11 && person.Email.Contains('@') == true && person.Sifre.Length > 8)
            {
            bilgiler.Add(txtAd.Text);
            bilgiler.Add(txtSoyad.Text);
            bilgiler.Add(txtTcNo.Text);
            bilgiler.Add(txtTelefonNo.Text);
            bilgiler.Add(txtEmail.Text);
            bilgiler.Add(txtDogumYeri.Text);
            bilgiler.Add(txtSifre.Text);
                AnaSayfa frmKayitOl = new AnaSayfa();
                frmKayitOl.Show();
                this.Hide();
                frmKayitOl.lblPerson.Text = person.Ad.ToUpper() + " " + person.Soyad.ToUpper();
            }
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
