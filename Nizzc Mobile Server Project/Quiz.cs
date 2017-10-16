using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Nizzc_Collection
{
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                thread2.Abort();
            }
            catch { }
            Close();
        }
        System.Threading.Thread thread2;
        private void Quiz_Load(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "You have " + "QuizFile"/*Please specify quiz file or database*/ + " Quiz questions plus extra math only questions";
            }
            catch {
                Load1();
                Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                button2.Enabled = true;
                button1.Enabled = false;
                int countit = 1;
                int paster=0 /*Please specify quiz file or database*/;
                RichTextBox loadit = new RichTextBox();
                System.Threading.Thread thr = new System.Threading.Thread(() =>
                {
                    try
                    {
                        label3.Text = "You have " + "QuizFile"/*Please specify quiz file or database*/ + " Quiz questions plus extra math only questions.";
                        label2.Text = "Waiting to be loaded...";
                        RichTextBox rch = new RichTextBox();
                        rch.Text = "QuizFile"/*Please specify quiz file or database*/;
                        foreach (string l in rch.Lines )
                        {
                            if (l.Contains("+"))
                            {
                                label2.Text = "Question type: Math(Addition)";
                            }
                            if (l.Contains("-"))
                            {
                                label2.Text = "Question type: Math(Subtraction)";
                            }
                            if (l.Contains("÷"))
                            {
                                label2.Text = "Question type: Math(Division)";
                            }
                            if (l.Contains("x"))
                            {
                                label2.Text = "Question type: Math(Multiplication)";
                            }
                            if (l.ToLower().Contains("correct"))
                            {
                                label2.Text = "Question type: English";
                            }
                            if (l.Contains("|"))
                            {
                                string[] sp = l.Split('|');
                                richTextBox1.Text += sp[0].Replace("�", "÷") + "\n";
                            }
                            label1.Text = "Loaded " + countit.ToString() + " Questions of " + paster.ToString().Insert(1, ",") + " Questions";
                            label4.Text = "Loaded Questions: " + countit;
                            progressBar1.Maximum = paster;
                            progressBar1.Value = countit;
                            countit++;
                            System.Threading.Thread.Sleep(10);
                        }
                    }
                    catch { }
                }); thr.IsBackground = true;
                thr.Start();
                thread2 = thr;
            }
            catch
            {
                Nizzc_Collection.tags ShowMessage = new Nizzc_Collection.tags();                
                ShowMessage.Message("Error Occured", "Quiz File is missing! Please reinstall the application", false, "Ok", "");
                ShowMessage.ShowDialog();
                Close();
            }
        }
        void Load1()
        {
            Nizzc_Collection.tags ShowMessage = new Nizzc_Collection.tags();
            ShowMessage.Message("Error Occured", "Quiz File is missing! Please reinstall the application", false , "Ok", "Yes");
            ShowMessage.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (button2.Text.ToLower() == "pause")
                {
                    thread2.Suspend();
                    button2.Text = "Resume";
                }
                else if (button2.Text.ToLower() == "resume")
                {
                    thread2.Resume();
                    button2.Text = "Pause";
                }
            }
            catch { }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (thread2.ThreadState == System.Threading.ThreadState.Running)
                {
                    thread2.Suspend();
                    richTextBox1.Clear();
                    thread2.Resume();
                }
                else
                {
                    richTextBox1.Clear();
                }
            }
            catch { }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionProtected = true;
        }
        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            richTextBox1.DeselectAll();
        }
        private void richTextBox1_Protected(object sender, EventArgs e)
        {
            richTextBox1.DeselectAll();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            richTextBox1.DeselectAll();
        }
    }
    }
