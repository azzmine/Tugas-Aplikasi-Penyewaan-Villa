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
    public partial class Sumatera_Selatan : Form
    {
        public Sumatera_Selatan()
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
            System.Diagnostics.Process.Start("https://www.agoda.com/lotus-villa-palembang/hotel/palembang-id.html?cid=1844104&ds=Ftyc71Kwj6lSqz0g");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tiket.com/homes/indonesia/villa-yogi-surf-3-canggu-611001699011534351?room=1&adult=1&checkin=2024-03-07&checkout=2024-03-08&soldOut=false");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.booking.com/hotel/id/mengskuy-villa.id.html?aid=356980&label=gog235jc-1FCAMYkgQoaEIJcGFsZW1iYW5nSBJYA2hoiAEBmAESuAEXyAEM2AEB6AEB-AECiAIBqAIDuAKJj6avBsACAdICJDQzYzMyNWQ4LTY0NzgtNDk1MC1iNTBmLTRjZWY3YTY1MTcxMNgCBeACAQ&sid=599cf1277608306e179e8143108c3f56&all_sr_blocks=1088307801_381749933_2_0_0&checkin=2024-10-01&checkout=2024-10-08&dest_id=-2690401&dest_type=city&dist=0&group_adults=2&group_children=0&hapos=3&highlighted_blocks=1088307801_381749933_2_0_0&hpos=3&matching_block_id=1088307801_381749933_2_0_0&nflt=sth%3D20&no_rooms=1&req_adults=2&req_children=0&room1=A%2CA&sb_price_type=total&sr_order=popularity&sr_pri_blocks=1088307801_381749933_2_0_0__17850000000&srepoch=1709803428&srpvid=32d0420b9d4c004c&type=total&ucfs=1&activeTab=main");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.booking.com/hotel/id/alaina-villa.id.html?aid=356980&label=gog235jc-1FCAYYkgQoaEIPc3VtYXRyYS1zZWxhdGFuSBJYA2hoiAEBmAESuAEXyAEM2AEB6AEB-AECiAIBqAIDuAKYk6avBsACAdICJDhiNzI1M2ZiLWFmZDItNGY0OS04MmY3LWQ5MjA2NWIyMWI5NNgCBeACAQ&sid=599cf1277608306e179e8143108c3f56&all_sr_blocks=825447401_370447773_5_0_0;checkin=2024-10-01;checkout=2024-10-08;dest_id=5446;dest_type=region;dist=0;group_adults=2;group_children=0;hapos=2;highlighted_blocks=825447401_370447773_5_0_0;hpos=2;matching_block_id=825447401_370447773_5_0_0;nflt=sth%3D20;no_rooms=1;req_adults=2;req_children=0;room1=A%2CA;sb_price_type=total;sr_order=popularity;sr_pri_blocks=825447401_370447773_5_0_0__1097250000;srepoch=1709803966;srpvid=86894317e3f700dd;type=total;ucfs=1&#hotelTmpl");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan pemesanan = new Pemesanan();
            pemesanan.Show();
        }
    }
}
