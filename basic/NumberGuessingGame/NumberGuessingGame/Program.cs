using System;

class NumberGuessingGame
{
    static int GetValidNumber()
    {
        int number;

        while (true)
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Invalid input try again");
            }
        }
    }
    public static void Main()
    {
        bool playAgain = true;
       while (playAgain)
        {
            int counter = 0;
            Random random = new Random();
            int number = random.Next(1, 101);


            Console.WriteLine("Hello there! Welcome to NumberGuessingGame");
            Console.Write("Enter your number: ");


            int chosenNumber = GetValidNumber();
            counter++;
            while (chosenNumber != number)
            {
                counter++;
                if (chosenNumber < number)
                {
                    Console.WriteLine("The number is too low");
                }
                else
                {
                    Console.WriteLine("The number is too high");

                }
                Console.Write("Enter your number again: ");
                chosenNumber = GetValidNumber();
               
            }
                Console.WriteLine($"Congratulations! you guessed it in {counter} tries.");
            
            Console.Write("Do you want to play again:");
            string response = Console.ReadLine().ToLower();
            playAgain = response == "yes";

        }


    }
}