using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoListApi.Repository;
using Task = ToDoListApi.Models.Task;

namespace ToDoListApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskRepo taskRepo;
        public TasksController(ITaskRepo taskRepo)
        {
            this.taskRepo=taskRepo;
        }
        [HttpGet]
        public IActionResult GetAllTasks()
        {
            List<Task> tasks = taskRepo.GetTasks();
            return Ok(tasks);
        }
        [HttpPost]
        public IActionResult AddTask(Task task) 
        {
            taskRepo.CreateTask(task);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteTask(Task task)
        {
            taskRepo.DeleteTask(task.Id);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateTask(int id,Task task) 
        {
            taskRepo.UpdateTask(id,task);
            return Ok();
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetTaskById(int id)
        {
            Task task = taskRepo.GetTaskById(id);
            return Ok(task);
        }

    }
}
