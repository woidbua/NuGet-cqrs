using FluentResults;
using MediatR;

namespace Woidbua.Cqrs;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}
