using HRMS.Application.Common.Interfaces.Persistence;
using HRMS.Application.Services.Employees.Common;
using HRMS.Domain.Entities;

using MediatR;

namespace HRMS.Application.Services.Employees.Commands.AddEmployee;

public class AddEmployeeCommandHandler : IRequestHandler<AddEmployeeCommand,EmployeeResult>
{
    private readonly IEmployeesRepository _employeesRepository;

    public AddEmployeeCommandHandler(IEmployeesRepository employeesRepository)
    {
        _employeesRepository = employeesRepository;
    }

    public Task<EmployeeResult> Handle(AddEmployeeCommand command, CancellationToken cancellationToken)
    {
        var employee = new Employee
        {
            EmpNo = command.EmpNo,
            FirstName = command.FirstName,
            LastName = command.LastName,
            Designation = command.Designation,
            HireDate = command.HireDate,
            Salary = command.Salary,
            Comm = command.Comm,
            DeptNo = command.DeptNo
        };
        var result = _employeesRepository.AddEmployee(employee);
        if (result != null)
        {
            return Task.FromResult(new EmployeeResult(
                result.EmpNo,
                result.FirstName,
                result.LastName,
                result.Designation,
                result.HireDate,
                result.Salary,
                result.Comm,
                result.DeptNo));
        }

        throw new Exception("Add employee failed");
    }
}