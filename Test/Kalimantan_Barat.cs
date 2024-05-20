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
    public partial class Kalimantan_Barat : Form
    {
        public Kalimantan_Barat()
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
            System.Diagnostics.Process.Start("https://www.traveloka.com/id-id/hotel/indonesia/golden-hawaii-villa-singkawang-3000010004775");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.traveloka.com/id-id/hotel/indonesia/villa-bukit-mas-3000010040089");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.traveloka.com/id-id/hotel/indonesia/villa-sekawan-9000001109575");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tiket.com/homes/indonesia/el-sierra-villa-612001702964828489?room=1&adult=1&checkin=2024-03-09&checkout=2024-03-10&soldOut=false");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan Pemesanan = new Pemesanan();
            Pemesanan.Show();
        }
    }
}
