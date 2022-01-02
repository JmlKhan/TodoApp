using System.ComponentModel.DataAnnotations;

namespace TodoAPP.Model
{
    public class Todo
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public bool Completed { get; set; }
    }
}
