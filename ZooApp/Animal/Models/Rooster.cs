using System;

namespace WebAPI.Models
{
    /// <summary>
    /// Represents a rooster, which is a derived class of <see cref="Animal"/>.
    /// </summary>
    public class Rooster : Animal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rooster"/> class with the specified name, age, and gender.
        /// </summary>
        /// <param name="name">The name of the rooster.</param>
        /// <param name="age">The age of the rooster.</param>
        /// <param name="gender">The gender of the rooster.</param>
        public Rooster(string name, int age, string gender)
            : base(name, age, gender) { }

        /// <summary>
        /// Outputs the sound a rooster makes to the console.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} crows: COCK-A-DOODLE-DOO!");
        }

        /// <summary>
        /// Displays the rooster's information to the console, including species.
        /// </summary>
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Species: Rooster");
        }
    }
}
