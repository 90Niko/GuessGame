using System;

namespace GuessGame



{
    class Program
    {
        public static void Main()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAutor = "Nikolay Geroev";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"{appName}: Version {appVersion} by {appAutor}");

            Console.ResetColor();

            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0} let´s play a game...", inputName);
            while (true)
            {
                Random random = new();

                int correctNumber = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10.");




                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {

                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Please enter an actual number!");

                        Console.ResetColor();

                        continue;

                    }




                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Wrong Number, please try again!");


                        Console.ResetColor();
                    }













                }



                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("You are CORRECT!");

                Console.ResetColor();
                Console.WriteLine("Play Again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {


                    continue;

                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;

                }

            }






        }
    }
}
