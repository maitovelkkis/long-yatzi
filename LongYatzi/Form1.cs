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
            uppertotal1.Visible = false;
            uppertotal2.Visible = false;
            uppertotal3.Visible = false;
            uppertotal4.Visible = false;
            bonus1.Visible = false;
            bonus2.Visible = false;
            bonus3.Visible = false;
            bonus4.Visible = false;
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
            threes1.Enabled = false;
            threes2.Enabled = false;
            threes3.Enabled = false;
            threes4.Enabled = false;
            fours1.Enabled = false;
            fours2.Enabled = false;
            fours3.Enabled = false;
            fours4.Enabled = false;
            fives1.Enabled = false;
            fives2.Enabled = false;
            fives3.Enabled = false;
            fives4.Enabled = false;
            sixes1.Enabled = false;
            sixes2.Enabled = false;
            sixes3.Enabled = false;
            sixes4.Enabled = false;
            pair1.Enabled = false;
            pair2.Enabled = false;
            pair3.Enabled = false;
            pair4.Enabled = false;
            twoPairs1.Enabled = false;
            twoPairs2.Enabled = false;
            twoPairs3.Enabled = false;
            twoPairs4.Enabled = false;
            threeSame1.Enabled = false;
            threeSame2.Enabled = false;
            threeSame3.Enabled = false;
            threeSame4.Enabled = false;
            fourSame1.Enabled = false;
            fourSame2.Enabled = false;
            fourSame3.Enabled = false;
            fourSame4.Enabled = false;
            smallStraight1.Enabled = false;
            smallStraight2.Enabled = false;
            smallStraight3.Enabled = false;
            smallStraight4.Enabled = false;
            bigStraight1.Enabled = false;
            bigStraight2.Enabled = false;
            bigStraight3.Enabled = false;
            bigStraight4.Enabled = false;
            fullHouse1.Enabled = false;
            fullHouse2.Enabled = false;
            fullHouse3.Enabled = false;
            fullHouse4.Enabled = false;
            random1.Enabled = false;
            random2.Enabled = false;
            random3.Enabled = false;
            random4.Enabled = false;
            yatzy1.Enabled = false;
            yatzy2.Enabled = false;
            yatzy3.Enabled = false;
            yatzy4.Enabled = false;



            if (scoreBoard.UpperSectionFull(0))
            {
                uppertotal1.Visible = true;
                uppertotal1.Text = scoreBoard.UpperSectionTotal(0).ToString();
                bonus1.Visible = true;
                bonus1.Text = scoreBoard.GetBonus(0).ToString();
            }
            if (scoreBoard.UpperSectionFull(1))
            {
                uppertotal2.Visible = true;
                uppertotal2.Text = scoreBoard.UpperSectionTotal(1).ToString();
                bonus2.Visible = true;
                bonus2.Text = scoreBoard.GetBonus(1).ToString();
            }
            if (scoreBoard.UpperSectionFull(2))
            {
                uppertotal3.Visible = true;
                uppertotal3.Text = scoreBoard.UpperSectionTotal(2).ToString();
                bonus3.Visible = true;
                bonus3.Text = scoreBoard.GetBonus(2).ToString();
            }
            if (scoreBoard.UpperSectionFull(3))
            {
                uppertotal4.Visible = true;
                uppertotal4.Text = scoreBoard.UpperSectionTotal(3).ToString();
                bonus4.Visible = true;
                bonus4.Text = scoreBoard.GetBonus(3).ToString();
            }
            ones1.Text = scoreBoard.GetScoreUp(1, 1).ToString();
            ones2.Text = scoreBoard.GetScoreUp(2, 1).ToString();
            ones3.Text = scoreBoard.GetScoreUp(3, 1).ToString();
            ones4.Text = scoreBoard.GetScoreUp(4, 1).ToString();
            twos1.Text = scoreBoard.GetScoreUp(1, 2).ToString();
            twos2.Text = scoreBoard.GetScoreUp(2, 2).ToString();
            twos3.Text = scoreBoard.GetScoreUp(3, 2).ToString();
            twos3.Text = scoreBoard.GetScoreUp(4, 2).ToString();
            threes1.Text = scoreBoard.GetScoreUp(1, 3).ToString();
            threes2.Text = scoreBoard.GetScoreUp(2, 3).ToString();
            threes3.Text = scoreBoard.GetScoreUp(3, 3).ToString();
            threes4.Text = scoreBoard.GetScoreUp(4, 3).ToString();
            fours1.Text = scoreBoard.GetScoreUp(1, 4).ToString();
            fours2.Text = scoreBoard.GetScoreUp(2, 4).ToString();
            fours3.Text = scoreBoard.GetScoreUp(3, 4).ToString();
            fours4.Text = scoreBoard.GetScoreUp(4, 4).ToString();
            fives1.Text = scoreBoard.GetScoreUp(1, 5).ToString();
            fives2.Text = scoreBoard.GetScoreUp(2, 5).ToString();
            fives3.Text = scoreBoard.GetScoreUp(3, 5).ToString();
            fives4.Text = scoreBoard.GetScoreUp(4, 5).ToString();
            sixes1.Text = scoreBoard.GetScoreUp(1, 6).ToString();
            sixes2.Text = scoreBoard.GetScoreUp(2, 6).ToString();
            sixes3.Text = scoreBoard.GetScoreUp(3, 6).ToString();
            sixes4.Text = scoreBoard.GetScoreUp(4, 6).ToString();
            pair1.Text = scoreBoard.GetScoreDown(1, 0).ToString();
            pair2.Text = scoreBoard.GetScoreDown(2, 0).ToString();
            pair3.Text = scoreBoard.GetScoreDown(3, 0).ToString();
            pair4.Text = scoreBoard.GetScoreDown(4, 0).ToString();
            twoPairs1.Text = scoreBoard.GetScoreDown(1, 1).ToString();
            twoPairs2.Text = scoreBoard.GetScoreDown(2, 1).ToString();
            twoPairs3.Text = scoreBoard.GetScoreDown(3, 1).ToString();
            twoPairs4.Text = scoreBoard.GetScoreDown(4, 1).ToString();
            threeSame1.Text = scoreBoard.GetScoreDown(1, 2).ToString();
            threeSame2.Text = scoreBoard.GetScoreDown(2, 2).ToString();
            threeSame3.Text = scoreBoard.GetScoreDown(3, 2).ToString();
            threeSame4.Text = scoreBoard.GetScoreDown(4, 2).ToString();
            fourSame1.Text = scoreBoard.GetScoreDown(1, 3).ToString();
            fourSame2.Text = scoreBoard.GetScoreDown(2, 3).ToString();
            fourSame3.Text = scoreBoard.GetScoreDown(3, 3).ToString();
            fourSame4.Text = scoreBoard.GetScoreDown(4, 3).ToString();
            smallStraight1.Text = scoreBoard.GetScoreDown(1, 4).ToString();
            smallStraight2.Text = scoreBoard.GetScoreDown(2, 4).ToString();
            smallStraight3.Text = scoreBoard.GetScoreDown(3, 4).ToString();
            smallStraight4.Text = scoreBoard.GetScoreDown(4, 4).ToString();
            bigStraight1.Text = scoreBoard.GetScoreDown(1, 5).ToString();
            bigStraight2.Text = scoreBoard.GetScoreDown(2, 5).ToString();
            bigStraight3.Text = scoreBoard.GetScoreDown(3, 5).ToString();
            bigStraight4.Text = scoreBoard.GetScoreDown(4, 5).ToString();
            fullHouse1.Text = scoreBoard.GetScoreDown(1, 6).ToString();
            fullHouse2.Text = scoreBoard.GetScoreDown(2, 6).ToString();
            fullHouse3.Text = scoreBoard.GetScoreDown(3, 6).ToString();
            fullHouse4.Text = scoreBoard.GetScoreDown(4, 6).ToString();
            random1.Text = scoreBoard.GetScoreDown(1, 7).ToString();
            random2.Text = scoreBoard.GetScoreDown(2, 7).ToString();
            random3.Text = scoreBoard.GetScoreDown(3, 7).ToString();
            random4.Text = scoreBoard.GetScoreDown(4, 7).ToString();
            yatzy1.Text = scoreBoard.GetScoreDown(1,8).ToString();
            yatzy2.Text = scoreBoard.GetScoreDown(2, 8).ToString();
            yatzy3.Text = scoreBoard.GetScoreDown(3, 8).ToString();
            yatzy4.Text = scoreBoard.GetScoreDown(4, 8).ToString();
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
                    ones1.Text = dice.Validate(1).ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(1, 2).ToString()))
                {
                    twos1.Enabled = true;
                    twos1.Text = dice.Validate(2).ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(1, 3).ToString()))
                {
                    threes1.Enabled = true;
                    threes1.Text = dice.Validate(3).ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(1, 4).ToString()))
                {
                    fours1.Enabled = true;
                    fours1.Text = dice.Validate(4).ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(1, 5).ToString()))
                {
                    fives1.Enabled = true;
                    fives1.Text = dice.Validate(5).ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(1, 6).ToString()))
                {
                    sixes1.Enabled = true;
                    sixes1.Text = dice.Validate(6).ToString();
                }
                if(string.IsNullOrEmpty(scoreBoard.GetScoreDown(1,0).ToString()))
                {
                    pair1.Enabled = true;
                    pair1.Text = dice.ValidatePair().ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreDown(1, 1).ToString()))
                {
                    twoPairs1.Enabled = true;
                    twoPairs1.Text = dice.ValidateTwoPairs().ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreDown(1, 2).ToString()))
                {
                    threeSame1.Enabled = true;
                    threeSame1.Text = dice.ValidateThreeSame().ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreDown(1,3).ToString()))
                {
                    fourSame1.Enabled = true;
                    fourSame1.Text = dice.ValidateFourSame().ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreDown(1, 4).ToString()))
                {
                    smallStraight1.Enabled = true;
                    smallStraight1.Text = dice.ValidateSmallStraight().ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreDown(1, 5).ToString()))
                {
                    bigStraight1.Enabled = true;
                    bigStraight1.Text = dice.ValidateBigStraight().ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreDown(1, 6).ToString()))
                {
                    fullHouse1.Enabled = true;
                    fullHouse1.Text = dice.ValidateFullHouse().ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreDown(1, 7).ToString()))
                {
                    random1.Enabled = true;
                    random1.Text = dice.ValidateRandom().ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreDown(1, 8).ToString()))
                {
                    yatzy1.Enabled = true;
                    yatzy1.Text = dice.ValidateYatzy().ToString();
                }
            }
            if (dice.GetThrow() <= 2 && dice.GetThrow() != 0)
            {
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(2, 1).ToString()))
                {
                    ones2.Enabled = true;
                    ones2.Text = dice.Validate(1).ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(2, 2).ToString()))
                {
                    twos2.Enabled = true;
                    twos2.Text = dice.Validate(2).ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(2, 3).ToString()))
                {
                    threes2.Enabled = true;
                    threes2.Text = dice.Validate(3).ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(2, 4).ToString()))
                {
                    fours2.Enabled = true;
                    fours2.Text = dice.Validate(4).ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(2, 5).ToString()))
                {
                    fives2.Enabled = true;
                    fives2.Text = dice.Validate(5).ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(2, 6).ToString()))
                {
                    sixes2.Enabled = true;
                    sixes2.Text = dice.Validate(6).ToString();
                }
            }
            if (dice.GetThrow() <= 3 && dice.GetThrow() != 0)
            {
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(3, 1).ToString()))
                {
                    ones3.Enabled = true;
                    ones3.Text = dice.Validate(1).ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(3, 2).ToString()))
                {
                    twos3.Enabled = true;
                    twos3.Text = dice.Validate(2).ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(3, 3).ToString()))
                {
                    threes3.Enabled = true;
                    threes3.Text = dice.Validate(3).ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(3, 4).ToString()))
                {
                    fours3.Enabled = true;
                    fours3.Text = dice.Validate(4).ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(3, 5).ToString()))
                {
                    fives3.Enabled = true;
                    fives3.Text = dice.Validate(5).ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(3, 6).ToString()))
                {
                    sixes3.Enabled = true;
                    sixes3.Text = dice.Validate(6).ToString();
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(4, 1).ToString()))
                {
                    if (scoreBoard.GetActiveForceCell() == 0)
                    {
                        ones4.Enabled = true;
                        ones4.Text = dice.Validate(1).ToString();
                    }
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(4, 2).ToString()))
                {
                    if (scoreBoard.GetActiveForceCell() == 1)
                    {
                        twos4.Enabled = true;
                        twos4.Text = dice.Validate(2).ToString();
                    }
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(4, 3).ToString()))
                {
                    if (scoreBoard.GetActiveForceCell() == 2)
                    {
                        threes4.Enabled = true;
                        threes4.Text = dice.Validate(3).ToString();
                    }
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(4, 4).ToString()))
                {
                    if (scoreBoard.GetActiveForceCell() == 3)
                    {
                        fours4.Enabled = true;
                        fours4.Text = dice.Validate(4).ToString();
                    }
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(4, 5).ToString()))
                {
                    if (scoreBoard.GetActiveForceCell() == 4)
                    {
                        fives4.Enabled = true;
                        fives4.Text = dice.Validate(5).ToString();
                    }
                }
                if (string.IsNullOrEmpty(scoreBoard.GetScoreUp(4, 6).ToString()))
                {
                    if (scoreBoard.GetActiveForceCell() == 5)
                    {
                        sixes4.Enabled = true;
                        sixes4.Text = dice.Validate(6).ToString();
                    }
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
            int _throw = 1;
            int _eyecount = 1;
            scoreBoard.StoreScoreUp(_throw, 1, dice.Validate(_eyecount));
            NewTurn();
        }
        private void ones2_Click(object sender, EventArgs e)
        {
            int _throw = 2;
            int _eyecount = 1;
            scoreBoard.StoreScoreUp(_throw, 1, dice.Validate(_eyecount));
            NewTurn();
        }
        private void ones3_Click(object sender, EventArgs e)
        {
            int _throw = 3;
            int _eyecount = 1;
            scoreBoard.StoreScoreUp(_throw, 1, dice.Validate(_eyecount));
            NewTurn();
        }

        private void ones4_Click(object sender, EventArgs e)
        {
            int _throw = 4;
            int _eyecount = 1;
            scoreBoard.StoreScoreUp(_throw, 1, dice.Validate(_eyecount));
            NewTurn();
        }

        private void twos1_Click(object sender, EventArgs e)
        {
            int _throw = 1;
            int _eyecount = 2;
            scoreBoard.StoreScoreUp(_throw, 2, dice.Validate(_eyecount));
            NewTurn();
        }

        private void twos2_Click(object sender, EventArgs e)
        {
            int _throw = 2;
            int _eyecount = 2;
            scoreBoard.StoreScoreUp(_throw, 2, dice.Validate(_eyecount));
            NewTurn();
        }

        private void twos3_Click(object sender, EventArgs e)
        {
            int _throw = 3;
            int _eyecount = 2;
            scoreBoard.StoreScoreUp(_throw, 2, dice.Validate(_eyecount));
            NewTurn();
        }

        private void twos4_Click(object sender, EventArgs e)
        {
            int _throw = 4;
            int _eyecount = 2;
            scoreBoard.StoreScoreUp(_throw, 2, dice.Validate(_eyecount));
            NewTurn();
        }

        private void threes1_Click(object sender, EventArgs e)
        {
            int _throw = 1;
            int _eyecount = 3;
            scoreBoard.StoreScoreUp(_throw, _eyecount, dice.Validate(_eyecount));
            NewTurn();
        }

        private void threes2_Click(object sender, EventArgs e)
        {
            int _throw = 2;
            int _eyecount = 3;
            scoreBoard.StoreScoreUp(_throw, _eyecount, dice.Validate(_eyecount));
            NewTurn();
        }

        private void threes3_Click(object sender, EventArgs e)
        {
            int _throw = 3;
            int _eyecount = 3;
            scoreBoard.StoreScoreUp(_throw, _eyecount, dice.Validate(_eyecount));
            NewTurn();
        }

        private void threes4_Click(object sender, EventArgs e)
        {
            int _throw = 4;
            int _eyecount = 3;
            scoreBoard.StoreScoreUp(_throw, _eyecount, dice.Validate(_eyecount));
            NewTurn();
        }

        private void fours1_Click(object sender, EventArgs e)
        {
            int _throw = 1;
            int _eyecount = 4;
            scoreBoard.StoreScoreUp(_throw, _eyecount, dice.Validate(_eyecount));
            NewTurn();
        }

        private void fours2_Click(object sender, EventArgs e)
        {
            int _throw = 2;
            int _eyecount = 4;
            scoreBoard.StoreScoreUp(_throw, _eyecount, dice.Validate(_eyecount));
            NewTurn();
        }

        private void fours3_Click(object sender, EventArgs e)
        {
            int _throw = 3;
            int _eyecount = 4;
            scoreBoard.StoreScoreUp(_throw, _eyecount, dice.Validate(_eyecount));
            NewTurn();
        }

        private void fours4_Click(object sender, EventArgs e)
        {
            int _throw = 4;
            int _eyecount = 4;
            scoreBoard.StoreScoreUp(_throw, _eyecount, dice.Validate(_eyecount));
            NewTurn();
        }

        private void fives1_Click(object sender, EventArgs e)
        {
            int _throw = 1;
            int _eyecount = 5;
            scoreBoard.StoreScoreUp(_throw, _eyecount, dice.Validate(_eyecount));
            NewTurn();
        }

        private void fives2_Click(object sender, EventArgs e)
        {
            int _throw = 2;
            int _eyecount = 5;
            scoreBoard.StoreScoreUp(_throw, _eyecount, dice.Validate(_eyecount));
            NewTurn();
        }

        private void fives3_Click(object sender, EventArgs e)
        {
            int _throw = 3;
            int _eyecount = 5;
            scoreBoard.StoreScoreUp(_throw, _eyecount, dice.Validate(_eyecount));
            NewTurn();
        }

        private void fives4_Click(object sender, EventArgs e)
        {
            int _throw = 4;
            int _eyecount = 5;
            scoreBoard.StoreScoreUp(_throw, _eyecount, dice.Validate(_eyecount));
            NewTurn();
        }

        private void sixes1_Click(object sender, EventArgs e)
        {
            int _throw = 1;
            int _eyecount = 6;
            scoreBoard.StoreScoreUp(_throw, _eyecount, dice.Validate(_eyecount));
            NewTurn();
        }

        private void sixes2_Click(object sender, EventArgs e)
        {
            int _throw = 2;
            int _eyecount = 6;
            scoreBoard.StoreScoreUp(_throw, _eyecount, dice.Validate(_eyecount));
            NewTurn();
        }

        private void sixes3_Click(object sender, EventArgs e)
        {
            int _throw = 3;
            int _eyecount = 6;
            scoreBoard.StoreScoreUp(_throw, _eyecount, dice.Validate(_eyecount));
            NewTurn();
        }

        private void sixes4_Click(object sender, EventArgs e)
        {
            int _throw = 4;
            int _eyecount = 6;
            scoreBoard.StoreScoreUp(_throw, _eyecount, dice.Validate(_eyecount));
            NewTurn();
        }

        private void pair1_Click(object sender, EventArgs e)
        {
            int _throw = 1;
            int _category = 0;
            scoreBoard.StoreScoreDown(_throw, _category, dice.ValidatePair());
            NewTurn();
        }

        private void pair2_Click(object sender, EventArgs e)
        {

        }

        private void pair3_Click(object sender, EventArgs e)
        {

        }

        private void pair4_Click(object sender, EventArgs e)
        {

        }

        private void twoPairs1_Click(object sender, EventArgs e)
        {

        }

        private void twoPairs2_Click(object sender, EventArgs e)
        {

        }

        private void twoPairs3_Click(object sender, EventArgs e)
        {

        }

        private void twoPairs4_Click(object sender, EventArgs e)
        {

        }

        private void threeSame1_Click(object sender, EventArgs e)
        {

        }

        private void threeSame2_Click(object sender, EventArgs e)
        {

        }

        private void threeSame3_Click(object sender, EventArgs e)
        {

        }

        private void threeSame4_Click(object sender, EventArgs e)
        {

        }

        private void fourSame1_Click(object sender, EventArgs e)
        {

        }

        private void fourSame2_Click(object sender, EventArgs e)
        {

        }

        private void fourSame3_Click(object sender, EventArgs e)
        {

        }

        private void fourSame4_Click(object sender, EventArgs e)
        {

        }

        private void smallStraight1_Click(object sender, EventArgs e)
        {

        }

        private void smallStraight2_Click(object sender, EventArgs e)
        {

        }

        private void smallStraight3_Click(object sender, EventArgs e)
        {

        }

        private void smallStraight4_Click(object sender, EventArgs e)
        {

        }

        private void bigStraight1_Click(object sender, EventArgs e)
        {

        }

        private void bigStraight2_Click(object sender, EventArgs e)
        {

        }

        private void bigStraight3_Click(object sender, EventArgs e)
        {

        }

        private void bigStraight4_Click(object sender, EventArgs e)
        {

        }

        private void fullHouse1_Click(object sender, EventArgs e)
        {

        }

        private void fullHouse2_Click(object sender, EventArgs e)
        {

        }

        private void fullHouse3_Click(object sender, EventArgs e)
        {

        }

        private void fullHouse4_Click(object sender, EventArgs e)
        {

        }

        private void random1_Click(object sender, EventArgs e)
        {

        }

        private void random2_Click(object sender, EventArgs e)
        {

        }

        private void random3_Click(object sender, EventArgs e)
        {

        }

        private void random4_Click(object sender, EventArgs e)
        {

        }

        private void yatzy1_Click(object sender, EventArgs e)
        {

        }

        private void yatzy2_Click(object sender, EventArgs e)
        {

        }

        private void yatzy3_Click(object sender, EventArgs e)
        {

        }

        private void yatzy4_Click(object sender, EventArgs e)
        {

        }
    }
}
