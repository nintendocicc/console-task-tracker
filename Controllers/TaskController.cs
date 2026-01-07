using TaskTrackerMVC.Models;
using TaskTrackerMVC.Views;

namespace TaskTrackerMVC.Controllers;

public class TaskController
{
    private List<TaskItem> _tasks = new();
    private TaskView _view = new();

    public void Run()
    {
        bool running = true;
        while (running)
        {
            _view.DisplayTasks(_tasks);
            string title = _view.GetTaskInput();
            
            if (title.ToLower() == "exit") break;

            _tasks.Add(new TaskItem { Id = _tasks.Count + 1, Title = title });
        }
    }
}