using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); //Run GetAppInfo function

            GreetUser(); //Ask for user's name and greet

            while (true)
            {


                //Init correct number
                //int correctNumber = 7;

                //Create a new random object
                Random random = new Random();

                //Init corerct number
                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    //Get user input
                    string input = Console.ReadLine();

                    //Make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        //Print error message
                        PrintColourMessage(ConsoleColor.Red, "Please use and actual number");
                        
                        //Keep going
                        continue;
                    }

                    //Convert to int and put in guess  
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Print error message
                        PrintColourMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                //Output success message
                PrintColourMessage(ConsoleColor.Green, "CORRECT!!! GG sir");

                //Ask to play again
                Console.WriteLine("Play again? [Yor N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }

            }
        }

        //Get and display app info
        static void GetAppInfo()
        {
            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Joe Swarbrick";

            //Change text colour
            Console.ForegroundColor = ConsoleColor.Cyan;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset console colour
            Console.ResetColor();
        }

        //Get user's name and greet
        static void GreetUser()
        {
            //Ask user's name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        //Print colour message
        static void PrintColourMessage(ConsoleColor color, string message)
        {
            //Change text colour
            Console.ForegroundColor = color;

            //Tell user it's not a number number
            Console.WriteLine(message);

            //Reset console colour
            Console.ResetColor();
        }
    }
}