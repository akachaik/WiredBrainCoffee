
using Microsoft.EntityFrameworkCore;
using WiredBrainCoffee.EmployeeManager.Data.Models;

namespace WiredBrainCoffee.EmployeeManager.Data;

public class EmployeeManagerDbContext : DbContext
{
    public EmployeeManagerDbContext(DbContextOptions<EmployeeManagerDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<Department> Departments => Set<Department>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Department>()
            .HasData(
                new Department { Id = 1, Name = "IT" },
                new Department { Id = 2, Name = "HR" },
                new Department { Id = 3, Name = "Sales" },
                new Department { Id = 4, Name = "Marketing" },
                new Department { Id = 5, Name = "Financial" }
            );

        modelBuilder.Entity<Employee>()
            .HasData(
                new Employee { Id = 1, FirstName = "Jane", LastName = "Doe", DepartmentId = 1 },
                new Employee { Id = 2, FirstName = "John", LastName = "Doe", DepartmentId = 3, IsDeveloper = true},
                new Employee { Id = 3, FirstName = "Mary", LastName = "Doe", DepartmentId = 2 },
                new Employee { Id = 4, FirstName = "Jack", LastName = "Doe", DepartmentId = 2 , IsDeveloper = true},
                new Employee { Id = 5, FirstName = "Mary", LastName = "Doe", DepartmentId = 1 }
            );
    }
}

