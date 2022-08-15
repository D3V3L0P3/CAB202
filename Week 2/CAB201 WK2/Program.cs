using System;

namespace AgeDisplay
{
    class AgeDisplay

    {
        /// <summary>
        /// </summary>
        /// <param name = 'args' \></param>
        static void Main(string[] args)
        {
            int age = 17;

            if (age >= 65)
            {
                Console.WriteLine("Enjoy your retirement");
            }

            else if (age >= 18)
            {
                Console.WriteLine("would your like an alcoholic beverage");
            }

            else if (age >= 16)
            {
                Console.WriteLine("You're old enough to drive");
            }

            else
            {
                Console.WriteLine("You're too young")
            }
        }
    }
}