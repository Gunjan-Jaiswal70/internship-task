using System;

TaskManager manager = new TaskManager();

while (true) 
{
    Console.WriteLine("\n1. Add Task\n2. Exit");
    string input = Console.ReadLine();

    if (input == "1") {
        Console.Write("Enter Title: ");
        string title = Console.ReadLine();

        if (string.IsNullOrEmpty(title)) {
            Console.WriteLine("Error: Task title khali nahi ho sakta!");
        } else {
            manager.AddTask(title);
        }
    } 
    else if (input == "2")
     {
        Console.WriteLine("\n--- Project Summary ---");
        Console.WriteLine("Tasks updated successfully in tasks.txt");
        break; 
    }
}