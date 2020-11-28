using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleToAttribute("LongYatziUnitTests")]
namespace LongYatzi
{
    class ScoreBoard
    {
        internal int?[,] upperSection = new int?[3, 6]; //x = throw 1-3, y = dice eye count - 1
        internal int?[,] lowerSection = new int?[3, 9]; //x = throw 1-3, y = category of points
        /*0 = pairs
         *1 = 2 pairs
         *2 = 3 sames
         *3 = four same
         *4 = small straight
         *5 = big straight
         *6 = full house
         *7 = random
         *8 = yatzy
         */
        int?[] bonuses = new int?[4];
        List<int> forcedColumn = new List<int>();
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
        internal void StoreScoreDown(int _throw, int _category, int _score)
        {
            if (_throw == 4)
            {
                forcedColumn.Add(_score);
            }
            else
            {
                _throw--;
                lowerSection[_throw, _category] = _score;
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
        internal int? GetScoreDown(int _throw, int _category)
        {
            if (_throw == 4 && _category+7 > forcedColumn.Count())
            {
                return null;
            }
            if (_throw == 4)
            {
                return forcedColumn[_category+6];
            }
            else
            {
                _throw--;
                return lowerSection[_throw, _category];
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
                if (!UpperSectionFull(1) || !LowerSectionFull(1))
                {
                    return true;
                }
                if (!UpperSectionFull(2) || !LowerSectionFull(2))
                {
                    return true;
                }
                if (!UpperSectionFull(3) || !LowerSectionFull(3))
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
                for (int i = 0; i < 9; i++)
                {
                    if (lowerSection[2, i] == null)
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
        public bool UpperSectionFull(int column)
        {
            if (column == 3)
            {
                if (forcedColumn.Count < 6)//is not full
                {
                    return false;
                }
            }
            else
            {
                for (int i = 0; i < 6; i++)
                {
                    if (upperSection[column, i] == null)
                    {
                        return false;
                    }
                }
            }
            if(UpperSectionTotal(column)>=0)
            {
                bonuses[column] = 50;
            }
            return true;
        }

        private bool LowerSectionFull(int column)
        {
            if (column == 3)
            {
                if (forcedColumn.Count < 15)//is not full
                {
                    return false;
                }
            }
            else
            {
                for (int i = 0; i < 9; i++)
                {
                    if (lowerSection[column, i] == null)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public int? UpperSectionTotal(int column)
        {
            int? total = 0;
            for(int i = 0;i<6;i++)
            {
                if (column == 3)
                {
                    if(forcedColumn.Count>i)
                    total += forcedColumn[i];
                }
                else
                {
                    if(upperSection[column,i]!=null) total += upperSection[column, i];
                }
            }
            return total;
        }
        public int? LowerSectionTotal(int column)
        {
            int? total = 0;
            for (int i = 0; i < 9; i++)
            {
                if (column == 3)
                {
                    if (forcedColumn.Count > i+6)
                        total += forcedColumn[i+6];
                }
                else
                {
                    if (lowerSection[column, i] != null) total += lowerSection[column, i];
                }
            }
            return total;
        }
        public int? Total(int column)
        {
            int? total = 0;
            if (UpperSectionTotal(column) != null) total += UpperSectionTotal(column);
            if (bonuses[column] != null) total += bonuses[column];
            if (LowerSectionTotal(column) != null) total += LowerSectionTotal(column);
            return total;
        }
        public int? Total()
        {
            return Total(0) + Total(1) + Total(2) + Total(3);
        }
        public int? GetBonus(int column)
        {
            return bonuses[column];
        }
    }
}
