using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LillerXxX
{
    internal class Game
    {
        /*
        public Timer gameTime;
        // int gameTimeInterval=1;
        public Player player;
        public Player player2;
        //  public AI ai;
        public Ball ball;
        public Form form;
        public GameController controller;

        public KeyEventHandler KeyDown { get; private set; }

        public Game(Form form)
        {
            this.form = form;
            controller = new GameController(form);
            gameTime = new Timer();
            gameTime.Enabled = true;
            gameTime.Interval = 1;
            gameTime.Tick += new EventHandler(OnGameTimeTick);

            Movable.mainForm = form;
            player = new Player();
            player.Size = new Size(20, 50);
            player.Location = new Point(player.Width / 2, form.Height / 2 - player.Height / 2);
            player.BackColor = Color.Aquamarine;

            player2 = new Player();
            player2.Size = new Size(20, 50);
            player2.Location = new Point(form.Width - (player2.Width * 2), form.Height / 2 - player2.Height / 2);
            player2.BackColor = Color.Aquamarine;

            /*
            ai = new AI();
            ai.AiSpeed = 3;
            ai.Size = new Size(20, 50);
            ai.Location = new Point(ClientSize.Width-(ai.Width+ai.Width / 2), ClientSize.Height / 2 - ai.Height / 2);
            ai.BackColor = Color.Blue;
            
            ball = new Ball(3, 3);
            ball.Size = new Size(20, 20);
            ball.BackColor = Color.Red;
            ball.Location = new Point(form.Width / 2 - ball.Width / 2, form.Height / 2 - ball.Height / 2);
        }

        void OnGameTimeTick(object sender, EventArgs e)
        {
            ball.Location = new Point(ball.Location.X + ball.ballSpeedX, ball.Location.Y + ball.ballSpeedY);
            controller.CollisionGameArea(ball);
            player.move();
            controller.PaddleCollision(player, player2, ball);
            // ai.AiMove(ball);

        }*/
    }
}
