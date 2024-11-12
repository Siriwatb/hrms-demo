using HRMS.Application.Services.Employees.Common;

using MediatR;

namespace HRMS.Application.Services.Employees.Commands.AddEmployee;

public record AddEmployeeCommand(
    string EmpNo,
    string FirstName,
    string LastName,
    string Designation,
    DateTime HireDate,
    Decimal Salary,
    Decimal Comm,
    string DeptNo
    ): IRequest<EmployeeResult>;