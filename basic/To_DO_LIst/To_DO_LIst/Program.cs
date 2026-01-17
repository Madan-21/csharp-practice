using System;
using System.Threading.Tasks;
using System.IO;

class ToDoList
{
    private static string GetNoNullInput(string message)
    {

        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                return input;

            }

            Console.WriteLine("Input cannot be empty. Please try again.");

        }
    }

    public static string GreetUser()
    {
        Console.WriteLine("Welcome user!");
        string name = GetNoNullInput("Please enter your name: ");
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
            string givenDay = GetNoNullInput("Enter day: ");

            bool isValid = false;

            foreach (string day in days)
            {
                if (day.Equals(givenDay, StringComparison.OrdinalIgnoreCase))
                {
                    isValid = true;
                    givenDay = day;
                    break;
                }
            }

            if (isValid)
                return givenDay;

            Console.WriteLine("Invalid day. Please try again.");
        }
    }
    public static string AddTask(string givenDay)
    {
        string task = GetNoNullInput("Task: ");

        string filePath = "task.txt";

        if (!File.ReadAllText(filePath).Contains(givenDay + ":"))
        {
            File.AppendAllText(filePath, $"\n{givenDay}:\n");
        }
        File.AppendAllText(filePath, "- " + task + "\n");
        Console.WriteLine("Your task has been saved.");
        return task;

    }


    public static bool AnotherTask(string givenDay)
    {
        string response = GetNoNullInput("Do you want to add another task: ").ToLower();
        bool addAnotherTask = response == "yes" || response == "y";

        return addAnotherTask;
    }
    public static void ReadTask()
    {

        string response = GetNoNullInput("Do you want to view your tasks: ").ToLower();

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

