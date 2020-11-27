using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleToAttribute("LongYatziUnitTests")]
namespace LongYatzi
{

    internal class Dice
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
        public void AddDie(int _eyecount)
        {
            _diceList.Add(new Die(_eyecount));
        }
        public List<Die> ReadDice()
        {
            return _diceList;
        }
        public int ThrowCount()
        {
            return _throw;
        }
        public void ThrowCount(int throwcount)
        {
            _throw = throwcount;
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
        public bool HandContains(int _eyecount)
        {
            foreach(Die die in _diceList)
            {
                if (die.EyeCount == _eyecount)
                    return true;
            }
            return false;
        }
        #region Dice Validators
        internal int Validate(int _eyecount) //validate category from upper section
        {
            int score = -3;
            foreach (Die die in _diceList)
            {
                if (die.EyeCount == _eyecount)
                {
                    score++;
                }
            }
            return score * _eyecount;
        }
        internal int ValidatePair()
        {
            for(int _eyecount = 6;_eyecount>0;_eyecount--)
            {
                int score = 0;
                foreach(Die die in _diceList)
                {
                    if (die.EyeCount == _eyecount) score += _eyecount;
                }
                if (score > _eyecount) return _eyecount * 2;
            }
            return 0;
        }
        internal int ValidateTwoPairs()
        {
            throw new NotImplementedException();
        }
        internal int ValidateThreeSame()
        {
            throw new NotImplementedException();
        }
        internal int ValidateFourSame()
        {
            throw new NotImplementedException();
        }
        internal int ValidateSmallStraight()
        {
            for(int i = 1;i<6;i++)
            {
                if(!HandContains(i))
                {
                    return 0;
                }
            }
            return 15;
        }
        internal int ValidateBigStraight()
        {
            for (int i = 2; i < 7; i++)
            {
                if (!HandContains(i))
                {
                    return 0;
                }
            }
            return 20;
        }
        internal int ValidateFullHouse()
        {
            throw new NotImplementedException();
        }
        internal int ValidateRandom()
        {
            return _diceList[0].EyeCount + _diceList[1].EyeCount + _diceList[2].EyeCount + _diceList[3].EyeCount + _diceList[5].EyeCount;
        }
        internal int ValidateYatzy()
        {
            if(_diceList[0].EyeCount == _diceList[1].EyeCount && _diceList[0].EyeCount == _diceList[2].EyeCount && _diceList[0].EyeCount == _diceList[3].EyeCount && _diceList[0].EyeCount == _diceList[4].EyeCount)
            {
                return 50;
            }
            return 0;
        }
        #endregion
    }
}
