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
    public partial class Locker : Form
    {
        public Locker()
        {
            InitializeComponent();
        }
        RichTextBox lo = new RichTextBox();
        Nizzc_Collection.tags msgshow = new Nizzc_Collection.tags();
        private void button1_Click(object sender, EventArgs e)
        { 
            string [] sp = Nizzc_Mobile_Ser.Form1.lockingopt.Split(':');
            if (textBox1.Text.Trim() == sp[0])
            {
                Close();
            }
            else
            {
                textBox1.BackColor = Color.Red;
                Nizzc_Collection.tags ShowMessage = new Nizzc_Collection.tags();
                ShowMessage.Message("Credentials error", "Your information is not valid.", false, "Ok", "");
                ShowMessage.ShowDialog();
            }
        }
        private void Locker_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception c) { MessageBox.Show(c.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.BackColor = Color.White;
            label2.Text = "Application is locked";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string[] sp = Nizzc_Mobile_Ser.Form1.lockingopt.Split(':');
            if (textBox1.Text.Trim() == sp[0])
            {
                RichTextBox sav = new RichTextBox();
                Nizzc_Mobile_Ser.Form1.lockingopt = "00000:off";
                Nizzc_Collection.tags ShowMessage = new Nizzc_Collection.tags();
                ShowMessage.Message("NOTICE!", "Your application is unprotected now!", false, "Ok", "");
                ShowMessage.ShowDialog();
                     Close();
            }
            else
            {
                textBox1.BackColor = Color.Red;
                Nizzc_Collection.tags ShowMessage = new Nizzc_Collection.tags();
                ShowMessage.Message("Credentials error", "Your information is not valid.", false, "Ok", "");
                ShowMessage.ShowDialog();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        string sh;
        private void button3_Click_1(object sender, EventArgs e)
        {
                string[] sp = Nizzc_Mobile_Ser.Form1.lockingopt.Split(':');
                RichTextBox clo = new RichTextBox();
                clo.Text = sp[2];
                clo.ForeColor = Color.Red;
                Nizzc_Collection.tags ShowMessage = new Nizzc_Collection.tags();
                ShowMessage.Message("Password Hint", "Your password hint is: '"+clo.Text+"'" , false, "Ok", "");
                if (clo.Text.Trim() != string.Empty)
                {
                    ShowMessage.ShowDialog();
                }
                else
                {
                    ShowMessage.Message("Password Hint", "No password hint was made.", false, "Ok", "");
                    ShowMessage.ShowDialog();
                }
        }
    }
}
