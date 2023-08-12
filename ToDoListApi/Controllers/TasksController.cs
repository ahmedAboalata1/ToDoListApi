using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoListApi.Repository;

namespace ToDoListApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly TaskRepo taskRepo;

        public TasksController(TaskRepo taskRepo)
        {
            this.taskRepo=taskRepo;
        }
        [HttpGet]
        public IActionResult GetAllTasks()
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult AddTask(Task task) 
        {
            return Ok(task);
        }
        [HttpDelete]
        public IActionResult DeleteTask(Task task)
        {
            return Ok(task);
        }
        [HttpPut]
        public IActionResult UpdateTask(int id,Task task) 
        {
            return Ok(task);
        }

    }
}
