namespace duckhunt
{
    partial class Highscore
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
            this.lblHighscore = new System.Windows.Forms.Label();
            this.lblNamePlayer = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHighscore
            // 
            this.lblHighscore.AutoSize = true;
            this.lblHighscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.lblHighscore.ForeColor = System.Drawing.Color.White;
            this.lblHighscore.Location = new System.Drawing.Point(73, 27);
            this.lblHighscore.Name = "lblHighscore";
            this.lblHighscore.Size = new System.Drawing.Size(621, 73);
            this.lblHighscore.TabIndex = 1;
            this.lblHighscore.Text = "*** HIGH SCORE ***";
            // 
            // lblNamePlayer
            // 
            this.lblNamePlayer.AutoSize = true;
            this.lblNamePlayer.BackColor = System.Drawing.Color.Black;
            this.lblNamePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblNamePlayer.ForeColor = System.Drawing.Color.White;
            this.lblNamePlayer.Location = new System.Drawing.Point(182, 132);
            this.lblNamePlayer.Name = "lblNamePlayer";
            this.lblNamePlayer.Size = new System.Drawing.Size(79, 29);
            this.lblNamePlayer.TabIndex = 2;
            this.lblNamePlayer.Text = "label1";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.BackColor = System.Drawing.Color.Black;
            this.lblPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblPlayerScore.ForeColor = System.Drawing.Color.White;
            this.lblPlayerScore.Location = new System.Drawing.Point(501, 132);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(79, 29);
            this.lblPlayerScore.TabIndex = 3;
            this.lblPlayerScore.Text = "label2";
            // 
            // Highscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblNamePlayer);
            this.Controls.Add(this.lblHighscore);
            this.MaximumSize = new System.Drawing.Size(800, 700);
            this.MinimumSize = new System.Drawing.Size(800, 700);
            this.Name = "Highscore";
            this.Text = "Highscore";
            this.Load += new System.EventHandler(this.Highscore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHighscore;
        private System.Windows.Forms.Label lblNamePlayer;
        private System.Windows.Forms.Label lblPlayerScore;
    }
}