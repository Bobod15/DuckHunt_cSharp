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
        private bool duckOneGoingRight = true;
        private bool duckOneGoingDown = true;
        private bool duckTwoGoingRight = false;
        private bool duckTwoGoingDown = false;
        public static int playerScore=0;
        public int MissCounter = 3;
        private int minStep = 15;
        private int maxStep = 35;


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

            //diff
            minStep++;
            maxStep++;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;

            //Score
            playerScore++;
            string psString = playerScore.ToString();
            lblPlayerScore.Text = psString;

            //timer
            tmrSecondDuck.Start();

            //diff
            minStep++;
            maxStep++;
        }

        private void pictureBox1_Timer(object sender, EventArgs e)
        {
            Random dOneRandT = new Random();
            Random dOneRandL = new Random();
            Random dTwoRandT = new Random();
            Random dTwoRandL = new Random();
            int dOneStepT = dOneRandT.Next(minStep, maxStep);
            int dOneStepL = dOneRandL.Next(minStep, maxStep);
            int dTwoStepT = dTwoRandT.Next(minStep, maxStep);
            int dTwoStepL = dTwoRandL.Next(minStep, maxStep);
            
            // collision

            if (Form1.howMany == 2 && pictureBox1.Visible==true && pictureBox2.Visible==true)
            {
                
                if (pictureBox1.Right >= pictureBox2.Left && pictureBox1.Right <= pictureBox2.Left + 160)
                {
                  //  label1.Text = Convert.ToString(pictureBox1.Top) + " " + Convert.ToString(pictureBox2.Top);

                    if (pictureBox1.Top >= pictureBox2.Bottom && pictureBox1.Bottom <= pictureBox2.Top ||
                        pictureBox1.Top <= pictureBox2.Bottom && pictureBox1.Bottom >= pictureBox2.Top)
                    {
                        duckOneGoingRight = false;
                        duckTwoGoingRight = true;
                        label1.Text = "collide 1";
                    }
                }

                if (pictureBox2.Right >= pictureBox1.Left && pictureBox2.Right <= pictureBox1.Left + 160)
                {
                 //   label1.Text = Convert.ToString(pictureBox1.Top) + " " + Convert.ToString(pictureBox2.Top);

                    if (pictureBox2.Top >= pictureBox1.Bottom && pictureBox2.Bottom <= pictureBox1.Top ||
                        pictureBox2.Top <= pictureBox1.Bottom && pictureBox2.Bottom >= pictureBox1.Top)
                    {
                        duckOneGoingRight = true;
                        duckTwoGoingRight = false;
                        label1.Text = "collide 2";
                    }
                }



            } // collision bracket

            // deciding where to move duck one


            if (pictureBox1.Top > 520)
            {
                duckOneGoingDown = false;
            }

            if (pictureBox1.Left > 620)
            {
                duckOneGoingRight = false;
            }

            if(pictureBox1.Top < 50)
            {
                duckOneGoingDown = true;
            }

            if(pictureBox1.Left < 0)
            {
                duckOneGoingRight = true;
            }

            // actually moving duck one

            if (duckOneGoingDown)
            {
                pictureBox1.Top += dOneStepT;
            }
            else
            {
                pictureBox1.Top -= dOneStepT;
            }

            if (duckOneGoingRight)
            {
                pictureBox1.Left += dOneStepL;
            }
            else
            {
                pictureBox1.Left -= dOneStepL;
            }

            // deciding where to move duck TWO

            if (Form1.howMany == 2)
            {

                if (pictureBox2.Top > 520)
                {
                    duckTwoGoingDown = false;
                }

                if (pictureBox2.Left > 620)
                {
                    duckTwoGoingRight = false;
                }

                if (pictureBox2.Top < 50)
                {
                    duckTwoGoingDown = true;
                }

                if (pictureBox2.Left < 0)
                {
                    duckTwoGoingRight = true;
                }

                // actually moving duck TWO

                if (duckTwoGoingDown)
                {
                    pictureBox2.Top += dTwoStepT;
                }
                else
                {
                    pictureBox2.Top -= dTwoStepT;
                }

                if (duckTwoGoingRight)
                {
                    pictureBox2.Left += dTwoStepL;
                }
                else
                {
                    pictureBox2.Left -= dTwoStepL;
                }
            }
        }

        private void tmrNewDuck_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            // reset timer code here
            tmrNewDuck.Stop();
        }

        private void tmrSecondDuck_Tick(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            tmrSecondDuck.Stop();
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

        private void FormGameA_Load_1(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            if (Form1.howMany == 2)
            {
                pictureBox2.Visible = true;
            }

        }
    }
}
