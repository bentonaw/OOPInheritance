using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance
{
    abstract class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string FavoriteFood { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public bool IsNightAnimal { get; set; }
        public string Species { get;}


        public Animal(string name = "Bob", string color = "black and white", string favoriteFood = "broccoli", int age =100, string gender = "unknown", bool isNightAnimal = false, string species= "not human")
        {
            Name = name;
            Color = color;
            FavoriteFood = favoriteFood;
            Age = age;
            Gender = gender;
            IsNightAnimal = isNightAnimal;
            Species = species;
        }

        public void doEat()
        {
            Console.WriteLine($"{Name} loves to eat {FavoriteFood}.");
        }

        public virtual void getDescription()
        {
            Console.WriteLine($"The {Color} {GetType().Name} is named {Name} and is {Age} years old {Gender} and enjoys {FavoriteFood}.");
        }

        public virtual void checkSleep()
        {
            DateTime Now = DateTime.Now;
            TimeSpan Morning = new TimeSpan(6, 0, 0);
            TimeSpan Evening = new TimeSpan(18, 0, 0);

            if ((Now.TimeOfDay >= Morning && Now.TimeOfDay < Evening !& IsNightAnimal) || (Now.TimeOfDay < Morning && Now.TimeOfDay >= Evening) && IsNightAnimal) 
            {
                Console.WriteLine($"{Name} is up and about!");
            }
            else if ((Now.TimeOfDay >= Morning && Now.TimeOfDay < Evening) && IsNightAnimal)
            {
                Console.WriteLine($"{Name} is most likely napping at the moment and waiting for the dark to roam");
            }
            else
            {
                Console.WriteLine($"{Name} is fast asleep");
            }
        }

        public abstract void makeSound(string s = "huh");
        
    }
}
