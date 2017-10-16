using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Nizzc_Mobile_Ser;
using System.Threading;
namespace Nizzc_Mobile_Server
{
    public partial class UpdateMybot : Form
    {
        public UpdateMybot()
        {
            InitializeComponent();
        }
        public static String IPpassword = "";//Please specify your IP password or contact us
        public static string IP = "https://nizzc.com/freenet:2124";//or choose your own.
        public static string IPusername = "";//Please specify your IP password or contact us
        private void button1_Click(object sender, EventArgs e)
        {
            Thread thre = new Thread(() =>
            {
                button1.Text = "Checking...";
                button1.Enabled = false;  
                try
                {
                    long Code = Convert.ToInt64(textBox1.Text);
                    WebClient FTP = new WebClient();
                    FTP.Credentials = new NetworkCredential(IPusername, IPpassword);
                    string juststring = FTP.DownloadString(IP.Replace("freenet:2124","") + "verify/" + Code.ToString());
                        button1.Text = "Updating...";
                        button1.Enabled = false;
                        msg.Text = "Your bot is being updated. Please don't close this window untill updating finishes.";
                        Form1 Upd = new Form1();
                        if (UpdateFTP(Code))
                        {
                            button1.Text = "Updated";
                            button1.Enabled = false;
                            msg.Text = "Your bot has been updated successfully.\nPlease send to your bot #UPDATE to make changes effect.\nPlease tell any problem to 'team@nizzc.com'";
                        }
                        else
                        {
                            button1.Text = "Update";
                            button1.Enabled = true ;
                            msg.Text = "There is error occured while updating your bot. Please check your internet connection.\nIf this error persists, please inform us 'team@nizzc.com'";
                        }
                }
                catch
                {
                    button1.Text = "Update";
                    button1.Enabled = true;
                    msg.Text = "Invalid code or no internet connection. Please try again!";
                }
            }); thre.IsBackground = true; thre.Start();
        }
        public static RichTextBox lo1 = new RichTextBox();
        bool UPdateSaverFTP()
        {
            bool isOk = false;
            try
            {
                lo1.SaveFile(@"Up", RichTextBoxStreamType.PlainText);
                lo1.SaveFile(@"Up", RichTextBoxStreamType.PlainText);
                isOk = true;
            }
            catch { }
            return isOk;
        }
        public bool UpdateFTP(long Code)
        {
            bool isOk = false;
            if (UPdateSaverFTP())
            {
                try
                {
                    WebClient ftp = new WebClient();
                    ftp.Credentials = new NetworkCredential(IPusername, IPpassword);
                    ftp.UploadFile(IP + "nimbuzz/" + Code.ToString(), "STOR", @"Up");
                    isOk = true;
                }
                catch
                {
                }
            }
            return isOk;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
