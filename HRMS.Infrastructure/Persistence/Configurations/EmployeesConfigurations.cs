using HRMS.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRMS.Infrastructure.Persistence.Configurations;

public class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("Employees");
        builder.HasKey(e => e.EmpNo);
        
        builder.HasData(
            new Employee { EmpNo = "1001", FirstName = "STEFAN", LastName = "SALVATORE", Designation = "BUSINESS ANALYST", HireDate = new DateTime(1997, 11, 17), Salary = 50000, Comm = 0, DeptNo = "40" },
            new Employee { EmpNo = "1002", FirstName = "DIANA", LastName = "LORRENCE", Designation = "TECHNICAL ARCHITECT", HireDate = new DateTime(2000, 5, 1), Salary = 70000, Comm = 0, DeptNo = "10" },
            new Employee { EmpNo = "1003", FirstName = "JAMES", LastName = "MADISON", Designation = "MANAGER", HireDate = new DateTime(1988, 6, 19), Salary = 80400, Comm = 0, DeptNo = "40" },
            new Employee { EmpNo = "1005", FirstName = "LUCY", LastName = "GELLER", Designation = "HR ASSOCIATE", HireDate = new DateTime(2008, 7, 13), Salary = 35000, Comm = 200, DeptNo = "30" },
            new Employee { EmpNo = "1006", FirstName = "ISAAC", LastName = "STEFAN", Designation = "TRAINEE", HireDate = new DateTime(2015, 12, 13), Salary = 20000, Comm = 0, DeptNo = "40" },
            new Employee { EmpNo = "1007", FirstName = "JOHN", LastName = "SMITH", Designation = "CLERK", HireDate = new DateTime(2005, 12, 17), Salary = 12000, Comm = 0, DeptNo = "10" },
            new Employee { EmpNo = "1008", FirstName = "NANCY", LastName = "GILBERT", Designation = "SALESMAN", HireDate = new DateTime(1981, 2, 20), Salary = 1600, Comm = 300, DeptNo = "10" },
            new Employee { EmpNo = "1004", FirstName = "JONES", LastName = "NICK", Designation = "HR ANALYST", HireDate = new DateTime(2003, 1, 2), Salary = 47000, Comm = 0, DeptNo = "30" }
        );
    }
}