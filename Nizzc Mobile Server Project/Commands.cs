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
    public partial class Commands : Form
    {
        public Commands()
        {
            InitializeComponent();
        }
        public static RichTextBox GetCommands = new RichTextBox();
        public static RichTextBox SetCommands = new RichTextBox();
        public static RichTextBox originalHELP = new RichTextBox();
        public static bool IsOk = false;
        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SetCommands.Text = cm1.Text + "|" + cm2.Text + "|" + cm3.Text + "|" + cm4.Text;
                SetCommands.SaveFile(@"spcm", RichTextBoxStreamType.PlainText);
                SetCommands.SaveFile(@"spcm", RichTextBoxStreamType.PlainText);
                IsOk = true;
                tags msgshow = new tags();
                msgshow.Message("Information", "Commands saved!", false, "Ok", "Ok");
                msgshow.ShowDialog();
                Close();
            }
            catch(Exception v) {
                tags msgshow = new tags();
                msgshow.Message("Error", "There is error occured while saving", false, "Ok", "Ok");
                msgshow.ShowDialog();
           }
        }
        private void Commands_Load(object sender, EventArgs e)
        {
            try
            {
                string[] sp = GetCommands.Text.Split('|');
                cm1.Text = sp[0]; cm2.Text = sp[1]; cm3.Text = sp[2]; cm4.Text = sp[3];
            }
            catch (Exception v)
            {
                MessageBox.Show(v.ToString());
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string[] sp = originalHELP.Text.Split('|');
                cm1.Text = sp[0];
                cm2.Text = sp[1];
                cm3.Text = sp[2];
                cm4.Text = sp[3];
            }
            catch
            {
                tags msgshow = new tags();
                msgshow.Message("Error", "There is error occured!", false, "Ok", "Ok");
                msgshow.ShowDialog();
            }
        }
    }
}
