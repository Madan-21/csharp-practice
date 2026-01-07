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
            int chosenNumber = Convert.ToInt32(Console.ReadLine());
           
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
                chosenNumber = Convert.ToInt32(Console.ReadLine());
               
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