using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongYatzi
{
    class Die
    {
        public bool Held = false;
        public int EyeCount;

        public Die(int EyeCount)
        {
            this.EyeCount = EyeCount;
        }
    }
}
