using System.Collections.Generic;
using System.Linq;

namespace LongYatzi
{
    class ScoreBoard
    {
        int?[,] upperSection = new int?[3, 6]; //x = throw 1-3, y = dice eye count - 1
        int?[,] lowerSection = new int?[3, 9]; //x = throw 1-3, y = category of points
        List<int> forcedColumn = new List<int>();
        /*0 = pairs
         *1 = 2 pairs
         *2 = 3 sames
         *3 = full house
         *4 = small straight
         *5 = big straight
         *6 = full house
         *7 = random
         *8 = yatzy
         */
        public void StoreScoreUp(int _throw,int _eyecount,int _score)
        {
            _eyecount--;
            if (_throw == 4)
            {
                forcedColumn.Add(_score);
            }
            else
            {
                _throw--;
                upperSection[_throw, _eyecount] = _score;
            }
        }
        public int? GetScoreUp(int _throw, int _eyecount)
        {
            if(_throw == 4 && _eyecount > forcedColumn.Count())
            {
                return null;
            }
            _eyecount--;
            if (_throw == 4)
            {
                return forcedColumn[_eyecount];
            }
            else
            {
                _throw--;
                return upperSection[_throw, _eyecount];
            }
        }
        public bool RoomForThrow(int _throw)
        {
            if(_throw==0)
            {
                return true;
            }
            else if(_throw == 1)
            {
                for (int i = 0; i < 6; i++)
                {
                    if(upperSection[1,i]==null)
                    {
                        return true;
                    }
                }
                for (int i = 0; i < 6; i++)
                {
                    if (upperSection[2, i] == null)
                    {
                        return true;
                    }
                }
                if(forcedColumn.Count<15)
                {
                    return true;
                }
            }
            else if (_throw == 2)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (upperSection[2, i] == null)
                    {
                        return true;
                    }
                }
                if (forcedColumn.Count < 15)
                {
                    return true;
                }
            }
            return false;
        }
        public int GetActiveForceCell()
        {
            return forcedColumn.Count();
        }
    }
}
