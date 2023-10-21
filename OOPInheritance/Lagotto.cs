using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance
{
    internal class Lagotto : Dog
    {
        public bool FoundTruffle { get; set; }
        public Lagotto(string name = "Doug", string color = "brown", string favoriteFood = "chicken", int age = 1, string gender = "unknown", bool isNightAnimal = false, string toy = "bone", bool foundtruffle = false) : base(name, color, favoriteFood, age, gender, isNightAnimal, toy)
        {
            FoundTruffle = foundtruffle;
        }

        public void findTruffle()
        {
            Random random = new Random();
            FoundTruffle = random.Next(2) == 0;
            if (FoundTruffle)
            {
                Console.WriteLine($"{Name} has found some truffles! Yay!");
            }
            else
            {
                Console.WriteLine($"No luck. {Name} did not find any truffles this time.");
            }
        }
        public override void makeSound(string s = "woo")
        {
            base.makeSound(s);
        }
    }
}
