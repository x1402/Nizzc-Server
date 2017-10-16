using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nizzc_Mobile_Ser;
using agsXMPP;
using System.Windows.Forms;
namespace Nizzc_Mobile_Server
{
    class DCTerminator
    {
        XmppClientConnection x;
        public string Terminator(string owner, string user)
        {
            string IsRemoved = "";
            try
            {
                RichTextBox temp = new RichTextBox();
                RichTextBox temp1 = new RichTextBox();
                string[] sp = Form1.Terminator.Text.Split('#');
                for (int i = 0; i < sp.Count();i++ )
                {
                    if (sp[i].Contains(":") && sp[i].Trim() != string.Empty)
                    {
                        string[] sp1 = sp[i].Split(':');
                        if (sp[i].Trim().ToLower() == owner.Trim().ToLower() + ":" + user.ToLower().Trim())
                        {
                            IsRemoved = "done";
                        }
                        else
                        {
                            temp.Text += sp[i] + "#";
                        }
                    }
                }
                Form1.Terminator.Clear();
                if (temp.Text.Trim() != string.Empty)
                {
                    for (int i = 0; i < temp.Lines.Count();i++ )
                    {
                        string sp2 = temp.Lines[i];
                        if (!Form1.Terminator.Text.Contains(sp2) && sp2.Trim() != string.Empty)
                        {
                            Form1.Terminator.Text += sp2 + "#";
                        }
                    }
                }
            }
            catch { }
            return IsRemoved;
        }
    }
}
