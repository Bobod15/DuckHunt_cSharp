namespace duckhunt
{
    partial class FormGameA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGameA));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.tmrNewDuck = new System.Windows.Forms.Timer(this.components);
            this.lblScoreUseless = new System.Windows.Forms.Label();
            this.lblMissesUseless = new System.Windows.Forms.Label();
            this.lblMisses = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.pictureBox1_Timer);
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Location = new System.Drawing.Point(729, 13);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(13, 13);
            this.lblPlayerScore.TabIndex = 1;
            this.lblPlayerScore.Text = "0";
            this.lblPlayerScore.Click += new System.EventHandler(this.lblPlayerScore_Click);
            // 
            // tmrNewDuck
            // 
            this.tmrNewDuck.Interval = 2000;
            this.tmrNewDuck.Tick += new System.EventHandler(this.tmrNewDuck_Tick);
            // 
            // lblScoreUseless
            // 
            this.lblScoreUseless.AutoSize = true;
            this.lblScoreUseless.Location = new System.Drawing.Point(685, 12);
            this.lblScoreUseless.Name = "lblScoreUseless";
            this.lblScoreUseless.Size = new System.Drawing.Size(38, 13);
            this.lblScoreUseless.TabIndex = 2;
            this.lblScoreUseless.Text = "Score:";
            // 
            // lblMissesUseless
            // 
            this.lblMissesUseless.AutoSize = true;
            this.lblMissesUseless.Location = new System.Drawing.Point(531, 13);
            this.lblMissesUseless.Name = "lblMissesUseless";
            this.lblMissesUseless.Size = new System.Drawing.Size(62, 13);
            this.lblMissesUseless.TabIndex = 3;
            this.lblMissesUseless.Text = "Bullets Left:";
            // 
            // lblMisses
            // 
            this.lblMisses.AutoSize = true;
            this.lblMisses.Location = new System.Drawing.Point(599, 13);
            this.lblMisses.Name = "lblMisses";
            this.lblMisses.Size = new System.Drawing.Size(13, 13);
            this.lblMisses.TabIndex = 4;
            this.lblMisses.Text = "3";
            // 
            // FormGameA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.lblMisses);
            this.Controls.Add(this.lblMissesUseless);
            this.Controls.Add(this.lblScoreUseless);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(800, 700);
            this.MinimumSize = new System.Drawing.Size(800, 700);
            this.Name = "FormGameA";
            this.Text = "Duck Hunt A";
            this.Click += new System.EventHandler(this.FormGameA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Timer tmrNewDuck;
        private System.Windows.Forms.Label lblScoreUseless;
        private System.Windows.Forms.Label lblMissesUseless;
        private System.Windows.Forms.Label lblMisses;
    }
}