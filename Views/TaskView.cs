using TaskTrackerMVC.Models;

namespace TaskTrackerMVC.Views;

public class TaskView
{
    public void DisplayTasks(List<TaskItem> tasks)
    {
        Console.WriteLine("\n--- Current Tasks ---");
        foreach (var task in tasks)
        {
            string status = task.IsCompleted ? "[Done]" : "[Pending]";
            Console.WriteLine($"{task.Id}. {status} {task.Title}");
        }
    }

    public string GetTaskInput()
    {
        Console.Write("\nEnter a new task title: ");
        return Console.ReadLine() ?? "";
    }
}