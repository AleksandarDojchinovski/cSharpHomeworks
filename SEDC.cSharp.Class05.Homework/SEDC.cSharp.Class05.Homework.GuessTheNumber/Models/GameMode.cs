using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.cSharp.Class05.Homework.GuessTheNumber.Models
{
    public class GameMode
    {
        public int NumberOfGuesses { get; set; }

        public int GenerateEasyRandomNumber()
        {
            Random rand = new Random();
            return rand.Next(0, 100);
        }
        public int GenerateNormalRandomNumber()
        {
            Random rand = new Random();
            return rand.Next(0, 500);
        }
        public int GenerateHardRandomNumber()
        {
            Random rand = new Random();
            return rand.Next(0, 1000);
        }
        


    }
}
