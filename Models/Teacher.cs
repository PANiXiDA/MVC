using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestMVC.Models
{
    public class Teacher
    {
        [Key]
        [Required]
        public int Teacher_ID { get; set; }
        [Required]
        public string? Teacher_Fio { get; set; }
        [Required]
        [ForeignKey("Lesson")]
        public string? Lesson_Name { get; set; }
    }
}
