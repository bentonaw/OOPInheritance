namespace OOPInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird bird1 = new Bird("Birdo","Yellow","Seeds",2,"Female",false,"Sparrow");
            Bird bird2 = new Bird("Pete", "Black", "Fish", 1, "Male", false, "Penguin");

            //bird1.getDescription();
            //bird1.doFlight();
            bird1.makeSound();
            Console.WriteLine();
            //bird2.getDescription();
            //bird2.doFlight();
            bird2.makeSound();
            Console.WriteLine();
            Sloth sloth1 = new Sloth("Sonic", "brown", "leaves", 3, "Male", false, false);

            //sloth1.getDescription();
            sloth1.checkSleep();
            sloth1.makeSound();
            sloth1.checkSleep();
            sloth1.makeSound();
            Console.WriteLine();
            Dog dog1 = new Dog("Bert", "beige", "lamb", 4, "Male");
            Poodle poodle1 = new Poodle("Pippi","White","chicken",9,"Female");
            Lagotto lagotto1 = new Lagotto("Lucy","brown","beef",7,"Female");

            //dog1.getDescription();
            //dog1.doEat();
            //dog1.goFetch();
            dog1.makeSound();
            Console.WriteLine();
            //poodle1.getDescription();
            //poodle1.doEat();
            //poodle1.goFetch();
            poodle1.makeSound();
            //poodle1.doTrick();
            Console.WriteLine();
            //lagotto1.getDescription();
            //lagotto1.doEat();
            //lagotto1.goFetch();
            lagotto1.makeSound();
            //lagotto1.findTruffle();
            Console.WriteLine();
        }
    }
}