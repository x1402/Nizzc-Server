namespace Nizzc_Collection
{
    partial class tags
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Code généré par le Concepteur Windows Form
        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.msg = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.yes = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // msg
            // 
            this.msg.BackColor = System.Drawing.Color.Transparent;
            this.msg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.msg.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg.ForeColor = System.Drawing.Color.Maroon;
            this.msg.Location = new System.Drawing.Point(0, 29);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(204, 55);
            this.msg.TabIndex = 1;
            this.msg.Text = "kdiufhsuofhgus";
            this.msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.msg.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // yes
            // 
            this.yes.BackColor = System.Drawing.Color.DeepPink;
            this.yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.yes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.yes.Location = new System.Drawing.Point(86, 87);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(56, 24);
            this.yes.TabIndex = 46;
            this.yes.Text = "Yes";
            this.yes.UseVisualStyleBackColor = false;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // no
            // 
            this.no.BackColor = System.Drawing.Color.LightCoral;
            this.no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.no.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.no.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.no.Location = new System.Drawing.Point(148, 87);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(56, 24);
            this.no.TabIndex = 47;
            this.no.Text = "No";
            this.no.UseVisualStyleBackColor = false;
            this.no.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.DeepPink;
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(204, 29);
            this.title.TabIndex = 48;
            this.title.Text = "Message";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // messageshower
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(204, 114);
            this.Controls.Add(this.title);
            this.Controls.Add(this.no);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.msg);
            this.Font = new System.Drawing.Font("Orbit Antique", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "messageshower";
            this.Opacity = 0.9;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "messageshower";
            this.Load += new System.EventHandler(this.messageshower_Load);
            this.ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button yes;
        private System.Windows.Forms.Button no;
        private System.Windows.Forms.Label title;
    }
}