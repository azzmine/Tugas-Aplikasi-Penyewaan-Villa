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
    public partial class Jawa_Tengah : Form
    {
        public Jawa_Tengah()
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
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g790291-d2446582-Reviews-Villa_Borobudur_Resort-Borobudur_Magelang_Central_Java_Java.html");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g790291-d2231929-Reviews-Rumah_Boedi_Private_Residence_Borobudur-Borobudur_Magelang_Central_Java_Java.html");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g1574417-d1307688-Reviews-Kura_Kura_Resort-Karimun_Jawa_Central_Java_Java.html");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g297713-d6441127-Reviews-Edelweiss_Hideaway_Solo-Solo_Central_Java_Java.html");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g1189712-d3350659-Reviews-Bayfront_Villa_Jepara-Jepara_Central_Java_Java.html");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g12564917-d17432199-Reviews-De_Villa_Cetho-Karanganyar_Central_Java_Java.html");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g1012818-d7984072-Reviews-Villa_Parikesit-Salatiga_Central_Java_Java.html");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan  Pemesanan = new Pemesanan();
            Pemesanan.Show();
        }
    }
}
