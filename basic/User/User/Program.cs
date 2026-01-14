using System;

class User
{
    public static string GreetUser()
    {

        Console.WriteLine("Hello! User \nHow are you?");
        Console.Write("Please Enter Your Name: ");
        string name = Console.ReadLine();
        return name;
    }
    public static string AskMood(string name)
    {
        Console.Write("Mood: ");
        string mood = Console.ReadLine();
        switch (mood)
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

        return mood;

    }
    public static string MoodType(string name, string mood)
    {

        string moodType = Console.ReadLine();
        Console.WriteLine($"Thank you for sharing, {name}.\n" +
             $"Tokhat you are feeling, {mood} and you want my help in, {moodType}.\n" +
             $"Now let me process it and get back to you.");
        return moodType;
    }

    public static bool Response(string name)
    {
        Console.Write("is that ok: ");
        string input1 = Console.ReadLine();
        bool response = (input1.ToLower() == "yes" || input1.ToLower() == "true");
        if (response == true)
        {
            Console.WriteLine("Wait for a minute, " + name);

        }
        else
        {
            Console.WriteLine("Okay respect your choice. " + name);

        }
        return response;
    }
    public static bool TryAgain(string name)
    {
        Console.Write("Do you want to try again?  " + name);
        string input2 = Console.ReadLine();
        bool tryAgain = (input2.ToLower() == "yes" || input2.ToLower() == "true");

        if (!tryAgain)
        {
            Console.WriteLine("Okay respect your choice. " + name);

        }
        return tryAgain;
    }
    public static void Main()
    {
        bool tryAgain = true;
        while (tryAgain)
        {
            string name = GreetUser();
            string mood = AskMood(name);
            string moodType = MoodType(name, mood);
            bool response = Response(name);
            tryAgain = TryAgain(name);
        }

    }
}