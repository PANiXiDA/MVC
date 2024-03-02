using System.ComponentModel.DataAnnotations;

namespace TestMVC.Models
{
    public class Classroom
    {
        [Key]
        [Required]
        public int Classroom_ID { get; set; }
        [Required]
        public int Classroom_Number { get; set; }
    }
}
