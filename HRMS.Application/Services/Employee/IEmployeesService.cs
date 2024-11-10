namespace HRMS.Application.Services.Employee;

public interface IEmployeesService
{
    EmployeeResult GetEmployeeByEmpNo(string empNo);
    EmployeeResult AddEmployee(string empNo, string firstName, string lastName, string designation, DateTime hireDate, Decimal salary, Decimal comm, string deptNo);
}