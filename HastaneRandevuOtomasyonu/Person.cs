using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevuOtomasyonu
{
    internal class Person
    {
        private string _ad;

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }


        private string _soyad;

        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }


        private string _tcNo;

        public string TcNo
        {
            get { return _tcNo; }
            set
            {
                if (value.Length!=11)
                {
                    MessageBox.Show("TC No 11 haneli olmalıdır!");
                }
                else
                {
                    _tcNo = value;
                }
            }
        }


        private string _dogumYeri;

        public string DogumYeri
        {
            get { return _dogumYeri; }
            set { _dogumYeri = value; }
        }


        private DateTime _dogumTarihi;

        public DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set
            {
                if (value>=DateTime.Now)
                {
                    MessageBox.Show("Tarihi Tekradan Giriniz!");
                }
                else
                {
                    _dogumTarihi = value;
                }
            }
        }
        

        private string _telefonNo;

        public string TelefonNo
        {
            get { return _telefonNo; }
            set {
                if (value.Length != 11)
                {
                    MessageBox.Show("Telefon No 11 haneli olmalıdır!");
                }
                else
                {
                    _telefonNo = value;
                }
            }
        }


        private string _email;

        public string Email
        {
            get { return _email; }
            set
            {
                if (value.Contains('@'))
                {
                    _email = value;
                }
                else
                {
                    MessageBox.Show("Mail Adresinizi Tekrardan Giriniz!");
                }
            }
        }


        private string _sifre;

        public string Sifre
        {
            get { return _sifre; }
            set
            {
                if (value.Length>8)
                {
                    _sifre = value;
                }
                else
                {
                    MessageBox.Show("Şifre En Az 8 Karakterden Oluşmalıdır!");
                }
            }
        }

    }
}
