using FluentValidation;

namespace HRMS.Application.Services.Employees.Commands.AddEmployee;

public class AddEmployeeCommandValidator : AbstractValidator<AddEmployeeCommand>
{
    public AddEmployeeCommandValidator()
    {
        RuleFor(x => x.EmpNo).NotEmpty();
        RuleFor(x => x.FirstName).NotEmpty();
        RuleFor(x => x.LastName).NotEmpty();
        RuleFor(x => x.Designation).NotEmpty();
        RuleFor(x => x.HireDate).NotEmpty();
        RuleFor(x => x.Salary).NotEmpty();
        RuleFor(x => x.Comm);
        RuleFor(x => x.DeptNo).NotEmpty();
    }
}