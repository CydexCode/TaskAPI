using System.ComponentModel.DataAnnotations;

namespace TaskAPI.Models
{
    public class Todo
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [Required]
  
        public DateTime CreatedDate { get; set;}
        [Required]
       
        public DateTime Due { get; set;}
        [Required]
  

        public TodoStatus Status { get; set;} //new, inprogress , completed

        public int AuthorId { get; set; }

        public Author Author { get; set; }

    }
}
