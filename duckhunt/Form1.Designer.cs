namespace duckhunt
{
    partial class Form1
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
            this.lblLab1 = new System.Windows.Forms.Label();
            this.lblGame1d = new System.Windows.Forms.Label();
            this.lblGame2d = new System.Windows.Forms.Label();
            this.lblHighscore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLab1
            // 
            this.lblLab1.AutoSize = true;
            this.lblLab1.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLab1.ForeColor = System.Drawing.Color.Turquoise;
            this.lblLab1.Location = new System.Drawing.Point(285, 9);
            this.lblLab1.Name = "lblLab1";
            this.lblLab1.Size = new System.Drawing.Size(250, 158);
            this.lblLab1.TabIndex = 0;
            this.lblLab1.Text = "DUCK \r\n   HUNT";
            // 
            // lblGame1d
            // 
            this.lblGame1d.AutoSize = true;
            this.lblGame1d.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGame1d.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblGame1d.Location = new System.Drawing.Point(271, 185);
            this.lblGame1d.Name = "lblGame1d";
            this.lblGame1d.Size = new System.Drawing.Size(280, 33);
            this.lblGame1d.TabIndex = 1;
            this.lblGame1d.Text = "GAME A        1 DUCK";
            this.lblGame1d.Click += new System.EventHandler(this.lblGame1d_Click);
            this.lblGame1d.MouseLeave += new System.EventHandler(this.lblGame1d_MouseLeave);
            this.lblGame1d.MouseHover += new System.EventHandler(this.lblGame1d_MouseHover);
            // 
            // lblGame2d
            // 
            this.lblGame2d.AutoSize = true;
            this.lblGame2d.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGame2d.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblGame2d.Location = new System.Drawing.Point(271, 231);
            this.lblGame2d.Name = "lblGame2d";
            this.lblGame2d.Size = new System.Drawing.Size(299, 33);
            this.lblGame2d.TabIndex = 3;
            this.lblGame2d.Text = "GAME B        2 DUCKS";
            this.lblGame2d.Click += new System.EventHandler(this.lblGame2d_Click);
            this.lblGame2d.MouseLeave += new System.EventHandler(this.lblGame2d_MouseLeave);
            this.lblGame2d.MouseHover += new System.EventHandler(this.LblGame2d_MouseHover);
            // 
            // lblHighscore
            // 
            this.lblHighscore.AutoSize = true;
            this.lblHighscore.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighscore.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblHighscore.Location = new System.Drawing.Point(330, 284);
            this.lblHighscore.Name = "lblHighscore";
            this.lblHighscore.Size = new System.Drawing.Size(177, 33);
            this.lblHighscore.TabIndex = 4;
            this.lblHighscore.Text = "HIGHSCORE";
            this.lblHighscore.Click += new System.EventHandler(this.lblHighscore_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(794, 661);
            this.Controls.Add(this.lblHighscore);
            this.Controls.Add(this.lblGame2d);
            this.Controls.Add(this.lblGame1d);
            this.Controls.Add(this.lblLab1);
            this.MaximumSize = new System.Drawing.Size(810, 700);
            this.MinimumSize = new System.Drawing.Size(810, 700);
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLab1;
        private System.Windows.Forms.Label lblGame1d;
        private System.Windows.Forms.Label lblGame2d;
        private System.Windows.Forms.Label lblHighscore;
    }
}

