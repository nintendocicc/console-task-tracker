using TaskTrackerMVC.Models;

namespace TaskTrackerMVC.Views;

public class TaskView
{
    public void DisplayTasks(List<TaskItem> tasks)
    {
        Console.Clear();
        Console.WriteLine("=== TASK TRACKER ===");
        if (tasks.Count == 0) Console.WriteLine("No tasks yet.");

        foreach (var task in tasks)
        {
            Console.WriteLine($"{task.Id}. [{task.Status}] {task.Title}");
        }
        Console.WriteLine("====================\n");
    }

    public string GetUserChoice()
    {
        Console.WriteLine("Options: [add] Create Task | [status] Change Status | [exit] Quit");
        Console.Write("> ");
        return Console.ReadLine()?.ToLower() ?? "";
    }

    public string GetTaskTitle()
    {
        Console.Write("Enter task title: ");
        return Console.ReadLine() ?? "Untitled";
    }

    public (int id, int statusChoice) GetStatusUpdate()
    {
        Console.Write("Enter Task ID to update: ");
        int.TryParse(Console.ReadLine(), out int id);

        Console.WriteLine("Select Status: 0: Pending | 1: In Progress | 2: Completed");
        Console.Write("Choice: ");
        int.TryParse(Console.ReadLine(), out int statusChoice);

        return (id, statusChoice);
    }
}