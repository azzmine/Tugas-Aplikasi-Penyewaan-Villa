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
    public partial class Papua : Form
    {
        public Papua()
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
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g297703-d10172975-Reviews-OssA_de_Villa-Timika_Papua.html");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tiket.com/homes/indonesia/villa-anneby-by-nirmala-biak-beach-hotel-511001669025170324?room=1&adult=1&checkin=2024-03-11&checkout=2024-03-12&soldOut=false");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tiket.com/homes/indonesia/villa-mega-by-nirmala-biak-beach-hotel-511001669026294932?room=1&adult=1&checkin=2024-03-11&checkout=2024-03-12&soldOut=false");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.traveloka.com/id-id/hotel/indonesia/villa-tosari-indah--9000000806247");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan pemesanan = new Pemesanan();
            pemesanan.Show();
        }
    }
}
