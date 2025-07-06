using System;

namespace WebAPI.Models
{
    /// <summary>
    /// Represents an abstract base class for animals with basic properties and behaviors.
    /// </summary>
    public abstract class Animal
    {
        /// <summary>
        /// Gets or sets the name of the animal.
        /// Defaults to "Unknown" if null or empty during initialization.
        /// </summary>
        public string Name { get; set; }

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
        /// <param name="name">The name of the animal. Defaults to "Unknown" if null or empty.</param>
        /// <param name="age">The age of the animal.</param>
        /// <param name="gender">The gender of the animal.</param>
        protected Animal(string name, int age, string gender)
        {
            Name = string.IsNullOrEmpty(name) ? "Unknown" : name;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// When implemented in a derived class, defines the sound the animal makes.
        /// </summary>
        public abstract void MakeSound();

        /// <summary>
        /// Displays the animal's information (Name, Age, Gender) to the console.
        /// </summary>
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}");
        }
    }
}
