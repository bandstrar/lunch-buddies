using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var lunchBuddy1 = new LunchBuddy("Kaladin", "Stormblessed");

            var lunchBuddiesList = new List<LunchBuddy>
            {
                new LunchBuddy("Adolin", "Kholin"),
                new LunchBuddy("Shallan", "Davar"),
                new LunchBuddy("The", "Lopen"),
                new LunchBuddy("Jasnah", "Kholin"),
                new LunchBuddy("Hoid", "Wit")
            };
            
            lunchBuddy1.Eat("Rock's Stew", lunchBuddiesList);
        }
    }
}
