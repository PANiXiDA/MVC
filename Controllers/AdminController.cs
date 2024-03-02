using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using TestMVC.Interfaces;
using TestMVC.Models;
using TestMVC.ViewModels;

namespace TestMVC.Controllers
{
    public class AdminController : Controller
    {
        private readonly IGroupRepository _repository_group;
        private readonly IStudentRepository _repository_student;
        private readonly IClassroomRepository _repository_classroom;
        private readonly ILessonRepository _repository_lesson;
        private readonly ITeacherRepository _repository_teacher;

        public AdminController(IGroupRepository repository_group, IStudentRepository repository_student,
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

        [HttpPost]
        public async Task<IActionResult> PostGroup(Group group)
        {
            if (!ModelState.IsValid)
            {
                return View("Error");
            }

            await _repository_group.Add(group);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteGroup(int id)
        {
            await _repository_group.Delete(id);

            return RedirectToAction("Index");
        }
        //[HttpPost]
        //public async Task<IActionResult> AddLessonOfGroup(int id, string lesson)
        //{
        //    var group = await _repository_group.GetByID(id);
        //    group.Group_Lessons.Add(lesson);

        //    return RedirectToAction("Index");
        //}
        //[HttpPost]
        //public async Task<IActionResult> DeleteLessonOfGroup(int id, string lesson)
        //{
        //    var group = await _repository_group.GetByID(id);
        //    group.Group_Lessons.Remove(lesson);

        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        public async Task<ActionResult<Student>> PostStudent(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View("Error");
            }
            await _repository_student.Add(student);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            await _repository_student.Delete(id);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> PostClassroom(Classroom сlassroom)
        {
            if (!ModelState.IsValid)
            {
                return View("Error");
            }
            await _repository_classroom.Add(сlassroom);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteClassroom(int id)
        {
            if (!ModelState.IsValid)
            {
                return View("Error");
            }

            await _repository_classroom.Delete(id);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<ActionResult<Lesson>> PostLesson(Lesson lesson)
        {
            if (!ModelState.IsValid)
            {
                return View("Error");
            }

            await _repository_lesson.Add(lesson);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteLesson(int id)
        {
            if (!ModelState.IsValid)
            {
                return View("Error");
            }

            await _repository_lesson.Delete(id);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<ActionResult<Teacher>> PostTeachert(Teacher teacher)
        {
            if (!ModelState.IsValid)
            {
                return View("Error");
            }

            await _repository_teacher.Add(teacher);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteTeacher(int id)
        {
            if (!ModelState.IsValid)
            {
                return View("Error");
            }

            await _repository_teacher.Delete(id);

            return RedirectToAction("Index");
        }
    }
}
