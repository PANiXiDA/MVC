using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestMVC.Models
{
    public class Student
    {
        [Key]
        [Required]
        public int Student_ID { get; set; }
        [Required]
        public string? Student_Fio { get; set; }
        [Required]
        [ForeignKey("Group")]
        public int Group_Number { get; set; }
    }
}
