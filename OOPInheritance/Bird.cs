using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance
{
    internal class Bird : Animal
    {
        public string BirdSpecies { get; set; }
        public bool Fly { get; set; } = true;

        public Bird(string name = "Bob", string color = "black and white", string favoriteFood = "broccoli", int age = 100, string gender = "unknown", bool isNightAnimal = false, string birdSpecies = "dove") : base(name, color, favoriteFood, age, gender, isNightAnimal)
        {
            BirdSpecies = birdSpecies;
        }

        public bool doFlight()
        {
            if (BirdSpecies != "Penguin")
            {
                return Fly;
            }
            else
            {
                return Fly = false;
            }

        }

        public override void getDescription()
        {
            Console.WriteLine($"The {Color} {GetType().Name} is named {Name} and is {Age} years old {Gender} and enjoys {FavoriteFood}. They are also of the {BirdSpecies} species");
        }

        public override void makeSound(string s ="Chirp chirp")
        {
            Console.WriteLine(s);
        }
    }
}
