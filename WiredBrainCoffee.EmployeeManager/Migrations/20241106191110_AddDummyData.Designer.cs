﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WiredBrainCoffee.EmployeeManager.Data;

#nullable disable

namespace WiredBrainCoffee.EmployeeManager.Migrations
{
    [DbContext(typeof(EmployeeManagerDbContext))]
    [Migration("20241106191110_AddDummyData")]
    partial class AddDummyData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WiredBrainCoffee.EmployeeManager.Data.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "IT"
                        },
                        new
                        {
                            Id = 2,
                            Name = "HR"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sales"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Marketing"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Financial"
                        });
                });

            modelBuilder.Entity("WiredBrainCoffee.EmployeeManager.Data.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DepartmentId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeveloper")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentId = 3,
                            FirstName = "Jane",
                            IsDeveloper = false,
                            LastName = "Smith"
                        },
                        new
                        {
                            Id = 2,
                            DepartmentId = 2,
                            FirstName = "John",
                            IsDeveloper = true,
                            LastName = "Johnson"
                        },
                        new
                        {
                            Id = 3,
                            DepartmentId = 4,
                            FirstName = "Mary",
                            IsDeveloper = false,
                            LastName = "Williams"
                        },
                        new
                        {
                            Id = 4,
                            DepartmentId = 1,
                            FirstName = "Jack",
                            IsDeveloper = true,
                            LastName = "Davis"
                        },
                        new
                        {
                            Id = 5,
                            DepartmentId = 5,
                            FirstName = "Mary",
                            IsDeveloper = false,
                            LastName = "Brown"
                        },
                        new
                        {
                            Id = 6,
                            DepartmentId = 2,
                            FirstName = "Bob",
                            IsDeveloper = false,
                            LastName = "Miller"
                        },
                        new
                        {
                            Id = 7,
                            DepartmentId = 3,
                            FirstName = "Alice",
                            IsDeveloper = true,
                            LastName = "Wilson"
                        },
                        new
                        {
                            Id = 8,
                            DepartmentId = 4,
                            FirstName = "Tom",
                            IsDeveloper = false,
                            LastName = "Anderson"
                        },
                        new
                        {
                            Id = 9,
                            DepartmentId = 1,
                            FirstName = "Sarah",
                            IsDeveloper = true,
                            LastName = "Taylor"
                        },
                        new
                        {
                            Id = 10,
                            DepartmentId = 5,
                            FirstName = "David",
                            IsDeveloper = false,
                            LastName = "Thompson"
                        },
                        new
                        {
                            Id = 11,
                            DepartmentId = 2,
                            FirstName = "Emily",
                            IsDeveloper = true,
                            LastName = "Garcia"
                        },
                        new
                        {
                            Id = 12,
                            DepartmentId = 3,
                            FirstName = "Michael",
                            IsDeveloper = false,
                            LastName = "Hernandez"
                        },
                        new
                        {
                            Id = 13,
                            DepartmentId = 4,
                            FirstName = "Jessica",
                            IsDeveloper = true,
                            LastName = "Gonzalez"
                        },
                        new
                        {
                            Id = 14,
                            DepartmentId = 5,
                            FirstName = "Christopher",
                            IsDeveloper = false,
                            LastName = "Diaz"
                        },
                        new
                        {
                            Id = 15,
                            DepartmentId = 1,
                            FirstName = "Olivia",
                            IsDeveloper = true,
                            LastName = "Reyes"
                        },
                        new
                        {
                            Id = 16,
                            DepartmentId = 2,
                            FirstName = "William",
                            IsDeveloper = false,
                            LastName = "Morales"
                        });
                });

            modelBuilder.Entity("WiredBrainCoffee.EmployeeManager.Data.Models.Employee", b =>
                {
                    b.HasOne("WiredBrainCoffee.EmployeeManager.Data.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("WiredBrainCoffee.EmployeeManager.Data.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}