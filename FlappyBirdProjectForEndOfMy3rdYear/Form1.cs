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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UsernameTB_TextChanged(object sender, EventArgs e)
        {
            if (UsernameTB.Text == string.Empty)
                UsernameL.Visible = true;
            else
                UsernameL.Visible = false;
        }
        private void PasswordTB_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTB.Text == string.Empty)
                PasswordL.Visible = true;
            else
                PasswordL.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UsernameTB.Text == "Flappy" && PasswordTB.Text == "bird")
            {
                Jozsi jozsi = new Jozsi();
                this.Hide();
                jozsi.Closed += (s, args) => this.Show();
                jozsi.Show();
            }
            if (UsernameTB.Text == "Ping" && PasswordTB.Text == "pong")
            {

            }
        }

        private void Velemeny_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Nekem tetszett a rajzolason kivul minden, de meg az sem volt borzalmas. A jovoben is fogok OOP-vel foglalkozni!", ":)", MessageBoxButtons.OK);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
