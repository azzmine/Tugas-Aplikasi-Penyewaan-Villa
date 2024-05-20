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
    public partial class Bali : Form
    {
        public Bali()
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
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g469404-d12596935-Reviews-Aramanis_Villas-Seminyak_Kuta_District_Bali.html?spAttributionToken=MjMzMjk2MjI");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g297701-d14961458-Reviews-The_Sankara_Suite_Villas_By_Pramana-Ubud_Gianyar_Regency_Bali.html");
        }

        private void Bali_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g2209545-d1810099-Reviews-The_Samaya_Ubud_Bali-Sayan_Ubud_Gianyar_Regency_Bali.html");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g469404-d590208-Reviews-Uma_Sapna-Seminyak_Kuta_District_Bali.html");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g3185061-d10291705-Reviews-Purana_Boutique_Resort-Mas_Ubud_Gianyar_Regency_Bali.html");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g19007998-d12215533-Reviews-Samsara_Ubud-Kelusa_Payangan_Gianyar_Regency_Bali.html");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g469404-d7679389-Reviews-Villa_Sipo-Seminyak_Kuta_District_Bali.html?spAttributionToken=MjMyNjg3ODQ");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g297696-d7311692-Reviews-Ayana_Villas_Bali-Jimbaran_South_Kuta_Bali.html");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g297701-d2018544-Reviews-Royal_Kamuela_Villas_Suites_at_Monkey_Forest_Ubud-Ubud_Gianyar_Regency_Bali.html");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g469404-d11811375-Reviews-Aksari_Villa_Seminyak_by_Ini_Vie_Hospitality-Seminyak_Kuta_District_Bali.html");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g1219108-d9623334-Reviews-Prasana_by_Arjani_Resorts-Ungasan_Bukit_Peninsula_Bali.html");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g297698-d572368-Reviews-Kayumanis_Nusa_Dua_Private_Villa_Spa-Nusa_Dua_Benoa_South_Kuta_Bali.html");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan Pemesanan = new Pemesanan();
            Pemesanan.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
