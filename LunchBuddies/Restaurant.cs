using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class Restaurant
    {
        public string Name { get; set; }
        private List<string> RestaurantNames = new List<string>
        { "Mas Tacos", "Ginger Thai", "Two Boots", "Tacos Aurora", "Vui's Kitchen", "Graze", "Las Palmas", "Gojo Ethiopian" };

        public Restaurant()
        {
            var rand = new Random();
            int randoRestoIndex = rand.Next(RestaurantNames.Count);

            Name = RestaurantNames[randoRestoIndex];
        }

    }
}
