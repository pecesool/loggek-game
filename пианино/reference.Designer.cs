namespace пианино
{
    partial class reference
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reference));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutTheProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giveFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTheProgramToolStripMenuItem,
            this.giveFeedbackToolStripMenuItem,
            this.webBrowserToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // aboutTheProgramToolStripMenuItem
            // 
            this.aboutTheProgramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersManualToolStripMenuItem});
            this.aboutTheProgramToolStripMenuItem.Name = "aboutTheProgramToolStripMenuItem";
            this.aboutTheProgramToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.aboutTheProgramToolStripMenuItem.Text = "About the program";
            // 
            // usersManualToolStripMenuItem
            // 
            this.usersManualToolStripMenuItem.Name = "usersManualToolStripMenuItem";
            this.usersManualToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.usersManualToolStripMenuItem.Text = "user\'s manual";
            this.usersManualToolStripMenuItem.Click += new System.EventHandler(this.usersManualToolStripMenuItem_Click);
            // 
            // giveFeedbackToolStripMenuItem
            // 
            this.giveFeedbackToolStripMenuItem.Name = "giveFeedbackToolStripMenuItem";
            this.giveFeedbackToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.giveFeedbackToolStripMenuItem.Text = "give feedback";
            this.giveFeedbackToolStripMenuItem.Click += new System.EventHandler(this.giveFeedbackToolStripMenuItem_Click);
            // 
            // webBrowserToolStripMenuItem
            // 
            this.webBrowserToolStripMenuItem.Name = "webBrowserToolStripMenuItem";
            this.webBrowserToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.webBrowserToolStripMenuItem.Text = "Web browser";
            this.webBrowserToolStripMenuItem.Click += new System.EventHandler(this.webBrowserToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::пианино.Properties.Resources.orig;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(808, 458);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // reference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "reference";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reference";
            this.Activated += new System.EventHandler(this.reference_Activated);
            this.Load += new System.EventHandler(this.reference_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem aboutTheProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giveFeedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersManualToolStripMenuItem;
    }
}