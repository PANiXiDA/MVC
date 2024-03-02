using TestMVC.Models;

namespace TestMVC.Interfaces
{
    public interface ITeacherRepository
    {
        public Task Add(Teacher teacher);
        public Task Update(Teacher teacher, int id);
        public Task Delete(int id);
        public Task<List<Teacher>> GetAll();
        public Task<Teacher> GetByID(int id);
        public Task<string> GetLessonOfTeacher(int id);
        public Task<bool> TeacherExists(int id);
    }
}
