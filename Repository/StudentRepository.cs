using Microsoft.EntityFrameworkCore;
using TestMVC.Data;
using TestMVC.Interfaces;
using TestMVC.Models;
using System.Threading.Tasks;

namespace TestMVC.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DataContext dataContext_;
        private object _context;
        public StudentRepository(DataContext dataContext)
        {
            dataContext_ = dataContext;
        }

        public async Task Add(Student student)
        {
            dataContext_.Students.Add(student);
            await dataContext_.SaveChangesAsync();
        }
        public async Task Update(Student student, int id)
        {
            Student studentToUpdate = await dataContext_.Students.FindAsync(id);
            studentToUpdate.Student_Fio = student.Student_Fio;
            studentToUpdate.Group_Number = student.Group_Number;
            await dataContext_.SaveChangesAsync();
        }
        public async Task Delete(int id)
        {
            var student = await dataContext_.Students.FindAsync(id);
            dataContext_.Students.Remove(student);
            await dataContext_.SaveChangesAsync();
        }

        public async Task<Student> GetByID(int id)
        {
            var student = await dataContext_.Students.FindAsync(id);
            return student;
        }

        public async Task<int> GetGroupOfStudent(int id)
        {
            var student = await dataContext_.Students.FindAsync(id);
            return student.Group_Number;
        }

        public async Task<bool> StudentExists(int id)
        {
            return await dataContext_.Students.AnyAsync(e => e.Student_ID == id);
        }

        public async Task<List<Student>> GetAll()
        {
            return await dataContext_.Students.ToListAsync();
        }
    }
}
