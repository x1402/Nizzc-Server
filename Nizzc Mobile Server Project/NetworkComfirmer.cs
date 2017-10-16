using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Nizzc_Mobile_Server
{
    public partial class NetworkComfirmer : Form
    {
        public NetworkComfirmer()
        {
            InitializeComponent();
        }
        private void no_Click(object sender, EventArgs e)
        {
            Close();
        }
        RichTextBox Rcode = new RichTextBox();
        public void ShowMessage(string Bot, long Code)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Rcode.SelectAll();
            Rcode.Copy();
            label2.Visible = true;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            label2.Visible = false;
        }
        public static long Ccode = 0;
        public static string StrMsg = "";
        public static string Bot = "";
        private void NetworkComfirmer_Load(object sender, EventArgs e)
        {
            label1.Text = StrMsg;
            Rcode.Text = Ccode.ToString();
        }
    }
}
