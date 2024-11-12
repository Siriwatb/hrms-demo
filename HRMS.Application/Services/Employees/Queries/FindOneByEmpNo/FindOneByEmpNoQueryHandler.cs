using System.Reflection;

using HRMS.Application.Common.Errors;
using HRMS.Application.Common.Interfaces.Persistence;
using HRMS.Application.Services.Employees.Common;

using MediatR;

namespace HRMS.Application.Services.Employees.Queries.FindOneByEmpNo;

public class FindOneByEmpNoQueryHandler : IRequestHandler<FindOneByEmpNoQuery,EmployeeResult>
{
    private readonly IEmployeesRepository _employeesRepository;

    public FindOneByEmpNoQueryHandler(IEmployeesRepository employeesRepository)
    {
        _employeesRepository = employeesRepository;
    }

    public Task<EmployeeResult> Handle(FindOneByEmpNoQuery query, CancellationToken cancellationToken)
    {
        var employee = _employeesRepository.GetEmployeeByEmpNo(query.EmpNo);
        if (employee == null)
        {
            throw new NotFoundException();
        }
        return Task.FromResult(new EmployeeResult(
            employee.EmpNo, 
            employee.FirstName, 
            employee.LastName, 
            employee.Designation, 
            employee.HireDate, 
            employee.Salary, 
            employee.Comm, 
            employee.DeptNo));
    }
}

