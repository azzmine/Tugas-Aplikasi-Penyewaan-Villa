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
    public partial class Jawa_Timur : Form
    {
        public Jawa_Timur()
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
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g1237079-d4886640-Reviews-The_Batu_Villas-Batu_East_Java_Java.html");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g20365583-d625058-Reviews-Ijen_Resort_and_Villas-Krajan_East_Java_Java.html");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g1237079-d2313254-Reviews-Jambuluwuk_Convention_Hall_Resort_Batu-Batu_East_Java_Java.html");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g12595377-d10365744-Reviews-Kampoeng_Joglo_Ijen-Licin_East_Java_Java.html");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g3735720-d1308746-Reviews-Villa_Guesthouse_Rumah_Kita-Kalibaru_East_Java_Java.html");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g297710-d8792102-Reviews-Djoglo_Luxury_Bungalow-Malang_East_Java_Java.html");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g1237079-d10257154-Reviews-Azcarya_Villa-Batu_East_Java_Java.html");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g1237079-d1862654-Reviews-Villa_Family_Hotel_Gradia-Batu_East_Java_Java.html");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g3735720-d12793080-Reviews-Villa_Kendi-Kalibaru_East_Java_Java.html");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan Pemesanan = new Pemesanan();
            Pemesanan.Show();
        }
    }
}
