using System;

class ToDoList
{
    public static void Main()
    {
        Console.WriteLine("Welcome user!");
        Console.Write("PLease enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Welcome " + name +" to our To DO List app");
        string[] days = { "Sunday", "Monday", "Teusday", "Wednesday", "Thursday", "Friday", "Saturday" };

        bool addAnotherTask = true;
        while (addAnotherTask)
        { 
            Console.WriteLine("Please type the day for which you would like to add task.");
            Console.Write("Day : ");
            string givenDay = Console.ReadLine();
            switch (givenDay)
            {
                case "Sunday":

                    break;
                case "Monday":
                    break;

                case "Tuesday":
                    break;
                case "Wednesday":

                    break;
                case "Thursday":

                    break;
                case "Friday":

                    break;
                case "Saturday":
                    break;
                default:
                    Console.WriteLine("Please enter a valid day");
                    break;
            }
            Console.WriteLine($"Please write your task for " + givenDay + " down below.");

            Console.Write("Task: ");
            string task = Console.ReadLine();

            Console.WriteLine($"Your task for " + givenDay + " is " + task);
            Console.WriteLine("Your task has been saved.");
            Console.Write("Do you want to add another task: ");
            string response = Console.ReadLine().ToLower();
            addAnotherTask = response == "yes";
        }
        
            Console.WriteLine("Thank you for using our app."); 
        
    }

}