namespace duckhunt
{
    partial class FormScoreBoard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFinalScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBest = new System.Windows.Forms.Label();
            this.lblSubmitNameUseless = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.btnSubmitScore = new System.Windows.Forms.Button();
            this.spamTimer = new System.Windows.Forms.Timer(this.components);
            this.lblN01Useless = new System.Windows.Forms.Label();
            this.lblN02Useless = new System.Windows.Forms.Label();
            this.lblN03Useless = new System.Windows.Forms.Label();
            this.lblN04Useless = new System.Windows.Forms.Label();
            this.lblN05Useless = new System.Windows.Forms.Label();
            this.lbl01Name = new System.Windows.Forms.Label();
            this.lbl02Name = new System.Windows.Forms.Label();
            this.lbl03Name = new System.Windows.Forms.Label();
            this.lbl04Name = new System.Windows.Forms.Label();
            this.lbl05Name = new System.Windows.Forms.Label();
            this.lbl01Score = new System.Windows.Forms.Label();
            this.lbl02Score = new System.Windows.Forms.Label();
            this.lbl03Score = new System.Windows.Forms.Label();
            this.lbl04Score = new System.Windows.Forms.Label();
            this.lbl05Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 48F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "GAME OVER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 24F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(57)))));
            this.label2.Location = new System.Drawing.Point(181, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "SCORE: ";
            // 
            // lblFinalScore
            // 
            this.lblFinalScore.AutoSize = true;
            this.lblFinalScore.Font = new System.Drawing.Font("Showcard Gothic", 24F);
            this.lblFinalScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(57)))));
            this.lblFinalScore.Location = new System.Drawing.Point(311, 138);
            this.lblFinalScore.Name = "lblFinalScore";
            this.lblFinalScore.Size = new System.Drawing.Size(36, 40);
            this.lblFinalScore.TabIndex = 2;
            this.lblFinalScore.Text = "0";
            this.lblFinalScore.Click += new System.EventHandler(this.lblFinalScore_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 24F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(57)))));
            this.label3.Location = new System.Drawing.Point(423, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "BEST: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblBest
            // 
            this.lblBest.AutoSize = true;
            this.lblBest.Font = new System.Drawing.Font("Showcard Gothic", 24F);
            this.lblBest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(57)))));
            this.lblBest.Location = new System.Drawing.Point(539, 138);
            this.lblBest.Name = "lblBest";
            this.lblBest.Size = new System.Drawing.Size(36, 40);
            this.lblBest.TabIndex = 4;
            this.lblBest.Text = "0";
            // 
            // lblSubmitNameUseless
            // 
            this.lblSubmitNameUseless.AutoSize = true;
            this.lblSubmitNameUseless.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.lblSubmitNameUseless.ForeColor = System.Drawing.Color.White;
            this.lblSubmitNameUseless.Location = new System.Drawing.Point(244, 197);
            this.lblSubmitNameUseless.Name = "lblSubmitNameUseless";
            this.lblSubmitNameUseless.Size = new System.Drawing.Size(59, 20);
            this.lblSubmitNameUseless.TabIndex = 5;
            this.lblSubmitNameUseless.Text = "Name:";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPlayerName.Location = new System.Drawing.Point(307, 195);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(117, 26);
            this.txtPlayerName.TabIndex = 6;
            // 
            // btnSubmitScore
            // 
            this.btnSubmitScore.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.btnSubmitScore.ForeColor = System.Drawing.Color.Black;
            this.btnSubmitScore.Location = new System.Drawing.Point(430, 191);
            this.btnSubmitScore.Name = "btnSubmitScore";
            this.btnSubmitScore.Size = new System.Drawing.Size(134, 33);
            this.btnSubmitScore.TabIndex = 7;
            this.btnSubmitScore.Text = "Submit Score";
            this.btnSubmitScore.UseVisualStyleBackColor = true;
            this.btnSubmitScore.Click += new System.EventHandler(this.btnSubmitScore_Click);
            // 
            // spamTimer
            // 
            this.spamTimer.Interval = 10000;
            this.spamTimer.Tick += new System.EventHandler(this.spamTimer_Tick);
            // 
            // lblN01Useless
            // 
            this.lblN01Useless.AutoSize = true;
            this.lblN01Useless.Font = new System.Drawing.Font("Showcard Gothic", 18F);
            this.lblN01Useless.ForeColor = System.Drawing.Color.White;
            this.lblN01Useless.Location = new System.Drawing.Point(183, 249);
            this.lblN01Useless.Name = "lblN01Useless";
            this.lblN01Useless.Size = new System.Drawing.Size(37, 30);
            this.lblN01Useless.TabIndex = 8;
            this.lblN01Useless.Text = "01";
            // 
            // lblN02Useless
            // 
            this.lblN02Useless.AutoSize = true;
            this.lblN02Useless.Font = new System.Drawing.Font("Showcard Gothic", 18F);
            this.lblN02Useless.ForeColor = System.Drawing.Color.White;
            this.lblN02Useless.Location = new System.Drawing.Point(183, 287);
            this.lblN02Useless.Name = "lblN02Useless";
            this.lblN02Useless.Size = new System.Drawing.Size(38, 30);
            this.lblN02Useless.TabIndex = 9;
            this.lblN02Useless.Text = "02";
            this.lblN02Useless.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblN03Useless
            // 
            this.lblN03Useless.AutoSize = true;
            this.lblN03Useless.Font = new System.Drawing.Font("Showcard Gothic", 18F);
            this.lblN03Useless.ForeColor = System.Drawing.Color.White;
            this.lblN03Useless.Location = new System.Drawing.Point(183, 325);
            this.lblN03Useless.Name = "lblN03Useless";
            this.lblN03Useless.Size = new System.Drawing.Size(39, 30);
            this.lblN03Useless.TabIndex = 10;
            this.lblN03Useless.Text = "03";
            // 
            // lblN04Useless
            // 
            this.lblN04Useless.AutoSize = true;
            this.lblN04Useless.Font = new System.Drawing.Font("Showcard Gothic", 18F);
            this.lblN04Useless.ForeColor = System.Drawing.Color.White;
            this.lblN04Useless.Location = new System.Drawing.Point(183, 363);
            this.lblN04Useless.Name = "lblN04Useless";
            this.lblN04Useless.Size = new System.Drawing.Size(41, 30);
            this.lblN04Useless.TabIndex = 11;
            this.lblN04Useless.Text = "04";
            // 
            // lblN05Useless
            // 
            this.lblN05Useless.AutoSize = true;
            this.lblN05Useless.Font = new System.Drawing.Font("Showcard Gothic", 18F);
            this.lblN05Useless.ForeColor = System.Drawing.Color.White;
            this.lblN05Useless.Location = new System.Drawing.Point(183, 401);
            this.lblN05Useless.Name = "lblN05Useless";
            this.lblN05Useless.Size = new System.Drawing.Size(39, 30);
            this.lblN05Useless.TabIndex = 12;
            this.lblN05Useless.Text = "05";
            // 
            // lbl01Name
            // 
            this.lbl01Name.AutoSize = true;
            this.lbl01Name.Font = new System.Drawing.Font("Showcard Gothic", 18F);
            this.lbl01Name.ForeColor = System.Drawing.Color.White;
            this.lbl01Name.Location = new System.Drawing.Point(226, 249);
            this.lbl01Name.Name = "lbl01Name";
            this.lbl01Name.Size = new System.Drawing.Size(90, 30);
            this.lbl01Name.TabIndex = 13;
            this.lbl01Name.Text = "blank";
            // 
            // lbl02Name
            // 
            this.lbl02Name.AutoSize = true;
            this.lbl02Name.Font = new System.Drawing.Font("Showcard Gothic", 18F);
            this.lbl02Name.ForeColor = System.Drawing.Color.White;
            this.lbl02Name.Location = new System.Drawing.Point(224, 287);
            this.lbl02Name.Name = "lbl02Name";
            this.lbl02Name.Size = new System.Drawing.Size(90, 30);
            this.lbl02Name.TabIndex = 14;
            this.lbl02Name.Text = "blank";
            // 
            // lbl03Name
            // 
            this.lbl03Name.AutoSize = true;
            this.lbl03Name.Font = new System.Drawing.Font("Showcard Gothic", 18F);
            this.lbl03Name.ForeColor = System.Drawing.Color.White;
            this.lbl03Name.Location = new System.Drawing.Point(224, 325);
            this.lbl03Name.Name = "lbl03Name";
            this.lbl03Name.Size = new System.Drawing.Size(90, 30);
            this.lbl03Name.TabIndex = 15;
            this.lbl03Name.Text = "blank";
            // 
            // lbl04Name
            // 
            this.lbl04Name.AutoSize = true;
            this.lbl04Name.Font = new System.Drawing.Font("Showcard Gothic", 18F);
            this.lbl04Name.ForeColor = System.Drawing.Color.White;
            this.lbl04Name.Location = new System.Drawing.Point(226, 363);
            this.lbl04Name.Name = "lbl04Name";
            this.lbl04Name.Size = new System.Drawing.Size(90, 30);
            this.lbl04Name.TabIndex = 16;
            this.lbl04Name.Text = "blank";
            // 
            // lbl05Name
            // 
            this.lbl05Name.AutoSize = true;
            this.lbl05Name.Font = new System.Drawing.Font("Showcard Gothic", 18F);
            this.lbl05Name.ForeColor = System.Drawing.Color.White;
            this.lbl05Name.Location = new System.Drawing.Point(224, 401);
            this.lbl05Name.Name = "lbl05Name";
            this.lbl05Name.Size = new System.Drawing.Size(90, 30);
            this.lbl05Name.TabIndex = 17;
            this.lbl05Name.Text = "blank";
            // 
            // lbl01Score
            // 
            this.lbl01Score.AutoSize = true;
            this.lbl01Score.Font = new System.Drawing.Font("Showcard Gothic", 18F);
            this.lbl01Score.ForeColor = System.Drawing.Color.White;
            this.lbl01Score.Location = new System.Drawing.Point(569, 249);
            this.lbl01Score.Name = "lbl01Score";
            this.lbl01Score.Size = new System.Drawing.Size(90, 30);
            this.lbl01Score.TabIndex = 18;
            this.lbl01Score.Text = "blank";
            // 
            // lbl02Score
            // 
            this.lbl02Score.AutoSize = true;
            this.lbl02Score.Font = new System.Drawing.Font("Showcard Gothic", 18F);
            this.lbl02Score.ForeColor = System.Drawing.Color.White;
            this.lbl02Score.Location = new System.Drawing.Point(569, 287);
            this.lbl02Score.Name = "lbl02Score";
            this.lbl02Score.Size = new System.Drawing.Size(90, 30);
            this.lbl02Score.TabIndex = 19;
            this.lbl02Score.Text = "blank";
            // 
            // lbl03Score
            // 
            this.lbl03Score.AutoSize = true;
            this.lbl03Score.Font = new System.Drawing.Font("Showcard Gothic", 18F);
            this.lbl03Score.ForeColor = System.Drawing.Color.White;
            this.lbl03Score.Location = new System.Drawing.Point(569, 325);
            this.lbl03Score.Name = "lbl03Score";
            this.lbl03Score.Size = new System.Drawing.Size(90, 30);
            this.lbl03Score.TabIndex = 20;
            this.lbl03Score.Text = "blank";
            // 
            // lbl04Score
            // 
            this.lbl04Score.AutoSize = true;
            this.lbl04Score.Font = new System.Drawing.Font("Showcard Gothic", 18F);
            this.lbl04Score.ForeColor = System.Drawing.Color.White;
            this.lbl04Score.Location = new System.Drawing.Point(569, 363);
            this.lbl04Score.Name = "lbl04Score";
            this.lbl04Score.Size = new System.Drawing.Size(90, 30);
            this.lbl04Score.TabIndex = 21;
            this.lbl04Score.Text = "blank";
            // 
            // lbl05Score
            // 
            this.lbl05Score.AutoSize = true;
            this.lbl05Score.Font = new System.Drawing.Font("Showcard Gothic", 18F);
            this.lbl05Score.ForeColor = System.Drawing.Color.White;
            this.lbl05Score.Location = new System.Drawing.Point(569, 401);
            this.lbl05Score.Name = "lbl05Score";
            this.lbl05Score.Size = new System.Drawing.Size(90, 30);
            this.lbl05Score.TabIndex = 22;
            this.lbl05Score.Text = "blank";
            // 
            // FormScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.lbl05Score);
            this.Controls.Add(this.lbl04Score);
            this.Controls.Add(this.lbl03Score);
            this.Controls.Add(this.lbl02Score);
            this.Controls.Add(this.lbl01Score);
            this.Controls.Add(this.lbl05Name);
            this.Controls.Add(this.lbl04Name);
            this.Controls.Add(this.lbl03Name);
            this.Controls.Add(this.lbl02Name);
            this.Controls.Add(this.lbl01Name);
            this.Controls.Add(this.lblN05Useless);
            this.Controls.Add(this.lblN04Useless);
            this.Controls.Add(this.lblN03Useless);
            this.Controls.Add(this.lblN02Useless);
            this.Controls.Add(this.lblN01Useless);
            this.Controls.Add(this.btnSubmitScore);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblSubmitNameUseless);
            this.Controls.Add(this.lblBest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFinalScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(800, 700);
            this.MinimumSize = new System.Drawing.Size(800, 700);
            this.Name = "FormScoreBoard";
            this.Text = "Score board";
            this.Load += new System.EventHandler(this.lblFinalScore_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFinalScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBest;
        private System.Windows.Forms.Label lblSubmitNameUseless;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button btnSubmitScore;
        private System.Windows.Forms.Timer spamTimer;
        private System.Windows.Forms.Label lblN01Useless;
        private System.Windows.Forms.Label lblN02Useless;
        private System.Windows.Forms.Label lblN03Useless;
        private System.Windows.Forms.Label lblN04Useless;
        private System.Windows.Forms.Label lblN05Useless;
        private System.Windows.Forms.Label lbl01Name;
        private System.Windows.Forms.Label lbl02Name;
        private System.Windows.Forms.Label lbl03Name;
        private System.Windows.Forms.Label lbl04Name;
        private System.Windows.Forms.Label lbl05Name;
        private System.Windows.Forms.Label lbl01Score;
        private System.Windows.Forms.Label lbl02Score;
        private System.Windows.Forms.Label lbl03Score;
        private System.Windows.Forms.Label lbl04Score;
        private System.Windows.Forms.Label lbl05Score;
    }
}