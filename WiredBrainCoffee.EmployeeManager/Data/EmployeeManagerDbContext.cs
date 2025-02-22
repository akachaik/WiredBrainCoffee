
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
                new Department { Id = 1, Name = "IT"          },
                new Department { Id = 2, Name = "HR"          },
                new Department { Id = 3, Name = "Sales"       },
                new Department { Id = 4, Name = "Marketing"   },
                new Department { Id = 5, Name = "Financial"   },
                new Department { Id = 6, Name = "Maintenance" }
            );

        modelBuilder.Entity<Employee>()
            .HasData(
                new Employee { Id =  1, FirstName = "Jane"       , LastName = "Smith"    , DepartmentId = 3, IsDeveloper = false },
                new Employee { Id =  2, FirstName = "John"       , LastName = "Johnson"  , DepartmentId = 2, IsDeveloper = true  },
                new Employee { Id =  3, FirstName = "Mary"       , LastName = "Williams" , DepartmentId = 4, IsDeveloper = false },
                new Employee { Id =  4, FirstName = "Jack"       , LastName = "Davis"    , DepartmentId = 1, IsDeveloper = true  },
                new Employee { Id =  5, FirstName = "Mary"       , LastName = "Brown"    , DepartmentId = 5, IsDeveloper = false },
                new Employee { Id =  6, FirstName = "Bob"        , LastName = "Miller"   , DepartmentId = 2, IsDeveloper = false },
                new Employee { Id =  7, FirstName = "Alice"      , LastName = "Wilson"   , DepartmentId = 3, IsDeveloper = true  },
                new Employee { Id =  8, FirstName = "Tom"        , LastName = "Anderson" , DepartmentId = 4, IsDeveloper = false },
                new Employee { Id =  9, FirstName = "Sarah"      , LastName = "Taylor"   , DepartmentId = 1, IsDeveloper = true  },
                new Employee { Id = 10, FirstName = "David"      , LastName = "Thompson" , DepartmentId = 5, IsDeveloper = false },
                new Employee { Id = 11, FirstName = "Emily"      , LastName = "Garcia"   , DepartmentId = 2, IsDeveloper = true  },
                new Employee { Id = 12, FirstName = "Michael"    , LastName = "Hernandez", DepartmentId = 3, IsDeveloper = false },
                new Employee { Id = 13, FirstName = "Jessica"    , LastName = "Gonzalez" , DepartmentId = 4, IsDeveloper = true  },
                new Employee { Id = 14, FirstName = "Christopher", LastName = "Diaz"     , DepartmentId = 5, IsDeveloper = false },
                new Employee { Id = 15, FirstName = "Olivia"     , LastName = "Reyes"    , DepartmentId = 1, IsDeveloper = true  },
                new Employee { Id = 16, FirstName = "William"    , LastName = "Morales"  , DepartmentId = 2, IsDeveloper = false },
                new Employee { Id = 17, FirstName = "Scott"      , LastName = "Gu"       , DepartmentId = 1, IsDeveloper = true  }
            );

    }
}

