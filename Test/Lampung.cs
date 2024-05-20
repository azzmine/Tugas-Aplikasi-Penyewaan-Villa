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
    public partial class Lampung : Form
    {
        public Lampung()
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
            System.Diagnostics.Process.Start("https://www.booking.com/hotel/id/betuah-say-2br-city-center-holiday-home.id.html?aid=356980&label=gog235jc-1DCAMYkgQoaEIOYmFuZGFyLWxhbXB1bmdIElgDaGiIAQGYARK4ARfIAQzYAQPoAQH4AQKIAgGoAgO4AsCFp68GwAIB0gIkM2UzMTVkOTEtMjZjOC00NjNiLTg2M2UtNzM5NmE1NGM5ZDIz2AIE4AIB&sid=599cf1277608306e179e8143108c3f56");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.booking.com/hotel/id/villa-5-br-utk-family-grup-di-villa-citra-lampung.id.html?aid=356980&label=gog235jc-1DCAMYkgQoaEIOYmFuZGFyLWxhbXB1bmdIElgDaGiIAQGYARK4ARfIAQzYAQPoAQH4AQKIAgGoAgO4AsCFp68GwAIB0gIkM2UzMTVkOTEtMjZjOC00NjNiLTg2M2UtNzM5NmE1NGM5ZDIz2AIE4AIB&sid=599cf1277608306e179e8143108c3f56");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.booking.com/hotel/id/bandar-lampung-villa.id.html?aid=356980&label=gog235jc-1DCAMYkgQoaEIOYmFuZGFyLWxhbXB1bmdIElgDaGiIAQGYARK4ARfIAQzYAQPoAQH4AQKIAgGoAgO4AsCFp68GwAIB0gIkM2UzMTVkOTEtMjZjOC00NjNiLTg2M2UtNzM5NmE1NGM5ZDIz2AIE4AIB&sid=599cf1277608306e179e8143108c3f56");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.booking.com/hotel/id/indonesia-entire-home-for-tourist.id.html?aid=356980&label=gog235jc-1DCAMYkgQoaEIOYmFuZGFyLWxhbXB1bmdIElgDaGiIAQGYARK4ARfIAQzYAQPoAQH4AQKIAgGoAgO4AsCFp68GwAIB0gIkM2UzMTVkOTEtMjZjOC00NjNiLTg2M2UtNzM5NmE1NGM5ZDIz2AIE4AIB&sid=599cf1277608306e179e8143108c3f56");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.booking.com/hotel/id/modern-and-cozy-home-with-3-bedrooms-and-pool.id.html?aid=356980&label=gog235jc-1DCAMYkgQoaEIOYmFuZGFyLWxhbXB1bmdIElgDaGiIAQGYARK4ARfIAQzYAQPoAQH4AQKIAgGoAgO4AsCFp68GwAIB0gIkM2UzMTVkOTEtMjZjOC00NjNiLTg2M2UtNzM5NmE1NGM5ZDIz2AIE4AIB&sid=599cf1277608306e179e8143108c3f56");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan Pemesanan = new Pemesanan();
            Pemesanan.Show();
        }
    }
}
