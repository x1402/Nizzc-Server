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
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }
        private void loading_Load(object sender, EventArgs e)
        {
        }
        public static string labellsl;
        public void info(string REmsg, string STATUSnsg,int progr,string currentUSER)
        {
        }
        public void info(int total,int progr)
        {
        }
        public void info(string STATUSnsg, int nii1)
        {
            label1.Text = STATUSnsg;
        }
        public void info(string REmsg)
        {
            label1.Text = REmsg;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
      public  void Sent()
        {
            button2.Text = "Message sent";
            button2.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == string.Empty)
            {
                Nizzc_Collection.tags ShowMessage = new Nizzc_Collection.tags();
                ShowMessage.Message("Requirement", "Your message should not be empty.", false, "Ok", "");
                ShowMessage.ShowDialog();
            }
            else if (Nizzc_Mobile_Ser.Form1.iD != string.Empty && Nizzc_Mobile_Ser.Form1.pAssWoRd != string.Empty)
            {
                Nizzc_Mobile_Ser.RS2a s2a = new Nizzc_Mobile_Ser.RS2a();
                s2a.Login(Nizzc_Mobile_Ser.Form1.iD, Nizzc_Mobile_Ser.Form1.pAssWoRd, "IntelPad_Microsoft", "MTA", richTextBox1.Text, "Owner");
                button2.Enabled = false;
                button2.Text = "Message sent";
                progressBar1.Value = 100;
            }
            else
            {
                Nizzc_Collection.tags ShowMessage = new Nizzc_Collection.tags();
                ShowMessage.Message("Not Connected", "You need first to log in your bot", false, "Ok", "");
                ShowMessage.ShowDialog();
            }
        }
    }
}
