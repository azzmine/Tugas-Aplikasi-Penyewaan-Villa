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
    public partial class Sulawesi_Barat : Form
    {
        public Sulawesi_Barat()
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
            System.Diagnostics.Process.Start("https://www.booking.com/hotel/id/botanica-nature-resort.id.html?aid=356980&label=gog235jc-1DCAYYkgQoaEIIc3VsYXdlc2lIElgDaGiIAQGYARK4ARfIAQzYAQPoAQH4AQKIAgGoAgO4AvH4uq8GwAIB0gIkMmI4Mjg0OWQtNmJjOS00ZmQ5LTkyMTMtNjNiMjc4MTVkYmE42AIE4AIB&sid=599cf1277608306e179e8143108c3f56");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g3178765-d3165479-Reviews-Mamasa_Cottages-Mamasa_West_Sulawesi_Sulawesi.html");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/andatavilla/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan pemesanan = new Pemesanan();
            pemesanan.Show();
        }
    }
}
