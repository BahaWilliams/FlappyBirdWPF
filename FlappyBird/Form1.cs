using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class backGround : Form
    {
        int piperspeed = 8;
        int gravity = 10;
        int score = 0;

        public backGround()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            lowerPipe.Left -= piperspeed;
            upperPipe.Left -= piperspeed;
            txtScore.Text = "Score: " + score;

            if(lowerPipe.Left < -150)
            {
                lowerPipe.Left = 650;
                score++;
            }

            if (upperPipe.Left < -150)
            {
                upperPipe.Left = 650;
            }

            if(flappyBird.Bounds.IntersectsWith(lowerPipe.Bounds) || flappyBird.Bounds.IntersectsWith(upperPipe.Bounds)
                || flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -5)
            {
                GameOver();
            }

            if(score > 10)
            {
                piperspeed = 15;
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void GameOver()
        {
            gameTimer.Stop();
            txtScore.Text += " Game Over!!!!!";
        }
    }
}
