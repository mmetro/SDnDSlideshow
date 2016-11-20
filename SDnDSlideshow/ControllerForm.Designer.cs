namespace SDnDSlideshow
{
    partial class ControllerForm
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
      this.button1 = new System.Windows.Forms.Button();
      this.screenComboBox1 = new System.Windows.Forms.ComboBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.slideShowDirTextBox = new System.Windows.Forms.TextBox();
      this.browseButton = new System.Windows.Forms.Button();
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.startButton = new System.Windows.Forms.Button();
      this.slideShowListView = new System.Windows.Forms.ListView();
      this.label1 = new System.Windows.Forms.Label();
      this.stopButton = new System.Windows.Forms.Button();
      this.lockButton = new System.Windows.Forms.Button();
      this.unlockButton = new System.Windows.Forms.Button();
      this.intervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.intervalNumericUpDown)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(6, 19);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(104, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Show Screen Info";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click_1);
      // 
      // screenComboBox1
      // 
      this.screenComboBox1.FormattingEnabled = true;
      this.screenComboBox1.Location = new System.Drawing.Point(116, 21);
      this.screenComboBox1.Name = "screenComboBox1";
      this.screenComboBox1.Size = new System.Drawing.Size(121, 21);
      this.screenComboBox1.TabIndex = 1;
      this.screenComboBox1.Text = "Select a Screen";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.button1);
      this.groupBox1.Controls.Add(this.screenComboBox1);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(260, 62);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "groupBox1";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.slideShowDirTextBox);
      this.groupBox2.Controls.Add(this.browseButton);
      this.groupBox2.Location = new System.Drawing.Point(12, 78);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(260, 54);
      this.groupBox2.TabIndex = 3;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Choose Directory";
      // 
      // slideShowDirTextBox
      // 
      this.slideShowDirTextBox.Location = new System.Drawing.Point(88, 22);
      this.slideShowDirTextBox.Name = "slideShowDirTextBox";
      this.slideShowDirTextBox.ReadOnly = true;
      this.slideShowDirTextBox.Size = new System.Drawing.Size(166, 20);
      this.slideShowDirTextBox.TabIndex = 1;
      this.slideShowDirTextBox.Text = "Choose a Directory";
      // 
      // browseButton
      // 
      this.browseButton.Location = new System.Drawing.Point(7, 20);
      this.browseButton.Name = "browseButton";
      this.browseButton.Size = new System.Drawing.Size(75, 23);
      this.browseButton.TabIndex = 0;
      this.browseButton.Text = "Browse";
      this.browseButton.UseVisualStyleBackColor = true;
      this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
      // 
      // startButton
      // 
      this.startButton.Location = new System.Drawing.Point(19, 185);
      this.startButton.Name = "startButton";
      this.startButton.Size = new System.Drawing.Size(90, 23);
      this.startButton.TabIndex = 4;
      this.startButton.Text = "Start Slideshow";
      this.startButton.UseVisualStyleBackColor = true;
      this.startButton.Click += new System.EventHandler(this.startButton_Click);
      // 
      // slideShowListView
      // 
      this.slideShowListView.Location = new System.Drawing.Point(340, 18);
      this.slideShowListView.Name = "slideShowListView";
      this.slideShowListView.Size = new System.Drawing.Size(363, 189);
      this.slideShowListView.TabIndex = 5;
      this.slideShowListView.UseCompatibleStateImageBehavior = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(337, 2);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(103, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "Running Slideshows";
      // 
      // stopButton
      // 
      this.stopButton.Location = new System.Drawing.Point(340, 214);
      this.stopButton.Name = "stopButton";
      this.stopButton.Size = new System.Drawing.Size(100, 23);
      this.stopButton.TabIndex = 7;
      this.stopButton.Text = "Stop Slideshow";
      this.stopButton.UseVisualStyleBackColor = true;
      this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
      // 
      // lockButton
      // 
      this.lockButton.Location = new System.Drawing.Point(449, 214);
      this.lockButton.Name = "lockButton";
      this.lockButton.Size = new System.Drawing.Size(91, 23);
      this.lockButton.TabIndex = 8;
      this.lockButton.Text = "Lock Slideshow";
      this.lockButton.UseVisualStyleBackColor = true;
      this.lockButton.Click += new System.EventHandler(this.lockButton_Click);
      // 
      // unlockButton
      // 
      this.unlockButton.Location = new System.Drawing.Point(547, 214);
      this.unlockButton.Name = "unlockButton";
      this.unlockButton.Size = new System.Drawing.Size(105, 23);
      this.unlockButton.TabIndex = 9;
      this.unlockButton.Text = "Unlock Slideshow";
      this.unlockButton.UseVisualStyleBackColor = true;
      this.unlockButton.Click += new System.EventHandler(this.unlockButton_Click);
      // 
      // intervalNumericUpDown
      // 
      this.intervalNumericUpDown.Location = new System.Drawing.Point(19, 152);
      this.intervalNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.intervalNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.intervalNumericUpDown.Name = "intervalNumericUpDown";
      this.intervalNumericUpDown.Size = new System.Drawing.Size(51, 20);
      this.intervalNumericUpDown.TabIndex = 10;
      this.intervalNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(74, 154);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(93, 13);
      this.label2.TabIndex = 11;
      this.label2.Text = "Interval (Seconds)";
      // 
      // ControllerForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(735, 261);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.intervalNumericUpDown);
      this.Controls.Add(this.unlockButton);
      this.Controls.Add(this.lockButton);
      this.Controls.Add(this.stopButton);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.slideShowListView);
      this.Controls.Add(this.startButton);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "ControllerForm";
      this.Text = "Slideshow Controller";
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.intervalNumericUpDown)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox screenComboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox slideShowDirTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ListView slideShowListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button lockButton;
        private System.Windows.Forms.Button unlockButton;
    private System.Windows.Forms.NumericUpDown intervalNumericUpDown;
    private System.Windows.Forms.Label label2;
  }
}

