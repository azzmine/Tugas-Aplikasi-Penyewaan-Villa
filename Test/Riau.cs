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
    public partial class Riau : Form
    {
        public Riau()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            p p = new p();
            p.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g1096248-d10379141-Reviews-Kamuela_Villas_Lagoi_Bay_Bintan-Lagoi_Bintan_Island_Bintan_Regency_Riau_Archipelago_.html");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g1096248-d10487253-Reviews-Pantai_Indah_Lagoi_Bintan-Lagoi_Bintan_Island_Bintan_Regency_Riau_Archipelago_Riau_I.html");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g297718-d23247980-Reviews-One_of_A_Kind_Resort_Trikora_Beach_Bintan-Bintan_Island_Bintan_Regency_Riau_Archipela.html");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g12811431-d2191358-Reviews-Pulau_Joyo-Joyo_Island_Bintan_Regency_Riau_Archipelago_Riau_Islands_Province.html");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g297718-d8028332-Reviews-De_Bintan_Villa-Bintan_Island_Bintan_Regency_Riau_Archipelago_Riau_Islands_Province.html");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g297717-d2702574-Reviews-Smiling_Hill-Batam_Riau_Archipelago_Riau_Islands_Province.html");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan pemesanan = new Pemesanan();
            pemesanan.Show();
        }
    }
}
