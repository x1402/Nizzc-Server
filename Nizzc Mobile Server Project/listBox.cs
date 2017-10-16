using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace Nizzc_Mobile_Ser
{
    public partial class listBox : ListBox
    {
        public listBox()
        {
            InitializeComponent();
        }
        public void AddItem(string Item)
        {
            this.Items.Add(Item);
        }
    }
}