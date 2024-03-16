using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ReactAspCrud1.Model
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=StudentDB;Integrated Security=True; TrustServerCertificate=True");
        }
    }
}
