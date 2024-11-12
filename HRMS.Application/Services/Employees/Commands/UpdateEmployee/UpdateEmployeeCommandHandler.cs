using HRMS.Application.Common.Errors;
using HRMS.Application.Common.Interfaces.Persistence;
using HRMS.Application.Services.Employees.Common;
using HRMS.Domain.Entities;

using MediatR;

namespace HRMS.Application.Services.Employees.Commands.UpdateEmployee;

public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand,EmployeeResult>
{
    private IEmployeesRepository _employeesRepository;

    public UpdateEmployeeCommandHandler(IEmployeesRepository employeesRepository)
    {
        _employeesRepository = employeesRepository;
    }

    public Task<EmployeeResult> Handle(UpdateEmployeeCommand command, CancellationToken cancellationToken)
    {
        var emp = _employeesRepository.GetEmployeeByEmpNo(command.EmpNo);
        
        if (emp == null)
        {
            throw new NotFoundException("Employee not found");
        }
        
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

       var result = _employeesRepository.UpdateEmployee(employee);

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

       throw new Exception("Edit employee failed");

    }
}