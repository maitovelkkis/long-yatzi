using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongYatzi
{
    public class Die
    {
        public bool Held = false;
        internal int EyeCount;

        public Die(int EyeCount)
        {
            this.EyeCount = EyeCount;
        }
        public int GetEyeCount()
        {
            return this.EyeCount;
        }
    }
}
