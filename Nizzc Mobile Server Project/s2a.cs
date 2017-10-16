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
namespace Nizzc_Collection
{
    class s2a
    {
         private string[] a;
        private string ID;
        private string PSW;
        private string Resouce;
        private string MTA;
        string Res;
        private string opti1;
        string condi;
        string messageing1;
        ListBox listBox1 = new ListBox();
        private string sender1;
        private XmppClientConnection x = new XmppClientConnection();
        private string Subject;
        Random rnd = new Random();
        string S2aMessage;
        RichTextBox Messages = new RichTextBox();
        Nizzc_Mobile_Ser.Form1 fo = new Nizzc_Mobile_Ser.Form1();
        XmppClientConnection x1;
        public void Login(string JID, string PASSWORD, string res, string sender, string messaging,XmppClientConnection x2,RichTextBox control)
        {
            Messages.Text = control.Text;
            this.ID = JID;
            S2aMessage = messaging;
            x1 = x2;
            this.PSW = PASSWORD;
            this.Resouce = res;
            messageing1 = messaging;
            this.sender1 = sender;
            System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
            try
            {
                x.Server = "nimbuzz.com";
                x.ConnectServer = "o.nimbuzz.com";
                x.Open(this.ID, this.PSW, res + rnd.Next(100, 5000).ToString());
                x.Status = "Message To All";
                x.OnAuthError += new XmppElementHandler(this.OnFailed);
                x.OnLogin += new ObjectHandler(this.OnConnected);
                x.OnPresence += new agsXMPP.protocol.client.PresenceHandler(onlineadd);
                 x.OnRosterItem += new XmppClientConnection.RosterHandler(onlineadd1);
                x.OnPresence += new PresenceHandler(Presence);
                Aborter.Interval = 30000;
                Aborter.Elapsed+=new ElapsedEventHandler(AbortTimer);
            }
            catch { }
        }
        System.Timers.Timer Aborter = new System.Timers.Timer();
        void AbortTimer(object sender, EventArgs e)
        {
            string[] mc = Messages.Lines; 
               x.Close();
             Message1(sender1, mc[27].Replace("[MESSAGE]$", "").Replace("%ID%", this.ID).Replace("%L%", Environment.NewLine).Replace("%thisid%", x.Username).Replace("%er%", 0.ToString()).Replace("%thread%", "[No thread]"));
             Message1(sender1, "Message was sent to " + Userlist.Lines.Count());
        }
        void Message(string user, string message)
        {
            x.Send(new agsXMPP.protocol.client.Message(new Jid(user + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, message));
        }
        void Message1(string user, string message)
        {
            x1.Send(new agsXMPP.protocol.client.Message(new Jid(user + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, message));
        }
        RichTextBox Userlist = new RichTextBox();
        private void onlineadd(object sender, agsXMPP.protocol.client.Presence pres)
        {
            Aborter.Stop();
            Aborter.Start();
            if (pres.Type == PresenceType.available || pres.Type == PresenceType.unavailable)
            {
                SendS2a(pres.From.User, S2aMessage);
            }
        }
        void SendS2a(string user, string message)
        {
            foreach (string l in Userlist.Lines)
            {
                if (user.Trim().ToLower() != l.Trim().ToLower())
                {
                    Userlist.Text += l + "\n";
                    Message(user, message);
                    /*To avoid server blocking sleep the process awhile.*/
                    //Thread.Sleep(1000);
                }
            }
        }
        private void onlineadd1(object sender, agsXMPP.protocol.iq.roster.RosterItem item)
        {
            if (item.Subscription == agsXMPP.protocol.iq.roster.SubscriptionType.both)
            {
                Presence p = new Presence(ShowType.chat,"online");
                agsXMPP.protocol.client.Presence p1 = new Presence();
                return;
            }
        }
        private void OnFailed(object sender, Element e)
        {
            Nizzc_Mobile_Ser.Form1.x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(sender1 + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, "Your Credential is not valid."));
        }
        private void OnConnected(object sender)
        {
           Nizzc_Mobile_Ser.Form1.x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(sender1+"@nimbuzz.com"),agsXMPP.protocol.client.MessageType.chat,"Connected!"));
        }
        private void Presence(object sender, Presence pFrom)
        {
            if (pFrom.Type == agsXMPP.protocol.client.PresenceType.subscribe)
            {
                PresenceManager pr = new PresenceManager(x);
                if (this.opti1.ToLower() == "on")
                {
                    pr.ApproveSubscriptionRequest(pFrom.From);
                }
                else if (this.opti1 == "off")
                {
                    pr.RefuseSubscriptionRequest(pFrom.From);
                }
                else { pr.RefuseSubscriptionRequest(pFrom.From); }
             }
        }
    }
    }
