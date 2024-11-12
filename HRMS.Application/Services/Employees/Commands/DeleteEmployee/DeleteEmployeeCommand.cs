using MediatR;

namespace HRMS.Application.Services.Employees.Commands.DeleteEmployee;

public record DeleteEmployeeCommand(string EmpNo
) : IRequest<bool>;