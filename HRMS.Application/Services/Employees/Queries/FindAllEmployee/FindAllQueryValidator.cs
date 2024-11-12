using FluentValidation;

using HRMS.Application.Services.Employees.Queries.FindOneByEmpNo;

namespace HRMS.Application.Services.Employees.Queries.FindAllEmployee;

public class FindAllQueryValidator : AbstractValidator<FindAllQuery>
{
    public FindAllQueryValidator()
    {
        
    }
}