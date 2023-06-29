using System;

class GuessingGame
{
    static void Main()
    {
        Random random = new Random();
        int randomNumbers = random.Next(1, 10);
        bool guessedCorrectly = false;
        int attempts = 0;

        Console.WriteLine("I'm thinking of a number from 1 to 11.\n" + "Can you guess it?"); 

        while (!guessedCorrectly)
        {
            Console.Write("Enter your guess ");
            int guess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if (guess == randomNumbers)
            {
                Console.WriteLine("You got it right!");
                Console.WriteLine("Thank you for playing the Number Guessing Game! ");
                break;
            }
            else if (guess < randomNumbers)
            {
                Console.WriteLine("You were close!");
            }
            else
            {
                Console.WriteLine("Try Again");
            }
            
        }
    }
}