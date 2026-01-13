using System;

class User
{
    public static void Main()
    {

        Console.WriteLine("Hello! User \nHow are you?");
        Console.Write("Please Enter Your Name: ");
        string name = Console.ReadLine();
        Console.Write("Mood: ");
        string mood = Console.ReadLine();

        
        
            switch(mood)
            { 

                case "Good":
                Console.WriteLine("Happy to know that. " + name);
                Console.Write("How can I help you today?\n");
                break;

                case "Bad":
                    Console.WriteLine("Ohh! That's sad to hear. " + name);
                    Console.Write("Any way I can help in?\n");
                    break;

                default:
                    Console.WriteLine("Wrong input write Good or Bad");
                    break;
            }
        
            string moodType = Console.ReadLine();
            Console.WriteLine($"Thank you for sharing that you are feeling\n" + mood + name +"\nand you want my help in " + moodType + "\nNow let me process it and get back to you");

            Console.Write("is that ok: ");
            string input1 = Console.ReadLine();
            bool response = (input1.ToLower() == "yes" || input1.ToLower() == "true");
            if (response == true)
            {
                Console.WriteLine("Wait for a minute" + name);

            }
            else
            {
                Console.WriteLine("Okay respect your choice." + name);

            }
            Console.Write("Do you want to try again?" + name);
            string input2 = Console.ReadLine();
            bool tryAgain = (input2.ToLower() == "yes" || input2.ToLower() == "true");

            if (tryAgain == true)
            {
                Main(); // I don't know how to reloop the whole thing again I forgot i did that i numberguessing game

            }
            else
            {
                Console.WriteLine("Okay respect your choice." + name);

            }
        }
}