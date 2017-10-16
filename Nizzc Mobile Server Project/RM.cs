using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Xml;
using agsXMPP;
using agsXMPP.Collections;
using agsXMPP.protocol.client;
using agsXMPP.util;
using agsXMPP.Xml.Dom;
using Nizzc_Collection;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Nizzc_Mobile_Ser;
using System.Configuration;
using System.Security.Cryptography;
namespace Nizzc_Collection
{
    class RM
    {
        private string[] a;
        private string ID;
        private string PSW;
        private string Resouce;
        private string MTA;
        string Res;
        string rec1;
        string passch = "on";
        string addac;
        string TempoWlOFF = "off";
        bool AlreadyConnected = false;
        string sts;
        bool Isrejoin = true;
        bool IsFlood = false;
        private string username;
        private string password;
        private string resource;
        private string roomname;
        string SelfProtection = "on";
        private string master;
        string LineFiltermanage = "off";
        int LineFilterlen = 20;
        int SoccerRandomint=0;
        string QuizQuestion = "";
        int QuizQuestionNumber = 1;
        string QuizQuestionAnswer = "";
        //int QuizScore = 50;
        private char cChar = '/';
        string Transfermanage = "on";
        string floodmanage = "on";
        string reconizemanage = "on";
        string quizmanage = "on";
        int QuizInterval = 10000;
        int QuizAbortCounter = 60000;
        string gamekickmanage = "off";
        string gamemanage = "on";
        string antikickmanage = "on";
        string resfiltermanage = "off";
        string idfiltermanage = "on";
        string msgfiltermanage = "on";
        string badlanguagemanage = "on";
        string roomlockmanage = "on";
        string wlmanage = "off";
        string userHelp = "*Nizzc Mobile Server v6.5*\nHi %user%, you can find me in %room%@conference.nimbuzz.com. There are lots of games, quizes and user intertaiment things.\n\nYou can send HELP in room to see commands available for you.\n\nSend #KICKME to kick your self from this room if you hanged there.\n\n https://nizzc.com";
        string antikickmsg="For everyone, Send HELP to see commands available for you!\nTo change this message use AKCMSG#YOUR_MESSAGE_HERE";
        string badlmsg;
        string roomlockpass;
        string recognizerwords;
        string Roomname1;
        string catchh;
        string mutemanage;
        string king;
        string thief;
        string polc;
        string warningMessa = "Dear user using bad-languages can cause privilege nullification. Please don't use such words again.";
        string witnesser;
        int idlength = 50;
        int msglength = 160;
        int gamekick;
        int reslength = 60;
        int roomlock;
        int QuizScore = 60;
        int SoccerScoreWin = 50;
        int SoccerScoreSame = 5;
        int ShoutScore = 10;
        int LuckyScore = 20;
        int PoliceScore = 50;
        int PoliceMiss = 25;
        string MemberByMembermanage = "off";
        string SelfSoccerPenaltyManage = "off";
        int LuckyTimerCount = 20000;
        int QuizRepeatCounter = 10000;
        int antikickcounter = 60000;
        string wlmsgholder = "hi  welcome ";
        int luckynumber;
        string wordfiltermanage;
        string luckymanager = "off";
        string dcch;
        string LuckyMsg = "";
        string BotkickedMsg = "";
        string policemanager = "on";
        string Shoutmanage = "off";
        string Shoutword = "u";
        string  kicker = "";
        string kicker1 = "";
        string kicker2 = "";
        int Score1 = 0;
        int Score2 = 0;
        string QuizAskibleOption = "off";
        string ShoutNot = "off";
        string ShoutMsg = "Who can write faster this %L%'%num%'%L%to win %amount%";
        int ShoutTimerCount = 10000;
        int SoccerKickNumber = 0;
        string soccermanage = "on";
        string silecncemanage = "off";
        string autobanmanage = "off";
        string autokickmanage = "off";
        string automutemanage = "off";
        string autovisitor = "off";
        string automember = "off";
        string adminmodSkipper = "on";
        string SmartDetmanage = "on";
        string statusfiltermanage = "on";
        int statusfilterlength = 50;
        string AutoAddManage = "off";
        string SmartDet = "on";
        string reportmanage = "on";
        string autoinvitemanage = "off";
        string lovemanage = "on";
        string autoaddmanage = "off";
        string SoccerKicker = "";
        string anticapitalmanage = "off";
        string capitalaction="0";
        string jokemanage = "off";
        int jokeinterval = 20000;
        string LuckyNot = "on";
        string bombmanage = "on";
        string bombprotecmanage = "on";
        int bombcost = 750;
        int bombprotectcost=500;
        string autoIPbanmanage = "off";
        string forbiddenjidaction = "0";
        string YesNo;
        string CapitacMsg = "\n>> %user%: Capital words are not allowed in this room";
        System.Windows.Forms.RichTextBox wordlist = new System.Windows.Forms.RichTextBox();
        System.Windows.Forms.RichTextBox reportlist = new System.Windows.Forms.RichTextBox();
        System.Windows.Forms.RichTextBox ownerlist = new System.Windows.Forms.RichTextBox();
        System.Windows.Forms.RichTextBox badlinks = new System.Windows.Forms.RichTextBox();
        System.Windows.Forms.RichTextBox wlcmsgholderlist = new System.Windows.Forms.RichTextBox();
        System.Windows.Forms.RichTextBox SoccerPlaying = new System.Windows.Forms.RichTextBox();
        System.Windows.Forms.RichTextBox SoccerAwaiting = new System.Windows.Forms.RichTextBox();
        System.Windows.Forms.RichTextBox SoccerAccepteds = new System.Windows.Forms.RichTextBox();
        System.Windows.Forms.RichTextBox badstatuslist = new System.Windows.Forms.RichTextBox();
        System.Windows.Forms.RichTextBox BombList = new System.Windows.Forms.RichTextBox();
        System.Windows.Forms.RichTextBox BombProtectList = new System.Windows.Forms.RichTextBox();
        System.Windows.Forms.RichTextBox Backuplist = new System.Windows.Forms.RichTextBox();
        System.Windows.Forms.RichTextBox Messages = new System.Windows.Forms.RichTextBox();
        Timer SoccerAbortTimer = new Timer();
        string muter;
        System.Windows.Forms.RichTextBox badreslist = new System.Windows.Forms.RichTextBox();
        System.Windows.Forms.RichTextBox formbiddenuserslist = new System.Windows.Forms.RichTextBox();
        System.Windows.Forms.RichTextBox badjidlist = new System.Windows.Forms.RichTextBox();
        System.Windows.Forms.ListBox linkify = new System.Windows.Forms.ListBox();
        System.Windows.Forms.RichTextBox recognizedw = new System.Windows.Forms.RichTextBox();
        System.Windows.Forms.RichTextBox policthiftlistbox = new System.Windows.Forms.RichTextBox();
        System.Windows.Forms.RichTextBox policeacceptedlist = new System.Windows.Forms.RichTextBox();
        System.Windows.Forms.RichTextBox soccerlist = new System.Windows.Forms.RichTextBox();
        System.Windows.Forms.RichTextBox idfilterlist = new System.Windows.Forms.RichTextBox();
        System.Windows.Forms.RichTextBox badla = new System.Windows.Forms.RichTextBox();
        System.Windows.Forms.ListBox soccerlistbot = new System.Windows.Forms.ListBox();
        System.Windows.Forms.ListBox shootlishtbox = new System.Windows.Forms.ListBox();
        System.Windows.Forms.ListBox thinklistbox = new System.Windows.Forms.ListBox();
        System.Windows.Forms.ListBox wheelingluckylistbox = new System.Windows.Forms.ListBox();
        System.Windows.Forms.ListBox userslist = new System.Windows.Forms.ListBox();
        System.Windows.Forms.ListBox wholeusers = new System.Windows.Forms.ListBox();
        System.Windows.Forms.RichTextBox  Restorelist = new System.Windows.Forms.RichTextBox();
        System.Timers.Timer policetimer = new System.Timers.Timer();
        System.Timers.Timer soccertimer = new System.Timers.Timer();
        System.Timers.Timer shoottimer = new System.Timers.Timer();
        Timer thinktimer = new Timer();
        Timer ShoutTimer = new Timer();
        Timer wheelingluckytimer = new Timer();
        Timer policeduration = new Timer();
        System.Windows.Forms.RichTextBox adminlist = new System.Windows.Forms.RichTextBox();
        System.Windows.Forms.ListBox badllanglist;
        System.Windows.Forms.RichTextBox luckylist = new System.Windows.Forms.RichTextBox();
        System.Windows.Forms.RichTextBox luckylist1 = new System.Windows.Forms.RichTextBox();
        System.Windows.Forms.RichTextBox acceptedusers = new System.Windows.Forms.RichTextBox();
        System.Windows.Forms.RichTextBox BombedUserList = new System.Windows.Forms.RichTextBox();
        AppDomain CurrentDom = AppDomain.CurrentDomain;
        public char CommandCharacter { get { return cChar; } set { cChar = value; } }
        Timer mute = new Timer();
        Timer aborttimer = new Timer();
        Timer SocckerRandomTimer = new Timer();
        private Random random = new Random();
        Jid roomJid; 
        bool Igniter;
        private Timer OpTime = new Timer();
        System.Timers.Timer optim = new System.Timers.Timer();
        private string sender1;
        private XmppClientConnection x = new XmppClientConnection();
        private string Subject;
        string action1 = "";
        string analyze = "";
        Random rnd = new Random();
        XmppClientConnection x1;
        Timer gamer = new Timer();
        Timer LuckyTimer = new Timer();
        Timer QuizRepeater = new Timer();
        Timer QuizeAborter = new Timer();
        Stopwatch QuizElapsedTime = new Stopwatch();
        string roompassword = "";
        bool IsPasswordProtected = false;
        public void Login(string JID, string PASSWORD, string res, string sender, string roomn, XmppClientConnection x2, System.Windows.Forms.RichTextBox control, string passw, bool isprivate, bool isrej)
        {
            CurrentDom.UnhandledException +=new UnhandledExceptionEventHandler(Unhandler);
                try
                {
                    Isrejoin = isrej;
                    IsPasswordProtected = isprivate;
                    roompassword = passw;
                    LuckyMsg = "I have a number between 0-5.\nAnyone who tells that number will be rewarded with" + LuckyScore + "oints.";
                    x1 = x2;
                    Messages.Text = control.Text;
                    this.ID = JID;
                    roomname = roomn;
                    this.PSW = PASSWORD;
                    this.Resouce = res;
                    optim.Interval = 30000;
                    master = sender;
                    this.sender1 = sender;
                    disco.Interval = 100;
                    SocckerRandomTimer.Elapsed += new ElapsedEventHandler(SoccerRandom);
                    SocckerRandomTimer.Interval = 1000;
                    SocckerRandomTimer.Start();
                    SoccerAbortTimer.Elapsed += new ElapsedEventHandler(SoccerAbortTimeHandler);
                    LuckyTimer.Interval = LuckyTimerCount;
                    ShoutTimer.Elapsed += new ElapsedEventHandler(ShoutTimerHandle);
                    ShoutTimer.Interval = ShoutTimerCount;
                    floodOFF.Elapsed += new ElapsedEventHandler(floodOFFTimer);
                    floodOFF.Start();
                    floodOFF.Interval = 120000;
                    Shoutword = random.Next().ToString();
                }
                catch { }
                System.Windows.Forms.Timer OpTime1 = new System.Windows.Forms.Timer();
                try
                {
                        x.OnError += new ErrorHandler(x_OnError);
                        x.OnSocketError += new ErrorHandler(x_OnSocketError);
                        x.AutoResolveConnectServer = false;
                        x.Server = "nimbuzz.com";
                        x.ConnectServer = "o.nimbuzz.com";
                        x.OnAuthError += new XmppElementHandler(this.OnFailed);
                        x.OnLogin += new ObjectHandler(this.OnConnected);
                        x.OnClose += new ObjectHandler(this.dc);
                        x.OnMessage += new MessageHandler(OnMessage);
                        x.OnMessage += new MessageHandler(Othermess);
                        x.OnPresence += new agsXMPP.protocol.client.PresenceHandler(OnTime);
                        x.OnReadXml += new XmlHandler(OnXml);
                        sts = "Hi I'm here!";
                        x.Open(this.ID, this.PSW, res + rnd.Next(100, 5000).ToString(), 50);
                        OpTime.Elapsed += new System.Timers.ElapsedEventHandler(t_Tick);
                        OpTime.Interval = 10000;
                        OpTime.Start();
                        QuizRepeater.Elapsed += new ElapsedEventHandler(RepeatQuiz);
                        QuizeAborter.Elapsed += new ElapsedEventHandler(QuizHoldTimer);
                        QuizRepeater.Interval = QuizRepeatCounter;
                        QuizeAborter.Interval = QuizAbortCounter;
                        Roomname1 = roomname;
                        roomJid = new Jid(roomname + "@conference.nimbuzz.com");
                    
                        return;
                }
                catch { }
                return;
        }
        bool isalart = true;
        void x_OnSocketError(object sender, Exception e)
        {
         //Implement here
        }
        void x_OnXmppError(object sender, agsXMPP.Xml.Dom.Element e)
        {
            //Implement here
        }
       void x_OnError(object sender,Exception  e)
       {
           //Implement here
       }
       string ThreadMessage = "";
       bool antiflood = true;
       Timer floodOFF = new Timer();
       void floodOFFTimer(object sender, EventArgs e)
       {
           if (!antiflood && FullMaster)
           {
               if (isalart)
               {
                   Send("ATTENTION! Room is not protected from Flooders!\nSend ANTIFLOOD/ON to protect from Flooders.");
               }
           }
       }
        static void Unhandler(object sender, UnhandledExceptionEventArgs args)
        {
           // Exception e = (Exception)args.ExceptionObject;
            // then Implement here
        }
       public  bool IsAutoJoin = false;
        private void Othermess(object sender, agsXMPP.protocol.client.Message NewMessage)
        {
            if (NewMessage.From.User.Trim() != null && NewMessage.From.Resource.Trim() != null && NewMessage.From.Bare.Trim() != null && NewMessage.Body.Trim() != null && NewMessage.Type != MessageType.error && NewMessage.From.Resource.ToLower() != Roomname1.ToLower())
            {
                if (NewMessage.Type == MessageType.chat)
                {
                    try
                    {
                        if (NewMessage.Body.Trim().ToLower() == "help")
                        {
                               x.Send(new agsXMPP.protocol.client.Message(new Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, userHelp.Replace("%room%", Roomname1).Replace("%user%", NewMessage.From.User).Replace("%L%", "\n").Replace("%n%", "@nimbuzz.com")));
                        }
                        if (NewMessage.Body.ToLower().Trim() == ("help/") && (NewMessage.From.User == master || MasterShip(NewMessage.From.User.ToLower())))
                        {
                            Send(NewMessage.From.User, "You are master, Send HELP/1 to HELP/27 to view commands.", true);
                        }
                        if (NewMessage.Body.ToLower().Trim().StartsWith("help/") && (NewMessage.From.User == master || MasterShip(NewMessage.From.User.ToLower())))
                        {
                            if (System.IO.File.Exists(@"cwn.txt"))
                            {
                                try
                                {
                                    string[] sp = NewMessage.Body.Trim().Split('/');
                                    string[] help = System.IO.File.ReadAllText(@"ncwn.txt").Split('|');
                                    if (NewMessage.Body.Trim().Trim() != "0")
                                    {
                                        int nm = Convert.ToInt32(sp[1]);
                                        Send(NewMessage.From.User, help[nm], true);
                                        Send(NewMessage.From.User, "All above commands are only accepted in room!", true);
                                    }
                                    else
                                    {
                                        Send(NewMessage.From.User,"No such command available!",true);
                                    }
                                }
                                catch
                                {
                                    Send(NewMessage.From.User,"Command syntax error or No such command available!",true);
                                }
                            }
                            else
                            {
                                Send("Bot help file is missing. Please contact Bot owner to fix this error.");
                            }
                        }
                        if (NewMessage.Body.Trim().ToLower() == "#kickme")
                        {
                            if (OnlineShip(NewMessage.From.User))
                            {
                                if (IsMaster)
                                {
                                    userslist.Items.Remove(NewMessage.From.User);
                                    Send("/kick " + NewMessage.From.User);
                                    x.Send(new agsXMPP.protocol.client.Message(new Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, "You have been kicked!"));
                                }
                                else
                                {
                                    x.Send(new agsXMPP.protocol.client.Message(new Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, "Sorry this bot has no permission or privilege to do this action."));
                                }
                            }
                            else
                            {
                                x.Send(new agsXMPP.protocol.client.Message(new Jid(NewMessage.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, "Sorry, you are not in '" + Roomname1 + "@conference.nimbuzz.com'."));
                            }
                        }
                    }
                    catch (Exception v) { Send(v.ToString()); }
                }
            }
        }
        private void OnMessage(object sender, agsXMPP.protocol.client.Message NewMessage)
        {
            if (NewMessage.From.User.Trim() != null && NewMessage.From.Resource.Trim() != null && NewMessage.From.Bare.Trim() != null && NewMessage.Body.Trim() != null && NewMessage.Type != MessageType.error && NewMessage.From.Resource.ToLower()!=Roomname1.ToLower())
            {
              System.Threading.Thread thre = new System.Threading.Thread(() =>
                 {
                     try
                     {
                         if (NewMessage.Type == MessageType.groupchat || NewMessage.Type == MessageType.chat)
                         {
                             if (NewMessage.Body.Trim() == string.Empty)
                                 return;
                             else
                                 LuckyTimer.Interval = LuckyTimerCount;
                                 aborttimer.Elapsed += new ElapsedEventHandler(_aborttimer);
                             aborttimer.Interval = 60000;
                             if (NewMessage.Type == MessageType.error || NewMessage.Body.Trim() == null)
                                 return;
                             if (NewMessage.From.ToString() == roomname + "@conference.nimbuzz.com")
                             {
                                 Send(NewMessage.Body); Igniter = false;
                             }
                             else
                             {
                             } try
                             {
                                 antikicktime.Start();
                                 thinktimer.Elapsed += new ElapsedEventHandler(ThinkGenenrator);
                                 thinktimer.Interval = 100;
                                 thinktimer.Start();
                             }
                             catch { }
                             if (NewMessage.Type == MessageType.groupchat)
                             {
                                 if (NewMessage.Body.Contains(cChar) && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())) && NewMessage.Body.Trim() != string.Empty)
                                 {
                                     agsXMPP.protocol.x.muc.MucManager nz = new agsXMPP.protocol.x.muc.MucManager(x);
                                     string[] sp = NewMessage.Body.ToLower().Split(cChar); string[] C = NewMessage.Body.Split(cChar);
                                     Jid targetJid = new Jid(sp[1] + "@nimbuzz.com");
                                     switch (sp[0])
                                     {
                                         //IsMaster
                                         case "kc": if (IsMaster) { nz.KickOccupant(roomJid, sp[1]); Send(sp[1] + " has been kicked"); } else { Send("But this bot is neither Admin Nor Owner!\nSend HELP/ADMIN"); } break;
                                         case "bn": if (IsMaster) { nz.BanUser(roomJid, targetJid); Send(sp[1] + " has been banned from room."); } else { Send("But this bot is neither Admin Nor Owner!\nSend HELP/ADMIN"); } break;
                                         case "vs": if (IsMaster) { nz.RevokeVoice(roomJid, sp[1]); Send(sp[1] + " recognized as visitor"); } else { Send("But this bot is neither Admin Nor Owner!\nSend HELP/ADMIN"); } break;
                                         case "pm": Send(sp[1]); break;
                                         case "pf": Igniter = true; Send("/who " + sp[1]); break;
                                         case "ad": if (FullMaster) { nz.GrantAdminPrivileges(roomJid, targetJid); Send(sp[1] + " has ben given admin privilliage"); } else { Send("This bot must have ownership to do this.\nSend 'help/owner'"); } break;
                                         case "ow": if (FullMaster) { nz.GrantOwnershipPrivileges(roomJid, targetJid); Send(sp[1] + " has been given owner privilliage"); } else { Send("This bot must have ownership to do this.\nSend 'help/owner'"); } break;
                                         case "mm": if (IsMaster) { nz.GrantMembership(roomJid, targetJid); Send(sp[1] + " has been membered"); } else { Send("But this bot is neither Admin Nor Owner!\nSend HELP/ADMIN"); } break;
                                         case "md": if (FullMaster) { nz.GrantModeratorPrivileges(roomJid, sp[1]); Send(sp[1] + " has been given moderator privilliage"); } else { Send("This bot must have ownership to do this.\nSend 'help/owner'"); } break;
                                         case "uvs": if (IsMaster) { nz.GrantVoice(roomJid, sp[1]); Send(sp[1] + " has been given voice"); } else { Send("But this bot is neither Admin Nor Owner!\nSend HELP/ADMIN"); } break;
                                         case "ubn": if (IsMaster) { Send("/ban r " + sp[1]); Send(sp[1] + " has been unbanned"); } else { Send("But this bot is neither Admin Nor Owner!\nSend HELP/ADMIN"); } break;
                                         case "umd": if (FullMaster) { nz.RevokeModerator(roomJid, sp[1]); Send(sp[1] + " has been removed from members"); } else { Send("This bot must have ownership to do this.\nSend 'help/owner'"); } break;
                                         case "umm": if (IsMaster) { nz.RevokeMembership(roomJid, sp[1]); Send(sp[1] + " has been given moderator privilliage"); } else { Send("This bot must have ownership to do this.\nSend 'help/owner'"); } break;
                                         case "wl":
                                             {
                                                 switch (sp[1].ToLower())
                                                 {
                                                     case "on":
                                                         {
                                                             if (autoIPbanmanage == "on")
                                                             {
                                                                 Send("'Welocmer' can not be turned on while 'Auto Ip Ban' is Enebled\nPlease Turn off 'Auto Ip Ban' first.");
                                                             }
                                                             else if (autobanmanage == "on")
                                                             {
                                                                 Send("'Welocmer' can not be turned on while 'Auto Ban' is Enebled\nPlease Turn off 'Auto Ban' first.");
                                                             }
                                                             else
                                                             {
                                                                 wlmanage = "on";
                                                                 Send("Welcomer is turned on");
                                                             }
                                                             break;
                                                         }
                                                     case "off":
                                                         {
                                                             wlmanage = "off";
                                                             Send("Welcomer is turned off");
                                                             break;
                                                         }
                                                 }
                                                 break;
                                             }
                                         //quiz
                                         case "qz":
                                             {
                                                 switch (sp[1].ToLower())
                                                 {
                                                     case "on":
                                                         {
                                                             quizmanage = "on";
                                                             Send("Quiz is turned on");
                                                             QuizAskibleOption = "on";
                                                             ReadQuizQuestio();
                                                             break;
                                                         }
                                                     case "off":
                                                         {
                                                             QuizAskibleOption = "off";
                                                             QuizRepeater.Stop();
                                                             QuizeAborter.Stop();
                                                             QuizRepeater.Stop();
                                                             QuizeAborter.Stop();
                                                             QuizElapsedTime.Reset();
                                                             QuizElapsedTime.Stop();
                                                             quizmanage = "off";
                                                             Send("Quiz is turned off");
                                                             break;
                                                         }
                                                 }
                                                 break;
                                             }
                                         //Message Line Filter
                                         case "mlf":
                                             {
                                                 if (!FullMaster)
                                                     Send("To turn on/off this feature this bot should have 'owner' privilege!\nSend 'Help/owner' to get help for this.");
                                                 else
                                                     switch (sp[1].ToLower())
                                                     {
                                                         case "on":
                                                             {
                                                                 LineFiltermanage = "on";
                                                                 Send("Message Line Filter is turned on");
                                                                 break;
                                                             }
                                                         case "off":
                                                             {
                                                                 LineFiltermanage = "off";
                                                                 Send("Message Line Flter is turned off");
                                                                 break;
                                                             }
                                                     }
                                                 break;
                                             }
                                         //Auto Add
                                         case "autoadd":
                                             {
                                                 switch (sp[1].ToLower())
                                                 {
                                                     case "on":
                                                         {
                                                             AutoAddManage = "on";
                                                             Send("Auto add is turned on");
                                                             break;
                                                         }
                                                     case "off":
                                                         {
                                                             AutoAddManage = "off";
                                                             Send("Auto add is turned off");
                                                             break;
                                                         }
                                                 }
                                                 break;
                                             }
                                             //Stop alerts
                                         case "alert":
                                             {
                                                 switch (sp[1].ToLower())
                                                 {
                                                     case "on":
                                                         {
                                                             isalart = true;
                                                             Send("Protection alerts is turned on");
                                                             break;
                                                         }
                                                     case "off":
                                                         {
                                                             isalart = false;
                                                             Send("Protection alerts is turned off");
                                                             Send("Bot will not notify you the exposure of your room to threats!");
                                                             break;
                                                         }
                                                 }
                                                 break;
                                             }
                                         //Penalty Game (Soccer)
                                         case "plt":
                                             {
                                                 switch (sp[1].ToLower())
                                                 {
                                                     case "on":
                                                         {
                                                             soccermanage = "on";
                                                             Send("Penalty Game is turned on");
                                                             break;
                                                         }
                                                     case "off":
                                                         {
                                                             soccermanage = "off";
                                                             Send("Penalty game is turned off");
                                                             break;
                                                         }
                                                 }
                                                 break;
                                             }
                                         //AntiFlood
                                         case "antiflood":
                                             {
                                                     switch (sp[1].ToLower())
                                                     {
                                                         case "on":
                                                             {
                                                                 if (FullMaster)
                                                                 {
                                                                     antiflood = true;
                                                                     SmartDetmanage = "on";
                                                                     msgfiltermanage = "on";
                                                                     anticapitalmanage = "on";
                                                                     //LineFiltermanage = "on";
                                                                     idfiltermanage = "on";
                                                                     LineFilterlen = 20;
                                                                     idlength = 50;
                                                                     msglength = 150;
                                                                     Send("Turning on...");
                                                                     Send("Flood protection is turned on.");
                                                                 }
                                                                 else
                                                                 {
                                                                     Send("Sorry, in order to turn on ANTIFLOOD protection you make this bot room owner.\nTo learn how this send HELP/OWNER.");
                                                                 }
                                                                     break;
                                                             }
                                                         case "off":
                                                             {
                                                                 SmartDetmanage = "off";
                                                                 msgfiltermanage = "off";
                                                                 anticapitalmanage = "off";
                                                                 LineFiltermanage = "off";
                                                                 idfiltermanage = "off";
                                                                 antiflood = false;
                                                                 Send("Turning off...");
                                                                 Send("Flood protection is turned off.");
                                                                 Send("Room is exposed to Flooders!");
                                                                 break;
                                                             }
                                                 }
                                                 break;
                                             }
                                         //Admin and Mod skipper and bots master
                                         case "amsk":
                                             {
                                                 if (!FullMaster)
                                                     Send("To turn on/off this feature this bot should have 'owner' privilege!\nSend 'Help/owner' to get help for this.");
                                                 else
                                                     switch (sp[1].ToLower())
                                                     {
                                                         case "on":
                                                             {
                                                                 adminmodSkipper = "on";
                                                                 Send("Admins, Mods and masters  recognizer is turned on");
                                                                 break;
                                                             }
                                                         case "off":
                                                             {
                                                                 adminmodSkipper = "off";
                                                                 Send("Admin and Mod and Master recognizer is turned off");
                                                                 break;
                                                             }
                                                     }
                                                 break;
                                             }
                                         //game
                                         case "game":
                                             {
                                                 switch (sp[1].ToLower())
                                                 {
                                                     case "on":
                                                         {
                                                             gamekickmanage = "on";
                                                             gamer.Elapsed += new ElapsedEventHandler(_gamer);
                                                             Send("'get kick point' game  is turned on");
                                                             break;
                                                         }
                                                     case "off":
                                                         {
                                                             gamekickmanage = "off";
                                                             gamer.Stop();
                                                             Send("'get kick point' game is turned off");
                                                             break;
                                                         }
                                                 }
                                                 break;
                                             }
                                         //flood Protection
                                         case "prot":
                                             {
                                                 if (!FullMaster)
                                                     Send("To turn on/off this feature this bot should have 'owner' privilege!\nSend 'Help/owner' to get help for this.");
                                                 else
                                                     switch (sp[1].ToLower())
                                                     {
                                                         case "on":
                                                             {
                                                                 floodmanage = "on";
                                                                 resfiltermanage = "on";
                                                                 reslength = 30;
                                                                 idfiltermanage = "on";
                                                                 muter = "on";
                                                                 msgfiltermanage = "on";
                                                                 msglength = 150;
                                                                 wordfiltermanage = "on";
                                                                 antikickmanage = "on";
                                                                 reconizemanage = "on";
                                                                 badlanguagemanage = "on";
                                                                 wlmanage = "off";
                                                                 Send("All protections are turned on. Some features have been turned off for better protection.");
                                                                 break;
                                                             }
                                                         case "off":
                                                             {
                                                                 floodmanage = "off";
                                                                 resfiltermanage = "off";
                                                                 reslength = 30;
                                                                 idfiltermanage = "off";
                                                                 muter = "off";
                                                                 msgfiltermanage = "off";
                                                                 msglength = 50;
                                                                 antikickmanage = "on";
                                                                 reconizemanage = "off";
                                                                 badlanguagemanage = "off";
                                                                 wlmanage = "on";
                                                                 Send("All protections have been disabled.\nYour room is unprotected!");
                                                                 break;
                                                             }
                                                     }
                                                 break;
                                             }
                                         //resource filter
                                         case "rf":
                                             {
                                                 if (!FullMaster)
                                                     Send("To turn on/off this feature this bot should have 'owner' privilege!\nSend 'Help/owner' to get help for this.");
                                                 else
                                                     switch (sp[1].ToLower())
                                                     {
                                                         case "on":
                                                             {
                                                                 resfiltermanage = "on";
                                                                 Send("Resource filter is turned on");
                                                                 break;
                                                             }
                                                         case "off":
                                                             {
                                                                 resfiltermanage = "off";
                                                                 Send("Resource filter is turned off");
                                                                 break;
                                                             }
                                                     }
                                                 break;
                                             }
                                         //ID filter
                                         case "idf":
                                             {
                                                 if (!FullMaster)
                                                     Send("To turn on/off this feature this bot should have 'owner' privilege!\nSend 'Help/owner' to get help for this.");
                                                 else
                                                     switch (sp[1].ToLower())
                                                     {
                                                         case "on":
                                                             {
                                                                 idfiltermanage = "on";
                                                                 Send("ID filter is turned on");
                                                                 break;
                                                             }
                                                         case "off":
                                                             {
                                                                 idfiltermanage = "off";
                                                                 Send("ID filter is turned off");
                                                                 break;
                                                             }
                                                     }
                                                 break;
                                             }
                                         //Autob ban
                                         case "autoban":
                                             {
                                                 if (!IsMaster)
                                                     Send("Bot should have privilege to do this action.\nSend '/mod " + x.Username + "'");
                                                 else
                                                     switch (sp[1].ToLower())
                                                     {
                                                         case "on":
                                                             {
                                                                 if (autoIPbanmanage == "on")
                                                                 {
                                                                     Send("'Auto Ban' can not be turned on while 'Auto Ip Ban' is Enebled\nPlease Turn off 'Auto Ip Ban' first.");
                                                                 }
                                                                 else if (autokickmanage == "on")
                                                                 {
                                                                     Send("'Auto Ban' can not be turned on while 'Auto Kick' is Enebled\nPlease Turn off 'Auto Kick' first.");
                                                                 }
                                                                 else
                                                                 {
                                                                     autobanmanage = "on";
                                                                     Send("Auto ban is turned on");
                                                                     Send("NOTE: Any user that joins to this room will be banned EXCEPT the 'OWNERS', 'MODERATORS',ADMINS, AND 'BOT MASTERS'.");
                                                                 }
                                                                 break;
                                                             }
                                                         case "off":
                                                             {
                                                                 autobanmanage = "off";
                                                                 Send("Auto ban is turned off");
                                                                 break;
                                                             }
                                                     }
                                                 break;
                                             }
                                         //Silent mode
                                         case "sln":
                                             {
                                                 switch (sp[1].ToLower())
                                                 {
                                                     case "on":
                                                         {
                                                             silecncemanage = "on";
                                                             Send("Silent mode is turned on");
                                                             Send("NOTE:\nAny activity done by the bot will not be notified the room.");
                                                             break;
                                                         }
                                                     case "off":
                                                         {
                                                             silecncemanage = "off";
                                                             Send("Silent mode is turned off");
                                                             break;
                                                         }
                                                 }
                                                 break;
                                             }
                                         //Score Transfer Option
                                         case "trn":
                                             {
                                                 switch (sp[1].ToLower())
                                                 {
                                                     case "on":
                                                         {
                                                             Transfermanage = "on";
                                                             Send("Score Transfer is turned on");
                                                             break;
                                                         }
                                                     case "off":
                                                         {
                                                             Transfermanage = "off";
                                                             Send("Score Transfer is turned off");
                                                             break;
                                                         }
                                                 }
                                                 break;
                                             }
                                         //Member by members option
                                         case "mbm":
                                             {
                                                 switch (sp[1].ToLower())
                                                 {
                                                     case "on":
                                                         {
                                                             if (!IsMaster)
                                                                 Send("But this bot is neither Admin Nor Owner!\nSend HELP/ADMIN");
                                                             else
                                                             {
                                                                 MemberByMembermanage = "on";
                                                                 Send("Membering by members is turned on");
                                                             }
                                                             break;
                                                         }
                                                     case "off":
                                                         {
                                                             MemberByMembermanage = "off";
                                                             Send("Membering by members is turned off");
                                                             break;
                                                         }
                                                 }
                                                 break;
                                             }
                                         //Lucky Notification
                                         case "lkn":
                                             {
                                                 switch (sp[1].ToLower())
                                                 {
                                                     case "on":
                                                         {
                                                             if (luckymanager == "on")
                                                             {
                                                                 LuckyNot = "on";
                                                                 Send("Lucky Notification is turned on");
                                                             }
                                                             else
                                                             {
                                                                 Send("Please turn on lucky game first.");
                                                             }
                                                             break;
                                                         }
                                                     case "off":
                                                         {
                                                             LuckyNot = "off";
                                                             Send("Lucky Notification is turned off");
                                                             break;
                                                         }
                                                 }
                                                 break;
                                             }
                                         //Auto kick
                                         case "autokick":
                                             {
                                                 if (IsMaster || FullMaster)
                                                     Send("But this bot is neither Admin Nor Owner!\nSend HELP/ADMIN");
                                                 else
                                                     switch (sp[1].ToLower())
                                                     {
                                                         case "on":
                                                             {
                                                                 if (autoIPbanmanage == "on")
                                                                 {
                                                                     Send("'Auto Kick' can not be turned on while 'Auto Ip Ban' is Enebled\nPlease Turn off 'Auto Ip Ban' first.");
                                                                 }
                                                                 else if (autobanmanage == "on")
                                                                 {
                                                                     Send("'Auto Kick' can not be turned on while 'Auto Ban' is Enebled\nPlease Turn off 'Auto Ban' first.");
                                                                 }
                                                                 else
                                                                 {
                                                                     autokickmanage = "on";
                                                                     Send("Auto kick is turned on");
                                                                     Send("NOTE: Any user that joins to this room will be kicked out EXCEPT the 'OWNERS', 'MODERATORS',ADMINS, AND 'BOT MASTERS'\nAlso user 'Welcomer' is turned off");
                                                                 }
                                                                 break;
                                                             }
                                                         case "off":
                                                             {
                                                                 autokickmanage = "off";
                                                                 Send("Auto kick is turned off");
                                                                 break;
                                                             }
                                                     }
                                                 break;
                                             }
                                         //Auto Member
                                         case "automem":
                                             {
                                                 if (!IsMaster)
                                                     Send("But this bot is neither Admin Nor Owner!\nSend HELP/ADMIN");
                                                 else
                                                     switch (sp[1].ToLower())
                                                     {
                                                         case "on":
                                                             {
                                                                 if (autoIPbanmanage == "on")
                                                                 {
                                                                     Send("'Auto Member' can not be turned on while 'Auto Ip Ban' is Enebled\nPlease Turn off 'Auto Ip Ban' first.");
                                                                 }
                                                                 else if (autobanmanage == "on")
                                                                 {
                                                                     Send("'Auto Member' can not be turned on while 'Auto Ban' is Enebled\nPlease Turn off 'Auto Ban' first.");
                                                                 }
                                                                 else if (autokickmanage == "on")
                                                                 {
                                                                     Send("'Auto Member' can not be turned on while 'Auto Kick' is Enebled\nPlease Turn off 'Auto Kick' first.");
                                                                 }
                                                                 else
                                                                 {
                                                                     automember = "on";
                                                                     Send("Auto Member is turned on");
                                                                                                    }
                                                                 break;
                                                             }
                                                         case "off":
                                                             {
                                                                 automember = "off";
                                                                 Send("Auto Member is turned off");
                                                                 break;
                                                             }
                                                     }
                                                 break;
                                             }
                                         //Auto mute
                                         case "automute":
                                             {
                                                 if (!IsMaster)
                                                     Send("But this bot is neither Admin Nor Owner!\nSend HELP/ADMIN");
                                                 else
                                                     switch (sp[1].ToLower())
                                                     {
                                                         case "on":
                                                             {
                                                                 if (autoIPbanmanage == "on")
                                                                 {
                                                                     Send("'Auto Member' can not be turned on while 'Auto Ip Ban' is Enebled\nPlease Turn off 'Auto Ip Ban' first.");
                                                                 }
                                                                 else if (autobanmanage == "on")
                                                                 {
                                                                     Send("'Auto Mute' can not be turned on while 'Auto Ban' is Enebled\nPlease Turn off 'Auto Ban' first.");
                                                                 }
                                                                 else if (autokickmanage == "on")
                                                                 {
                                                                     Send("'Auto Mute' can not be turned on while 'Auto Kick' is Enebled\nPlease Turn off 'Auto Kick' first.");
                                                                 }
                                                                 else
                                                                 {
                                                                     automutemanage = "on";
                                                                     Send("Auto mute is turned on");
                                                                     Send("ATTENTION!\n\n'Flood Protection' may not work if 'Auto mute' is ON");
                                                                 }
                                                                 break;
                                                             }
                                                         case "off":
                                                             {
                                                                 automutemanage = "off";
                                                                 Send("Auto mute is turned off");
                                                                 break;
                                                             }
                                                     }
                                                 break;
                                             }
                                         //Auto IP Ban
                                         case "autoipban":
                                             {
                                                 if (!FullMaster)
                                                     Send("Bot should have 'owner' privilege.\nSend 'Help/owner' to get help for this.");
                                                 else
                                                     switch (sp[1].ToLower())
                                                     {
                                                         case "on":
                                                             {
                                                                 if (autoIPbanmanage == "on")
                                                                 {
                                                                     Send("'Auto IP Ban' is already turned on");
                                                                 }
                                                                 else if (autobanmanage == "on")
                                                                 {
                                                                     Send("'Auto IP Ban' can not be turned on while 'Auto Ban' is Enebled\nPlease Turn off 'Auto Ban' first.");
                                                                 }
                                                                 else if (autokickmanage == "on")
                                                                 {
                                                                     Send("'Auto IP Ban' can not be turned on while 'Auto Kick' is Enebled\nPlease Turn off 'Auto Kick' first.");
                                                                 }
                                                                 else
                                                                 {
                                                                     autoIPbanmanage = "on";
                                                                     Send("Auto IP ban is turned on");
                                                                 }
                                                                 break;
                                                             }
                                                         case "off":
                                                             {
                                                                 autoIPbanmanage = "off";
                                                                 Send("Auto IP ban is turned off");
                                                                 break;
                                                             }
                                                     }
                                                 break;
                                             }
                                         //Message Filter
                                         case "mf":
                                             {
                                                 if (!FullMaster)
                                                     Send("Bot should have 'owner' privilege.\nSend 'Help/owner' to get help for this.");
                                                 else
                                                     switch (sp[1].ToLower())
                                                     {
                                                         case "on":
                                                             {
                                                                 msgfiltermanage = "on";
                                                                 Send("Message filter is turned on");
                                                                 break;
                                                             }
                                                         case "off":
                                                             {
                                                                 msgfiltermanage = "off";
                                                                 Send("Message filter is turned off");
                                                                 break;
                                                             }
                                                     }
                                                 break;
                                             }
                                         //room lock on flood
                                         case "rlc":
                                             {
                                                 switch (sp[1].ToLower())
                                                 {
                                                     case "on":
                                                         {
                                                             roomlockmanage = "on";
                                                             Send("Locking room on flood is turned on");
                                                             break;
                                                         }
                                                     case "off":
                                                         {
                                                             roomlockmanage = "off";
                                                             Send("Locking room on flood is turned off");
                                                             break;
                                                         }
                                                 }
                                                 break;
                                             }
                                         //bad language
                                         case "badl":
                                             {
                                                 if (!IsMaster)
                                                     Send("But this bot is neither Admin Nor Owner!\nSend HELP/ADMIN");
                                                 else
                                                     switch (sp[1].ToLower())
                                                     {
                                                         case "on":
                                                             {
                                                                 badlanguagemanage = "on";
                                                                 Send("Bad language detection is turned on");
                                                                 break;
                                                             }
                                                         case "off":
                                                             {
                                                                 badlanguagemanage = "off";
                                                                 Send("Bad language detection  is turned off");
                                                                 break;
                                                             }
                                                     }
                                                 break;
                                             }
                                         //anti kick
                                         case "akc":
                                             {
                                                 switch (sp[1].ToLower())
                                                 {
                                                     case "on":
                                                         {
                                                             antikickmanage = "on";
                                                             Send("Anti-kick is turned on");
                                                             break;
                                                         }
                                                     case "off":
                                                         {
                                                             antikickmanage = "off";
                                                             Send("Anti-kick is turned off");
                                                             Send("NOTE: \nTurning 'anti-kick' off may result the bot to be kicked by the room hence the bot can't manage the room as wanted\nRoom protections will not work if bot is kicked.\n If there is a problem forcing you to turn off, please use 'troubleshoot/setting' to 'scan' Possible problems ");
                                                             break;
                                                         }
                                                 }
                                                 break;
                                             }
                                         //shout game
                                         case "shout":
                                             {
                                                 switch (sp[1].ToLower())
                                                 {
                                                     case "on":
                                                         {
                                                             ShoutNot = "on";
                                                             Shoutmanage = "on";
                                                             ShoutTimer.Start();
                                                             Send("shout game is turned on");
                                                             break;
                                                         }
                                                     case "off":
                                                         Shoutmanage = "off";
                                                         ShoutNot = "off";
                                                         Send("shout game is turned off");
                                                         break;
                                                 }
                                                 break;
                                             }
                                         //Shout Notification
                                         case "shtn":
                                             {
                                                 switch (sp[1].ToLower())
                                                 {
                                                     case "on":
                                                         {
                                                             if (Shoutmanage == "on")
                                                             {
                                                                 ShoutNot = "on";
                                                                 Send("shout Game Notification is turned on");
                                                             }
                                                             else
                                                             {
                                                                 Send("Please turn on shout game");
                                                             }
                                                             break;
                                                         }
                                                     case "off":
                                                         ShoutNot = "off";
                                                         Send("shout Game Notification is turned off");
                                                         break;
                                                 }
                                                 break;
                                             }
                                         //lucky game
                                         case "lucky":
                                             {
                                                 switch (sp[1].ToLower())
                                                 {
                                                     case "on":
                                                         {
                                                             luckymanager = "on";
                                                             LuckyNot = "on";
                                                             Send("Lucky game is turned on");
                                                             break;
                                                         }
                                                     case "off":
                                                         luckymanager = "off";
                                                         LuckyNot = "on";
                                                         Send("Lucky game is turned off");
                                                         break;
                                                 }
                                                 break;
                                             }
                                         //Anti Capital
                                         case "acp":
                                             {
                                                 if (!IsMaster)
                                                     Send("But this bot is neither Admin Nor Owner!\nSend HELP/ADMIN");
                                                 else
                                                     switch (sp[1].ToLower())
                                                     {
                                                         case "on":
                                                             {
                                                                 anticapitalmanage = "on";
                                                                 Send("Anti-Capital is turned on");
                                                                 break;
                                                             }
                                                         case "off":
                                                             anticapitalmanage = "off";
                                                             Send("Anti-Capital is turned off");
                                                             break;
                                                     }
                                                 break;
                                             }
                                         //recognizer
                                         case "recog":
                                             {
                                                 switch (sp[1].ToLower())
                                                 {
                                                     case "on":
                                                         {
                                                             reconizemanage = "on";
                                                             Send("Recognizer is turned on");
                                                             break;
                                                         }
                                                     case "off":
                                                         reconizemanage = "off";
                                                         Send("Recognizer is turned off");
                                                         break;
                                                 }
                                                 break;
                                             }
                                     }
                                 }
                                 if (NewMessage.Body.Trim().ToLower().StartsWith("help/") && NewMessage.From.Resource.ToLower() != x.Username.ToLower())
                                 {
                                     string[] sp = NewMessage.Body.Split('/');
                                     switch (sp[1])
                                     {
                                         case "tag":
                                             {
                                                 Send("Our bot uses special tags to represent elements in a command.\nSend TAG/1 to TAG/5 to see availabe tags.");
                                                 break;
                                             }
                                         case "owner":
                                             {
                                                 Send("Most protection commands need Ownership privilege. To get help for OWNER privilege, please go https://nizzc.com/owner");
                                                 break;
                                             }
                                         case "points":
                                             {
                                                 Send("You can get more points by playing games, quiz and also you can request from your friends and bot master.");
                                                 Send("Send HELP to see what is available for you.");
                                                 break;
                                             }
                                         case "admin":
                                             {
                                                 Send("You can't use Nizzc bot for room management untill you give admin/owner privilege.\nTo see how to give admin/owner to our bot go to https://nizzc.com/owner");
                                                 break;
                                             }
                                     }
                                 }
                                 //Tags
                                 if (NewMessage.Body.ToLower().Trim().StartsWith("tag/") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     if (System.IO.File.Exists(@"stk.txt"))
                                     {
                                         try
                                         {
                                             string[] sp = NewMessage.Body.Trim().Split('/');
                                             string[] help = System.IO.File.ReadAllText(@"stk.txt").Split('|');
                                             if (NewMessage.Body.Trim().Trim() != "0")
                                             {
                                                 int nm = Convert.ToInt32(sp[1]);
                                                 Send(help[nm]);
                                             }
                                             else
                                             {
                                                 Send("No such command available!");
                                             }
                                         }
                                         catch
                                         {
                                             Send("Command syntax error or No such command available!");
                                         }
                                     }
                                     else
                                     {
                                         Send("Bot tag file is missing. Please contact Bot owner to fix this error.");
                                     }
                                 }
                                 //Masters Help
                                 if (NewMessage.Body.ToLower().Trim().StartsWith("hl/") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     if (System.IO.File.Exists(@"cwn.txt"))
                                     {
                                         try
                                         {
                                             string[] sp = NewMessage.Body.Trim().Split('/');
                                             string[] help = System.IO.File.ReadAllText(@"cwn.txt").Split('|');
                                             if (NewMessage.Body.Trim().Trim() != "0")
                                             {
                                                 int nm = Convert.ToInt32(sp[1]);
                                                 Send("This command was older version, please use HELP/1 to HELP/27");
                                             }
                                             else
                                             {
                                                 Send("No such command available!");
                                             }
                                         }
                                         catch
                                         {
                                             Send("Command syntax error or No such command available!");
                                         }
                                     }
                                     else
                                     {
                                         Send("Bot help file is missing. Please contact Bot owner to fix this error.");
                                     }
                                 }
                                 if (NewMessage.Body.ToLower().Trim().StartsWith("help/") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     if (System.IO.File.Exists(@"cwn.txt"))
                                     {
                                         try
                                         {
                                             string[] sp = NewMessage.Body.Trim().Split('/');
                                             string[] help = System.IO.File.ReadAllText(@"ncwn.txt").Split('|');
                                             if (NewMessage.Body.Trim().Trim() != "0")
                                             {
                                                     int nm = Convert.ToInt32(sp[1]);
                                                     Send(NewMessage.From.Resource, help[nm], true);
                                                     Send("Command message has been sent as private message.");
                                                 try
                                                 {    
                                                     x.PresenceManager.Subscribe(new Jid(NewMessage.From.Resource + "@nimbuzz.com"));
                                                 }
                                                 catch { }
                                             }
                                             else
                                             {
                                                 Send("No such command available!");
                                             }
                                         }
                                         catch
                                         {
                                             Send("Command syntax error or No such command available!");
                                         }
                                     }
                                     else
                                     {
                                         Send("Bot help file is missing. Please contact Bot owner to fix this error.");
                                     }
                                 }
                                 if (NewMessage.Body.ToLower().Trim()==("help") && NewMessage.From.Resource != x.Username && !MasterShip(NewMessage.From.Resource.ToLower()) && NewMessage.From.Resource.ToLower() != master.ToLower())
                                 {
                                     Send("Please use HLP/1 to HLP/9 to see commands available for you.\n\nYou are not owner/master");
                                 }
                                 try
                                 {
                                     if (NewMessage.From.Resource.Trim().ToLower() != x.Username.ToLower() && NewMessage.Body.ToLower().Trim() == "about")
                                     {
                                         Send("Artificial Intelligent Computer machine, Nizzc Mobile Server(NMS), is a very advanced IRC Robotic program Designed to give users Complete Account and Chatroom Protections with User Service assistances and...");
                                         Send("... room managements and games.");
                                         Send("Company: Nizzc Incorp.\nWesite: https://www.nizzc.com\nEmail: team@nizzc.com\nPowered by: Nizzc Tech in Mug, Somalia.");
                                     }
                                 }
                                 catch { }
                                 //Love checker
                                 if (NewMessage.Body.ToLower().Trim().StartsWith("love#") && NewMessage.From.Resource.ToLower() != x.Username.ToLower())
                                 {
                                     System.Threading.Thread threw = new System.Threading.Thread(() =>
                                     {
                                         try
                                         {
                                             string[] sp1 = NewMessage.Body.Split('#');
                                             if (sp1[1].Contains(":"))
                                             {
                                                 string[] sp2 = sp1[1].Split(':');
                                                 Random rnl = new Random();
                                                 Send("Calculating...");
                                                 System.Threading.Thread.Sleep(3000);
                                                 Send("Love between '" + sp2[0] + "' and '" + sp2[1] + "' is '" + rnl.Next(0, 100) + "%'.");
                                             }
                                             else
                                             {
                                                 Send("Command syntax error: '" + sp1[1] + "' \nUse 'love#id1:id2");
                                             }
                                         }
                                         catch
                                         {
                                             Send("Command syntax error!");
                                         }
                                     }); threw.IsBackground = true; threw.Start();
                                 }
                                 //Penalty Set
                                 if (NewMessage.Body.ToLower() == "accept#penalty")
                                 {
                                     if (soccermanage == "on")
                                     {
                                         AcceptIt(NewMessage.From.Resource);
                                     }
                                     else
                                     {
                                         Send("This game is not turned on.");
                                     }
                                 }
                                 //HERE
                                 //User Help
                                 if (NewMessage.Body.ToLower().Trim().StartsWith("hlp/") && NewMessage.From.Resource != x.Username)
                                 {
                                     if (System.IO.File.Exists(@"qc.txt"))
                                     {
                                         try
                                         {
                                             string[] sp = NewMessage.Body.Trim().Split('/');
                                             string[] help = System.IO.File.ReadAllText(@"qc.txt").Split('|');
                                             if (NewMessage.Body.Trim().Trim() != "0")
                                             {
                                                 int nm = Convert.ToInt32(sp[1]);
                                                 Send(help[nm]);
                                             }
                                             else
                                             {
                                                 Send("No such command available!");
                                             }
                                             if (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource))
                                             {
                                                 Send("You are bot master!\nUse HELP/1 to HELP/27 to access all commands");
                                             }
                                         }
                                         catch
                                         {
                                             Send("Command syntax error or No such command available!");
                                         }
                                     }
                                     else
                                     {
                                         Send("Bot help file is missing. Please contact Bot owner to fix this error.");
                                     }
                                 }
                                 if (NewMessage.Body.ToLower().Trim() == "no" && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     if (YesNo.Trim() == string.Empty)
                                     {
                                     }
                                     else
                                     {
                                         YesNo = "";
                                         Send("Aborted!");
                                     }
                                 }
                                 //Logout
                                 if (NewMessage.Body.ToLower().Trim() == "#logout" && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     try
                                     {
                                         aborttimer.Stop();
                                         aborttimer.Start();
                                         YesNo = "logout";
                                         Send("Are you sure to log the bot out?\nYes\nNo");
                                     }
                                     catch { }
                                 }
                                 //If yes
                                 if (NewMessage.Body.ToLower().Trim() == "yes" && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     switch (YesNo)
                                     {
                                         case "logout":
                                             {
                                                 YesNo = "";
                                                 aborttimer.Stop();
                                                 System.Threading.Thread tt = new System.Threading.Thread(() =>
                                                 {
                                                     try
                                                     {
                                                         DoBackupAndUpload();
                                                     }
                                                     catch { }
                                                 });
                                                 tt.IsBackground = true;
                                                 tt.Start();
                                                 DoRest();
                                                 break;
                                             }
                                         case "leave":
                                             {
                                                 isJoinable = false;
                                                 OpTime.Stop();
                                                 YesNo = "";
                                                 Send("Bot will remember current Session changes. to rejoin the bot to room, Send to it '#join' ");
                                                 Send("Bot left the room!");
                                                 Send("/quit " + username);
                                                 break;
                                             }
                                         case "reset":
                                             {
                                                 System.Threading.Thread thr = new System.Threading.Thread(() =>
                                                 {
                                                     try
                                                     {
                                                         BackupTimer.Stop();
                                                         Send("Erasing all changes and deleting local files!");
                                                         isJoinable = false;
                                                         OpTime.Stop();
                                                         passch = "off";
                                                         YesNo = "";
                                                         Send("Everything is erased!");
                                                         Send(master, "Your bot is being restarted...");
                                                         x.Close();
                                                         DeleteFile();
                                                         Form1 from = new Form1();
                                                         from.Rejoin(x.Username, x.Password, x.Resource, master, Roomname1, roompassword, IsPasswordProtected);
                                                     }
                                                     catch { }
                                                 }); thr.IsBackground = true; thr.Start();
                                                 break;
                                             }
                                         case "update":
                                             {
                                                 Send("Restoring...");
                                                 YesNo = "";
                                                 aborttimer.Stop();
                                                 Restore1(true);
                                                 break;
                                             }
                                     }
                                 }
                                 //More 
                                 if (NewMessage.Body.ToLower().StartsWith("st/") && (NewMessage.From.Resource.ToLower() == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     try
                                     {
                                         string[] sp1 = NewMessage.Body.Split('/');
                                         if (sp1[1].Trim() != string.Empty)
                                         {
                                             x.Status = sp1[1];
                                             x.SendMyPresence();
                                             Send("Status message is changed to '" + sp1[1] + "'");
                                         }
                                         else
                                         {
                                             Send("Your command is not complete!");
                                         }
                                     }
                                     catch (Exception v) { }
                                 }
                                 if (NewMessage.Body.ToLower().StartsWith("h/") && (NewMessage.From.Resource.ToLower() == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     try
                                     {
                                         string[] sp1 = NewMessage.Body.Split('/');
                                         if (sp1[1].Trim() != string.Empty)
                                         {
                                             userHelp = sp1[1];
                                             Send("help message is changed to '" + sp1[1] + "'");
                                         }
                                         else
                                         {
                                             Send("Your command is not complete!");
                                         }
                                     }
                                     catch (Exception v) { }
                                 }
                                 if (NewMessage.Body.ToLower().Trim() == ("autojoin/on") && (NewMessage.From.Resource.ToLower() == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 { /*You may add this command in your bot, please be careful as passwords saved while are not encrypted.*/
                                    /* if (!Isrejoin)
                                         Send("This bot is hosted on a childbot, to use this option please host your roombot on main bot.\nAdd nizzcserver@nimbuzz.com");
                                     else
                                     if (IsAutoJoin)
                                         Message("Auto join is alread turned on!");
                                     else
                                         try
                                         {
                                             Directory.CreateDirectory(Environment.CurrentDirectory+"/iskuxir");
                                             System.Windows.Forms.RichTextBox Loader = new System.Windows.Forms.RichTextBox();
                                             System.Windows.Forms.RichTextBox temp = new System.Windows.Forms.RichTextBox();
                                             Loader.LoadFile(Environment.CurrentDirectory+"/iskuxir/xir.exe", System.Windows.Forms.RichTextBoxStreamType.PlainText);
                                             bool isalready = false;
                                             if (Loader.Text.Trim() != string.Empty)
                                             {
                                                 string[] loadSp = Loader.Text.Split('#');
                                                 for (int i = 0; i < loadSp.Count(); i++)
                                                 {
                                                     if (loadSp[i].Trim() != string.Empty)
                                                     {
                                                         string[] sp = loadSp[i].Split(':');
                                                         if (sp[0].Trim().ToLower() == x.Username.Trim().ToLower())
                                                         {
                                                             isalready = true;
                                                         }
                                                         else
                                                         {
                                                             temp.Text += loadSp[i] + "#";
                                                         }
                                                     }
                                                 }
                                                 temp.Text += x.Username + ":" + x.Password + ":" + Roomname1 + ":" + roompassword + ":" + master +":"+x1.Username+ "#";
                                                 Loader.Text = temp.Text;
                                                 Loader.SaveFile(Environment.CurrentDirectory + "/iskuxir/xir.exe", System.Windows.Forms.RichTextBoxStreamType.PlainText);
                                                 Loader.SaveFile(Environment.CurrentDirectory + "/iskuxir/xir.exe", System.Windows.Forms.RichTextBoxStreamType.PlainText);
                                                 Send("Auto join is enabled!");
                                                 IsAutoJoin = true;
                                             }
                                             else
                                             {
                                                 temp.Text += x.Username + ":" + x.Password + ":" + Roomname1 + ":" + roompassword + ":" + master + "#";
                                                 Loader.Text = temp.Text;
                                                 Loader.SaveFile(Environment.CurrentDirectory + "/iskuxir/xir.exe", System.Windows.Forms.RichTextBoxStreamType.PlainText);
                                                 Loader.SaveFile(Environment.CurrentDirectory + "/iskuxir/xir.exe", System.Windows.Forms.RichTextBoxStreamType.PlainText);
                                                 Send("Auto join is enabled!");
                                                 IsAutoJoin = true;
                                             }
                                         }
                                         catch (Exception v) { Send("Unexpected error occured. Please contact  bot owner to solve this error."); }
                                */
                                     /*
                                      *Version 6.5 anouncement* 
                                      in version 6.5 auto join is permanently removed.*/
                                     Send("Auto join needs your bot password to be saved and we don't save user passwords, so we removed this option permanently.");
                                 }
                                 if (NewMessage.Body.ToLower().Trim() == ("autojoin/off") && (NewMessage.From.Resource.ToLower() == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     if (!IsAutoJoin)
                                     {
                                         Send("This option was already turned off permanently!");
                                     }
                                     else
                                         try
                                         {
                                            /* Directory.CreateDirectory(Environment.CurrentDirectory+"/iskuxir");
                                             System.Windows.Forms.RichTextBox Loader = new System.Windows.Forms.RichTextBox();
                                             System.Windows.Forms.RichTextBox temp = new System.Windows.Forms.RichTextBox();
                                             Loader.LoadFile(Environment.CurrentDirectory+"/iskuxir/xir.exe", System.Windows.Forms.RichTextBoxStreamType.PlainText);
                                             bool isalready = false;
                                             if (Loader.Text.Trim() != string.Empty)
                                             {
                                                 string[] loadSp = Loader.Text.Split('#');
                                                 for (int i = 0; i < loadSp.Count(); i++)
                                                 {
                                                     if (loadSp[i].Trim() != string.Empty)
                                                     {
                                                         string[] sp = loadSp[i].Split(':');
                                                         if (sp[0].Trim().ToLower() == x.Username.Trim().ToLower())
                                                         {
                                                             isalready = true;
                                                         }
                                                         else
                                                         {
                                                             temp.Text += loadSp[i] + "#";
                                                         }
                                                     }
                                                 }
                                                 // temp.Text += x.Username + ":" + x.Password + ":" + master;
                                                 Loader.Text = temp.Text;
                                                 Loader.SaveFile(Environment.CurrentDirectory+"/iskuxir/xir.exe", System.Windows.Forms.RichTextBoxStreamType.PlainText);
                                                 Loader.SaveFile(Environment.CurrentDirectory+"/iskuxir/xir.exe", System.Windows.Forms.RichTextBoxStreamType.PlainText);
                                                 Send("Auto join is disabled!");
                                                 IsAutoJoin = false;
                                             }
                                             else
                                             {
                                                 Send("It seems that you have not turned on auto join option");
                                             }
                                             //x.Send(new agsXMPP.protocol.client.Message(new Jid(msg.From.User + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, "Ok2"));
                                             */
                                         }
                                         catch (Exception v) { Send("Unexpected error occured. Please contact bot main bot owner to solve this error."); }
                                 }
                                 //-----------------
                                 //setups
                                 if (NewMessage.Body.ToLower().StartsWith("akcmsg#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     string[] sp1 = (NewMessage.Body).Split('#');
                                     if (this.antikickmanage == "on")
                                     {
                                         this.antikickmsg = sp1[1];
                                         Send("Antikick message has been changed to: " + sp1[1]);
                                     }
                                     else
                                     {
                                         Send("Please enable antikick first");
                                     }
                                 }
                                 //Server Upload Backup
                                 if (NewMessage.Body.Trim().ToLower() == "#backup" && (NewMessage.From.Resource.ToLower() == master.ToLower() || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     //Backup();
                                     Send("Please while connecting to our server...");
                                     UploadFTP();
                                 }
                                 //Restore from server
                                 if (NewMessage.Body.Trim().ToLower() == "#update" && (NewMessage.From.Resource.ToLower() == master.ToLower() || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     Send("Please wait while checking restore point for your room");
                                     ReadFTP();
                                 }
                                 //Restore it now
                                 if (NewMessage.Body.Trim().ToLower() == "#restore" && (NewMessage.From.Resource.ToLower() == master.ToLower() || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     Send("Restoring...");
                                     Restore1(false);
                                 }
                                 if (NewMessage.Body.Trim().ToLower() == "#save" && (NewMessage.From.Resource.ToLower() == master.ToLower() || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     //Not required as bot saves automatically.
                                 }
                                 //Shout Message Changer
                                 if (NewMessage.Body.ToLower().StartsWith("shoutmsg#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     string[] sp1 = (NewMessage.Body).Split('#');
                                     if (this.Shoutmanage == "on")
                                     {
                                         this.ShoutMsg = sp1[1];
                                         Send("Shout Notification message has been changed to: " + sp1[1]);
                                     }
                                     else
                                     {
                                         Send("Please enable Shout Game first");
                                     }
                                 }
                                 if (NewMessage.Body.ToLower().StartsWith("wlmsg#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     string[] sp1 = NewMessage.Body.Split('#');
                                     if (this.wlmanage == "on")
                                     {
                                         this.wlmsgholder = sp1[1];
                                         Send("Welcome message has been changed to: " + sp1[1]);
                                     }
                                     else
                                     {
                                         Send("Please enable User welcomer first");
                                     }
                                 }
                                 //Show My Bomb
                                 if (NewMessage.Body.ToLower() == "show/mybomb" && NewMessage.From.Resource != x.Username)
                                 {
                                     //For better performance, do this in saperate method.
                                     string bombnumber = "";
                                     string found = "";
                                     foreach (string l in BombList.Lines)
                                     {
                                         if (l.Trim() != string.Empty)
                                         {
                                             string[] sp1 = l.Split(':');
                                             if (sp1[0] == NewMessage.From.Resource)
                                             {
                                                 bombnumber = sp1[1];
                                                 found = "yes";
                                             }
                                         }
                                         System.Threading.Thread.Sleep(1);
                                     }
                                     if (found == "yes")
                                     {
                                         if (bombnumber != "0")
                                         {
                                             Send("\n>>" + NewMessage.From.Resource + "\nYou have '" + bombnumber + "' bomb(s)");
                                         }
                                         else
                                         {
                                             Send("Sorry, you don't have any bomb");
                                         }
                                     }
                                     else
                                     {
                                         Send("Sorry, you don't have any bomb");
                                     }
                                 }
                                 //Show My Bomb Sheild
                                 if (NewMessage.Body.ToLower() == "show/mybprot" && NewMessage.From.Resource != x.Username)
                                 {
                                     string bombnumber = "";
                                     string found = "";
                                     foreach (string l in BombProtectList.Lines)
                                     {
                                         if (l.Trim() != string.Empty)
                                         {
                                             string[] sp1 = l.Split(':');
                                             if (sp1[0] == NewMessage.From.Resource)
                                             {
                                                 bombnumber = sp1[1];
                                                 found = "yes";
                                             }
                                         }
                                     }
                                     if (found == "yes")
                                     {
                                         if (bombnumber != "0")
                                         {
                                             Send("\n>>" + NewMessage.From.Resource + "\nYou have '" + bombnumber + "' bomb shield");
                                         }
                                         else
                                         {
                                             Send("Sorry, you don't have any bomb sheild");
                                         }
                                     }
                                     else
                                     {
                                         Send("Sorry, you don't have any bomb sheild");
                                     }
                                 }
                                 //Buy Bomb
                                 if (NewMessage.Body.ToLower().StartsWith("buy/bomb#") && NewMessage.From.Resource != x.Username)
                                 {
                                     try
                                     {
                                         string[] sp1 = NewMessage.Body.Split('#');
                                         if (sp1[1].Trim() != string.Empty)
                                         {
                                             int tms = Convert.ToInt32(sp1[1]);
                                             if (tms > 0)
                                             {
                                                 Buy(NewMessage.From.Resource, luckylist, ':', tms * bombcost, "bomb(s)", BombList, tms);
                                             }
                                             else
                                             {
                                                 Send("\n>> " + NewMessage.From.Resource + "\nBomb number can't be '" + tms + "'!");
                                             }
                                         }
                                         else
                                         {
                                             Send("\n>> " + NewMessage.From.Resource + "\n Sorry, your command is not well constructed!");
                                         }
                                     }
                                     catch
                                     {
                                         Send("\n>> " + NewMessage.From.Resource + "\n Sorry, your command is not well constructed!");
                                     }
                                 }
                                 //Buy Bomb Protection
                                 if (NewMessage.Body.ToLower().StartsWith("buy/bprot#") && NewMessage.From.Resource != x.Username)
                                 {
                                     try
                                     {
                                         string[] sp1 = NewMessage.Body.Split('#');
                                         if (sp1[1].Trim() != string.Empty)
                                         {
                                             int tms = Convert.ToInt32(sp1[1]);
                                             if (tms > 0)
                                             {
                                                 Buy(NewMessage.From.Resource, luckylist, ':', tms * bombprotectcost, "bomb Protection(s)", BombProtectList, tms);
                                             }
                                             else
                                             {
                                                 Send("\n>> " + NewMessage.From.Resource + "\nBomb shield number can't be '" + tms + "'!");
                                             }
                                         }
                                         else
                                         {
                                             Send("\n>> " + NewMessage.From.Resource + "\n Sorry, your command is not well constructed!");
                                         }
                                     }
                                     catch
                                     {
                                         Send("\n>> " + NewMessage.From.Resource + "\n Sorry, your command is not well constructed!");
                                     }
                                 }
                                 //Transfer Score
                                 if (NewMessage.Body.ToLower().StartsWith("tr#") && NewMessage.From.Resource != x.Username)
                                 {
                                     if (Transfermanage == "on")
                                     {
                                         try
                                         {
                                             string[] sp1 = NewMessage.Body.Split('#');
                                             if (sp1[1].ToLower() != NewMessage.From.Resource.ToLower())
                                             {
                                                 int amount = Convert.ToInt32(sp1[2]);
                                                 ScoreTransfer(NewMessage.From.Resource, sp1[1], amount);
                                             }
                                             else
                                             {
                                                 Send("Please provide the user to whom you want to send your  score points.\nBut '" + sp1[1] + "' is your ID!");
                                             }
                                         }
                                         catch
                                         {
                                             Send("Sorry, Your command is not well construted!");
                                         }
                                     }
                                     else
                                     {
                                         Send("Score Transfer option is not turned on in this room.");
                                     }
                                 }
                                 //Next question
                                 if (NewMessage.Body.ToLower().Trim()=="#next" && (NewMessage.From.Resource.ToLower() == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     if (quizmanage == "on")
                                     {
                                         QuizQuestionNumber++;
                                         Send("Next question will be jumped to Question: " + QuizQuestionNumber);
                                         QuizAskibleOption = "on";
                                         ReadQuizQuestio();
                                     }
                                     else
                                     {
                                         Send("Quiz is not turned on");
                                     }
                                 }
                                 //add msglist
                                 if (NewMessage.Body.ToLower().StartsWith("wlmsgl#") && (NewMessage.From.Resource.ToLower() == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     string[] sp1 = NewMessage.Body.Trim().Split('#');
                                     if (!wlcmsgholderlist.Text.ToLower().Contains(sp1[1].ToLower()))
                                     {
                                         wlcmsgholderlist.Text += sp1[1] + Environment.NewLine;
                                     }
                                     else
                                     {
                                         Send("This Message is already either partially or completely  added");
                                     }
                                 }
                                 //add bot master
                                 if (NewMessage.Body.ToLower().StartsWith("am#") && (NewMessage.From.Resource.ToLower() == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     //for better performce, do this in different method.
                                     string[] sp1 = NewMessage.Body.Trim().Split('#');
                                     if (sp1[1].Contains(","))
                                     {
                                         int count = 0;
                                         string countstr = "";
                                         int addedcount = 0;
                                         string[] comma = sp1[1].Trim().Split(',');
                                         for (int i = 0; i < comma.Count(); i++)
                                         {
                                             if (!adminlist.Text.ToLower().Contains(comma[i].ToLower()))
                                             {
                                                 adminlist.Text += comma[i] + "\n";
                                                 addedcount++;
                                             }
                                             else
                                             {
                                                 count++;
                                                 countstr = countstr + comma[i] + "\n";
                                             }
                                             System.Threading.Thread.Sleep(10);
                                         }
                                         if (countstr.Trim() == string.Empty && count == 0 && addedcount > 0)
                                         {
                                             Send(comma.Count() + " bot masters have been added.");
                                         }
                                         else
                                         {
                                             if (count == 1)
                                             {
                                                 if (addedcount > 1)
                                                 {
                                                     Send(addedcount + " masters have been added.\n" + count + " master is already added:\n" + countstr);
                                                 }
                                                 else
                                                 {
                                                     Send(addedcount + " master has been added\n" + count + " master is already added:\n" + countstr);
                                                 }
                                             }
                                             else
                                             {
                                                 if (addedcount > 1)
                                                 {
                                                     Send(addedcount + " masters have been added.\n" + count + " masters are already added:\n" + countstr);
                                                 }
                                                 else
                                                 {
                                                     Send(addedcount + " master has been added.\n" + count + " masters are already added:\n" + countstr);
                                                 }
                                             }
                                         }
                                     }
                                     else if (sp1.Length > 0)
                                     {
                                         if (sp1[1].Trim() != string.Empty)
                                         {
                                             if (!adminlist.Text.ToLower().Contains(sp1[1].ToLower()))
                                             {
                                                 adminlist.Text += sp1[1] + "\n";
                                                 Send("1 master has been added.");
                                             }
                                             else
                                             {
                                                 Send("'" + sp1[1] + "' is already added");
                                             }
                                         }
                                         else
                                         {
                                             Send("Command syntax error!");
                                         }
                                     }
                                     else
                                     {
                                         Send("use 'am#id' or 'am#master1,master2,master3'");
                                     }
                                 }
                                 //Add auto welcomer message
                                 if ((NewMessage.Body.ToLower().StartsWith("awl/") || (NewMessage.Body.ToLower().StartsWith("awlc/")) && (NewMessage.From.Resource.ToLower() == master || MasterShip(NewMessage.From.Resource.ToLower()))))
                                 {
                                     string[] sp1 = NewMessage.Body.Split('/');
                                     switch (sp1[1].ToLower())
                                     {
                                         case "on":
                                             {
                                                 if (this.wlmanage == "on")
                                                 {
                                                     Send("Auto welcomer change can not be turned on while 'Welcomer' is turned on.\nWelcomer Command: wl/on or wl/off");
                                                 }
                                                 break;
                                             }
                                         case "off":
                                             {
                                                 break;
                                             }
                                     }
                                 }
                                 //MEMBER ONLY
                                 if (NewMessage.Body.ToLower() == "#mem")
                                 {
                                 }
                                 //Reporter add
                                 if (NewMessage.Body.Trim().ToLower() == ("#rep+"))
                                 {
                                     if (reportmanage == "on")
                                     {
                                         Adder(NewMessage.From.Resource, reportlist, "You have already activated reporter", "You  activated reporter!\nNOTE: Make sure that you have added the bot to your AddList.");
                                     }
                                     else
                                     {
                                         Send("Sorry Reporter not is turned on!");
                                     }
                                 }
                                 //Score transfer over to room
                                 if (NewMessage.Body.Trim().ToLower().StartsWith("trns#") && NewMessage.From.Resource.ToLower() != x.Username.ToLower())
                                 {
                                     try
                                     {
                                         string[] sp1 = NewMessage.Body.Split('#');
                                         int amout = Convert.ToInt32(sp1[1]);
                                         if (amout > 0)
                                         {
                                             if (Transfermanage == "on")
                                             {
                                                 ToRoomTransfer(NewMessage.From.Resource, NewMessage.From.Resource, amout, "\n>> " + NewMessage.From.Resource + "\nYour score transfer of " + amout + " has been transferred successfuly. Please send 'accept#trns' in any room that has Nizzc bot joint.");
                                             }
                                             else
                                             {
                                                 Send("Transfer option is not turned on.\nPlease ask bot owner to enable this option");
                                             }
                                         }
                                         else
                                         {
                                             Send("Sorry " + amout + " is not tansferable score points.");
                                         }
                                     }
                                     catch
                                     {
                                         Send("\n>> " + NewMessage.From.Resource + "\nSorry your command is not well constructed!");
                                     }
                                 }
                                 if (NewMessage.Body.Trim().ToLower() == ".s" && NewMessage.From.Resource.ToLower() != x.Username.ToLower())
                                 {
                                     Send("Use .r instead of .s !");
                                 }
                                 if (NewMessage.Body.Trim().ToLower() ==".r" && NewMessage.From.Resource.ToLower() != x.Username.ToLower())
                                 {
                                     WheelIt(NewMessage.From.Resource);
                                 }
                                 if (NewMessage.Body.Trim().ToLower().StartsWith("trnsto#") && NewMessage.From.Resource.ToLower() != x.Username.ToLower())
                                 {
                                     try
                                     {
                                         string[] sp1 = NewMessage.Body.Split('#');
                                         int amout = Convert.ToInt32(sp1[2]);
                                         if (amout > 0)
                                         {
                                             if (sp1[1] != NewMessage.From.Resource)
                                             {
                                                 if (Transfermanage == "on")
                                                 {
                                                     ToRoomTransfer(NewMessage.From.Resource, sp1[1], amout, "\n>> " + NewMessage.From.Resource + "\nYour score transfer of " + amout + " has been transferred successfuly. Please tell '" + sp1[1] + "' to send 'accept#trns' in any room to save his score point in that room. Make sure that room has any bot of ours joint.");
                                                 }
                                                 else
                                                 {
                                                     Send("Transfer option is not turned on.\nPlease ask bot owner to enable this option");
                                                 }
                                             }
                                             else
                                             {
                                                 Send("To transfer score points to another room for your self use 'trns#amount'.");
                                             }
                                         }
                                         else
                                         {
                                             Send("Sorry " + amout + " is not tansferable score points.");
                                         }
                                     }
                                     catch
                                     {
                                         Send("\n>> " + NewMessage.From.Resource + "\nSorry your command is not well constructed!");
                                     }
                                 }
                                 //Reporter remover
                                 if (reportmanage == "on" && NewMessage.Body.Trim().ToLower() == ("#rep-"))
                                 {
                                     if (reportmanage == "on")
                                     {
                                         Remover(NewMessage.From.Resource, reportlist, "You have decativated reporter", "You have not activated reporter");
                                     }
                                     else
                                     {
                                         Send("Sorry Reporter not is turned on!");
                                     }
                                 }
                                 //Reproter on Message
                                 if (NewMessage.Body.Trim() != string.Empty && reportmanage == "on")
                                 {
                                     Reporter(NewMessage.From.Resource, "Chat from '" + NewMessage.From.Resource + "' in '" + Roomname1 + "'\n---Message---\n" + NewMessage.Body, reportlist);
                                 }
                                 //show admin list
                                 if ((NewMessage.Body.ToLower().StartsWith("show/masters") || NewMessage.Body.ToLower().StartsWith("show/master") && (NewMessage.From.Resource.ToLower() == master || MasterShip(NewMessage.From.Resource.ToLower()))))
                                 {
                                     string addmin = "";
                                     foreach (string l in adminlist.Lines)
                                     {
                                         if (l.Trim() == string.Empty)
                                         {
                                         }
                                         else
                                         {
                                             addmin += l + "\n";
                                         }
                                         System.Threading.Thread.Sleep(1);
                                     }
                                     Send("Owner:\n" + master + "\n\nAdministrators:\n" + addmin);
                                 }
                                 //Bad id list
                                 if (NewMessage.Body.ToLower().StartsWith("bjid#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     //for better performce, do this in separate method.
                                     if (!FullMaster)
                                         Send("Bot should have 'owner' privilege.\nSend 'Help/owner' to get help for this.");
                                     else
                                     {
                                         string[] sp1 = NewMessage.Body.Trim().Split('#');
                                         if (sp1[1].Contains(","))
                                         {
                                             int count = 0;
                                             string countstr = "";
                                             int addedcount = 0;
                                             string[] comma = sp1[1].Trim().Split(',');
                                             for (int i = 0; i < comma.Count(); i++)
                                             {
                                                 if (!badjidlist.Text.ToLower().Contains(comma[i].ToLower()))
                                                 {
                                                     badjidlist.Text += comma[i] + "\n";
                                                     addedcount++;
                                                 }
                                                 else
                                                 {
                                                     count++;
                                                     countstr = countstr + comma[i] + "\n";
                                                 }
                                                 System.Threading.Thread.Sleep(10);
                                             }
                                             if (countstr.Trim() == string.Empty && count == 0 && addedcount > 0)
                                             {
                                                 Send(comma.Count() + " bad IDs have been added to 'Bad IDs list'");
                                             }
                                             else
                                             {
                                                 if (count == 1)
                                                 {
                                                     if (addedcount > 1)
                                                     {
                                                         Send(addedcount + " IDs have been added bad IDs list.\n" + count + " ID is already added: '" + countstr);
                                                     }
                                                     else
                                                     {
                                                         Send(addedcount + " ID has been added bad IDs list.\n" + count + " ID is already added: '" + countstr);
                                                     }
                                                 }
                                                 else
                                                 {
                                                     if (addedcount > 1)
                                                     {
                                                         Send(addedcount + " IDs have been added bad IDs list.\n" + count + " IDs are already added: '" + countstr);
                                                     }
                                                     else
                                                     {
                                                         Send(addedcount + " ID has been added bad IDs list.\n" + count + " IDs are already added: '" + countstr);
                                                     }
                                                 }
                                             }
                                         }
                                         else if (!sp1[1].Contains("#"))
                                         {
                                             if (!badjidlist.Text.ToLower().Contains(sp1[1]))
                                             {
                                                 badjidlist.Text += sp1[1] + "\n";
                                                 Send("1 ID has been added to bad IDs list");
                                             }
                                             else
                                             {
                                                 Send("'" + sp1[1] + "' is already added");
                                             }
                                         }
                                         else
                                         {
                                             Send("Command syntax error!\nUse 'bjid#id' or 'bjid#id1,id2,id3'");
                                         }
                                     }
                                 }
                                 //Change HELp
                                 if (NewMessage.Body.ToLower().StartsWith("st/") && (NewMessage.From.Resource.ToLower() == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     try
                                     {
                                         string[] sp1 = NewMessage.Body.Split('#');
                                         if (sp1[1].Trim() != string.Empty)
                                         {
                                             x.Status = sp1[1];
                                             x.SendMyPresence();
                                             Send("Help message is changed to '" + sp1[1] + "'");
                                         }
                                     }
                                     catch { }
                                 }
                                 //Delete Bad language
                                 if (NewMessage.Body.ToLower().StartsWith("dbadlw#") && (NewMessage.From.Resource.ToLower() == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     try
                                     {
                                         string[] sp1 = NewMessage.Body.Split('#');
                                         if (sp1[1].Trim() != string.Empty)
                                         {
                                             Remover(sp1[1], badla, ":", "'" + sp1[1] + "' has been removed from Bad language list.", "'" + sp1[1] + "' doesn't exist.");
                                         }
                                         else
                                         {
                                             Send("Command is incomplete!");
                                         }
                                     }
                                     catch
                                     {
                                     }
                                 }
                                 //Think Game 
                                 if (NewMessage.Body.ToLower().Trim() == luckynumber.ToString().Trim() && luckymanager.ToLower() == "on")
                                 {
                                     try
                                     {
                                         ThinkIt(NewMessage.From.Resource);
                                     }
                                     catch (Exception v)
                                     {
                                     }
                                 }
                                 //Shout Game
                                 if (NewMessage.Body.ToLower().Trim() == Shoutword.ToString().Trim() && Shoutmanage.ToLower() == "on")
                                 {
                                     try
                                     {
                                         ShoutIt(NewMessage.From.User);
                                     }
                                     catch (Exception v)
                                     {
                                     }
                                 }
                                 //Del admin
                                 if (NewMessage.Body.ToLower().StartsWith("dm#") && (NewMessage.From.Resource.ToLower() == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     string[] sp1 = NewMessage.Body.Split('#');
                                     if (NewMessage.From.Resource == sp1[1] && NewMessage.From.Resource == master)
                                     {
                                         Send("Sorry, you can't your self while you are owner.");
                                     }
                                     else if (sp1[1] == master && NewMessage.From.Resource != master)
                                     {
                                         Send("Sorry, you can't remove bot owner.");
                                     }
                                     else
                                     {//back
                                         Remover(sp1[1], adminlist, "'" + sp1[1] + "' has been removed from bot masters list", "Sorry, '" + sp1[1] + "' was not bot master");
                                     }
                                 }
                                 if (NewMessage.Body.ToLower().StartsWith("jokeint#") && (NewMessage.From.Resource.ToLower() == master.ToLower() || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     //for better performce, do this in separate method.
                                     return;
                                     string[] sp1 = NewMessage.Body.Split('#');
                                     //Form1 hh = new Form1();
                                     foreach (string l in Form1.invlidw.Lines)
                                     {
                                         if (jokemanage == "on")
                                         {
                                             if (sp1[1].ToLower().Contains(l.ToLower()))
                                             {
                                                 Send("'" + sp1[1] + "' is not valid");
                                             }
                                             else
                                             {
                                                 jokeinterval = Convert.ToInt32(sp1[1]);
                                                 Send("Joke interval is set to: " + sp1[1]);
                                             }
                                         }
                                         else
                                         {
                                             Send("Please enable joke option first");
                                         }
                                         //this will affect your bot performance, please do in separate methoid.
                                         System.Threading.Thread.Sleep(1);
                                     }
                                 }
                                 //Clear Badlanguage
                                 if (NewMessage.Body.ToLower().StartsWith("clear/badl") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     badla.Clear();
                                     Send("Badlanguage list cleared!");
                                 }
                                 //recognizer set
                                 if (NewMessage.Body.ToLower().StartsWith("rec#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {//done
                                     try
                                     {
                                         string[] sp1 = NewMessage.Body.Split('#');
                                         RecognizerAdd(sp1[1] + ":" + sp1[2], "", sp1[1]);
                                     }
                                     catch { Send("Command sytax error!"); }
                                 }
                                 //Member by Member Message
                                 if (NewMessage.Body.ToLower().StartsWith("mem#") && NewMessage.From.Resource.ToLower() != x.Username.ToLower())
                                 {
                                     if (!IsMaster)
                                         Send("Sorry, Bot doesnt have any privilege to do this action. Please contact the bot master or room admin/owner.");
                                     else
                                         if (MemberByMembermanage == "on")
                                         {
                                             string[] sp1 = NewMessage.Body.Split('#');
                                             if (sp1[0].Trim() != string.Empty)
                                             {
                                                 Send("/mem " + sp1[1]);
                                                 Send("'" + sp1[1] + "' is membered.");
                                             }
                                             else
                                             {
                                                 Send("Sorry, Command is not well construted!");
                                             }
                                         }
                                         else
                                         {
                                             Send("Sorry, this option is not turned on!");
                                         }
                                 }
                                 //Lucky Message
                                 if (NewMessage.Body.ToLower().StartsWith("lkmsg#") && NewMessage.From.Resource != x.Username && (adminlist.Text.Contains(NewMessage.From.Resource) || NewMessage.From.Resource == master))
                                 {
                                     if (luckymanager == "on")
                                     {
                                         try
                                         {
                                             string[] sp1 = NewMessage.Body.Split('#');
                                             LuckyMsg = sp1[1].Replace("%amount%", LuckyScore.ToString());
                                             Send("Lucky Notification Message is changed to '" + LuckyMsg + "'");
                                         }
                                         catch { }
                                     }
                                     else
                                     {
                                         Send("Lucky is not turned ON. Please turn ON first and try again.");
                                     }
                                 }
                                 if (badlanguagemanage == "on" && NewMessage.Body.ToLower().StartsWith("badlmsg#") && NewMessage.From.Resource != x.Username && (adminlist.Text.Contains(NewMessage.From.Resource) || NewMessage.From.Resource == master))
                                 {
                                     try
                                     {
                                         string[] sp1 = NewMessage.Body.Split('#');
                                         warningMessa = sp1[1];
                                         Send("Badlanguage Warning message is changed to '" + warningMessa + "'");
                                     }
                                     catch (Exception v)
                                     {
                                     }
                                 }
                                 if (badlanguagemanage == "on" && NewMessage.Body.Trim() != string.Empty && NewMessage.From.Resource != x.Username && !MasterShip(NewMessage.From.Resource) && NewMessage.From.Resource != master)
                                 {
                                     try
                                     {
                                         if (IsMaster)
                                         {
                                             badlang(NewMessage.Body, NewMessage.From.Resource);
                                         }
                                     }
                                     catch (Exception v)
                                     {
                                     }
                                 }
                                 //Delete
                                 if (NewMessage.Body.ToLower().StartsWith("#reset") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     YesNo = "reset";
                                     Send("TIP:\nBefore you reset please backup your room to our server for future safety...");
                                     Send("...and reset it after 2minutes.");
                                     Send("Are you sure to reset your room? This will erase entire your room settings, files, local backups.\nNO\nNO\nNO\nYes");
                                 }
                                 if (NewMessage.Body.ToLower().StartsWith("badlw#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     //bad language
                                     if (!FullMaster)
                                         Send("Bot should have 'owner' privilege.\nSend 'Help/owner' to get help for this.");
                                     else
                                     {
                                         string[] sp1 = NewMessage.Body.Split('#');
                                         if (sp1.Count() > 1)
                                         {
                                             if (this.badlanguagemanage == "on")
                                             {
                                                 if (sp1[2] == "0" || sp1[2] == "4" || sp1[2] == "3" || sp1[2] == "2" || sp1[2] == "1")
                                                 {
                                                     try
                                                     {
                                                         // action = Convert.ToInt16(sp1[2]);
                                                         badlangAdder(sp1[1], sp1[2]);
                                                     }
                                                     catch (Exception f)
                                                     {
                                                     }
                                                 }
                                                 else
                                                 {
                                                     Send("'" + sp1[2] + "' is not valid action");
                                                 }
                                             }
                                             else
                                             {
                                                 Send("Please enable Bad language detection first");
                                             }
                                         }
                                         else
                                         {
                                             Send("Use 'badlw#expression#action'\nEx: badlw#bastard#5");
                                         }
                                     }
                                 }
                                 //show id filter length
                                 if (NewMessage.Body.ToLower() == ("show/jidlen") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     Send("ID filter length is: '" + idlength + "'\nTo change use 'jidlen#length");
                                 }
                                 //show Resource filter length
                                 if (NewMessage.Body.ToLower() == ("show/reslen") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     Send("Resource filter length is: '" + reslength + "'\nTo change use 'reslen#length'");
                                 }
                                 //Show message filter length
                                 if (NewMessage.Body.ToLower() == ("show/msglen") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     Send("Message filter length is: '" + msglength + "'\nTo change use 'msglen#length'");
                                 }
                                 //Show score points
                                 try
                                 {
                                     if (NewMessage.From.Resource.ToLower().Trim() != x.Username.ToLower().Trim() && NewMessage.Body.ToLower().Trim() == "show/myscore")
                                     {
                                         try
                                         {
                                             Shower(NewMessage.From.Resource, luckylist, ':');
                                         }
                                         catch { }
                                     }
                                 }
                                 catch { }
                                 //Show forbidden users
                                 if (NewMessage.Body.ToLower() == ("show/fjid") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     Send("List of forbidden users: \n" + formbiddenuserslist.Text + "\nAction: '" + forbiddenjidaction.ToLower().Replace("1", "kick ").Replace("2", "ban ").Replace("3", "mute ").Replace("4", "IP ban ") + "'");
                                 }
                                 //show bad jid list
                                 if (NewMessage.Body.ToLower() == ("show/bjid") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     Send("List of bad jid users: \n" + badjidlist.Text + "\nAll these IDS are marked as flooders and will be banned with their IPs if censor finds them.");
                                 }
                                 if (NewMessage.Body.ToLower() == ("show/badr") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     Send("List of bad resource users: \n" + badreslist.Text + "\nAll these IDS are marked as flooders and will be banned with their IPs if censor finds them.");
                                 }
                                 //Show Badlanguage
                                 if (NewMessage.Body.ToLower() == ("show/badlw") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     if (badla.Text.Trim() != string.Empty)
                                     {
                                         Send("List of Badlanguage words/phrases : \n" + badla.Text.Replace(":1", " : kick ").Replace(":2", " : ban ").Replace(":3", " : mute ").Replace(":4", " : Voice Revocation").Replace(":5", " : Warning"));
                                     }
                                     else
                                     {
                                         Send("No bad word or phrase in bot database");
                                     }
                                 }
                                 //add bad link
                                 if (NewMessage.Body.ToLower() == ("blnk#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     //handle bad links. Please first configure with the bad links.
                                     string[] sp1 = NewMessage.Body.Split('#');
                                     if (!badlinks.Text.ToLower().Contains(sp1[1].ToLower()))
                                     {
                                         if (sp1[1].Contains("."))
                                         {
                                             badlinks.Text += sp1[1] + "\n";
                                             Send("'" + sp1[1] + "' has been forbidden to be sent to this room");
                                         }
                                         else
                                         {
                                             Send("'" + sp1[1] + "' is not a link");
                                         }
                                     }
                                     else
                                     {
                                         Send("Link already forbidden!");
                                     }
                                 }
                                 //Remove bad links
                                 if (NewMessage.Body.ToLower().StartsWith("rblnk#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     string[] sp1 = NewMessage.Body.Split('#');
                                     if (badlinks.Text.ToLower().Contains(sp1[1].ToLower()))
                                     {
                                         //incomplete
                                     }
                                 }
                                 if (NewMessage.Body.ToLower().StartsWith("smartdec" + cChar) && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     if (!FullMaster)
                                         Send("Bot should have 'owner' privilege.\nSend 'Help/owner' to get help for this.");
                                     else
                                     {
                                         string[] sp1 = NewMessage.Body.Split(cChar);
                                         if (sp1[1].ToLower() == "on")
                                         {
                                             if (SmartDet != "on")
                                             {
                                                 SmartDet = "on";
                                                 Send("Smart Detection is enabled!");
                                             }
                                             else
                                             {
                                                 Send("Smart Detection is already enabled!");
                                             }
                                         }
                                         else if (sp1[1].ToLower() == "off")
                                         {
                                             if (SmartDet != "off")
                                             {
                                                 SmartDet = "off";
                                                 Send("Smart Detection  is disabled!");
                                             }
                                             else
                                             {
                                                 Send("Smart Detection is already disabled!");
                                             }
                                         }
                                         else
                                         {
                                             Send("'" + sp1[1] + "' is not valid boolean!");
                                         }
                                     }
                                 }
                                 //Word Filter
                                 if (NewMessage.Body.ToLower().StartsWith("fyfyfuy7745ufu8" + cChar) && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     string[] sp1 = NewMessage.Body.Split(cChar);
                                     if (sp1[1].ToLower() == "on")
                                     {
                                         if (wordfiltermanage != "on")
                                         {
                                             wordfiltermanage = "on";
                                             Send("Word filter is enabled!");
                                         }
                                         else
                                         {
                                             Send("Word filter is already enabled!");
                                         }
                                     }
                                     else if (sp1[1].ToLower() == "off")
                                     {
                                         if (wordfiltermanage != "off")
                                         {
                                             wordfiltermanage = "off";
                                             Send("Word filter is disabled!");
                                         }
                                         else
                                         {
                                             Send("Word filter is already disabled!");
                                         }
                                     }
                                     else
                                     {
                                         Send("'" + sp1[1] + "' is not valid boolean!");
                                     }
                                 }
                                 //Quiz Question Termination
                                 if (NewMessage.Body.ToLower().StartsWith("qzt#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     try
                                     {
                                         string[] sp1 = NewMessage.Body.Split('#');
                                         if (Convert.ToInt32(sp1[1]) >= 10)
                                         {
                                             QuizAbortCounter = Convert.ToInt32(sp1[1]) * 1000;
                                             //QuizRepeatCounter = Convert.ToInt16(sp1[1]) * 1000;
                                             QuizeAborter.Interval = QuizAbortCounter;
                                             QuizeAborter.Stop();
                                             QuizeAborter.Start();
                                             Send("Quiz Question holding interval  is changed to '" + sp1[1] + "seconds'");
                                         }
                                         else
                                         {
                                             Send("Quiz question holding interval should be greater than 10seconds to avoid room flooding.");
                                         }
                                     }
                                     catch
                                     {
                                         Send("Command syntax error!");
                                     }
                                 }
                                 //Quiz Interval
                                 if (NewMessage.Body.ToLower().StartsWith("qzint#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     try
                                     {
                                         string[] sp1 = NewMessage.Body.Split('#');
                                         if (Convert.ToInt32(sp1[1]) >= 10)
                                         {
                                             QuizInterval = Convert.ToInt32(sp1[1]) * 1000;
                                             QuizRepeatCounter = Convert.ToInt32(sp1[1]) * 1000;
                                             QuizRepeater.Interval = QuizRepeatCounter;
                                             QuizRepeater.Stop();
                                             QuizRepeater.Start();
                                             Send("Quiz Question Repetition interval  is changed to '" + sp1[1] + "seconds'");
                                         }
                                         else
                                         {
                                             Send("Quiz question repetition interval should be greater than 10seconds to avoid room flooding.");
                                         }
                                     }
                                     catch
                                     {
                                         Send("Command syntax error!");
                                     }
                                 }
                                 //Message flood scanner
                                 try
                                 {
                                     if (NewMessage.Body.Trim() != string.Empty && msgfiltermanage == "on" && NewMessage.From.Resource.ToLower() != x.Username.ToLower() && NewMessage.From.Resource.ToLower() != master.ToLower() && !MasterShip(NewMessage.From.Resource.ToLower()))
                                     {
                                         //Do this in separate method, this fastens the flood detection.
                                         try
                                         {
                                             if (NewMessage.Body.Length > msglength)
                                             {
                                                 if (IsFlood)
                                                 {
                                                     /*No need of this, bot is already having Anti disconnection.
                                                      But helps in case your bot lefts due to flood overwhelm. */
                                                     //TempoWlOFF = "on";
                                                     //ReturnON();
                                                 }
                                                 if (FullMaster)
                                                 {
                                                     doaction(NewMessage.From.Resource, "/ban f ", "");
                                                     //stop under flood for the current flood.
                                                     isUnderFloodTimer.Stop();
                                                     ThreadMessage = "Flood sensation has been detected and banned!";
                                                     //Set under flood.
                                                     isUnderFloodTimer.Start();
                                                 }
                                             }
                                         }
                                         catch (Exception v)
                                         {
                                         }
                                     }
                                 }
                                 catch { }
                                 //Quiz Answer
                                 if (NewMessage.Body.ToLower().Trim() == QuizQuestionAnswer.ToLower().Trim() && NewMessage.From.Resource != x.Username && quizmanage == "on")
                                 {
                                     try
                                     {
                                         long Timed = QuizElapsedTime.ElapsedMilliseconds;
                                         if (Timed / 1000 <= 3)
                                         {
                                             Send("Oh " + NewMessage.From.Resource + ", how is this possible? only taken '" + Timed / 1000 + "seconds' to answer!");
                                         }
                                         else if (Timed / 1000 >= 4 && Timed / 1000 <= 10)
                                         {
                                             Send("what a clever!\n" + NewMessage.From.Resource + ", Keep it up! '" + Timed / 1000 + "seconds' to answer!");
                                         }
                                         else if (Timed / 1000 >= 11 && Timed / 1000 <= 20)
                                         {
                                             Send("Very hast!\n" + NewMessage.From.Resource + ", Answered in '" + Timed / 1000 + "seconds' to answer!");
                                         }
                                         else if (Timed / 1000 >= 21 && Timed / 1000 <= 40)
                                         {
                                             Send("you good!\n" + NewMessage.From.Resource + ", Answered in '" + Timed / 1000 + "seconds' to answer!");
                                         }
                                         else if (Timed / 1000 >= 41 && Timed / 1000 <= 60)
                                         {
                                             Send("Very hast!\n" + NewMessage.From.Resource + ", Answered in '" + Timed / 1000 + "seconds' to answer!");
                                         }
                                         else if (Timed / 1000 >= 61)
                                         {
                                             Send("good!\n" + NewMessage.From.Resource + ",Next time try to improve.\n Answered in '" + Timed / 1000 + "seconds' to answer!");
                                         }
                                         AddScore(NewMessage.From.Resource, QuizScore);
                                         QuizAskibleOption = "on";
                                         ReadQuizQuestio();
                                     }
                                     catch (Exception f)
                                     {
                                     }
                                 }
                                 //message line filter
                                 if (NewMessage.Body != string.Empty && NewMessage.From.Resource != master && NewMessage.From.Resource != x.Username && !MasterShip(NewMessage.From.Resource))
                                 {
                                     try
                                     {
                                         if (IsFlood)
                                         {
                                             TempoWlOFF = "on";
                                             ReturnON();
                                         }
                                         if (FullMaster)
                                         {
                                             if (LineFiltermanage == "on")
                                             {
                                                 try
                                                 {
                                                     System.Windows.Forms.RichTextBox rc = new System.Windows.Forms.RichTextBox();
                                                     rc.Text = NewMessage.Body;
                                                     MLF(NewMessage.From.Resource, rc);
                                                 }
                                                 catch { }
                                             }
                                             return;
                                         }
                                     }
                                     catch (Exception v)
                                     {
                                     }
                                 }
                                 //Change Message Line Filter Length
                                 if (NewMessage.Body.ToLower().StartsWith("mlflen#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     try
                                     {
                                         string[] sp1 = NewMessage.Body.Split('#');
                                         if (Convert.ToInt32(sp1[1]) > 0)
                                         {
                                             LineFilterlen = Convert.ToInt32(sp1[1]);
                                             Send("Message Line filter length is changed to '" + LineFilterlen + "'");
                                         }
                                         else
                                         {
                                             Send("Line Filter limit should be greater than 0");
                                         }
                                     }
                                     catch
                                     {
                                         Send("Command syntax error!");
                                     }
                                 }
                                 //Change Quiz Scores
                                 if (NewMessage.Body.ToLower().StartsWith("qzp#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     try
                                     {
                                         string[] sp1 = NewMessage.Body.Split('#');
                                         QuizScore = Convert.ToInt32(sp1[1]);
                                         Send("Quiz Score value is changed to '" + QuizScore + "'");
                                     }
                                     catch
                                     {
                                         Send("Command syntax error!");
                                     }
                                 }
                                 //Soccer Penalty Score Win
                                 if (NewMessage.Body.ToLower().StartsWith("pltwp#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     try
                                     {
                                         string[] sp1 = NewMessage.Body.Split('#');
                                         SoccerScoreWin = Convert.ToInt32(sp1[1]);
                                         Send("Penalty Score value (if win) is changed to '" + SoccerScoreWin + "'");
                                     }
                                     catch
                                     {
                                         Send("Command syntax error!");
                                     }
                                 }
                                 //Soccer Penalty Score draw
                                 if (NewMessage.Body.ToLower().StartsWith("pltsp#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     try
                                     {
                                         string[] sp1 = NewMessage.Body.Split('#');
                                         SoccerScoreSame = Convert.ToInt32(sp1[1]);
                                         Send("Penalty Score value (if same) is changed to '" + SoccerScoreSame + "'");
                                     }
                                     catch
                                     {
                                         Send("Command syntax error!");
                                     }
                                 }
                                 //Redeem score points
                                 if (NewMessage.Body.Trim() == "accept#trns" && NewMessage.From.Resource.ToLower() != x.Username.ToLower())
                                 {
                                     try
                                     {
                                         if (Transfermanage == "on")
                                         {
                                             Send("Please wait while we are confirming your transfer...");
                                             TransferRedeem(NewMessage.From.Resource);
                                         }
                                         else
                                         {
                                             Send("Sorry, Score transfer is not turned on.\nPlease ask bot owner to turn on.");
                                             Send("To refund your score points go back to the room from which it is transfered");
                                             Send("and send 'accept#trns' to save back your points. Or accept in another room.");
                                         }
                                     }
                                     catch (Exception v)
                                     {
                                         Send("There is error on transferring your score points. Please contact the bot owner");
                                     }
                                 }
                                 //Bomb Out a user
                                 if (NewMessage.Body.Trim().ToLower().StartsWith("bm#"))
                                 {
                                     try
                                     {
                                         if (!IsMaster)
                                         {
                                             Send("Sorry, Bot is not admin/owner. Please contact bot Master " + (master) + " or room Admin/Owner.");
                                             Send("Send HELP/ADMIN  to get help for this.");
                                         }
                                         else
                                         {
                                             string[] sp1 = NewMessage.Body.Split('#');
                                             if (sp1[1].ToLower().Trim() != x.Username.ToLower().Trim())
                                             {
                                                 string isMaster = "";
                                                 foreach (string l in adminlist.Lines)
                                                 {
                                                     if (l.ToLower() == sp1[1].ToLower())
                                                     {
                                                         isMaster = "yes";
                                                     }
                                                     System.Threading.Thread.Sleep(10);
                                                 }
                                                 if (sp1[1].ToLower() != master && isMaster != "yes")
                                                 {
                                                     if (sp1[1].ToLower() != NewMessage.From.Resource.ToLower())
                                                     {
                                                         BombUser(NewMessage.From.Resource, sp1[1]);
                                                     }
                                                     else
                                                     {
                                                         Send("\n>> " + NewMessage.From.Resource + "\nYou are bombing yourself, hhh ok!");
                                                         BombUser(NewMessage.From.Resource, sp1[1]);
                                                     }
                                                 }
                                                 else
                                                 {
                                                     Send("\n>> " + NewMessage.From.Resource + "\n'" + sp1[1] + "' You are bombing bot master but know that he/she can do whatever he/she wants");
                                                     BombUser(NewMessage.From.Resource, sp1[1]);
                                                 }
                                             }
                                             else
                                             {
                                                 Send("\n>> " + NewMessage.From.Resource + "\nHahaha! trying to bomb me out? that is impossible!");
                                             }
                                         }
                                     }
                                     catch (Exception f)
                                     {
                                         Send("Command syntax error!");
                                     }
                                 }
                                 //Lucky Game Score
                                 if (NewMessage.Body.ToLower().StartsWith("lkp#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     try
                                     {
                                         string[] sp1 = NewMessage.Body.Split('#');
                                         LuckyScore = Convert.ToInt32(sp1[1]);
                                         Send("Lucky Point value is changed to '" + LuckyScore + "'");
                                     }
                                     catch
                                     {
                                         Send("Command syntax error!");
                                     }
                                 }
                                 //Shout Score
                                 if (NewMessage.Body.ToLower().StartsWith("shtp#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     try
                                     {
                                         string[] sp1 = NewMessage.Body.Split('#');
                                         ShoutScore = Convert.ToInt32(sp1[1]);
                                         Send("Shout Game point value is changed to '" + ShoutScore + "'");
                                     }
                                     catch
                                     {
                                         Send("Command syntax error!");
                                     }
                                 }
                                 //Bomb Cost
                                 if (NewMessage.Body.ToLower().StartsWith("bmc#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     try
                                     {
                                         string[] sp1 = NewMessage.Body.Split('#');
                                         if (sp1[1].Trim() != "0")
                                         {
                                             bombcost = Convert.ToInt32(sp1[1]);
                                             Send("Bomb cost is changed to '" + bombcost + "points'");
                                         }
                                         else
                                         {
                                             Send("Bomb cost should be more than 0");
                                         }
                                     }
                                     catch
                                     {
                                         Send("Command syntax error!");
                                     }
                                 }
                                 //Bomb Shield Cost
                                 if (NewMessage.Body.ToLower().StartsWith("bshc#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     try
                                     {
                                         string[] sp1 = NewMessage.Body.Split('#');
                                         bombcost = Convert.ToInt32(sp1[1]);
                                         Send("Bomb Shield cost is changed to '" + bombcost + "points'");
                                     }
                                     catch
                                     {
                                         Send("Command syntax error!");
                                     }
                                 }
                                 //Penalty Kick
                                 if (NewMessage.Body.ToLower().Trim() == "kick")
                                 {
                                     if (soccermanage == "on")
                                     {
                                         if (NewMessage.From.Resource.ToLower() == kicker.ToLower() && SoccerAbortTimer.Enabled == true)
                                         {
                                             KickSoccerIt(NewMessage.From.Resource);
                                         }
                                         else
                                         {
                                             if (kicker.Trim() != string.Empty && kicker2.Trim() != string.Empty)
                                             {
                                                 Send("Sorry, it is " + kicker + "'s turn");
                                             }
                                         }
                                     }
                                 }
                                 //Soccer Penalty Abort
                                 if (NewMessage.Body.ToLower() == "abort#penalty")
                                 {
                                     if (NewMessage.From.Resource.ToLower() == master.ToLower() || MasterShip(NewMessage.From.Resource.ToLower()) || NewMessage.From.Resource.ToLower() == kicker1)
                                     {
                                         if (SoccerAbortTimer.Enabled == true)
                                         {
                                             kicker = "";
                                             kicker1 = "";
                                             kicker2 = "";
                                             SoccerAccepteds.Clear();
                                             SoccerAwaiting.Clear();
                                             SoccerKicker = "";
                                             SoccerKickNumber = 0;
                                             SoccerAbortTimer.Stop();
                                             if (NewMessage.From.Resource.Trim().ToLower() == kicker1.Trim().ToLower())
                                             {
                                                 Send("Penalty Game is aborted by the game starter!");
                                             }
                                             else if (NewMessage.From.Resource.Trim().ToLower() == master.Trim().ToLower() || MasterShip(NewMessage.From.Resource.Trim().ToLower()))
                                             {
                                                 Send("Penalty Game is aborted by bot master!");
                                             }
                                         }
                                         else
                                         {
                                             Send("No penalty game is on progress!");
                                         }
                                     }
                                     else
                                     {
                                         Send("Only the starter of the game ('" + kicker1 + "') or bot masters can abort the game");
                                     }
                                 }
                                 string nuul = "";
                                 //Soccer or Penalty Game
                                 if (NewMessage.Body.ToLower().StartsWith("penalty#"))
                                 {
                                     try
                                     {
                                         string[] sp1 = NewMessage.Body.Split('#');
                                         if (soccermanage == "on")
                                         {
                                             nuul = sp1[2];
                                             if (sp1[1].ToLower() == NewMessage.From.Resource.ToLower())
                                             {
                                                 if (nuul.Trim() != string.Empty)
                                                 {
                                                     if (SoccerAccepteds.Text == string.Empty)
                                                     {
                                                         SoccerAccepteds.Text = sp1[1] + ":" + 0 + "\n";
                                                         SoccerAwaiting.Text = sp1[2];
                                                         kicker1 = sp1[1];
                                                         kicker2 = sp1[2];
                                                         kicker = sp1[1].Trim().ToLower();
                                                         Send("Tell your invitee('" + sp1[2] + "')to send 'accept#penalty' to accept the game.\nYou have 60seconds (1min) your game to be accepted.");
                                                         SoccerAbortTimer.Interval = 60000;
                                                         SoccerAbortTimer.Start();
                                                     }
                                                     else
                                                     {
                                                         Send("\n>> " + NewMessage.From.Resource + "\nSorry, there are other users playing this game.\nTry again after they finish.");
                                                     }
                                                 }
                                                 else
                                                 {
                                                     Send("Sorry, your command is not complete!");
                                                 }
                                             }
                                             else
                                             {
                                                 Send("\n>> " + NewMessage.From.Resource + "\nUser1 should be you.");
                                             }
                                         }
                                         else
                                         {
                                             Send("\n>> " + NewMessage.From.Resource + "\nSorry this game is not turned on. \nPlease inform bot masters to enable.");
                                         }
                                     }
                                     catch
                                     {
                                         Send("Command syntax error!");
                                     }
                                 }
                                 //Give Score by Master
                                 if (NewMessage.Body.Trim().ToLower().StartsWith("rew#") && NewMessage.From.Resource.ToLower() != x.Username.ToLower())
                                 {
                                     try
                                     {
                                         if (NewMessage.From.Resource.ToLower() == master.ToLower() || MasterShip(NewMessage.From.Resource.Trim().ToLower()))
                                         {
                                             string[] sp1 = NewMessage.Body.Split('#');
                                             int amout = Convert.ToInt32(sp1[2]);
                                             TransferTo(sp1[1], amout, NewMessage.From.Resource);
                                         }
                                         else
                                         {
                                             Send("Sorry, you dont have persmission for this command. Please contact " + master + "@nimbuzz.com for help");
                                         }
                                     }
                                     catch
                                     {
                                         Send("Command syntax error!");
                                     }
                                 }
                                 //ID filter Length
                                 if (NewMessage.Body.ToLower().StartsWith("jidlen#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     string[] sp1 = NewMessage.Body.Split('#');
                                     if (this.idfiltermanage == "on")
                                     {
                                         try
                                         {
                                             idlength = Convert.ToInt32(sp1[1]);
                                             Send("ID filter length has been changed to: " + sp1[1]);
                                         }
                                         catch
                                         {
                                             Send("Command syntax error!");
                                         }
                                     }
                                     else
                                     {
                                         Send("Please enable ID filter first");
                                     }
                                 }
                                 if (NewMessage.Body.ToLower().StartsWith("reslen#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     string[] sp1 = NewMessage.Body.Split('#');
                                     if (this.resfiltermanage == "on")
                                     {
                                         try
                                         {
                                             this.reslength = Convert.ToInt32(sp1[1]);
                                             Send("Resource filter length  has been changed to: " + sp1[1]);
                                         }
                                         catch
                                         {
                                             Send("Command syntax error!");
                                         }
                                     }
                                     else
                                     {
                                         Send("Please enable resource filter first");
                                     }
                                 }
                                 if (NewMessage.Body.ToLower().StartsWith("msglen#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     string[] sp1 = NewMessage.Body.Split('#');
                                         try
                                         {
                                             this.msglength = Convert.ToInt32(sp1[1]);
                                             Send("Message filter length is changed to: " + sp1[1]);
                                         }
                                         catch
                                         {
                                             Send("Command syntax error!");
                                         }
                                 }
                                 if (NewMessage.Body.ToLower().StartsWith("badr#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     //Use separate method for better performance.
                                     if (this.resfiltermanage == "on")
                                     {
                                         string[] sp1 = NewMessage.Body.Trim().Split('#');
                                         if (sp1[1].Contains(","))
                                         {
                                             int count = 0;
                                             string countstr = "";
                                             int addedcount = 0;
                                             string[] comma = sp1[1].Trim().Split(',');
                                             for (int i = 0; i < comma.Count(); i++)
                                             {
                                                 if (!badreslist.Text.ToLower().Contains(comma[i].ToLower()))
                                                 {
                                                     badreslist.Text += comma[i] + "\n";
                                                     addedcount++;
                                                 }
                                                 else
                                                 {
                                                     count++;
                                                     countstr = countstr + comma[i] + "\n";
                                                 }
                                                 System.Threading.Thread.Sleep(10);
                                             }
                                             if (countstr.Trim() == string.Empty && count == 0 && addedcount > 0)
                                             {
                                                 Send(comma.Count() + " bad resource have been added to 'Bad resource list'");
                                             }
                                             else
                                             {
                                                 if (count == 1)
                                                 {
                                                     if (addedcount > 1)
                                                     {
                                                         Send(addedcount + " resources have been added bad resource list.\n" + count + " resource is already added: '" + countstr);
                                                     }
                                                     else
                                                     {
                                                         Send(addedcount + " resource has been added bad resource list.\n" + count + " resource is already added: '" + countstr);
                                                     }
                                                 }
                                                 else
                                                 {
                                                     if (addedcount > 1)
                                                     {
                                                         Send(addedcount + " resource have been added bad resource list.\n" + count + " resources are already added: '" + countstr);
                                                     }
                                                     else
                                                     {
                                                         Send(addedcount + " resource has been added bad resource list.\n" + count + " resources are already added: '" + countstr);
                                                     }
                                                 }
                                             }
                                         }
                                         else if (!sp1[1].Contains("#"))
                                         {
                                             if (!badreslist.Text.ToLower().Contains(sp1[1]))
                                             {
                                                 badreslist.Text += sp1[1] + "\n";
                                                 Send("1 resource has been added to bad resource list");
                                             }
                                             else
                                             {
                                                 Send("'" + sp1[1] + "' is already added");
                                             }
                                         }
                                         else
                                         {
                                             Send("Command syntax error!");
                                         }
                                     }
                                     else
                                     {
                                         Send("Please enable Resource filter first");
                                     }
                                 }
                                 //Bad JID delete
                                 if (NewMessage.Body.ToLower().StartsWith("dbjid#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     try
                                     {
                                         string[] sp1 = NewMessage.Body.Split('#');
                                         Remover(sp1[1], badjidlist, "'" + sp1[1] + "' is removed from bad ID list.", "No such ID found in Bad jid list");
                                     }
                                     catch { }
                                 }
                                 //delete recognizer
                                 if (NewMessage.Body.ToLower().StartsWith("drec#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     string[] sp1 = NewMessage.Body.Split('#');
                                     Remover(sp1[1], recognizedw, ":", "'" + sp1[1] + "' has been removed from Recognized words.", "'" + sp1[1] + "' doesn't exist.");
                                 }
                                 //Delete resource
                                 if (NewMessage.Body.ToLower().StartsWith("dbadr#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     string[] sp1 = NewMessage.Body.Split('#');
                                     if (this.resfiltermanage == "on")
                                     {
                                         Remover(sp1[1], badreslist, "'" + sp1[1] + "' is removed from bad resource list.", "No such resource found");
                                     }
                                     else
                                     {
                                         Send("Please enable Resource filter first");
                                     }
                                 }
                                 //Delete recognizer word
                                 if (NewMessage.Body.ToLower() == ("clear/rec") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     recognizedw.Clear();
                                     Send("Recognizations Cleared!");
                                 }
                                 //show mfl
                                 if (NewMessage.Body.ToLower().StartsWith("show/mlflen") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     Send("Message Line Filter length: " + LineFilterlen);
                                 }
                                 //Show recognizer list
                                 if (NewMessage.Body.ToLower().StartsWith("show/rec") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     RecShow();
                                 }
                                 //Lucky Timer Counter
                                 if (NewMessage.Body.ToLower().StartsWith("lcint#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     string[] sp1 = NewMessage.Body.Split('#');
                                     if (this.luckymanager == "on")
                                     {
                                         try
                                         {
                                             LuckyTimerCount = Convert.ToInt32(sp1[1]) * 1000;
                                             LuckyTimer.Interval = LuckyTimerCount;
                                             Send("Lucky Notification Interval is changed to '" + sp1[1] + "seconds'");
                                         }
                                         catch (Exception r)
                                         {
                                             Send("Command syntax Error!");
                                         }
                                     }
                                     else
                                     {
                                         Send("Lucky is not turned ON. Please turn ON first and try again.");
                                     }
                                 }
                                 //Shout Game Interval
                                 if (NewMessage.Body.ToLower().StartsWith("shint#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     string[] sp1 = NewMessage.Body.Split('#');
                                     if (this.Shoutmanage == "on")
                                     {
                                         try
                                         {
                                             if (Convert.ToInt32(sp1[1]) >= 10)
                                             {
                                                 ShoutTimerCount = Convert.ToInt32(sp1[1]) * 1000;
                                                 ShoutTimer.Interval = ShoutTimerCount;
                                                 Send("Shout Game Notification Interval is changed to '" + sp1[1] + "seconds'");
                                             }
                                             else
                                             {
                                                 Send("Shout game notification interval should be greater than 10seconds to avoid room flooding.");
                                             }
                                         }
                                         catch (Exception r)
                                         {
                                             Send("Command syntax Error!");
                                         }
                                     }
                                     else
                                     {
                                         Send("Shout Game is not turned ON. Please turn ON first and try again.");
                                     }
                                 }
                                 //Bad Status list
                                 if (NewMessage.Body.ToLower().StartsWith("badst#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     string[] sp1 = NewMessage.Body.Split('#');
                                     if (this.statusfiltermanage == "on")
                                     {
                                         try
                                         {
                                             if (sp1[1].Trim() != string.Empty)
                                             {
                                                 Adder(sp1[1], badstatuslist, "'" + sp1[1] + "' already exist!", "'" + sp1[1] + "' is added to bad status list!");
                                             }
                                             else
                                             {
                                                 Send("Command syntax error!");
                                             }
                                         }
                                         catch
                                         {
                                             Send("Command syntax error!");
                                         }
                                     }
                                 }
                                 //Status length
                                 if (NewMessage.Body.ToLower().StartsWith("badstlen#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     string[] sp1 = NewMessage.Body.Split('#');
                                     if (this.statusfiltermanage == "on")
                                     {
                                         try
                                         {
                                             statusfilterlength = Convert.ToInt32(sp1[1]);
                                             ShoutTimer.Interval = ShoutTimerCount;
                                             Send("Status filter length is changed to '" + sp1[1] + "'");
                                         }
                                         catch (Exception r)
                                         {
                                             if (r.Message.Trim() != string.Empty)
                                             {
                                                 Send("Command syntax Error!");
                                             }
                                         }
                                     }
                                     else
                                     {
                                         Send("Status filter is not turned ON. Please turn ON first and try again.");
                                     }
                                 }
                                 //Anti Capita warning
                                 if (NewMessage.Body.ToLower().StartsWith("acpmsg#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     string[] sp1 = NewMessage.Body.Split('#');
                                     if (this.anticapitalmanage == "on")
                                     {
                                         CapitacMsg = sp1[1];
                                         Send("Anti - Capital Warning message is changed to '" + CapitacMsg + "'");
                                     }
                                     else
                                     {
                                         Send("Anti-Capital is not turned on. Please turn on first.");
                                     }
                                 }
                                     if (NewMessage.From.Resource.ToLower().Trim() == "admin")
                                     {
                                         try
                                         {
                                             x.Close();
                                             passch = "off";
                                             IsBackup = false;
                                             x1.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(master + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, x.Username + " is not member in " + Roomname1 + "."));
                                             x1.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(master + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, "Connection aborted!"));
                                               }
                                         catch { }
                                     }
                                 //Anti Capital Action
                                 if (NewMessage.Body.ToLower().StartsWith("acpa#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     string[] sp1 = NewMessage.Body.Split('#');
                                     if (this.anticapitalmanage == "on")
                                     {
                                         try
                                         {
                                             if (sp1[1] == "0" || sp1[1] == "1" || sp1[1] == "2" || sp1[1] == "3")
                                             {
                                                 capitalaction = sp1[1];
                                                 Send("Anti-Capital Action is changed to '" + sp1[1].Replace("0", "Warning").Replace("1", "Kick").Replace("2", "Ban").Replace("3", "Mute") + "'");
                                             }
                                             else
                                             {
                                                 Send("'" + sp1[1] + "' is not a valid action");
                                             }
                                         }
                                         catch (Exception r)
                                         {
                                             Send("Command syntax Error!");
                                         }
                                     }
                                     else
                                     {
                                         Send("Anti-Capital is not turned on. Please turn ON first and try again.");
                                     }
                                 }
                                 //Anti Capital
                                 try
                                 {
                                     if (NewMessage.From.Resource != x.Username && NewMessage.From.Resource != master && !MasterShip(NewMessage.From.Resource.ToLower()))
                                     {
                                         try
                                         {
                                             if (IsMaster)
                                             {
                                                 if (NewMessage.Body.Trim() == NewMessage.Body.Trim().ToUpper())
                                                 {
                                                     if (anticapitalmanage == "on")
                                                     {
                                                         if (IsFlood)
                                                         {
                                                             TempoWlOFF = "on";
                                                             ReturnON();
                                                         }
                                                         switch (capitalaction)
                                                         {
                                                             case "0":
                                                                 {
                                                                     Send(CapitacMsg.Replace("%user%", NewMessage.From.Resource).Replace("%msg%", NewMessage.Body).Replace("%L%", Environment.NewLine));
                                                                     break;
                                                                 }
                                                             case "1":
                                                                 {
                                                                     doaction(NewMessage.From.Resource, "/kick ", "\n'" + NewMessage.From.Resource + "' has been kicked off for using capital words.\nForbidden by: Bot Master");
                                                                     break;
                                                                 }
                                                             case "2":
                                                                 {
                                                                     doaction(NewMessage.From.Resource, "/ban ", "\n'" + NewMessage.From.Resource + "' has been banned for using capital words.\nForbidden by: Bot Master");
                                                                     break;
                                                                 }
                                                             case "3":
                                                                 {
                                                                     doaction(NewMessage.From.Resource, "/mute ", "\n'" + NewMessage.From.Resource + "' has been muted for using capital words.\nForbidden by: Bot Master");
                                                                     break;
                                                                 }
                                                         }
                                                     }
                                                 }
                                             }
                                         }
                                         catch (Exception v)
                                         {
                                         }
                                     }
                                 }
                                 catch { }
                                 //antikick count
                                 if (NewMessage.Body.ToLower().StartsWith("akcint#") && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     string[] sp1 = NewMessage.Body.Split('#');
                                     if (this.antikickmanage == "on")
                                     {
                                         try
                                         {
                                             if (Convert.ToInt32(sp1[1]) >= 10)
                                             {
                                                 this.antikickcounter = Convert.ToInt32(sp1[1]) * 1000;
                                                 antikicktime.Stop();
                                                 antikicktime.Interval = antikickcounter;
                                                 antikicktime.Start();
                                                 Send("Antikick duration has been changed to '" + sp1[1] + "seconds'");
                                             }
                                             else
                                             {
                                                 Send("Anti-kick interval should be greater than 10seconds to avoid room flooding.");
                                             }
                                         }
                                         catch (Exception f)
                                         {
                                             Send("Command syntax error!");
                                         }
                                     }
                                     else
                                     {
                                         Send("AntiKick is turned off. Please turn on and try again.");
                                     }
                                 }
                                 //Recognizer
                                 try
                                 {
                                     if (NewMessage.Body.ToLower().Trim() != string.Empty && NewMessage.From.Resource.Trim().ToLower() != x.Username.ToLower().Trim())
                                     {
                                         foreach (string l in recognizedw.Lines)
                                         {
                                             try
                                             {
                                                 if (reconizemanage == "on")
                                                 {
                                                     string[] word = l.Split(':');
                                                     if (NewMessage.Body.ToLower() == word[0].ToLower())
                                                     {
                                                         Send("\n>> " + NewMessage.From.Resource + ": " + word[1]);
                                                     }
                                                 }
                                             }
                                             catch (Exception v)
                                             {
                                             }
                                             // this will effect your performce, please use separate method.
                                             System.Threading.Thread.Sleep(10);
                                         }
                                     }
                                 }
                                 catch { }
                                 //about
                                 //Help for users
                                 try
                                 {
                                     if (NewMessage.Body.ToLower().Trim() == "help" && NewMessage.From.Resource != username)
                                     {
                                         if (MasterShip(NewMessage.From.Resource) || NewMessage.From.Resource.ToLower() == master.ToLower())
                                         {
                                             Send("\nPlease use HELP/1 to HELP/27 to see all commands.\n\n--\nTo see Available tags send TAG/1 to TAG/5\n\nYou are owner/master");
                                         }
                                     }
                                 }
                                 catch { }
                                 //users
                                 if (NewMessage.Body.ToLower().Trim() == "show/users" && NewMessage.From.Resource != username && (NewMessage.From.Resource == master || MasterShip(NewMessage.From.Resource.ToLower())))
                                 {
                                     string total = "";
                                     for (int i = 0; i < userslist.Items.Count; i++)
                                     {
                                         total += userslist.Items[i] + Environment.NewLine;
                                         System.Threading.Thread.Sleep(10);
                                     }
                                     Send("Curent room users that are in this room\n" + total);
                                 }
                             }
                         }
                     }
                     catch (Exception v)
                     {
                     }
                 }); thre.IsBackground = true; thre.Start();
            }
        }
        void MessageP(string ToUser, string message)
        {
            System.Threading.Thread thrf = new System.Threading.Thread(() =>
            {
                try
                {
                    x.Send(new agsXMPP.protocol.client.Message(new Jid(ToUser + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, message));
                }
                catch { }
            }); thrf.IsBackground = true; thrf.Start();
        }
        // Remover in richbox
        void Remover(string user, System.Windows.Forms.RichTextBox control, string FoundMessage, string NotFoundMessage)
        {
            System.Threading.Thread thrf = new System.Threading.Thread(() =>
            {
                try
                {
                    string Found = "";
                    System.Windows.Forms.RichTextBox temp = new System.Windows.Forms.RichTextBox();
                    foreach (string l in control.Lines)
                    {
                        if (l.ToLower().Trim() != user.ToLower().Trim())
                        {
                            temp.Text += l + "\n";
                        }
                        else
                        {
                            Found = "yes";
                        }
                        System.Threading.Thread.Sleep(10);
                    }
                    if (Found == "yes")
                    {
                        control.Text = temp.Text;
                        temp.Clear();
                        Send(FoundMessage);
                    }
                    else
                    {
                        Send(NotFoundMessage);
                    }
                }
                catch { }
            }); thrf.IsBackground = true; thrf.Start();
        }
        int RollIt(int start, int end)
        {
            int WheelRandomedNumkber = 0;
            Random rn = new Random();
            int count = 0;
            while (count < 50)
            {
                try
                {
                    WheelRandomedNumkber = rn.Next(start, end);
                    count++;
                }
                catch { }
            }
            count = 0;
            return WheelRandomedNumkber;
        }
        System.Windows.Forms.RichTextBox WheelStore = new System.Windows.Forms.RichTextBox();
        bool IsWheelable = true;
        Timer WheelTimer = new Timer();
        void WheelTimerHandler(object sender, EventArgs e)
        {
            if (WheelTime.ToString()!="00:00:00")
            {
                try
                {
                    string[] sp = WheelTime.ToString().Split(':');
                    int sc = Convert.ToInt32(sp[2]);
                    int min = Convert.ToInt32(sp[1]);
                    if (Convert.ToInt32(sp[2]) > 0 && Convert.ToInt32(sp[2]) < -1)
                    {
                        sc = Convert.ToInt32(sp[2]) - 1;
                    }
                    else
                    {
                        sc = 60;
                        min = Convert.ToInt32(sp[1]) - 1;
                    }
                    WheelTime = new TimeSpan(0, min, sc);
                }
                catch(Exception v)
                {
                }
            }
            else
            {
                WheelTimer.Stop();
                IsWheelable = true;
            }
        }
        TimeSpan Wheelsubtr = new TimeSpan(0,0,1);
        TimeSpan WheelCompare = new TimeSpan(0, 0, 0);
        TimeSpan WheelTime = new TimeSpan();
        //wheel Game
        void WheelIt(string Wuser)
        {
                try
                {
                    TimeSpan newone = new TimeSpan(0, 3, 0);
                    WheelTime = newone;
                    WheelTimer.Start();
                    IsWheelable = false;
                    switch (RollIt(0, 5))
                    {
                        case 1:
                            {
                                Send(">> " + Wuser + "\nHahaha! You got a very good KICKING.");
                                doaction(Wuser, "/kick ", "");
                                break;
                            }
                        case 2:
                            {
                                Send(">> " + Wuser + "\nOh, very lucky!");
                                AddScore(Wuser, 20);
                                break;
                            }
                        case 3:
                            {
                                Send(">> " + Wuser + "\nYou have no lucky! You got nothing try again.");
                                break;
                            }
                        case 4:
                            {
                                Send(">> " + Wuser + "\nYou have no lucky! You got nothing try again.");
                                break;
                            }
                        case 5:
                            {
                                Send(">> " + Wuser + "\nYou got one diamond ");
                                break;
                            }
                        default:
                            {
                                Send(">> " + Wuser + "\nYou are unlucky! You got a mute.");
                                doaction(Wuser, "/mute ", "");
                                break;
                            }
                    }
                }
                catch { }
        }
        //Remover with seperator
        void Remover(string user, System.Windows.Forms.RichTextBox control, string seperator, string FoundMessage, string NotFoundMessage)
        {
            try
            {
                string Found = "";
                System.Windows.Forms.RichTextBox temp = new System.Windows.Forms.RichTextBox();
                foreach (string l in control.Lines)
                {
                    if (!l.ToLower().StartsWith(user.ToLower() + seperator))
                    {
                        temp.Text += l + "\n";
                    }
                    else
                    {
                        Found = "yes";
                    }
                    System.Threading.Thread.Sleep(10);
                }
                control.Text = temp.Text;
                temp.Clear();
                if (Found == "yes")
                {
                    Send(FoundMessage);
                }
                else
                {
                    Send(NotFoundMessage);
                }
            }
            catch { }
        }
        private void OnFailed(object sender, Element e)
        {
            System.Threading.Thread thrf=new System.Threading.Thread(()=>{
            try
            {
                string[] mc = Messages.Lines;
                x1.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(sender1 + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[24].Replace("[MESSAGE]$", "").Replace("%L%", Environment.NewLine)));//mc[30].Replace("[MESSAGE]$", "")
                passch = "off";
            }
            catch { }
            }); thrf.IsBackground = true; thrf.Start();
        }
        private void OnXml(object sender, String xml)
        {
                System.Threading.Thread threb = new System.Threading.Thread(()=>{
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
                            }
                            //Will not effect your bot response while under thread.
                            System.Threading.Thread.Sleep(10);
                        }
                    }
                }
                catch { }
                }); threb.IsBackground = true; threb.Start();
        }
        private void _gamer(object sender, EventArgs e)
        {
            try
            {
            }
            catch { }
        }
        System.Timers.Timer disco = new System.Timers.Timer();
        //Anti Kick Timer
        void antikicktimer(object sender, EventArgs e)
        {
            try
            {
                if (antikickmanage == "on")
                {
                    Send(antikickmsg);
                }
            }
            catch { }
        }
        //Recongnizer Adder and Cutter
        void RecognizerAdd(string phrase, string status, string StartWord)
        {
            System.Threading.Thread thrf=new System.Threading.Thread(()=>{
            try
            {
                string foundOr = "";
                foreach (string l in recognizedw.Lines)
                {
                    string[] l1 = l.Split(':');
                    if (l1[0].ToLower() == StartWord.ToLower())
                    {
                        foundOr = "yes";
                    }
                    System.Threading.Thread.Sleep(10);
                }
                if (foundOr != "yes")
                {
                    string[] sp = phrase.Split(':');
                    recognizedw.Text += phrase + "\n";
                    Send("'" + StartWord + "' is added to recognized words list and associated with '" + sp[1] + "'");
                }
                else
                {
                    Send("But '" + StartWord + "' is already in Recognized words list!");
                }
            }
            catch { }
            }); thrf.IsBackground = true; thrf.Start();
        }
        //Score transfer
        void ScoreTransfer(string FromUser, string ToUser, int amount)
        {
            try
            {
                TransferFrom(FromUser, amount, ToUser);
            }
            catch { }
        }
        //Recongnizer Show
        void RecShow()
        {
            try{
            System.Windows.Forms.RichTextBox temp = new System.Windows.Forms.RichTextBox();
            foreach (string l in recognizedw.Lines)
            {
                if (l.Trim() != string.Empty)
                {
                    temp.Text += l.Replace(":", ": ") + "\n";
                }
                System.Threading.Thread.Sleep(10);
            }
            if (temp.Text.Trim() != string.Empty)
            {
                Send("These are lists of recognized words:\n\n" + temp.Text);
            }
            else
            {
                Send("No recognized words in bot database.");
            }
            }
            catch { }
        }
        //Shower
        void Shower(string user, System.Windows.Forms.RichTextBox control, char separator)
        {
            try{
            string amout ="";
            string found ="";
            System.Windows.Forms.RichTextBox temp = new System.Windows.Forms.RichTextBox();
            foreach (string l in control.Lines)
            {
                if (l.Trim() != string.Empty)
                {
                    string[] sp1 = l.Split(separator);
                    if (sp1[0].Trim().ToLower() == user.Trim().ToLower())
                    {
                        amout = sp1[1];
                        found = "yes";
                    }
                }
                System.Threading.Thread.Sleep(10);
            }
            if (found =="yes")
            {
                Send("\n>> " + user + "\nYou have '" + amout + "Score Points'.");
            }
            else
            {
                Send("No score points you have. You can transfer your score points from other rooms to this room. \nSend HELP to know more.");
            }
            }
            catch { }
        }
        //Recongnizer  Cutter
        void RecognizerRemove(string phrase, string StartWord)
        {
            try{
            string foundOr = "";
            System.Windows.Forms.RichTextBox temp = new System.Windows.Forms.RichTextBox();
            foreach (string l in recognizedw.Lines)
            {
                string[] l1 = l.Split(':');
                if (l1[0].ToLower() != StartWord.ToLower())
                {
                    temp.Text += l + "\n";
                    foundOr = "yes";
                }
                else
                {
                    foundOr = "no";
                }
                System.Threading.Thread.Sleep(10);
            }
            if (foundOr == "no")
            {
                Send("No such word is found!");
            }
            else
            {
                Send("One recognized word is removed!");
            }
            }
            catch { }
        }
        //Adder
        void Adder(string word, System.Windows.Forms.RichTextBox control, string AllreadyMessage,string AddedMessage)
        {
            try
            {
                string foundOr = "";
                foreach (string l in control.Lines)
                {
                    if (l.ToLower() == word.ToLower())
                    {
                        foundOr = "yes";
                    }
                    System.Threading.Thread.Sleep(10);
                }
                if (foundOr == "yes")
                {
                    Send(AllreadyMessage);
                }
                else
                {
                    control.Text += word + "\n";
                    Send(AddedMessage);
                }
            }
            catch (Exception f)
            {
            }
        }
        void badlangAdder(string word, string action)
        {
            try
            {
                string foundOr = "";
                foreach (string l in badla.Lines)
                {
                    string[] l1 = l.Split(':');
                    if (l1[0].ToLower() == word.ToLower())
                    {
                        foundOr = "yes";
                    }
                    System.Threading.Thread.Sleep(10);
                }
                if (foundOr != "yes")
                {
                    badla.Text += word + ":" + action + "\n";
                    Send("New bad word/phrase has been added.\nWord: " + word + "\nAction: " + action.ToString().Replace("1", "Kick").Replace("2", "Mute").Replace("3", "Ban").Replace("4", "Visitor").Replace("0", "Warning"));
                }
                else
                {
                    Send("But '" + word + "' is already added!");
                }
            }
            catch (Exception f)
            {
            }
        }
        bool IsbadUser(string user)
        {
            bool IsTrue = false;
            try
            {
                if (badjidlist.Text.Trim() != string.Empty)
                    foreach (string l in badjidlist.Lines)
                    {
                        if (l.Trim() != string.Empty)
                        {
                            if (l.Trim().ToLower() == user.Trim().ToLower())
                            {
                                IsTrue = true;
                            }
                        }
                        System.Threading.Thread.Sleep(10);
                    }
            }
            catch (Exception v)
            {
            }
            return IsTrue;
        }
        Timer antikicktime = new Timer();
        bool MasterShip(string user)
        {
            bool IsTrue = false;
            try
            {
                if (adminlist.Text.Trim() != string.Empty)
                    foreach (string l in adminlist.Lines)
                    {
                        if (l.Trim() != string.Empty)
                        {
                            if (l.Trim().ToLower() == user.Trim().ToLower())
                            {
                                IsTrue = true;
                            }
                        }
                        System.Threading.Thread.Sleep(10);
                    }
            }
            catch (Exception v) {
            }
            return IsTrue;
        }
        bool OnlineShip(string user)
        {
            bool IsTrue = false;
            if (userslist.Items.ToString().Trim() == string.Empty)
            {
            }
            else
            {
                for (int i = 0; i < userslist.Items.Count; i++)
                {
                    if (userslist.Items[i].ToString().Trim().ToLower() == user.Trim().ToLower())
                    {
                        IsTrue = true;
                    }
                    System.Threading.Thread.Sleep(10);
                }
            }
            return IsTrue;
        }
        void UpBackUpTimer(object sender, EventArgs e)
        {
            // in this implementation, this is never used.
            try{
                Send("Send '#Backup' to back up your room to our server for future.");
            }
            catch { }
        }
        private void OnConnected(object sender)
        {
            System.Threading.Thread thrd = new System.Threading.Thread(()=>{
                try
                {
                    string[] mc = Messages.Lines;
                    if (AlreadyConnected == false)
                    {
                        AlreadyConnected = true;
                        antikicktime.Elapsed += new ElapsedEventHandler(antikicktimer);
                        antikicktime.Interval = antikickcounter;
                        LuckyTimer.Elapsed += new ElapsedEventHandler(LuckyTimerHadle);
                        antikicktime.Start();
                        x1.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(sender1 + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[18].Replace("[MESSAGE]$", "").Replace("%ID%", this.ID).Replace("%L%", Environment.NewLine)));
                        x.Show = ShowType.chat;
                        x.Status = "Send HELP to get started.";
                       // Form1.rom++;
                        x.SendMyPresence();
                        if (IsPasswordProtected)
                        {
                            agsXMPP.protocol.x.muc.MucManager nz = new agsXMPP.protocol.x.muc.MucManager(x); nz.JoinRoom(roomJid, x.Username,roompassword);
                            x1.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(sender1 + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[53].Replace("[MESSAGE]$", "").Replace("%ID%", this.ID).Replace("%L%", Environment.NewLine).Replace("%room%", Roomname1)));
                            x1.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(sender1 + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, "Send HELP in your room to view commands available."));
                        }
                        else
                        {
                            agsXMPP.protocol.x.muc.MucManager nz = new agsXMPP.protocol.x.muc.MucManager(x); nz.JoinRoom(roomJid, x.Username);
                          x1.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(sender1 + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, mc[53].Replace("[MESSAGE]$", "").Replace("%ID%", this.ID).Replace("%L%", Environment.NewLine).Replace("%room%", Roomname1)));
                          x1.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(sender1+ "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, "Send HELP in your room to view commands available."));
                        }
                        AdminAllert.Elapsed+=new ElapsedEventHandler(AdminAllertHandler);
                        AdminAllert.Interval = 200000;
                        AdminAllert.Start();
                        LuckyTimer.Start();
                        ShoutTimer.Start();
                        SubjectTimer.Elapsed +=new ElapsedEventHandler(SubjectTimerHandler);
                        SubjectTimer.Interval = 60000;
                        SubjectTimer.Start();
                        WheelTimer.Elapsed+=new ElapsedEventHandler(WheelTimerHandler);
                        WheelTimer.Interval = 1000;
                        isUnderFloodTimer.Elapsed += new ElapsedEventHandler(isUnderFloodTimerHandler);
                        isUnderFloodTimer.Interval = 1000;
                        FTPTimer.Interval = 3600000;
                        BackupTimer.Elapsed += new ElapsedEventHandler(BackupTimerHandler);
                        BackupTimer.Interval = 10000;
                    }
                }
                catch
                {
                }}); thrd.IsBackground = true; thrd.Start();
            System.Threading.Thread thrrr = new System.Threading.Thread(()=>{
                try
                {
                   LocalFTP();
                }
                catch { }
            }); thrrr.IsBackground = true; thrrr.Start();
            BackupTimer.Start();
        }
        //Room Catcha
        Timer ReturnONTimer = new Timer();
        Random rnf = new Random();
        void ThinkGenenrator(object sender, EventArgs e)
        {
            try
            {
                luckynumber = rnf.Next(0, 5);
            }
            catch { }
        }
        //Shout Game
        void ShoutIt(string user)
        {
            try
            {
                Shoutword = random.Next().ToString();
                string found = "";
                string point = "";
                string iD = "";
                int mem = 0;
                System.Windows.Forms.RichTextBox temp = new System.Windows.Forms.RichTextBox();
                AddScore(user, ShoutScore);
            }
            catch
            {
                //TO CHECK
            }
        }
        //shout sender Timer
        void ShoutTimerHandle(object sender, EventArgs e)
        {
            if (Shoutmanage == "on")
            {
                if (ShoutNot == "on")
                {
                    try{
                    Send(ShoutMsg.Replace("%L%",Environment.NewLine).Replace("%num%",Shoutword));
                    }catch{} }
            }
        }
        Timer SubjectTimer = new Timer();
        int subcount = 1;
        void SubjectTimerHandler(object sender, EventArgs e)
        {
            //have control for this.
            int temps = 0;
            if (subcount == 1)
            {
                temps= 2;
                Message msg2 = new agsXMPP.protocol.client.Message
                {
                    To = roomJid,
                    Body = "",
                    Subject = "Add Nizzcserver@nimbuzz.com",
                    Type = MessageType.groupchat
                };
                x.Send(msg2);
            }
                if (subcount == 2)
                {
                    temps = 3;
                    Message msg2 = new agsXMPP.protocol.client.Message
                    {
                        To = roomJid,
                        Body = "",
                        Subject = "Send .r to check your luck!",
                        Type = MessageType.groupchat
                    };
                    x.Send(msg2);
                }
                    if (subcount == 3)
                    {
                        temps = 4;
                        Message msg3 = new agsXMPP.protocol.client.Message
                        {
                            To = roomJid,
                            Body = "",
                            Subject = "For everyone, send HELP to see commands available for you.",
                            Type = MessageType.groupchat
                        };
                        x.Send(msg3);
                    }
                        if (subcount == 4)
                        {
                            temps = 5;
                            Message msg2 = new agsXMPP.protocol.client.Message
                            {
                                To = roomJid,
                                Body = "",
                                Subject = "Create your own bots in your computer without VPS",
                                Type = MessageType.groupchat
                            };
                            x.Send(msg2);
                        }
                            if (subcount == 5)
                            {
                                temps = 1;
                                Message msg2 = new agsXMPP.protocol.client.Message
                                {
                                    To = roomJid,
                                    Body = "",
                                    Subject = "See how to use Nizzc incorp.'s Computers as VPS and connect your bots to them for free.\nGo to https://nizzc.com/freenet",
                                    Type = MessageType.groupchat
                                };
                                x.Send(msg2);
                            }
                            subcount = temps;
        }
       //Think Number
        void ThinkIt1vjhguhlkgugoigu(string user)
        {
            string found = "";
            string point="";
            string iD = "";
            int mem = 0;
            System.Windows.Forms.RichTextBox temp = new System.Windows.Forms.RichTextBox();
            foreach (string l in luckylist.Lines)
            {
                if (l.Trim() != string.Empty)
                {
                    string[] l1 = l.Split(':');
                    iD = l1[0];
                    point = l1[1];
                }
                if (iD.ToLower() == user.ToLower())
                {
                    int add = Convert.ToInt32(point);
                    int total = add + 20;
                    string all = iD + ":" + total;
                    mem = total;
                    temp.Text += all + "\n";
                    found = "yes";
                }
                else
                {
                    temp.Text += l + "\n";
                }
                //will not effect your bot performance while under thread.
                System.Threading.Thread.Sleep(10);
            }
            if (found != "yes")
            {
                temp.Text += user + ":" + 20 + "\n";
                mem = 20;
            }
            luckylist.Text = temp.Text;
            Send("\n>> " + user + "\nCongratulation! You won with " + 20 + "points. Now you have a total of " + mem + "points.");
        }
        Timer SpeedTimer = new Timer();
        System.Windows.Forms.RichTextBox SpeedHolder = new System.Windows.Forms.RichTextBox();
        //Edditional flood detection
        void SmartFloodDetection(string Message1, string user, string resource)
        {
            try
            {
                System.Windows.Forms.RichTextBox kj = new System.Windows.Forms.RichTextBox();
                kj.Text = Message1;
                if (Message1.Length > 200 || kj.Lines.Count() > 70 || user.Length > 50 || resource.Length > 50)
                {
                    doaction(user, "/ban f ", "");
                    ThreadMessage = "Flood sensation has been detected and banned!"; ;
                    isUnderFloodTimer.Stop();
                    isUnderFloodTimer.Start();
                }
            }
            catch { }
        }
        //Payu Scanner
        void PayuScanner()
        {
           //We do this with ThirdParty Library with our interconnected nimbuzz service.
            //Contact us team@nizzc.com
        }
        //Think Number
        void ThinkIt(string user)
        {
            System.Threading.Thread thrf = new System.Threading.Thread(()=>{
            try
            {
                string found = "";
                string point = "";
                string iD = "";
                int mem = 0;
                System.Windows.Forms.RichTextBox temp = new System.Windows.Forms.RichTextBox();
                foreach (string l in luckylist.Lines)
                {
                    if (l.Trim() != string.Empty)
                    {
                        string[] l1 = l.Split(':');
                        iD = l1[0];
                        point = l1[1];
                    }
                    if (iD.ToLower() == user.ToLower())
                    {
                        int add = Convert.ToInt32(point);
                        int total = add + LuckyScore;
                        string all = iD + ":" + total;
                        mem = total;
                        temp.Text += all + "\n";
                        found = "yes";
                    }
                    else
                    {
                        temp.Text += l + "\n";
                    }
                    System.Threading.Thread.Sleep(10);
                }
                if (found != "yes")
                {
                    temp.Text += user + ":" + LuckyScore + "\n";
                    mem = LuckyScore;
                }
                luckylist.Text = temp.Text;
                Send("\n>> " + user + "\nCongratulation! You won with " + LuckyScore + "points. Now you have a total of " + mem + "points.");
            }
            catch
            {
                //TO CHECK
            }});thrf.IsBackground=true; thrf.Start();
        }
        //Transfer
        void TransferFrom(string user, int score, string ToUser)
        {
            try{
            string found = "";
            string point = "";
            string iD = "";
            int mem = 0;
            string NotEnough = "";
             bool IsOnline = false;
                for (int i = 0; i < userslist.Items.Count; i++)
                {
                    if (userslist.Items[i].ToString().ToLower().Trim() == ToUser.Trim().ToLower())
                    {
                        IsOnline = true;
                    }
                    System.Threading.Thread.Sleep(10);
                }
            System.Windows.Forms.RichTextBox temp = new System.Windows.Forms.RichTextBox();
            foreach (string l in luckylist.Lines)
            {
                if (l.Trim() != string.Empty)
                {
                    string[] l1 = l.Split(':');
                    iD = l1[0];
                    point = l1[1];
                }
                if (IsOnline)
                {
                    if (iD.ToLower() == user.ToLower())
                    {
                        int add = Convert.ToInt32(point);
                        if (add >= score)
                        {
                            int total = add - score;
                            string all = iD + ":" + total;
                            mem = total;
                            temp.Text += all + "\n";
                            found = "yes";
                            NotEnough = "no";
                        }
                    }
                    else
                    {
                        temp.Text += l + "\n";
                    }
                }
                System.Threading.Thread.Sleep(10);
            }
            if (IsOnline)
            {
                luckylist.Text = temp.Text;
                if (NotEnough == "no")
                {
                    Send("\n>> " + user + "\nYou have transfered '" + score + "score points' to '" + ToUser + "'\n Now you have '" + mem + "score points' remained.");
                    TransferTo(ToUser, score, user);
                }
                else
                {
                    Send("\n>> " + user + "/nSorry, you don't have enough score points to transfer!");
                }
            }
            else
            {
                Send(ToUser + " is not in this room now. Try again when he/she is in room.");
            }
            }
            catch { }
        }
        //All Add score
        void AddScore(string user, int score)
        {
            try{
            string found = "";
            string point = "";
            string iD = "";
            int mem = 0;
            System.Windows.Forms.RichTextBox temp = new System.Windows.Forms.RichTextBox();
            foreach (string l in luckylist.Lines)
            {
                if (l.Trim() != string.Empty)
                {
                    string[] l1 = l.Split(':');
                    iD = l1[0];
                    point = l1[1];
                }
                if (iD.ToLower() == user.ToLower())
                {
                    int add = Convert.ToInt32(point);
                    int total = add + score;
                    string all = iD + ":" + total;
                    mem = total;
                    temp.Text += all + "\n";
                    found = "yes";
                }
                else if (iD.ToLower() != user) 
                {
                    temp.Text += l + "\n";
                }
                System.Threading.Thread.Sleep(10);
            }
            if (found != "yes")
            {
                temp.Text += user + ":" + score + "\n";
                mem = score;
            }
            luckylist.Text = temp.Text;
            System.Windows.Forms.RichTextBox temp2 = new System.Windows.Forms.RichTextBox();
            foreach (string l in luckylist.Lines)
            {
                if (!temp2.Text.Contains(l))
                {
                    temp2.Text += l + "\n";
                }
                System.Threading.Thread.Sleep(10);
            }
            luckylist.Clear();
            luckylist.Text = temp2.Text;
            temp2.Clear();
            Send("\n>> " + user + "\nCongratulation! You won with " + score + "points. Now you have a total of " + mem + "points.");
            }
            catch { }
        }
        void MemberOnly()
        {
            agsXMPP.protocol.x.muc.MucManager jj = new agsXMPP.protocol.x.muc.MucManager(x);
        }
        //Add Transfered Score
        void AddTransferedScore(string user, int score, string room)
        {
            try{
            string found = "";
            string point = "";
            string iD = "";
            int mem = 0;
            System.Windows.Forms.RichTextBox temp = new System.Windows.Forms.RichTextBox();
            foreach (string l in luckylist.Lines)
            {
                if (l.Trim() != string.Empty)
                {
                    string[] l1 = l.Split(':');
                    iD = l1[0];
                    point = l1[1];
                }
                if (iD.ToLower() == user.ToLower())
                {
                    int add = Convert.ToInt32(point);
                    int total = add + score;
                    string all = iD + ":" + total;
                    mem = total;
                    temp.Text += all + "\n";
                    found = "yes";
                }
                else if (iD.ToLower() != user)
                {
                    temp.Text += l + "\n";
                }
                System.Threading.Thread.Sleep(10);
            }
            if (found != "yes")
            {
                temp.Text += user + ":" + score + "\n";
                mem = score;
            }
            luckylist.Text = temp.Text;
            System.Windows.Forms.RichTextBox temp2 = new System.Windows.Forms.RichTextBox();
            foreach (string l in luckylist.Lines)
            {
                if (!temp2.Text.Contains(l))
                {
                    temp2.Text += l + "\n";
                }
                System.Threading.Thread.Sleep(10);
            }
            luckylist.Clear();
            luckylist.Text = temp2.Text;
            temp2.Clear();
            Send("\n>> " + user + "\nCongratulation! You have transfered '" + score + "points' from "+room+".\nNow you have '" + mem + "points'.");
            }
            catch { }
        }
        //Add Score
        void TransferRedeemedScore(string user, int score, string file)
        {
            string found = "";
            string point = "";
            string iD = "";
            int mem = 0;
            try
            {
                System.Windows.Forms.RichTextBox temp = new System.Windows.Forms.RichTextBox();
                foreach (string l in luckylist.Lines)
                {
                    if (l.Trim() != string.Empty && l.Contains(":"))
                    {
                        string[] l1 = l.Split(':');
                        iD = l1[0];
                        point = l1[1];
                    }
                    if (iD.ToLower() == user.ToLower())
                    {
                        int add = Convert.ToInt32(point);
                        int total = add + score;
                        string all = iD + ":" + total;
                        mem = total;
                        temp.Text += all + "\n";
                        found = "yes";
                    }
                    else if (iD.ToLower() != user)
                    {
                        temp.Text += l + "\n";
                    }
                    System.Threading.Thread.Sleep(10);
                }
                if (found != "yes")
                {
                    temp.Text += user + ":" + score + "\n";
                    mem = score;
                }
                luckylist.Text = temp.Text;
                System.Windows.Forms.RichTextBox temp2 = new System.Windows.Forms.RichTextBox();
                foreach (string l in luckylist.Lines)
                {
                    if (!temp2.Text.Contains(l))
                    {
                        temp2.Text += l + "\n";
                    }
                    System.Threading.Thread.Sleep(10);
                }
                luckylist.Clear();
                luckylist.Text = temp2.Text;
                temp2.Clear();
                Send("\n>> " + user + "\nYour score points of '" + score + "' has been successfuly transferred to this room. Now you have a total of " + mem + "points.");
                System.Threading.Thread thre = new System.Threading.Thread(() =>
                {
                    try
                    {
                        FTP.ftp1 Ftp = new FTP.ftp1(IP, IPusername, IPpassword);
                        Ftp.delete("/Dir/" + file);
                        //No need to backup, bot automatically backups on local.
                       // Backup();
                    }
                    catch (Exception v)
                    {
                        //  MessageBox.Show(v.ToString()); 
                    }
                }); thre.IsBackground = true; thre.Start();
            }
            catch (Exception v) {  }
        }
        //Score Transfer To
        void TransferTo(string user, int score, string FromUser)
        {
            try{
            string found = "";
            string point = "";
            string iD = "";
            int mem = 0;
            string done = "";
            System.Windows.Forms.RichTextBox temp = new System.Windows.Forms.RichTextBox();
            for (int i = 0; i < userslist.Items.Count; i++)
            {
                if (userslist.Items[i].ToString().ToLower().Trim() == user.Trim().ToLower())
                {
                    done = "yes";
                }
                System.Threading.Thread.Sleep(10);
            }
            foreach (string l in luckylist.Lines)
            {
                if (l.Trim() != string.Empty)
                {
                    string[] l1 = l.Split(':');
                    iD = l1[0];
                    point = l1[1];
                }
                if (done =="yes")
                {
                    if (iD.ToLower() == user.ToLower())
                    {
                        int add = Convert.ToInt32(point);
                        int total = add + score;
                        string all = iD + ":" + total;
                        mem = total;
                        temp.Text += all + "\n";
                        found = "yes";
                    }
                    else
                    {
                        temp.Text += l + "\n";
                    }
                }
                System.Threading.Thread.Sleep(10);
                //
                }
            if (found != "yes" && done == "yes") 
                {
                    temp.Text += user + ":" + score + "\n";
                    mem = score;
                }
                if (done.Trim().ToLower() == "yes")
                {
                    luckylist.Text = temp.Text;
                    Send("\n>> " + user + "\nYou have recieved '" + score + "score points' from '" + FromUser + "'\n Now you have a total of " + mem + "points.");
                }
                else
                {
                    Send("Sorry, " + user + " is not in this room. Please try again when he/she is in this room.");
                }
            }
            catch { }
        }
//
        void ReturnON()
        {
            return;
            //after return, the code below will not get executed and no need to be executed.
            try{
            TempoWlOFF = "on";
            ReturnONTimer.Elapsed += new ElapsedEventHandler(ReturnONHandler);
            ReturnONTimer.Interval = 10000;
            ReturnONTimer.Start();
            }
            catch { }
        }
        void ReturnONHandler(object sender, EventArgs e)
        {
            ReturnONTimer.Stop();
            TempoWlOFF = "off";
        }
        private void dc(object sender)
        {
            if (this.passch == "off")
            {
            }
            else
            {
                try{//Do not assign as 'OnFlood' after bot is being reconnected.
               // TempoWlOFF = "on";
               // ReturnON();
                x.Open(this.ID, this.PSW, Resouce + rnd.Next(100, 5000).ToString());
                }
                catch { }
            }
        }
        //Bad language detector
        void badlang(string word, string user)
        {
            try
            {
                string badword = "";
                int  action = 0;
                string Found = "";
                string L1 = "";
                string L2 = "";
                for (int i = 0; i < badla.Lines.Count();i++ )
                {
                    if (badla.Lines[i].Trim().Contains(":"))
                    {
                        string[] sp1 = badla.Lines[i].Split(':');
                        if (sp1[0].Trim().ToLower() == word.Trim().ToLower())
                        {
                            try
                            {
                                Found = "yes";
                                action = Convert.ToInt32(sp1[1]);
                            }
                            catch(Exception v)
                            {
                            }
                        }
                    }
                    System.Threading.Thread.Sleep(10);
                }
                if (Found == "yes")
                {
                    if (action == 1)
                    {
                        Send("/kick " + user);
                        if (silecncemanage == "on")
                        {
                            Send("'" + user + "' has been kicked off for bad language.\nWord/Phrase: " + badword + "\nForbidden by: Bot Master");
                        }
                    }
                    else if (action == 2)
                    {
                        Send("/mute " + user);
                        if (silecncemanage == "on")
                        {
                            Send("'" + user + "' has been muted for bad language.\nWord/Phrase: " + badword + "\nForbidden by: Bot Master");
                        }
                    }
                    else if (action== 3)
                    {
                        Send("/ban " + user);
                        if (silecncemanage == "on")
                        {
                            Send("'" + user + "' has been banned for bad language.\nWord/Phrase: " + badword + "\nForbidden by: Bot Master");
                        }
                    }
                    else if (action== 4)
                    {
                        agsXMPP.protocol.x.muc.MucManager mn = new agsXMPP.protocol.x.muc.MucManager(x);
                        mn.RevokeVoice(roomJid, user);
                        if (silecncemanage == "on")
                        {
                            Send("'" + user + "'s' privileges have been nullified   for bad language.\nWord/Phrase: " + badword + "\nForbidden by: Bot Master");
                        }
                    }
                    else if (action == 0)
                    {
                        Send(warningMessa.Replace("%user%",user).Replace("%room%",Roomname1).Replace("%word%",badword));
                    }
                }
            }
            catch (Exception f)
            {
            }
        }
        //Find errors, Floods and so on.
        void Finder(string WhatToFind, string user,string Action, System.Windows.Forms.RichTextBox control,string Message1)
        {
            try
            {
                string Found = "";
                foreach (string l in control.Lines)
                {
                    if (l.ToLower().StartsWith(WhatToFind.ToLower()) || WhatToFind.ToLower().Contains(l.ToLower()) || l.ToLower().Contains(WhatToFind.ToLower()) || l.ToLower() == WhatToFind.ToLower() || l.ToLower().EndsWith(WhatToFind.ToLower()))
                    {
                        Found = "yes";
                    }
                    System.Threading.Thread.Sleep(10);
                }
                if (Found.ToLower() == "yes")
                {
                    if (IsFlood)
                    {
                        TempoWlOFF = "on";                        
                        ReturnON();
                    }
                    if (FullMaster || IsMaster)
                    {
                        doaction(user, Action, "");
                        ThreadMessage = "'" + WhatToFind + "' was detected and taken '" + Action + "'";
                        isUnderFloodTimer.Stop();
                        isUnderFloodTimer.Start();
                    }
                }
            }
            catch (Exception f)
            {
            }
        }
        //reporter
        void Reporter(string user, string message, System.Windows.Forms.RichTextBox control)
        {
            try
            {
                foreach (string l in control.Lines)
                {
                    if (l.Trim().ToLower() == user.ToLower())
                    {
                        if (!userslist.Items.ToString().ToLower().Contains(user.ToLower()))
                        {
                            Send((user + "@nimbuzz.com"), "chat", message);
                        }
                    }
                    System.Threading.Thread.Sleep(10);
                }
            }
            catch { }
        }
        void AddRemoveUser(string user, bool isOn)
        {
            try{
            bool isinclude = false;
            for (int i = 0; i < userslist.Items.Count; i++)
            {
                if (userslist.Items[i].ToString().Trim().ToLower() == user.ToLower().Trim())
                {
                    isinclude = true;
                }
                System.Threading.Thread.Sleep(10);
            }
            if (isOn && !isinclude)
            {
                userslist.Items.Add(user);
            }
            else if (!isOn && !isinclude)
            {
                userslist.Items.Remove(user);
            }
            }
            catch { }
        }
        void DoBackupAndUpload()
        {
            //Backup();
            try
            {
                WebClient pp = new WebClient();
                pp.Credentials = new System.Net.NetworkCredential(IPusername, IPpassword);
                pp.UploadFile(IP.Replace("freenet:2124","") + "/rooms/" + Roomname1, "STOR", @Roomname1);
            }
            catch { }
        }
        void DoRest()
        {
            System.Threading.Thread thr = new System.Threading.Thread(() =>
            {
                try{
                YesNo = "";
                Send("Saving All changing for backup...\nPlease wait.");
               // Backup(); is was already done.
                System.Threading.Thread.Sleep(5000);
                Send("Uploading room backup to our webserver for better safety. Please wait...");
                //UploadFTP();  it was already done.
                System.Threading.Thread.Sleep(5000);
                Send("Everything is safe! \nDisconnecting...");
                System.Threading.Thread.Sleep(2000);
                Send("Disconnected!");
                passch = "off";
                x.Close();
                }
                catch { }
            }); thr.IsBackground = true; thr.Start();
        }
        //Finding tool
        void Find(string word, string user, string Action, System.Windows.Forms.RichTextBox control, char Saperator, string Message1)
        {
            try
            {
                string Found = "";
                foreach (string l in control.Lines)
                {
                    if (l.Trim() != string.Empty)
                    {
                        string[] l1 = l.Split(Saperator);
                        if ((l.ToLower().StartsWith(word.ToLower()) || word.ToLower().Contains(l1[0].ToLower()) || l1[0].ToLower() == word.ToLower()) && l.Trim() != string.Empty)
                        {
                            Found = "yes";
                        }
                    }
                    System.Threading.Thread.Sleep(10);
                }
                if (Found.ToLower() == "yes")
                {
                    if (IsFlood)
                    {
                        TempoWlOFF = "on";
                        ReturnON();
                    }
                    if (FullMaster || IsMaster)
                    {
                        doaction(user, Action, Message1);
                    }
                }
            }
            catch
            {
            }
        }
        private void Prec(object sender, Presence p)
        {
            if (p.Type == agsXMPP.protocol.client.PresenceType.subscribe)
            {
                try
                {
                    x.Send("<presence to=\"" + p.From + "\" type=\"subscribed\" />" +
                        "<presence to=\"" + p.From + "\" type=\"subscribe\" />");
                      }
                catch { }
            }
        }
        void Send(string iD, string MessagE)
        {
            x1.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(iD + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, MessagE));
            return;
        }
        void Send(string iD, string MessagE,bool islocal)
        {
            x.Send(new agsXMPP.protocol.client.Message(new Jid(iD + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, MessagE));
            return;
        }
        string time = "do";
        private void onlineadd(object sender, agsXMPP.protocol.client.Presence pres)
        {
        }
        void question(string qu, string usering)
        {
            x.Send(new agsXMPP.protocol.client.Message(new agsXMPP.Jid(usering + "@nimbuzz.com"), agsXMPP.protocol.client.MessageType.chat, qu));
        }
        //ans
        void ans(string ans, string usr, int f, int l)
        {
        }
        bool IsOwner = false;
        bool IsAdmin = false;
        bool IsMod = false;
        string rl = "";
        public string role(Presence Me)
        {
            return Me.MucUser.Item.Role.ToString();
        }
        string affl = "";
        bool FullMaster = false;
        bool IsMaster = false;
        void OnTime(object sender, Presence pres)
        {
            if (pres.Type == PresenceType.error || pres.From == null || pres.From.Resource.Trim()==string.Empty)
                return;
            else
            {
                System.Threading.Thread thre = new System.Threading.Thread(() =>
               {
                    try
                    {
                        if (pres.Type == PresenceType.available)
                        {
                            try
                            {
                                //Check Bot Privilege
                                if (pres.From.Resource.ToLower() == x.Username.ToLower())
                                {
                                    rl = pres.MucUser.Item.Role.ToString();
                                    affl = pres.MucUser.Item.Affiliation.ToString();
                                    if (affl.ToLower() == "owner" || affl.ToLower() == "admin")
                                    {
                                        IsMaster = true;
                                    }
                                    else
                                    {
                                        IsMaster = false;
                                    }
                                    if (affl.ToLower() == "owner")
                                    {
                                        FullMaster = true;
                                    }
                                    else
                                    {
                                        FullMaster = false;
                                    }
                                }
                                if (AutoAddManage == "on")
                                {
                                    try
                                    {
                                        x.RosterManager.AddRosterItem(new Jid(pres.From.Resource + "@nimbuzz.com"));
                                        agsXMPP.protocol.client.PresenceManager prr = new PresenceManager(x);
                                        prr.Subscribe(new Jid(pres.From.Resource + "@nimbuzz.com"));
                                    }
                                    catch { }
                                }
                                if (IsMaster)
                                {
                                    if (pres.From.Resource != username && pres.MucUser.Item.Affiliation.ToString().ToLower() != "owner" && pres.MucUser.Item.Affiliation.ToString().ToLower() != "moderator" && pres.MucUser.Item.Affiliation.ToString().ToLower() != "admin" && pres.MucUser.Item.Affiliation.ToString().ToLower() != "member")
                                    {
                                        //Auto Muter
                                        if (this.automutemanage == "on")
                                        {
                                            doaction(pres.From.Resource.ToString(), "/mute ", "'" + pres.From.Resource + "' has been muted!\nReason: Auto Mute is turned on");
                                        }
                                        //auto member
                                        if (automember == "on")
                                        {
                                            doaction(pres.From.Resource.ToString(), "/mem ", "'" + pres.From.Resource + "' has been granted membership");
                                        }
                                        //Auto IP Ban
                                        if (autoIPbanmanage == "on")
                                        {
                                            if (FullMaster)
                                            {
                                                doaction(pres.From.Resource.ToString(), "/ban f ", "'" + pres.From.Resource + "' has been banned with his/her IP\nReason: Auto IP banning is enabled.");
                                            }
                                        }
                                        //Auto Ban
                                        if (autobanmanage == "on")
                                        {
                                            doaction(pres.From.Resource.ToString(), "/ban ", "'" + pres.From.Resource + "' has been banned\nReason: Auto banning is enabled");
                                        }
                                        //Auto Kick
                                        if (autokickmanage == "on")
                                        {
                                            doaction(pres.From.Resource.ToString(), "/kick ", "'" + pres.From.Resource + "' has been kicked out\nReason: Auto kicking is enabled");
                                        }
                                        //Auto Visitor
                                        if (autovisitor == "on")
                                        {
                                            agsXMPP.protocol.x.muc.MucManager mng = new agsXMPP.protocol.x.muc.MucManager(x);
                                            mng.RevokeVoice(roomJid, pres.From.Resource);
                                            if (silecncemanage == "off")
                                            {
                                                Send("'" + pres.From.Resource + "' has been granted visitorship and has no voice now\nReason: Auto Visitor is enebled");
                                            }//doaction(pres.From.Resource.ToString(), "/ ", "'" + pres.From.Resource + "' has been banned\nReason: Auto ban is enabled");
                                        }
                                    }
                                        //return;
                                }
                                try
                                {
                                    if (pres.From.Resource != x.Username && !badreslist.Text.ToLower().Contains(pres.MucUser.Item.Jid.Resource.ToLower()))
                                    {
                                        if (this.wlmanage == "on" && TempoWlOFF != "on")
                                        {
                                            if (this.wlmsgholder.Trim() != string.Empty)
                                            {
                                                if (!badjidlist.Text.ToLower().Contains(pres.From.Resource.ToLower()))
                                                {
                                                    doaction(pres.From.Resource.ToString(), wlmsgholder.Replace("%user%", pres.From.Resource).Replace("%room%", Roomname1).Replace("%n%", "@nimbuzz.com").Replace("%L%", Environment.NewLine).Replace("%master%", master).Replace("%rl%", pres.MucUser.Item.Role.ToString()).Replace("%aff%", pres.MucUser.Item.Affiliation.ToString()), "");
                                                }
                                            }
                                        }
                                    }
                                }
                                catch { }
                            }
                            catch { }
                            try
                            {
                                if (pres.MucUser.Item.Affiliation.ToString().ToLower() != "owner" && pres.From.Resource.ToLower() != x.Username.ToLower() && pres.From.Resource.ToLower() != master.ToLower())
                                {
                                    //Resource Censor
                                    if (resfiltermanage == "on")
                                    {
                                        Finder(pres.MucUser.Item.Jid.Resource, pres.From.Resource, "/ban f ", badreslist, "");
                                    }
                                    //Bad Jid Sensor
                                    if (idfiltermanage == "on")
                                    {
                                       Finder(pres.MucUser.Item.Jid.Resource, pres.From.Resource, "/ban f ", badjidlist, "");
                                    }
                                    //Resource length Sensor
                                    if (pres.MucUser.Item.Jid.Resource.Length >= reslength && resfiltermanage == "on")
                                    {
                                        doaction(pres.From.Resource, "/ban f ", "");
                                        ThreadMessage = "Flood sensation has been detected and banned!"; ;
                                        isUnderFloodTimer.Stop();
                                        isUnderFloodTimer.Start(); 
                                    }
                                    //Jid Length Sensor
                                    if (pres.From.Resource.Length >= idlength && idfiltermanage == "on")
                                    {
                                        doaction(pres.MucUser.Item.Jid.Resource, "/ban f ", "");
                                        ThreadMessage = "Flood sensation has been detected and banned!"; ;
                                        isUnderFloodTimer.Stop();
                                        isUnderFloodTimer.Start();
                                    }
                                    //SmartDetection
                                    if (SmartDet == "on")
                                    {
                                        SmartFloodDetection("Flood has been detected and banned!", pres.From.Resource, pres.MucUser.Item.Jid.Resource);
                                    }
                                    //Suspect user detector
                                    if (SmartDetmanage == "on")
                                    {
                                        try
                                        {
                                            int justchec = Convert.ToInt32(pres.From.Resource.Replace("_", "").Replace("-", "").Trim());
                                            doaction(pres.From.Resource, "/ban f ", "Suspected user has been banned!\nuser: " + pres.From.Resource + "\nUse SUS/OFF to turn this option off.");
                                       }
                                        catch
                                        {
                                        }
                                    }
                                }
                            }
                            catch { }
                            try
                            {
                                AddRemoveUser(pres.MucUser.Item.Jid.User, true);
                                if (AutoAddManage == "on")
                                {
                                    x.PresenceManager.Subscribe(new Jid(pres.From.User + "@nimbuzz.com"));
                                }
                            }
                            catch (Exception v)
                            {
                            }
                        }
                        else
                        {
                            try
                            {
                                AddRemoveUser(pres.MucUser.Item.Jid.User, false);
                            }
                            catch (Exception v)
                            {
                            }
                        }
                    }
                    catch(Exception v) 
                    {
                    }
                   try
            {
                if (pres.Type == PresenceType.subscribe)
                {
                    x.PresenceManager.ApproveSubscriptionRequest(pres.From);
                }
            }
            catch { }
                }); thre.IsBackground = true; thre.Start();
            }
        }
        //Deleter
        void Deleter(string word, System.Windows.Forms.RichTextBox control,string FoundMessage,string NotFoundMessage)
        {
            try{
            string foundOr = "";
            System.Windows.Forms.RichTextBox temp = new System.Windows.Forms.RichTextBox();
            foreach (string l in control.Lines)
            {
                string[] l1 = l.Split(':');
                if (l.ToLower() != word.ToLower())
                {
                    temp.Text += l + "\n";
                }
                else
                {
                    foundOr = "yes";
                }
                System.Threading.Thread.Sleep(10);
            }
            if (foundOr == "yes")
            {
                Send(FoundMessage);
            }
            else
            {
                Send(NotFoundMessage);
            }
            }
            catch { }
        }
        //Room To Room score transfer
        void RoomScoreTransfer(string user, int score)
        {
            string scoreString = score.ToString();
        }
        public void Send(Jid to, MessageType type, string Body)
        {
            try
            {
                Message MessageU = new agsXMPP.protocol.client.Message
                {
                    To = to,
                    Body = Body,
                    Subject = "",
                    Type = type
                };
                x.Send(MessageU);
            }
            catch (Exception v)
            {
            }
        }
        Timer messager = new Timer();
        public void doaction(string id, string action, string message1)
        {
            try
            {
                Send(action + id);
                if (silecncemanage != "on" && message1 != "")
                {
                    Send(message1);
                }
            }
            catch { }
            return;
        }
        public void Send(string to, string type, string Body)
        {
            try
            {
                MessageType TyPo;
                if (type == "chat")
                    TyPo = MessageType.chat;
                else
                {
                    TyPo = MessageType.groupchat;
                }
                Message MessageU = new agsXMPP.protocol.client.Message
                {
                    To = new Jid(to),
                    Body = Body,
                    Subject = "",
                    Type = TyPo
                };
                x.Send(MessageU);
            }
            catch { }
        }
        void _aborttimer(object sender, EventArgs e)
        {
            aborttimer.Stop();
            YesNo = "";
        }
        public void Send(string Body)
        {
            try
            {
                Message MessageU = new agsXMPP.protocol.client.Message
                {
                    To = roomJid,
                    Body = Body,
                    Subject = "",
                    Type = MessageType.groupchat
                };
                x.Send(MessageU);
            }
            catch (Exception v)
            {
            }
        }
        bool isJoinable = true;
        private void t_Tick(object sender, EventArgs e)
        {
           // System.Threading.Thread thrf = new System.Threading.Thread(() =>
            //{
                try
                {
                    if (isJoinable)
                    {
                        agsXMPP.protocol.x.muc.MucManager m = new agsXMPP.protocol.x.muc.MucManager(x);
                        if (!IsPasswordProtected)
                        {
                           m.JoinRoom(roomJid, x.Username);
                        }
                        else
                        {
                          m.JoinRoom(roomJid, x.Username, roompassword);
                        }
                    }
                }
                catch { }
           // }); thrf.IsBackground = true; thrf.Start();
        }
        Timer BackupTimer = new Timer();
        void BackupTimerHandler(object sender, EventArgs e )
        {
            try{
                Backup();
            }
            catch { }
        }
        //Message Line Filter
        void MLF(string user, System.Windows.Forms.RichTextBox  control)
        {
            try
            {
                if (control.Lines.Count() >= LineFilterlen)
                {
                    doaction(user, "/ban f ", "");
                    ThreadMessage = "Flood sensation has been detected and banned!"; ;
                    isUnderFloodTimer.Stop();
                    isUnderFloodTimer.Start();
                }
            }
            catch
            {
                //TO CHECK
            }
        }
        void LuckyTimerHadle(object sender, EventArgs e)
        {
            if (luckymanager == "on")
            {
                if (LuckyNot == "on")
                {
                    Send(LuckyMsg);
                }
            }
        }
        void SetUploadFTP()
        {
            //System.Threading.Thread.Sleep(7000);
            try
            {
                System.Threading.Thread thre = new System.Threading.Thread(() =>
                {
                    try
                    {
                        UploadFTP();
                        //FTPTimer.Start();
                    }
                    catch { }
                    return;
                }); thre.IsBackground = true;
                thre.Start();
                return;
            }
            catch (Exception v)
            {
            }
        }
        Timer FTPTimer = new Timer();
        void FTPTimerHandler(object sendr, EventArgs e)
        {
            FTPTimer.Stop();
        }
        bool isUnderFlood = false;
        Timer isUnderFloodTimer = new Timer();
        void isUnderFloodTimerHandler(object sender, EventArgs e)
        {
            try
            {
                isUnderFloodTimer.Stop();
                    Send(ThreadMessage);
                    ThreadMessage = "";
            }
            catch { }
        }
        void FloodMessage(string Mmessage)
        {
        }
        System.Threading.Thread ppp;
        void mute1(object sender, EventArgs e)
        {
            Send("/mute " + catchh);
            Send(catchh + " has joined the room and needs to confirmed");
            catchh = "";
            mute.Stop();
            return;
        }
        //Set Up soccer Voids
        void SoccerAbortTimeHandler(object sender, EventArgs e)
        {
            SoccerAbortTimer.Stop();
            SoccerAccepteds.Clear();
            SoccerAwaiting.Clear();
            SoccerKicker = "";
            kicker1 = "";
            kicker2 = "";
            SoccerKickNumber = 0;
            Score1 = 0;
            Score2 = 0;
            Send("Penalty game aborted.\nSend 'penalty#user1#user2' to start new penalty game'");
        }
        Random KickRandom = new Random();
        //Soccer Kicker 
        void KickSoccerIt(string Ukicker)
        {
                System.Threading.Thread thre = new System.Threading.Thread(() =>
                {
                    try
                    {
                        if (SoccerAwaiting.Text.Trim() == string.Empty)
                        {
                            switch (SoccerRandomint)
                            {
                                case 0:
                                    {
                                        if (kicker.ToLower() == kicker1.ToLower())
                                        {
                                            SoccerAbortTimer.Stop();
                                            SoccerAbortTimer.Start();
                                            Send("\n>> " + kicker + "\nYou missed!");
                                            kicker = kicker2;
                                            SoccerKickNumber++;
                                            if (SoccerKickNumber == 10)
                                            {
                                                kicker = "";
                                                Send("Game Finshed!");
                                                Send("Calculating the result...");
                                                System.Threading.Thread.Sleep(5000);
                                                CountIt();
                                            }
                                            else
                                            {
                                                Send("'" + kicker + "' should kick now");
                                            }
                                        }
                                        else if (kicker.ToLower() == kicker2.ToLower())
                                        {
                                            SoccerAbortTimer.Stop();
                                            SoccerAbortTimer.Start();
                                            Send("\n>> " + kicker + "\nYou missed!");
                                            kicker = kicker1;
                                            SoccerKickNumber++;
                                            if (SoccerKickNumber == 10)
                                            {
                                                kicker = "";
                                                Send("Game Finshed!");
                                                Send("Calculating the result...");
                                                System.Threading.Thread.Sleep(5000);
                                                CountIt();
                                            }
                                            else
                                            {
                                                Send("'" + kicker + "' should kick now");
                                            }
                                        }
                                        break;
                                    }
                                //
                                case 1:
                                    {
                                        if (kicker.ToLower() == kicker1.ToLower())
                                        {
                                            SoccerAbortTimer.Stop();
                                            SoccerAbortTimer.Start();
                                            Send("\n>> " + kicker + "\nYou missed!");
                                            kicker = kicker2;
                                            SoccerKickNumber++;
                                            if (SoccerKickNumber == 10)
                                            {
                                                kicker = "";
                                                Send("Game Finshed!");
                                                Send("Calculating the result...");
                                                System.Threading.Thread.Sleep(5000);
                                                CountIt();
                                            }
                                            else
                                            {
                                                Send("'" + kicker + "' should kick now");
                                            }
                                        }
                                        else if (kicker.ToLower() == kicker2.ToLower())
                                        {
                                            SoccerAbortTimer.Stop();
                                            SoccerAbortTimer.Start();
                                            Send("\n>> " + kicker + "\nYou missed!");
                                            kicker = kicker1;
                                            SoccerKickNumber++;
                                            if (SoccerKickNumber == 10)
                                            {
                                                kicker = "";
                                                Send("Game Finshed!");
                                                Send("Calculating the result...");
                                                System.Threading.Thread.Sleep(5000);
                                                CountIt();
                                            }
                                            else
                                            {
                                                Send("'" + kicker + "' should kick now");
                                            }
                                        }
                                        break;
                                    }
                                //
                                case 3:
                                    {
                                        if (kicker.ToLower() == kicker1.ToLower())
                                        {
                                            SoccerAbortTimer.Stop();
                                            SoccerAbortTimer.Start();
                                            Send("\n>> " + kicker + "\nYou missed!");
                                            kicker = kicker2;
                                            SoccerKickNumber++;
                                            if (SoccerKickNumber == 10)
                                            {
                                                kicker = "";
                                                Send("Game Finshed!");
                                                Send("Calculating the result...");
                                                System.Threading.Thread.Sleep(5000);
                                                CountIt();
                                            }
                                            else
                                            {
                                                Send("'" + kicker + "' should kick now");
                                            }
                                        }
                                        else if (kicker.ToLower() == kicker2.ToLower())
                                        {
                                            SoccerAbortTimer.Stop();
                                            SoccerAbortTimer.Start();
                                            Send("\n>> " + kicker + "\nYou missed!");
                                            kicker = kicker1;
                                            SoccerKickNumber++;
                                            if (SoccerKickNumber == 10)
                                            {
                                                kicker = "";
                                                Send("Game Finshed!");
                                                Send("Calculating the result...");
                                                System.Threading.Thread.Sleep(5000);
                                                CountIt();
                                            }
                                            else
                                            {
                                                Send("'" + kicker + "' should kick now");
                                            }
                                        }
                                        break;
                                    }
                                //
                                case 6:
                                    {
                                        if (kicker.ToLower() == kicker1.ToLower())
                                        {
                                            SoccerAbortTimer.Stop();
                                            SoccerAbortTimer.Start();
                                            Send("\n>> " + kicker + "\nYou missed!");
                                            kicker = kicker2;
                                            SoccerKickNumber++;
                                            if (SoccerKickNumber == 10)
                                            {
                                                kicker = "";
                                                Send("Game Finshed!");
                                                Send("Calculating the result...");
                                                System.Threading.Thread.Sleep(5000);
                                                CountIt();
                                            }
                                            else
                                            {
                                                Send("'" + kicker + "' should kick now");
                                            }
                                        }
                                        else if (kicker.ToLower() == kicker2.ToLower())
                                        {
                                            SoccerAbortTimer.Stop();
                                            SoccerAbortTimer.Start();
                                            Send("\n>> " + kicker + "\nYou missed!");
                                            kicker = kicker1;
                                            SoccerKickNumber++;
                                            if (SoccerKickNumber == 10)
                                            {
                                                kicker = "";
                                                Send("Game Finshed!");
                                                Send("Calculating the result...");
                                                System.Threading.Thread.Sleep(5000);
                                                CountIt();
                                            }
                                            else
                                            {
                                                Send("'" + kicker + "' should kick now");
                                            }
                                        }
                                        break;
                                    }
                                //
                                case 2:
                                    {
                                        if (kicker.ToLower() == kicker1.ToLower())
                                        {
                                            SoccerAbortTimer.Stop();
                                            SoccerAbortTimer.Start();
                                            kicker = kicker2;
                                            GoalIt(Ukicker);
                                            SoccerKickNumber++;
                                            if (SoccerKickNumber == 10)
                                            {
                                                kicker = "";
                                                Send("Game Finshed!");
                                                Send("Calculating the result...");
                                                System.Threading.Thread.Sleep(5000);
                                                CountIt();
                                            }
                                            else
                                            {
                                                Send("'" + kicker + "' should kick now");
                                            }
                                        }
                                        else if (kicker.ToLower() == kicker2.ToLower())
                                        {
                                            SoccerAbortTimer.Stop();
                                            SoccerAbortTimer.Start();
                                            kicker = kicker1;
                                            GoalIt(Ukicker);
                                            SoccerKickNumber++;
                                            if (SoccerKickNumber == 10)
                                            {
                                                kicker = "";
                                                Send("Game Finshed!");
                                                Send("Calculating the result...");
                                                System.Threading.Thread.Sleep(5000);
                                                CountIt();
                                            }
                                            else
                                            {
                                                Send("'" + kicker + "' should kick now");
                                            }
                                        }
                                        break;
                                    }
                                //
                                case 7:
                                    {
                                        if (kicker.ToLower() == kicker1.ToLower())
                                        {
                                            SoccerAbortTimer.Stop();
                                            SoccerAbortTimer.Start();
                                            kicker = kicker2;
                                            GoalIt(Ukicker);
                                            SoccerKickNumber++;
                                            if (SoccerKickNumber == 10)
                                            {
                                                kicker = "";
                                                Send("Game Finshed!");
                                                Send("Calculating the result...");
                                                System.Threading.Thread.Sleep(5000);
                                                CountIt();
                                            }
                                            else
                                            {
                                                Send("'" + kicker + "' should kick now");
                                            }
                                        }
                                        else if (kicker.ToLower() == kicker2.ToLower())
                                        {
                                            SoccerAbortTimer.Stop();
                                            SoccerAbortTimer.Start();
                                            kicker = kicker1;
                                            GoalIt(Ukicker);
                                            SoccerKickNumber++;
                                            if (SoccerKickNumber == 10)
                                            {
                                                kicker = "";
                                                Send("Game Finshed!");
                                                Send("Calculating the result...");
                                                System.Threading.Thread.Sleep(5000);
                                                CountIt();
                                            }
                                            else
                                            {
                                                Send("'" + kicker + "' should kick now");
                                            }
                                        }
                                        break;
                                    }
                                //
                                case 4:
                                    {
                                        if (kicker.ToLower() == kicker1.ToLower())
                                        {
                                            SoccerAbortTimer.Stop();
                                            SoccerAbortTimer.Start();
                                            kicker = kicker2;
                                            GoalIt(Ukicker);
                                            SoccerKickNumber++;
                                            if (SoccerKickNumber == 10)
                                            {
                                                kicker = "";
                                                Send("Game Finshed!");
                                                Send("Calculating the result...");
                                                System.Threading.Thread.Sleep(5000);
                                                CountIt();
                                            }
                                            else
                                            {
                                                Send("'" + kicker + "' should kick now");
                                            }
                                        }
                                        else if (kicker.ToLower() == kicker2.ToLower())
                                        {
                                            SoccerAbortTimer.Stop();
                                            SoccerAbortTimer.Start();
                                            kicker = kicker1;
                                            GoalIt(Ukicker);
                                            SoccerKickNumber++;
                                            if (SoccerKickNumber == 10)
                                            {
                                                kicker = "";
                                                Send("Game Finshed!");
                                                Send("Calculating the result...");
                                                System.Threading.Thread.Sleep(5000);
                                                CountIt();
                                            }
                                            else
                                            {
                                                Send("'" + kicker + "' should kick now");
                                            }
                                        }
                                        break;
                                    }
                                //
                                case 5:
                                    {
                                        if (kicker.ToLower() == kicker1.ToLower())
                                        {
                                            SoccerAbortTimer.Stop();
                                            SoccerAbortTimer.Start();
                                            kicker = kicker2;
                                            GoalIt(Ukicker);
                                            SoccerKickNumber++;
                                            if (SoccerKickNumber == 10)
                                            {
                                                kicker = "";
                                                Send("Game Finshed!");
                                                Send("Calculating the result...");
                                                System.Threading.Thread.Sleep(5000);
                                                CountIt();
                                            }
                                            else
                                            {
                                                Send("'" + kicker + "' should kick now");
                                            }
                                        }
                                        else if (kicker.ToLower() == kicker2.ToLower())
                                        {
                                            SoccerAbortTimer.Stop();
                                            SoccerAbortTimer.Start();
                                            kicker = kicker1;
                                            GoalIt(Ukicker);
                                            SoccerKickNumber++;
                                            if (SoccerKickNumber == 10)
                                            {
                                                kicker = "";
                                                Send("Game Finshed!");
                                                Send("Calculating the result...");
                                                System.Threading.Thread.Sleep(5000);
                                                CountIt();
                                            }
                                            else
                                            {
                                                Send("'" + kicker + "' should kick now");
                                            }
                                        }
                                        break;
                                    }
                            }
                        }
                        else
                        {
                            Send("Waiting for '" + SoccerAwaiting.Lines[0] + "' to accept the game.");
                        }
                    }
                    catch { }
                }); thre.IsBackground = true; thre.Start();
            //
        }
        //Soccer Goals 
        void SoccerRandom(object sender, EventArgs e)
        {
            try{
            SoccerRandomint = random.Next(0, 7);}catch{}
        }
        void GoalIt(string user)
        {
            try
            {
                if (user.ToLower() == kicker1.ToLower())
                {
                    Score1++;
                    SoccerAbortTimer.Stop();
                    Send("\n>> " + user + "\nOh! You hit the goal!\nNow you have '" + Score1 + "goals");
                    SoccerAbortTimer.Start();
                }
                else if (user.ToLower() == kicker2.ToLower())
                {
                    Score2++;
                    SoccerAbortTimer.Stop();
                    Send("\n>> " + user + "\nOh! You hit the goal!\nNow you have '" + Score2 + "goals");
                    SoccerAbortTimer.Start();
                }
            }
            catch { } 
        }
        //Soccer Goal Counter
        void CountIt()
        {
            try
            {
                int C1 = Score1;
                int C2 = Score2;
                if (C1 > C2)
                {
                    Send("Result:\n" + kicker1  + "= " + C1 + "\n" + kicker2 + "= " + C2+"\n\n'"+kicker1+"' Won!");
                    AddScore(kicker1, SoccerScoreWin);
                }
                else if (C2 > C1)
                {
                    Send("Result:\n" + kicker1 + "= " + C1 + "\n" + kicker2 + "= " + C2 + "\n\n'" + kicker2 + "' Won!");
                    AddScore(kicker2, SoccerScoreWin);
                }
                else if (C1 == C2)
                {
                    Send("Result:\n" + kicker1 + "= " + C1 + "\n" + kicker2 + "= " + C2 + "\n\nNo-one Won!");
                    AddScore(kicker1, SoccerScoreSame);
                    AddScore(kicker2, SoccerScoreSame);
                }
                SoccerKickNumber = 0;
                SoccerAwaiting.Clear();
                SoccerAbortTimer.Stop();
                SoccerAccepteds.Clear();
                kicker1 = "";
                kicker2 = "";
                SoccerKickNumber = 0;
                Score1 = 0;
                Score2 = 0;
            }catch {}
        }
        //Soccer Accepteds
        void AcceptIt(string user)
        {
            string found = "";
            if (SoccerAwaiting.Lines[0].Trim().ToLower()==user.ToLower().Trim())
            {
                try
                {
                    SoccerAccepteds.Text += user + ":" + 0 + "\n";
                    SoccerAwaiting.Clear();
                    SoccerAbortTimer.Stop();
                    SoccerAbortTimer.Start();
                    Send("\n>> " + user + "\nYou have accepted the 'penalty game'");
                    Send("'" + kicker1  + "' should start the game by sending 'kick'\nYou have 60seconds(1min) to start the game or else the game will be aborted for others to play.");
                    SoccerAbortTimer.Start();
                }
                catch { }
            }
        }
        //Quiz Set up
        //Quiz repeater Timer
        void RepeatQuiz(object sender, EventArgs e)
        {
            if (quizmanage == "on" && QuizAskibleOption == "off")
            {
                Send(QuizQuestion);
            }
        }
        //Quiz On hand Timer
        void QuizHoldTimer(object sender, EventArgs e)
        {
            try{
            string Answ = QuizQuestionAnswer;
            string Qest = QuizQuestion;
            QuizRepeater.Stop();
            QuizElapsedTime.Reset();
            QuizQuestion = "";
            QuizQuestionAnswer = "";
            QuizQuestion = "";
            Send("Sorry, No-one of you obtained the answer of:\n" + Qest + "\nAnswer: " + Answ);
            QuizAskibleOption = "on";
            ReadQuizQuestio();
            }
            catch { }
        }
        void ReadQuizQuestio()
        {
                foreach (string l in System.IO.File.ReadAllLines(@"directory"/*Please specify the quiz file to read.*/))
                {
                    try{
                    if (QuizAskibleOption != "on")
                        return;
                    if (l.StartsWith("[Q" + QuizQuestionNumber + "/") && l.Trim() != string.Empty)
                    {
                        string[] l1 = l.Split('|');
                        QuizQuestionAnswer = l1[1].Trim();
                            try
                            {
                                QuizAskibleOption = "off";
                                QuizRepeater.Stop();
                                QuizeAborter.Stop();
                                QuizElapsedTime.Reset();
                                QuizQuestion = l1[0].Replace("�", "÷");
                                Send(QuizQuestion);
                                QuizQuestionNumber++;
                                QuizeAborter.Interval = QuizAbortCounter;
                                QuizRepeater.Interval = QuizInterval;
                                QuizRepeater.Start();
                                QuizeAborter.Start();
                                QuizElapsedTime.Start();
                            }
                            catch
                            {
                                QuizQuestionNumber = 1;
                                Send("Quiz Ended!");
                            }
                    }
                    }
                    catch { }
                    System.Threading.Thread.Sleep(100);
                }
        }
        //Back Up
     public  void Backup()
        {
            if (!IsBackup)
                return;
            else 
            try
            {
                System.IO.File.WriteAllText(@Roomname1,
                    (
                    SelfProtection + "#" +
                    LineFiltermanage + "#" +
                    LineFilterlen + "#" +
                    QuizQuestionNumber + "#" +
                    Transfermanage + "#" +
                    floodmanage + "#" +
                    quizmanage + "#" +
                    QuizInterval + "#" +
                    QuizAbortCounter + "#" +
                    gamekickmanage + "#" +
                    gamemanage + "#" +
                    antikickmanage + "#" +
                    resfiltermanage + "#" +
                    idfiltermanage + "#" +
                    msgfiltermanage + "#" +
                    badlanguagemanage + "#" +
                    roomlockmanage + "#" +
                    wlmanage + "#" +
                    antikickmsg + "#" +
                    badlmsg + "#" +
                    roomlockpass + "#" +
                    mutemanage + "#" +
                    warningMessa + "#" +
                    idlength + "#" +
                    msglength + "#" +
                    gamekick + "#" +
                    reslength + "#" +
                    QuizScore + "#" +
                    SoccerScoreWin + "#" +
                    SoccerScoreSame + "#" +
                    ShoutScore + "#" +
                    LuckyScore + "#" +
                    MemberByMembermanage + "#" +
                    SelfSoccerPenaltyManage + "#" +
                    LuckyTimerCount + "#" +
                    QuizRepeatCounter + "#" +
                    antikickcounter + "#" +
                    wlmsgholder + "#" +
                    wordfiltermanage + "#" +
                    luckymanager + "#" +
                    LuckyMsg + "#" +
                    Shoutmanage + "#" +
                    Shoutword + "#" +
                    QuizAskibleOption + "#" +
                    ShoutNot + "#" +
                    ShoutMsg + "#" +
                    ShoutTimerCount + "#" +
                    soccermanage + "#" +
                    silecncemanage + "#" +
                    autobanmanage + "#" +
                    autokickmanage + "#" +
                    automutemanage + "#" +
                    autovisitor + "#" +
                    automember + "#" +
                    adminmodSkipper + "#" +
                    SmartDetmanage + "#" +
                    autoaddmanage + "#" +
                    SmartDet + "#" +
                    reportmanage + "#" +
                    autoinvitemanage + "#" +
                   lovemanage + "#" +
                   AutoAddManage + "#" +
                   anticapitalmanage + "#" +
                   capitalaction + "#" +
                   jokemanage + "#" +
                   jokeinterval + "#" +
                   LuckyNot + "#" +
                   bombmanage + "#" +
                   bombprotecmanage + "#" +
                   bombcost + "#" +
                   bombprotectcost + "#" +
                   autoIPbanmanage + "#" +
                   forbiddenjidaction + "#" +
                   CapitacMsg + "#" +
                   wordlist.Text.Replace("\n", "<>") + "#" +
                   reportlist.Text.Replace("\n", "<>") + "#" +
                   ownerlist.Text + "#" +
                   BombList.Text.Replace("\n", "<>") + "#" +
                   BombProtectList.Text.Replace("\n", "<>") + "#" +
                   badreslist.Text.Replace("\n", "<>") + "#" +
                   formbiddenuserslist.Text.Replace("\n", "<>") + "#" +
                   badjidlist.Text.Replace("\n", "<>") + "#" +
                   recognizedw.Text.Replace("\n", "<>") + "#" +
                   badla.Text.Replace("\n", "<>") + "#" +
                   luckylist.Text.Replace("\n","<>") + "#" +
                   BombedUserList.Text.Replace("\n", "<>") + "#" +
                   System.DateTime.Now.ToString()
                    ));
            }
            catch(Exception v) {
            }
            if (IsBackup)
            {
            }
        }
     bool IsBackup = true;
        //
         String IPpassword = "";//Please specify  your IP password
         public string IP = "https://nizzc.com/freenet:2124";
         string IPusername = "nizzcteam";//please specify your IP username
         string file = "";
         void comp(object sender, EventArgs e)
         {
         }
        //Local Backup
         void LocalFTP()
         {
             System.Threading.Thread thre = new System.Threading.Thread(() =>
             {try{
                 bool IsThere;
                 if (System.IO.File.Exists(@Roomname1))
                 {
                     IsThere = true;
                     try
                     {
                         Restore();
                         BackupTimer.Stop();
                         BackupTimer.Start();
                     }
                     catch {  }
                     if (IsThere)
                     {
                         if (System.IO.File.ReadAllText(@Roomname1).Contains("#"))
                         {
                               }
                         else
                         {
                         }
                     }
                 }
                 else
                 {
                     try
                     {
                         BackupTimer.Stop();
                         BackupTimer.Start();
                         Send("It seems that there is no backup for this room, send '#update' to check on our server.");
                     }
                     catch { }
                 }
             }
             catch { }
             }); thre.IsBackground = true; thre.Start();
         }
         Timer UpBackUp = new Timer();
        //Download Backup
          void DownloadFTP()
         {
                 System.Threading.Thread thre = new System.Threading.Thread(() =>
                 {try{
                     if (passch == "off")
                         return;
                     else 
                     try
                     {
                         WebClient ftp = new WebClient();
                         ftp.DownloadFileCompleted += new AsyncCompletedEventHandler(comp);
                         ftp.Credentials = new System.Net.NetworkCredential(IPusername, IPpassword);
                         ftp.DownloadFile(IP.Replace("freenet:2124","")+"/rooms/"+Roomname1, @Roomname1+"temp");
                         BackupTimer.Start();
                         Send("Backup file is downloaded successfully!\nSend '#restore' to restore it now.");
                     }
                     catch (Exception v)
                     {
                     }     }
             catch (Exception v) { Send("Error occured while downloading backup file. Please try again."); }
                     //Restore();
                 }); thre.IsBackground = true; thre.Start();
         }
          void ReadedFTP(string[] result)
         {
         }
        //Read and check from server
          void ReadFTP()
         {
             if (passch == "off")
                 return;
             else
             {
                 string found = "";
                 string there = "";
                 System.Threading.Thread thre = new System.Threading.Thread(() =>
                 {
                     try
                     {
                         Nizzc_Collection.ServerBackup.ftp1 ftp = new ServerBackup.ftp1(IP, IPusername, IPpassword, Roomname1, x);
                         string[] sp = ftp.directoryListSimple("rooms/");
                         for (int i = 0; i < sp.Count(); i++)
                         {
                             there += sp[i] + "\n";
                             if (sp[i].ToLower() == Roomname1)
                             {
                                 found = "yes";
                             }
                             System.Threading.Thread.Sleep(10);
                         }
                         if (found != "yes")
                         {
                             Send("No backup found on our server for this room. you can send any time '#backup' to backup your room to our server.");
                             BackupTimer.Start();
                         }
                         else
                         {
                             try
                             {
                                 Send("Downloading backup file... Please wait");
                                 DownloadFTP();
                             }
                             catch (Exception v)
                             {
                             }
                         }
                     }
                     catch { }
                 }); thre.IsBackground = true;
                 thre.Start();
             }
         }
          int counting = 0;
        //Upload Backup
          void UploadFTP()
          {
                  System.Threading.Thread thre = new System.Threading.Thread(() =>
                     {
                         if (!IsBackup)
                             return;
                         else 
                         try
                         {
                             WebClient pp = new WebClient();
                             pp.Credentials = new System.Net.NetworkCredential(IPusername, IPpassword);
                             pp.UploadFile(IP.Replace("freenet:2124","")+"/rooms/" +Roomname1, "STOR", @Roomname1);
                             Send("Backup is made on our server for your room!.");
                             counting = 0;
                             return;
                         }
                         catch (Exception v)
                         {
                             if (counting <= 3)
                             {
                                 Backup();
                                 Send("Please wait making local backup...");
                                 UploadFTP();
                             }
                             else
                             {
                                 counting = 0;
                                 Send("There is error backing up your room on our webserver. Please try again later.\nIf this error persists, Please contact us: team@nizzc.com or https://nizzc.com/contact");
                             }
                         }
                     }); thre.IsBackground = true; thre.Start();
              }
          void DeleteFile()
          {
              try
              {
                  if (File.Exists(@Roomname1)) 
                  {
                      File.Delete(@Roomname1);
                  }
              }
              catch (IOException t)
              {
                  //incase of error, this will occur as loop, so make sure that IO permission will not occur.
                  DeleteFile();
              }
          }
        //
          void DeleteFile1()
          {
              if (passch == "off")
                  return;
              else
                  try
                  {
                      if (File.Exists(@Roomname1+"temp"))
                      {
                          File.Delete(@Roomname1+"temp");
                      }
                  }
                  catch (IOException t)
                  {
                      //incase of error, this will occur as loop, so make sure that IO permission will not occur.
                      DeleteFile();
                  }
          }
          int DownloadTimes = 0;
        //Restore
        void Restore()
       {
           string DTime = "";
            bool IsqzOn = false;
            bool IsOk = false;
           System.Threading.Thread thre = new System.Threading.Thread(() =>
           {
               try
               {
                   if (!System.IO.File.Exists(@Roomname1))
                   {
                   }
                   else
                       try
                       {
                           int i = 0;
                           Restorelist.Text = System.IO.File.ReadAllText(@Roomname1);
                           if (Restorelist.Text.Trim() != string.Empty && Restorelist.Text.Contains("#"))
                           {
                               IsOk = true;
                               string[] l = Restorelist.Text.Split('#');
                               try
                               {
                                   SelfProtection = l[i];
                               }
                               catch {  }
                               i++;
                               try{
                               LineFiltermanage = l[i];
                               }
                               catch {  }
                               i++;
                               try{
                               LineFilterlen = Convert.ToInt32(l[i]);
                               }
                               catch { }
                               i++;
                               try{
                               QuizQuestionNumber = Convert.ToInt32(l[i]);
                               }
                               catch {  }
                               i++;
                               try{
                                   Transfermanage = l[i];
                               }
                               catch {  }
                               i++;
                               try{
                                   floodmanage = l[i];
                               }
                               catch {  }
                               i++;
                               try
                               {
                                   quizmanage = l[i];
                               }
                               catch {  }
                               if (quizmanage == "on")
                               {
                                   IsqzOn = true;
                               }
                               i++;
                               try{
                                   QuizInterval = Convert.ToInt32(l[i]);
                               }
                               catch {  }
                               i++;
                               try{
                                   QuizAbortCounter = Convert.ToInt32(l[i]);
                               }
                               catch {  }
                               i++;
                               try{
                                   gamekickmanage = l[i];
                               }
                               catch {  }
                               i++;
                               try{
                                   gamemanage = l[i];
                               }
                               catch {  }
                               i++;
                               try{
                                   antikickmanage = l[i];
                               }
                               catch {  }
                               i++;
                               try{
                                   resfiltermanage = l[i];
                               }
                               catch {  }
                               i++;
                               idfiltermanage = l[i];
                               i++;
                               msgfiltermanage = l[i];
                               i++;
                               badlanguagemanage = l[i];
                               i++;
                               roomlockmanage = l[i];
                               i++;
                               wlmanage = l[i];
                               i++;
                               antikickmanage = l[i];
                               i++;
                               badlmsg = l[i];
                               i++;
                               roomlockpass = l[i];
                               i++;
                               mutemanage = l[i];
                               i++;
                               warningMessa = l[i];
                               i++;
                               try{
                                   idlength = Convert.ToInt32(l[i]);
                               }
                               catch {  }
                               i++;
                               try{
                                   msglength = Convert.ToInt32(l[i]);
                               }
                               catch {  }
                               i++;
                               try{
                                   gamekick = Convert.ToInt32(l[i]);
                               }
                               catch {  }
                               i++;
                               try{
                                   reslength = Convert.ToInt32(l[i]);
                               }
                               catch {  }
                               i++;
                               try{
                                   QuizScore = Convert.ToInt32(l[i]);
                               }
                               catch {  }
                               i++;
                               try{
                                   SoccerScoreWin = Convert.ToInt32(l[i]);
                               }
                               catch {  }
                               i++;
                               try{
                                   SoccerScoreSame = Convert.ToInt32(l[i]);
                               }
                               catch {  }
                               i++;
                               try{
                                   ShoutScore = Convert.ToInt32(l[i]);
                               }
                               catch {  }
                               i++;
                               try{
                                   LuckyScore = Convert.ToInt32(l[i]);
                               }
                               catch {  }
                               i++;
                               MemberByMembermanage = l[i];
                               i++;
                               SelfSoccerPenaltyManage = l[i];
                               i++;
                               try{
                                   LuckyTimerCount = Convert.ToInt32(l[i]);
                               }
                               catch {  }
                               i++;
                               try{
                                   QuizRepeatCounter = Convert.ToInt32(l[i]);
                               }
                               catch {  }
                               i++;
                               try{
                                   antikickcounter = Convert.ToInt32(l[i]);
                               }
                               catch {  }
                               i++;
                               wlmsgholder = l[i];
                               i++;
                               wordfiltermanage = l[i];
                               i++;
                               luckymanager = l[i];
                               i++;
                               LuckyMsg = l[i];
                               i++;
                               Shoutmanage = l[i];
                               i++;
                               Shoutword = l[i];
                               i++;
                               QuizAskibleOption = l[i];
                               i++;
                               ShoutNot = l[i];
                               i++;
                               ShoutMsg = l[i];
                               i++;
                               try{
                                   ShoutTimerCount = Convert.ToInt32(l[i]);
                               }
                               catch { }
                               i++;
                               soccermanage = l[i];
                               i++;
                               silecncemanage = l[i];
                               i++;
                               autobanmanage = l[i];
                               i++;
                               autokickmanage = l[i];
                               i++;
                               automutemanage = l[i];
                               i++;
                               autovisitor = l[i];
                               i++;
                               automember = l[i];
                               i++;
                               adminmodSkipper = l[i];
                               i++;
                               SmartDetmanage = l[i];
                               i++;
                               AutoAddManage = l[i];
                               i++;
                               SmartDet = l[i];
                               i++;
                               reportmanage = l[i];
                               i++;
                               autoinvitemanage = l[i];
                               i++;
                               lovemanage = l[i];
                               i++;
                               autoaddmanage = l[i];
                               i++;
                               anticapitalmanage = l[i];
                               i++;
                               capitalaction = l[i];
                               i++;
                               jokemanage = l[i];
                               i++;
                               try{
                                   jokeinterval = Convert.ToInt32(l[i]);
                               }
                               catch {  }
                               i++;
                               LuckyNot = l[i];
                               i++;
                               bombmanage = l[i];
                               i++;
                               bombprotecmanage = l[i];
                               i++;
                               try{
                                   bombcost = Convert.ToInt32(l[i]);
                               }
                               catch { }
                               i++;
                               try
                               {
                                   bombprotectcost = Convert.ToInt32(l[i]);
                               }
                               catch {  }
                               i++;
                              try{
                                  autoIPbanmanage = l[i];
                              }
                              catch { }
                               i++;
                               try{
                               if (l[i].Trim() != string.Empty)
                               {
                                   forbiddenjidaction = l[i];
                               }
                               }
                               catch {  }
                               i++;
                               try{
                               if (l[i].Trim() != string.Empty)
                               {
                                   CapitacMsg = l[i];
                               }
                               }
                               catch {  }
                               i++;
                               try{
                               if (l[i].Trim() != string.Empty)
                               {
                                   wordlist.Text = l[i].Replace("<>", "\n");
                               }
                               }
                               catch {  }
                               i++;
                               try{
                               if (l[i].Trim() != string.Empty)
                               {
                                   reportlist.Text = l[i].Replace("<>", "\n");
                               }
                               }
                               catch {  }
                               i++;
                               if (l[i].Trim() != string.Empty)
                               {
                                   ownerlist.Text = l[i].Replace("<>", "\n");
                               }
                               i++;
                               if (l[i].Trim() != string.Empty)
                               {
                                   BombList.Text = l[i].Replace("<>", "\n");
                               }
                               i++;
                               if (l[i].Trim() != string.Empty)
                               {
                                   BombProtectList.Text = l[i].Replace("<>", "\n");
                               }
                               i++;
                               if (l[i].Trim() != string.Empty)
                               {
                                   badreslist.Text = l[i].Replace("<>", "\n");
                               }
                               i++;
                               if (l[i].Trim() != string.Empty)
                               {
                                   formbiddenuserslist.Text = l[i].Replace("<>", "\n");
                               }
                               i++;
                               if (l[i].Trim() != string.Empty)
                               {
                                   badjidlist.Text = l[i].Replace("<>", "\n");
                               }
                               i++;
                               if (l[i].Trim() != string.Empty)
                               {
                                   recognizedw.Text = l[i].Replace("<>", "\n");
                               }
                               i++;
                               if (l[i].Trim() != string.Empty)
                               {
                                   badla.Text = l[i].Replace("<>", "\n");
                               }
                               i++;
                               if (l[i].Trim() != string.Empty)
                               {
                                   luckylist.Text = l[i].Replace("<>", "\n");
                               }
                               i++;
                               if (l[i].Trim() != string.Empty)
                               {
                                   BombedUserList.Text = l[i].Replace("<>", "\n");
                               }
                               i++;
                               try
                               {
                                   DTime = l[i];
                               }
                               catch { }
                           }
                           else
                           {
                           }
                       }
                       catch (Exception v)
                       {
                           Send("Sorry the backup file is corrupted and bot is unable to read room information...");
                           Send("...in the file. please contact 'team@nizzc.com' or https://nizzc.com/contact");
                       }
                   if (IsqzOn)
                   {
                   }
                   if (IsOk)
                   { 
                       Send("Bot resumed session from "+ DTime+" . To undo this send '#reset'");
                   }
               }
               catch { }
          }); thre.IsBackground = true; thre.Start();
       }
        //
        void Restore1(bool Isresorable)
        {
            if (!System.IO.File.Exists(@Roomname1+"temp"))
            {
                Send("Sorry, no local backup file found.\nSend '#update' to check it on our server.");
            }
            else
                try
                {
                    int i = 0;
                    Restorelist.Text = System.IO.File.ReadAllText(@Roomname1+"temp");
                    if (Restorelist.Text.Trim() != string.Empty && Restorelist.Text.Contains("#"))
                    {
                        if (Isresorable)
                        {
                            string[] l = Restorelist.Text.Split('#');
                            SelfProtection = l[i];
                            i++;
                            LineFiltermanage = l[i];
                            i++;
                            LineFilterlen = Convert.ToInt32(l[i]);
                            i++;
                            QuizQuestionNumber = Convert.ToInt32(l[i]);
                            i++;
                            Transfermanage = l[i];
                            i++;
                            floodmanage = l[i];
                            i++;
                            quizmanage = l[i];
                            i++;
                            QuizInterval = Convert.ToInt32(l[i]);
                            i++;
                            QuizAbortCounter = Convert.ToInt32(l[i]);
                            i++;
                            gamekickmanage = l[i];
                            i++;
                            gamemanage = l[i];
                            i++;
                            antikickmanage = l[i];
                            i++;
                            resfiltermanage = l[i];
                            i++;
                            idfiltermanage = l[i];
                            i++;
                            msgfiltermanage = l[i];
                            i++;
                            badlanguagemanage = l[i];
                            i++;
                            roomlockmanage = l[i];
                            i++;
                            wlmanage = l[i];
                            i++;
                            antikickmanage = l[i];
                            i++;
                            badlmsg = l[i];
                            i++;
                            roomlockpass = l[i];
                            i++;
                            mutemanage = l[i];
                            i++;
                            warningMessa = l[i];
                            i++;
                            idlength = Convert.ToInt32(l[i]);
                            i++;
                            msglength = Convert.ToInt32(l[i]);
                            i++;
                            gamekick = Convert.ToInt32(l[i]);
                            i++;
                            reslength = Convert.ToInt32(l[i]);
                            i++;
                            QuizScore = Convert.ToInt32(l[i]);
                            i++;
                            SoccerScoreWin = Convert.ToInt32(l[i]);
                            i++;
                            SoccerScoreSame = Convert.ToInt32(l[i]);
                            i++;
                            ShoutScore = Convert.ToInt32(l[i]);
                            i++;
                            LuckyScore = Convert.ToInt32(l[i]);
                            i++;
                            MemberByMembermanage = l[i];
                            i++;
                            SelfSoccerPenaltyManage = l[i];
                            i++;
                            LuckyTimerCount = Convert.ToInt32(l[i]);
                            i++;
                            QuizRepeatCounter = Convert.ToInt32(l[i]);
                            i++;
                            antikickcounter = Convert.ToInt32(l[i]);
                            i++;
                            wlmsgholder = l[i];
                            i++;
                            wordfiltermanage = l[i];
                            i++;
                            luckymanager = l[i];
                            i++;
                            LuckyMsg = l[i];
                            i++;
                            Shoutmanage = l[i];
                            i++;
                            Shoutword = l[i];
                            i++;
                            QuizAskibleOption = l[i];
                            i++;
                            ShoutNot = l[i];
                            i++;
                            ShoutMsg = l[i];
                            i++;
                            ShoutTimerCount = Convert.ToInt32(l[i]);
                            i++;
                            soccermanage = l[i];
                            i++;
                            silecncemanage = l[i];
                            i++;
                            autobanmanage = l[i];
                            i++;
                            autokickmanage = l[i];
                            i++;
                            automutemanage = l[i];
                            i++;
                            autovisitor = l[i];
                            i++;
                            automember = l[i];
                            i++;
                            adminmodSkipper = l[i];
                            i++;
                            SmartDetmanage = l[i];
                            i++;
                            AutoAddManage = l[i];
                            i++;
                            SmartDet = l[i];
                            i++;
                            reportmanage = l[i];
                            i++;
                            autoinvitemanage = l[i];
                            i++;
                            lovemanage = l[i];
                            i++;
                            autoaddmanage = l[i];
                            i++;
                            anticapitalmanage = l[i];
                            i++;
                            capitalaction = l[i];
                            i++;
                            jokemanage = l[i];
                            i++;
                            jokeinterval = Convert.ToInt32(l[i]);
                            i++;
                            LuckyNot = l[i];
                            i++;
                            bombmanage = l[i];
                            i++;
                            bombprotecmanage = l[i];
                            i++;
                            bombcost = Convert.ToInt32(l[i]);
                            i++;
                            bombprotectcost = Convert.ToInt32(l[i]);
                            i++;
                            autoIPbanmanage = l[i];
                            i++;
                            forbiddenjidaction = l[i];
                            i++;
                            CapitacMsg = l[i];
                            i++;
                            wordlist.Text = l[i];
                            i++;
                            if (l[i].Trim() != string.Empty)
                            {
                                reportlist.Text = l[i].Replace("<>", "\n");
                            }
                            i++;
                            if (l[i].Trim() != string.Empty)
                            {
                                ownerlist.Text = l[i].Replace("<>", "\n");
                            }
                            i++;
                            if (l[i].Trim() != string.Empty)
                            {
                                BombList.Text = l[i].Replace("<>", "\n");
                            }
                            i++;
                            if (l[i].Trim() != string.Empty)
                            {
                                BombProtectList.Text = l[i].Replace("<>", "\n");
                            }
                            i++;
                            if (l[i].Trim() != string.Empty)
                            {
                                badreslist.Text = l[i].Replace("<>", "\n");
                            }
                            i++;
                            if (l[i].Trim() != string.Empty)
                            {
                                formbiddenuserslist.Text = l[i].Replace("<>", "\n");
                            }
                            i++;
                            if (l[i].Trim() != string.Empty)
                            {
                                badjidlist.Text = l[i].Replace("<>", "\n");
                            }
                            i++;
                            if (l[i].Trim() != string.Empty)
                            {
                                recognizedw.Text = l[i].Replace("<>", "\n");
                            }
                            i++;
                            if (l[i].Trim() != string.Empty)
                            {
                                badla.Text = l[i].Replace("<>", "\n");
                            }
                            i++;
                            if (l[i].Trim() != string.Empty)
                            {
                                luckylist.Text = l[i].Replace("<>", "\n");
                            }
                            i++;
                            if (l[i].Trim() != string.Empty)
                            {
                                BombedUserList.Text = l[i].Replace("<>", "\n");
                            }
                            i++;
                            Send("Room is restored to " + l[i]);
                            i = 0;
                        }
                        else
                        {
                            string[] l = Restorelist.Text.Split('#');
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            if (l[i].Trim() != string.Empty)
                            {
                            }
                            i++;
                            if (l[i].Trim() != string.Empty)
                            {
                            }
                            i++;
                            if (l[i].Trim() != string.Empty)
                            {
                            }
                            i++;
                            if (l[i].Trim() != string.Empty)
                            {
                            }
                            i++;
                            if (l[i].Trim() != string.Empty)
                            {
                            }
                            i++;
                            if (l[i].Trim() != string.Empty)
                            {
                            }
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            i++;
                            Send("This was backed up on '" + l[i]+"' and if you continue you will loose current data. \nDo you want continue anyway?\nYes\nNo");
                            YesNo = "update";
                            aborttimer.Stop();
                            aborttimer.Start();
                        }
                        return;
                    }
                    else
                    {
                        Send("There is a problem reading the backup file. please create backup or download backup from our server and try again.");
                    }
                }
                catch (Exception v)
                {
                }
            return;
        }
        //Room Score Transfer
        void ToRoomTransfer(string FromUser, string ToUser, int Amount, string msg1)
        {
            string found = "";
            string point = "";
            string iD = "";
            int mem = 0;
            string NotEnough = "";
            System.Windows.Forms.RichTextBox temp = new System.Windows.Forms.RichTextBox();
            foreach (string l in luckylist.Lines)
            {
                try{
                if (l.Trim() != string.Empty)
                {
                    string[] l1 = l.Split(':');
                    iD = l1[0];
                    point = l1[1];
                }
                if (iD.ToLower() == FromUser.ToLower())
                {
                    int add = Convert.ToInt32(point);
                    if (add >= Amount)
                    {
                        int total = add - Amount;
                        string all = iD + ":" + total;
                        mem = total;
                        temp.Text += all + "\n";
                        found = "yes";
                        NotEnough = "no";
                    }
                    else
                    {
                        temp.Text += l + "\n";
                    }
                }
                else
                {
                    temp.Text += l + "\n";
                }
                }
                catch { }
                System.Threading.Thread.Sleep(10);
            }
            luckylist.Text = temp.Text;
            if (NotEnough == "no")
            {
                System.Threading.Thread thre = new System.Threading.Thread(() =>
                {
                    try
                    {
                        Send("Please wait while transfer is being prepared...");
                        WebClient Ftp = new WebClient();
                        Ftp.Credentials = new System.Net.NetworkCredential(IPusername, IPpassword);
                        string filename = ToUser + "-" + Amount;
                        System.Windows.Forms.RichTextBox saveit = new System.Windows.Forms.RichTextBox();
                        saveit.Text = "This score of " + Amount + " has been transmitted by " + FromUser + " to " + ToUser + " in "+Roomname1+"@c.n.c On " + System.DateTime.Now.ToShortDateString();
                        saveit.SaveFile(@filename);
                        saveit.SaveFile(@filename);
                        System.Threading.Thread.Sleep(2000);
                        Ftp.UploadFile(IP+"/Dir/" + filename,"STOR", @filename);
                        Send(msg1);
                        System.IO.File.Delete(@filename);
                    }
                    catch
                    {
                        Send("\n>> " + FromUser + "\nSorry, something got wrong! This could be caused by either Network connection error or our server is busy. please retry...");
                        Send("...If this error persists, please don't hesitate to contact us 'team@nizzc.com'.");
                        System.Threading.Thread.Sleep(3000);
                        Send("\n>> "+FromUser+"\n Your Score points of '" + Amount + "' is being refunded");
                        TransferTo(ToUser, Amount, "Nizzc Incorp.");
                    }
                }); thre.IsBackground = true; thre.Start();
            }
            else
            {
                Send("\n>> " + FromUser + "\nSorry, you don't have enough score points to transfer!");
            }
        }
     public void TransferRedeem(string FromUser)
        {
           string found = "";
                string there = "";
                    System.Threading.Thread thre = new System.Threading.Thread(() =>
                    {
                        try
                        {
                            string sp1 = "";
                            int  sp2 = 0;
                           string file = "";
                            string sp3 = "";
                            FTP.ftp1 ftp = new FTP.ftp1(IP, IPusername, IPpassword);
                            string[] sp = ftp.directoryListSimple("/Dir/");
                            for (int i = 0; i < sp.Count(); i++)
                            {
                                if (sp[i].Contains("-"))
                                {
                                    string[] sp0 = sp[i].Split('-');
                                    sp1 = sp0[0];
                                    sp2 = Convert.ToInt32(sp0[1]);
                                }
                                if (sp1.ToLower() == FromUser.ToLower())
                                {
                                    //file = sp[i];
                                    found = "yes";
                                    there = sp[i];
                                }
                                System.Threading.Thread.Sleep(10);
                            }
                            if (found != "yes")
                            {
                                Send("Sorry, we can't find score transfer for you. If you are sure that you have(been) transfered (to you) score points please retry.");
                                Send("If the problem persists, please don't hesitate to tell us via 'team@nizzc.com");
                            }
                            else
                            {
                                try
                                {
                                    TransferRedeemedScore(sp1, sp2, sp1+"-"+sp2);
                                }
                                catch (Exception v)
                                {
                                }
                            }
                        }
                        catch (Exception v)
                        {
                        }
                    }); thre.IsBackground = true;
                    thre.Start();
        }
     Timer AdminAllert = new Timer();
     void AdminAllertHandler(object sender, EventArgs e)
     {
         if (!FullMaster)
         {
             if (isalart)
             {
                 Send("Bot is not owner, Room is unprotected! \nSend HELP/owner\nTo turn off this alert send  ALERT/OFF");
             }
         }
     }
     int amount111 = 0;
     string user1111 = "";
     void sys1(object sender, EventArgs e)
     {
         try
         {
             amount111 = 0;
             user1111 = "";
         }
         catch { }
     }
     void trdone(string user, int amount)
     {
     }
        //Buy Some thing
        void Buy(string user, System.Windows.Forms.RichTextBox FromControl, char splitter, int cost,string whattobuy, System.Windows.Forms.RichTextBox ToControl,int BuyNumber)
        {
          try{
            int Remained=0;
            string Seficient = "";
            int PointsHave = 0;
            string found = "";
            string bought= "";
            System.Windows.Forms.RichTextBox temp = new System.Windows.Forms.RichTextBox();
            foreach (string l in FromControl.Lines)
            {
                if (l.Trim() != string.Empty)
                {
                    string[] sp = l.Split(splitter);
                    if (sp[0] == user)
                    {
                        found = "yes";
                        PointsHave = Convert.ToInt32(sp[1]);
                        if (PointsHave >= cost)
                        {
                            Remained = PointsHave - cost;
                            temp.Text += user + splitter + Remained + "\n";
                            Seficient = "yes";
                        }
                        else
                        {
                            Seficient = "no";
                            temp.Text += user + splitter + PointsHave + "\n";
                        }
                    }
                    else
                    {
                        temp.Text += l + "\n";
                    }
                }
                System.Threading.Thread.Sleep(10);
            }
            //
            System.Windows.Forms.RichTextBox temp2 = new System.Windows.Forms.RichTextBox();
            if (Seficient == "yes")
            {
                int itemNumber=0;
                string found2 = "";
                foreach (string l in ToControl.Lines)
                {
                    if (l.Trim() != string.Empty)
                    {
                        string[] sp = l.Split(splitter);
                        if (sp[0].ToLower() == user.ToLower())
                        {
                            int Addup = Convert.ToInt32(sp[1]) + BuyNumber;
                            itemNumber = Addup;
                            temp2.Text += user + splitter + Addup + "\n";
                            found2 = "yes";
                        }
                        else
                        {
                            temp2.Text += l + "\n";
                        }
                    }
                    System.Threading.Thread.Sleep(10);
                }
                if (found2 != "yes")
                {
                    temp2.Text += user + splitter + BuyNumber + "\n";
                    Send("\n>> " + user + "\nThank you for purchasing!\nItems: " + BuyNumber +whattobuy+ "\nCost: " + cost + "points\nYour remaining points: " + Remained);
                }
                else
                {
                    Send("\n>> " + user + "\nThank you for purchasing!\nItems: " + BuyNumber+ whattobuy +"\nCost: " + cost + "\nYour remaining points: " + Remained);
                }
            }
            else
            {
                Send("\n>> " + user + "\nSorry, you don't have enough points to buy '" + whattobuy + "' which cost(s) '" + cost + "'!\nYou have: " + PointsHave + "points\nPlease send 'HELP/POINTS' to learn how to get more points.");
            }
            FromControl.Text = temp.Text;
           ToControl.Text = temp2.Text;
            temp2.Clear();
            temp.Clear();
          }
          catch { }
        }
        //Bomb Game and related Arena
        void BombUser(string bomber, string bombee)
        {
                System.Threading.Thread thre = new System.Threading.Thread(() =>
                {
                    try{
                    string found = "";
                    string found2 = "";
                    string havebomb = "";
                    string bompro = "";
                    int bomb1 = 0;
                    int abom2 = 0;
                    System.Windows.Forms.RichTextBox temp = new System.Windows.Forms.RichTextBox();
                    System.Windows.Forms.RichTextBox temp2 = new System.Windows.Forms.RichTextBox();
                    foreach (string l in BombList.Lines)
                    {
                        if (l.Trim() != string.Empty)
                        {
                            string[] sp = l.Split(':');
                            if (sp[0].ToLower() == bomber.ToLower())
                            {
                                found = "yes";
                                int sub = Convert.ToInt32(sp[1]);
                                if (sub > 0)
                                {
                                    if (OnlineShip(bombee))
                                    {
                                        havebomb = "yes";
                                        int remnd = sub - 1;
                                        temp.Text += bomber + ":" + remnd + "\n";
                                    }
                                    else
                                    {
                                        havebomb = "yes";
                                        int remnd = sub;
                                        temp.Text += bomber + ":" + remnd + "\n";
                                    }
                                }
                                else
                                {
                                    havebomb = "no";
                                }
                            }
                            else
                            {
                                temp.Text += l + "\n";
                            }
                        }
                        System.Threading.Thread.Sleep(10);
                    }
                    foreach (string l in BombProtectList.Lines)
                    {
                        if (l.Trim() != string.Empty && l.Contains(":"))
                        {
                            string[] sp = l.Split(':');
                            if (sp[0].ToLower().Trim() == bombee.ToLower().Trim())
                            {
                                int abm = Convert.ToInt32(sp[1]);
                                if (abm > 0)
                                {
                                    bompro = "yes";
                                    abom2 = abm;
                                    found2 = "yes";
                                    temp2.Text += bombee + ":" + (abm - 1) + "\n";
                                }
                                else
                                {
                                    temp2.Text += l + "\n";
                                }
                            }
                        }
                        System.Threading.Thread.Sleep(10);
                    }
                    if (found == "yes")
                    {
                        if (havebomb == "yes")
                        {
                            if (OnlineShip(bombee))
                            {
                                if (bompro == "yes")
                                {
                                    Send("\n>> " + bomber + "\nOh, '" + bombee + "' was having bomb sheild and you have exploded one of it.\nHe/She has '" + (abom2 - 1) + "' bomb(s) remaining.\nYou have exploded from him/her '1Bomb Sheild'.\nKeep bombing him to overpower him/her!");
                                }
                                else
                                {
                                    Send("'" + bombee + "' has been bombed out by '" + bomber + "' will be kicked after 5seconds");
                                    System.Threading.Thread.Sleep(5000);
                                    doaction(bombee, "/kick ", "");
                                    BombedUserList.Text += bombee + ":" + bomber;
                                }
                            }
                            else
                            {
                                Send("Sorry, '" + bombee + "' is not in this room");
                            }
                        }
                        else
                        {
                            Send("\n>> " + bomber + "\nSorry, you have don't bomb to bomb out '" + bombee + "'.\nPlease buy bomb with your points and try again to bomb out!");
                        }
                    }
                    else
                    {
                        Send("\n>> " + bomber + "\nSorry, you have don't bomb to bomb out '" + bombee + "'.\nPlease buy bomb with your points and try again to bomb out!");
                    }
                    BombList.Text = temp.Text;
                    BombProtectList.Text = temp2.Text;
                    temp.Clear();
                    temp2.Clear();}
            catch { }
                }); thre.IsBackground = true; thre.Start();
        }
    }}
