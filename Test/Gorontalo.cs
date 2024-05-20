using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Gorontalo : Form
    {
        public Gorontalo()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            p p = new p();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.agoda.com/villa-domanik/hotel/goron-talo-id.html?cid=1844104&ds=LkgluLuvZheTK%2BFP");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g1602653-d8517227-Reviews-Pulo_Cinta_Ecoresort-Gorontalo_Gorontalo_Province_Sulawesi.html");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g1602653-d10720064-Reviews-Saronde_Island_Resort-Gorontalo_Gorontalo_Province_Sulawesi.html");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.agoda.com/oile-dive-lodge/hotel/gorontalo-id.html?cid=1844104&ds=UGilW%2B%2Fsq7p4PtK8");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.agoda.com/century-beach-resort-gorontalo/hotel/gorontalo-id.html?cid=1844104&ds=U%2FHZNpvRcLsxw2xV");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan  Pemesanan = new Pemesanan();
            Pemesanan.Show();
        }
    }
}
