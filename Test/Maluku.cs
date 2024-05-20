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
    public partial class Maluku : Form
    {
        public Maluku()
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

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g3793647-d1197784-Reviews-Cape_Paperu_Resort_Spa-Saparua_Maluku_Maluku_Islands.html");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g15239592-d15230666-Reviews-Ora_Sunrise_View_Resort-Saleman_Maluku_Maluku_Islands.html");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.agoda.com/id-id/bellarizki-resort/hotel/saleman-id.html?finalPriceView=1&isShowMobileAppPrice=false&cid=1587481&numberOfBedrooms=&familyMode=false&adults=2&children=0&rooms=1&maxRooms=0&checkIn=2024-04-7&isCalendarCallout=false&childAges=&numberOfGuest=0&missingChildAges=false&travellerType=1&showReviewSubmissionEntry=false&currencyCode=IDR&isFreeOccSearch=false&tag=hid31664557%2Cpide0ef9b30-1d38-4368-ae87-f1d01fb569f8&isCityHaveAsq=false&los=1&searchrequestid=40ba216d-a10d-4d87-82a2-9dcd950e7bc0&ds=sjuf1QCyMaB%2Bx6Vl");
        }
    }
}
