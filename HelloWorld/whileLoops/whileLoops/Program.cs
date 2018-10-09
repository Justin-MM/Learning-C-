using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoops
{
    //display a main menu
    //then 1) print the numbers a user wants
    //2)play a guessing game
    //3)exit out of the application
    class Program
    {
        static void Main(string[] args)
        {
            bool showMainMenu = true;

            while (showMainMenu)
            {
                Console.Clear();
                showMainMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.WriteLine("Choose an item number from the menu:");
            Console.WriteLine("1) Print some numbers");
            Console.WriteLine("2) Play a guessing game");
            Console.WriteLine("3) Exit");
            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                Console.Clear();
                PrintNumbers();
                return true;
            }
            else if (userChoice == 2)
            {
                Console.Clear();
                GuessingGame();
                return true;
            }
            else if (userChoice == 3)
            {
                Console.WriteLine("Goodbye!");
                return false;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please choose an item from the Menu");
                Console.ReadLine();
                return true;
            }

        }

        private static void PrintNumbers()
        {
            Console.WriteLine("Print Numbers");
            Console.Write("How many numbers do you want?: ");
            int numbers = int.Parse(Console.ReadLine());

            int counter = 0;
            while (counter < numbers + 1)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            Console.ReadLine();

        }

        private static void GuessingGame()
        {
            Console.WriteLine("Let's Play a guessing game!");
            Random randomNumber = new Random();
            int guessThisNumber = randomNumber.Next(1, 11);
            int guesses = 0;
                        
            bool incorrect = true;
            do
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                int answer = int.Parse(Console.ReadLine());
                guesses++;

                if (answer == guessThisNumber)
                {
                    incorrect = false;
                }
                else {
                    Console.WriteLine("Wrong!");
                    incorrect = true;
                }
            } while (incorrect);
            Console.WriteLine("Correct! It took you {0} guesses to get it right", guesses);
            Console.ReadLine();

        }
    }
}
