namespace task_api.Models;

public class Tasks 
{
    public int TaskId { get; set; }
    public string? Title { get; set; }
    public bool Completed { get; set; }
}