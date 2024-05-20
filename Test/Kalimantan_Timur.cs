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
    public partial class Kalimantan_Timur : Form
    {
        public Kalimantan_Timur()
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
            System.Diagnostics.Process.Start("https://www.tiket.com/homes/indonesia/derawan-fisheries-cottage-404001618192835515?room=1&adult=1&checkin=2024-03-09&checkout=2024-03-10&soldOut=false");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tiket.com/homes/indonesia/blue-villa-605001684331090107?room=1&adult=1&checkin=2024-03-09&checkout=2024-03-10&soldOut=false");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tiket.com/homes/indonesia/maratua-ranu-cottage-505001652408128579?room=1&adult=1&checkin=2024-03-09&checkout=2024-03-10&soldOut=false");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tiket.com/hotel/indonesia/arasatu-villas-sanctuary-412001639107216054?room=1&adult=1&checkin=2024-03-09&checkout=2024-03-10&soldOut=false");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tiket.com/hotel/indonesia/grand-jatra-hotel-balikpapan-108001534490296179?room=1&adult=1&checkin=2024-03-09&checkout=2024-03-10&soldOut=false");
        }

        private void Kalimantan_Timur_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan Pemesanan = new Pemesanan();
            Pemesanan.Show();
        }
    }
}
