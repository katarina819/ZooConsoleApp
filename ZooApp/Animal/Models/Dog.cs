using System;

namespace WebAPI.Models
{
    /// <summary>
    /// Represents a dog, which is a derived class of <see cref="Animal"/>.
    /// </summary>
    public class Dog : Animal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dog"/> class with the specified name, age, and gender.
        /// </summary>
        /// <param name="name">The name of the dog.</param>
        /// <param name="age">The age of the dog.</param>
        /// <param name="gender">The gender of the dog.</param>
        public Dog(string name, int age, string gender)
            : base(name, age, gender) { }

        /// <summary>
        /// Outputs the sound a dog makes to the console.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} barks: WOOF WOOF!");
        }

        /// <summary>
        /// Displays the dog's information to the console, including species.
        /// </summary>
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Species: Dog");
        }
    }
}
