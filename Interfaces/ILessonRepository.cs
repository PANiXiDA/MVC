using TestMVC.Models;

namespace TestMVC.Interfaces
{
    public interface ILessonRepository
    {
        public Task Add(Lesson lesson);
        public Task Update(Lesson lesson, int id);
        public Task Delete(int id);
        public Task<List<Lesson>> GetAll();
        public Task<Lesson> GetByID(int id);
        public Task<string> GetWeekdayOfLesson(int id);
        public Task<int> GetClassroomOfLesson(int id);
        public Task<bool> LessonExists(int id);
    }
}
