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
namespace Nizzc_Mobile_Ser
{
    class RS2a
    {
        private string[] a;
        private string ID;
        private string PSW;
        private string Resouce;
        private string MTAP;
        private string sender1;
        private XmppClientConnection x = new XmppClientConnection();
        private listBox xmlLister;
        private string Subject;
        public void Login(string JID, string PASSWORD, string res, string sub, string MtaS2A, string sender)
        {
            this.ID = JID;
            this.PSW = PASSWORD;
            this.Resouce = res;
            this.Subject = sub;
            this.sender1 = sender;
            this.MTAP = MtaS2A;
            System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
            try
            {
                Random rnd = new Random();
                x = new XmppClientConnection { Server = "nimbuzz.com", ConnectServer = "o.nimbuzz.com" };
                x.Open(this.ID, this.PSW, res + rnd.Next(100, 5000).ToString());
                this.x.OnAuthError += new XmppElementHandler(this.OnFailed);
                this.x.OnLogin += new ObjectHandler(this.OnConnected);
                this.x.OnClose += new ObjectHandler(this.dc);
                this.x.OnReadXml += new XmlHandler(this.OnXml);
                Nizzc_Collection.loading ld = new Nizzc_Collection.loading();
                ld.info("Connecting...");
            }
            catch
            {
            }
        }
        string[] mc = Nizzc_Mobile_Ser.Form1.Commandmsglist.Lines;
        Random rnd = new Random();
        private void OnConnected(object sender)
        {
            Nizzc_Collection.loading ld = new Nizzc_Collection.loading();
            ld.info("Connected... Loading AddList.");
            Nizzc_Mobile_Ser.Form1.mta = Nizzc_Mobile_Ser.Form1.mta + 1;
           }
        private void dc(object sender)
        {
        }
        private void OnFailed(object sender, Element e)
        {
            Nizzc_Collection.loading ld = new Nizzc_Collection.loading();
            ld.info("Invalid Username or password.");
                   }
        private void OnXml(object sender, string xml)
        {
            xml = Strings.Replace(xml, "\"", "'", 1, -1, CompareMethod.Text);
            if (((Strings.InStr(xml, "<query xmlns='jabber:iq:roster'>", CompareMethod.Binary) != 0)))
            {
                xmlLister = new listBox();
                this.a = xml.Split(new char[] { '<' });
                int num4 = Information.UBound(this.a, 1);
                for (int j = Information.LBound(this.a, 1); j <= num4; j++)
                {
                    if ((Strings.InStr(this.a[j], "'both'", CompareMethod.Binary) != 0))
                    {
                        string addBoth;
                        addBoth = a[j].Substring(a[j].IndexOf("jid='") + 5);
                        addBoth = addBoth.Substring(0, addBoth.IndexOf("'") - 0);
                        xmlLister.Dock = DockStyle.Top;
                        Form1 xx = new Form1();
                        xmlLister.AddItem(addBoth);
                        Nizzc_Collection.loading ld = new Nizzc_Collection.loading();
                        ld.info("Loaded AddList: "+xmlLister.Items.Count );
                    }
                    if ((Strings.InStr(this.a[j], "/iq>", CompareMethod.Binary) != 0))
                    {
                        if (x.Authenticated)
                        {
                            Nizzc_Collection.loading ld = new Nizzc_Collection.loading();
                            for (int i = 0; i < xmlLister.Items.Count; ++i)
                            {
                                this.x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(xmlLister.Items[i].ToString()), agsXMPP.protocol.client.MessageType.chat, MTAP, Subject));
                                  ld.info("Message sent to: "+xmlLister.Items[i] +"("+i+"/"+xmlLister.Items.Count+")");
                                ld.info(xmlLister.Items.Count, i);
                                if (i == xmlLister.Items.Count - 1)
                                {
                                    Form1.x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(sender1 + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[39].Replace("[MESSAGE]$", "").Replace("%L%", Environment.NewLine)));
                                    x.Close();
                                    ld.info("Message is sent to "+xmlLister.Items.Count+" Users");
                                    Nizzc_Collection.loading ldg = new Nizzc_Collection.loading();
                                    ldg.Sent();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
