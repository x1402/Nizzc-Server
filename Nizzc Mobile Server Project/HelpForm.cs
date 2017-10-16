using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Nizzc_Mobile_Server
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (treeView1.SelectedNode.Name.Trim() != string.Empty)
                {
                    string applicationDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                    string myFile = Path.Combine(applicationDirectory, "help/" + treeView1.SelectedNode.Name);
                    webBrowser1.Url = new Uri("file:///" + myFile);
                  }
            }
            catch { }
             }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }
        private void HelpForm_Load(object sender, EventArgs e)
        {
            try
            {
                string applicationDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                string myFile = Path.Combine(applicationDirectory, "help/ntrd.htm");
                webBrowser1.Url = new Uri("file:///" + myFile);
            }
            catch { }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
