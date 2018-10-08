namespace VideoSurveilance
{
   partial class VideoSurveilance
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
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imageBox1.Location = new System.Drawing.Point(12, 12);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(442, 380);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Load Video";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(101, 440);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Start Counting";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.FileName = "openFileDialog4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(8, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total Vehicles:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(720, 539);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label5";
            this.label3.Visible = false;
            // 
            // VideoSurveilance
            // 
            this.ClientSize = new System.Drawing.Size(471, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imageBox1);
            this.Name = "VideoSurveilance";
            this.Load += new System.EventHandler(this.VideoSurveilance_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.SplitContainer splitContainer1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.OpenFileDialog openFileDialog1;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem openVideoToolStripMenuItem;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.TreeView treeView1;
      private System.Windows.Forms.SplitContainer splitContainer2;
      private System.Windows.Forms.GroupBox groupBox1;
      private Emgu.CV.UI.ImageBox imageBox2;
      private System.Windows.Forms.Timer timer1;
      private System.Windows.Forms.ToolStripMenuItem loadSnapshotToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem saveSnapshotToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem saveAsXMLToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
      private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem analyzeToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem technicalSupportToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
      private System.Windows.Forms.Button btnPlay1;
      private System.Windows.Forms.Button btnLoadVid2;
      private System.Windows.Forms.Button btnLoadVid3;
      private Emgu.CV.UI.ImageBox imageBox3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.RichTextBox richTextBox1;
      private System.Windows.Forms.OpenFileDialog openFileDialog2;
      private System.Windows.Forms.Button button2;
      private Emgu.CV.UI.ImageBox imageBox1;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button4;
      private System.Windows.Forms.Timer timer2;
      private System.Windows.Forms.Timer timer3;
      private System.Windows.Forms.OpenFileDialog openFileDialog3;
      private System.Windows.Forms.OpenFileDialog openFileDialog4;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label3;
   }
}