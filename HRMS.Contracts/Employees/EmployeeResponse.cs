namespace HRMS.Contracts.Employees;

public record EmployeeResponse(
    string EmpNo,
    string FirstName,
    string LastName,
    string Designation,
    DateTime HireDate,
    Decimal Salary,
    Decimal Comm,
    string DeptNo
    );