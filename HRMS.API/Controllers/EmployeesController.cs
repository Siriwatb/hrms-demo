using Microsoft.AspNetCore.Mvc;

namespace HRMS.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    [HttpGet]
    public IActionResult GetEmployees()
    {
        return Ok();
    }
    
    [HttpGet("{empNo}")]
    public IActionResult GetEmployeeByEmpNo(string empNo)
    {
        return Ok();
    }
    
    [HttpPost]
    public IActionResult AddEmployee(string empNo, string firstName, string lastName, string designation, DateTime hireDate, Decimal salary, Decimal comm, string deptNo)
    {
        return Created();
    }
}