using FlagHunter.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace FlagHunter.Api
{
    public class FlagHunterDbContext : DbContext
    {
        public FlagHunterDbContext(DbContextOptions<FlagHunterDbContext> options) : base(options) {}
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<StudentTest> StudentTests { get; set; }
        public DbSet<Test> Tests { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<StudentTest>()
                .HasKey(sc => new { sc.StudentId, sc.TestId });
            modelBuilder.Entity<StudentTest>()
                .HasOne(s => s.Student)
                .WithMany(c => c.StudentTests)
                .HasForeignKey(s => s.StudentId);
            modelBuilder.Entity<StudentTest>()
                .HasOne(c => c.Test)
                .WithMany(s => s.StudentTests)
                .HasForeignKey(c => c.TestId);

            modelBuilder.Entity<Course>().HasOne(c => c.Teacher).WithMany(t => t.Courses);
            modelBuilder.Entity<Test>().HasOne(t => t.Course).WithMany(c => c.Tests);

            modelBuilder.FlagHunterDbSeed();
        }
    }
}
