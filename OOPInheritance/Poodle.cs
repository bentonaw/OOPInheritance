using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance
{
    internal class Poodle : Dog
    {
        public string FavoriteTrick { get; set; }
        public Poodle(string name = "Doug", string color = "brown", string favoriteFood = "chicken", int age = 1, string gender = "unknown", bool isNightAnimal = false, string toy = "bone", string favoriteTrick ="stand") : base(name, color, favoriteFood, age, gender, isNightAnimal, toy)
        {
            FavoriteTrick = favoriteTrick;
        }

        public void doTrick()
        {
            if ( Age >= 9)
            {
                Console.WriteLine($"{Name} might be considered old but can still do their favorite trick \"{FavoriteTrick}\"!");
            }
            else
            {
                Console.WriteLine($"{Name} still hasn't perfected \"{FavoriteTrick}\"..");
            }
        }
        public override void makeSound(string s= "bark!")
        {
            base.makeSound(s);
        }

    }
}
