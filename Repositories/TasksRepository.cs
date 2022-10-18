using task_api.Migrations;
using task_api.Models;

namespace task_api.Repositories;

public class TasksRepository : ITasksRepository
{
    private readonly TaskDbContext _context;

    public TasksRepository(TaskDbContext context)
    {
        _context = context;
    }

    public Tasks CreateTask(Tasks newTask)
    {
        _context.Tasks.Add(newTask);
        _context.SaveChanges();
        return newTask;
    }

    public void DeleteTaskById(int taskId)
    {
        var task = _context.Tasks.Find(taskId);
        if (task != null) {
            _context.Tasks.Remove(task);
            _context.SaveChanges();
        }
    }

    public IEnumerable<Tasks> GetAllTasks()
    {
        return _context.Tasks.ToList();
    }

    public Tasks GetTaskById(int taskId)
    {
        return _context.Tasks.SingleOrDefault(t => t.TaskId == taskId);
    }

    public Tasks UpdateTask(Tasks newTask)
    {
        var originalTask = _context.Tasks.Find(newTask.TaskId);
        if (originalTask != null){
            originalTask.Title = newTask.Title;
            originalTask.Completed = newTask.Completed;
            _context.SaveChanges();
        }
        return originalTask;
    }
}