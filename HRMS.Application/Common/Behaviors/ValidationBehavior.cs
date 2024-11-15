using System.Net.Http.Json;

using FluentValidation;

using HRMS.Application.Common.Errors;

using MediatR;

namespace HRMS.Application.Common.Behaviors;

public class ValidationBehavior<TRequest,TResponse> : IPipelineBehavior<TRequest,TResponse>
{
    private readonly IValidator<TRequest>? _validator;

    public ValidationBehavior(IValidator<TRequest>? validator)
    {
        _validator = validator;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        if (_validator == null)
        {
            return await next();
        }

        var validationResult = await _validator.ValidateAsync(request, cancellationToken);

        if (validationResult.IsValid)
        {
            return await next();
        }

        var errors = validationResult.Errors;
        
        
        throw new BadRequestException();
    }
}