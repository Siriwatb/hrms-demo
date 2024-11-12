using HRMS.Domain.Entities;
using HRMS.Infrastructure.Persistence.Configurations;

using Microsoft.EntityFrameworkCore;

namespace HRMS.Infrastructure.Persistence;

public class EmployeesDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; } = null!;

    public EmployeesDbContext(DbContextOptions<EmployeesDbContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(EmployeesDbContext).Assembly);
    }
    
}