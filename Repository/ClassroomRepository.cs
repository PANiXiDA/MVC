using Microsoft.EntityFrameworkCore;
using TestMVC.Data;
using TestMVC.Interfaces;
using TestMVC.Models;
using System.Threading.Tasks;

namespace TestMVC.Repository
{
    public class ClassroomRepository : IClassroomRepository
    {
        private readonly DataContext dataContext_;
        private object _context;

        public ClassroomRepository(DataContext dataContext)
        {
            dataContext_ = dataContext;
        }

        public async Task Add(Classroom classroom)
        {
            dataContext_.Classrooms.Add(classroom);
            await dataContext_.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var classroom = await dataContext_.Classrooms.FindAsync(id);
            dataContext_.Classrooms.Remove(classroom);
            await dataContext_.SaveChangesAsync();
        }

        public async Task<List<Classroom>> GetAll()
        {
            return await dataContext_.Classrooms.ToListAsync();
        }

        public async Task<Classroom> GetByID(int id)
        {
            var classroom = await dataContext_.Classrooms.FindAsync(id);
            return classroom;
        }

        public async Task<bool> СlassroomExists(int id)
        {
            return await dataContext_.Classrooms.AnyAsync(e => e.Classroom_ID == id);
        }
    }
}
