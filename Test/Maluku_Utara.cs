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
    public partial class Maluku_Utara : Form
    {
        public Maluku_Utara()
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
            System.Diagnostics.Process.Start("https://www.booking.com/hotel/id/vila-ma-rasai.id.html");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan pemesanan = new Pemesanan();
            pemesanan.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g15213346-d7089058-Reviews-Sabua_Gaba-Jailolo_Halmahera_North_Maluku_Maluku_Islands.html");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=villa+dekat+pantai+dodola+maluku+utara&sca_esv=ffe209feeacdfb2d&sca_upv=1&rlz=1C1CHBF_enID1057ID1057&ei=L6YHZtrCBd264-EPys2UyAY&oq=villa+dekat+pantai+dodo+maluku+utara&gs_lp=Egxnd3Mtd2l6LXNlcnAiJHZpbGxhIGRla2F0IHBhbnRhaSBkb2RvIG1hbHVrdSB1dGFyYSoCCAAyChAhGAoYoAEYwwQyChAhGAoYoAEYwwQyChAhGAoYoAEYwwQyChAhGAoYoAEYwwQyChAhGAoYoAEYwwRIjmBQpxRY1U1wAXgAkAEAmAFwoAGMDKoBBDE0LjS4AQHIAQD4AQGYAhGgAvMLwgIIEAAYgAQYogTCAggQABiJBRiiBMICCBAhGKABGMMEwgIMECEYChigARjDBBgKwgIGECEYChgKmAMAiAYBkgcEMTMuNKAHiE8&sclient=gws-wiz-serp&lqi=CiZ2aWxsYSBkZWthdCBwYW50YWkgZG9kb2xhIG1hbHVrdSB1dGFyYUj0_4malrSAgAhaPBAAEAIQAxgAGAMYBBgFIiZ2aWxsYSBkZWthdCBwYW50YWkgZG9kb2xhIG1hbHVrdSB1dGFyYSoECAMQAJIBBXZpbGxhmgEjQ2haRFNVaE5NRzluUzBWSlEwRm5TVVJrTFRjeU5rTm5FQUWqAVoQASoJIgV2aWxsYSgmMh8QASIbFvbn2AVtvkhZY9DAs7LWkJGijmn9NMOZCnUCMioQAiImdmlsbGEgZGVrYXQgcGFudGFpIGRvZG9sYSBtYWx1a3UgdXRhcmE#rlimm=12179903385121268597");
        }
    }
}
