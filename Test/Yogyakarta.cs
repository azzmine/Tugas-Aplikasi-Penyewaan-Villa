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
    public partial class Yogyakarta : Form
    {
        public Yogyakarta()
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
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g294230-d1518889-Reviews-Villa_Pondok_Terra-Yogyakarta_Region_Java.html");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g294230-d7790694-Reviews-Villa_Rosseno-Yogyakarta_Region_Java.html");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g294230-d7149626-Reviews-Villa_Sambal-Yogyakarta_Region_Java.html");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g14782503-d15574404-Reviews-Duta_Garden_Hotel_Boutique_Villa-Yogyakarta_Yogyakarta_Region_Java.html");
        }

        private void Yogyakarta_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g3916131-d7779570-Reviews-Habitat_Hyarta-Ngaglik_Sleman_District_Yogyakarta_Region_Java.html");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan pemesanan = new Pemesanan();
            pemesanan.Show();
        }
    }
}
