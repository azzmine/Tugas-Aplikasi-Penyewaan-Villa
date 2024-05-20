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
    public partial class Kalimantan_Tengah : Form
    {
        public Kalimantan_Tengah()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            p p = new p();
            p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.traveloka.com/id-id/hotel/indonesia/rimba-orangutan-eco-lodge-1000000606634");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.booking.com/hotel/id/garuda-guesthouse.id.html");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bougenvilleseigohong.com/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.booking.com/hotel/id/bukit-raya-guesthouse.en-gb.html?aid=311984&label=bukit-raya-guesthouse-VGQ1nTmFsMS3gmZLPTdl_QS541251930641%3Apl%3Ata%3Ap1%3Ap2%3Aac%3Aap%3Aneg%3Afi%3Atiaud-146342137510%3Akwd-60911193723%3Alp9056670%3Ali%3Adec%3Adm%3Appccp%3DUmFuZG9tSVYkc2RlIyh9YXORK0YJiVoOxcWODxYDaAA&sid=73300f9564a4b2d88fdf50228b5745a4&all_sr_blocks=84473402_205830341_2_41_0;checkin=2024-10-01;checkout=2024-10-08;dest_id=-2690353;dest_type=city;dist=0;group_adults=1;group_children=0;hapos=1;highlighted_blocks=84473402_205830341_2_41_0;hpos=1;matching_block_id=84473402_205830341_2_41_0;no_rooms=1;req_adults=1;req_children=0;room1=A;sb_price_type=total;sr_order=popularity;sr_pri_blocks=84473402_205830341_2_41_0__334880000;srepoch=1714022148;srpvid=6b062501ff6000c1;type=total;ucfs=1&#hotelTmpl");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.booking.com/hotel/id/rungan-sari.en-gb.html?aid=311984&label=rungan-sari-srDY9OTjKfNsaMc_WYWLJAS541220300396%3Apl%3Ata%3Ap1%3Ap2%3Aac%3Aap%3Aneg%3Afi%3Atiaud-146342137510%3Akwd-26245994621%3Alp9056670%3Ali%3Adec%3Adm%3Appccp%3DUmFuZG9tSVYkc2RlIyh9YXORK0YJiVoOxcWODxYDaAA&sid=599cf1277608306e179e8143108c3f56&all_sr_blocks=42432901_335383412_0_1_0;checkin=2024-03-10;checkout=2024-03-11;dest_id=-2678717;dest_type=city;dist=0;group_adults=1;group_children=0;hapos=1;highlighted_blocks=42432901_335383412_0_1_0;hpos=1;matching_block_id=42432901_335383412_0_1_0;no_rooms=1;req_adults=1;req_children=0;room1=A;sb_price_type=total;sr_order=popularity;sr_pri_blocks=42432901_335383412_0_1_0__70180000;srepoch=1709958458;srpvid=2e401f5aa5eb0087;type=total;ucfs=1&#hotelTmpl");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan Pemesanan = new Pemesanan();
            Pemesanan.Show();
        }
    }
}
