using HRMS.Application.Common.Interfaces.Persistence;
using HRMS.Domain.Entities;

namespace HRMS.Infrastructure.Persistence.Repositories;

public class EmployeesRepository : IEmployeesRepository
{
    private readonly EmployeesDbContext _dbContext;

    public EmployeesRepository(EmployeesDbContext dbContext)
    {
        _dbContext = dbContext;
    }


    public IEnumerable<Employee> GetEmployees()
    {
        return _dbContext.Employees;
    }
    
    public Employee? GetEmployeeByEmpNo(string empNo)
    {
        return _dbContext.Employees.SingleOrDefault(e=> e.EmpNo == empNo);
    }

    public Employee? AddEmployee(Employee employee)
    {
        _dbContext.Add(employee);
        _dbContext.SaveChanges();
        return employee;
    }

    public Employee? UpdateEmployee(Employee employee)
    {
        var existingEmployee = _dbContext.Employees.SingleOrDefault(e=> e.EmpNo == employee.EmpNo);

        if (existingEmployee != null)
        {
            existingEmployee.FirstName = employee.FirstName;
            existingEmployee.LastName = employee.LastName;
            existingEmployee.Designation = employee.Designation;
            existingEmployee.HireDate = employee.HireDate;
            existingEmployee.Salary = employee.Salary;
            existingEmployee.Comm = employee.Comm;
            existingEmployee.DeptNo = employee.DeptNo;
            return existingEmployee;
        }
        
        return null;
    }

    public bool DeleteEmployee(string empNo)
    {
        var employee = _dbContext.Employees.SingleOrDefault(e=> e.EmpNo == empNo);
        if (employee == null)
        {
            return false;
        }

        _dbContext.Remove(employee);
        return true;
    }
}