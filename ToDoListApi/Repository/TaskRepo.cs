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

        public void CreateTask(Task task)
        {
            context.Add(task);
            context.SaveChanges();
        }

        public void DeleteTask(int id)
        {
            Task task = GetTaskById(id);
            context.Task.Remove(task);
            context.SaveChanges();
        }

        public Task GetTaskById(int id)
        {
            Task task = context.Task.FirstOrDefault(x=>x.Id==id);     
              return task;
        }

        public List<Task> GetTasks()
        {
           List<Task> tasks = context.Task.ToList();
            return tasks;
        }

        public void UpdateTask(int id ,Task task)
        {
            Task OldTask = GetTaskById(id);
            if (OldTask != null)
            {
                OldTask.IsCompleted=task.IsCompleted;
                OldTask.Desciption=task.Desciption;
                OldTask.DueDate=task.DueDate;
            }
            context.SaveChanges();
        }
    }
}
