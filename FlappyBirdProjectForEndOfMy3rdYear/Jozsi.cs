using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LillerXxX
{
    public partial class Jozsi : Form
    {
        public Jozsi()
        {
            InitializeComponent();
        }
        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;
        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }

        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game over!!!";
            Exit.Visible = true;
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;
            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;
            }
            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                score++;
            }
            if (Bird.Bounds.IntersectsWith(pipeBottom.Bounds) || Bird.Bounds.IntersectsWith(pipeTop.Bounds) || Bird.Bounds.IntersectsWith(ground.Bounds) || Bird.Top < -25)
            {
                endGame();
            }
            if (score > 5)
            {
                pipeSpeed = 15;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
