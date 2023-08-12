using ToDoListApi.Models;
using Task = ToDoListApi.Models.Task;

namespace ToDoListApi.Repository
{
    public class TaskRepo:ITaskRepo
    {
        private readonly Context context;

        public TaskRepo(Context context)
        {
            this.context=context;
        }

        public void DeleteTask(int id)
        {
            throw new NotImplementedException();
        }

        public Task GetTaskById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Task> GetTasks()
        {
            throw new NotImplementedException();
        }

        public void UpdateTask(Task task)
        {
            throw new NotImplementedException();
        }

        
    }
}
