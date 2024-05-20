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
    public partial class Jambi : Form
    {
        public Jambi()
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
            System.Diagnostics.Process.Start("https://www.traveloka.com/id-id/hotel/indonesia/villa-rahmi-syari-1-3-bedrooms-9000000973782");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.traveloka.com/id-id/hotel/indonesia/rumah-kito-resort-hotel-jambi-by-waringin-hospitality-3000010001063");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tiket.com/homes/indonesia/buluran-guest-house-syariah-611001699416336655?room=1&adult=1&checkin=2024-03-07&checkout=2024-03-08&referrer=https%3A%2F%2Fwww.tiket.com%2Fhomes%2Fsearch%3Froom%3D1%26adult%3D1%26id%3Djambi-108001534490276538%26type%3DCITY%26q%3DJambi%26checkin%3D2024-03-07%26checkout%3D2024-03-08%26accommodationType%3DNHA&utm_page=searchResultPage");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan Pemesanan = new Pemesanan(); 
            Pemesanan.Show();
        }
    }
}
