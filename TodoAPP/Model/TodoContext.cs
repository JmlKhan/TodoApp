using Microsoft.EntityFrameworkCore;

namespace TodoAPP.Model
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) 
            : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }
    }
}
