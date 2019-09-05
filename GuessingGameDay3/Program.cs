using System;

namespace GuessingGameDay3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Please guess a number between 1 and 10");

            int userGuess = Convert.ToInt32(Console.ReadLine());
            int secretNumber = random.Next(1, 10);            

            if (userGuess == secretNumber)
            {
                Console.WriteLine("You Win!");
                Environment.Exit(0);
            }

            if (userGuess < secretNumber)
            {
                Console.WriteLine("The secret number is greater than " + userGuess);
            }

            if (userGuess > secretNumber)
            {
                Console.WriteLine("The secret number is less than " + userGuess);
            }


            if (userGuess == 0)
            {
                Console.WriteLine("Number must be between 1 and 10");
            }

            else
            {
                Console.WriteLine("Guess again");
            }

            Console.WriteLine("Please guess a number between 1 and 10");

            int userGuess2 = Convert.ToInt32(Console.ReadLine());

            if (userGuess2 == secretNumber)
            {
                Console.WriteLine("You Win!");
                Environment.Exit(0);
            }

            if (userGuess2 < secretNumber)
            {
                Console.WriteLine("The secret number is greater than " + userGuess2);
            }

            if (userGuess2 > secretNumber)
            {
                Console.WriteLine("The secret number is less than " + userGuess2);
            }

            if (userGuess2 < 0)
            {
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("Guess again");
            }


            Console.WriteLine("You have one more guess");


            int userGuess3 = Convert.ToInt32(Console.ReadLine());


            if (userGuess3 == secretNumber)
            {
                Console.WriteLine("You Win!");
            }

            if (userGuess3 < secretNumber)
            {
                Console.WriteLine("The secret number is greater than " + userGuess3 );
            }

            if (userGuess3 > secretNumber)
            {
                Console.WriteLine("The secret number is less than " + userGuess3);
            }

            if (userGuess3 < 0)
            {
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("You're out of guesses");
            }

        }
    }
}
