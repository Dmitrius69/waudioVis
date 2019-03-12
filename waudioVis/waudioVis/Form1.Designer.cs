namespace waudioVis
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wavechart1 = new Accord.Controls.Wavechart();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.waveViewer1 = new NAudio.Gui.WaveViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.histogramView1 = new Accord.Controls.HistogramView();
            this.duratLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fnamelabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.statToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1118, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPenToolStripMenuItem,
            this.toolStripMenuItem1,
            this.testToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // oPenToolStripMenuItem
            // 
            this.oPenToolStripMenuItem.Name = "oPenToolStripMenuItem";
            this.oPenToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.oPenToolStripMenuItem.Text = "Open";
            this.oPenToolStripMenuItem.Click += new System.EventHandler(this.oPenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 6);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // statToolStripMenuItem
            // 
            this.statToolStripMenuItem.Name = "statToolStripMenuItem";
            this.statToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.statToolStripMenuItem.Text = "Stat";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wavechart1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.waveViewer1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(9, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(534, 700);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // wavechart1
            // 
            this.wavechart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wavechart1.Location = new System.Drawing.Point(0, 368);
            this.wavechart1.Name = "wavechart1";
            this.wavechart1.RangeX = ((Accord.DoubleRange)(resources.GetObject("wavechart1.RangeX")));
            this.wavechart1.RangeY = ((Accord.DoubleRange)(resources.GetObject("wavechart1.RangeY")));
            this.wavechart1.SimpleMode = false;
            this.wavechart1.Size = new System.Drawing.Size(706, 254);
            this.wavechart1.TabIndex = 5;
            this.wavechart1.Text = "wavechart1";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(168, 645);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 39);
            this.button3.TabIndex = 4;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(86, 645);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Pause";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(5, 645);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // waveViewer1
            // 
            this.waveViewer1.BackColor = System.Drawing.Color.SteelBlue;
            this.waveViewer1.ForeColor = System.Drawing.SystemColors.Info;
            this.waveViewer1.Location = new System.Drawing.Point(0, 63);
            this.waveViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.waveViewer1.Name = "waveViewer1";
            this.waveViewer1.SamplesPerPixel = 128;
            this.waveViewer1.Size = new System.Drawing.Size(530, 215);
            this.waveViewer1.StartPosition = ((long)(0));
            this.waveViewer1.TabIndex = 0;
            this.waveViewer1.WaveStream = null;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(548, 34);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(377, 424);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.histogramView1);
            this.panel1.Controls.Add(this.duratLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.fnamelabel);
            this.panel1.Location = new System.Drawing.Point(4, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 402);
            this.panel1.TabIndex = 0;
            // 
            // histogramView1
            // 
            this.histogramView1.BinWidth = null;
            this.histogramView1.DataSource = ((object)(resources.GetObject("histogramView1.DataSource")));
            this.histogramView1.Histogram = ((Accord.Statistics.Visualizations.Histogram)(resources.GetObject("histogramView1.Histogram")));
            this.histogramView1.Location = new System.Drawing.Point(14, 53);
            this.histogramView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.histogramView1.Name = "histogramView1";
            this.histogramView1.NumberOfBins = null;
            this.histogramView1.Size = new System.Drawing.Size(344, 335);
            this.histogramView1.TabIndex = 3;
            // 
            // duratLabel
            // 
            this.duratLabel.AutoSize = true;
            this.duratLabel.Location = new System.Drawing.Point(86, 37);
            this.duratLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.duratLabel.Name = "duratLabel";
            this.duratLabel.Size = new System.Drawing.Size(49, 13);
            this.duratLabel.TabIndex = 2;
            this.duratLabel.Text = "00:00 00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Длительность";
            // 
            // fnamelabel
            // 
            this.fnamelabel.AutoSize = true;
            this.fnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fnamelabel.Location = new System.Drawing.Point(9, 15);
            this.fnamelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fnamelabel.Name = "fnamelabel";
            this.fnamelabel.Size = new System.Drawing.Size(53, 15);
            this.fnamelabel.TabIndex = 0;
            this.fnamelabel.Text = "FName";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 727);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1118, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 749);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private NAudio.Gui.WaveViewer waveViewer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fnamelabel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label duratLabel;
        private System.Windows.Forms.Label label1;
        private Accord.Controls.HistogramView histogramView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Accord.Controls.Wavechart wavechart1;
    }
}

