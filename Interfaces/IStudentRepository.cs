using TestMVC.Models;

namespace TestMVC.Interfaces
{
    public interface IStudentRepository
    {
        public Task Add(Student student);
        public Task Update(Student student, int id);
        public Task Delete(int id);
        public Task<Student> GetByID(int id);
        public Task<int> GetGroupOfStudent(int id);
        public Task<List<Student>> GetAll();
        public Task<bool> StudentExists(int id);
    }
}
