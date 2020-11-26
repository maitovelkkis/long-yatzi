using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongYatzi
{
    class ScoreBoard
    {
        int?[,] upperSection = new int?[4, 6]; //x = throw 1-3 and forced, y = dice eye count - 1
        int[,] lowerSection = new int[4, 9]; //x = throw 1-3 and forced, y = category of points
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
            _throw--;
            upperSection[_throw, _eyecount] = _score;
        }
        public int? GetScoreUp(int _throw,int _eyecount)
        {
            _eyecount--;
            _throw--;
            return upperSection[_throw, _eyecount];
        }
    }
}
