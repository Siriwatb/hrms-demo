using HRMS.Application.Common.Interfaces.Persistence;
using HRMS.Application.Services.Employees.Common;

using MediatR;

namespace HRMS.Application.Services.Employees.Queries.FindAllEmployee;

public class FindAllQueryHandler : IRequestHandler<FindAllQuery,IEnumerable<EmployeeResult>>
{
    private readonly IEmployeesRepository _employeesRepository;

    public FindAllQueryHandler(IEmployeesRepository employeesRepository)
    {
        _employeesRepository = employeesRepository;
    }

    public Task<IEnumerable<EmployeeResult>> Handle(FindAllQuery request, CancellationToken cancellationToken)
    {
        var employees = _employeesRepository.GetEmployees();
        return Task.FromResult(employees.Select(e => new EmployeeResult(
            e.EmpNo, 
            e.FirstName, 
            e.LastName, 
            e.Designation, 
            e.HireDate, 
            e.Salary, 
            e.Comm, 
            e.DeptNo)));
    }
}