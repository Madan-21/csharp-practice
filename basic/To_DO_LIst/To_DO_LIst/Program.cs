using System;
using System.Threading.Tasks;

class ToDoList
{
    public static string GreetUser()
    {
        Console.WriteLine("Welcome user!");
        Console.Write("PLease enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Welcome " + name + " to our To DO List app");

        return name;
    }
    public static string Days()
    {
        string[] days =
        {
            "Sunday", "Monday", "Tuesday",
            "Wednesday", "Thursday", "Friday", "Saturday"
        };

        while (true)
        {
            Console.Write("Enter day: ");
            string givenDay = Console.ReadLine();

            bool isValid = false;

            foreach (string day in days)
            {
                if (day.Equals(givenDay, StringComparison.OrdinalIgnoreCase))
                {
                    isValid = true;
                    givenDay = day; // normalize casing
                    break;
                }
            }

            if (isValid)
                return givenDay;

            Console.WriteLine("❌ Invalid day. Please try again.");
        }
    }
    public static string AddTask(string givenDay)
    {

        Console.Write("Task: ");
        string task = Console.ReadLine();
        Console.WriteLine($"Your task for " + givenDay + " is " + task);
        Console.WriteLine("Your task has been saved.");
        return task;

    }


    public static bool AnotherTask(string givenDay)
    {
        Console.Write("Do you want to add another task: ");
        string response = Console.ReadLine().ToLower();
        bool addAnotherTask = response == "yes";
        Console.WriteLine($"Please write your task for " + givenDay + " down below.");

        return addAnotherTask;
    }

    public static void Main()
    {
        GreetUser();
        bool addAnotherTask = true;
        while (addAnotherTask)
        {
            string givenDay = Days();
            AddTask(givenDay);
            addAnotherTask = AnotherTask(givenDay);
        }
        Console.WriteLine("Thank you for using our app.");

    }


}

