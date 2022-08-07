namespace пианино
{
    partial class Top
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Top));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.labirintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oSUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labirintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labirintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loggekDataSet = new пианино.loggekDataSet();
            this.labirintTableAdapter = new пианино.loggekDataSetTableAdapters.labirintTableAdapter();
            this.loggekDataSet1 = new пианино.loggekDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.loginDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loggekDataSet11 = new пианино.loggekDataSet1();
            this.oSUTableAdapter = new пианино.loggekDataSet1TableAdapters.OSUTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.loginDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iQBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loggekDataSet2 = new пианино.loggekDataSet2();
            this.iQTableAdapter = new пианино.loggekDataSet2TableAdapters.IQTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labirintBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loggekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loggekDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loggekDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iQBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loggekDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labirintToolStripMenuItem,
            this.oSUToolStripMenuItem,
            this.iToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // labirintToolStripMenuItem
            // 
            this.labirintToolStripMenuItem.Name = "labirintToolStripMenuItem";
            this.labirintToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.labirintToolStripMenuItem.Text = "Labirint";
            this.labirintToolStripMenuItem.Click += new System.EventHandler(this.labirintToolStripMenuItem_Click);
            // 
            // oSUToolStripMenuItem
            // 
            this.oSUToolStripMenuItem.Name = "oSUToolStripMenuItem";
            this.oSUToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.oSUToolStripMenuItem.Text = "OSU";
            this.oSUToolStripMenuItem.Click += new System.EventHandler(this.oSUToolStripMenuItem_Click);
            // 
            // iToolStripMenuItem
            // 
            this.iToolStripMenuItem.Name = "iToolStripMenuItem";
            this.iToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.iToolStripMenuItem.Text = "IQ test";
            this.iToolStripMenuItem.Click += new System.EventHandler(this.iToolStripMenuItem_Click);
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
            this.pictureBox1.Image = global::пианино.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 456);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginDataGridViewTextBoxColumn,
            this.labirintDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.labirintBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(110, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 315);
            this.dataGridView1.TabIndex = 2;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.loginDataGridViewTextBoxColumn.Frozen = true;
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.loginDataGridViewTextBoxColumn.Width = 188;
            // 
            // labirintDataGridViewTextBoxColumn
            // 
            this.labirintDataGridViewTextBoxColumn.DataPropertyName = "labirint";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labirintDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.labirintDataGridViewTextBoxColumn.Frozen = true;
            this.labirintDataGridViewTextBoxColumn.HeaderText = "Deaths";
            this.labirintDataGridViewTextBoxColumn.Name = "labirintDataGridViewTextBoxColumn";
            this.labirintDataGridViewTextBoxColumn.ReadOnly = true;
            this.labirintDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.labirintDataGridViewTextBoxColumn.Width = 185;
            // 
            // labirintBindingSource
            // 
            this.labirintBindingSource.DataMember = "labirint";
            this.labirintBindingSource.DataSource = this.loggekDataSet;
            // 
            // loggekDataSet
            // 
            this.loggekDataSet.DataSetName = "loggekDataSet";
            this.loggekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labirintTableAdapter
            // 
            this.labirintTableAdapter.ClearBeforeFill = true;
            // 
            // loggekDataSet1
            // 
            this.loggekDataSet1.DataSetName = "loggekDataSet";
            this.loggekDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginDataGridViewTextBoxColumn1,
            this.oSUDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.oSUBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(110, 80);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(555, 315);
            this.dataGridView2.TabIndex = 3;
            // 
            // loginDataGridViewTextBoxColumn1
            // 
            this.loginDataGridViewTextBoxColumn1.DataPropertyName = "login";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.loginDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.loginDataGridViewTextBoxColumn1.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn1.Name = "loginDataGridViewTextBoxColumn1";
            this.loginDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.loginDataGridViewTextBoxColumn1.Width = 188;
            // 
            // oSUDataGridViewTextBoxColumn
            // 
            this.oSUDataGridViewTextBoxColumn.DataPropertyName = "OSU";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.oSUDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.oSUDataGridViewTextBoxColumn.HeaderText = "Time";
            this.oSUDataGridViewTextBoxColumn.Name = "oSUDataGridViewTextBoxColumn";
            this.oSUDataGridViewTextBoxColumn.Width = 185;
            // 
            // oSUBindingSource
            // 
            this.oSUBindingSource.DataMember = "OSU";
            this.oSUBindingSource.DataSource = this.loggekDataSet11;
            // 
            // loggekDataSet11
            // 
            this.loggekDataSet11.DataSetName = "loggekDataSet1";
            this.loggekDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oSUTableAdapter
            // 
            this.oSUTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginDataGridViewTextBoxColumn2,
            this.iQDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.iQBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(110, 80);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(555, 315);
            this.dataGridView3.TabIndex = 4;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // loginDataGridViewTextBoxColumn2
            // 
            this.loginDataGridViewTextBoxColumn2.DataPropertyName = "login";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.loginDataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle5;
            this.loginDataGridViewTextBoxColumn2.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn2.Name = "loginDataGridViewTextBoxColumn2";
            this.loginDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.loginDataGridViewTextBoxColumn2.Width = 188;
            // 
            // iQDataGridViewTextBoxColumn
            // 
            this.iQDataGridViewTextBoxColumn.DataPropertyName = "IQ";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.iQDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.iQDataGridViewTextBoxColumn.HeaderText = "Attempts";
            this.iQDataGridViewTextBoxColumn.Name = "iQDataGridViewTextBoxColumn";
            this.iQDataGridViewTextBoxColumn.Width = 185;
            // 
            // iQBindingSource
            // 
            this.iQBindingSource.DataMember = "IQ";
            this.iQBindingSource.DataSource = this.loggekDataSet2;
            // 
            // loggekDataSet2
            // 
            this.loggekDataSet2.DataSetName = "loggekDataSet2";
            this.loggekDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iQTableAdapter
            // 
            this.iQTableAdapter.ClearBeforeFill = true;
            // 
            // Top
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(775, 456);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Top";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Top";
            this.Load += new System.EventHandler(this.Top_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labirintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loggekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loggekDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loggekDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iQBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loggekDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem labirintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oSUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private loggekDataSet loggekDataSet;
        private System.Windows.Forms.BindingSource labirintBindingSource;
        private loggekDataSetTableAdapters.labirintTableAdapter labirintTableAdapter;
        private loggekDataSet loggekDataSet1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private loggekDataSet1 loggekDataSet11;
        private System.Windows.Forms.BindingSource oSUBindingSource;
        private loggekDataSet1TableAdapters.OSUTableAdapter oSUTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private loggekDataSet2 loggekDataSet2;
        private System.Windows.Forms.BindingSource iQBindingSource;
        private loggekDataSet2TableAdapters.IQTableAdapter iQTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labirintDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iQDataGridViewTextBoxColumn;
    }
}