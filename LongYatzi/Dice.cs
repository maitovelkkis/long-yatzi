using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongYatzi
{
    class Dice
    {
        private int _diceAmount = 6;
        public List<int> ThrowDice()
        {
            List<int> _diceList = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < _diceAmount; i++)
            {
                _diceList.Add(rand.Next(1, 6));
            }
            return _diceList;

        }
    }
}
