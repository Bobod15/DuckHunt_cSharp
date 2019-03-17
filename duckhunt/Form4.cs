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
    public partial class Highscore : Form
    {
        public Highscore()
        {
            InitializeComponent();
        }

        private void Highscore_Load(object sender, EventArgs e)
        {
            lblNamePlayer.Text = "";
            lblPlayerScore.Text = "";
            string[] highscore = File.ReadAllLines(@"..\Highscore.txt");
            for(int i=0; i<20; i++)
            {
                /*rtbHighscore.Text += "    " + highscore[i] + " ";
                i++;
                rtbHighscore.SelectAll();
                rtbHighscore.SelectionAlignment = HorizontalAlignment.Right;
                rtbHighscore.Text += highscore[i] + Environment.NewLine;
                rtbHighscore.DeselectAll();*/
                lblNamePlayer.Text += highscore[i] + Environment.NewLine;
                i++;
              //  rtbHighscore.SelectAll();
             //   rtbHighscore.SelectionAlignment = HorizontalAlignment.Right;
                lblPlayerScore.Text += highscore[i] + Environment.NewLine;
                //rtbHighscore.DeselectAll();
            }

        }
    }
}
