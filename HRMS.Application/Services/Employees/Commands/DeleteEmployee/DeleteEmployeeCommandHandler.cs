using HRMS.Application.Common.Errors;
using HRMS.Application.Common.Interfaces.Persistence;

using MediatR;

namespace HRMS.Application.Services.Employees.Commands.DeleteEmployee;

public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand, bool>
{
    private readonly IEmployeesRepository _employeesRepository;

    public DeleteEmployeeCommandHandler(IEmployeesRepository employeesRepository)
    {
        _employeesRepository = employeesRepository;
    }

    public Task<bool> Handle(DeleteEmployeeCommand command, CancellationToken cancellationToken)
    {
        var employee = _employeesRepository.GetEmployeeByEmpNo(command.EmpNo);
        if (employee == null)
        {
            throw new NotFoundException();
        }
        
        var result = _employeesRepository.DeleteEmployee(command.EmpNo);
        if (!result)
        {
            throw new Exception("Delete employee failed");
        }

        return Task.FromResult(result);
    }
}