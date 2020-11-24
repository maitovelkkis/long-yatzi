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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dice.ThrowDice();
            throw1.Enabled = false;
            die1.Text = dice.ReadDice()[0].ToString();
            die2.Text = dice.ReadDice()[1].ToString();
            die3.Text = dice.ReadDice()[2].ToString();
            die4.Text = dice.ReadDice()[3].ToString();
            die5.Text = dice.ReadDice()[4].ToString();
        }

        private void die1_Click(object sender, EventArgs e)
        {

        }
    }
}
