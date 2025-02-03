﻿// <auto-generated />
using ConsoleApp4;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsoleApp4.Migrations
{
    [DbContext(typeof(classroomDb))]
    partial class classroomDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.1");

            modelBuilder.Entity("ConsoleApp4.Pupil", b =>
                {
                    b.Property<int>("PupilId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PupilId");

                    b.ToTable("Pupils");
                });

            modelBuilder.Entity("ConsoleApp4.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("ConsoleApp4.TeacherPupil", b =>
                {
                    b.Property<int>("TeacherId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PupilId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TeacherId", "PupilId");

                    b.HasIndex("PupilId");

                    b.ToTable("TeacherPupils");
                });

            modelBuilder.Entity("ConsoleApp4.TeacherPupil", b =>
                {
                    b.HasOne("ConsoleApp4.Pupil", "Pupil")
                        .WithMany("TeacherPupils")
                        .HasForeignKey("PupilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp4.Teacher", "Teacher")
                        .WithMany("TeacherPupils")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pupil");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("ConsoleApp4.Pupil", b =>
                {
                    b.Navigation("TeacherPupils");
                });

            modelBuilder.Entity("ConsoleApp4.Teacher", b =>
                {
                    b.Navigation("TeacherPupils");
                });
#pragma warning restore 612, 618
        }
    }
}
