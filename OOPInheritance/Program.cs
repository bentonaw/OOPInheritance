namespace OOPInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Bird bird1 = new Bird("Birdo","Yellow","Seeds",2,"Female",false,"Sparrow");
            //bird1.getDescription();
            //bird1.doFlight();
            Console.Write("The bird says: ");
            bird1.makeSound();

            Bird bird2 = new Bird("Pete", "Black", "Fish", 1, "Male", false, "Penguin");
            //bird2.getDescription();
            //bird2.doFlight();
            Console.Write("The bird says: ");
            bird2.makeSound();

            Sloth sloth1 = new Sloth("Sonic", "brown", "leaves", 3, "Male", false, false);
            //sloth1.getDescription();
            sloth1.checkSleep();
            Console.Write("The sloth says: ");
            sloth1.makeSound();

            Dog dog1 = new Dog("Bert", "beige", "lamb", 4, "Male");
            Poodle poodle1 = new Poodle("Pippi","White","chicken",9,"Female");
            Lagotto lagotto1 = new Lagotto("Lucy","brown","beef",7,"Female");

            //dog1.getDescription();
            //dog1.doEat();
            //dog1.goFetch();
            Console.Write("The dog says: ");
            dog1.makeSound();

            //poodle1.getDescription();
            //poodle1.doEat();
            //poodle1.goFetch();
            Console.Write("The dog says: ");
            poodle1.makeSound();
            //poodle1.doTrick();

            //lagotto1.getDescription();
            //lagotto1.doEat();
            //lagotto1.goFetch();
            Console.Write("The dog says: ");
            lagotto1.makeSound();
            //lagotto1.findTruffle();

        }
    }
}