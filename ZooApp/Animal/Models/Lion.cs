using System;

namespace WebAPI.Models
{
    /// <summary>
    /// Represents a lion, which is a derived class of <see cref="Animal"/>.
    /// </summary>
    public class Lion : Animal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Lion"/> class with the specified name, age, and gender.
        /// </summary>
        /// <param name="name">The name of the lion.</param>
        /// <param name="age">The age of the lion.</param>
        /// <param name="gender">The gender of the lion.</param>
        public Lion(string name, int age, string gender)
            : base(name, age, gender) { }

        /// <summary>
        /// Outputs the sound a lion makes to the console.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} roars: ROAR!");
        }

        /// <summary>
        /// Displays the lion's information to the console, including species.
        /// </summary>
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Species: Lion");
        }
    }
}
