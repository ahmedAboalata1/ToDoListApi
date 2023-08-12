using Microsoft.EntityFrameworkCore;

namespace ToDoListApi.Models
{
    public class Context :DbContext
    {
        public Context()
        {
        }
        public Context(DbContextOptions options):base(options)
        {   
        }
        public DbSet<Task> Task { get; set; }
         
    }
}
