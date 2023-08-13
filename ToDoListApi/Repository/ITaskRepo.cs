namespace ToDoListApi.Repository;
using Task = Models.Task;

public interface ITaskRepo
{
    List<Task> GetTasks();
    Task GetTaskById(int id);
    void DeleteTask(int id);
    void UpdateTask(int id ,Task task);
    void CreateTask(Task task);  
}
