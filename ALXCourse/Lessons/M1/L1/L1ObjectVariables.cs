using ALXCourse.Lessons.M1.L1.Classes;

namespace ALXCourse.Lessons.M1.L1
{
    public class L1ObjectVariables
    {
        public static void Run()
        {
            Console.WriteLine("Variables");
            Dog dog = new Dog();
            dog.Jump();
            dog.Bark();
            dog.Name = "Burek";
            dog.Race = "Golden Retriver";
            dog.Age = 2;
            Console.WriteLine("Attention here is dog " + dog.Name);
            Console.WriteLine("Race: " + dog.Race);
            Console.WriteLine("Age: " + dog.Age);
            Dog.Eat();
            Cat cat = new Cat();
            cat.Name = "Klakier";
            Console.WriteLine(".... and now ....");
            cat.Eat();
            cat.Sleep();
            Console.WriteLine("");
        }

        public void T2()
        {
            Console.WriteLine("Bla Bla Bla");
        }

        public static void Test3()
        {
            Dog westieDog = new Dog();
            westieDog.Race = "WHWT";
            westieDog.Age = 2;
            westieDog.Name = "Skiper";
            westieDog.GoodBoi = false;
            westieDog.Present();
            DogOffspringStats stats = westieDog.Breed();
            Console.WriteLine("Number of famale pups: " + stats.NumberOfFemalePups);
            Console.WriteLine("Number of male pups: " + stats.NumberOfMalePups);
            Console.WriteLine(westieDog.Breed().NumberOfFemalePups);
            Console.WriteLine("Number of famale pups: ________ " + westieDog.Breed().NumberOfFemalePups);
            westieDog.Jump();
            westieDog.Bark();
            Console.WriteLine(westieDog.Add(2, 4));
            Console.WriteLine(westieDog.GetOlderAge());
        }
    }
}
