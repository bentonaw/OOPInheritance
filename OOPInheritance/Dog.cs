using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance
{
    internal class Dog : Animal
    {
        public string Toy { get; set; } = "ChewingBone";
        public Dog(string name ="Doug", string color = "brown", string favoriteFood = "chicken", int age = 1, string gender = "unknown", bool isNightAnimal = false, string toy = "bone") : base(name, color, favoriteFood, age, gender, isNightAnimal)
        {
            Toy = toy;
        }
        public void goFetch()
        {
            if (Gender == "Male")
            {
                Console.WriteLine($"There he goes!\r\nNow bring back the {Toy}!\r\nGood boy!");
            }
            else
            {
                Console.WriteLine($"There she goes!\r\nNow bring back the {Toy}!\r\nGood girl!");
            }
        }
        public override void makeSound(string s = "Woof!")
        {
            Console.WriteLine(s);
        }
    }
}
