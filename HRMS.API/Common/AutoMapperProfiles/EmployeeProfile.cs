using AutoMapper;

using HRMS.Application.Services.Employees.Commands.AddEmployee;
using HRMS.Application.Services.Employees.Commands.UpdateEmployee;
using HRMS.Application.Services.Employees.Common;
using HRMS.Contracts.Employees;
using HRMS.Domain.Entities;

namespace HRMS.API.Common.AutoMapperProfiles;

public class EmployeeProfile : Profile
{
    public EmployeeProfile()
    {
        CreateMap<Employee, EmployeeResult>();
        CreateMap<Employee, AddEmployeeCommand>();
        CreateMap<AddEmployeeRequest, AddEmployeeCommand>();
        CreateMap<EmployeeResult, EmployeeResponse>();
        CreateMap<UpdateEmployeeRequest, UpdateEmployeeCommand>().ForCtorParam("EmpNo", opt => opt.MapFrom(src => string.Empty));
    }
}