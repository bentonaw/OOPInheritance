using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance
{
    internal class Sloth : Animal
    {
        public bool IsSleeping { get; set; } = false;
        public Sloth(string name = "Bob", string color = "black and white", string favoriteFood = "broccoli", int age = 100, string gender = "unknown", bool isNightAnimal = false, bool isSleeping = false) : base(name, color, favoriteFood, age, gender, isNightAnimal)
        {
            IsSleeping = isSleeping;
        }

        public override void checkSleep()
        {
            Random random = new Random();
            IsSleeping = random.Next(2) == 0;

            if (IsSleeping)
            {
                Console.WriteLine($"You caught {Name} at a bad time. They are not awake at the moment.");
            }
            else
            {
                Console.WriteLine($"You are lucky! {Name} is currently awake!");
            }
        }


        public override void makeSound(string s = "Squeek!")
        {
            if (IsSleeping)
            {
                Console.WriteLine("...");
            }
            else
            {
                Console.WriteLine(s);
            }
            
        }

    }
}
