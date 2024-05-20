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
    public partial class Kepulauan_Riau : Form
    {
        public Kepulauan_Riau()
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
            System.Diagnostics.Process.Start("https://www.booking.com/hotel/id/4br-private-villa-with-pool-in-the-heart-of-city.id.html?aid=356980&label=gog235jc-1DCAYYkgQoaEIOa2VwdWxhdWFuLXJpYXVIElgDaGiIAQGYARK4ARfIAQzYAQPoAQH4AQKIAgGoAgO4Ap3Wpq8GwAIB0gIkMjBmOTllMGItZDJhMy00MTRjLTg5ZTItYzA4ZTQ3OGZjMTlh2AIE4AIB&sid=599cf1277608306e179e8143108c3f56");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.booking.com/hotel/id/peaceful-villa-in-private-beach-resort.id.html?aid=356980&label=gog235jc-1DCAYYkgQoaEIOa2VwdWxhdWFuLXJpYXVIElgDaGiIAQGYARK4ARfIAQzYAQPoAQH4AQKIAgGoAgO4Ap3Wpq8GwAIB0gIkMjBmOTllMGItZDJhMy00MTRjLTg5ZTItYzA4ZTQ3OGZjMTlh2AIE4AIB&sid=599cf1277608306e179e8143108c3f56");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.booking.com/hotel/id/danka-tudor-residence.id.html?aid=356980&label=gog235jc-1DCAYYkgQoaEIOa2VwdWxhdWFuLXJpYXVIElgDaGiIAQGYARK4ARfIAQzYAQPoAQH4AQKIAgGoAgO4Ap3Wpq8GwAIB0gIkMjBmOTllMGItZDJhMy00MTRjLTg5ZTItYzA4ZTQ3OGZjMTlh2AIE4AIB&sid=599cf1277608306e179e8143108c3f56");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.booking.com/hotel/id/calmness-villa-syariah.id.html?aid=356980&label=gog235jc-1DCAYYkgQoaEIOa2VwdWxhdWFuLXJpYXVIElgDaGiIAQGYARK4ARfIAQzYAQPoAQH4AQKIAgGoAgO4Ap3Wpq8GwAIB0gIkMjBmOTllMGItZDJhMy00MTRjLTg5ZTItYzA4ZTQ3OGZjMTlh2AIE4AIB&sid=599cf1277608306e179e8143108c3f56");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan Pemesanan = new Pemesanan();
            Pemesanan.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
