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
    public partial class Nusa_Tenggara_Timur : Form
    {
        public Nusa_Tenggara_Timur()
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
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g1777483-d12196462-Reviews-Villa_Domanik-Labuan_Bajo_Flores_East_Nusa_Tenggara.html");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g1777483-d8114445-Reviews-Selini_on_the_Hill_Villas_Spa-Labuan_Bajo_Flores_East_Nusa_Tenggara.html");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g1777483-d13433274-Reviews-Manta_Manta_Guesthouse-Labuan_Bajo_Flores_East_Nusa_Tenggara.html");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g1777483-d14167975-Reviews-AYANA_Komodo_Resort_Waecicu_Beach-Labuan_Bajo_Flores_East_Nusa_Tenggara.html");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan pemesanan = new Pemesanan();
            pemesanan.Show();
        }
    }
}
