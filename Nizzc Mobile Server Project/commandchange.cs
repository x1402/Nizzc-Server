using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Nizzc_Collection
{
    public partial class commandchange : Form
    {
        public commandchange()
        {
            InitializeComponent();
        }
        string check = "";
        private void commandchange_Load(object sender, EventArgs e)
        {
            string i = Nizzc_Collection.Form4.com1.Text;
            if (i.EndsWith("#"))
            {
                check = "yes";
            }
            else
            {
                check = "no";
            }
            switch (i)
            {
                case "[": { Close(); break; }
                case "]": { Close(); break; }
                case " ": { Close(); break; }
                case "---Room Commands---": { Close(); break; }
                case "---User Commands---": { Close(); break; }
                case "---Administration Commands---": { Close(); break; }
                default:
                    {
                        if (Nizzc_Collection.Form4.com1.Text.StartsWith("---") && Nizzc_Collection.Form4.com1.Text.EndsWith("---"))
                        {
                            this.textBox1.Enabled = false;
                            label2.ForeColor = Color.Red;
                            button1.Enabled = false;
                            label2.Text = "Invalid Command!";
                        }
                        else
                        {
                            textBox1.Text = Nizzc_Collection.Form4.com1.Text;
                        }
                        break;
                    }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string i = textBox1.Text;
            switch (i.Trim())
            {
                case "": { textBox1.BackColor = Color.Red; break; }
                default:
                    {
                        if ((check == "yes" && textBox1.Text.EndsWith("#")) || (check == "no" && !textBox1.Text.EndsWith("#")))
                        {
                            Nizzc_Collection.Form4.com2.Text = textBox1.Text;
                            Nizzc_Collection.Form4.com1.Text = Nizzc_Collection.Form4.com2.Text;
                            Close();
                        }
                        else
                        {
                            Nizzc_Collection.tags show = new tags();
                            if (check == "yes")
                            {
                                show.Message("Command Error", "You should end your command with '#'", false, "Ok", "");
                                show.ShowDialog();
                            }
                            else if (check == "no") 
                            {
                                show.Message("Command Error", "You should NOT end your command with '#'", false, "Ok", "");
                                show.ShowDialog();
                            }
                        }
                        break;
                    }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
