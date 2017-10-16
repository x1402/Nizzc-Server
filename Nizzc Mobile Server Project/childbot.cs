using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using agsXMPP;
using agsXMPP.Collections;
using agsXMPP.util;
using agsXMPP.protocol.client;
using agsXMPP.Xml.Dom;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Runtime.CompilerServices;
using System.IO;
using System.Xml;
using System.Collections;
using System.Collections.ObjectModel;
using System.Threading;
using System.Timers;
using System.Net;
using Nizzc_Mobile_Ser;
using Nizzc_Mobile_Server;
namespace Nizzc_Collection
{
    class childbot
    {
        private string senderuser;
        private string senderpass;
        private string[] a;
        private string sid;
        private string spa;
        private string ID;
        private string PSW;
        private string Resouce;
        private string MTA;
        string Res;
        string dcch;
        RichTextBox help = new RichTextBox();
        private string Subject;
        Random rnd = new Random();
        RichTextBox sts = new RichTextBox();
         RichTextBox admins = new RichTextBox();
         string master = "";
        RichTextBox acc = new RichTextBox();
        RichTextBox Commandmsglist = new RichTextBox();
        RichTextBox user = new RichTextBox();
        TextBox sender2 = new TextBox();
        RichTextBox snderuser = new RichTextBox();
        RichTextBox snderpass = new RichTextBox();
        private string sender1;
        XmppClientConnection x = new XmppClientConnection();
        XmppClientConnection x1 = new XmppClientConnection();
int childbotcount;
         int hostedbotcount;
        int dccount;
         int addfloodcount;
        int protectedcount;
        int mtacount;
         int rom;
        int romopt;
         int optim;
        string onlinetime;
         int fow;
        int childcounts;
        int trnscount;
        string op = "op", fwrd = "fwrd", trns = "trns", scan = "scan", ent = "ent", entp = "entp", adc = "adc", dis = "dis", mta = "mta", cont = "cont", share = "share", crtqq = "crt", protection = "protection", assistance = "assistance", bots = "bots", others = "others";
        char separator = '#';
      RichTextBox Commandlist = new RichTextBox();
      RichTextBox eng = new RichTextBox();
      string hlp1 = "";
      string hlp2 = "";
      string hlp3 = "";
      string hlp4 = "";
      bool isseparatble = true;
      bool iscategorized = true;
        public void Login(string JID, string PASSWORD, string res, string sender,XmppClientConnection x2, RichTextBox Commands, RichTextBox Cmessages,string userhelp,RichTextBox hlp)
        {
            Res = res;
            x1 = x2;
            acc.Text = Nizzc_Mobile_Ser.Form1.Acc.Text;
            Commandlist.Text = Commands.Text;
            Commandmsglist.Text = Cmessages.Text;
            eng.Text = Form1.ChildBotEng.Text;
            admins.Text += sender + "#";
            master = sender;
            Aborter.Elapsed+=new ElapsedEventHandler(AbortIt);
            Aborter.Interval = 10000;
            try
            {
                string[] spc = hlp.Text.Split('|');
                hlp1 = spc[0];
                hlp2 = spc[1];
                hlp3 = spc[2];
                hlp4 = spc[3];
            }
            catch { isseparatble = false; iscategorized = false; }
            this.ID = JID;
            this.PSW = PASSWORD;
            this.Resouce = res;
            this.sender1 = sender;
            AdminChanger.Interval = 3000;
            System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
                try
                {
                    x.Server = "nimbuzz.com";
                    x.ConnectServer = "o.nimbuzz.com";
                    x.OnAuthError += new XmppElementHandler(this.OnFailed);
                    x.OnLogin += new ObjectHandler(this.OnConnected);
                    x.OnClose += new ObjectHandler(this.OnDis);
                    x.OnMessage += new MessageHandler(OnMessage);
                    x.OnPresence += new agsXMPP.protocol.client.PresenceHandler(onlineadd);
                    x.OnPresence += new PresenceHandler(Prec);
                    x.OnMessage += new MessageHandler(Admin_OnMessage);
                    x.Open(this.ID, this.PSW, res, 50);
                }
                catch (Exception j) { }
        }
        bool IsAdmin(string cuser)
        {
            bool isyes = false;
            for (int i = 0; i < admins.Text.Split('#').Count(); i++)
            {
                if (admins.Text.Split('#').ElementAt(i).ToLower().Trim() == cuser.Trim().ToLower())
                {
                    isyes = true;
                }
            }
            return isyes;
        }
        bool isrestart = false;
        System.Timers.Timer Aborter = new System.Timers.Timer();
        void AbortIt(object sender, EventArgs e)
        {
            Aborter.Stop();
            isrestart = false;
        }
        System.Timers.Timer AdminChanger = new System.Timers.Timer();
        private void Admin_OnMessage(object sender, agsXMPP.protocol.client.Message NewMessage)
        {
            if (IsAdmin(NewMessage.From.User))
            {
                if (NewMessage.Body.Trim().ToLower() == "#users" || NewMessage.Body.Trim().ToLower() == "#user")
                {
                    Send(NewMessage.From.User, ShowUsers(),"");
                }
                if (NewMessage.Body.Trim().ToLower() == "#reset")
                {
                    Aborter.Start();
                    isrestart = true;
                    Send(NewMessage.From.User, "Are you sure to reset your bot?\nYes\nNo", "");
                }
                if (NewMessage.Body.Trim().ToLower() == "yes")
                {
                    if (isrestart)
                    {
                        Aborter.Stop();
                        dcch = "off";
                        isrestart = false; ;
                        Send(NewMessage.From.User, "Please wait while Your bot is being restarted!", "");
                        x.Close();
                        Form1 rec = new Form1();
                        rec.ChildConnect(x.Username, x.Password, Resouce, master, x);
                    }
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
                if (NewMessage.Body.ToLower().StartsWith("st/"))
                {
                    try
                    {
                        this.sts.Clear();
                        string text = null;
                        text = NewMessage.Body.Replace("st/", "");
                        this.sts.AppendText(text);
                        x.Send("<presence xmlns='jabber:client' to='" + x.Username + "@nimbuzz.com' xml:lang='en' from='" + x.Username + "@nimbuzz.com'><show>online</show><status>" + sts.Text + "</status></presence>");
                        Send(NewMessage.From.User, "Status message is changed!", "");
                    }
                    catch { }
                }
                if (NewMessage.Body.ToLower().Trim() == "#logout")
                {
                    dcch = "off";
                    Send(NewMessage.From.User, "disconnected", "");
                    x.Close();
                }
                if (NewMessage.Body.ToLower().StartsWith("chat/"))
                {
                    string[] sp = NewMessage.Body.Split('/');
                    Send(sp[1], sp[2], "");
                    Send(NewMessage.From.User, "Message sent.", "");
                }
                //remove user
                if (NewMessage.Body != null && NewMessage.Body.ToLower().StartsWith("delu/"))
                {
                    try
                    {
                        string[] sp = NewMessage.Body.Split('/');
                        //delete roster
                        x.Send("<iq type=\"set\" id=\"qip_2483\"><query xmlns=\"jabber:iq:roster\"><item jid=\"" + (sp[1]) + "@nimbuzz.com\" subscription=\"remove\" /></query></iq>");
                        x.Send("<message type='chat' to='" + NewMessage.From.User + "@nimbuzz.com' id='ltmsg'><body>" + sp[1] + "@nimbuzz.com has been removed!</body></message>");
                        listBox1.Items.Remove(sp[1] + "@nimbuzz.com");
                    }
                    catch { }
                }
                if (NewMessage.Body != null && NewMessage.Body.ToLower().StartsWith("addu/"))
                {
                    try
                    {
                        string[] sp = NewMessage.Body.Split('/');
                        x.PresenceManager.Subscribe(new Jid(sp[1] + "@nimbuzz.com"));
                       // x.Send("<iq type=\"set\" id=\"qip_2483\"><query xmlns=\"jabber:iq:roster\"><item jid=\"" + (sp[1]) + "@nimbuzz.com\" subscription=\"remove\" /></query></iq>");
                        x.Send("<message type='chat' to='" + NewMessage.From.User + "@nimbuzz.com' id='ltmsg'><body>" + sp[1] + "@nimbuzz.com is added to addlist!</body></message>");
                        listBox1.Items.Remove(sp[1] + "@nimbuzz.com");
                    }
                    catch { }
                }
                //delete remoter
                if (NewMessage.Body.ToLower().StartsWith("delm/"))
                {
                    string listeds = "";
                    string[] ussp = NewMessage.Body.Split('/');
                    if (ussp[1].ToLower().Trim() == admins.Text.ToLower().Trim().Split('#').ElementAt(0))
                        Send(NewMessage.From.User, "You can't delete bot owner!", "");
                    else
                    {
                        bool isdelete = false;
                        try
                        {
                            if (admins.Text.Contains("#"))
                            {
                                string[] sp = admins.Text.Split('#');
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
                                admins.Text = listeds;
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
                if (NewMessage.Body.ToLower().Trim()=="#cpanel")
                {
                    x.Send("<message type='chat' to='" + NewMessage.From.User + "@nimbuzz.com' id='ltmsg'><body>"+Form1.ChildBotCommands.ToString()+"</body></message>");
                }
                //Change command
                if (NewMessage.Body.ToLower().Trim().StartsWith("change/"))
                {
                    string[] sp = NewMessage.Body.Split('/');
                    if (sp[2].Trim() != string.Empty)
                    {
                        if (sp[1].Trim().ToLower() == op.Trim().ToLower())
                        {
                            Send(NewMessage.From.User, "'" + op + "' is changed to '" + sp[2], "");
                            op = sp[2].Trim().ToLower();
                        }
                        else if (sp[1].Trim().ToLower() == fwrd.Trim().ToLower())
                        {
                            Send(NewMessage.From.User, "'" + fwrd + "' is changed to '" + sp[2], "");
                            fwrd = sp[2].Trim().ToLower();
                        }
                        else if (sp[1].Trim().ToLower() == trns.Trim().ToLower())
                        {
                            Send(NewMessage.From.User, "'" + trns + "' is changed to '" + sp[2], "");
                            trns = sp[2].Trim().ToLower();
                        }
                        else if (sp[1].Trim().ToLower() == scan.Trim().ToLower())
                        {
                            Send(NewMessage.From.User, "'" + scan + "' is changed to '" + sp[2], "");
                            scan = sp[2].Trim().ToLower();
                        }
                        else if (sp[1].Trim().ToLower() == ent.Trim().ToLower())
                        {
                            Send(NewMessage.From.User, "'" + ent + "' is changed to '" + sp[2], "");
                            ent = sp[2].Trim().ToLower();
                        }
                        else if (sp[1].Trim().ToLower() == entp.Trim().ToLower())
                        {
                            Send(NewMessage.From.User, "'" + entp + "' is changed to '" + sp[2], "");
                            entp = sp[2].Trim().ToLower();
                        }
                        else if (sp[1].Trim().ToLower() == adc.Trim().ToLower())
                        {
                            Send(NewMessage.From.User, "'" + adc + "' is changed to '" + sp[2], "");
                            adc = sp[2].Trim().ToLower();
                        }
                        else if (sp[1].Trim().ToLower() == dis.Trim().ToLower())
                        {
                            Send(NewMessage.From.User, "'" + dis + "' is changed to '" + sp[2], "");
                            dis = sp[2].Trim().ToLower();
                        }
                        else if (sp[1].Trim().ToLower() == mta.Trim().ToLower())
                        {
                            Send(NewMessage.From.User, "'" + mta + "' is changed to '" + sp[2], "");
                            mta = sp[2].Trim().ToLower();
                        }
                        else if (sp[1].Trim().ToLower() == "help".Trim().ToLower())
                        {
                            Send(NewMessage.From.User, "Sorry, you can't change 'help' command!", "");
                        }
                        else if (sp[1].Trim().ToLower() == "about".Trim().ToLower())
                        {
                            Send(NewMessage.From.User, "Sorry, you can't change 'about' command!", "");
                        }
                        else if (sp[1].Trim().ToLower() == "info".Trim().ToLower())
                        {
                            Send(NewMessage.From.User, "Sorry, you can't change 'info' command!", "");
                        }
                        else if (sp[1].Trim().ToLower() == share.Trim().ToLower())
                        {
                            Send(NewMessage.From.User, "'" + share + "' is changed to '" + sp[2], "");
                            share = sp[2].Trim().ToLower();
                        }
                        else if (sp[1].Trim().ToLower() == "dddddde3455crt".Trim().ToLower())
                        {
                            Send(NewMessage.From.User, "'" + "ddddgtttgvcrt" + "' is changed to '" + sp[2], "");
                            string dddo93e9302 = sp[2].Trim().ToLower();
                        }
                        else if (sp[1].Trim().ToLower() == cont.Trim().ToLower())
                        {
                            Send(NewMessage.From.User, "'" + cont + "' is changed to '" + sp[2], "");
                            cont = sp[2].Trim().ToLower();
                        }
                        else if (sp[1].Trim().ToLower() == protection.Trim().ToLower())
                        {
                            Send(NewMessage.From.User, "'" + protection + "' is changed to '" + sp[2], "");
                            protection = sp[2].Trim().ToLower();
                        }
                        else if (sp[1].Trim().ToLower() == assistance.Trim().ToLower())
                        {
                            Send(NewMessage.From.User, "'" + assistance + "' is changed to '" + sp[2], "");
                            assistance = sp[2].Trim().ToLower();
                        }
                        else if (sp[1].Trim().ToLower() == bots.Trim().ToLower())
                        {
                            Send(NewMessage.From.User, "'" + bots + "' is changed to '" + sp[2], "");
                            bots = sp[2].Trim().ToLower();
                        }
                        else if (sp[1].Trim().ToLower() == others.Trim().ToLower())
                        {
                            Send(NewMessage.From.User, "'" + others + "' is changed to '" + sp[2], "");
                            others = sp[2].Trim().ToLower();
                        }
                        else
                        {
                            Send(NewMessage.From.User, "'"+sp[1]+"' doesn't exist!", "");
                        }
                    }
                    else
                    {
                        Send(NewMessage.From.User, "Command syntax error!", "");
                    }
                }
                if (NewMessage.Body.ToLower().StartsWith("hc/"))
                {
                    string[] sp = NewMessage.Body.Split('/');
                    if (sp[1].Trim().ToLower() == protection)
                    {
                        try
                        {
                            hlp1 = sp[2];
                            Send(NewMessage.From.User, "User help of category '" + protection + "' is changed!\nTo see the effects send " + protection.ToUpper(), "");
                        }
                        catch { Send(NewMessage.From.User, "Error occured!", ""); }
                    }
                    else if (sp[1].Trim().ToLower() == assistance.ToLower().Trim())
                    {
                        try
                        {
                            hlp1 = sp[2];
                            Send(NewMessage.From.User, "User help of category '" + assistance + "' is changed!\nTo see the effects send " + assistance.ToUpper(), "");
                        }
                        catch { Send(NewMessage.From.User, "Error occured!", ""); }
                    }
                    else if (sp[1].Trim().ToLower() == bots.ToLower().Trim())
                    {
                        try
                        {
                            hlp1 = sp[2];
                            Send(NewMessage.From.User, "User help of category '" + bots + "' is changed!\nTo see the effects send " + bots.ToUpper(), "");
                        }
                        catch { Send(NewMessage.From.User, "Error occured!", ""); }
                    }
                    else if (sp[1].Trim().ToLower() == others.ToLower().Trim())
                    {
                        try
                        {
                            hlp1 = sp[2];
                            Send(NewMessage.From.User, "User help of category '" + others + "' is changed!\nTo see the effects send " + others.ToUpper(), "");
                        }
                        catch { Send(NewMessage.From.User, "Error occured!", ""); }
                    }
                    else
                    {
                        Send(NewMessage.From.User, "There is no category named '" + sp[1].ToUpper() + "'! \ndid you mean one of these '" + protection.ToUpper() + "," + assistance.ToUpper() + "," + bots.ToUpper() + "," +others.ToUpper() +"'?", "");
                    }
                }
                //change help
                if (NewMessage.Body.StartsWith("h/"))
                {
                    eng.Text = NewMessage.Body.Remove(0,2) ;
                    Send(NewMessage.From.User, "User help content is changed!\nSend HELP to see effects.", "");
                }
                if (NewMessage.Body.ToLower().StartsWith("addm/"))
                {
                    try
                    {
                        string[] sp1 = NewMessage.Body.Split('/');
                        if (!admins.Text.ToLower().Contains(sp1[1].ToLower()))
                        {
                            if (admins.Text.EndsWith("#"))
                            {
                                admins.Text += (sp1[1] + "#");
                            }
                            else
                            {
                                admins.Text += ("#" + sp1[1] + "#");
                            }
                            x.Send("<message to=\"" + NewMessage.From + "\" type=\"chat\"><body>New bot administrator is added.</body></message>");
                        }
                        else
                        {
                            x.Send("<message to=\"" + NewMessage.From + "\" type=\"chat\"><body>This ID is already in administrators list.</body></message>");
                        }
                    }
                    catch { }
                }
            }
        }
        //Auto admin status detector
        void StAdddddmin(object sender, EventArgs e)
        {
            //in this child bot, we didnot use it.
            try
            {
                bool isonline = false;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (admins.Text.Contains("#"))
                    {
                        if (listBox1.Items[i].ToString().ToLower() == admins.Text.Split('#').ElementAt(0).ToLower() + "@nimbuzz.com")
                        {
                            isonline = true;
                        }
                    }
                    else
                    {
                        if (listBox1.Items[i].ToString().ToLower() == admins.Text.ToLower() + "@nimbuzz.com")
                        {
                            isonline = true;
                        }
                    } if (isonline)
                    {
                        x.Status = sts.Text.Replace("%admin%", "[Owner: " + admins.Text.Split('#').ElementAt(0) + " is online]");
                        x.SendMyPresence();
                    }
                    else
                    {
                        x.Status = sts.Text.Replace("%admin%", "[Owner: " + admins.Text.Split('#').ElementAt(0) + " is offline]");
                        x.SendMyPresence();
                    }
                }
            }
            catch { }
        }
        private void onlineadd(object sender, agsXMPP.protocol.client.Presence pres)
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
                        if (pres.Type == PresenceType.unsubscribed || pres.Type == PresenceType.unsubscribe || pres.Type == PresenceType.unavailable)
                        {
                            listBox1.Items.Remove(pres.From.Bare);
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
        }
        string ShowUsers()
        {
            string Userslist = "";
            try
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (listBox1.Items[i].ToString().Trim() != string.Empty && listBox1.Items[i].ToString().Contains("@"))
                    {
                        Userslist += listBox1.Items[i].ToString() + "\n";
                    }
                }
            if (Userslist.Trim() == string.Empty)
            {
                Userslist = "No user is online now!";
            }}
            catch {
                Userslist = "Error on reading online users!\nPlease try again.";
            }
            return Userslist;
        }
        private void OnMessage(object sender, agsXMPP.protocol.client.Message NewMessage)
        {
            Thread thrd = new Thread(()=>{
            try
            {
                string[] c = Commandlist.Lines;
                string[] mc = Commandmsglist.Lines;
                if (NewMessage.Body.ToLower().Trim() == "help")
                {
                    try
                    {
                        x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, eng.Text.Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", admins.Text.Replace("#", "\n").Replace("%user%", NewMessage.From.User))));
                        return;
                    }
                    catch { }
                }
                //Creating childbot on childbot
                if (NewMessage.Body.ToLower().StartsWith(separator+"222345678trdscvgtfc")) 
                {
                    //in this child bot, we didnt use this.
                    try
                    {
                            string[] sp = NewMessage.Body.Split(separator);
                            Nizzc_Collection.childbot ch = new Nizzc_Collection.childbot();
                            //ch.Login(sp[1].Trim(), sp[2].Trim(), sp[3].Trim(), msg.From.User, x, Commandlist, Commandmsglist, Form1.ChildBotEng.Text);
                            x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[19].Replace("[MESSAGE]$", "").Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", admins.Text.Replace("#", "\n"))));
                            childcounts++;
                    }
                    catch { }
                }
                //info
                if (NewMessage.Body.ToLower() == "info")
                {
                    try
                    {
                        //Check
                        string info = "\nRoomBot: " + rom + "\nScanned: " + protectedcount + "\nDC Protection: " + dccount + "\nForwarded: " + fow /*+"\nChild Bots: "+childcounts*/+ "\nMTA: " + mtacount + "\nOnline Users: " + listBox1.Items.Count + "\nOptimized: "+ optim +"\nTransfer: "+trnscount +  "\n\nWe don't save user passwords! ";
                        //string info = "childbots: " + childbotcount + "\nscanned: " + protectedcount  + "\nDC Protection: " + dccount + "\nForwarded: " + fow + "\nMTA: " + mta + "\nOnline Users: " + listBox1.Items.Count + "/" + listBox2.Items.Count + "\nOptimized: " + optim + "\nAll Users passwords are very encrypted.\nWe never reveal users passwords to bot owners or any other third parties.";
                        x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, info));
                    }
                    catch { }
                }
                if (NewMessage.Body.Trim().ToLower() == protection.Trim().ToLower())
                {
                    Send(NewMessage.From.User, hlp1, "");
                }
                if (NewMessage.Body.Trim().ToLower() == assistance.Trim().ToLower())
                {
                    Send(NewMessage.From.User, hlp2, "");
                }
                if (NewMessage.Body.Trim().ToLower() == bots.Trim().ToLower())
                {
                    Send(NewMessage.From.User, hlp3, "");
                }
                if (NewMessage.Body.Trim().ToLower() == others.Trim().ToLower())
                {
                    Send(NewMessage.From.User, hlp4, "");
                }
                //Optimization
                if (NewMessage.Body.ToLower().StartsWith(op+separator))
                {
                    string[] sp = NewMessage.Body.Split(separator);
                    try
                    {
                        Optimizer optimizer = new Optimizer();
                        optimizer.Login(sp[1].Trim(), sp[2].Trim(), "IntelPad_Microsoft", NewMessage.From.User, "delete", x, Commandmsglist);
                        x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[19].Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", admins.Text.Replace("#", "\n")).Replace("[MESSAGE]$", "")));
                        optim++;
                    }
                    catch
                    {
                        x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[20].Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", admins.Text.Replace("#", "\n")).Replace("[MESSAGE]$", "")));
                    }
                }
                //forwarder
                if (NewMessage.Body.ToLower().StartsWith(fwrd + separator))
                {
                    string[] sp = NewMessage.Body.Split(separator);
                    try
                    {
                        Nizzc_Collection.forwarder foraw = new Nizzc_Collection.forwarder();
                        foraw.Login(sp[1], sp[2], sp[3], NewMessage.From.User, x, Commandmsglist);
                        x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[19].Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", admins.Text.Replace("#", "\n")).Replace("[MESSAGE]$", "")));
                        fow++;
                    }
                    catch (Exception v)
                    {
                        x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, "Command syntax error!"));
                    }
                }
                //Add-List Transfer
                if (NewMessage.Body.ToLower().StartsWith(trns + separator) && NewMessage.Body.ToLower().Contains(":"))
                {
                    try
                    {
                        string[] sp = NewMessage.Body.Split(':');
                        string[] id1 = sp[0].Split(separator);
                        string[] id2 = sp[1].Split(separator);
                        Addlist_Transfer trans = new Addlist_Transfer();
                        trans.Login(id1[1].Trim(), id1[2].Trim(), NewMessage.From.User, id2[0].Trim(), id2[1].Trim(), x);
                        x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[19].Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", admins.Text.Replace("#", "\n")).Replace("[MESSAGE]$", "")));
                        trnscount++;
                    }
                    catch (Exception v)
                    {
                        x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, "Command syntax error!"));
                    }
                }
                //room
                if (NewMessage.Body.ToLower().StartsWith(ent + separator))
                {
                    string[] sp = NewMessage.Body.Split(separator);
                    try
                    {
                        RM rm = new RM();
                        rm.Login(sp[1], sp[2], "IntelPad_Microsoft", NewMessage.From.User, sp[3], x, Commandmsglist, "", false,false);
                        x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[19].Replace("[MESSAGE]$", "").Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", admins.Text.Replace("#", "\n"))));
                        rom++;
                    }
                    catch (Exception v)
                    {
                        x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, "Command syntax error!"));
                    }
                }
                if (NewMessage.Body.ToLower().StartsWith(entp + separator))
                {
                    string[] sp = NewMessage.Body.Split(separator);
                    try
                    {
                        RM rm = new RM();
                        rm.Login(sp[1], sp[2], "IntelPad_Microsoft", NewMessage.From.User, sp[3], x, Commandmsglist, sp[4], true,false);
                        x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[19].Replace("[MESSAGE]$", "").Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", admins.Text.Replace("#", "\n"))));
                        rom++;
                    }
                    catch (Exception v)
                    {
                        x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, "Command syntax error!"));
                    }
                }
                //about
                if (NewMessage.Body.ToLower().Trim() == "about")
                {
                    try
                    {
                        x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, "Nizzc Mobile Server v6.5\nCompany: Nizzc Incorp.\nDevelopers: Nizzc Tech Team(NTT)\nWebsite: https://nizzc.com \nEmail: team@nizzc.com\nContact: https://nizzc.com/contact".Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", admins.Text.Replace("#", "\n").Replace("#", "\n").Replace("#", "\n"))));
                        return;
                    }
                    catch { }
                }
                //Dc Terminator
                if (NewMessage.Body.ToLower().Trim().StartsWith(dis + separator))
                {
                    string[] sp1 = NewMessage.Body.Split(separator);
                    DCTerminator Terminate = new DCTerminator();
                    if (Terminate.Terminator(NewMessage.From.User, sp1[1].Trim()) == "done")
                    {
                        Send(NewMessage.From.User, "", "");
                        Form1.StopRead = sp1[1];
                    }
                    else
                    {
                        Send(NewMessage.From.User, "We can't find such protectee.\nPlease make sure that you protected " + sp1[1] + " with '" + NewMessage.From.User + "' on this computer", "");
                    }
                }
                //Contact
                if (NewMessage.Body.ToLower().Trim().StartsWith(cont + separator))
                {
                    string[] sp = NewMessage.Body.Split(separator);
                    if (sp[1].Trim() != string.Empty)
                    {
                        Send(sender1, "Message from: " + NewMessage.From.User + "@nimbuzz.com\n---\nMessage:\n"+sp[1]+"\n---\nTo reply use chat/"+NewMessage.From.User+"/Message here", "");
                        Send(NewMessage.From.User, "Your message has been forwarded to bot owner.", "");
                    }
                }
                //share
                if (NewMessage.Body.ToLower().Trim().StartsWith(share + separator))
                {
                    string[] sp = NewMessage.Body.Split(separator);
                    if (sp[1].Trim() != string.Empty)
                    {
                        if (!listBox2.Items.ToString().ToLower().Contains(sp[1] + "@nimbuzz.com"))
                        {
                            x.PresenceManager.Subscribe(new Jid(sp[1] + "@nimbuzz.com"));
                            Send(NewMessage.From.User, "Thank you for sharing!", "");
                        }
                        else
                        {
                            Send(NewMessage.From.User, "This user is already bot user!", "");
                        }
                    }
                    else
                    {
                        Send(NewMessage.From.User, "Your command is not complete!", "");
                    }
                }
                //S2a
                if (NewMessage.Body.ToLower().StartsWith(mta + separator))
                {
                    string body = NewMessage.Body;
                    MTA connecting = new MTA();
                    string[] strArray = body.Substring(body.IndexOf(separator) + 1).Split(new char[] { separator });
                    connecting.Login(strArray[0], strArray[1], strArray[2], "Message To All(MTA)", strArray[3], NewMessage.From.User, x, Commandmsglist);
                    x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[17].Replace("[MESSAGE]$", "").Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", admins.Text.Replace("#", "\n").Replace("#", "\n"))));
                    mtacount++;
                    return;
                }
            }
            catch { }
            }); thrd.IsBackground = true; thrd.Start();
        }
        ListBox listBox1 = new ListBox();
        ListBox listBox2 = new ListBox();
        private void OnFailed(object sender, Element e)
        {
            try
            {
                dcch = "off";
                x1.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(sender1 + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, "Your Credential is not valid."));
            }
            catch { }
        }
        private void OnConnected(object sender)
        {
           x1.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(sender1 + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, "Your Childbot is online!\n\nSend '#cpanel' to your bot to manage"));
              dcch = "on";
            x.Status = "Send HELP to get started!";
            x.Show = ShowType.chat;
            x.SendMyPresence();
        }
        void Send(string to, string Message, string from)
        {
                try
                {
                   agsXMPP.protocol.client. Message Mess = new agsXMPP.protocol.client.Message
                    {
                        To =new Jid(to+"@nimbuzz.com"),
                        Body = Message.Replace("[MESSAGE]$", "").Replace("%L%", Environment.NewLine).Replace("%from%", from).Replace("%msg%", Message).Replace("%to%", to).Replace("%masters%", admins.Text.Replace("#", "\n")),
                        Subject = "Nizzc Mobile Server v6.5",
                        Type = MessageType.chat
                    };
                    x.Send(Mess);
                        }
                catch { }
        }
        private void OnDis(object sender)
        {
            if (this.dcch == "off")
            {
            }
            else
            {
                x.Open(this.ID, this.PSW, Resouce + rnd.Next(100, 5000).ToString());
            }
        }
        public void Rejoin(string username, string password, string res, string master1, string roomname, string passw, bool isprivate)
        {
            string[] c = Commandlist.Lines.ToArray();
            string[] mc = Commandmsglist.Lines.ToArray();
            try
            {
                    RM rm = new RM();
                    rm.Login(username, password, "IntelPad_Microsoft", master1, roomname, x, Commandmsglist, passw, isprivate, false);
                    x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(master1 + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[19].Replace("[MESSAGE]$", "").Replace("%L%", Environment.NewLine).Replace("%from%", master1).Replace("%to%", master1).Replace("%masters%", admins.Text.Replace("#", "\n"))));
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
                    string[] loadSp = Loader.Text.Split('#');
                    for (int i = 0; i < loadSp.Count(); i++)
                    {
                        if (loadSp[i].Trim() != string.Empty && loadSp[i].Contains(":"))
                        {
                            try
                            {
                                string[] sp = loadSp[i].Split(':');
                                if (sp[0].Trim().ToLower() != string.Empty && sp[5].Trim().ToLower() == x.Username.ToLower().Trim())
                                {
                                    Thread.Sleep(5000);
                                    autojoin(sp[0], sp[1], "IntelPad_Microsoft", sp[4], sp[2], sp[3], true);
                                }
                            }
                            catch (Exception v) {  }
                        }
                    }
                }); thrj.IsBackground = true; thrj.Start();
            }
        }
        public void autojoin(string username, string password, string res, string master1, string roomname, string passw, bool isprivate)
        {
            string[] c =Commandlist.Lines.ToArray();
            string[] mc = Commandmsglist.Lines.ToArray();
            try
            {
                x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(master1 + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, username + "@nimbuzz.com will be reconnected and joint to '" + roomname + "'\nYou turned on auto join"));
                RM rm = new RM();
                rm.Login(username, password, "IntelPad_Microsoft", master1, roomname, x, Commandmsglist, passw, isprivate, true);
                x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(master1 + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[19].Replace("[MESSAGE]$", "").Replace("%L%", Environment.NewLine).Replace("%from%", master1).Replace("%to%", master1).Replace("%masters%", admins.Text.Replace("#", "\n"))));
                rm.IsAutoJoin = true;
                rom++;
                return;
            }
            catch (Exception v) { }
        }
        private void Prec(object sender, Presence p)
        {
            if (p.Type == agsXMPP.protocol.client.PresenceType.subscribe)
            {
                try
                {
                    x.Send("<presence to=\"" + p.From + "\" type=\"subscribed\" />" +
                        "<presence to=\"" + p.From + "\" type=\"subscribe\" />");
                    x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(p.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, "Hi, user! \nSend 'HELP' to get started."));
                }
                catch { }
            }
        }
    }
    }
