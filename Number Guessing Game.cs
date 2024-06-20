using System;

namespace DannyPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String Response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                Response = "";
                number = random.Next(min, max + 1);

                while(guess != number) 
                {
                    Console.WriteLine("Guess the number between " + min + "-" + max + ":");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high!");
                    }
                    else if (guess < number) 
                    {
                        Console.WriteLine(guess + " is too low!");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("This was your amount of guesses: " + guesses);

                Console.WriteLine("Would you like to play again (Y/N): ");
                Response = Console.ReadLine();
                Response = Response.ToUpper();

                if (Response== "Y")
                {
                    playAgain = true;
                }
                else if (Response == "N")
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("STHANK YOU VWERY MUSH for play.");
            Console.ReadKey();
        }
    }
}
