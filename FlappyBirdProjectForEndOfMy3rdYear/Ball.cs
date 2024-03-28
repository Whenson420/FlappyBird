using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LillerXxX
{
    internal class Ball : Movable
    {
        public int ballSpeedX { set; get; }
        public int ballSpeedY { set; get; }
        public void resetBall()
        {

            Location = new Point(mainForm.Width / 2 - Width / 2, mainForm.Height / 2 - Height / 2);
        }
        public Ball(int ballSpeedX, int ballSpeedY)
        {
            this.ballSpeedX = ballSpeedX;
            this.ballSpeedY = ballSpeedY;
        }
    }
}
