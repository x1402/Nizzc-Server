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
    public partial class Lock : Form
    {
        public Lock()
        {
            InitializeComponent();
        }
        Nizzc_Collection.tags msgshow = new Nizzc_Collection.tags();
        private void Lock_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Trim() == string.Empty || textBox1.Text.Length <5)
            {
                textBox1.BackColor = Color.Red;
                Nizzc_Collection.tags ShowMessage = new Nizzc_Collection.tags();
                ShowMessage.Message("Requirement", "Password should be at least 6 digits.", false, "Ok", "");
                ShowMessage.ShowDialog();
                //textBox3.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                label4.BackColor = Color.Transparent;
            }
            else if (textBox2.Text.Trim() == string.Empty || textBox2.Text.Trim() != textBox1.Text.Trim())
            {
                textBox2.BackColor = Color.Red;
                //label4.Text = "Passwords is not matched";
                Nizzc_Collection.tags ShowMessage = new Nizzc_Collection.tags();
                ShowMessage.Message("Password Match error", "Your passwords are not matched", false, "Ok", "");
                ShowMessage.ShowDialog();
                textBox1.BackColor = Color.White;
               // textBox3.BackColor = Color.White;
                label4.BackColor = Color.Transparent;
            }
            else if (textBox1.Text.Trim() != string.Empty && textBox2.Text.Trim() == textBox1.Text.Trim())
            {
                if (textBox3.Text.Trim() == textBox1.Text.Trim())
                {
                    Nizzc_Collection.tags ShowMessage = new Nizzc_Collection.tags();
                    ShowMessage.Message("Password hint error", "Hint should not be same to your password.", false, "Ok", "");
                    ShowMessage.ShowDialog();
                }
                else
                {
                    label4.BackColor = Color.Transparent;
                    // textBox3.BackColor = Color.White;
                    textBox2.BackColor = Color.White;
                    textBox1.BackColor = Color.White;
                    Nizzc_Mobile_Ser.Form1.lockingopt = textBox1.Text + ":on:"+textBox3.Text ;
                       Nizzc_Collection.tags ShowMessage = new Nizzc_Collection.tags();
                    ShowMessage.Message("Success", "Locker activated! \nTo lock the application click 'Lock' button.", false, "Ok", "");
                    ShowMessage.ShowDialog();
                    tags t = new tags();
                         Close();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
          textBox2.BackColor =  textBox1.BackColor = Color.White;
          label4.Text = "Protect from unauthorized users";
        }
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            textBox2.BackColor = textBox1.BackColor = Color.White;
            label4.Text = "Protect from unauthorized users";
        }
    }
}
