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
    class Addlist_Transfer
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
        string invalid = "";
        string time1 = "do";
        string time2 = "do";
        System.Timers.Timer optim = new System.Timers.Timer();
        private string sender1;
        private XmppClientConnection x = new XmppClientConnection();
        private XmppClientConnection y = new XmppClientConnection();
        ListBox list1 = new ListBox();
        ListBox list2 = new ListBox();
        ListBox list3 = new ListBox();
        ListBox list4 = new ListBox();
        private string Subject;
        string action1 = "";
        string analyze = "";
        Random rnd = new Random();
        Nizzc_Mobile_Ser.Form1 fo = new Nizzc_Mobile_Ser.Form1();
        XmppClientConnection x1;
        public void Login(string JID1, string PASSWORD1, string sender, string JID2, string PASSWORD2, XmppClientConnection x2)
        {
            this.ID = JID1;
            x1 = x2;
           // action1 = action;
            this.PSW = PASSWORD1;
            optim.Interval = 30000;
            this.sender1 = sender;
            System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
            try
            {
                x.Server = "nimbuzz.com";
                y.Server = "nimbuzz.com";
                x.ConnectServer = "o.nimbuzz.com";
                y.ConnectServer = "o.nimbuzz.com";
                x.Open(this.ID, this.PSW, "IntelPad_Microsoft" + rnd.Next(100, 5000).ToString());
                y.Open(JID2, PASSWORD2, "IntelPad_Microsoft" + rnd.Next(100, 5000).ToString());
                // x.Status = sts.Text;
                x.OnAuthError += new XmppElementHandler(this.OnFailed);
                y.OnAuthError += new XmppElementHandler(this.OnFailed2);
                x.OnLogin += new ObjectHandler(this.OnConnected);
                y.OnLogin += new ObjectHandler(this.OnConnected2);
                x.OnClose += new ObjectHandler(this.dc);
                x.OnPresence += new agsXMPP.protocol.client.PresenceHandler(onlineadd);
                y.OnPresence += new agsXMPP.protocol.client.PresenceHandler(onlineadd2);
                sts = "Not Available!";
                optim.Elapsed += new ElapsedEventHandler(optimizer);
            }
            catch { }
        }
        bool isComplete = false;
        string[] mc = Nizzc_Mobile_Ser.Form1.Commandmsglist.Lines;
        private void OnFailed(object sender, Element e)
        {
            Send(sender1, "ID1: Invalid Credentials");
            invalid = "disco";
        }
        //
        private void OnFailed2(object sender, Element e)
        {
            Send(sender1, "ID2: Invalid Credentials");
            invalid = "disco";
        }
        private void OnConnected(object sender)
        {
            if (invalid != "disco")
            {
                x.Show = ShowType.away;
                x.Status = sts;
                x.SendMyPresence();
                  Send(sender1, "ID1: Connected.");
                Send(sender1, "ID1: Please wait while loading Add-Lists...");
            }
            else
            {
                x.Close();
            }
        }
        private void OnConnected2(object sender)
        {
            if (invalid != "disco")
            {
                y.Show = ShowType.away;
                y.Status = sts;
                y.SendMyPresence();
                 Send(sender1, "ID2: Connected.");
                Send(sender1, "ID2: Please wait while loading Add-Lists...");
            }
            else
            {
                y.Close();
            }
        }
        void optimizer(object sender, EventArgs e)
        {
            optim.Stop();
            add();
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
        private void onlineadd(object sender, agsXMPP.protocol.client.Presence pres)
        {
            if (time1 == "do")
            {
                time1 = "";
                Send(sender1, "ID1: Comparing both IDs...");
                optim.Start();
            }
            optim.Stop();
            optim.Start();
            if (!list1.Items.ToString().ToLower().Contains(pres.From.Resource.ToLower()))
            {
                list1.Items.Add(pres.From.Bare);
            }}
        //
        private void onlineadd2(object sender, agsXMPP.protocol.client.Presence pres)
        {
            optim.Stop();
            optim.Start();
            if (time2 == "do")
            {
                time2 = "";
                Send(sender1, "ID2: Comparing both IDs...");
                optim.Start();
            }
            if (!list2.Items.ToString().ToLower().Contains(pres.From.Resource.ToLower()))
            {
                list1.Items.Add(pres.From.Bare);
            }
        }
        void add()
        {
            try
            {
                ListBox sent = new ListBox();
                ListBox matiual = new ListBox();
                Send(sender1, "Transfering...");
                if (list1.Items.Count != 0)
                {
                    for (int i = 0; i < list1.Items.Count; i++)
                    {
                        if (!list2.Items.ToString().ToLower().Contains(list1.Items[i].ToString().ToLower()))
                        {
                            sent.Items.Add(list1.Items[i]);
                            Jid jid = new Jid(list1.Items[i] + "@nimbuzz.com");
                            y.RosterManager.AddRosterItem(jid);
                            PresenceManager man = new PresenceManager(y);
                            man.Subscribe(jid);
                            Form1.transfereduserscount++;
                        }
                        else
                        {
                            matiual.Items.Add(list1.Items[i]);
                        }
                    }
                    if (!isComplete)
                    {
                        Thread thrd = new Thread(()=>{
                        isComplete = true;
                        Send(sender1, "Transfer completed");
                        Thread.Sleep(3000);
                        Send(sender1, "Disconnecting...");
                        Thread.Sleep(3000);
                        y.Close();
                        x.Close();
                        Send(sender1, "Disconnected");
                        Thread.Sleep(3000);
                        Send(sender1, "Transfered: " + sent.Items.Count + "\nAlready Existed: " + matiual.Items.Count + "\nTotal: " + list1.Items.Count);
                        Send(sender1, "It may take up-to 24hours to appear transferred Users in " + y.Username + "@nimbuzz.com");
                        }); thrd.IsBackground = true; thrd.Start();
                    }
                }
                else
                {
                    Send(sender1, "It seems that there are no new IDs  to transfer.");
                }
                return;
            }
            catch { }
            return;
        }
    }
}
