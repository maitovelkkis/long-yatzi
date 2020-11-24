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
        private int _throw = 0;
        List<Die> _diceList = new List<Die>();
        public void ThrowDice()
        {
            Random rand = new Random();
            foreach(Die die in _diceList)
            {
                if(!die.Held)
                {
                    die.EyeCount = rand.Next(1, 7);
                }
            }
        }
        public List<Die> ReadDice()
        {
            return _diceList;
        }
        public int ThrowCount()
        {
            return _throw;
        }
        public void Initialize()
        {
            for(int i = 0; i < _diceAmount;i++)
            {
                _diceList.Add(new Die(1));
            }
        }
    }
}
