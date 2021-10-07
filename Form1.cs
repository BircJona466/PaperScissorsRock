using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PaperScissorsRock
{
    public partial class PaperScissorsRock : Form
    {
        Random generator = new Random();
        int result;
        int score;
        
        public PaperScissorsRock()
        {
            InitializeComponent();
        }

        private void PaperScissorsRock_Load(object sender, EventArgs e)
        {
            score = 10;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            lblScore.Text = ("You have " + score + " points..");
            numBetting.Maximum = score;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnRock_Click(object sender, EventArgs e)
        { 
            result = generator.Next(0, 3);

            if (result == 1)
            {
                picEnemy.Visible = true;
                picEnemy.BackgroundImage = Properties.Resources.rock;
                lblResult.Text = "Tie!";
                numBetting.Maximum = score;
            }
            else if (result == 2)
            {
                picEnemy.Visible = true;
                picEnemy.BackgroundImage = Properties.Resources.paper;
                lblResult.Text = "You Lose!";
                score = (score - (int)numBetting.Value);
                lblScore.Text = ("You have " + score + " points..");
                numBetting.Maximum = score;
            }
            else
            {
                picEnemy.Visible = true;
                picEnemy.BackgroundImage = Properties.Resources.scissors;
                lblResult.Text = "You Win!";
                score = (score + ((int)numBetting.Value * 2));
                lblScore.Text = ("You have " + score + " points..");
                numBetting.Maximum = score;
            }
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            result = generator.Next(0, 3);

            if (result == 1)
            {
                picEnemy.Visible = true;
                picEnemy.BackgroundImage = Properties.Resources.rock;
                lblResult.Text = "You Win!";
                score = (score + ((int)numBetting.Value * 2));
                lblScore.Text = ("You have " + score + " points..");
                numBetting.Maximum = score;
            }
            else if (result == 2)
            {
                picEnemy.Visible = true;
                picEnemy.BackgroundImage = Properties.Resources.paper;
                lblResult.Text = "Tie!";
                numBetting.Maximum = score;
            }
            else
            {
                picEnemy.Visible = true;
                picEnemy.BackgroundImage = Properties.Resources.scissors;
                lblResult.Text = "You Lose!";
                score = (score - (int)numBetting.Value);
                lblScore.Text = ("You have " + score + " points..");
                numBetting.Maximum = score;
            }
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            result = generator.Next(0, 3);

            if (result == 1)
            {
                picEnemy.Visible = true;
                picEnemy.BackgroundImage = Properties.Resources.rock;
                lblResult.Text = "You Lose!";
                score = (score - (int)numBetting.Value);
                lblScore.Text = ("You have " + score + " points..");
                numBetting.Maximum = score;
            }
            else if (result == 2)
            {
                picEnemy.Visible = true;
                picEnemy.BackgroundImage = Properties.Resources.paper;
                lblResult.Text = "You Win!";
                score = (score + ((int)numBetting.Value * 2));
                lblScore.Text = ("You have " + score + " points..");
                numBetting.Maximum = score;
            }
            else
            {
                picEnemy.Visible = true;
                picEnemy.BackgroundImage = Properties.Resources.scissors;
                lblResult.Text = "Tie!";
                numBetting.Maximum = score;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }

        
        
            
        }
    
