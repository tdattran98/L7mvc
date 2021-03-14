// tinfo200:[2021-03-10-dattr98-dykstra1] - Added the DbContext database context class 
using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    // tinfo200:[2021-03-10-dattr98-dykstra1] - Inherit from DbContext database context class
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        //tinfo200:[2021-03-10-dattr98-dykstra1] - Dbset<> methods set a database table consists of 3 entity from 3 classes: Student,Enrollment and Course.
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        //tinfo200:[2021-03-10-dattr98-dykstra1] - Create tables with the same names as Dbset get/set properties.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}