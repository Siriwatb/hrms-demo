namespace HRMS.Application.Services.Employees.Common;

public record EmployeeResult(
    string EmpNo,
    string FirstName,
    string LastName,
    string Designation,
    DateTime HireDate,
    Decimal Salary,
    Decimal Comm,
    string DeptNo
);
