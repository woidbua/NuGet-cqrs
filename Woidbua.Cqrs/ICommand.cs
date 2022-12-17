using FluentResults;
using MediatR;

namespace Woidbua.Cqrs;

public interface ICommand : IRequest<Result>
{
}

public interface ICommand<TResponse> : IRequest<Result<TResponse>>
{
}
