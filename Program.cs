//Adrian Rozsahegyi NET23

using System.Threading.Channels;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Creates new animals
            Husky bob = new Husky();
            Cow bessy = new Cow();
            Cat zigge = new Cat();
            Dog buster = new Dog();
            Chihuahua sparkle = new Chihuahua();
            Snake ekans = new Snake();

            // Call the make sound function of each animal which prints out their unique sounds
            bob.MakeSound();
            bessy.MakeSound();
            zigge.MakeSound();
            buster.MakeSound();
            sparkle.MakeSound();
            ekans.MakeSound();


            Human rolf = new Human();
            rolf.DestroyWorld();

        }
    }

    // Animals

    // Declaring the base class Animal and initializing it with its default values and methods.
    public class Animal
    {

        public string favFood = "Meat or greens";
        public string noise = "*Animal noises*";
        public string gender = "Male";
        public int legs = 4;
        public int age = 5;       

        // Prints all the information about the animal
        public void AboutAnimal()
        {
            Console.WriteLine($"Favorite food: {favFood}\nGender: {gender}\nLegs: {legs}\nAge: {age}");
        }

        // Prints out the animals noise
        public void MakeSound()
        {
            Console.WriteLine(noise);
        }

        // Prints out what the animals favorite food is
        public void FavoriteFood()
        {
            Console.WriteLine(favFood);
        }
    }

    // Plants

    // Declaring the Plants base class
    public class Plant
        {
        public string favFood = "Sunlight";
        public int age = 20;

        // Prints all the information about the Plant
        public void AboutPlant()
        {
                Console.WriteLine($"Favorite food: {favFood}\nLegs:\nAge: {age}");
        }
    }

        // Declaring the Tree subclass
        public class Tree : Plant
        {
            public Tree()
            {
                favFood = "C02";
                age = 345;
            }
        }

        // Declaring the Flower subclass
        public class Flower : Plant
        {
            public Flower()
            {
                age = 3;
            }
        }

    // Delcaring the subclass Reptile
    public class Reptile : Animal
    {

    }

    // Delcaring the subclass Mammal
    public class Mammal : Animal
    {

    }

    // Declares interface IWild and ITame to let classes inherit from both Mammal & Reptile and simmultaniously
    // being tame or wild
    // Instead of creating 4 sub classes for wild and tame reptile and mammal
    public interface IWild
    {
        void Wild();
    }
    public interface ITame
    {
        void Tame();
    }

    //Mammals

    // Declaring the class "Human" which inherits all the charestaristics from the parrent class "Mammal"
    public class Human : Mammal
        {
            // Initializing it's unique default parameter.
            public bool thumbs = true;

            // Changes some values from the default of the Animal class to things fitting Humans.
            public Human()
            {
                favFood = "Pizza";
                noise = "Tjeeenare mannen!";
            }

            // The Human class' unique method. 
            public void DestroyWorld()
            {
                Console.WriteLine("*By mere existing, the human manges to annihilate the world*");
            }

        }

        // Dogs
        
        // Declaring the class "Dog" which inherits all the charestaristics from "Mammals"
        public class Dog : Mammal, ITame
        {
            // Initializing it's unique parameter size to size medium as default 
            public string size = "medium";

            // Changes some values from the default of the Animal class to things fitting dogs.
            public Dog()
            {
                favFood = "Bones";
                noise = "Woof";
            }

            // The Dog class' unique method. When called it prints out the fetch message shown below.
            public void Fetch()
            {
                Console.WriteLine("*You throw a stick and the dog runs after it and comes back with it, happily wiggling its tail.*");
            }

            public void Tame()
            {
                Console.WriteLine("I am tame");
            }

        }
        
            // Dog subclasses
            public class Chihuahua : Dog
            {
                // Changes the default values to fit Chihuahuas
                public Chihuahua()
                {
                    size = "small";
                    favFood = "Exclusive gold sprinkled gourmet beef wellington";
                    noise = "Waff Waff Waff!";
                }

                public void Fetch()
                {
                    Console.WriteLine("*The Chihuahua looks down on you in a pitifull manner, wondering as to why you'd think it'd run after a stupid stick.");
                }
            }

            public class Husky : Dog
            {
                // Changes the default values to fit Huskys
                public Husky()
                {
                    size = "big";
                    favFood = "anything edible(optional)";
                    noise = "Ooowhoooooooo!";
                }

                public void Fetch()
                {
                    Console.WriteLine("*The Husky excitedly runs after the stick and.. eats the stick when it catches it*");
                }
            }

        // Cats

        // Declaring the class "Cat" which inherits all the charestaristics from the "Mammal" class
        public class Cat : Mammal, ITame
        {

            // Initializing it's unique parameter "coat" to Solid black
            public string coat = "Solid black";

            // Changes some values from the default of the parent class to things fitting cats.
            public Cat()
            {
                favFood = "Fish";
                noise = "Meow";
            }

            // The Cat class' unique method. When called it prints out the cuddle message shown below.
            public void Cuddle()
            {
                Console.WriteLine("*The cat sits in your lap, making biscuts for a while until it lays down and falls asleep*");
            }

            public void Tame()
            {
                Console.WriteLine("I am tame");
            }
    }

        // Cows

        // Declaring the class "Cow" which inherits all the charestaristics from the parrent class.
        public class Cow : Mammal, ITame
        {
            // Initializing it's unique parameter "milkCow" to true
            public bool milkCow = true;

            // Changes some values from the default of the parent class.
            public Cow()
            {
                favFood = "Grass";
                noise = "Moo";
            }

            // The Cow class' unique method. When called it prints out the cow release message shown below
            public void CowRelase()
            {
                Console.WriteLine("*The cows are released outside after the long winter and are joyfully running and jumping around in the nice spring grass*");
            }

            public void Tame()
            {
                Console.WriteLine("I am tame");
            }
    }

    // Reptiles

        // Declaring the class "Snake" which inherits all the charestaristics from the parrent class "Reptile"
        public class Snake : Reptile, IWild
        {
            // Initializing it's unique parameter
            public string length = "3 meters";

            // Changes some values from the parent class to things fitting Snakes.
            public Snake()
            {
                favFood = "Mice";
                noise = "Hiiissss";
                legs = 0;
            }

            // The Snake class' unique method.
            public void ShedSkin()
            {
                Console.WriteLine("*The snake wriggles around, its time for it to shed its scaly skin and change into a new fresh one*");
            }

            public void Wild()
            {
                Console.WriteLine("I am wild");
            }
    }












}