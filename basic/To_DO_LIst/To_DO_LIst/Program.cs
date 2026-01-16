using System;
using System.Threading.Tasks;
using System.IO;

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

        string filePath = "task.txt";
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine($"Your task for " + givenDay + " is " + task);
        }
        Console.WriteLine("Your task has been saved.");
        return task;

    }


    public static bool AnotherTask(string givenDay)
    {
        Console.Write("Do you want to add another task: ");
        string response = Console.ReadLine().ToLower();
        bool addAnotherTask = response == "yes" || response == "y";

        return addAnotherTask;
    }
    public static void ReadTask()
    {
        Console.Write("Do you want to view your tasks: ");
        string response = Console.ReadLine().ToLower();

        if (response == "yes" || response == "y")
        {
            if (File.Exists("task.txt"))
            {
                Console.WriteLine("Your Tasks: ");
                var tasks = File.ReadAllText("task.txt");
                Console.WriteLine(tasks);
            }
            else
            {
                Console.WriteLine("No tasks found yet.");
            }
        }

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
        ReadTask();
        Console.WriteLine("Thank you for using our app.");
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();

    }


}

