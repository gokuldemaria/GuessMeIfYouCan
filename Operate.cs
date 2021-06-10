using num_finder.tools;
using System;
namespace num_finder
{
    public class Operate // the whole process of the game is happening in this class.
    {                    // the brain of the game.
        public void process(int start, int end)
        {

            int theNumber = RandomGenerator.getRandom(start, end); // generating the random number.
            int guessCount = 1;
           

            result(theNumber, guessCount); 

        }

        private void result(int theNumber, int guessCount) // interaction with the player and getting the guess.
        {
            System.Console.WriteLine();
            System.Console.Write("ENTER UR GUESS : ");
            int guess = Convert.ToInt32(Console.ReadLine());
            
            // needs to be refactored.. coz each time we are instantiating the level class.
            Level l = new Level();
            int n = l.hardShip();    // calling the overloaded method #hardship to get the actual chances to calculate.
            

            if (guessCount == (n - 1)) // warning message
            {
                System.Console.WriteLine();
                ColorWritter.ColorMaker("YOU GOT ONLY ONE CHANCE LEFT TO GUESS!!", ConsoleColor.DarkYellow);
                System.Console.WriteLine();
            }
            if (guessCount >= n)  // game over message
            {
                System.Console.WriteLine();
                ColorWritter.ColorMaker("GAME OVER!!", ConsoleColor.DarkYellow);
                ColorWritter.ColorMaker($"The treasure number is : {theNumber}", ConsoleColor.Blue);
                System.Console.WriteLine();
                return;
            }

            if (guess == theNumber) // printing the result if the player guessed the number correctly
            {
                System.Console.WriteLine();
                ColorWritter.ColorMaker("HURRAYYY...! YOU WON", ConsoleColor.DarkGreen);
                System.Console.WriteLine($"You guessed the number in {guessCount} attempts !!");
                System.Console.WriteLine();
            }
            else if (guess > theNumber) // message and further process if the player's guess is greater.
            {
                System.Console.WriteLine();
                ColorWritter.ColorMaker("WRONG GUESS!! TRY AGAIN!!", ConsoleColor.DarkRed);
                ColorWritter.ColorMaker("HINT: you should guess smaller than this!", ConsoleColor.Red);
                System.Console.WriteLine();
                guessCount += 1;
                result(theNumber, guessCount); // using a recursive algo
            }

            else if (guess < theNumber) // message and next thing to happenn if the player's guess is lesser. 
            {
                System.Console.WriteLine();
                ColorWritter.ColorMaker("WRONG GUESS!! TRY AGAIN!!", ConsoleColor.DarkRed);
                ColorWritter.ColorMaker("HINT: you should go a little bigger!", ConsoleColor.Red);
                System.Console.WriteLine();
                guessCount += 1;
                result(theNumber, guessCount); // using a recursive algo
            }

        }

    }
}