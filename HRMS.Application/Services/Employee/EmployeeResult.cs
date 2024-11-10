namespace HRMS.Application.Services.Employee;

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
