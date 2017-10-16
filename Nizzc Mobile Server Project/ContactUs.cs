using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
namespace Nizzc_Collection
{
    public partial class ContactUs : Form
    {
        public ContactUs()
        {
            InitializeComponent();
        }
        string pass = "";//Please specify passowrd
        private void label1_Click(object sender, EventArgs e)
        {
        }
        Nizzc_Collection.tags ShowMessage = new Nizzc_Collection.tags();
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == string.Empty && textBox3.Text.Trim() == string.Empty)
            {
                ShowMessage.StartPosition = FormStartPosition.CenterParent;
                ShowMessage.Message("Required Information", "Please provide all required information. ", false, "OK", "Yes");
                ShowMessage.ShowDialog();
            }
            else if (textBox1.Text.Trim() != string.Empty && textBox1.Text.Trim().Contains("@"))
            {
                System.Threading.Thread thre = new System.Threading.Thread(() =>
                {
                    button4.Text = "Sending...";
                    button4.Enabled = false;
                   // button1.Enabled = false;
                    var fromAddress = new MailAddress("noreply@nizzc.com", "Customer contact");
                    var toAddress = new MailAddress("team@nizzc.com", textBox2.Text);
                    string fromPassword = pass;
                    string subject = textBox2.Text;
                    string Msg = textBox3.Text;
                    string body = "From: " + textBox2.Text + "\nEmail: " + textBox1.Text + "\n---\nMessage:\n" + Msg;
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.nizzc.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                    };
                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        try
                        {
                            smtp.Send(message);
                            button4.Text = "Message sent!";
                            button1.Enabled = true;
                        }
                        catch 
                        {
                             ShowMessage.Message("Message sendding error", "Couldn't complete your request. Check your internet connection or email", false, "OK", "Yes");
                            ShowMessage.ShowDialog();
                            button4.Text = "Send";
                            button4.Enabled = true;
                        }
                    }
                }); thre.Start();
            }
            else
            {
                ShowMessage.StartPosition = FormStartPosition.CenterParent;
                ShowMessage.Message("Required Information", "Please provide all required information. ", false, "OK", "Yes");
                ShowMessage.ShowDialog();
            }
        }
        private void ContactUs_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button4.Text.Trim().ToLower() == "sending...")
            {
                try
                {
                    ShowMessage.StartPosition = FormStartPosition.CenterParent;
                    ShowMessage.Message("Awaiting...", "Please wait while current process is being completed.", false, "OK", "Yes");
                    ShowMessage.ShowDialog();
                }
                catch { }
            }
            else
            {
                Close();
            }
        }
    }
}
