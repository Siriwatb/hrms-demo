using HRMS.Application.Common.Interfaces.Persistence;
using HRMS.Domain;

namespace HRMS.Infrastructure.Persistence;

public class EmployeesRepository : IEmployeesRepository
{
    private readonly List<Employee> _employees = new();
    
    public Employee? GetEmployeeByEmpNo(string empNo)
    {
        return _employees.SingleOrDefault(e=> e.EmpNo == empNo);
    }

    public void AddEmployee(Employee employee)
    {
        _employees.Add(employee);
    }
}