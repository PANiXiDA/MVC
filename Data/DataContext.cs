using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TestMVC.Models;

namespace TestMVC.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Group> Groups { get; set; } = null!;
        public DbSet<Lesson> Lessons { get; set; } = null!;
        public DbSet<Teacher> Teachers { get; set; } = null!;
        public DbSet<Classroom> Classrooms { get; set; } = null!;
    }
}
