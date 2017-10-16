using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Nizzc_Collection
{
    public partial class tags : Form
    {
        public static RichTextBox mess = new RichTextBox();
        public static int timing;
        public tags()
        {
            InitializeComponent();
        }
        Nizzc_Mobile_Ser.Form1 mainform = new Nizzc_Mobile_Ser.Form1();
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void messageshower_Load(object sender, EventArgs e)
        {
        }
        //Handler 
        public void Message(string Title, string message, bool yesno,string no1,string yes1)
        {
            title.Text  = Title;
            msg.Text = message;
            yes.Visible = yesno;
            no.Text = no1;
            yes.Text = yes1;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void show(string messages)
        {
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Interval = timing;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Nizzc_Mobile_Ser.Form1.YesNo = "no";
            Close();
        }
        private void yes_Click(object sender, EventArgs e)
        {
            Nizzc_Mobile_Ser.Form1.YesNo = "yes";
            Close();
        }
    }
}
