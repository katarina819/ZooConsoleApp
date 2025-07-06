using System;

namespace WebAPI.Models
{
    /// <summary>
    /// Represents an elephant, which is a derived class of <see cref="Animal"/>.
    /// </summary>
    public class Elephant : Animal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Elephant"/> class with the specified name, age, and gender.
        /// </summary>
        /// <param name="name">The name of the elephant.</param>
        /// <param name="age">The age of the elephant.</param>
        /// <param name="gender">The gender of the elephant.</param>
        public Elephant(string name, int age, string gender)
            : base(name, age, gender) { }

        /// <summary>
        /// Outputs the sound an elephant makes to the console.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} trumpets: PRRR!");
        }

        /// <summary>
        /// Displays the elephant's information to the console, including species.
        /// </summary>
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Species: Elephant");
        }
    }
}
