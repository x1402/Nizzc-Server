using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using SHDocVw;
using System.Xml.Serialization.Advanced;
using agsXMPP;
using System.Net.Mail;
using agsXMPP.Collections;
using agsXMPP.protocol.client;
using System.Media;
using System.Windows.Forms.VisualStyles;
using System.Linq;
using System.Text;
using Nizzc_Collection;
using Nizzc_Mobile_Ser;
using System.Windows.Forms.ComponentModel;
using System.Windows.Forms;
using agsXMPP.exceptions;
using AxWMPLib;
using agsXMPP.util;
using agsXMPP.Xml.Dom;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Runtime.CompilerServices;
using System.IO;
using System.Xml;
using System.Collections;
using System.Collections.ObjectModel;
using System.Threading;
//
using System.Net.NetworkInformation;
//
using agsXMPP.protocol.x.muc;
using agsXMPP.protocol.iq.roster;
using System.Net;
using System.Web;
//
using Nizzc_Mobile_Ser;
using agsXMPP.protocol.extensions.html;
using Microsoft.Win32;
namespace Nizzc_Collection
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            try
            {
                Botmanager.LoadFile(@"org", RichTextBoxStreamType.PlainText);
            }
            catch  
            {
                Nizzc_Collection.tags ShowMessage = new Nizzc_Collection.tags();
                ShowMessage.Message("Error occured!", "Some files are missing. The application may not work perfectly. Please reinstall the application.", false, "Ok", "");
                ShowMessage.ShowDialog();
               }
        }
        tags ShowMessage = new tags();
        public static RichTextBox Botmanager = new RichTextBox();
        public static TextBox com1 = new TextBox();
        public static RichTextBox lister = new RichTextBox();
        public static TextBox com3 = new TextBox();
        public static RichTextBox richbox = new RichTextBox();
        public static TextBox com2 = new TextBox();
        Nizzc_Collection.tags msgshow = new Nizzc_Collection.tags();
        public static int linecu = new int();
        public static int linesel = new int();
        public static RichTextBox cl = new RichTextBox();
        public static RichTextBox ml = new RichTextBox();
        public static RichTextBox option1 = new RichTextBox();
       XmppClientConnection x = Nizzc_Mobile_Ser.Form1.f1;
       public static bool YesNo;
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void richTextBox1_DoubleClick(object sender, EventArgs e)
        {
            if ((richTextBox1.SelectedText.Contains("[") || richTextBox1.SelectedText.Contains("]") || richTextBox1.SelectedText == ("") || richTextBox1.SelectedText.Contains(" ") || richTextBox1.SelectedText==("") || richTextBox1.SelectedText==("") || richTextBox1.SelectedText == ("") || richTextBox1.SelectedText.Contains(" ") || richTextBox1.SelectedText.Contains("\n") || richTextBox1.SelectedText == ("") || richTextBox1.SelectedText.Contains(" ") || richTextBox1.SelectedText.Contains("\n") || richTextBox1.SelectedText == ("") || richTextBox1.SelectedText==("") || richTextBox1.SelectedText==("---Extra Commands---")) == true)
            {
            }
            else
            {
                    int corsur = this.richTextBox1.SelectionStart;
                    int lineindex = this.richTextBox1.GetLineFromCharIndex(corsur);
                    string linetext = this.richTextBox1.Lines[lineindex];
                    int le = richTextBox1.GetFirstCharIndexFromLine(lineindex);
                    com1.Text = linetext.Replace("[", "").Replace("]", "").Replace(" ", "").Replace("\n", "");
                    Nizzc_Collection.commandchange change = new commandchange(); ;
                    change.ShowDialog();
                    int ar = lineindex;
                    int lin = linetext.Length;
                    richTextBox1.Select(corsur, lin);
                    int count = linetext.Length;
                    richTextBox1.Select(le, count);
                    richTextBox1.SelectedText = "[" + com1.Text + "]";
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.Lines.Length > 0)
            {
                try
                {
                    richTextBox1.SaveFile(@"commands");
                    richTextBox1.SaveFile(@"commands");
                    label1.Text = "Changes has been updated!";
                }
                catch { label1.Text = "Something went wrong!"; }
            }
            else
                label1.Text = "Invaid commands!";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text.Contains("User"))
            {
                richTextBox1.ReadOnly = false;
                this.richTextBox1.Undo();
                richTextBox1.ReadOnly = true;
            }
            else if (tabControl1.SelectedTab.Text.Contains("Mes"))
            {
                richTextBox1.ReadOnly = false;
                richTextBox1.ReadOnly = true;
            }
            //
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text.Contains("User"))
            {
                richTextBox1.ReadOnly = false;
                this.richTextBox1.Redo();
                richTextBox1.ReadOnly = true;
            }
            else if (tabControl1.SelectedTab.Text.Contains("Mes"))
            {
                richTextBox1.ReadOnly = false;
                richTextBox1.ReadOnly = true;
            }
        }
        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            Nizzc_Collection.commandchange open = new commandchange();
        }
        private void tabControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        private void richTextBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RichTextBox chp = new RichTextBox();
            int corsur = this.richTextBox3.SelectionStart;
            int lineindex = this.richTextBox3.GetLineFromCharIndex(corsur);
            int selc = this.richTextBox3.GetFirstCharIndexFromLine(lineindex);
            linecu = selc;
            linesel = lineindex;
            string linetext = this.richTextBox3.Lines[lineindex];
            string[] l = richTextBox3.Lines;
            richTextBox6.Text = richTextBox3.Lines[lineindex];
            richbox.Text = richTextBox3.Text;
            com2.Text = l[lineindex];
            if (com2.Text.StartsWith("["))
            {
                richTextBox4.Text = l[lineindex];
                com1.Text = l[lineindex];
                com3.Text = l[lineindex];
                RichTextBox pas = new RichTextBox();
                messagechangng dis = new messagechangng();
                dis.ShowDialog();
                richTextBox4.Text = com3.Text;
                if (this.richTextBox4.Text != string.Empty)
                {
                    int p = richTextBox6.Text.Length;
                    richTextBox3.Select(linecu, p);
                    richTextBox3.SelectedText = richTextBox4.Text;
                }
            }
            else { MessageBox.Show("Please select the message line", "Forbidden line", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
        }
        private void button4_Click(object sender, EventArgs e)
        {
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (Form1.Con.Trim().ToLower() != "connected")
            {
                cl.Text = richTextBox1.Text;
                ml.Text = richTextBox3.Text;
                richTextBox1.SaveFile(@"Amarada", RichTextBoxStreamType.PlainText);
                richTextBox1.SaveFile(@"Amarada", RichTextBoxStreamType.PlainText);
                richTextBox3.SaveFile(@"Oraahda", RichTextBoxStreamType.PlainText);
                richTextBox3.SaveFile(@"Oraahda", RichTextBoxStreamType.PlainText);
                Nizzc_Collection.tags ShowMessage = new Nizzc_Collection.tags();
                ShowMessage.Message("Information", "All changes are saved", false, "Ok", "");
                ShowMessage.ShowDialog();
                Form1.ifch = "yes";
                this.Close();
            }
            else
            {
                Nizzc_Collection.tags ShowMessage = new Nizzc_Collection.tags();
                ShowMessage.Message("Saving Error", "Couldn't save changes while bot is connected.", false, "Ok", "");
                ShowMessage.ShowDialog();
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.LoadFile(@"Cbkup", RichTextBoxStreamType.PlainText);
                richTextBox3.LoadFile(@"Mbkup", RichTextBoxStreamType.PlainText);
            }
            catch
            {
                ShowMessage.Message("Loading file Error", "Some files are missing. Please try to reinstall.", false, "Ok", "");
                ShowMessage.ShowDialog();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (rich1 == richTextBox1.Text && rich3 == richTextBox3.Text)
            {
                Close();
            }
            else
            {
                Nizzc_Collection.tags show = new tags();
                show.Message("Confirmation", "There are unsaved changes made. Do you want to save?", true , "No", "Yes");
                show.ShowDialog();
                if (Nizzc_Mobile_Ser.Form1.YesNo == "yes")
                {
                    button10.PerformClick();
                }
                else
                {
                    Close();
                }
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
        }
        public void Add(string Onlines, string Alls)
        {
            string onn = Onlines;
            MessageBox.Show(onn);
        }
        string rich1 = "";
        string rich3 = "";
        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.LoadFile(@"Amarada", RichTextBoxStreamType.PlainText);
                richTextBox3.LoadFile(@"Oraahda", RichTextBoxStreamType.PlainText);
                rich1 = richTextBox1.Text;
                rich3 = richTextBox3.Text;
            }
            catch 
            {
                richTextBox1.Text = "THERE IS FATAL ERROR:\n\nThe application could not find the Command or Command Message file. The bot will not recognize any user command and will not send any respond.\n\nThis bot reads the current missing files to compare what is recieved and send the corresponding message.\n\nTo fix this error please do these:\n\nEither:\n1.Click 'RESET ALL' button and then 'save' button. \n\nOR\n\n2.Uninstall the application and reinstall it";
                richTextBox3.Text = "THERE IS FATAL ERROR:\n\nThe application could not find the Command or Command Message file. The bot will recognize any user command and will not send any respond.\n\nThis bot read the current missing files to compare what is recieved and send the corresponding message.\n\nTo fix this error please these:\n\nEither:\n1.Click 'RESET ALL' button and then 'save' button. \n\nOR\n\n2.Uninstall the application and reinstall it";
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void protectedlist_TextChanged(object sender, EventArgs e)
        {
        }
        private void button15_Click(object sender, EventArgs e)
        {
        }
        private void removebutton_Click(object sender, EventArgs e)
        {
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }
        string selected = "";
        string action = "";
        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Botmanager.Text);
        }
        private void groupBox6_Enter(object sender, EventArgs e)
        {
        }
        private void button16_Click_1(object sender, EventArgs e)
        {
        }
        private void disallowbutton_Click(object sender, EventArgs e)
        {
        }
        private void totalusers_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void onlineuser_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void allowbutton_Click(object sender, EventArgs e)
        {
        }
        private void button5_Click(object sender, EventArgs e)
        {
        }
        void Send(string This_Message, string iD)
        {
            x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(iD + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, This_Message));
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            selected = "forw";
        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            action = "add";
        }
        private void groupBox4_Enter(object sender, EventArgs e)
        {
        }
        private void CH_pro_CheckedChanged(object sender, EventArgs e)
        {
            selected = "pro";
        }
        private void CH_anti_flood_CheckedChanged(object sender, EventArgs e)
        {
            selected = "fld";
        }
        private void CH_dc_CheckedChanged(object sender, EventArgs e)
        {
            selected = "dx";
        }
        private void CH_childbots_CheckedChanged(object sender, EventArgs e)
        {
            selected = "bot";
        }
        private void CH_roombot_CheckedChanged(object sender, EventArgs e)
        {
            selected = "room";
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            switch (selected.Trim())
            {
                case "":
                    {
                        break;
                    }
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void CH_discon_CheckedChanged(object sender, EventArgs e)
        {
            action = "discontinue";
           // textBox2.Enabled =true;
        }
        private void CH_send_CheckedChanged(object sender, EventArgs e)
        {
            action = "send";
          //  textBox2.Enabled = true;
        }
        private void CH_restart_CheckedChanged(object sender, EventArgs e)
        {
            action = "restart";
           // textBox2.Enabled =true;
        }
    }
}
