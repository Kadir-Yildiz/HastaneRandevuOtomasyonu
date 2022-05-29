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
    public partial class RandevuListele : Form
    {
        public RandevuListele()
        {
            InitializeComponent();
        }

        private void RandevuListele_Load(object sender, EventArgs e)
        {
            
            foreach (var item in RandevuAl.list)
            {
                lbListele.Items.Add(item);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seçili Randevuyu Silmek İstediğinizden Emin Misiniz?", "Seçili Randevu Silme", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
            lbListele.Items.Remove(lbListele.SelectedItem);
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
    }
}
