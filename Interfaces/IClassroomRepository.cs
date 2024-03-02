using TestMVC.Models;

namespace TestMVC.Interfaces
{
    public interface IClassroomRepository
    {
        public Task Add(Classroom classroom);
        public Task Delete(int id);
        public Task<Classroom> GetByID(int id);
        public Task<List<Classroom>> GetAll();
        public Task<bool> СlassroomExists(int id);
    }
}
