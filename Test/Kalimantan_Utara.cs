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
    public partial class Kalimantan_Utara : Form
    {
        public Kalimantan_Utara()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            p p = new p();
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g2004702-d1069007-Reviews-Maratua_Paradise_Resort-Maratua_Island_Derawan_Islands_East_Kalimantan_Kalimantan.html");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/maps/place/Glamping+resort+%22food+%26+coffee%22/@2.6220065,117.8019988,17z/data=!3m1!4b1!4m6!3m5!1s0x321251d18d24bf91:0xe7f9d31b5e122c7e!8m2!3d2.6220065!4d117.8019988!16s%2Fg%2F11ssjxb4wx?entry=ttu");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan Pemesanan = new Pemesanan();
            Pemesanan.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://g.co/kgs/b3ZKGeg");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
