using System.Collections.Generic;
using TestMVC.Models;

namespace TestMVC.ViewModels
{
    public class ViewModel
    {
        public IEnumerable<Group>? Groups { get; set; }
        public IEnumerable<Student>? Students { get; set; }
        public IEnumerable<Classroom>? Classrooms { get; set; }
        public IEnumerable<Lesson>? Lessons { get; set; }
        public IEnumerable<Teacher>? Teachers { get; set; }
        public int GroupNumber { get; set; }
        public string Teacher { get; set; }
    }
}
