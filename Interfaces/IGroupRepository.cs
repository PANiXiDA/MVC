using TestMVC.Models;

namespace TestMVC.Interfaces
{
    public interface IGroupRepository
    {
        public Task Add(Group group);
        public Task Update(Group group, int id);
        public Task Delete(int id);
        public Task<Group> GetByID(int id);
        public Task<List<Group>> GetAll();
        //public Task<List<Student>> GetStudentsOfGroup(int id);
        //public Task<ICollection<string>> GetLessonsOfGroup(int id);
        public Task<bool> GroupExists(int id);
    }
}
