using TaskTrackerMVC.Models;
using TaskTrackerMVC.Views;

namespace TaskTrackerMVC.Controllers;

public class TaskController
{
    private List<TaskItem> _tasks = new();
    private TaskView _view = new();
    private int _nextId = 1;

    public void Run()
    {
        while (true)
        {
            _view.DisplayTasks(_tasks);
            string choice = _view.GetUserChoice();

            if (choice == "exit") break;

            switch (choice)
            {
                case "add":
                    string title = _view.GetTaskTitle();
                    _tasks.Add(new TaskItem { Id = _nextId++, Title = title });
                    break;

                case "status":
                    var (id, statusIndex) = _view.GetStatusUpdate();
                    var task = _tasks.Find(t => t.Id == id);
                    if (task != null && Enum.IsDefined(typeof(Models.TaskStatus), statusIndex))
                    {
                        task.Status = (Models.TaskStatus)statusIndex;
                    }
                    break;
            }
        }
    }
}