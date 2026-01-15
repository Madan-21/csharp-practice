using System;

class NumberGuessingGame
{
    public static int GetValidNumber()
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
    static void greetUser()
    {
        Console.WriteLine("Hello there! Welcome to NumberGuessingGame");
        Console.Write("Enter your number: ");
    }
    public static int randomNumber()
    {
        Random random = new Random();
        int number = random.Next(1, 101);
        return number;
    }
    static int Counter(int number)

    {
        int counter = 0;


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
        return counter;
    }

    static bool PlayAgain()
    {

        Console.Write("Do you want to play again:");
        string response = Console.ReadLine().ToLower();
        return response == "yes";
    }

    public static void Main()
    {
        bool playAgain = true;
        while (playAgain)
        {
            greetUser();
            int number = randomNumber();
            Counter(number);
            playAgain = PlayAgain();
        }


    }
}