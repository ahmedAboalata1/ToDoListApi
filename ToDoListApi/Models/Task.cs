namespace ToDoListApi.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Desciption { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }

    }
}
