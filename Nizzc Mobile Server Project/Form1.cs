using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.Mail;
//
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel;
using System.Windows.Forms.VisualStyles;
using System.Xml;
using System.Xml.Serialization.Advanced;
using agsXMPP;
using agsXMPP.Collections;
using agsXMPP.exceptions;
using agsXMPP.protocol.client;
using agsXMPP.protocol.extensions.html;
using agsXMPP.protocol.iq.roster;
//
using agsXMPP.protocol.x.muc;
using agsXMPP.util;
using agsXMPP.Xml.Dom;
using AxWMPLib;
using Nizzc_Collection;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
//
using Nizzc_Mobile_Ser;
using SHDocVw;
using Nizzc_Mobile_Server;
using System.Diagnostics;
using System.Runtime.InteropServices;
namespace Nizzc_Mobile_Ser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            aboot.Text = abooot.Text;
            ChildBotCommands = childbotcommands.Text;
            ChildBotEng.Text = childbotEng.Text;
        }
        public static TextBox ChildBotEng = new TextBox();
            int CurrentVersion = 8;
        public static string StopRead = "";
        public static  string YesNo;
        public static string Con = "";
        public static RichTextBox addlist = new RichTextBox();
        public static string ChildBotCommands = "";
        private string id, pass, send;
        bool isHoster = false;
        public static int childbotcount;
        public static int hostedbotcount;
        public static int dccount;
        public static int transfereduserscount;
        public static int protectedcount;
        public static int mta;
        public static int rom;
        public static int romopt;
        public static int optim;
        public static string onlinetime;
        public static int fow;
        public static int childcounts;
        public static string ifch;
        public static string lockteller;
        public static string lockingopt = "0000:off";
        public static RichTextBox invlidw = new RichTextBox();
        public static RichTextBox Terminator = new RichTextBox();
        public static string mainbotID = "";
        public static RichTextBox childbotlist = new RichTextBox();
        public static RichTextBox RoomBotlist = new RichTextBox();
        public static RichTextBox DcIdList = new RichTextBox();
        public static RichTextBox ForwarderList = new RichTextBox();
        public static RichTextBox DataDownloader = new RichTextBox();
        //tags-----------------------------------------
        public static RichTextBox Acc = new RichTextBox();
       public static RichTextBox redlist = new RichTextBox();
        public static TextBox admintag = new TextBox();
        public static TextBox addlisttag = new TextBox();
        public static TextBox statustag = new TextBox();
        public static TextBox helptag = new TextBox();
        public static TextBox hostedbotstag = new TextBox();
        public static TextBox abouttag = new TextBox();
        public static TextBox protectedacctag = new TextBox();
        public static TextBox usertag = new TextBox();
        public static TextBox SMPtag = new TextBox();
        public static TextBox resourcetag = new TextBox();
        public static TextBox onlinetimetag = new TextBox();
        public static TextBox lasthostedbottag = new TextBox();
        public static TextBox thisid = new TextBox();
        public static TextBox thisbot = new TextBox();
        public static TextBox antiadduser = new TextBox();
        public static TextBox antiaddpass = new TextBox();
        public static TextBox antiaddres = new TextBox();
        public static RichTextBox Commandlist = new RichTextBox();
        public static RichTextBox Commandmsglist = new RichTextBox();
        public static RichTextBox Eng = new RichTextBox();
        public static TextBox sender2 = new TextBox();
        public static string hostage;
        bool ishostee = false;
        bool ishoster = false;
        //----------------------------------------------
        public static TextBox help = new TextBox();
        public static TextBox about = new TextBox();
        public static TextBox admins = new TextBox();
        public string[] c1;
        public static  string stopp;
        public static string iD="";
        public static string pAssWoRd="";
        string len = "50";
        public static ListBox alladd = new ListBox();
        public static ListBox  onlineadd1 = new ListBox ();
        enum MyAffiliation
        {
            owner = 0,
            admin = 1,
            none = 2
        }
        string OnBeing = "online";
        internal static XmppClientConnection x = new XmppClientConnection();
       public static XmppClientConnection f1 = x;
        Random rand = new Random();
        public static string OnEye = "";
        private string[] a;
        Random randomize = new Random();
        bool IsOnNet = false;
        private void button1_Click(object sender, EventArgs e)
            {
            mainbotID = textBox1.Text;
            Thread thra = new Thread(() =>
            {
                bool conn = NetworkInterface.GetIsNetworkAvailable();
                if (conn == false)
                {
                    if (NetFreeCheckBox.Checked == true)
                    {
                        Nizzc_Collection.tags ShowMessage = new Nizzc_Collection.tags();
                        ShowMessage.StartPosition = FormStartPosition.CenterParent;
                        ShowMessage.Message("Network Error", "Couldn't connect to '" + IP + "'. Please check your network connection.", false, "Ok", "");
                          ShowMessage.ShowDialog();
                    }
                    else
                    {
                        Nizzc_Collection.tags ShowMessage = new Nizzc_Collection.tags();
                        ShowMessage.Message("Network Error", "Please check your internet connection.", false, "Ok", "");
                        ShowMessage.ShowDialog();
                    }
                }
                else if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty)
                {
                    Nizzc_Collection.tags ShowMessage = new Nizzc_Collection.tags();
                    ShowMessage.Message("Required Information", "Username, Password or Resource box is empty", false, "Ok", "");
                    ShowMessage.ShowDialog();
                }
                else
                {
                    try
                    {
                        button1.Enabled = false;
                        button2.Enabled = true;
                        checkBox1.Checked = true;
                        checkBox2.Checked = true;
                        NetFreeCheckBox.Enabled = false;
                        if (NetFreeCheckBox.Checked == true)
                        {
                            Thread throe = new Thread(() =>
                            {
                                button1.Text = "Please wait...";
                                if (FreeConnect())
                                {
                                    try
                                    {
                                        button1.Text = "Connecting...";
                                        Thread thre = new Thread(() =>
                                        {
                                            try
                                            {
                                                x.Server = "nimbuzz.com";
                                                x.ConnectServer = "o.nimbuzz.com";
                                                x.Open(textBox1.Text, textBox2.Text, textBox3.Text, 50);
                                                x.Status = sts.Text;
                                                x.OnAuthError += new XmppElementHandler(this.OnFailed);
                                                x.OnLogin += new ObjectHandler(this.connected);
                                                x.OnClose += new ObjectHandler(this.OnDis);
                                                x.OnMessage += new MessageHandler(OnMessage);
                                                x.OnPresence += new agsXMPP.protocol.client.PresenceHandler(onlineadd);
                                                x.OnPresence += new PresenceHandler(WhilePren);
                                                x.OnReadXml += new XmlHandler(OnXML);
                                                x.OnMessage += new MessageHandler(Admin_OnMessage);
                                                IsOnNet = true;
                                            }
                                            catch { }
                                        }); thre.IsBackground = true; thre.Start();
                                    }
                                    catch (Exception v)
                                    {
                                        messg.BackColor = Color.Orange;
                                        ErrorLable.Text = "Sorry, unexpected error has occured. Please try again.";
                                        Con = "";
                                        iD = "";
                                        pAssWoRd = "";
                                        button1.Enabled = true;
                                        button2.Enabled = false;
                                        timer4.Enabled = true;
                                        button1.Text = "connect";
                                        timer4.Stop();
                                        timer4.Start();
                                        NetFreeCheckBox.Enabled = true;
                                        button1.Text = "Connect";
                                    }
                                }
                                else
                                {
                                    NetFreeCheckBox.Enabled = true;
                                    timer4.Enabled = true;
                                    Con = "";
                                    iD = "";
                                    pAssWoRd = "";
                                    button1.Enabled = true;
                                    button2.Enabled = false;
                                    timer4.Enabled = true;
                                    button1.Text = "connect";
                                    timer4.Stop();
                                    timer4.Start();
                                    ErrorLable.BackColor = Color.PaleVioletRed;
                                    ErrorLable.Text = "Sorry, Our network is not available in your region!";
                                }
                            }); throe.IsBackground = true; throe.Start();
                        }
                        else
                        {
                            Thread thre = new Thread(() =>
                            {
                                try
                                {
                                    NetFreeCheckBox.Enabled = false;
                                    button1.Text = "Connecting...";
                                    x.Server = "nimbuzz.com";
                                    x.ConnectServer = "o.nimbuzz.com";
                                    x.Open(this.textBox1.Text, this.textBox2.Text, textBox3.Text, 50);
                                    x.Status = sts.Text;
                                    x.OnAuthError += new XmppElementHandler(this.OnFailed);
                                    x.OnLogin += new ObjectHandler(this.connected);
                                    x.OnClose += new ObjectHandler(this.OnDis);
                                    x.OnMessage += new MessageHandler(OnMessage);
                                    x.OnPresence += new agsXMPP.protocol.client.PresenceHandler(onlineadd);
                                    x.OnPresence += new PresenceHandler(WhilePren);
                                    x.OnReadXml += new XmlHandler(OnXML);
                                    x.OnMessage += new MessageHandler(Admin_OnMessage);
                                    IsOnNet = false;
                                }
                                catch { }
                            }); thre.IsBackground = true; thre.Start();
                        }
                    }
                    catch (Exception g)
                    {
                    }
                }
            }); thra.IsBackground = true;
            thra.Start();
        }
        long ThisCode = 0;
        private void connected(object sender)
        {
            if (base.InvokeRequired)
            {
                base.BeginInvoke(new ObjectHandler(this.connected), new object[] { sender });
            }
            else
            {
                Con = "connected";
                button1.Enabled = false;
                button2.Enabled = true;
                ErrorLable.Text = "Connected!";
                if (IsOnNet)
                {
                    Thread thrpe = new Thread(() =>
                    {
                        try
                        {
                            ErrorLable.Text = "Please wait while data is being transmitted...";
                            button1.Text = "Awaiting...";
                            if (UpFTP())
                            {
                                string mybot = "";
                                if (mybot.Trim() != string.Empty)
                                {
                                    button1.Text = "Connect";
                                    ErrorLable.Text = "Please verify your bot.";
                                    NetworkComfirmer cn = new NetworkComfirmer();
                                    try
                                    {
                                        NetworkComfirmer.Ccode = ThisCode;
                                        NetworkComfirmer.StrMsg = "Please add " + mybot + "@nimbuzz.com to your account and send to it VERIFY#" + ThisCode + "\nOnce you confirm your Nbot, it will come online and you can exit this application. To update your bot anytime, click 'My Bot > Update' under main menu.";
                                        NetworkComfirmer.Bot = mybot;
                                    }
                                    catch { }
                                    checkBox1.Checked = false;
                                    try
                                    {
                                        x.Close();
                                    }
                                    catch { }
                                    button1.Text = "Hosted";
                                    button2.Enabled = false;
                                    cn.ShowDialog();
                                }
                                else
                                {
                                    checkBox1.Checked = false;
                                    x.Close();
                                    button1.Text = "Failed";
                                    ErrorLable.Text = "Error occured! Please retry.";
                                }
                            }
                        }
                        catch (Exception v){
                        }
                    }); thrpe.IsBackground = true; thrpe.Start();
                }
                    this.textBox1.BackColor = Color.Green;
                    this.textBox2.BackColor = Color.Green;
                    this.textBox3.BackColor = Color.Green;
                    this.textBox1.Enabled = false;
                    this.textBox2.Enabled = false;
                    this.textBox2.Enabled = false;
                    timer4.Start();
                    iD = textBox1.Text;
                    pAssWoRd = textBox2.Text;
                    button1.Text = "Connected";
                    onlinetime = DateTime.Now.ToString();
                    if (File.Exists(@"yes"))
                    {
                        try
                        {
                            Hide();
                        }
                        catch { }
                    }
            }
        }
        private void OnDis(object sender)
        {
            if (base.InvokeRequired)
            {
                base.BeginInvoke(new ObjectHandler(this.OnDis), new object[] { sender });
            }
            else
            {
                Thread thrg = new Thread(() =>
                {
                    try
                    {
                        if (!IsOnNet)
                        {
                            Con = "";
                            button1.Enabled = true;
                            button2.Enabled = false;
                            button1.Text = "Connect";
                            this.textBox1.BackColor = Color.Red;
                            this.textBox2.BackColor = Color.Red;
                            this.textBox3.BackColor = Color.Red;
                        }
                        if (checkBox1.Checked == true)
                        {
                            button1.Enabled = false;
                            button2.Enabled = true;
                            x.Server = "nimbuzz.com";
                            x.ConnectServer = "o.nimbuzz.com";
                            x.Open(this.textBox1.Text, this.textBox2.Text, textBox3.Text, 50);
                            x.Status = sts.Text;
                            button1.Text = "Connecting...";
                        }
                    }
                    catch { }
                }); thrg.IsBackground = true; thrg.Start();
            }
        }
        private void OnFailed(object sender, Element e)
        {
            if (base.InvokeRequired)
            {
                base.BeginInvoke(new XmppElementHandler(this.OnFailed), new object[] { sender, e });
            }
            else
            {
                try
                {
                    NetFreeCheckBox.Enabled = true;
                    Con = "";
                    iD = "";
                    pAssWoRd = "";
                    textBox1.BackColor = Color.Red;
                    textBox3.BackColor = Color.Red;
                    this.textBox1.Enabled = true;
                    this.textBox2.Enabled = true;
                    this.textBox3.Enabled = true;
                    textBox2.BackColor = Color.Red;
                    ErrorLable.Text = "Invalid credentials - Check username/password";
                    button1.Text = "Not Connected";
                    IsOnNet = false;
                }
                catch { }
            }
        }
        private void OnMessage(object sender, agsXMPP.protocol.client.Message NewMessage)
        {
                if (base.InvokeRequired)
                {
                    base.BeginInvoke(new MessageHandler(this.OnMessage), new object[] { RuntimeHelpers.GetObjectValue(sender), NewMessage });
                }
                else
                {
                    Thread thrd = new Thread(() =>
                    {
                        try
                        {
                            if (NewMessage.Type == MessageType.error || NewMessage.Body.Trim() == string.Empty)
                                return;
                            else
                            if (NewMessage.Type == MessageType.chat)
                            {
                                string[] c = commandlist.Lines.ToArray();
                                string[] mc =  System.IO.File.ReadAllLines(@"Oraahda");
                                if (NewMessage.Body.ToLower().Trim() == (c[1].Replace("[", "").Replace("]", "").Trim().ToLower())) 
                                    {
                                        try
                                        {
                                            x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, eng.Text.Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", master.Text.Replace("#", "\n").Replace("%user%", NewMessage.From.User))));
                                            return;
                                        }
                                        catch { }
                                    }
                                if (NewMessage.Body.Trim().ToLower() == "protection" || NewMessage.Body.Trim().ToLower() == "protections")
                                {
                                    if (!checkBox3.Checked)
                                        return;
                                    else
                                        Send(NewMessage.From.User, hlp.Text.Split('|').ElementAt(0), "");
                                }
                                if (NewMessage.Body.Trim().ToLower() == "assistance" || NewMessage.Body.Trim().ToLower() == "assistances")
                                {
                                    if (!checkBox3.Checked)
                                        return;
                                    else
                                    Send(NewMessage.From.User, hlp.Text.Split('|').ElementAt(1), "");
                                }
                                if (NewMessage.Body.Trim().ToLower() == "bots" || NewMessage.Body.Trim().ToLower() == "bot")
                                {
                                    if (!checkBox3.Checked)
                                        return;
                                    else
                                    Send(NewMessage.From.User, hlp.Text.Split('|').ElementAt(2), "");
                                }
                                if (NewMessage.Body.Trim().ToLower() == "others" || NewMessage.Body.Trim().ToLower() == "other")
                                {
                                    if (!checkBox3.Checked)
                                        return;
                                    else
                                    Send(NewMessage.From.User, hlp.Text.Split('|').ElementAt(3), "");
                                }
                                try
                                {
                                    //info
                                    if (NewMessage.Body.ToLower().Trim() == c[9].Replace("[", "").Replace("]", ""))
                                    {
                                        string info = "\nRoomBot: " + rom + "\nScanned: " + protectedcount + "\nDC Protection: " + dccount + "\nForwarded: " + fow + "\nChildbots: " + childcounts + "\nMTA: " + mta + "\nOnline Users: " + listBox1.Items.Count + "\nOptimized: " + optim + "\nTotal transfered users: " + transfereduserscount + "\nQuiz Questions: " + File.ReadAllLines(@"/"/*Specify the quiz directory*/).Count() + "\n\nWe never save user passwords!";
                                        x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, info));
                                    }
                                }
                                catch { }
                                if (NewMessage.Body.ToLower().StartsWith(c[14].Replace("[", "").Replace("]", "")))
                                {
                                    string[] sp = NewMessage.Body.Split('#');
                                    try
                                    {
                                        Jid thisjid = new Jid(sp[1] + "@nimbuzz.com");
                                        x.RosterManager.AddRosterItem(thisjid);
                                        PresenceManager prs = new PresenceManager(x);
                                        prs.Subscribe(thisjid);
                                        Send(NewMessage.From.User, "Thank you for sharing.", "");
                                    }
                                    catch { }
                                }
                                //Contact
                                if (NewMessage.Body.ToLower().StartsWith(c[8].Replace("[", "").Replace("]", "")))
                                {
                                    string[] sp = NewMessage.Body.Split('#');
                                    try
                                    {
                                        if (master.Text.Trim() != string.Empty)
                                        {
                                            if (master.Text.Contains("#"))
                                            {
                                                string[] sp1 = master.Text.Split('#');
                                                Send(sp1[0], "New Message from: " + NewMessage.From.User + "@nimbuzz.com" + "\nTime: " + DateTime.Now.ToString() + "\nMessage:\n--\n" + sp[1] + "\n--\nTo reply user 'chat/" + NewMessage.From.User + "/message'", "");
                                                Send(NewMessage.From.User, "Message is sent to bot owner", "");
                                            }
                                            else
                                            {
                                                Send(master.Text, "New Message from: " + NewMessage.From.User + "@nimbuzz.com" + "\nTime: " + DateTime.Now.ToString() + "\nMessage:\n--\n" + sp[1] + "\n--\nTo reply user 'chat/" + NewMessage.From.User + "/message'", "");
                                                Send(NewMessage.From.User, "Message is sent to bot owner", "");
                                            }
                                        }
                                        else
                                        {
                                            Send(NewMessage.From.User, "No master/admin pointed for this bot.\nPlease contact 'team@nizzc.com' instead.", "");
                                        }
                                    }
                                    catch
                                    {
                                        x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[20].Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", master.Text.Replace("#", "\n")).Replace("[MESSAGE]$", "")));
                                    }
                                }
                                //Optimization
                                if (NewMessage.Body.ToLower().StartsWith(c[12].Replace("[", "").Replace("]", "")))
                                {//optimize#id#pass
                                    string[] sp = NewMessage.Body.Split('#');
                                    try
                                    {
                                        if (OptimizerBot)
                                        {
                                            Optimizer optimizer = new Optimizer();
                                            optimizer.Login(sp[1], sp[2], "IntelPad_Microsoft", NewMessage.From.User, "delete", x, commandmsglist);
                                            x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[19].Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", master.Text.Replace("#", "\n")).Replace("[MESSAGE]$", "")));
                                            optim++;
                                        }
                                        else
                                        {
                                            x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[91].Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", master.Text.Replace("#", "\n")).Replace("[MESSAGE]$", "")));
                                        }
                                    }
                                    catch
                                    {
                                        x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[20].Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", master.Text.Replace("#", "\n")).Replace("[MESSAGE]$", "")));
                                    }
                                }
                                //Stop
                                //forw
                                if (NewMessage.Body.ToLower().StartsWith(c[4].Replace("[", "").Replace("]", "")))
                                {
                                    string[] sp = NewMessage.Body.Split('#');
                                    try
                                    {
                                        if (ForwarderBot)
                                        {
                                            if (NewMessage.From.User.ToLower() != sp[1].Trim().ToLower())
                                            {
                                                Fhelp = forwadercpanle.Text;
                                                Nizzc_Collection.forwarder foraw = new Nizzc_Collection.forwarder();
                                                foraw.Login(sp[1], sp[2], sp[3], NewMessage.From.User, x, commandmsglist);
                                                x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[19].Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", master.Text.Replace("#", "\n")).Replace("[MESSAGE]$", "")));
                                                fow++;
                                            }
                                            else
                                            {
                                                Send(NewMessage.From.User, "You can't forward yourself to yourself!", "");
                                            }
                                        }
                                        else
                                        {
                                            x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[91].Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", master.Text.Replace("#", "\n")).Replace("[MESSAGE]$", "")));
                                        }
                                    }
                                    catch { }
                                }
                                //Add-List Transfer
                                if (NewMessage.Body.ToLower().StartsWith(c[10].Replace("[", "").Replace("]", "")) && NewMessage.Body.ToLower().Contains(":"))
                                {
                                    if (RoomFullerBot)
                                    {
                                        try
                                        {
                                            string[] sp = NewMessage.Body.Split(':');
                                            string[] id1 = sp[0].Split('#');
                                            string[] id2 = sp[1].Split('#');
                                            Addlist_Transfer trans = new Addlist_Transfer();
                                            trans.Login(id1[1], id1[2], NewMessage.From.User, id2[0], id2[1], x);
                                            x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[19].Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", master.Text.Replace("#", "\n")).Replace("[MESSAGE]$", "")));
                                        }
                                        catch { }
                                    }
                                    else
                                    {
                                        x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[91].Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", master.Text.Replace("#", "\n")).Replace("[MESSAGE]$", "")));
                                    }
                                }
                                //childbot cr#
                                if (NewMessage.Body.ToLower().StartsWith("crt#"))
                                {
                                    try
                                    {
                                        if (ChildBot)
                                        {
                                            string[] sp = NewMessage.Body.Split('#');
                                            Nizzc_Collection.childbot ch = new Nizzc_Collection.childbot();
                                            ch.Login(sp[1], sp[2], sp[3], NewMessage.From.User, x, commandlist, commandmsglist, eng.Text,hlp2);
                                            x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[19].Replace("[MESSAGE]$", "").Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", master.Text.Replace("#", "\n"))));
                                            childcounts++;
                                        }
                                        else
                                        {
                                            x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[91].Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", master.Text.Replace("#", "\n")).Replace("[MESSAGE]$", "")));
                                        }
                                    }
                                    catch { }
                                }
                                //room
                                if (NewMessage.Body.ToLower().Trim().StartsWith(c[2].Replace("[", "").Replace("]", "")))
                                {
                                    string[] sp = NewMessage.Body.Split('#');
                                    Thread thref = new Thread(() =>
                                    {
                                        try
                                        {
                                            if (RoomBot)
                                            {
                                                RM rm = new RM();
                                                rm.Login(sp[1], sp[2], "IntelPad_Microsoft", NewMessage.From.User, sp[3], x, commandmsglist, "", false, true);
                                                x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[19].Replace("[MESSAGE]$", "").Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", master.Text.Replace("#", "\n"))));
                                                rom++;
                                            }
                                            else
                                            {
                                                x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[91].Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", master.Text.Replace("#", "\n")).Replace("[MESSAGE]$", "")));
                                            }
                                        }
                                        catch (Exception v)
                                        {
                                            x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, "Command syntax error!"));
                                        }
                                    }); thref.IsBackground = true; thref.Start();
                                }
                                if (NewMessage.Body.ToLower().StartsWith(c[3].Replace("[", "").Replace("]", "")))
                                {
                                    string[] sp = NewMessage.Body.Split('#');
                                    Thread thref = new Thread(() =>
                                    {
                                        try
                                        {
                                            if (RoomBot)
                                            {
                                                RM rm = new RM();
                                                rm.Login(sp[1], sp[2], "IntelPad_Microsoft", NewMessage.From.User, sp[3], x, commandmsglist, sp[4], true, true);
                                                x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[19].Replace("[MESSAGE]$", "").Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", master.Text.Replace("#", "\n"))));
                                                rom++;
                                            }
                                            else
                                            {
                                                x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[91].Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", master.Text.Replace("#", "\n")).Replace("[MESSAGE]$", "")));
                                            }
                                        }
                                        catch (Exception v)
                                        {
                                            x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, "Command syntax error!"));
                                        }
                                    }); thref.IsBackground = true; thref.Start();
                                }
                                //about
                                if (Strings.InStr(NewMessage.Body.ToLower().Trim(), c[5].Replace("[", "").Replace("]", ""), CompareMethod.Text) != 0)
                                {
                                    try
                                    {
                                        x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, abooot.Text.Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", master.Text.Replace("#", "\n").Replace("#", "\n").Replace("#", "\n"))));
                                        return;
                                    }
                                    catch { }
                                }
                                //Dc Terminator
                                if (NewMessage.Body.ToLower().StartsWith(c[11].Replace("[", "").Replace("]", "")))
                                {
                                    try
                                    {
                                        string[] sp1 = NewMessage.Body.Split('#');
                                        DCTerminator Terminate = new DCTerminator();
                                        if (Terminate.Terminator(NewMessage.From.User, sp1[1].Trim()) == "done")
                                        {
                                            Send(NewMessage.From.User, "", "");
                                            StopRead = sp1[1];
                                        }
                                        else
                                        {
                                            Send(NewMessage.From.User, "We can't find such protectee.\nPlease make sure that you protected " + sp1[1] + " with '" + NewMessage.From.User + "' on this computer", "");
                                        }
                                    }
                                    catch { }
                                }
                                //S2a
                                if (NewMessage.Body.ToLower().StartsWith(c[13].Replace("[", "").Replace("]", "")))
                                {
                                    if (mta1)
                                    {
                                        try
                                        {
                                            string body = NewMessage.Body;
                                            MTA connecting = new MTA();
                                            string[] spArray = body.Substring(body.IndexOf("#") + 1).Split(new char[] { '#' });
                                            connecting.Login(spArray[0], spArray[1], spArray[2], "Message To All", spArray[3], NewMessage.From.User, x, commandmsglist);
                                            x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[17].Replace("[MESSAGE]$", "").Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", master.Text.Replace("#", "\n").Replace("#", "\n"))));
                                            mta++;
                                        }
                                        catch { }
                                        return;
                                    }
                                    else
                                    {
                                        x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[91].Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", master.Text.Replace("#", "\n")).Replace("[MESSAGE]$", "")));
                                    }
                                }
                            }
                        }
                        catch (Exception v)
                        {
                        }
                    }); thrd.IsBackground = true; thrd.Start();
                }
                return;
        }
        private void onlineadd(object sender, agsXMPP.protocol.client.Presence pres)
        {
            if (base.InvokeRequired == true)
            {
                base.BeginInvoke(new agsXMPP.protocol.client.PresenceHandler(onlineadd), new object[] { sender, pres });
            }
            else
            {
                Thread threk = new Thread(() =>
                {
                    try
                    {
                        if (pres.Type == PresenceType.available)
                        {
                            if (listBox1.Items.Contains(pres.From.Bare))
                            {
                            }
                            else
                            {
                                listBox1.Items.Add(pres.From.Bare);
                            }
                        }
                        else
                        {
                            listBox1.Items.Remove(pres.From.Bare);
                        }
                        if (pres.Type == PresenceType.unsubscribed || pres.Type == PresenceType.unsubscribe)
                        {
                            if (pres.Type == PresenceType.unavailable)
                            {
                                listBox1.Items.Remove(pres.From.Bare);
                            }
                            listBox2.Items.Remove(pres.From.Bare);
                        }
                        if (pres.Type == PresenceType.subscribe || pres.Type == PresenceType.subscribed)
                        {
                            if (!listBox2.Items.Contains(pres.From.Bare))
                            {
                                listBox2.Items.Add(pres.From.Bare);
                            }
                            else
                            {
                            }
                        }
                    }
                    catch { }
                }); threk.IsBackground = true; threk.Start();
            }
        }
        private void OnXML(object sender, string xml)
        {
            if (base.InvokeRequired)
            {
                base.BeginInvoke(new XmlHandler(this.OnXML), new object[] { RuntimeHelpers.GetObjectValue(sender), xml });
            }
            else
            {
                Thread threb = new Thread(()=>{
                try
                {
                    xml = Strings.Replace(xml, "\"", "'", 1, -1, CompareMethod.Text);
                    if (((Strings.InStr(xml, "<query xmlns='jabber:iq:roster'>", CompareMethod.Binary) != 0)))
                    {
                        this.a = xml.Split(new char[] { '<' });
                        int num4 = Information.UBound(this.a, 1);
                        for (int j = Information.LBound(this.a, 1); j <= num4; j++)
                        {
                            if ((Strings.InStr(this.a[j], "'both'", CompareMethod.Binary) != 0))
                            {
                                string add;
                                add = a[j].Substring(a[j].IndexOf("jid='") + 5);
                                add = add.Substring(0, add.IndexOf("'") - 0);
                                listBox2.Items.Add(add);
                                alladd.Items.Add(add);
                            }
                        }
                    }
                }
                catch { }
                }); threb.IsBackground = true; threb.Start();
            }
        }
        private void WhilePren(object sender, Presence FrPren)
        {
            if (InvokeRequired)
                BeginInvoke(new agsXMPP.protocol.client.PresenceHandler(WhilePren), new object[] { sender, FrPren });
            else
            {
                Thread threb = new Thread(() =>
                {
                    try
                    {
                        if (FrPren.Type == agsXMPP.protocol.client.PresenceType.subscribe)
                        {
                            string[] mc = System.IO.File.ReadAllLines(@"Oraahda");
                            x.Send("<presence to=\"" + FrPren.From + "\" type=\"subscribed\" />" +
                                "<presence to=\"" + FrPren.From + "\" type=\"subscribe\" />");
                            x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(FrPren.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[26].Replace("%from%", FrPren.From.User).Replace("[MESSAGE]$", "").Replace("%L%", Environment.NewLine).Replace("%user%",FrPren.From.User)));
                        }
                    }
                    catch { }
                }); threb.IsBackground = true; threb.Start();
            }
        }
        private void WhileIq(object sender, IQ OnIq)
        {
            Thread thres = new Thread(()=>{
                try
                {
                    if (OnIq.Query != null)
                    {
                        if (OnIq.Query.GetType() == typeof(agsXMPP.protocol.iq.version.Version))
                        {
                            agsXMPP.protocol.iq.version.Version vers = (agsXMPP.protocol.iq.version.Version)OnIq.Query;
                            agsXMPP.protocol.iq.time.Time time = (agsXMPP.protocol.iq.time.Time)OnIq.Query;
                            if (OnIq.Type == agsXMPP.protocol.client.IqType.get)
                            {
                                OnIq.SwitchDirection();
                                OnIq.Type = agsXMPP.protocol.client.IqType.result;
                                vers.Name = "Nizzc Mobile Server";
                                vers.Ver = "6.5";
                                //time.Value = System.DateTime.Today.ToString();
                                vers.Os = "Service Pack: " + System.Environment.OSVersion.ServicePack + "\nPlatform : " + System.Environment.OSVersion.Platform + "\nVersion: " + System.Environment.OSVersion.Version.Major;
                                // vers.Os = Environment.OSVersion.ToString();
                                x.Send(OnIq);
                            }
                        }
                    }
                }
                catch { }
            }); thres.IsBackground = true; thres.Start();
        }
        //
        //Finder
        void Finder(string IDPlus, RichTextBox  control,string user,string thisid)
        {
            Thread threj = new Thread(()=>{
                try
                {
                    string[] mc = System.IO.File.ReadAllLines(@"Oraahda");
                    string result = "";
                    string[] from = IDPlus.Split(':');
                    foreach (string l in control.Lines)
                    {
                        if (l.ToLower() == IDPlus.ToLower())
                        {
                            StopRead = IDPlus;
                            result = "found";
                        }
                    }
                    if (result == "found")
                    {
                        x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(user + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[89].Replace("[MESSAGE]$", "").Replace("%L%", Environment.NewLine).Replace("%from%", user).Replace("%msg%", "[No Message]").Replace("%to%", "[No Message]").Replace("%masters%", master.Text.Replace("#", "\n").Replace("%thisid%", from[1]))));
                        remover(IDPlus, DcIdList);
                    }
                    else
                    {
                        x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(user + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[90].Replace("[MESSAGE]$", "").Replace("%L%", Environment.NewLine).Replace("%from%", user).Replace("%msg%", "[No Message]").Replace("%to%", "[No Message]").Replace("%masters%", master.Text.Replace("#", "\n").Replace("%thisid%", from[1]))));
                    }
                }
                catch { }
            }); threj.IsBackground = true; threj.Start();
        }
        bool VerifyIt(long code)
        {
            bool isOk = false;
            try
            {
                WebClient ftp = new WebClient();
                ftp.Credentials = new NetworkCredential(IpUser, IpPassword);
                ftp.DownloadFile(IP + "/Verify/" + code.ToString(), @code.ToString());
                isOk = true;
            }
            catch { }  
            return isOk;
        }
        //Remver 
        void remover(string info, RichTextBox control)
        {
            RichTextBox addup = new RichTextBox();
            foreach (string l in control.Lines)
            {
                if (l.ToLower() != info.ToLower())
                {
                    addup.Text += l + "\n";
                }
            }
            DcIdList.Text = addup.Text;
            return;
        }
        //Admin Contact
        void pm(string MeS, string from)
        {
            Thread threc = new Thread(()=>{
                try{
            if (master.Text.Trim() != string.Empty)
            {
                string[] sp = master.Text.Split('#');
                string[] mc = System.IO.File.ReadAllLines(@"Oraahda");
                x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(sp[0] + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, "Message from: " + from + "@nimbuzz.com\n------\n\n" + MeS + "\n\nTo reply use 'reply#" + from + "#Your Message"));
                x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(from + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[84].Replace("%L%", Environment.NewLine).Replace("%from%", from).Replace("%msg%", MeS).Replace("%to%", sp[0]).Replace("%masters%", master.Text.Replace("#", "\n")).Replace("[MESSAGE]$", "")));
            }
            else
            {
                string[] mc = System.IO.File.ReadAllLines(@"Oraahda");
                x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(from + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[85].Replace("%L%", Environment.NewLine).Replace("%from%", from).Replace("%msg%", MeS).Replace("%to%", "[To unknown]").Replace("%masters%", master.Text.Replace("#", "\n")).Replace("[MESSAGE]$", "")));
            }
                }catch{}
            }); threc.IsBackground = true; threc.Start();
        }
        bool IsMaster(string UUuser)
        {
            bool IsOk=false;
            if (master.Text.ToLower().Trim().Contains("#"))
            {
                string[] sp = master.Text.Split('#');
                for (int i = 0; i < sp.Count(); i++)
                {
                    if (UUuser.Trim().Trim().ToLower() == sp[i])
                    {
                        IsOk = true;
                    }
                }
            }
            else
            {
                if (master.Text.Trim().ToLower() == UUuser.ToLower().Trim())
                {
                    IsOk = true;
                }
            }
            return IsOk;
        }
        private void Admin_OnMessage(object sender, agsXMPP.protocol.client.Message NewMessage)
        {
                if (base.InvokeRequired)
                {
                    base.BeginInvoke(new MessageHandler(this.Admin_OnMessage), new object[] { sender, NewMessage });
                }
                else
                {
                        try
                        {
                            if (NewMessage.Body == null || NewMessage.From == null || NewMessage.From.User == null)
                                return;
                                if (IsMaster(NewMessage.From.User))
                                {
                                    //cpanel
                                    if (NewMessage.Body.ToLower() == "#cpanel")
                                    {
                                        x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, adminhelp.Text));
                                    }
                                    string[] c = commandlist.Lines.ToArray();
                                    string[] mc =System.IO.File.ReadAllLines(@"Oraahda");
                                    //change help
                                    if (NewMessage.Body.StartsWith("h/"))
                                    {
                                        string sm1 = NewMessage.Body;
                                        string sm = sm1.Replace("/", "#").Replace("\\", "#").Replace("-", "#").Replace("[", "#").Replace("]", "#").Replace(" ", "#").Replace("+", "#").Replace("=", "#").Replace("*", "#").Replace("@", "#").Replace("^", "#").Replace(">", "#").Replace("~", "#").Replace("_", "#").Replace(",", "#").Replace(".", "#").Replace("?", "#").Replace("&", "#").Replace("%", "#").Replace("$", "#").Replace("!", "#").Replace("'", "#").Replace("<", "#").Replace(",", "#").Replace(";", "#").Replace(":", "#").Replace("|", "#").Replace("(", "#").Replace(")", "#").Replace("{", "#").Replace("}", "#").Replace("  ", "#");
                                        string[] sm2 = sm.Split('#');
                                        eng.Text = sm2[1];
                                        Send(NewMessage.From.User, "User help content is changed!\nSend "+c[1].Replace("[","").Replace("]","").ToUpper()+ " to see effects", "");
                                    }
                                    //Update
                                    if (NewMessage.Body.Trim().ToLower() == "#update")
                                    {
                                        if (File.Exists(@"yes"))
                                        {
                                            try
                                            {
                                                Send(NewMessage.From.User, "Please wait while updating...", "");
                                                WebClient cftp = new WebClient();
                                                cftp.Credentials = new NetworkCredential(IpUser, IpPassword);
                                                if (cftp.DownloadString(IP + "/Update/" + Directory.GetParent(@"Org").Name) != string.Empty)
                                                {
                                                    cftp.DownloadFile(IP + "/Update/" + Directory.GetParent(@"Org").Name, @"Loadit");
                                                    Send(NewMessage.From.User, "Your bot has been updated.", "");
                                                    RichTextBox ld = new RichTextBox();
                                                    ld.LoadFile(@"loadit", RichTextBoxStreamType.PlainText);
                                                    string[] arr = ld.Text.Split('|');
                                                    textBox1.Text = arr[0].Replace("<n>", Environment.NewLine);
                                                    textBox2.Text = "";
                                                    textBox3.Text = arr[2].Replace("<n>", Environment.NewLine);
                                                    sts.Text = arr[3].Replace("<n>", Environment.NewLine);
                                                    master.Text = arr[4].Replace("<n>", Environment.NewLine);
                                                    eng.Text = arr[5].Replace("<n>", Environment.NewLine);
                                                    commandlist.Text = arr[6];
                                                    commandmsglist.Text = arr[7];
                                                    string[] nz = arr[8].Split('.');
                                                    ChildBot = Convert.ToBoolean(nz[0]);
                                                    ProtectionBot = Convert.ToBoolean(nz[1]);
                                                    ForwarderBot = Convert.ToBoolean(nz[2]);
                                                    AntiDCBot = Convert.ToBoolean(nz[3]);
                                                    AntiFloodBot = Convert.ToBoolean(nz[4]);
                                                    RoomBot = Convert.ToBoolean(nz[5]);
                                                    RoomFullerBot = Convert.ToBoolean(nz[6]);
                                                    OptimizerBot = Convert.ToBoolean(nz[7]);
                                                    mta1 = Convert.ToBoolean(nz[8]);
                                                    ChildBot1.Checked = Convert.ToBoolean(nz[0]);
                                                    ProtectionBot1.Checked = Convert.ToBoolean(nz[1]);
                                                    ForwarderBot1.Checked = Convert.ToBoolean(nz[2]);
                                                    AntiDCBot1.Checked = Convert.ToBoolean(nz[3]);
                                                    AntiFloodBot1.Checked = Convert.ToBoolean(nz[4]);
                                                    RoomBot1.Checked = Convert.ToBoolean(nz[5]);
                                                    RoomFullerBot1.Checked = Convert.ToBoolean(nz[6]);
                                                    OptimizerBot1.Checked = Convert.ToBoolean(nz[7]);
                                                    MTA_Server.Checked = Convert.ToBoolean(nz[8]);
                                                    Send(NewMessage.From.User, "We gave you 2years of our time to give you this owesome Nbot!\nPlease can you give us 5minutes of your time to tell users and us what you think about our Nbot product on our forum(No registration is required).", "");
                                                }
                                                else
                                                {
                                                    Send(NewMessage.From.User, "Sorry, we couldn't find any update for this server. Please make sure that you have updated this server with its correct hosting code.\nIf this error persists, Please let us email via 'team@nizzc.com'", "");
                                                }
                                            }
                                            catch (Exception v)
                                            {
                                                Send(NewMessage.From.User, "Error occured while reading the information\nPlease retry.", "");
                                            }
                                        }
                                        else
                                        {
                                            Send(NewMessage.From.User, "Oops! It doesn't seem that this bot is running on any computer of Nizzc Incorp.\nIf this is error, Please consider to inform our team via team@nizzc.com", "");
                                        }
                                    }
                                    // bot enable ON
                                    if (NewMessage.Body.ToLower() == "cbot/on")
                                    {
                                    }
                                    //guess log in enable ON
                                    if (NewMessage.Body.ToLower() == "cp/on")
                                    {
                                    }
                                    //guess log in enable OFF
                                    if (NewMessage.Body.ToLower() == "cp/off")
                                    {
                                    }
                                    //delete remoter
                                    if (NewMessage.Body.ToLower().StartsWith("delm#"))
                                    {
                                        string listeds="";
                                        string[] ussp = NewMessage.Body.Split('#');
                                        if (ussp[1].ToLower().Trim() == master.Text.ToLower().Trim().Split('#').ElementAt(0))
                                            Send(NewMessage.From.User, "You can't delete bot owner!", "");
                                        else
                                        {
                                            bool isdelete = false;
                                            try
                                            {
                                                if (master.Text.Contains("#"))
                                                {
                                                    string[] sp = master.Text.Split('#');
                                                    for (int i = 0; i < sp.Count(); i++)
                                                    {
                                                        if (sp[i].Trim().ToLower() == ussp[1].Trim().ToLower())
                                                        {
                                                            isdelete = true;
                                                        }
                                                        else
                                                        {
                                                            listeds += sp[i] + "#";
                                                        }
                                                    }
                                                }
                                                if (isdelete)
                                                {
                                                    master.Text = listeds;
                                                    Send(NewMessage.From.User, "Master deleted!", "");
                                                }
                                                else
                                                {
                                                    Send(NewMessage.From.User, "No such master could find!", "");
                                                }
                                                }
                                            catch { }
                                        }
                                    }
                                    //AST connection
                                    if (NewMessage.Body.StartsWith("tr"))
                                    {
                                    }
                                    //remove user
                                    if (NewMessage.Body != null && NewMessage.Body.ToLower().StartsWith("delu#"))
                                    {
                                        try
                                        {
                                            string[] sp = NewMessage.Body.Split('#');
                                            //delete roster
                                            x.Send("<iq type=\"set\" id=\"qip_2483\"><query xmlns=\"jabber:iq:roster\"><item jid=\"" + (sp[1]) + "@nimbuzz.com\" subscription=\"remove\" /></query></iq>");
                                            x.Send("<message type='chat' to='" + NewMessage.From.User + "@nimbuzz.com' id='ltmsg'><body>" + NewMessage.From.User + "@nimbuzz.com\nUser has been removed!</body></message>");
                                        }
                                        catch { }
                                    }
                                    //add remoter
                                    if (NewMessage.Body.ToLower().StartsWith("addm#"))
                                    {
                                        try
                                        {
                                            string[] sp1 = NewMessage.Body.Split('#');
                                            if (!master.Text.ToLower().Contains(sp1[1].ToLower()))
                                            {
                                                if (master.Text.EndsWith("#"))
                                                {
                                                    master.Text += (sp1[1] + "#");
                                                }
                                                else
                                                {
                                                    master.Text += ("#" + sp1[1] + "#");
                                                }
                                                x.Send("<message to=\"" + NewMessage.From + "\" type=\"chat\"><body>New bot administrator is added.</body></message>");
                                            }
                                            else
                                            {
                                                x.Send("<message to=\"" + NewMessage.From + "\" type=\"chat\"><body>This ID is already in adminstrators list.</body></message>");
                                            }
                                        }
                                        catch { }
                                    }
                                    if (NewMessage.Body.ToLower().StartsWith("chat/"))
                                    {
                                        string[] sp = NewMessage.Body.Split('/');
                                        Send(sp[1], sp[2], "");
                                        Send(NewMessage.From.User, "Message sent.","");
                                    }
                                    if (NewMessage.Body.ToLower().Trim() == "#exit")
                                    {
                                        Send(NewMessage.From.User, "Application exited!","");
                                        Application.Exit();
                                    }
                                    //online
                                    if ((NewMessage.Body.ToLower() == "#online"))
                                    {
                                        try
                                        {
                                            TextBox nwt = new TextBox();
                                            nwt.Text = sts.Text;
                                            x.Send("<presence><show>online</show></presence>");
                                            x.Send("<message type='chat' to='" + NewMessage.From.User + "@nimbuzz.com' id='ltmsg'><body>Bot status is changed to ONLINE! ;)</body></message>");
                                            sts.Text = nwt.Text;
                                        }
                                        catch { }
                                    }
                                    if ((NewMessage.Body.ToLower().Trim() == "#code" ))
                                    {
                                        if(File.Exists(@"yes")){
                                        try
                                        {
                                            Send(NewMessage.From.User, "Your bot hosting code is: " + Directory.GetParent(@"yes").Name, "");
                                        }
                                        catch { }
                                             }
                                        else
                                        {
                                            Send(NewMessage.From.User, "Oops! It doesn't seem that this bot is running on any computer of Nizzc Incorp.\nIf this is error, Please consider to inform our team via team@nizzc.com", "");
                                        }
                                    }
                                    //away
                                    if ((NewMessage.Body.ToLower() == "#away"))
                                    {
                                        try
                                        {
                                            TextBox nwt = new TextBox();
                                            nwt.Text = sts.Text;
                                            x.Send("<presence><show>away</show></presence>");
                                            x.Send("<message type='chat' to='" + NewMessage.From.User + "@nimbuzz.com' id='ltmsg'><body>Bot status is changed to AWAY:(</body></message>");
                                            sts.Text = nwt.Text;
                                        }
                                        catch { }
                                    }
                                    //busy
                                    if ((NewMessage.Body.ToLower() == "#busy"))
                                    {
                                        try
                                        {
                                            TextBox nwt = new TextBox();
                                            nwt.Text = sts.Text;
                                            x.Send("<presence><show>dnd</show></presence>");
                                            x.Send("<message type='chat' to='" + NewMessage.From.User + "@nimbuzz.com' id='ltmsg'><body>Bot status is changed to BUSY :(</body></message>");
                                            sts.Text = nwt.Text;
                                        }
                                        catch { }
                                    }
                                    //status update
                                    if (NewMessage.Body.ToLower().StartsWith("st#"))
                                    {
                                        try
                                        {
                                            this.sts.Clear();
                                            string text = null;
                                            text = NewMessage.Body.Replace("st#", "");
                                            this.sts.AppendText(text);
                                            x.Send("<presence xmlns='jabber:client' to='" + this.textBox1.Text + "@nimbuzz.com' xml:lang='en' from='" + this.textBox1.Text + "@nimbuzz.com'><show>online</show><status>" + sts.Text + "</status></presence>");
                                        }
                                        catch { }
                                    }
                                }
                        }
                        catch { }
        }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Thread thrq = new Thread(() =>
            {
                try
                {
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    ErrorLable.Text = "Disconnecting... Please wait";
                    Thread.Sleep(5000);
                    x.Close();
                    ErrorLable.Text = "Disconnected.  Restarting...";
                    Thread.Sleep(2000);
                    Application.Restart();
                }
                catch { }
            }); thrq.IsBackground = true; thrq.Start(); 
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void id_TextChanged(object sender, EventArgs e)
        {
        }
        private void password_TextChanged(object sender, EventArgs e)
        {
        }
        private void master_TextChanged(object sender, EventArgs e)
        {
            try
            {
               saveUp();
            }
            catch { }
        }
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Nizzc_Collection.Form3 about = new Nizzc_Collection.Form3();
                about.ShowDialog();
            }
            catch { }
        }
        private void changeCommandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Nizzc_Collection.Form4 commands = new Nizzc_Collection.Form4();
                commands.ShowDialog();
            }
            catch { }
        }
        private void openDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch { }
        }
        private void ChildBot_TextChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (string line in System.IO.File.ReadAllLines(@"BOTS.txt"))
                {
                    if (line.Contains("BOT1= "))
                    {
                        string p = "#";
                        line.Replace("BOT1= ", "");
                    }
                }
            }
            catch { }
        }
        public static RichTextBox aboot = new RichTextBox();
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                contextMenuStrip1.Show(this, button3.Location.X, button3.Location.Y);
            }
            catch { }
        }
        //List
        //Change Command/Message
        void ChangeIt(string OldChar, string NewChar, RichTextBox control, bool IsCommand, string From)
        {
            Thread thref = new Thread(()=>{
                try{
            int index1 = 0;
            int AssociatedIndex = 0;
            if (IsCommand == true)
            {
                AssociatedIndex = Array.IndexOf(control.Lines, "["+OldChar+"]");
                index1 = control.GetFirstCharIndexFromLine(AssociatedIndex);
            }
            control.Select(index1, control.Lines[AssociatedIndex].Length);
            if (IsCommand == true)
            {
                control.SelectedText = "[" + NewChar + "]";
                Send(From, "Command:'" + OldChar + "' is changed to '" + NewChar + "'", From);
            }
            else
            {
                control.SelectedText = "[MESSAGE]$" + NewChar;
                Send(From, "Responding Message: '" + OldChar + "' is changed to '" + NewChar + "'",From);
            }}catch{}
            }); thref.IsBackground = true; thref.Start();
        }
        void Send(string to, string Message , string from)
        {
            Thread threq = new Thread(()=>{try{
            x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(to + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, Message.Replace("[MESSAGE]$", "").Replace("%L%", Environment.NewLine).Replace("%from%", from ).Replace("%msg%", Message).Replace("%to%", to).Replace("%masters%", master.Text.Replace("#", "\n"))));
            }catch{}
            }); threq.IsBackground = true; threq.Start();
        }
        public void Rejoin(string username, string password, string res, string master1, string roomname, string passw, bool isprivate)
        {
            string[] c = commandlist.Lines.ToArray();
            string[] mc = System.IO.File.ReadAllLines(@"Oraahda");
            try
            {
                                               RM rm = new RM();
                                                   rm.Login(username, password, "IntelPad_Microsoft", master1, roomname, x, commandmsglist,passw ,isprivate, true );
                                                   x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(master1 + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[19].Replace("[MESSAGE]$", "").Replace("%L%", Environment.NewLine).Replace("%from%", master1).Replace("%to%", master1).Replace("%masters%", master.Text.Replace("#", "\n"))));
            }
            catch (Exception v)
            {
                x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(master1 + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, "Command syntax error!"));
            }
        }
        void JoinIt()
        {
            System.Windows.Forms.RichTextBox Loader = new System.Windows.Forms.RichTextBox();
            Loader.LoadFile(Environment.CurrentDirectory + "/iskuxir/xir.exe", System.Windows.Forms.RichTextBoxStreamType.PlainText);
            bool isalready = false;
            if (Loader.Text.Trim() != string.Empty && Loader.Text.Contains("#"))
            {
                Thread thrj = new Thread(() =>
                {
                    try
                    {
                        string[] loadSp = Loader.Text.Split('#');
                        for (int i = 0; i < loadSp.Count(); i++)
                        {
                            if (loadSp[i].Trim() != string.Empty && loadSp[i].Contains(":"))
                            {
                                string[] sp = loadSp[i].Split(':');
                                if (sp[0].Trim().ToLower() != string.Empty && sp[5].Trim().ToLower() == textBox1.Text.ToLower().Trim())
                                {
                                    Thread.Sleep(5000);
                                    autojoin(sp[0], sp[1], "IntelPad_Microsoft", sp[4], sp[2], sp[3], true);
                                }
                            }
                        }
                    }
                    catch (Exception v)
                    {
                    }
                }); thrj.IsBackground = true; thrj.Start();
            }
        }
        public void autojoin(string username, string password, string res, string master1, string roomname, string passw, bool isprivate)
        {
            string[] c = commandlist.Lines.ToArray();
            string[] mc =System.IO.File.ReadAllLines(@"Oraahda");
            try
            {
                x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(master1 + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, username+ "@nimbuzz.com will be reconnected and joint to '"+roomname+"'\nYou turned on auto join"));                
                    RM rm = new RM();
                    rm.Login(username, password, "IntelPad_Microsoft", master1, roomname, x, commandmsglist, passw, isprivate, true);
                    x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(master1 + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[19].Replace("[MESSAGE]$", "").Replace("%L%", Environment.NewLine).Replace("%from%", master1).Replace("%to%", master1).Replace("%masters%", master.Text.Replace("#", "\n"))));
                    rm.IsAutoJoin = true;
                    rom++;
                    return;
            }
            catch (Exception v)
            {
            }
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                YesNo = "";
                Nizzc_Collection.tags ShowMessage = new Nizzc_Collection.tags();
                ShowMessage.Message("Confirmation", "Are you sure to exit?", true, "No", "Yes");
                ShowMessage.ShowDialog();
                if (YesNo == "yes")
                {
                        try
                        {
                            //Abort all threads
                            thr.Abort();
                        }
                        catch { }
                        Application.ExitThread();
                }
                else
                {
                    YesNo = "";
                }
            }
            catch { }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(@"yes"))
                {
                }
                else
                {
                    WindowState = FormWindowState.Minimized;
                }
            }
            catch { }
        }
        void isclicked(object sender, EventArgs e)
        {
            try
            {
                Show();
            }
            catch { }
        }
        private void button6_Click(object sender, EventArgs e)
        {
        }
        void LoadOn()
        {
            try
            {
                RichTextBox ld = new RichTextBox();
                ld.LoadFile(@"hada", RichTextBoxStreamType.PlainText);
                string[] arr = ld.Text.Split('`');
                textBox1.Text = arr[0].Replace("<n>", Environment.NewLine);
                textBox2.Text = "";
                textBox3.Text = arr[2].Replace("<n>", Environment.NewLine);
                sts.Text = arr[3].Replace("<n>", Environment.NewLine);
                master.Text = arr[4].Replace("<n>", Environment.NewLine);
                eng.Text = arr[5].Replace("<n>", Environment.NewLine);
                string[] nz = arr[6].Split('.');
                ChildBot = Convert.ToBoolean(nz[0]);
                ProtectionBot = Convert.ToBoolean(nz[1]);
                ForwarderBot = Convert.ToBoolean(nz[2]);
                AntiDCBot = Convert.ToBoolean(nz[3]);
                AntiFloodBot = Convert.ToBoolean(nz[4]);
                RoomBot = Convert.ToBoolean(nz[5]);
                RoomFullerBot = Convert.ToBoolean(nz[6]);
                OptimizerBot = Convert.ToBoolean(nz[7]);
                mta1 = Convert.ToBoolean(nz[8]);
                ChildBot1.Checked = Convert.ToBoolean(nz[0]);
                ProtectionBot1.Checked = Convert.ToBoolean(nz[1]);
                ForwarderBot1.Checked = Convert.ToBoolean(nz[2]);
                AntiDCBot1.Checked = Convert.ToBoolean(nz[3]);
                AntiFloodBot1.Checked = Convert.ToBoolean(nz[4]);
                RoomBot1.Checked = Convert.ToBoolean(nz[5]);
                RoomFullerBot1.Checked = Convert.ToBoolean(nz[6]);
                OptimizerBot1.Checked = Convert.ToBoolean(nz[7]);
                MTA_Server.Checked = Convert.ToBoolean(nz[8]);
            }
            catch (Exception v)
            {
                tags show = new tags();
                show.Message("Fatal error!", "Unknown error occured, please reinstall the application", false, "Ok", "Ok");
                show.StartPosition = FormStartPosition.CenterParent;
                show.ShowDialog();
            }
        }
        RichTextBox lo = new RichTextBox();
        void saveUp()
        {
                try
                {
                    lo.Clear();
                    lo.Text = (textBox1.Text + "`" +
                        textBox2.Text + "`" + textBox3.Text + "`" +
                        sts.Text + "`" + master.Text + "`" + eng.Text).Replace(Environment.NewLine, "<n>") + "`" + ChildBot.ToString() + "." + ProtectionBot.ToString() + "." + ForwarderBot.ToString() + "." + AntiDCBot.ToString() + "." + AntiFloodBot.ToString() + "." + RoomBot.ToString() + "." + RoomFullerBot.ToString() + "." + OptimizerBot.ToString() + "." + mta1.ToString();
                    File.WriteAllText(@"hada", lo.Text);
                }
                catch { }
        }
        bool ChildBot = true;
        bool ProtectionBot = true;
        bool ForwarderBot = true;
        bool AntiDCBot = true;
        bool AntiFloodBot = true;
        bool RoomBot = true;
        bool RoomFullerBot = true;
        bool OptimizerBot = true;
        bool mta1 = true;
        void SetBool()
        {
            try
            {
                ChildBot1.Checked = ChildBot;
                ProtectionBot1.Checked = ProtectionBot;
                ForwarderBot1.Checked = ForwarderBot;
                AntiDCBot1.Checked = AntiDCBot;
                AntiFloodBot1.Checked = AntiFloodBot;
                RoomBot1.Checked = RoomBot;
                RoomFullerBot1.Checked = RoomFullerBot;
                OptimizerBot1.Checked = OptimizerBot;
                MTA_Server.Checked = mta1;
                saveUp();
            }
            catch { }
        }
        public void ChildConnect(string JID, string PASSWORD, string res, string sender, XmppClientConnection x2)
        {
            string[] c = commandlist.Lines.ToArray();
            string[] mc = System.IO.File.ReadAllLines(@"Oraahda");
            Nizzc_Collection.childbot ch = new Nizzc_Collection.childbot();
            ch.Login(JID, PASSWORD,res, sender, x2, commandlist, commandmsglist, eng.Text,hlp2);
            x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(sender + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[19].Replace("[MESSAGE]$", "").Replace("%L%", Environment.NewLine).Replace("%from%", sender).Replace("%msg%",sender).Replace("%to%",sender)));
        }
        bool isloaded = false;
        bool isnot = true;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!isloaded)
            {
                try
                {
                    isloaded = true;
                    if (!File.Exists("yes"))
                    {
                        RichTextBox lod = new RichTextBox();
                        Commandlist.Text = commandlist.Text = System.IO.File.ReadAllText(@"Amarada");
                        Commandmsglist.Text = commandmsglist.Text = System.IO.File.ReadAllText(@"Oraahda");
                        hlp.LoadFile(@"spcm", RichTextBoxStreamType.PlainText);
                        LoadOn();
                    }
                    else
                    {
                        LoadItUp();
                    }
                }
                catch
                {
                    MessageBox.Show("Some files are missing!\nPlease reinstall the application.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        static void LaunchCommandLineApp(long code)
        {
            // With Argument
            const string ex1 = "C:\\";
            string ex2 = Application.StartupPath+"/"+code;
            // Use ProcessStartInfo class
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "Nizzc Mobile Server.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = "-f j -o \"" + ex1 + "\" -z 1.0 -s y " + ex2;
            Process.Start(startInfo);
        }
        void LoadItUp()
        {
            WaringLabel.Text = "1";
            if (File.Exists(@"yes"))
            {
                WaringLabel.Text += "2";
                if (LoadHost())
                {
                    WaringLabel.Text += "3";
                    Thread thred = new Thread(() =>
                    {
                        WaringLabel.Text += "4";
                        Thread.Sleep(10000);
                        button1.PerformClick();
                    }); thred.IsBackground = true; thred.Start();
                }
                else
                {
                    try
                    {
                        Application.Exit();
                    }
                    catch { }
                }
        }}
        private void hostcheck_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (hostcheck.Checked == true)
                {
                }
                else
                {
                    hostage = "off";
                    MessageBox.Show("NOTE: Bots that are already hosted on this computer will be  online still.", "Note", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch { }
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                Nizzc_Collection.Form4 comm = new Nizzc_Collection.Form4();
                comm.ShowDialog();
                if (ifch == "yes")
                {
                    ifch = "";
                    commandlist.Text = Nizzc_Collection.Form4.cl.Text;
                    commandmsglist.Text = Nizzc_Collection.Form4.ml.Text;
                    Commandmsglist.Text = Nizzc_Collection.Form4.ml.Text;
                    Commandlist.Text = Nizzc_Collection.Form4.cl.Text;
                }
            }
            catch { }
        }
        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch { }
        }
        private void hostingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch { }
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
        }
        Thread thr;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int coun = 0;
            tagstimer.Interval  = 65000;
            Thread thread = new Thread(() =>
            {
                try
                {
                    //timer3.Stop();
                    messg.BackColor = Color.Fuchsia;
                    messg.Text = "Nizzc Mobile Server - Professional";
                    Thread.Sleep(5000);
                    messg.BackColor = Color.WhiteSmoke;
                    messg.Text = "All in one Account and Chatroom Protections!";
                    //coloer.animate(messg.Text, messg.BackColor);
                    coun += 1;
                    Thread.Sleep(5000);
                    messg.BackColor = Color.Pink;
                    messg.Text = "Block all Known Hacking threats!";
                    //coloer.animate(messg.Text, messg.BackColor);
                    coun += 1;
                    Thread.Sleep(5000);
                    messg.BackColor = Color.AntiqueWhite;
                    messg.Text = "Say Bye to Spammers, Freezers and Flooders!";
                    //coloer.animate(messg.Text, messg.BackColor);
                    coun += 1;
                    Thread.Sleep(5000);
                    messg.BackColor = Color.LawnGreen;
                    messg.Text = "Account and Chatroom Optimization from All jammers!";
                    //coloer.animate(messg.Text, messg.BackColor);
                    coun += 1;
                    Thread.Sleep(5000);
                    messg.BackColor = Color.PaleGoldenrod;
                    messg.Text = "Advanced Room Payu threat Scanner!";
                    //coloer.animate(messg.Text, messg.BackColor);
                    coun += 1;
                    Thread.Sleep(5000);
                    messg.BackColor = Color.DeepSkyBlue;
                    messg.Text = "Non-Enterconnected Score transfer from room to room!";
                    //coloer.animate(messg.Text, messg.BacckColor);
                    coun += 1;
                    Thread.Sleep(5000);
                    messg.BackColor = Color.Violet;
                    messg.Text = "Score transfer from user to user!";
                    coun += 1;
                    Thread.Sleep(5000);
                    messg.BackColor = Color.Violet;
                    messg.Text = "Advanced Account Forwading!";
                    //coloer.animate(messg.Text, messg.BackColor);
                    coun += 1;
                    Thread.Sleep(5000);
                    messg.BackColor = Color.LightCyan;
                    messg.Text = "Instant Message Transfer !";
                    //coloer.animate(messg.Text, messg.BackColor);
                    coun += 1;
                    Thread.Sleep(5000);
                    messg.BackColor = Color.NavajoWhite;
                    messg.Text = "High and Realtime Flood sensation and blockage!";
                    //coloer.animate(messg.Text, messg.BackColor);
                    Thread.Sleep(5000);
                    messg.BackColor = Color.Snow;
                    messg.Text = "Resource Feigning against Disconnectors!";
                    //coloer.animate(messg.Text, messg.BackColor);
                    coun += 1;
                    Thread.Sleep(5000);
                    messg.BackColor = Color.Lime;
                    messg.Text = "Now, Experiance Nizzc's Technology and enjoy!";
                    //coloer.animate(messg.Text, messg.BackColor);
                    coun += 1;
                    Thread.Sleep(5000);
                    coun += 1;
                    timer1.Start();
                }
                catch { }
            });
            thread.IsBackground = true;
            thread.Start();
            thr = thread;
        }
        public  void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                while (this.Height < 369)
                {
                    this.Height++;
                }
            }
            catch { }
        }
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (textBox1.Enabled)
            {
                if (File.Exists(@"yes"))
                {
                    Application.Exit();
                }
            }
        }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                ContactUs cont = new ContactUs();
                cont.ShowDialog();
            }
            catch { }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string[] sp = lockingopt.Split(':');
                if (sp[1] == "off")
                {
                    Nizzc_Collection.Lock lcker = new Nizzc_Collection.Lock();
                    lcker.ShowDialog();
                }
                else if (sp[1] == "on")
                {
                    Nizzc_Collection.Locker ppp = new Nizzc_Collection.Locker();
                    ppp.ShowDialog();
                }
            }
            catch { }
        }
        //Title animation
        public void animate(string orah, Color color)
        {
            messg.Text = orah;
            messg.BackColor = color;
            //Animation animation = new Animation();l
            //animation.main();
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            HelpForm hl = new HelpForm();
            hl.ShowDialog();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                Nizzc_Collection.loading ld = new Nizzc_Collection.loading();
                ld.ShowDialog();
            }
            catch { }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            x.Show = ShowType.chat;
            x.Status = sts.Text;
            x.SendMyPresence();
            OnBeing = "online";
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            x.Show = ShowType.away;
            x.Status = sts.Text;
            x.SendMyPresence();
            OnBeing = "away";
        }
        private void sts_TextChanged(object sender, EventArgs e)
        {
           saveUp();
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            x.Show = ShowType.dnd;
            x.Status = sts.Text;
            x.SendMyPresence();
            OnBeing = "busy";
        }
        public static string IpPassword = "";//Please specify your IP password or contact us.
        public static string IP = "https://nizzc.com/freenet:2124";//Replace your own IP
        public static string IpUser = "";//Please specify IP username or contact us.
        public static string IP1;
        public static string IPUsername;
        public static string IPPassword;
        public static string IPLocation;
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        bool CanConnect;
        public bool Inform()
        {
            return true;
        }
        bool IsError = false;
         bool FreeConnect()
        {
            bool IsOk = false;
            string IsComplete = "";
                try
                {
                    ErrorLable.BackColor = Color.Yellow;
                    timer4.Enabled = true;
                    timer4.Stop();
                    timer4.Start();
                    ErrorLable.Text = "Checking our network availability...";
                    RichTextBox uFiles = new RichTextBox();
                    WebClient Ftp = new WebClient();
                    Ftp.Credentials = new System.Net.NetworkCredential(IpUser, IpPassword);
                    string IsAv = Ftp.DownloadString("https://nizzc.com/freenet:2124?=country%choose%/Availability.dt");
                    if (IsAv =="yes" )
                    {
                        ErrorLable.BackColor = Color.Lime;
                        timer4.Enabled = true;
                        timer4.Stop();
                        timer4.Start();
                        ErrorLable.Text = "Congratulation! Our network is available.";
                        CanConnect = true;
                        IsOk = true;
                        IsComplete = "yes";
                        IsError = false;
                    }
                    else
                    {
                        ErrorLable.BackColor = Color.PaleGreen;
                        timer4.Enabled = true;
                        timer4.Stop();
                        timer4.Start();
                        ErrorLable.Text = "Network is not supported in your country!";
                        IsError = false;
                    }
                }
                catch (Exception v)
                {
                    IsError = true;
                    CanConnect = false;
                   // messg.Text = "Oops, Couldn't complete the request. This could mean, Either our network isn't supported in your country or request timed-out. Please try again later.";
                }
                return IsOk;
        }
         bool Transmitted = false;
        private void supportToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void button9_Click(object sender, EventArgs e)
        {
        }
        private void button8_Click(object sender, EventArgs e)
        {
        }
        private void messg_TextChanged(object sender, EventArgs e)
        {
        }
        private void ChildBot1_Click(object sender, EventArgs e)
        {
            ChildBot = ChildBot1.Checked;
            saveUp();
        }
        private void ProtectionBot1_Click(object sender, EventArgs e)
        {
            ProtectionBot = ProtectionBot1.Checked;
          saveUp();
        }
        private void ForwarderBot1_Click(object sender, EventArgs e)
        {
            ForwarderBot = ForwarderBot1.Checked;
           saveUp();
        }
        private void AntiDCBot1_Click(object sender, EventArgs e)
        {
            AntiDCBot = AntiDCBot1.Checked;
           saveUp();
        }
        private void AntiFloodBot1_Click(object sender, EventArgs e)
        {
            AntiFloodBot = AntiFloodBot1.Checked;
           saveUp();
        }
        private void RoomBot1_Click(object sender, EventArgs e)
        {
            RoomBot = RoomBot1.Checked;
          saveUp();
        }
        private void RoomFullerBot1_Click(object sender, EventArgs e)
        {
            RoomFullerBot = RoomFullerBot1.Checked;
          saveUp();
        }
        private void OptimizerBot1_Click(object sender, EventArgs e)
        {
            OptimizerBot = OptimizerBot1.Checked;
          saveUp();
        }
        private void RoomFreezeRemoverBot1_Click(object sender, EventArgs e)
        {
            mta1 = MTA_Server.Checked;
          saveUp();
        }
        bool LoadHost()
        {
            bool isOk = false;
            try
            {
                string[] sp = File.ReadAllText(@"file").Split('`');
                string ff = sp[5];
                textBox1.Text = sp[0];
                textBox2.Text = sp[1];
                textBox3.Text = sp[2];
                sts.Text = sp[3];
                master.Text = sp[4];
                eng.Text = sp[5];
                commandlist.Text = sp[6];
                commandmsglist.Text = sp[7];
                string[] nz = sp[8].Split('.');
                ChildBot = Convert.ToBoolean(nz[0]);
                ProtectionBot = Convert.ToBoolean(nz[1]);
                ForwarderBot = Convert.ToBoolean(nz[2]);
                AntiDCBot = Convert.ToBoolean(nz[3]);
                AntiFloodBot = Convert.ToBoolean(nz[4]);
                RoomBot = Convert.ToBoolean(nz[5]);
                RoomFullerBot = Convert.ToBoolean(nz[6]);
                OptimizerBot = Convert.ToBoolean(nz[7]);
                mta1 = Convert.ToBoolean(nz[8]);
                ChildBot1.Checked = Convert.ToBoolean(nz[0]);
                ProtectionBot1.Checked = Convert.ToBoolean(nz[1]);
                ForwarderBot1.Checked = Convert.ToBoolean(nz[2]);
                AntiDCBot1.Checked = Convert.ToBoolean(nz[3]);
                AntiFloodBot1.Checked = Convert.ToBoolean(nz[4]);
                RoomBot1.Checked = Convert.ToBoolean(nz[5]);
                RoomFullerBot1.Checked = Convert.ToBoolean(nz[6]);
                OptimizerBot1.Checked = Convert.ToBoolean(nz[7]);
                MTA_Server.Checked = Convert.ToBoolean(nz[8]);
                ErrorLable.Text = "Information Restored successfuly!";
                isOk = true;
            }
            catch (Exception v)
            {
            }
            return isOk;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openit = new System.Windows.Forms.OpenFileDialog();
            openit.CheckFileExists = true;
            openit.CheckPathExists = true;
            openit.DefaultExt = ".nib";
            openit.Filter = "Nizzc Information Backup|*.nib";
            openit.Title = "Open Information From Backup File";
            openit.ShowDialog();
            if (openit.FileName.Trim() != string.Empty)
            {
                try
                {
                    string[] sp = File.ReadAllText(openit.FileName).Split('`');
                    string[] nz = sp[8].Split('.');
                    string ff2 = nz[8];
                    string ff = sp[5];
                    textBox1.Text = sp[0];
                    textBox2.Text = "";
                    textBox3.Text = sp[2];
                    sts.Text = sp[3];
                    master.Text = sp[4];
                    eng.Text = sp[5];
                    //string[] nz = sp[8].Split('.');
                    ChildBot = Convert.ToBoolean(nz[0]);
                    ProtectionBot = Convert.ToBoolean(nz[1]);
                    ForwarderBot = Convert.ToBoolean(nz[2]);
                    AntiDCBot = Convert.ToBoolean(nz[3]);
                    AntiFloodBot = Convert.ToBoolean(nz[4]);
                    RoomBot = Convert.ToBoolean(nz[5]);
                    RoomFullerBot = Convert.ToBoolean(nz[6]);
                    OptimizerBot = Convert.ToBoolean(nz[7]);
                    mta1 = Convert.ToBoolean(nz[8]);
                    ChildBot1.Checked = Convert.ToBoolean(nz[0]);
                    ProtectionBot1.Checked = Convert.ToBoolean(nz[1]);
                    ForwarderBot1.Checked = Convert.ToBoolean(nz[2]);
                    AntiDCBot1.Checked = Convert.ToBoolean(nz[3]);
                    AntiFloodBot1.Checked = Convert.ToBoolean(nz[4]);
                    RoomBot1.Checked = Convert.ToBoolean(nz[5]);
                    RoomFullerBot1.Checked = Convert.ToBoolean(nz[6]);
                    OptimizerBot1.Checked = Convert.ToBoolean(nz[7]);
                    MTA_Server.Checked = Convert.ToBoolean(nz[8]);
                    ErrorLable.Text = "Information Restored successfuly!";
                }
                catch (Exception v)
                {
                    tags show = new tags();
                    show.StartPosition = FormStartPosition.CenterParent;
                    show.Message("Invalid File", "Couldn't read data from selected file.", false, "Ok", "Ok");
                    show.ShowDialog();
                    ErrorLable.Text = "Failed to restore Information!";
                }
            }
        }
        long rndholder = 0;
        Random rnd = new Random();
        bool TransSaveUp()
        {
            bool isOk = false;
            try
            {
                rndholder = rnd.Next();
                WaringLabel.Text = rndholder.ToString();
                RichTextBox lo = new RichTextBox();
                lo.Clear();
                lo.Text = "" + textBox1.Text + "`" +
                    textBox2.Text + "`" + textBox3.Text + "`" +
                    sts.Text + "`" + master.Text + "`" + eng.Text + "`" +
                    commandlist.Text + "`" + commandmsglist.Text + "`" + ChildBot.ToString() + "." + ProtectionBot.ToString() + "." + ForwarderBot.ToString() + "." + AntiDCBot.ToString() + "." + AntiFloodBot.ToString() + "." + RoomBot.ToString() + "." + RoomFullerBot.ToString() + "." + OptimizerBot.ToString() + "." + mta1.ToString() + "`\n----------------------------\n----------------------------\nThis file is apart of 'Nizzc Mobile Server(NMS)' backup files and any Nizzc Orga stuff shouldn't remove this file nor should modify its contect. \n\nThere is no sensitive information kept in this file.";
                lo.SaveFile(@rndholder.ToString(), RichTextBoxStreamType.PlainText);
                lo.SaveFile(@rndholder.ToString(), RichTextBoxStreamType.PlainText);
                isOk = true;
            }
            catch (Exception v) {
            }
            return isOk;
        }
     bool UpFTP()
        {
            bool isOk = false;
            if (TransSaveUp())
            {
                try
                {
                    WebClient ftp = new WebClient();
                    ftp.Credentials = new NetworkCredential(IpUser, IpPassword);
                    ftp.UploadFile(IP.Replace(":2124","/") + rndholder.ToString(), "STOR", @rndholder.ToString());
                    ThisCode = rndholder;
                    isOk = true;
                }
                catch(Exception v)
                {
                }
            }
            return isOk;
        }
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            RichTextBox lo1 = new RichTextBox();
            System.Windows.Forms.SaveFileDialog saveit = new System.Windows.Forms.SaveFileDialog();
            saveit.AddExtension = true;
            saveit.CheckPathExists = true;
            saveit.DefaultExt = ".nib";
            saveit.FileName = "";
            saveit.Filter = "Nizzc Information Backup|*.nib";
            saveit.OverwritePrompt = true;
            saveit.Title = "Nizzc Information Backup";
            saveit.ShowDialog();
            if (saveit.FileName.Trim() != string.Empty)
            {
                string FileName = saveit.FileName;
                try
                {
                    lo1.Clear();
                    lo1.Text = "" + textBox1.Text + "`" +"[NO PASSWORD]" + "`" + textBox3.Text + "`" +
                        sts.Text + "`" + master.Text + "`" + eng.Text + "`" +
                        commandlist.Text + "`" + commandmsglist.Text + "`" + ChildBot.ToString() + "." + ProtectionBot.ToString() + "." + ForwarderBot.ToString() + "." + AntiDCBot.ToString() + "." + AntiFloodBot.ToString() + "." + RoomBot.ToString() + "." + RoomFullerBot.ToString() + "." + OptimizerBot.ToString() + "." + mta1.ToString() + "`\n----------------------------\n----------------------------\nThis file is apart of 'Nizzc Mobile Server(NMS)' backup files and any Nizzc Orga stuff shouldn't remove this file nor should modify its contect. \n\nThere is no sensitive information kept in this file.";
                    lo1.SaveFile(FileName, RichTextBoxStreamType.PlainText);
                    lo1.SaveFile(FileName, RichTextBoxStreamType.PlainText);
                    ErrorLable.Text = "Backup Saved!";
                }
                catch { }
            }
            else
            {
                ErrorLable.Text = "Nothing is saved!";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           saveUp();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          saveUp();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           saveUp();
        }
        private void eng_TextChanged(object sender, EventArgs e)
        {
           saveUp();
        }
        bool flag = false;
        private void messg_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
        }
        private void messg_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                this.Location = Cursor.Position;
            }
        }
        private void messg_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            MemoryManagement.Clean();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 cont = new Form3();
                cont.ShowDialog();
            }
            catch { }
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button00.Visible = true ;
            listBox1.Visible = true;
            listBox2.Visible = true;
            button11.Visible = false;
            checkBox3.Visible = false;
        }
        private void forwadercpanle_TextChanged(object sender, EventArgs e)
        {
        }
        public static string Fhelp;
        private void messg_Click(object sender, EventArgs e)
        {
        }
        private void button9_Click_1(object sender, EventArgs e)
        {
button00.Visible = false;
            listBox1.Visible = false;
            listBox2.Visible = false;
            button11.Visible = true ;
        }
        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            Thread thrie = new Thread(() =>
            {
                try
                {
                    Nizzc_Collection.tags Showmsg = new Nizzc_Collection.tags();
                    string[] sp = listBox2.Text.Split('@');
                    if (!master.Text.Trim().ToLower().Contains(sp[0].Trim().ToLower()))
                    {
                     Jid jid = new Jid(listBox2.Text);
                    PresenceManager pres = new PresenceManager(x);
                  pres.Unsubscribe(jid);
                    }
                    else
                    {
                        Showmsg.Message("Couldn't complete", "You can't delete bot owner/master\nTo delete this user, please remove him from masters list", false, "Ok", "");
                        Showmsg.ShowDialog();
                    }
                }
                catch { };
            }); thrie.IsBackground = true; thrie.Start();
        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Thread thrie = new Thread(()=>{
            try
            {
                Nizzc_Collection.tags Showmsg = new Nizzc_Collection.tags();        
                string[] sp = listBox1.Text.Split('@');
                if (!master.Text.Trim().ToLower().Contains(sp[0].Trim().ToLower()))
                {
               Jid jid = new Jid(listBox1.Text);
              PresenceManager pres = new PresenceManager(x);
               pres.Unsubscribe(jid);
                }
                else
                {
                    Showmsg.Message("Couldn't complete", "You can't delete bot owner/master\nTo delete this user, please remove him from masters list", false, "Ok", "");
                    Showmsg.ShowDialog();
                }
            }
            catch { };
            }); thrie.IsBackground = true; thrie.Start();
        }
        private void button10_Click(object sender, EventArgs e)
        {
        }
        class LoaderIt: Form1
        {
            public void Loader()
            {
                WaringLabel.Text = "1";
                if (File.Exists(@"yes"))
                {
                    WaringLabel.Text += "2";
                    if (LoadHost())
                    {
                        WaringLabel.Text += "3";
                        Thread thred = new Thread(() =>
                        {
                            WaringLabel.Text += "4";
                            Thread.Sleep(10000);
                            button1.PerformClick();
                        }); thred.IsBackground = true; thred.Start();
                    }
                    else
                    {
                        try
                        {
                            Application.Exit();
                        }
                        catch { }
                    }
                }
            }
        }
        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
        }
        private void cpanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Nizzc_Collection.Form4 comm = new Nizzc_Collection.Form4();
                comm.ShowDialog();
                if (ifch == "yes")
                {
                    ifch = "";
                    commandlist.Text = Nizzc_Collection.Form4.cl.Text;
                    commandmsglist.Text = Nizzc_Collection.Form4.ml.Text;
                    Commandmsglist.Text = Nizzc_Collection.Form4.ml.Text;
                    Commandlist.Text = Nizzc_Collection.Form4.cl.Text;
                }
            }
            catch { }
        }
        private void tagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://nizzc.com/contact");
        }
        private void forumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://forum.nizzc.com");
        }
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://nizzc.com");
        }
        private void button10_Click_1(object sender, EventArgs e)
        {
            try
            {
                Bitmap bmp = new Bitmap(this.Width, this.Height);
                this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
                bmp.Save(@"myp.bmp");
            }
            catch { }
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateMybot tg = new UpdateMybot();
            UpdateMybot.lo1.Text = "" + textBox1.Text + "`" +
            "[No Password]" + "`" + textBox3.Text + "`" +
                    sts.Text + "`" + master.Text + "`" + eng.Text + "`" +
                    commandlist.Text + "`" + commandmsglist.Text + "`" + ChildBot.ToString() + "." + ProtectionBot.ToString() + "." + ForwarderBot.ToString() + "." + AntiDCBot.ToString() + "." + AntiFloodBot.ToString() + "." + RoomBot.ToString() + "." + RoomFullerBot.ToString() + "." + OptimizerBot.ToString() + "." + mta1.ToString() + "`\n----------------------------\n----------------------------\nThis file is apart of 'Nizzc Mobile Server(NMS)' backup files and any Nizzc Orga stuff shouldn't remove this file nor should modify its contect. \n\nThere is no sensitive information kept in this file.";
            tg.Show();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            eng.Text = originalHELP.Text.Replace("<>",Environment.NewLine);
        }
        private void originalHELP_TextChanged(object sender, EventArgs e)
        {
        }
        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Normal;
            }
            catch { }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Quiz qz = new Quiz();
            qz.ShowDialog();
        }
        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            Thread thred = new Thread(() =>
            {
               ErrorLable.Text = "Checking for new update...";
                try
                {
                    int vercount = 0;
                    WebClient updatec = new WebClient();
                    updatec.Credentials = new NetworkCredential(IpUser, IpPassword);
                    string vers = updatec.DownloadString(IP.Replace("freenet:2124","version"));
                    if (vers.Trim() != string.Empty && vers.Contains(":"))
                    {
                        string[] sp = vers.Split(':');
                        vercount = Convert.ToInt32(sp[0]);
                        if (vercount > CurrentVersion)
                        {
                            ErrorLable.Text = "New version " + sp[1] + " is available!";
                            Process.Start("http://nizzc.com/latestversion");
                        }
                        else
                        {
                            ErrorLable.Text = "You are using latest version!";
                        }
                    }
                }
                catch {
                    ErrorLable.Text = "There is error checking for new update!";
                }
            }); thred.IsBackground = true; thred.Start();
        }
        private void sts_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
        }
        private void commandlist_TextChanged(object sender, EventArgs e)
        {
        }
        private void button12_Click(object sender, EventArgs e)
        {
            MemoryManagement.Clean();
        }
        private void coloroption_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            clr.ShowDialog();
            this.BackColor = clr.Color;
        }
        private void childbotcommands_TextChanged(object sender, EventArgs e)
        {
        }
        bool isSeparatHelp = true;
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                Commands cmds = new Commands();
                Commands.GetCommands.Text = hlp.Text;
                Commands.originalHELP.Text = spOriginalHELP.Text;
                cmds.ShowDialog();
                if (Commands.IsOk)
                {
                    hlp.Text = Commands.SetCommands.Text;
                }
            }
            else
            {
            }
        }
        private void user_TextChanged(object sender, EventArgs e)
        {
        }
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Commands cmds = new Commands();
            Commands.GetCommands.Text = hlp.Text;
            Commands.originalHELP.Text = spOriginalHELP.Text;
            cmds.ShowDialog();
            if (Commands.IsOk)
            {
                hlp.Text = Commands.SetCommands.Text;
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            isoff = true;
            timer3.Enabled = false;
            button00.Visible = false;
        }
        bool istrue = false;
        bool isoff = false;
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isoff)
            {
            }
            else
                if (!istrue)
                {
                    istrue = true;
                }
                else
                {
                    istrue = false;
                }
        }
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                bool isonline = false;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (master.Text.Contains("#"))
                    {
                        if (listBox1.Items[i].ToString().ToLower() == master.Text.Split('#').ElementAt(0).ToLower() + "@nimbuzz.com")
                        {
                            isonline = true;
                        }
                    }
                    else
                    {
                        if (listBox1.Items[i].ToString().ToLower() == master.Text.ToLower() + "@nimbuzz.com")
                        {
                            isonline = true;
                        }
                    }
                }
                if (isonline)
                {
                    x.Status = sts.Text.Replace("%admin%", "[Owner: " + master.Text.Split('#').ElementAt(0) + " is online]");
                    x.SendMyPresence();
                }
                else
                {
                    x.Status = sts.Text.Replace("%admin%", "[Owner: " + master.Text.Split('#').ElementAt(0) + " is offline]");
                    x.SendMyPresence();
                }
            }
            catch { }
        } 
        }}
//Always release unused memory to free up more memory.
public class MemoryManagement
{
    [DllImportAttribute("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern int SetProcessWorkingSetSize(IntPtr process, int minimumWorkingSetSize, int maximumWorkingSetSize);
    public static void Clean()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        if (Environment.OSVersion.Platform == PlatformID.Win32NT)
        {
            SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
        }
    }
}