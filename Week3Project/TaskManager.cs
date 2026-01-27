using System;
using System.Collections.Generic;
using System.IO;

public class TaskManager {
    private List<string> tasks = new List<string>();
    private string fileName = "tasks.txt";

    public void AddTask(string title) {
        tasks.Add(title);
        // File mein save karna
        File.AppendAllText(fileName, title + Environment.NewLine); 
        Console.WriteLine("Task saved to file!");
    }
}