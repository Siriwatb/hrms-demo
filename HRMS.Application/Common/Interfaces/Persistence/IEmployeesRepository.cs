using HRMS.Domain.Entities;

namespace HRMS.Application.Common.Interfaces.Persistence;

public interface IEmployeesRepository
{
    
    IEnumerable<Employee> GetEmployees();
    
    Employee? GetEmployeeByEmpNo(string empNo);
    
    Employee? AddEmployee(Employee employee);
    
    Employee? UpdateEmployee(Employee employee);
    
    bool DeleteEmployee(string empNo);
}