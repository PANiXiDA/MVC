using Microsoft.EntityFrameworkCore;
using TestMVC.Data;
using TestMVC.Interfaces;
using TestMVC.Models;
using System.Threading.Tasks;

namespace TestMVC.Repository
{
    public class LessonRepository : ILessonRepository
    {
        private readonly DataContext dataContext_;
        private object _context;

        public LessonRepository(DataContext dataContext)
        {
            dataContext_ = dataContext;
        }

        public async Task Add(Lesson lesson)
        {
            dataContext_.Lessons.Add(lesson);
            await dataContext_.SaveChangesAsync();
        }
        public async Task Update(Lesson lesson, int id)
        {
            Lesson lessonToUpdate = await dataContext_.Lessons.FindAsync(id);
            lessonToUpdate.Lesson_Name = lesson.Lesson_Name;
            lessonToUpdate.Weekday = lesson.Weekday;
            lessonToUpdate.Classroom_Number = lesson.Classroom_Number;
            lessonToUpdate.Lesson_GroupNumber = lesson.Lesson_GroupNumber;
            lessonToUpdate.Lesson_Number = lesson.Lesson_Number;
            await dataContext_.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var lesson = await dataContext_.Lessons.FindAsync(id);
            dataContext_.Lessons.Remove(lesson);
            await dataContext_.SaveChangesAsync();
        }

        public async Task<Lesson> GetByID(int id)
        {
            var lesson = await dataContext_.Lessons.FindAsync(id);
            return lesson;
        }

        public async Task<int> GetClassroomOfLesson(int id)
        {
            var lesson = await dataContext_.Lessons.FindAsync(id);
            return lesson.Classroom_Number;
        }

        public async Task<string> GetWeekdayOfLesson(int id)
        {
            var lesson = await dataContext_.Lessons.FindAsync(id);
            return lesson.Weekday;
        }

        public async Task<bool> LessonExists(int id)
        {
            return await dataContext_.Lessons.AnyAsync(e => e.Lesson_ID == id);
        }

        public async Task<List<Lesson>> GetAll()
        {
            return await dataContext_.Lessons.ToListAsync();
        }
    }
}
