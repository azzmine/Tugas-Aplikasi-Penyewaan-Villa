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
    public partial class Banten : Form
    {
        public Banten()
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
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g3400871-d12126803-Reviews-Padmadewi_Anyer_Villa_Hotel-Anyer_Banten_Province_Java.html");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g3400871-d3908454-Reviews-Villa_Stefan-Anyer_Banten_Province_Java.html");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g317104-d8449169-Reviews-Archipelago_Carita-Carita_Labuhan_Banten_Province_Java.html");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g317104-d13157154-Reviews-Villa_Stephanie-Carita_Labuhan_Banten_Province_Java.html");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g3400871-d4108120-Reviews-Villa_Nine-Anyer_Banten_Province_Java.html");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g3381380-d12144662-Reviews-Villa_Queen_Sawarna-Bayah_Banten_Province_Java.html");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g1493703-d1009520-Reviews-FM7_Resort_Hotel_Airport_Jakarta_Bandara-Tangerang_Banten_Province_Java.html");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan Pemesanan = new Pemesanan();
            Pemesanan.Show();
        }
    }
}
