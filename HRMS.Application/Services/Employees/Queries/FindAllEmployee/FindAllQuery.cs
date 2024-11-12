using HRMS.Application.Services.Employees.Common;

using MediatR;

namespace HRMS.Application.Services.Employees.Queries.FindAllEmployee;

public record FindAllQuery(): IRequest<IEnumerable<EmployeeResult>>;