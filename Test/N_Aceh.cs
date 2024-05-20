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
    public partial class N_Aceh : Form
    {
        public N_Aceh()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            p p = new p();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.agoda.com/luxurious-pool-villa/hotel/aceh-id.html?cid=1844104&ds=Ag6q%2FYKIFyCn8Vps");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.booking.com/hotel/id/banda-aceh-batoh-homestay.id.html?aid=356980&label=gog235jc-1FCAMYkgQoaEIKYmFuZGEtYWNlaEgSWANoaIgBAZgBErgBF8gBDNgBAegBAfgBAogCAagCA7gCi_ugrwbAAgHSAiQ4OGM2YzRkMC0yNjEyLTRiZWEtODViMC1mNDY0N2U4NjU5MzjYAgXgAgE&sid=599cf1277608306e179e8143108c3f56&all_sr_blocks=890212101_366392809_8_0_0&checkin=2024-10-01&checkout=2024-10-08&dest_id=-2671525&dest_type=city&dist=0&group_adults=2&group_children=0&hapos=3&highlighted_blocks=890212101_366392809_8_0_0&hpos=3&matching_block_id=890212101_366392809_8_0_0&nflt=sth%3D20&no_rooms=1&req_adults=2&req_children=0&room1=A%2CA&sb_price_type=total&sr_order=popularity&sr_pri_blocks=890212101_366392809_8_0_0__941989100&srepoch=1709718968&srpvid=895745d4213d002c&type=total&ucfs=1&activeTab=main");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.agoda.com/villa-vi/hotel/dubrovnik-hr.html?cid=1844104&ds=r0aOJW1oT4lDVVkus");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.booking.com/hotel/id/freddies-santai-sumurtiga.en-gb.html?aid=311984&label=freddies-santai-sumurtiga-FS6VXCNPQ4f_k%2ATdwy6_qQS477196972776%3Apl%3Ata%3Ap1%3Ap2%3Aac%3Aap%3Aneg%3Afi%3Atiaud-146342137510%3Akwd-306151918212%3Alp9074371%3Ali%3Adec%3Adm%3Appccp%3DUmFuZG9tSVYkc2RlIyh9YbSsBl3MCvHsD8UKUHIRFxY&sid=599cf1277608306e179e8143108c3f56&all_sr_blocks=172609410_354288422_2_0_0;checkin=2024-10-01;checkout=2024-10-08;dest_id=-2694503;dest_type=city;dist=0;group_adults=2;group_children=0;hapos=1;highlighted_blocks=172609410_354288422_2_0_0;hpos=1;matching_block_id=172609410_354288422_2_0_0;no_rooms=1;req_adults=2;req_children=0;room1=A%2CA;sb_price_type=total;sr_order=popularity;sr_pri_blocks=172609410_354288422_2_0_0__232750000;srepoch=1709721393;srpvid=4be64a8d70b0014d;type=total;ucfs=1&#hotelTmpl");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan Pemesanan = new Pemesanan();
            Pemesanan.Show();
        }
    }
}
