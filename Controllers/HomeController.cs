using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using System.Diagnostics;
using TestMVC.Interfaces;
using TestMVC.Models;
using TestMVC.Repository;
using TestMVC.ViewModels;

namespace TestMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGroupRepository _repository_group;
        private readonly IStudentRepository _repository_student;
        private readonly IClassroomRepository _repository_classroom;
        private readonly ILessonRepository _repository_lesson;
        private readonly ITeacherRepository _repository_teacher;

        public HomeController(IGroupRepository repository_group, IStudentRepository repository_student, 
            IClassroomRepository repository_classroom, ILessonRepository repository_lesson, ITeacherRepository repository_teacher)
        {
            _repository_group = repository_group;
            _repository_student = repository_student;
            _repository_classroom = repository_classroom;
            _repository_lesson = repository_lesson;
            _repository_teacher = repository_teacher;
        }

        public async Task<IActionResult> Index()
        {
            ViewModel obj = new ViewModel();    
            obj.Groups = await _repository_group.GetAll();
            obj.Students = await _repository_student.GetAll();
            obj.Classrooms = await _repository_classroom.GetAll();
            obj.Lessons = await _repository_lesson.GetAll();
            obj.Teachers = await _repository_teacher.GetAll();
            return View(obj);
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> Timetable(string group)
        {
            ViewModel obj = new ViewModel();
            obj.Groups = await _repository_group.GetAll();
            obj.Students = await _repository_student.GetAll();
            obj.Classrooms = await _repository_classroom.GetAll();
            obj.Lessons = await _repository_lesson.GetAll();
            obj.Teachers = await _repository_teacher.GetAll();
            obj.GroupNumber = int.Parse(group);
            return View(obj);
        }

        public async Task<IActionResult> TeacherTimetable(string teacher)
        {
            ViewModel obj = new ViewModel();
            obj.Groups = await _repository_group.GetAll();
            obj.Students = await _repository_student.GetAll();
            obj.Classrooms = await _repository_classroom.GetAll();
            obj.Lessons = await _repository_lesson.GetAll();
            obj.Teachers = await _repository_teacher.GetAll();
            obj.Teacher = teacher;
            return View(obj);
        }
    }
}
