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
    public partial class Nusa_Tenggara_Barat : Form
    {
        public Nusa_Tenggara_Barat()
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
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g1592993-d25316392-Reviews-Kalandara_Resort_Lombok-Senggigi_Lombok_West_Nusa_Tenggara.html?spAttributionToken=MjMyOTMzMTg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g3177245-d302429-Reviews-The_Oberoi_Beach_Resort_Lombok-Tanjung_Lombok_West_Nusa_Tenggara.html");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g664666-d1223817-Reviews-Pondok_Santi_Estate_Gili_Trawangan-Gili_Trawangan_Gili_Islands_Pemenang_Lombok_West_Nu.html");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g2708413-d299126-Reviews-Holiday_Resort_Lombok-Mangsit_Senggigi_Lombok_West_Nusa_Tenggara.html");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan pemesanan = new Pemesanan();
            pemesanan.Show();
        }
    }
}
