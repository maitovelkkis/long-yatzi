using System;
using LongYatzi;

namespace Server
{
    class Program
    {
        static void Main()
        {
            Dice dice = new Dice();
            dice.Initialize();
            Console.Clear();
            foreach (Die die in dice.ReadDice()) Console.WriteLine(die.GetEyeCount());
        }
    }
}
