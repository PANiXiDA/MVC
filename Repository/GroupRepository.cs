using Microsoft.EntityFrameworkCore;
using TestMVC.Data;
using TestMVC.Interfaces;
using TestMVC.Models;
using System.Threading.Tasks;

namespace TestMVC.Repository
{
    public class GroupRepository : IGroupRepository
    {
        private readonly DataContext dataContext_;
        private object _context;

        public GroupRepository(DataContext dataContext)
        {
            dataContext_ = dataContext;
        }

        public async Task Add(Group group)
        {
            dataContext_.Groups.Add(group);
            await dataContext_.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var group = await dataContext_.Groups.FindAsync(id);
            dataContext_.Groups.Remove(group);
            await dataContext_.SaveChangesAsync();
        }

        public async Task Update(Group group, int id)
        {
            Group groupToUpdate = await dataContext_.Groups.FindAsync(id);
            groupToUpdate.Group_Number = group.Group_Number;
            //groupToUpdate.Students = group.Students;
            //groupToUpdate.Lessons = group.Lessons;
            await dataContext_.SaveChangesAsync();
        }

        public async Task<Group> GetByID(int id)
        {
            var group = await dataContext_.Groups.FindAsync(id);
            return group;
        }

        //public async Task<List<Lesson>> GetLessonsOfGroup(int id)
        //{
        //    var group = await dataContext_.Groups.FindAsync(id);
        //    return group.Lessons;
        //}

        //public async Task<List<Student>> GetStudentsOfGroup(int id)
        //{
        //    var group = await dataContext_.Groups.FindAsync(id);
        //    return group.Students;
        //}

        public async Task<bool> GroupExists(int id)
        {
            return await dataContext_.Groups.AnyAsync(e => e.Group_ID == id);
        }

        public async Task<List<Group>> GetAll()
        {
            return await dataContext_.Groups.ToListAsync();
        }

        //public async Task<ICollection<string>> GetLessonsOfGroup(int id)
        //{
        //    var group = await dataContext_.Groups.FindAsync(id);
        //    return group.Group_Lessons;
        //}
    }
}
