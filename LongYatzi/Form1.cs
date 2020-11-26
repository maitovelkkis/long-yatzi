using System;
using System.Windows.Forms;

namespace LongYatzi
{
    public partial class Form1 : Form
    {
        Dice dice = new Dice();
        ScoreBoard scoreBoard = new ScoreBoard();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dice.Initialize();
            UpdateUI();
        }

        private void button1_Click(object sender, EventArgs e)//new throw
        {
            dice.ResetHeld();
            if (dice.GetThrow() != 0)
            {
                if (hold1.Checked)
                {
                    dice.Hold(0);
                }
                if (hold2.Checked)
                {
                    dice.Hold(1);
                }
                if (hold3.Checked)
                {
                    dice.Hold(2);
                }
                if (hold4.Checked)
                {
                    dice.Hold(3);
                }
                if (hold5.Checked)
                {
                    dice.Hold(4);
                }
            }
            dice.ThrowDice();
            throw1.Enabled = scoreBoard.RoomForThrow(dice.GetThrow());
            UpdateUI();
        }
        private void UpdateUI()
        {
            throwcount.Text = dice.GetThrow().ToString();
            die1.Text = dice.ReadDice()[0].EyeCount.ToString();
            die2.Text = dice.ReadDice()[1].EyeCount.ToString();
            die3.Text = dice.ReadDice()[2].EyeCount.ToString();
            die4.Text = dice.ReadDice()[3].EyeCount.ToString();
            die5.Text = dice.ReadDice()[4].EyeCount.ToString();

            ones1.Enabled = false;
            ones2.Enabled = false;
            ones3.Enabled = false;
            ones4.Enabled = false;
            twos1.Enabled = false;
            twos2.Enabled = false;
            twos3.Enabled = false;
            twos4.Enabled = false;
            ones1.Text = scoreBoard.GetScoreUp(1, 1).ToString();
            ones2.Text = scoreBoard.GetScoreUp(2, 1).ToString();
            ones3.Text = scoreBoard.GetScoreUp(3, 1).ToString();
            ones4.Text = scoreBoard.GetScoreUp(4, 1).ToString();
            twos1.Text = scoreBoard.GetScoreUp(1, 2).ToString();
            twos2.Text = scoreBoard.GetScoreUp(2, 2).ToString();
            twos3.Text = scoreBoard.GetScoreUp(3, 2).ToString();
            twos3.Text = scoreBoard.GetScoreUp(4, 2).ToString();
            die1.Visible = true;
            die2.Visible = true;
            die3.Visible = true;
            die4.Visible = true;
            die5.Visible = true;
            hold1.Visible = true;
            hold2.Visible = true;
            hold3.Visible = true;
            hold4.Visible = true;
            hold5.Visible = true;
            if (dice.GetThrow()==0)
            {
                die1.Visible = false;
                die2.Visible = false;
                die3.Visible = false;
                die4.Visible = false;
                die5.Visible = false;
                hold1.Visible = false;
                hold2.Visible = false;
                hold3.Visible = false;
                hold4.Visible = false;
                hold5.Visible = false;
            }
            else
            if(dice.GetThrow()==1)
            {
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(1, 1).ToString()))
                {
                    ones1.Enabled = true;
                    ones1.Text = dice.ValidateOnes(1).ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(1, 2).ToString()))
                {
                    twos1.Enabled = true;
                    twos1.Text = dice.ValidateTwos(1).ToString();
                }
            }
            if (dice.GetThrow() <= 2 && dice.GetThrow() != 0)
            {
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(2, 1).ToString()))
                {
                    ones2.Enabled = true;
                    ones2.Text = dice.ValidateOnes(2).ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(2, 2).ToString()))
                {
                    twos2.Enabled = true;
                    twos2.Text = dice.ValidateTwos(2).ToString();
                }
            }
            if (dice.GetThrow() <= 3 && dice.GetThrow() != 0)
            {
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(3, 1).ToString()))
                {
                    ones3.Enabled = true;
                    ones3.Text = dice.ValidateOnes(3).ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(3, 2).ToString()))
                {
                    twos3.Enabled = true;
                    twos3.Text = dice.ValidateTwos(3).ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(4, 1).ToString()))
                {
                    ones4.Enabled = true;
                    ones4.Text = dice.ValidateOnes(4).ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(4, 2).ToString()))
                {
                    twos4.Enabled = true;
                    twos4.Text = dice.ValidateTwos(4).ToString();
                }
            }
        }
        private void NewTurn()
        {
            dice.ThrowCount(0);
            dice.ResetHeld();
            hold1.Checked = false;
            hold2.Checked = false;
            hold3.Checked = false;
            hold4.Checked = false;
            hold5.Checked = false;
            throw1.Enabled = true;
            UpdateUI();
        }
        private void ones1_Click(object sender, EventArgs e)
        {
            scoreBoard.StoreScoreUp(1, 1, dice.ValidateOnes(1));
            NewTurn();
        }
        private void ones2_Click(object sender, EventArgs e)
        {
            scoreBoard.StoreScoreUp(2, 1, dice.ValidateOnes(2));
            NewTurn();
        }
        private void ones3_Click(object sender, EventArgs e)
        {
            scoreBoard.StoreScoreUp(3, 1, dice.ValidateOnes(3));
            NewTurn();
        }

        private void ones4_Click(object sender, EventArgs e)
        {
            scoreBoard.StoreScoreUp(4, 1, dice.ValidateOnes(4));
            NewTurn();
        }

        private void twos1_Click(object sender, EventArgs e)
        {
            int _throw = 1;
            scoreBoard.StoreScoreUp(_throw, 2, dice.ValidateTwos(_throw));
            NewTurn();
        }

        private void twos2_Click(object sender, EventArgs e)
        {
            int _throw = 2;
            scoreBoard.StoreScoreUp(_throw, 2, dice.ValidateTwos(_throw));
            NewTurn();
        }

        private void twos3_Click(object sender, EventArgs e)
        {
            int _throw = 3;
            scoreBoard.StoreScoreUp(_throw, 2, dice.ValidateTwos(_throw));
            NewTurn();
        }

        private void twos4_Click(object sender, EventArgs e)
        {
            int _throw = 4;
            scoreBoard.StoreScoreUp(_throw, 2, dice.ValidateTwos(_throw));
            NewTurn();
        }
    }
}
