using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace duckhunt
{
    public partial class FormGameA : Form
    {
        private bool goingRight = true;
        private bool goingDown = true;
        public static int playerScore=0;
        public int MissCounter = 3;

        public FormGameA()
        {
            InitializeComponent();
        }

        public int GetPlayerScore()
        {
            return playerScore;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible=false;

            //Score
            playerScore++;
            string psString = playerScore.ToString();
            lblPlayerScore.Text = psString;

            //timer
            tmrNewDuck.Start();           
        }

        private void pictureBox1_Timer(object sender, EventArgs e)
        {
            Random randL = new Random();
            Random randT = new Random();
            int stepT = randL.Next(15, 35);
            int stepL = randT.Next(15, 35);

            if (pictureBox1.Top > 520)
            {
                goingDown = false;
            }

            if (pictureBox1.Left > 620)
            {
                goingRight = false;
            }

            if(pictureBox1.Top < 50)
            {
                goingDown = true;
            }

            if(pictureBox1.Left < 0)
            {
                goingRight = true;
            }

            // --

            if (goingDown)
            {
                pictureBox1.Top += stepT;
            }
            else
            {
                pictureBox1.Top -= stepT;
            }

            if (goingRight)
            {
                pictureBox1.Left += stepL;
            }
            else
            {
                pictureBox1.Left -= stepL;
            }


        }

        private void tmrNewDuck_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            // reset timer code here
            tmrNewDuck.Stop();
        }

        private void FormGameA_Load(object sender, EventArgs e)
        {

            MissCounter--;
            if (MissCounter > 0)
            {
                string mcString = MissCounter.ToString();
                lblMisses.Text = mcString;
            }
            else
            {
               /* FormScoreBoard ChildForm = FormScoreBoard();
                ChildForm.MdiParent = this;
                ChildForm.Show();*/

                this.Hide();
                var form3 = new FormScoreBoard();
                form3.Closed += (s, args) => this.Close();
                form3.Show();
            }

            // if misses = 0 open game over form
        }

        private void lblPlayerScore_Click(object sender, EventArgs e)
        {

        }
    }
}
