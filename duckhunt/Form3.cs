using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace duckhunt
{
    public partial class FormScoreBoard : Form
    {
        private int noSpam = 1;


        public FormScoreBoard()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblFinalScore_Click(object sender, EventArgs e)
        {
            
            string[] scoreBoardDef = File.ReadAllLines(@"..\ScoreBoard.txt");
            int strLenghts = scoreBoardDef.Length / 2;
            string finalScore = FormGameA.playerScore.ToString();
            string[] sbNames = new string[strLenghts];
            string[] sbNames2 = new string[strLenghts];
            int[] sbScore = new int[strLenghts];
            int[] sbScore2 = new int[strLenghts];
    

            lblFinalScore.Text = finalScore;

            //sort         

            
            for(int i=0, j=0; i<scoreBoardDef.Length; )
            {
                sbNames[j] = scoreBoardDef[i];
                i++;
                
                sbScore[j] = Int32.Parse(scoreBoardDef[i]);
                j++;
                i++;
               
            }

            int storedID = 0;
            int max = 0;
           // int maxVal = 0;

            for(int i = 0; i < sbScore.Length; i++)
            {
                for(int j = 0; j < sbScore.Length; j++)
                {
                    if(sbScore[j]> max)
                    {
                        storedID = j;
                        max = sbScore[j];
                        
                    }
                }
                
                sbNames2[i] = sbNames[storedID];
                sbScore2[i] = max;
                max = 0;
                sbScore[storedID] = -1;
            }


           lbl01Name.Text = sbNames2[0] ;
           lbl01Score.Text = Convert.ToString(sbScore2[0]);

            lblBest.Text = Convert.ToString(sbScore2[0]);
                                                     
           lbl02Name.Text = sbNames2[1];             
           lbl02Score.Text = Convert.ToString(sbScore2[1]);
                                                     
           lbl03Name.Text = sbNames2[2];             
           lbl03Score.Text = Convert.ToString(sbScore2[2]);
                                                     
           lbl04Name.Text = sbNames2[3];             
           lbl04Score.Text = Convert.ToString(sbScore2[3]);
                                                     
           lbl05Name.Text = sbNames2[4];             
           lbl05Score.Text = Convert.ToString(sbScore2[4]);

            string[] hsNew = new string[40];


            //nomer na horata v Highscore
            for(int i=0, j=0; i<20; )
            {
                hsNew[i] = sbNames2[j];
                i++;
                hsNew[i] = Convert.ToString(sbScore2[j]);
                i++;
                j++;
            }
            System.IO.File.WriteAllLines(@"..\Highscore.txt", hsNew);



        }

        private void btnSubmitScore_Click(object sender, EventArgs e)
        {
            if (noSpam >= 1)
            {
                TextWriter tsw = new StreamWriter(@"..\ScoreBoard.txt", true);
                tsw.WriteLine(txtPlayerName.Text);
                tsw.WriteLine(FormGameA.playerScore);
                tsw.Close();
                noSpam--;
                spamTimer.Start();

                //update func
                lblFinalScore_Click(sender, e);          
            }
        }

        private void spamTimer_Tick(object sender, EventArgs e)
        {
            noSpam = 1;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
