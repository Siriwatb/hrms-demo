using HRMS.Application.Common.Interfaces.Persistence;

namespace HRMS.Application.Services.Employee;

public class EmployeesService : IEmployeesService
{
    private readonly IEmployeesRepository _employeesRepository;
    
    public EmployeesService(IEmployeesRepository employeesRepository)
    {
        _employeesRepository = employeesRepository;
    }
    
    public EmployeeResult GetEmployeeByEmpNo(string empNo)
    {
        var employee = _employeesRepository.GetEmployeeByEmpNo(empNo);
        if (employee == null)
        {
            throw new Exception("Employee not found");
        }
        return new EmployeeResult(
            employee.EmpNo, 
            employee.FirstName, 
            employee.LastName, 
            employee.Designation, 
            employee.HireDate, 
            employee.Salary, 
            employee.Comm, 
            employee.DeptNo);
    }

    public EmployeeResult AddEmployee(string empNo, string firstName, string lastName, string designation, DateTime hireDate,
        decimal salary, decimal comm, string deptNo)
    {
        throw new NotImplementedException();
    }
}