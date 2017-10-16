namespace Nizzc_Mobile_Server
{
    partial class HelpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Commands");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Tags");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Customizations");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Connect to network");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Update your hosted bot");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("About");
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Right;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(182, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(617, 350);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.Aqua;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "cwin.htm";
            treeNode1.Text = "Commands";
            treeNode2.Name = "";
            treeNode2.Text = "";
            treeNode3.Name = "tks.htm";
            treeNode3.Text = "Tags";
            treeNode4.Name = "Node7";
            treeNode4.Text = "";
            treeNode5.Name = "czcm.htm";
            treeNode5.Text = "Customizations";
            treeNode6.Name = "Node8";
            treeNode6.Text = "";
            treeNode7.Name = "net.htm";
            treeNode7.Text = "Connect to network";
            treeNode8.Name = "";
            treeNode8.Text = "";
            treeNode9.Name = "netup.htm";
            treeNode9.Text = "Update your hosted bot";
            treeNode10.Name = "";
            treeNode10.Text = "";
            treeNode11.Name = "ntrd.htm";
            treeNode11.Text = "About";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            this.treeView1.ShowLines = false;
            this.treeView1.ShowPlusMinus = false;
            this.treeView1.ShowRootLines = false;
            this.treeView1.Size = new System.Drawing.Size(185, 350);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Honeydew;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(153, 327);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 23);
            this.button4.TabIndex = 34;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 350);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HelpForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HelpForm";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button4;
    }
}