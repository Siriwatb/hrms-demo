using HRMS.Application.Services.Employees.Common;

using MediatR;

namespace HRMS.Application.Services.Employees.Queries.FindOneByEmpNo;

public record FindOneByEmpNoQuery(
    string EmpNo
    ): IRequest<EmployeeResult>;