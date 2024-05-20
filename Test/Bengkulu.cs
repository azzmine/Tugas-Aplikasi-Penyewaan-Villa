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
    public partial class Bengkulu : Form
    {
        public Bengkulu()
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
            Hide();
            Pemesanan Pemesanan = new Pemesanan();
            Pemesanan.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/villathania.baratwetan/?igsh=b2hobTQ2MjNiaXg2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/villa.xiaolake/?hl=en");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=Villa+Kepahiang+Bengkulu&sca_esv=6946a8fe4d355c0f&sca_upv=1&bih=599&biw=1366&rlz=1C1CHBF_enID1057ID1057&hl=en-US&hotel_occupancy=2&ei=SM0HZouXOr_u4-EPya2AmA0&ved=0ahUKEwiL25nhyJuFAxU_9zgGHckWANMQ4dUDCBA&uact=5&oq=Villa+Kepahiang+Bengkulu&gs_lp=Egxnd3Mtd2l6LXNlcnAiGFZpbGxhIEtlcGFoaWFuZyBCZW5na3VsdTIGEAAYFhgeSOQXUO8OWO8OcAF4AZABAJgBZ6ABZ6oBAzAuMbgBA8gBAPgBAfgBApgCAqACcqgCFMICIBAAGIAEGIoFGOUCGOUCGOoCGLQCGIoDGLcDGNQD2AEBwgIWEAAYAxiPARjlAhjqAhi0AhiMA9gBAsICFhAuGAMYjwEY5QIY6gIYtAIYjAPYAQKYAwi6BgQIARgHugYGCAIQARgKkgcDMS4xoAeRAQ&sclient=gws-wiz-serp&lqi=ChhWaWxsYSBLZXBhaGlhbmcgQmVuZ2t1bHVIhKjZ_8G4gIAIWiwQABgAGAEYAiIYdmlsbGEga2VwYWhpYW5nIGJlbmdrdWx1KgQIAxAAMgJpZJIBBXZpbGxhqgFMEAEqCSIFdmlsbGEoJjIfEAEiG6lfDKg_bLh6TNGSuPI8SwJWNdJay6K7b9LnKzIcEAIiGHZpbGxhIGtlcGFoaWFuZyBiZW5na3VsdQ#lkt=LocalPoiReviews&rlimm=507844590476756177");
        }
    }
}
