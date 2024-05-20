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
    public partial class Jawa_Barat : Form
    {
        public Jawa_Barat()
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
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g1137840-d13386687-Reviews-Aleyra_Hotel_and_Villa_s_Garut-Garut_West_Java_Java.html");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g297707-d10995272-Reviews-Desa_Alamanis_Resort_Vila-Cirebon_West_Java_Java.html");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g1137840-d14794584-Reviews-Cahaya_Villa_Hotel-Garut_West_Java_Java.html");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g7187358-d1916235-Reviews-Villa_Istana_Bunga-Lembang_West_Java_Java.html");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g297704-d6350978-Reviews-Kastuba_Resort-Bandung_West_Java_Java.html");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g297706-d11858499-Reviews-EdensoR_Hills_Villa_Resort_Cafe-Bogor_West_Java_Java.html");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g297704-d1975938-Reviews-Osmond_Villa_Resort-Bandung_West_Java_Java.html");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan Pemesanan = new Pemesanan();
            Pemesanan.Show();  
        }
    }
}
