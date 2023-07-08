using System.ComponentModel.DataAnnotations;

namespace CourseUdemy.Entity
{
    public class User
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
    }
}
