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
    class MTA
    {
        private string[] a;
        private string ID;
        private string PSW;
        private string Resouce;
        private string MTAMess;
        RichTextBox Messages = new RichTextBox();
        private string sender1;
        private XmppClientConnection x = new XmppClientConnection();
        private XmppClientConnection x1 = new XmppClientConnection();
        private listBox XmlLister;
        private string Subject;
        public void Login(string JID, string PASSWORD, string res, string sub, string MTAmess, string sender, XmppClientConnection x2, RichTextBox control)
        {
            this.ID = JID;
            Messages.Text = control.Text;
            x1 = x2;
            this.PSW = PASSWORD;
            this.Resouce = res;
            this.Subject = sub;
            this.sender1 = sender;
            this.MTAMess = MTAmess;
            System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
            try
            {
                Random rnd = new Random();
                x = new XmppClientConnection { Server = "nimbuzz.com", ConnectServer = "o.nimbuzz.com" };
                x.Open(this.ID, this.PSW, res + rnd.Next(100, 5000).ToString());
                this.x.OnAuthError += new XmppElementHandler(this.failed);
                this.x.OnLogin += new ObjectHandler(this.connected);
                this.x.OnClose += new ObjectHandler(this.dc);
                this.x.OnReadXml += new XmlHandler(this.OnXML);
                x.OnClose += new ObjectHandler(x_OnClose);
            }
            catch
            {
            }
        }
        public void x_OnClose(object sender)
        {
        }
        Random rnd = new Random();
        private void connected(object sender)
        {
            string[] mc = Messages.Lines;
            Nizzc_Mobile_Ser.Form1.mta  = Nizzc_Mobile_Ser.Form1.mta + 1;
                  x1.Send(new agsXMPP.protocol.client.Message(new Jid(this.sender1 + "@nimbuzz.com"), MessageType.chat, mc[18].Replace("[MESSAGE]$", "").Replace("%L%",Environment.NewLine)));
            x1.Send(new agsXMPP.protocol.client.Message(new Jid(this.sender1 + "@nimbuzz.com"), MessageType.chat, mc[38].Replace("[MESSAGE]$", "").Replace("%L%", Environment.NewLine)));
        }
        private void dc(object sender)
        {
        }
        private void failed(object sender, Element e)
        {
            string[] mc = Messages.Lines;
              x1.Send(new agsXMPP.protocol.client.Message(new Jid(this.sender1 + "@nimbuzz.com"), MessageType.chat, mc[24].Replace("[MESSAGE]$", "").Replace("%L%", Environment.NewLine)));
        }
        private void OnXML(object sender, string xml)
        {
            string[] mc = Messages.Lines;
            xml = Strings.Replace(xml, "\"", "'", 1, -1, CompareMethod.Text);
            if (((Strings.InStr(xml, "<query xmlns='jabber:iq:roster'>", CompareMethod.Binary) != 0)))
            {
                XmlLister = new listBox();
                this.a = xml.Split(new char[] { '<' });
                int num4 = Information.UBound(this.a, 1);
                for (int j = Information.LBound(this.a, 1); j <= num4; j++)
                {
                    if ((Strings.InStr(this.a[j], "'both'", CompareMethod.Binary) != 0))
                    {
                        string addBoth;
                        addBoth = a[j].Substring(a[j].IndexOf("jid='") + 5);
                        addBoth = addBoth.Substring(0, addBoth.IndexOf("'") - 0);
                        XmlLister.Dock = DockStyle.Top;
                        Form1 xx = new Form1();
                        XmlLister.AddItem(addBoth);
                    }
                    if ((Strings.InStr(this.a[j], "/iq>", CompareMethod.Binary) != 0))
                    {
                        if (x.Authenticated)
                        {
                            for (int i = 0; i < XmlLister.Items.Count; ++i)
                            {
                                this.x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(XmlLister.Items[i].ToString()), agsXMPP.protocol.client.MessageType.chat, MTAMess, Subject));
                                if (i == XmlLister.Items.Count - 1)
                                {
                                    x1.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(sender1 + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[39].Replace("[MESSAGE]$", "").Replace("%L%", Environment.NewLine)));
                                    x.Close();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
