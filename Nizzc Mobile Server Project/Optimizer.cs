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
using Nizzc_Collection;
using Nizzc_Mobile_Ser;
namespace Nizzc_Collection
{
    class Optimizer
    {
        private string[] a;
        private string ID;
        private string PSW;
        private string Resouce;
        private string Mt;
        string Res;
        string rec1;
        string passch;
        string addac;
        string sts;
        System.Timers.Timer optim = new System.Timers.Timer();
        private string sender1;
        private XmppClientConnection x = new XmppClientConnection();
        private string Subject;
        string action1 = "";
        string analyze = "";
        Random rnd = new Random();
         RichTextBox Messages = new RichTextBox();
        Nizzc_Mobile_Ser.Form1 fo = new Nizzc_Mobile_Ser.Form1();
        XmppClientConnection x1;
        public void Login(string JID, string PASSWORD, string res, string sender,string action, XmppClientConnection x2, RichTextBox control)
        {
            this.ID = JID;
            x1 = x2;
            Messages.Text = control.Text;
            action1 = action;
            this.PSW = PASSWORD;
            this.Resouce = res;
            this.sender1 = sender;
            //this.rec1 = rec;
            System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
            try
            {
                x.Server = "nimbuzz.com";
                x.ConnectServer = "o.nimbuzz.com";
                x.Open(this.ID, this.PSW, res + rnd.Next(100, 5000).ToString());
                // x.Status = sts.Text;
                x.OnAuthError += new XmppElementHandler(this.OnFailed);
                x.OnLogin += new ObjectHandler(this.connected);
                x.OnClose += new ObjectHandler(this.dc);
                x.OnPresence += new agsXMPP.protocol.client.PresenceHandler(onlineadd);
                x.OnReadXml += new XmlHandler(Xml1);
                x.OnRosterEnd += new ObjectHandler(OnRosterEnd); 
                sts = "Hi I'm here!";
                optim.Elapsed += new ElapsedEventHandler(optimizer);
                optim.Interval = 10000;
            }
            catch { }
        }
        ListBox list1 = new ListBox();
        ListBox list2 = new ListBox();
        ListBox list3 = new ListBox();
        ListBox list4 = new ListBox();
        private void OnFailed(object sender, Element e)
        {
            string[] mc = Messages.Lines;
            x1.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(sender1 + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[24].Replace("[MESSAGE]$", "").Replace("%L%", Environment.NewLine)));//mc[30].Replace("[MESSAGE]$", "")
        }
        private void Xml1(object sender, String Xml1)
        {
        }
        private void connected(object sender)
        {
            try
            {
                string[] mc = Messages.Lines;
               // Form1.optim++;
                x.Show = ShowType.NONE;
                x.SendMyPresence();
                x1.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(sender1 + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[18].Replace("[MESSAGE]$", "").Replace("%ID%", this.ID).Replace("%L%", Environment.NewLine)));
            }
            catch (Exception m)
            {
            }
        }
        void optimizer(object sender, EventArgs e)
        {
            optim.Stop();
            delete();
        }
        private void dc(object sender)
        {
            if (this.passch == "off")
            {
            }
            else
            {
            }
        }
        void Send(string iD, string MessagE)
        {
            x1.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(iD + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, MessagE));
            return;
        }
        string time = "do";
        //On roster end
         void OnRosterEnd(object sender)
        {
            Thread thrd = new Thread(() =>
            {
                Thread.Sleep(10000);
                delete();
            }); thrd.IsBackground = true; thrd.Start();
         }
         int init = 0;
        private void onlineadd(object sender, agsXMPP.protocol.client.Presence pres)
        {
            try
            {
                init++;
                optim.Stop();
                if (time == "do")
                {
                    try
                    {
                        string[] mc = Messages.Lines;
                        time = "";
                        Send(sender1, mc[59].Replace("[MESSAGE]$", "").Replace("%ID%", this.ID).Replace("%L%", Environment.NewLine).Replace("%thisid%", x.Username).Replace("%er%", "[No error]"));
                    }
                    catch { }
                }
                try{
               if (!list1.Items.ToString().ToLower().Contains(pres.From.Resource.ToLower()))
                {
                    list1.Items.Add(pres.From.Bare);
                }
                }
                catch { }
                //Length
                try{
                if (pres.From.User.Length > 20)
                {
                    if (!list2.Items.ToString().ToLower().Contains(pres.From.Resource.ToLower()))
                    {
                        list2.Items.Add(pres.From.Bare);
                    }
                }
                }
                catch { }
                //Unsubscribed
                try{
                if (pres.Type == PresenceType.unsubscribed)
                {
                    if (!list3.Items.ToString().ToLower().Contains(pres.From.Resource.ToLower()))
                    {
                        list3.Items.Add(pres.From.Bare);
                    }
                }
                }
                catch { }
                try{
                if (pres.Type == PresenceType.error)
                {
                    if (!list4.Items.ToString().ToLower().Contains(pres.From.Resource.ToLower()))
                    {
                        list4.Items.Add(pres.From.Bare);
                    }
                }
                }
                catch { }
            }
            catch (Exception v) { Send(sender1, "1\n"+v.ToString()); }
            //return;
        }
        void RosterEnd()
        {
        }
        void delete()
        {
            Thread thrf = new Thread(() =>
            {
                try
                {
                    //Send(sender1, "1");
                    string[] mc = Messages.Lines;
                    Send(sender1, mc[60].Replace("[MESSAGE]$", "").Replace("%ID%", this.ID).Replace("%L%", Environment.NewLine).Replace("%thisid%", x.Username).Replace("%er%", "[No error]").Replace("%thread%", "[No thread]"));
                    Thread.Sleep(5000);                    
                    if (list4.Items.Count != 0)
                    {
                        Send(sender1, mc[62].Replace("[MESSAGE]$", "").Replace("%ID%", this.ID).Replace("%L%", Environment.NewLine).Replace("%thisid%", x.Username).Replace("%er%", list4.Items.Count.ToString()).Replace("%thread%", "[No thread]"));
                        Send(sender1, mc[63].Replace("[MESSAGE]$", "").Replace("%ID%", this.ID).Replace("%L%", Environment.NewLine).Replace("%thisid%", x.Username).Replace("%er%", list4.Items.Count.ToString()).Replace("%thread%", "[No thread]"));
                        //Error
                        for (int i = 0; i < list4.Items.Count; i++)
                        {
                            Jid acco = new Jid(list4.Items[i].ToString());
                            PresenceManager manager = new PresenceManager(x);
                            manager.Unsubscribe(acco);
                            x.RosterManager.RemoveRosterItem(acco);
                        }
                    }
                    else
                    {
                        Send(sender1, mc[64].Replace("[MESSAGE]$", "").Replace("%ID%", this.ID).Replace("%L%", Environment.NewLine).Replace("%thisid%", x.Username).Replace("%er%", list4.Items.Count.ToString()).Replace("%thread%", "[No thread]"));
                    }
                    Send(sender1, mc[65].Replace("[MESSAGE]$", "").Replace("%ID%", this.ID).Replace("%L%", Environment.NewLine).Replace("%thisid%", x.Username).Replace("%er%", list2.Items.Count.ToString()).Replace("%thread%", "[No thread]"));
                    Thread.Sleep(5000);                   
                    //Length
                    if (list2.Items.Count != 0)
                    {
                        Send(sender1, mc[62].Replace("[MESSAGE]$", "").Replace("%ID%", this.ID).Replace("%L%", Environment.NewLine).Replace("%thisid%", x.Username).Replace("%er%", list2.Items.Count.ToString()).Replace("%thread%", "[No thread]"));
                        Send(sender1, mc[63].Replace("[MESSAGE]$", "").Replace("%ID%", this.ID).Replace("%L%", Environment.NewLine).Replace("%thisid%", x.Username).Replace("%er%", list2.Items.Count.ToString()).Replace("%thread%", "[No thread]"));
                        for (int i = 0; i < list2.Items.Count; i++)
                        {
                            Jid acco = new Jid(list2.Items[i].ToString());
                            PresenceManager manager = new PresenceManager(x);
                            manager.Unsubscribe(acco);
                            x.RosterManager.RemoveRosterItem(acco);
                        }
                    }
                    else
                    {
                        Send(sender1, mc[64].Replace("[MESSAGE]$", "").Replace("%ID%", this.ID).Replace("%L%", Environment.NewLine).Replace("%thisid%", x.Username).Replace("%er%", list2.Items.Count.ToString()).Replace("%thread%", "[No thread]"));
                    }
                    Send(sender1, mc[66].Replace("[MESSAGE]$", "").Replace("%ID%", this.ID).Replace("%L%", Environment.NewLine).Replace("%thisid%", x.Username).Replace("%er%", list3.Items.Count.ToString()).Replace("%thread%", "[No thread]"));
                    Thread.Sleep(5000);
                    //Non-subcribtion
                    if (list3.Items.Count != 0)
                    {
                        Send(sender1, mc[62].Replace("[MESSAGE]$", "").Replace("%ID%", this.ID).Replace("%L%", Environment.NewLine).Replace("%thisid%", x.Username).Replace("%er%", list3.Items.Count.ToString()).Replace("%thread%", "[No thread]"));
                        Send(sender1, mc[63].Replace("[MESSAGE]$", "").Replace("%ID%", this.ID).Replace("%L%", Environment.NewLine).Replace("%thisid%", x.Username).Replace("%er%", list3.Items.Count.ToString()).Replace("%thread%", "[No thread]"));
                        for (int i = 0; i < list3.Items.Count; i++)
                        {
                            Jid acco = new Jid(list3.Items[i].ToString());
                            PresenceManager manager = new PresenceManager(x);
                            manager.Unsubscribe(acco);
                            x.RosterManager.RemoveRosterItem(acco);
                        }
                    }
                    else
                    {
                        Send(sender1, mc[64].Replace("[MESSAGE]$", "").Replace("%ID%", this.ID).Replace("%L%", Environment.NewLine).Replace("%thisid%", x.Username).Replace("%er%", list3.Items.Count.ToString()).Replace("%thread%", "[No thread]"));
                    }
                    if (list2.Items.Count == 0 && list3.Items.Count == 0 && list4.Items.Count == 0)
                    {
                        Send(sender1, mc[67].Replace("[MESSAGE]$", "").Replace("%ID%", this.ID).Replace("%L%", Environment.NewLine).Replace("%thisid%", x.Username).Replace("%er%", 0.ToString()).Replace("%thread%", "[No thread]"));
                    }
                    else
                    {
                        Send(sender1, mc[61].Replace("[MESSAGE]$", "").Replace("%ID%", this.ID).Replace("%L%", Environment.NewLine).Replace("%thisid%", x.Username).Replace("%er%", 0.ToString()).Replace("%thread%", "[No thread]"));
                    }
                    Thread.Sleep(5000);
                    Send(sender1, mc[71].Replace("[MESSAGE]$", "").Replace("%ID%", this.ID).Replace("%L%", Environment.NewLine).Replace("%thisid%", x.Username).Replace("%er%", 0.ToString()).Replace("%thread%", "[No thread]"));
                    Thread.Sleep(5000);
                    x.Close();
                    Send(sender1, mc[27].Replace("[MESSAGE]$", "").Replace("%ID%", this.ID).Replace("%L%", Environment.NewLine).Replace("%thisid%", x.Username).Replace("%er%", 0.ToString()).Replace("%thread%", "[No thread]"));
                    Thread.Sleep(3000);
                    if (list2.Items.Count == 0 && list3.Items.Count == 0 && list4.Items.Count == 0)
                    {
                    }
                    else
                    {
                        if (sender1 == x.Username)
                        {
                            Send(sender1, mc[68].Replace("[MESSAGE]$", "").Replace("%ID%", this.ID).Replace("%L%", Environment.NewLine).Replace("%thisid%", x.Username).Replace("%er%", 0.ToString()).Replace("%thread%", "[No thread]"));
                        }
                        else
                        {
                            Send(sender1, mc[69].Replace("[MESSAGE]$", "").Replace("%ID%", this.ID).Replace("%L%", Environment.NewLine).Replace("%thisid%", x.Username).Replace("%er%", 0.ToString()).Replace("%thread%", "[No thread]"));
                        }
                    }
                    return;
                }
                catch (Exception v) { Send(sender1, "Unexpected error has occured. Please try again."); }
            }); thrf.IsBackground = true; thrf.Start();
        }
    }
}
