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
    public partial class Form1 : Form
    {
        public static int howMany = 1;


        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(0, 0, 0); 
        }

        private void lblGame1d_Click(object sender, EventArgs e)
        {
            /*   FormGameA fgA = new FormGameA();
               fgA.ShowDialog();*/
            this.Hide();
            var form2 = new FormGameA();
            form2.Closed += (s, args) => this.Close();
            form2.Show();

        }

        private void lblGame1d_MouseHover(object sender, EventArgs e)

        {
            lblGame1d.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void lblGame1d_MouseLeave(object sender, EventArgs e)

        {
            lblGame1d.ForeColor = Color.FromArgb(184, 134, 11);
        }


        //lblform2
        private void lblGame2d_Click(object sender, EventArgs e)
        {
            howMany = 2;
            this.Hide();
            var form2 = new FormGameA();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
            
        }

        private void LblGame2d_MouseHover(object sender, EventArgs e)

        {
            lblGame2d.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void lblGame2d_MouseLeave(object sender, EventArgs e)

        {
            lblGame2d.ForeColor = Color.FromArgb(184, 134, 11);
        }



        public int HowManyDucks()
        {
            return howMany;
        }

        private void lblHighscore_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Highscore();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
