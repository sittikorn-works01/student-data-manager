using Microsoft.EntityFrameworkCore;
using studentDataWebApp.Models;

namespace studentDataWebApp.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             base.OnModelCreating(modelBuilder);

            // This automatically injects starter faculties into the database
            modelBuilder.Entity<Faculty>().HasData(
                new Faculty { Id = 1, FacultyName = "สำนักวิชาแพทยศาสตร์" },
                new Faculty { Id = 2, FacultyName = "สำนักวิชาวิศวกรรมศาสตร์และเทคโนโลยี" },
                new Faculty { Id = 3, FacultyName = "สำนักวิชาสารสนเทศศาสตร์" },
                new Faculty { Id = 4, FacultyName = "สำนักวิชาศึกษาศาสตร์" }
            );
        }
    }
    
}
