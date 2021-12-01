using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);
            

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            bool gameOn = true;
            int userGuess = 0;
            int userCount = 0;


            // Keep track of the number of guesses and the current user guess
            do {
                Console.WriteLine("Enter your guess, or -1 to give up.");
                string theGuess = Console.ReadLine();
                 bool result = Int32.TryParse(theGuess, out userGuess);


                //check if user entered a number
                if(!result) {
                    Console.WriteLine("Hmmm, that doesn't look like a number");
                }
                else {
                    //if -1 - end the game
                    if(userGuess == -1) {
                        Console.WriteLine("Oh, I was thinking of {0}. GG", theNumber);
                        gameOn = false;

                    }
                    else {
                        userCount++;
                        if(userGuess < theNumber) {
                            Console.WriteLine("That's too low.");
                            
                        }
                        else if(userGuess > theNumber) {
                            Console.WriteLine("No, that't too high");
                            
                        }
                        else {
                            Console.WriteLine("Exactly!");
                            Console.WriteLine("You got it in {0} tries.", userCount);
                            gameOn = false;
                        }
                    }
                }

                
            }
            while(gameOn);

            }
            
    }
}
