
using Microsoft.AspNetCore.Mvc;
using task_api.Models;
using task_api.Repositories;

namespace task_api.Controllers;

[ApiController]
[Route("api/[controller]")]

public class TasksController : ControllerBase
{
    private readonly ILogger<TasksController> _logger;
    private readonly ITasksRepository _tasksRepository;
    
    public TasksController(ILogger<TasksController> logger, ITasksRepository repository)
    {
        _logger = logger;
        _tasksRepository = repository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Tasks>> GetAllTasks()
    {
        return Ok(_tasksRepository.GetAllTasks());
    }

    [HttpGet]
    [Route("{taskId:int}")]
    public ActionResult<Tasks> GetTaskById(int taskId)
    {
        var task = _tasksRepository.GetTaskById(taskId);
        if (task == null)
        {
            return NotFound();
        }

        return Ok(task);
    }

    [HttpPost]
    public ActionResult<Tasks> CreateTask(Tasks newTask)
    {
        if (!ModelState.IsValid || newTask == null)
        {
            return BadRequest();
        }
        
        var createdTask = _tasksRepository.CreateTask(newTask);
        return Created(nameof(GetTaskById), createdTask);
    }

    [HttpPut]
    [Route("{taskId:int}")]
    public ActionResult<Tasks> UpdateTask(Tasks newTask)
    {
        return Ok(_tasksRepository.UpdateTask(newTask));
    }

    [HttpDelete]
    [Route("{taskId:int}")]
    public ActionResult DeleteTaskById(int taskId)
    {
        _tasksRepository.DeleteTaskById(taskId);
        return NoContent();
    }
}