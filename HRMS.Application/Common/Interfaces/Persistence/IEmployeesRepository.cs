using HRMS.Domain;

namespace HRMS.Application.Common.Interfaces.Persistence;

public interface IEmployeesRepository
{
    Employee? GetEmployeeByEmpNo(string empNo);
    
    void AddEmployee(Employee employee);
}