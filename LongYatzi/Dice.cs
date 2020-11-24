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
            if(_throw == 3)
            {
                ResetHeld();
                _throw = 0;
            }
            foreach(Die die in _diceList)
            {
                if(!die.Held)
                {
                    die.EyeCount = rand.Next(1, 7);
                }
            }
            _throw++;
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
        public void Hold(int die)
        {
            _diceList[die].Held = true;
        }
        public void ResetHeld()
        {
            foreach(Die die in _diceList)
            {
                die.Held = false;
            }
        }
        public int GetThrow()
        {
            return _throw;
        }
        public int ValidateOnes(int i)//4 for force
        {
            int score = -3;
            if(i == 1)
            {
                if(GetThrow() == 1)
                {
                    foreach(Die die in _diceList)
                    {
                        if(die.EyeCount == 1)
                        {
                            score++;
                        }
                    }
                    return score;
                }
            }
            else if (i == 2)
            {
                if (GetThrow() <= 2)
                {
                    foreach (Die die in _diceList)
                    {
                        if (die.EyeCount == 1)
                        {
                            score++;
                        }
                    }
                    return score;
                }
            }
            else if (i == 3)
            {
                foreach (Die die in _diceList)
                {
                    if (die.EyeCount == 1)
                    {
                        score++;
                    }
                }
                return score;
            }
            return 0;
        }
    }
}
