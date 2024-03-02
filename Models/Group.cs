using System.ComponentModel.DataAnnotations;

namespace TestMVC.Models
{
    public class Group
    {
        [Key]
        [Required]
        public int Group_ID { get; set; }
        [Required]
        public int? Group_Number { get; set; }
        //[Required]
        //public ICollection<string>? Group_Lessons { get; set; }
    }
}
