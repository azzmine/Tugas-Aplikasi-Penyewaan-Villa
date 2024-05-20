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
    public partial class Sumatera_Utara : Form
    {
        public Sumatera_Utara()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            p p = new p();
            p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tiket.com/homes/indonesia/villa-greenhill-sibolangit-chaster-408001628501436585?room=1&adult=1&checkin=2024-03-06&checkout=2024-03-07&soldOut=false");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tiket.com/homes/indonesia/villa-green-hill-sibolangit-oniomo-4br-502001643764529179?room=1&adult=1&checkin=2024-03-06&checkout=2024-03-07&soldOut=false");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g680012-d10345661-Reviews-Villa_Paradise-Bukit_Lawang_North_Sumatra_Sumatra.html");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tiket.com/homes/indonesia/lekjon-2-cottage-410001634023224165?room=1&adult=1&checkin=2024-03-07&checkout=2024-03-08&soldOut=false");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tiket.com/homes/indonesia/villa-berastagi-highland-8kk-201001547180292829?room=1&adult=1&checkin=2024-03-07&checkout=2024-03-08&soldOut=false");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tiket.com/homes/indonesia/villa-berastagi-highland-7-ll-412001639390432776?room=1&adult=1&checkin=2024-03-07&checkout=2024-03-08&soldOut=false");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tiket.com/homes/indonesia/villa-bukit-indah-4br-brastagi-berastagi-401001611307813658?room=1&adult=1&checkin=2024-03-07&checkout=2024-03-08&soldOut=false");
        }

        private void Sumatera_Utara_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan pemesanan = new Pemesanan();
            pemesanan.Show();
        }
    }
}
