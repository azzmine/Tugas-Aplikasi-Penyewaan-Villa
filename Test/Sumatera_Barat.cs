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
    public partial class Sumatera_Barat : Form
    {
        public Sumatera_Barat()
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
            System.Diagnostics.Process.Start("https://www.traveloka.com/id-id/hotel/indonesia/rumah-pakankamih-3000010021551");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.traveloka.com/id-id/hotel/indonesia/villa-rumah-kayu-lubuk-minturun-9000000082808");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.traveloka.com/id-id/hotel/indonesia/villa-mandam-resort-9000000974007");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.traveloka.com/id-id/hotel/indonesia/villa-copenhagen-bukittinggi-9000001136426");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.traveloka.com/id-id/hotel/indonesia/dvio-villa-9000001152761");
        }

        private void Sumatera_Barat_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan pemesanan = new Pemesanan();
            pemesanan.Show();
        }
    }
}
