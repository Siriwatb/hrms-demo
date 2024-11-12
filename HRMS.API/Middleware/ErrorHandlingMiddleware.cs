using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text.Json;

using HRMS.Application.Common.Errors;

using Microsoft.AspNetCore.Mvc;

namespace HRMS.API.Middleware;

public class ErrorHandlingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ErrorHandlingMiddleware> _logger;
    
    public ErrorHandlingMiddleware(RequestDelegate next, ILogger<ErrorHandlingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }
    
    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (NotFoundException ex)
        {   
            _logger.LogError(ex, ex.Message);
            await HandleNotfoundResouceExceptionAsync(context);
        }
        catch (BadRequestException ex)
        {
            _logger.LogError(ex, ex.Message);
            await HandleValidationExceptionAsync(context, ex.Message);
        }
        catch (Exception ex)
        {
            _logger.LogDebug("Exception caught in ErrorHandlingMiddleware");
            _logger.LogError(ex, ex.Message);
            await HandleExceptionAsync(context);
        }
    }
    
    private static Task HandleExceptionAsync(HttpContext context)
    {  
        var problemDetails = new ProblemDetails
        {
            Title = "An error occurred while processing your request.",
            Status = (int)HttpStatusCode.InternalServerError,
        };
        context.Response.StatusCode = StatusCodes.Status500InternalServerError;
        return context.Response.WriteAsJsonAsync(problemDetails);
    }
    
    private static Task HandleNotfoundResouceExceptionAsync(HttpContext context)
    {
        var problemDetails = new ProblemDetails
        {
            Title = "Resource not found.",
            Status = (int)HttpStatusCode.NotFound,
        };
        context.Response.StatusCode = StatusCodes.Status404NotFound;
        return context.Response.WriteAsJsonAsync(problemDetails);
    }
    
    private static Task HandleValidationExceptionAsync(HttpContext context, string message)
    {
        var problemDetails = new ProblemDetails
        {
            Title = "Validation error occurred.",
            Status = (int)HttpStatusCode.BadRequest,
        };
        context.Response.StatusCode = StatusCodes.Status400BadRequest;
        return context.Response.WriteAsJsonAsync(problemDetails);
    }
    
}