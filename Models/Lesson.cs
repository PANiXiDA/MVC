using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestMVC.Models
{
    public class Lesson
    {
        [Key]
        public int Lesson_ID { get; set; }
        [Required]
        public string? Lesson_Name { get; set; }
        [Required]
        public string? Weekday { get; set; }
        [Required]
        [ForeignKey("Classroom")]
        public int Classroom_Number { get; set; }
        [Required]
        [ForeignKey("Lesson")]
        public int Lesson_GroupNumber { get; set; }
        public int Lesson_Number { get; set; }
    }
}
