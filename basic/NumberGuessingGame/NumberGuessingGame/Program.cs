using System;

class NumberGuessingGame
{
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
            
            
            int chosenNumber;
            while (true)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out chosenNumber))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input try again");
                }
            }
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
              
                while (true)
                {
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out chosenNumber))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input try again");
                    }
                }
            }
                Console.WriteLine($"Congratulations! you guessed it in {counter} tries.");
            
            Console.Write("Do you want to play again:");
            string response = Console.ReadLine();
            if (response == "yes")
            {
                
            }
            else
            {
                break;
            }

        }


    }
}