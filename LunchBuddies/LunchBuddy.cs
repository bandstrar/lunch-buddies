using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class LunchBuddy
    {

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Eat(string food, List<LunchBuddy> companions)
        {
            var randomRestaurant = new Restaurant();

            Console.WriteLine($"{FirstName} {LastName} is at {randomRestaurant.Name} and ordered {food}.");

            foreach (var companion in companions)
            {
                Console.WriteLine(companion.FirstName);
            }
        }

        public void Eat(List<LunchBuddy> companions)
        {
            var randomRestaurant = new Restaurant();

            Console.WriteLine($"{FirstName} {LastName} is at {randomRestaurant.Name}.");

            foreach (var companion in companions)
            {
                Console.WriteLine(companion.FirstName);
            }
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} ate {food} at the office.");
        }

        public void Eat()
        {
            var randomRestaurant = new Restaurant();

            Console.WriteLine($"{FirstName} {LastName} is at {randomRestaurant.Name}.");
            
        }
    }
}
