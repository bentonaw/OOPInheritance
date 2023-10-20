using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance
{
    internal class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string FavoriteFood { get; set; }
        public int Age {  get; set; }
        public bool NightAnimal { get; set; }

        public Animal(string name, string color, string favoritefood, int age, bool nightanimal)
        {
            Name = name;
            Color = color;
            FavoriteFood = favoritefood;
            Age = age;
            NightAnimal = nightanimal;
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} loves to eat {FavoriteFood}");
        }

        public void Sleep()
        {
            DateTime Now = DateTime.Now;
            TimeSpan Morning = new TimeSpan(6, 0, 0);
            TimeSpan Evening = new TimeSpan(18, 0, 0);

            if ((Now.TimeOfDay >= Morning && Now.TimeOfDay < Evening) || (Now.TimeOfDay >= Morning && Now.TimeOfDay < Evening)! & NightAnimal) 
            {
                Console.WriteLine($"{Name} is up and about!");
            }
            else if ((Now.TimeOfDay >= Morning && Now.TimeOfDay < Evening) && NightAnimal)
            {
                Console.WriteLine($"{Name} is most likely napping at the moment and waiting for the dark to roam");
            }
                
        }

        public void makeSound()
        {

        }
    }
}
