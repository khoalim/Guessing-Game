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
                Environment.Exit(0);
            }

            if (guess <= 5)
            {
                
            }

                  

            if (guess == 0)
            {
                Console.WriteLine("Number must be between 1 and 10");
            }

            else
            {
                Console.WriteLine("Guess again");
            }

            Console.WriteLine("Please guess a number between 1 and 10");

            string userGuess2 = Console.ReadLine();
            byte guess2 = Convert.ToByte(userGuess2);

            if (guess2 == 7)
            {
                Console.WriteLine("You Win!");
                Environment.Exit(0);
            }

            if (guess2 < 0)
            {
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("Guess again");
            }


            Console.WriteLine("You have one more guess");
            

               string userGuess3 = Console.ReadLine();
               byte guess3 = Convert.ToByte(userGuess3);
           

            if (guess3 == 7)
            {
                Console.WriteLine("You Win!");
            }

            if (guess3 < 0)
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
