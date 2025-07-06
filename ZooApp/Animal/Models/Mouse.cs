using System;

namespace WebAPI.Models
{
    /// <summary>
    /// Represents a mouse, which is a derived class of <see cref="Animal"/>.
    /// </summary>
    public class Mouse : Animal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mouse"/> class with the specified name, age, and gender.
        /// </summary>
        /// <param name="name">The name of the mouse.</param>
        /// <param name="age">The age of the mouse.</param>
        /// <param name="gender">The gender of the mouse.</param>
        public Mouse(string name, int age, string gender)
            : base(name, age, gender) { }

        /// <summary>
        /// Outputs the sound a mouse makes to the console.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} squeaks: SQUEAK!");
        }

        /// <summary>
        /// Displays the mouse's information to the console, including species.
        /// </summary>
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Species: Mouse");
        }
    }
}
