using System;
using System.Collections.Generic;
using System.Linq;

namespace WebAPI
{
    /// <summary>
    /// Represents the abstract base class for all animals in the zoo.
    /// Demonstrates encapsulation, abstraction, and polymorphism.
    /// </summary>
    abstract class Animal
    {
        private string name;

        /// <summary>
        /// Gets or sets the name of the animal. If null or empty, sets it to "Unknown".
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = !string.IsNullOrEmpty(value) ? value : "Unknown"; }
        }

        /// <summary>
        /// Gets or sets the age of the animal.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Gets or sets the gender of the animal.
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Animal"/> class.
        /// </summary>
        /// <param name="name">The name of the animal.</param>
        /// <param name="age">The age of the animal.</param>
        /// <param name="gender">The gender of the animal.</param>
        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Outputs the animal's unique sound to the console.
        /// Must be implemented by derived classes.
        /// </summary>
        public abstract void MakeSound();

        /// <summary>
        /// Displays the animal's general information.
        /// Can be overridden in derived classes.
        /// </summary>
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}");
        }
    }

    // === Derived Animal Classes ===

    /// <summary>Represents a lion.</summary>
    class Lion : Animal
    {
        public Lion(string name, int age, string gender) : base(name, age, gender) { }

        public override void MakeSound() => Console.WriteLine($"{Name} roars: ROAR!");
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Species: Lion");
        }
    }

    /// <summary>Represents an elephant.</summary>
    class Elephant : Animal
    {
        public Elephant(string name, int age, string gender) : base(name, age, gender) { }

        public override void MakeSound() => Console.WriteLine($"{Name} trumpets: PRRR!");
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Species: Elephant");
        }
    }

    /// <summary>Represents a dog.</summary>
    class Dog : Animal
    {
        public Dog(string name, int age, string gender) : base(name, age, gender) { }

        public override void MakeSound() => Console.WriteLine($"{Name} barks: WOOF WOOF!");
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Species: Dog");
        }
    }

    /// <summary>Represents a mouse.</summary>
    class Mouse : Animal
    {
        public Mouse(string name, int age, string gender) : base(name, age, gender) { }

        public override void MakeSound() => Console.WriteLine($"{Name} squeaks: SQUEAK!");
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Species: Mouse");
        }
    }

    /// <summary>Represents a rooster.</summary>
    class Rooster : Animal
    {
        public Rooster(string name, int age, string gender) : base(name, age, gender) { }

        public override void MakeSound() => Console.WriteLine($"{Name} crows: COCK-A-DOODLE-DOO!");
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Species: Rooster");
        }
    }

    /// <summary>
    /// Main program class containing application entry point and menu logic.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point for the zoo management console application.
        /// </summary>
        static void Main(string[] args)
        {
            List<Animal> zoo = new List<Animal>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n=== Zoo Menu ===");
                Console.WriteLine("1. Add a new animal");
                Console.WriteLine("2. Show all animals");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option (1-3): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddAnimal(zoo);
                        break;
                    case "2":
                        ShowAllAnimals(zoo);
                        break;
                    case "3":
                        running = false;
                        Console.WriteLine("Exiting the zoo. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose 1, 2, or 3.");
                        break;
                }
            }
        }

        /// <summary>
        /// Prompts the user to enter and add a new animal to the zoo.
        /// </summary>
        /// <param name="zoo">The list of animals.</param>
        static void AddAnimal(List<Animal> zoo)
        {
            Console.WriteLine("\nSelect animal type to add:");
            Console.WriteLine("1. Lion");
            Console.WriteLine("2. Elephant");
            Console.WriteLine("3. Dog");
            Console.WriteLine("4. Mouse");
            Console.WriteLine("5. Rooster");
            Console.Write("Your choice (1-5): ");
            string typeChoice = Console.ReadLine();

            string name = "", gender = "";
            int age = 0;

            switch (typeChoice)
            {
                case "1":
                    name = ReadName("Lion");
                    age = ReadAge("Lion");
                    gender = ReadGender("Lion");
                    zoo.Add(new Lion(name, age, gender));
                    break;
                case "2":
                    name = ReadName("Elephant");
                    age = ReadAge("Elephant");
                    gender = ReadGender("Elephant");
                    zoo.Add(new Elephant(name, age, gender));
                    break;
                case "3":
                    name = ReadName("Dog");
                    age = ReadAge("Dog");
                    gender = ReadGender("Dog");
                    zoo.Add(new Dog(name, age, gender));
                    break;
                case "4":
                    name = ReadName("Mouse");
                    age = ReadAge("Mouse");
                    gender = ReadGender("Mouse");
                    zoo.Add(new Mouse(name, age, gender));
                    break;
                case "5":
                    name = ReadName("Rooster");
                    age = ReadAge("Rooster");
                    gender = ReadGender("Rooster");
                    zoo.Add(new Rooster(name, age, gender));
                    break;
                default:
                    Console.WriteLine("Invalid choice. Returning to main menu.");
                    return;
            }

            Console.WriteLine($"Great job! You added an animal: {typeChoice} {name}, {age} years old, Gender: {gender}");
        }

        /// <summary>
        /// Displays all animals currently in the zoo.
        /// </summary>
        /// <param name="zoo">The list of animals.</param>
        static void ShowAllAnimals(List<Animal> zoo)
        {
            if (zoo.Count == 0)
            {
                Console.WriteLine("No animals in the zoo yet.");
                return;
            }

            Console.WriteLine("\n=== Zoo Animals ===");
            foreach (Animal animal in zoo)
            {
                animal.ShowInfo();
                animal.MakeSound();
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Reads and validates an animal's name from user input.
        /// </summary>
        static string ReadName(string animalType)
        {
            while (true)
            {
                Console.Write($"Enter the name of the {animalType}: ");
                string name = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(name) && !name.Any(char.IsDigit))
                    return name;

                Console.WriteLine("Invalid name. It cannot be empty or contain numbers.");
            }
        }

        /// <summary>
        /// Reads and validates an animal's age from user input.
        /// </summary>
        static int ReadAge(string animalType)
        {
            int age;
            while (true)
            {
                Console.Write($"Enter the age of the {animalType} (<= 100): ");
                if (int.TryParse(Console.ReadLine(), out age) && age >= 1 && age <= 100)
                    return age;

                Console.WriteLine("Invalid input. Please enter a valid age between 1 and 100.");
            }
        }

        /// <summary>
        /// Reads and validates an animal's gender from user input.
        /// </summary>
        static string ReadGender(string animalType)
        {
            while (true)
            {
                Console.Write($"Enter the gender of the {animalType} (Male/Female): ");
                string gender = Console.ReadLine()?.Trim().ToLower();

                if (gender == "male" || gender == "female")
                    return char.ToUpper(gender[0]) + gender.Substring(1);

                Console.WriteLine("Invalid gender. Please enter 'Male' or 'Female'.");
            }
        }
    }
}
