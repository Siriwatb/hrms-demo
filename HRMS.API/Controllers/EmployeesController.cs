using AutoMapper;

using HRMS.Application.Services.Employees.Commands.AddEmployee;
using HRMS.Application.Services.Employees.Commands.DeleteEmployee;
using HRMS.Application.Services.Employees.Commands.UpdateEmployee;
using HRMS.Application.Services.Employees.Queries.FindAllEmployee;
using HRMS.Application.Services.Employees.Queries.FindOneByEmpNo;
using HRMS.Contracts.Employees;

using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace HRMS.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public EmployeesController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<EmployeeResponse>), 200)]
    public async Task<IActionResult> GetEmployees()
    {
        var query = new FindAllQuery();
        var employees = await _mediator.Send(query);

        var response = employees.Select(e => _mapper.Map<EmployeeResponse>(e));

        return Ok(response);
    }

    [HttpGet("{empNo}")]
    [ProducesResponseType(typeof(EmployeeResponse), 200)]
    public async Task<IActionResult> GetEmployeeByEmpNo(string empNo)
    {
        var query = new FindOneByEmpNoQuery(empNo);
        var employee = await _mediator.Send(query);
        var response = _mapper.Map<EmployeeResponse>(employee);
        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(EmployeeResponse), 201)]
    public async Task<IActionResult> AddEmployee(AddEmployeeRequest request)
    {
        var command = _mapper.Map<AddEmployeeCommand>(request);

        var result = await _mediator.Send(command);

        var response = _mapper.Map<EmployeeResponse>(result);

        return Created("", response);
    }

    [HttpPut("{empNo}")]
    [ProducesResponseType( 204)]
    public async Task<IActionResult> UpdateEmployee(string empNo , [FromBody]UpdateEmployeeRequest request)
    {
        var command = _mapper.Map<UpdateEmployeeCommand>(request);
        command = command with { EmpNo = empNo };
        await _mediator.Send(command);

        return NoContent();
    }
    
    [HttpDelete("{empNo}")]
    [ProducesResponseType(204)]
    public async Task<IActionResult> DeleteEmployee(string empNo)
    {
        var command = new DeleteEmployeeCommand(empNo);
        await _mediator.Send(command);
        return NoContent();
    }
}