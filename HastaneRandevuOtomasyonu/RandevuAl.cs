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
    public partial class RandevuAl : Form
    {
        public static List<string> list = new List<string>();
        RandevuListele randevu = new RandevuListele();
        public static string bolumBilgisi = "";
        public static string pazartesi = "";
        public static string sali = "";
        public static string carsamba = "";
        public static string persembe = "";
        public static string cuma = "";
        public RandevuAl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Seçmek İstediğiniz Randevu Doludur! ");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            bolumBilgisi = btn.Text;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (pazartesi != "")
            {
                MessageBox.Show($"{bolumBilgisi} Saat : {pazartesi} Pazartesi Gününe Randevunuz Alınmıştır!");
                string pzt = $"{bolumBilgisi} Saat : {pazartesi} Pazartesi Günü";
                randevu.lbListele.Items.Add($"{bolumBilgisi} Saat : {pazartesi} Pazartesi Günü");
                list.Add(pzt);
                pazartesi = "";
            }
            else if (sali != "")
            {
                MessageBox.Show($"{bolumBilgisi} Saat : {sali} Salı Gününe Randevunuz Alınmıştır!");
                string sal = $"{bolumBilgisi} Saat : {sali} Salı Günü";
                randevu.lbListele.Items.Add(sal);
                list.Add(sal);
                sali = "";
            }
            else if (carsamba != "")
            {
                MessageBox.Show($"{bolumBilgisi} Saat : {carsamba} Çarşamba Gününe Randevunuz Alınmıştır!");
                string car = $"{bolumBilgisi} Saat : {carsamba} Çarşamba Günü";
                randevu.lbListele.Items.Add(car);
                list.Add(car);
                carsamba = "";
            }
            else if (persembe != "")
            {
                MessageBox.Show($"{bolumBilgisi} Saat : {persembe} Perşembe Gününe Randevunuz Alınmıştır!");
                string per = $"{bolumBilgisi} Saat : {persembe} Perşembe Günü";
                randevu.lbListele.Items.Add(per);
                list.Add(per);
                persembe = "";
            }
            else if (cuma != "")
            {
                MessageBox.Show($"{bolumBilgisi} Saat : {cuma} Cuma Gününe Randevunuz Alınmıştır!");
                string cum = $"{bolumBilgisi} Saat : {cuma} Cuma Günü";
                randevu.lbListele.Items.Add(cum);
                list.Add(cum);
                cuma = "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor=Color.Tomato;
            pazartesi = btn.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Tomato;
            sali = btn.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Tomato;
            carsamba = btn.Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Tomato;
            persembe = btn.Text;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Tomato;
            cuma = btn.Text;
        }
    }
}
