using System.ComponentModel.DataAnnotations;

namespace ToDoListApi.Models
{
    public class Task
    {
        public int Id { get; set; }
        [MinLength(10)]
        public string Desciption { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }

    }
}
