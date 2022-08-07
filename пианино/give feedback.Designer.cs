namespace пианино
{
    partial class give_feedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(give_feedback));
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьШрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьЦветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выравниваниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЛевомуКраюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поПравомуКраюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЦентруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(669, 419);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.Thistle;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(13, 47);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(756, 364);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.форматироватьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(785, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.печатьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.файлToolStripMenuItem.Text = "File";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.новыйToolStripMenuItem.Text = "new document";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.новыйToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.открытьToolStripMenuItem.Text = "open file";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.сохранитьToolStripMenuItem.Text = "save as";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.печатьToolStripMenuItem.Text = "print";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.печатьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.выделитьВсеToolStripMenuItem});
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.редактироватьToolStripMenuItem.Text = "Edit";
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.вырезатьToolStripMenuItem.Text = "cut";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.копироватьToolStripMenuItem.Text = "copy";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.вставитьToolStripMenuItem.Text = "paste";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // выделитьВсеToolStripMenuItem
            // 
            this.выделитьВсеToolStripMenuItem.Name = "выделитьВсеToolStripMenuItem";
            this.выделитьВсеToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.выделитьВсеToolStripMenuItem.Text = "select all";
            this.выделитьВсеToolStripMenuItem.Click += new System.EventHandler(this.выделитьВсеToolStripMenuItem_Click);
            // 
            // форматироватьToolStripMenuItem
            // 
            this.форматироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьШрифтToolStripMenuItem,
            this.изменитьЦветToolStripMenuItem,
            this.выравниваниеToolStripMenuItem});
            this.форматироватьToolStripMenuItem.Name = "форматироватьToolStripMenuItem";
            this.форматироватьToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.форматироватьToolStripMenuItem.Text = "format";
            // 
            // изменитьШрифтToolStripMenuItem
            // 
            this.изменитьШрифтToolStripMenuItem.Name = "изменитьШрифтToolStripMenuItem";
            this.изменитьШрифтToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.изменитьШрифтToolStripMenuItem.Text = "change font";
            this.изменитьШрифтToolStripMenuItem.Click += new System.EventHandler(this.изменитьШрифтToolStripMenuItem_Click);
            // 
            // изменитьЦветToolStripMenuItem
            // 
            this.изменитьЦветToolStripMenuItem.Name = "изменитьЦветToolStripMenuItem";
            this.изменитьЦветToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.изменитьЦветToolStripMenuItem.Text = "change color";
            this.изменитьЦветToolStripMenuItem.Click += new System.EventHandler(this.изменитьЦветToolStripMenuItem_Click);
            // 
            // выравниваниеToolStripMenuItem
            // 
            this.выравниваниеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поЛевомуКраюToolStripMenuItem,
            this.поПравомуКраюToolStripMenuItem,
            this.поЦентруToolStripMenuItem});
            this.выравниваниеToolStripMenuItem.Name = "выравниваниеToolStripMenuItem";
            this.выравниваниеToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.выравниваниеToolStripMenuItem.Text = "alignment";
            // 
            // поЛевомуКраюToolStripMenuItem
            // 
            this.поЛевомуКраюToolStripMenuItem.Name = "поЛевомуКраюToolStripMenuItem";
            this.поЛевомуКраюToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.поЛевомуКраюToolStripMenuItem.Text = "to the left";
            this.поЛевомуКраюToolStripMenuItem.Click += new System.EventHandler(this.поЛевомуКраюToolStripMenuItem_Click);
            // 
            // поПравомуКраюToolStripMenuItem
            // 
            this.поПравомуКраюToolStripMenuItem.Name = "поПравомуКраюToolStripMenuItem";
            this.поПравомуКраюToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.поПравомуКраюToolStripMenuItem.Text = "to the right";
            this.поПравомуКраюToolStripMenuItem.Click += new System.EventHandler(this.поПравомуКраюToolStripMenuItem_Click);
            // 
            // поЦентруToolStripMenuItem
            // 
            this.поЦентруToolStripMenuItem.Name = "поЦентруToolStripMenuItem";
            this.поЦентруToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.поЦентруToolStripMenuItem.Text = "in the center";
            this.поЦентруToolStripMenuItem.Click += new System.EventHandler(this.поЦентруToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "\"Rtf files|*.rtf|Txt files|*.txt|Все файлы|*.*\"";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "doc1.txt";
            this.saveFileDialog1.Filter = "\"Rtf files|*.rtf|Txt files|*.txt|Все файлы|*.*\"";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // give_feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::пианино.Properties.Resources.R3YZL5qp_8U;
            this.ClientSize = new System.Drawing.Size(785, 460);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "give_feedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "give_feedback";
            this.Activated += new System.EventHandler(this.give_feedback_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьШрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьЦветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выравниваниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поЛевомуКраюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поПравомуКраюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поЦентруToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}