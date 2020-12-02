using System;
using System.Data;
using System.Data.SqlClient;
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



            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DESKTOP-IIR9L26\SQLEXPRESS01;Initial Catalog=LongYatzi;User ID=mahtiantti;Password=123;Trusted_Connection=true";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            Console.WriteLine("Connection Open  !");
            cnn.Close();
        }
    }
}
