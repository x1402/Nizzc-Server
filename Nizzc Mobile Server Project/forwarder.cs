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
using Nizzc_Mobile_Ser;
namespace Nizzc_Collection
{
    class forwarder
    {
        private string[] a;
        private string ID;
        private string PSW;
        private string Resouce;
        private string MTN;
        string Res;
        string rec1;
        string passch;
        string addac;
        string sts;
        bool NotifyOnline = false;
        bool AutoAccept = true;
        bool SaveHistory = false;
        bool Isconnected = false;
        bool reconnectable = true;
        RichTextBox histroy = new RichTextBox();
        RichTextBox addeduserlist = new RichTextBox();
        RichTextBox Messages = new RichTextBox();
        private string owner;
        private XmppClientConnection x = new XmppClientConnection();
        //private listBox xxx;
        private string Subject;
        Random rnd = new Random();
        Nizzc_Mobile_Ser.Form1 fo = new Nizzc_Mobile_Ser.Form1();
        XmppClientConnection x1;
        public void Login(string JID, string PASSWORD, string res, string sender, XmppClientConnection x2, RichTextBox control)
        {
            this.ID = JID;
            x1 = x2;
            this.PSW = PASSWORD;
            this.Resouce = res;
            Messages.Text = control.Text;
            this.owner = sender;
            //this.rec1 = rec;
            disco.Elapsed += new ElapsedEventHandler(Disco);
            disco.Interval = 100;
            disco.Start();
            System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
            try
            {
                x.Server = "nimbuzz.com";
                x.ConnectServer = "o.nimbuzz.com";
                x.OnAuthError += new XmppElementHandler(this.OnFailed);
                x.OnLogin += new ObjectHandler(this.connected);
                x.OnClose += new ObjectHandler(this.OnDis);
                x.OnMessage += new MessageHandler(OnMessage);
                x.OnPresence += new agsXMPP.protocol.client.PresenceHandler(onlineadd);
                x.OnPresence += new PresenceHandler(Prec);
                x.Open(this.ID, this.PSW, res + rnd.Next(100, 5000).ToString());
            }
            catch { }
        }
        bool Selftesting = false;
        ListBox Userslist = new ListBox();
        private void onlineadd(object sender, agsXMPP.protocol.client.Presence pres)
        {
            if (pres.Type == PresenceType.available)
            {
                try
                {
                    if (!Userslist.Items.Contains(pres.From.User))
                    {
                        Userslist.Items.Add(pres.From.User);
                    }
                    if (NotifyOnline)
                    {
                        Message(owner, pres.From.User + "@nimbuzz.com is online now");
                    }
                }
                catch { }
            }
            else if (pres.Type == PresenceType.unavailable)
            {
                if (Userslist.Items.Contains(pres.From.User))
                {
                    try
                    {
                        Userslist.Items.Remove(pres.From.User);
                    }
                    catch { }
                }
                if (NotifyOnline)
                {
                    Message(owner, pres.From.User + "@nimbuzz.com is offline now");
                }
            }
            else if (pres.Type == PresenceType.unsubscribed)
            {
                if (Userslist.Items.Contains(pres.From.User))
                {
                    try
                    {
                        Userslist.Items.Remove(pres.From.User);
                    }
                    catch { }
                }
                if (NotifyOnline)
                {
                    Message(owner, pres.From.User + "@nimbuzz.com deleted you from his contacts.");
                }
            }
        }
        void Message(string ToUser, string ThisMessage)
        {
            string[] mc = Messages.Lines;
            x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(ToUser + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, ThisMessage.Replace("[MESSAGE]$", "").Replace("%L%", Environment.NewLine).Replace("%msg%", ThisMessage).Replace("%to%", ToUser).Replace("%masters%", owner)));                    
        }
        private void OnMessage(object sender, agsXMPP.protocol.client.Message NewMessage)
        {
            if (NewMessage.Type == MessageType.error || NewMessage.Type == null)
                return;
            else
            {
                Thread thre = new Thread(() =>
                {
                    try
                    {
                        string[] mc = Messages.Lines;
                        if (NewMessage.Type == MessageType.chat)
                        {
                            if (NewMessage.Body.Trim() != string.Empty)
                            {
                                if (NewMessage.From.User.ToLower().Trim() != owner.ToLower().Trim())
                                {
                                    x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(owner + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[35].Replace("[MESSAGE]$", "").Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", owner).Replace("%time%", DateTime.Now.ToString())));
                                }
                                if (NewMessage.From.User.ToLower().Trim() == owner.ToLower().Trim() &&Selftesting)
                                {
                                    x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(owner + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[35].Replace("[MESSAGE]$", "").Replace("%L%", Environment.NewLine).Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%to%", NewMessage.From.User).Replace("%masters%", owner).Replace("%time%", DateTime.Now.ToString())));
                                }
                            }
                            if (NewMessage.From.User == owner)
                            {
                                //stop
                                if (NewMessage.Body.ToLower().StartsWith("#logout"))
                                {
                                    reconnectable = false;
                                    x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[27].Replace("[MESSAGE]$", "")));
                                    x.Close();
                                }
                                if (NewMessage.Body.Trim().ToLower().StartsWith("add#"))
                                {
                                    PresenceManager presx = new PresenceManager(x);
                                    string[] sp = NewMessage.Body.Split('#');
                                    try
                                    {
                                        if (sp[1].Trim() != string.Empty)
                                        {
                                            Jid jid = new Jid(sp[1] + "@nimbuzz.com");
                                            x.RosterManager.AddRosterItem(jid);
                                            presx.Subscribe(jid);
                                            Message(owner, "Friend request was sent to '" + jid + "' and you will be notified he/she acceptes.");
                                        }
                                        else
                                        {
                                            Message(owner, "Command syntax error!");
                                        }
                                    }
                                    catch
                                    {
                                        Message(owner, "Command syntax error!");
                                    }
                                }
                                if (NewMessage.Body.Trim().ToLower().StartsWith("del#"))
                                {
                                    PresenceManager presx = new PresenceManager(x);
                                    string[] sp = NewMessage.Body.Split('#');
                                    try
                                    {
                                        if (sp[1].Trim() != string.Empty)
                                        {
                                            Jid jid = new Jid(sp[1] + "@nimbuzz.com");
                                            x.RosterManager.RemoveRosterItem(jid);
                                            presx.Unsubscribe(jid);
                                            Message(owner, "'" + jid + "' is deleted.");
                                            Userslist.Items.Remove(jid);
                                            x.RequestRoster();
                                        }
                                        else
                                        {
                                            Message(owner, "Command syntax error!");
                                        }
                                    }
                                    catch
                                    {
                                        Message(owner, "Command syntax error!");
                                    }
                                }
                                //reply
                                if (NewMessage.Body.ToLower().StartsWith("chat/"))
                                {
                                    if (NewMessage.From.User == owner)
                                    {
                                        string[] sp = NewMessage.Body.Split('/');
                                        try
                                        {
                                            x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(sp[1] + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, sp[2]));
                                            x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[36].Replace("[MESSAGE]$", "").Replace("%to%", sp[1]).Replace("%L%", Environment.NewLine)));
                                        }
                                        catch { Message(NewMessage.From.User, "Command syntax error!"); }
                                    }
                                    else
                                    {
                                        x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(owner + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, NewMessage.Body));
                                    }
                                }
                                //status
                                if (NewMessage.Body.Trim() != string.Empty && NewMessage.From.User.ToLower() == owner.ToLower())
                                {
                                    switch (NewMessage.Body.ToLower().Trim())
                                    {
                                        case "#online":
                                            {
                                                x.Status = sts;
                                                x.SendMyPresence();
                                                x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(owner + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[42].Replace("[MESSAGE]$", "").Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%L%", Environment.NewLine).Replace("%sts%","online").Replace("%thisid%", ID)));
                                                break;
                                            }
                                        case "#away":
                                            {
                                                x.Show = ShowType.away;
                                                x.Status = sts;
                                                x.SendMyPresence();
                                                x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(owner + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[42].Replace("[MESSAGE]$", "").Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%L%", Environment.NewLine).Replace("%sts%","away").Replace("%thisid%", ID).Replace("%to%", NewMessage.From.User.Remove(0))));
                                                break;
                                            }
                                        case "#busy":
                                            {
                                                x.Show = ShowType.dnd;
                                                x.Status = sts;
                                                x.SendMyPresence();
                                                x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(owner + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[42].Replace("[MESSAGE]$", "").Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%L%", Environment.NewLine).Replace("%sts%", "busy").Replace("%thisid%", ID).Replace("%to%", NewMessage.From.User.Remove(0))));
                                                break;
                                            }
                                        case "+test":
                                            {
                                                Selftesting = true;
                                                Message(owner, "Self Testing is turned on");
                                                break;
                                            }
                                        case "-test":
                                            {
                                                Selftesting = false;
                                                Message(owner, "Self Testing is turned off");
                                                break;
                                            }
                                        case "+autoaccept":
                                            {
                                                AutoAccept = true;
                                                Message(owner, "Auto friend request accept is turned on");
                                                break;
                                            }
                                        case "-autoaccept":
                                            {
                                                AutoAccept = false ;
                                                Message(owner, "Auto friend request accept is turned off");
                                                break;
                                            }
                                        case "+notify":
                                            {
                                                NotifyOnline = true;
                                                Message(owner, "Online Notifier is turned on");
                                                break;
                                            }
                                        case "-notify":
                                            {
                                                NotifyOnline = false ;
                                                Message(owner, "Online Notifier is turned off");
                                                break;
                                            }
                                        case "#cpanel":
                                            {
                                                Message(owner, Form1.Fhelp.Replace("%master%", owner));
                                                break;
                                            }
                                        case "#users":
                                            {
                                                Message(owner,"\nOnline users list:\n" +Listout());
                                                break;
                                            }
                                        case "#accept":
                                            {
                                                int count = 0;
                                                if (addeduserlist.Text.Trim() != string.Empty)
                                                {
                                                    PresenceManager presx = new PresenceManager(x);
                                                    foreach (string l in addeduserlist.Lines)
                                                    {
                                                        if (l.Trim() != string.Empty)
                                                        {
                                                            try
                                                            {
                                                                Jid jid = new Jid(l + "@nimbuzz.com");
                                                                x.RosterManager.AddRosterItem(jid);
                                                                presx.Subscribe(jid);
                                                                presx.ApproveSubscriptionRequest(jid);
                                                                count++;
                                                                Message(owner, jid + " is accepted");
                                                            }
                                                            catch { }
                                                        }
                                                    }
                                                    addeduserlist.Clear();
                                                }
                                                else
                                                {
                                                    Message(owner, "No friend request sent.");
                                                }
                                                break;
                                            }
                                        default:
                                            {
                                                      break;
                                            }
                                    }
                                }
                                if (NewMessage.Body.ToLower().StartsWith("stm#") && NewMessage.From.User == owner)
                                {
                                    string[] sp = NewMessage.Body.Split('#');
                                    x.Status = sp[1];
                                    sts = sp[1];
                                    x.SendMyPresence();
                                    x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(owner + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[43].Replace("[MESSAGE]$", "").Replace("%from%", NewMessage.From.User).Replace("%msg%", NewMessage.Body).Replace("%L%", Environment.NewLine).Replace("%stm%", sts).Replace("%thisid%", ID).Replace("%to%", NewMessage.From.User)));
                                }
                            }
                        }
                    }
                    catch (Exception v) {  }
                }); thre.IsBackground = true; thre.Start();
            }
        }
        public string  Listout()
        {
            string Lists = "";
            for (int i = 0; i < Userslist.Items.Count; i++)
            {
                Lists += Userslist.Items[i]+"@nimbuzz.com" + "\n";
            }
            return Lists;
        }
        private void OnFailed(object sender, Element e)
        {
            try
            {
                string[] mc = Messages.Lines;
                x1.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(owner + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[24].Replace("[MESSAGE]$", "").Replace("%ID%", this.ID).Replace("%L%", Environment.NewLine).Replace("%thisid%", x.Username).Replace("%er%", "[No error]").Replace("%thread%", "[No thread]").Replace("%IP%", "[No IP]")));//mc[30].Replace("[MESSAGE]$", "")
                reconnectable = false;
            }
            catch { }
        }
        private void connected(object sender)
        {
            if (!Isconnected)
            {
                Thread thre = new Thread(() =>
                {
                    try
                    {
                        Isconnected = true;
                        x.Status = "Online via Nimbuzz!";
                        sts = x.Status;
                        x.Show = ShowType.chat;
                        x.SendMyPresence();
                        string[] mc = Messages.Lines;
                        x1.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(owner + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[34].Replace("[MESSAGE]$", "").Replace("%ID%", this.ID).Replace("%L%", Environment.NewLine).Replace("%thisid%", x.Username).Replace("%er%", "[No error]").Replace("%thread%", "[No thread]").Replace("%IP%", "[No IP]").Replace("%user%",owner)));
                    }
                    catch (Exception v) {  }
                }); thre.IsBackground = true; thre.Start();
            }
        }
        private void OnDis(object sender)
        {
            if (reconnectable)
            {
                try
                {
                    x.Open(this.ID, this.PSW, Resouce + rnd.Next(100, 5000).ToString());
                }
                catch { }
            }
        }
         System.Timers.Timer disco = new System.Timers.Timer();
        void Disco(object sender, EventArgs e)
        {
        }
        private void Prec(object sender, Presence p)
        {
            if (p.Type == agsXMPP.protocol.client.PresenceType.subscribe)
            {
                PresenceManager OnUser = new PresenceManager(x);
                if (AutoAccept)
                {
                    try
                    {
                        Message(owner, p.From.User + " sent you a friend request.");
                        OnUser.ApproveSubscriptionRequest(p.From);
                        Message(owner, p.From.User + " is accepted now");
                       }
                    catch { }
                }
                else
                {
                    try
                    {
                        Message(owner, p.From.User + " sent you a friend request.");
                        addeduserlist.Text += p.From.User + "\n";
                    }
                    catch { }
                }
            }
            else if (p.Type == PresenceType.subscribed)
            {
                Message(owner, p.From.User + "@nimbuzz.com accepted your friend request.");
            }
            else if (p.Type == PresenceType.unsubscribed)
            {
               // Message(owner, "" + p.From.User + "@nimbuzz.com has deleted you from his/her friend list.");
            }
        }
    }
    }
