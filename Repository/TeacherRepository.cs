using Microsoft.EntityFrameworkCore;
using TestMVC.Data;
using TestMVC.Interfaces;
using TestMVC.Models;
using System.Threading.Tasks;

namespace TestMVC.Repository
{
    public class TeacherRepository: ITeacherRepository
    {
        private readonly DataContext dataContext_;
        private object _context;

        public TeacherRepository(DataContext dataContext)
        {
            dataContext_ = dataContext;
        }

        public async Task Add(Teacher teacher)
        {
            dataContext_.Teachers.Add(teacher);
            await dataContext_.SaveChangesAsync();
        }
        public async Task Update(Teacher teacher, int id)
        {
            Teacher teacherToUpdate = await dataContext_.Teachers.FindAsync(id);
            teacherToUpdate.Teacher_Fio = teacher.Teacher_Fio;
            teacherToUpdate.Lesson_Name = teacher.Lesson_Name;
            await dataContext_.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var teacher = await dataContext_.Teachers.FindAsync(id);
            dataContext_.Teachers.Remove(teacher);
            await dataContext_.SaveChangesAsync();
        }

        public async Task<Teacher> GetByID(int id)
        {
            var teacher = await dataContext_.Teachers.FindAsync(id);
            return teacher;
        }

        public async Task<string> GetLessonOfTeacher(int id)
        {
            var teacher = await dataContext_.Teachers.FindAsync(id);
            return teacher.Lesson_Name;
        }

        public async Task<bool> TeacherExists(int id)
        {
            return await dataContext_.Teachers.AnyAsync(e => e.Teacher_ID == id);
        }

        public async Task<List<Teacher>> GetAll()
        {
            return await dataContext_.Teachers.ToListAsync();
        }
    }
}
