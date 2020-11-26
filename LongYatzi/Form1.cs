using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            UpdateScoreBoardButtons();
        }

        private void button1_Click(object sender, EventArgs e)//new throw
        {
            dice.ResetHeld();
            if(dice.GetThrow() == 2)
            {
                hold1.Checked = false;
                hold2.Checked = false;
                hold3.Checked = false;
                hold4.Checked = false;
                hold5.Checked = false;
                throw1.Enabled = false;
            }
            if(hold1.Checked)
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
            dice.ThrowDice();
            die1.Text = dice.ReadDice()[0].EyeCount.ToString();
            die2.Text = dice.ReadDice()[1].EyeCount.ToString();
            die3.Text = dice.ReadDice()[2].EyeCount.ToString();
            die4.Text = dice.ReadDice()[3].EyeCount.ToString();
            die5.Text = dice.ReadDice()[4].EyeCount.ToString();
            UpdateScoreBoardButtons();
        }
        private void UpdateScoreBoardButtons()
        {
            throwcount.Text = dice.GetThrow().ToString();
            ones1.Enabled = false;
            ones2.Enabled = false;
            ones3.Enabled = false;
            ones4.Enabled = false;
            ones1.Text = scoreBoard.GetScoreUp(1, 1).ToString();
            ones2.Text = scoreBoard.GetScoreUp(2, 1).ToString();
            ones3.Text = scoreBoard.GetScoreUp(3, 1).ToString();
            if(dice.GetThrow()==1)
            {
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(1, 1).ToString()))
                {
                    ones1.Enabled = true;
                    ones1.Text = dice.ValidateOnes(1).ToString();
                }
            }
            if (dice.GetThrow() <= 2 && dice.GetThrow() != 0)
            {
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(2, 1).ToString()))
                {
                    ones2.Enabled = true;
                    ones2.Text = dice.ValidateOnes(2).ToString();
                }
            }
            if (dice.GetThrow() <= 3 && dice.GetThrow() != 0)
            {
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(3, 1).ToString()))
                {
                    ones3.Enabled = true;
                    ones3.Text = dice.ValidateOnes(3).ToString();
                }
            }
            if (dice.GetThrow() <= 3 && dice.GetThrow() != 0)
            {
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(4, 1).ToString()))
                {
                    ones4.Enabled = true;
                    ones4.Text = dice.ValidateOnes(4).ToString();
                }
            }
        }
        private void NewTurn()
        {
            dice.ThrowCount(0);
            dice.ResetHeld();
            throw1.Enabled = true;
            UpdateScoreBoardButtons();
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
    }
}
