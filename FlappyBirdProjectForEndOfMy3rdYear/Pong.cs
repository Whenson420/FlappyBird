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
    public partial class Pong : Form
    {
        /*
        public Pong()
        {
            InitializeComponent();
            this.Height = GameAreaHeight;
            this.Width = GameAreaWidth;
            this.StartPosition = FormStartPosition.CenterScreen;
            game = new Game(this);
            KeyDown += new KeyEventHandler(OnKeyDown);
        }
        Game game;
        const int GameAreaWidth = 1248;
        const int GameAreaHeight = 720;
        private void Pong_Load(object sender, EventArgs e)
        {

        }
        public void OnKeyDown(object sender, KeyEventArgs e)
        {
            int y = game.player2.Location.Y;
            int playerSpeed = 25;
            if (e.KeyCode == Keys.Up && y - 25 >= 0)
            {
                game.player2.Location = new Point(this.Width - (game.player2.Width * 2), y - playerSpeed);
            }
            else if (e.KeyCode == Keys.Down && y + playerSpeed <= (this.Height - game.player2.Height * 2))
            {

                game.player2.Location = new Point(this.Width - (game.player2.Width * 2), y + playerSpeed);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        */
    }
}
