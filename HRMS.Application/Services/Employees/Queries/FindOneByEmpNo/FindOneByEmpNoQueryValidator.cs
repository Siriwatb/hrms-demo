using FluentValidation;

namespace HRMS.Application.Services.Employees.Queries.FindOneByEmpNo;

public class FindOneByEmpNoQueryValidator : AbstractValidator<FindOneByEmpNoQuery>
{
    public FindOneByEmpNoQueryValidator()
    {
        RuleFor(x => x.EmpNo).NotEmpty();
    }
}