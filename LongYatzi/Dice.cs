using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongYatzi
{
    class Dice
    {
        private int _diceAmount = 5;
        List<int> _diceList = new List<int>();
        public void ThrowDice()
        {
            _diceList.Clear();
            Random rand = new Random();
            for (int i = 0; i < _diceAmount; i++)
            {
                _diceList.Add(rand.Next(1, 7));
            }
        }
        public List<int> ReadDice()
        {
            return _diceList;
        }
    }
}
