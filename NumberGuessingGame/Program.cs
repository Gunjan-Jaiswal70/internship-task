using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Number Guessing Game (Task 1) ---");
            
            // 1. Difficulty Level
            Console.WriteLine("Level chunein: 1 (1-10), 2 (1-50), 3 (1-100)");
            string choice = Console.ReadLine();
            int maxRange = (choice == "1") ? 10 : (choice == "2" ? 50 : 100);

            Random random = new Random();
            int target = random.Next(1, maxRange + 1);
            int attempts = 0; // 2. Score Tracking
            bool won = false;

            Console.WriteLine($"Maine 1 se {maxRange} ke beech ek number socha hai!");

            while (!won)
            {
                Console.Write("Aapka guess: ");
                if (int.TryParse(Console.ReadLine(), out int guess))
                {
                    attempts++;
                    if (guess == target) {
                        Console.WriteLine($"Sahi! Aapka score (Attempts): {attempts}");
                        won = true;
                    }
                    else if (guess < target) Console.WriteLine("Thoda bada socho!");
                    else Console.WriteLine("Thoda chota socho!");
                }
            }
        }
    }
}
