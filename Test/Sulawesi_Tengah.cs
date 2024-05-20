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
    public partial class Sulawesi_Tengah : Form
    {
        public Sulawesi_Tengah()
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
            System.Diagnostics.Process.Start("https://www.traveloka.com/id-id/hotel/indonesia/sutan-raja-villa-palu-9000000289594");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g12719069-d7217610-Reviews-Sanctum_Una_Una_Eco_Dive_Resort-Una_Una_Island_Togian_Islands_Central_Sulawesi_Sulaw.html");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g12719069-d12685606-Reviews-Pristine_Paradise_Una_Una_Dive_Resort-Una_Una_Island_Togian_Islands_Central_Sulawes.html");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g10541003-d9781738-Reviews-Harmony_Bay_Resort_and_Dive_Center-Kadidiri_Island_Togian_Islands_Central_Sulawesi_S.html");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g10541003-d1752094-Reviews-Black_Marlin_Dive_Resort-Kadidiri_Island_Togian_Islands_Central_Sulawesi_Sulawesi.html");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan pemesanan = new Pemesanan();
            pemesanan.Show();
        }
    }
}
