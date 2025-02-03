using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class classroomDb: DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Pupil> Pupils { get; set; }
        public DbSet<TeacherPupil> TeacherPupils { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
           
            options.UseSqlite("Data Source=school.db");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the many-to-many relationship
            modelBuilder.Entity<TeacherPupil>()
                .HasKey(tp => new { tp.TeacherId, tp.PupilId });

            modelBuilder.Entity<TeacherPupil>()
                .HasOne(tp => tp.Teacher)
                .WithMany(t => t.TeacherPupils)
                .HasForeignKey(tp => tp.TeacherId);

            modelBuilder.Entity<TeacherPupil>()
                .HasOne(tp => tp.Pupil)
                .WithMany(p => p.TeacherPupils)
                .HasForeignKey(tp => tp.PupilId);
        }
    }
}
