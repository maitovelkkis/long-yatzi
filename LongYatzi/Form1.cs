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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dice.Initialize();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dice.ResetHeld();
            if(dice.GetThrow() == 3)
            {
                hold1.Checked = false;
                hold2.Checked = false;
                hold3.Checked = false;
                hold4.Checked = false;
                hold5.Checked = false;
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
            throwcount.Text = dice.GetThrow().ToString();
            ones1.Enabled = true;
            ones2.Enabled = true;

            if (dice.GetThrow() > 1)
            {
                ones1.Enabled = false;
            }
            if (dice.GetThrow() > 2)
            {
                ones2.Enabled = false;
            }
            ones1.Text = dice.ValidateOnes(1).ToString();
            ones2.Text = dice.ValidateOnes(2).ToString();
            ones3.Text = dice.ValidateOnes(3).ToString();
        }

    }
}
