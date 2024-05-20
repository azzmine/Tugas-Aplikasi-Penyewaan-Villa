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
    public partial class Sulawesi_Utara : Form
    {
        public Sulawesi_Utara()
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
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g1071666-d1673817-Reviews-Bunaken_Island_Resort-Bunaken_Island_Manado_North_Sulawesi_Sulawesi.html");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g680020-d1633911-Reviews-Kasawari_Lembeh_Resort-Bitung_North_Sulawesi_Sulawesi.html");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g297721-d1454360-Reviews-Minahasa_Prima_Resort-Manado_North_Sulawesi_Sulawesi.html");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g297721-d301907-Reviews-Mercure_Manado_Tateli_Resort_and_Convention-Manado_North_Sulawesi_Sulawesi.html");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan pemesanan = new Pemesanan();
            pemesanan.Show();
        }
    }
}
