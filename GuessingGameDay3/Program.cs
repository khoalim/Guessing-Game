using System;

namespace GuessingGameDay3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please guess a number between 1 and 10");

            string userGuess = Console.ReadLine();
            byte guess = Convert.ToByte(userGuess);

            if (guess == 7)
            {
                Console.WriteLine("You Win!");
            }
            else
            {
                Console.WriteLine("You lose");
            }

        }
    }
}
