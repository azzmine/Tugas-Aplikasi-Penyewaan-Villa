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
    public partial class Papua_Barat_Daya : Form
    {
        public Papua_Barat_Daya()
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
            System.Diagnostics.Process.Start("https://www.booking.com/hotel/id/hamueco-raja-ampat.en-gb.html?aid=311984&label=hamueco-raja-ampat-uiMpLYUmWY8CeaxlE4gGsQS590144421528%3Apl%3Ata%3Ap1%3Ap2%3Aac%3Aap%3Aneg%3Afi%3Atiaud-146342136310%3Akwd-361755775608%3Alp9074371%3Ali%3Adec%3Adm%3Appccp%3DUmFuZG9tSVYkc2RlIyh9YbSsBl3MCvHsD8UKUHIRFxY&sid=599cf1277608306e179e8143108c3f56&dest_id=-2693518;dest_type=city;dist=0;group_adults=1;group_children=0;hapos=1;hpos=1;no_rooms=1;req_adults=1;req_children=0;room1=A;sb_price_type=total;sr_order=popularity;srepoch=1710299987;srpvid=2b0c175be04d00a8;type=total;ucfs=1&#hotelTmpl");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g3632533-d17816558-Reviews-D_coral_Paradise_Resort-Waisai_Raja_Ampat_West_Papua.html");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.traveloka.com/id-id/hotel/indonesia/korpak-villa--resort-raja-ampat-9000000790400");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.booking.com/hotel/id/waiwo-dive-resort-raja-ampat.en-gb.html?aid=311984&label=waiwo-dive-resort-raja-ampat-DIoMo5pAyMd_0ZM_JJX8MQS675500278535%3Apl%3Ata%3Ap1%3Ap2%3Aac%3Aap%3Aneg%3Afi%3Atikwd-45949978582%3Alp9074371%3Ali%3Adec%3Adm%3Appccp%3DUmFuZG9tSVYkc2RlIyh9YbSsBl3MCvHsD8UKUHIRFxY&sid=599cf1277608306e179e8143108c3f56&dest_id=-2693518;dest_type=city;dist=0;group_adults=1;group_children=0;hapos=1;hpos=1;no_rooms=1;req_adults=1;req_children=0;room1=A;sb_price_type=total;sr_order=popularity;srepoch=1710300765;srpvid=3a5518e96ce10034;type=total;ucfs=1&#hotelTmpl");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan pemesanan = new Pemesanan();
            pemesanan.Show();
        }
    }
}
