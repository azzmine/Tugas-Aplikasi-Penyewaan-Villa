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
    public partial class Papua_Tengah : Form
    {
        public Papua_Tengah()
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
            System.Diagnostics.Process.Start("https://www.tripadvisor.co.id/Hotel_Review-g680180-d526784-Reviews-The_Baliem_Valley_Resort-Wamena_Papua.html");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/travel/hotels/entity/ChkIgLaCmsqx_eNyGg0vZy8xMWxna2RqZnBsEAE?q=villa%20terbaik%20di%20papua%20tengah&g2lb=2502548%2C2503771%2C2503781%2C2504511%2C4258168%2C4284970%2C4291517%2C4814050%2C4874190%2C4893075%2C4965990%2C72248050%2C72248052%2C72277293%2C72302247%2C72317059%2C72406588%2C72414906%2C72421566%2C72458066%2C72462234%2C72467704%2C72469155%2C72470440%2C72470899%2C72471280%2C72472051%2C72473738%2C72473841%2C72483525%2C72484736%2C72485656%2C72485658%2C72486593%2C72494250%2C72498532%2C72505054%2C72510103%2C72511832%2C72512134%2C72513419%2C72513513%2C72521825&hl=id-ID&gl=id&ssta=1&ts=CAEaMwoVEhEKCC9tLzAzeHJxOgVQYXB1YRoAEhoSFAoHCOgPEAMYHRIHCOgPEAMYHhgBMgIQACoLCgU6A0lEUhoAKAg&qs=CAE4BEIJCfZnJZPHeX1VQgkJRFNeIEGdiRBCCQktwzZCUEhgfUgA&ap=KigKEgmt06JbAbglwBEzu5P0C-dgQBISCTI6Uco7kuo_ETO7k_QvK2JAMABoAQ&ictx=111&ved=0CAAQ5JsGahcKEwjozNnqm_CEAxUAAAAAHQAAAAAQAw&utm_campaign=sharing&utm_medium=link&utm_source=htls");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/travel/hotels/entity/ChoI0N2rsY20wPm1ARoNL2cvMTFrcjkyZzYzZxAB?q=villa%20terbaik%20di%20papua%20tengah&g2lb=2502548%2C2503771%2C2503781%2C2504511%2C4258168%2C4284970%2C4291517%2C4814050%2C4874190%2C4893075%2C4965990%2C72248050%2C72248052%2C72277293%2C72302247%2C72317059%2C72406588%2C72414906%2C72421566%2C72458066%2C72462234%2C72467704%2C72469155%2C72470440%2C72470899%2C72471280%2C72472051%2C72473738%2C72473841%2C72483525%2C72484736%2C72485656%2C72485658%2C72486593%2C72494250%2C72498532%2C72505054%2C72510103%2C72511832%2C72512134%2C72513419%2C72513513%2C72521825&hl=id-ID&gl=id&ssta=1&ts=CAEaMwoVEhEKCC9tLzAzeHJxOgVQYXB1YRoAEhoSFAoHCOgPEAMYHRIHCOgPEAMYHhgBMgIQACoLCgU6A0lEUhoAKAg&qs=CAE4BEIJCfZnJZPHeX1VQgkJRFNeIEGdiRBCCQktwzZCUEhgfUgA&ap=KigKEgnlAjrbnZ4uwBEzu5P0t4ZgQBISCVBMHbwq9R9AETO7k_T_DmNAMABoAQ&ictx=111&ved=0CAAQ5JsGahcKEwjglNiFnfCEAxUAAAAAHQAAAAAQAw&utm_campaign=sharing&utm_medium=link&utm_source=htls");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/travel/hotels/entity/ChoIudKuuI6CzMniARoNL2cvMTFjNnR0d3I5cRAB?q=villa%20terbaik%20di%20papua%20tengah&g2lb=2502548%2C2503771%2C2503781%2C2504511%2C4258168%2C4284970%2C4291517%2C4814050%2C4874190%2C4893075%2C4965990%2C72248050%2C72248052%2C72277293%2C72302247%2C72317059%2C72406588%2C72414906%2C72421566%2C72458066%2C72462234%2C72467704%2C72469155%2C72470440%2C72470899%2C72471280%2C72472051%2C72473738%2C72473841%2C72483525%2C72484736%2C72485656%2C72485658%2C72486593%2C72494250%2C72498532%2C72505054%2C72510103%2C72511832%2C72512134%2C72513419%2C72513513%2C72521825&hl=id-ID&gl=id&ssta=1&ts=CAESCgoCCAMKAggDEAAaUAoyEi4yJTB4NjgzYjJjMDRhYWZmOTI3MzoweGViYTk0ZTljNWVlZmU2NzM6BVBhcHVhGgASGhIUCgcI6A8QAxgdEgcI6A8QAxgeGAEyAhAAKgkKBToDSURSGgA&qs=CAESBENCST04BEIJCfZnJZPHeX1VQgkJRFNeIEGdiRBCCQktwzZCUEhgfUgA&ap=KigKEgnlAjrbnZ4uwBEzu5P0t4ZgQBISCVBMHbwq9R9AETO7k_T_DmNAMABoAQ&ictx=111&ved=0CAAQ5JsGahcKEwigjPPznfCEAxUAAAAAHQAAAAAQAw&utm_campaign=sharing&utm_medium=link&utm_source=htls");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Pemesanan pemesanan = new Pemesanan();
            pemesanan.Show();
        }
    }
}
