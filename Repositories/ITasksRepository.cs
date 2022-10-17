using task_api.Models;
namespace task_api.Repositories;

public interface ITasksRepository 
{
    IEnumerable<Tasks> GetAllTasks();
    Tasks GetTaskById(int taskId);
    Tasks CreateTask(Tasks newTask);
    Tasks UpdateTask(Tasks newTask);
    void DeleteTaskById(int taskId);
}