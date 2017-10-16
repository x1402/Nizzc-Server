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
    public partial class messagechangng : Form
    {
        public messagechangng()
        {
            InitializeComponent();
        }
        Timer t = new Timer();
        public static RichTextBox mg = new RichTextBox();
        private void messagechangng_Load(object sender, EventArgs e)
        {
            TextBox text = new TextBox();
            text.Text = Nizzc_Collection.Form4.com1.Text ;
            mg.Text = Form4.richbox.Text;
            string[] sp = text.Text.Split('$');
            textBox1.Text = text.Text.Replace(sp[0] + "$", "").Replace("%L%", System.Environment.NewLine).Replace("%L%%L%", System.Environment.NewLine + System.Environment.NewLine);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form4.com3.Text ="[MESSAGE]$"+ textBox1.Text.Replace("\n", "%L%"); 
            Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
            }
            if (e.KeyCode == Keys.Space)
            {
            }
        }
        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
            }
            if (e.KeyCode == Keys.Space)
            { 
            }
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
