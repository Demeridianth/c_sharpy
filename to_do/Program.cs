using System;
using System.Buffers;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Markup;
using System.Xml.XPath;
using to_do;


public class ToDo
{

    // Program entry point
    public static void Main(string[] args)
    {
        List<TaskItem> tasks = new();
        ToDo app = new();

        app.Help();
        app.AddTask(tasks);
    }

    // help
    public void Help()
    {
        Console.WriteLine("help text");
    }

    // add
    public void AddTask(List<TaskItem> tasks)
    {
        Console.WriteLine("enter task name: ");
        string addTask = Console.ReadLine() ?? "";
        
        TaskItem taskNew = new(addTask, "new");
        
        tasks.Add(taskNew);
    
    }

    // show
    public void ShowTasks(List<TaskItem> tasks)
    {
        
    }

}
