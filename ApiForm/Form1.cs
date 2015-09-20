using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  freegeoip.net / xml / 4.2.2.2

            var client = new WebClient();
            var text = client.DownloadString("http://freegeoip.net/json/4.2.2.2");
            textBox1.Text = text ;






        }
    }
}
