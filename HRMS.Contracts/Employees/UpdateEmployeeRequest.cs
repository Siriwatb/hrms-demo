namespace HRMS.Contracts.Employees;

public record UpdateEmployeeRequest(
    string FirstName,
    string LastName,
    string Designation,
    DateTime HireDate,
    Decimal Salary,
    Decimal Comm,
    string DeptNo
    );