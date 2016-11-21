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
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.intervalNumericUpDown)).BeginInit();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.slideShowDirTextBox);
      this.groupBox2.Controls.Add(this.browseButton);
      this.groupBox2.Location = new System.Drawing.Point(5, 3);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(268, 89);
      this.groupBox2.TabIndex = 3;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Slideshow Settings";
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
      this.startButton.Location = new System.Drawing.Point(12, 98);
      this.startButton.Name = "startButton";
      this.startButton.Size = new System.Drawing.Size(90, 23);
      this.startButton.TabIndex = 4;
      this.startButton.Text = "Start Slideshow";
      this.startButton.UseVisualStyleBackColor = true;
      this.startButton.Click += new System.EventHandler(this.startButton_Click);
      // 
      // slideShowListView
      // 
      this.slideShowListView.Location = new System.Drawing.Point(10, 18);
      this.slideShowListView.Name = "slideShowListView";
      this.slideShowListView.Size = new System.Drawing.Size(363, 189);
      this.slideShowListView.TabIndex = 5;
      this.slideShowListView.UseCompatibleStateImageBehavior = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(7, 2);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(103, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "Running Slideshows";
      // 
      // stopButton
      // 
      this.stopButton.Location = new System.Drawing.Point(10, 214);
      this.stopButton.Name = "stopButton";
      this.stopButton.Size = new System.Drawing.Size(100, 23);
      this.stopButton.TabIndex = 7;
      this.stopButton.Text = "Stop Slideshow";
      this.stopButton.UseVisualStyleBackColor = true;
      this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
      // 
      // lockButton
      // 
      this.lockButton.Location = new System.Drawing.Point(119, 214);
      this.lockButton.Name = "lockButton";
      this.lockButton.Size = new System.Drawing.Size(91, 23);
      this.lockButton.TabIndex = 8;
      this.lockButton.Text = "Lock Slideshow";
      this.lockButton.UseVisualStyleBackColor = true;
      this.lockButton.Click += new System.EventHandler(this.lockButton_Click);
      // 
      // unlockButton
      // 
      this.unlockButton.Location = new System.Drawing.Point(217, 214);
      this.unlockButton.Name = "unlockButton";
      this.unlockButton.Size = new System.Drawing.Size(105, 23);
      this.unlockButton.TabIndex = 9;
      this.unlockButton.Text = "Unlock Slideshow";
      this.unlockButton.UseVisualStyleBackColor = true;
      this.unlockButton.Click += new System.EventHandler(this.unlockButton_Click);
      // 
      // intervalNumericUpDown
      // 
      this.intervalNumericUpDown.Location = new System.Drawing.Point(12, 65);
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
      this.label2.Location = new System.Drawing.Point(67, 67);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(93, 13);
      this.label2.TabIndex = 11;
      this.label2.Text = "Interval (Seconds)";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.intervalNumericUpDown);
      this.panel1.Controls.Add(this.startButton);
      this.panel1.Controls.Add(this.groupBox2);
      this.panel1.Location = new System.Drawing.Point(7, 6);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(276, 133);
      this.panel1.TabIndex = 12;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.unlockButton);
      this.panel2.Controls.Add(this.lockButton);
      this.panel2.Controls.Add(this.stopButton);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Controls.Add(this.slideShowListView);
      this.panel2.Location = new System.Drawing.Point(330, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(385, 251);
      this.panel2.TabIndex = 13;
      // 
      // ControllerForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(735, 261);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "ControllerForm";
      this.Text = "Slideshow Controller";
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.intervalNumericUpDown)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion
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
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
  }
}

