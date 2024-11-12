namespace HRMS.Domain.Entities;

public class Employee
{
    public string EmpNo { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Designation { get; set; } = null!;
    public DateTime HireDate { get; set; }
    public Decimal Salary { get; set; }
    public Decimal Comm { get; set; }
    public string DeptNo { get; set; }= null!;
} 