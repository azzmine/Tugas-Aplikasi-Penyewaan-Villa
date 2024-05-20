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
    public partial class Bangka_Belitung : Form
    {
        public Bangka_Belitung()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            p p = new p();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tiket.com/homes/indonesia/pelangi-lake-resort-109001536321528716?room=1&adult=1&checkin=2024-03-07&checkout=2024-03-08&soldOut=false");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tiket.com/homes/indonesia/belitung-holiday-resort-206001561722162636?room=1&adult=1&checkin=2024-03-07&checkout=2024-03-08&soldOut=false");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tiket.com/homes/indonesia/istana-pool-villas-spa-108001534490350524?room=1&adult=1&checkin=2024-03-07&checkout=2024-03-08&soldOut=false");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tiket.com/hotel/indonesia/arumdalu-private-resort-108001534490310562?room=1&adult=1&checkin=2024-03-07&checkout=2024-03-08&soldOut=false");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan Pemesanan = new Pemesanan(); 
            Pemesanan.Show();
        }
    }
}
