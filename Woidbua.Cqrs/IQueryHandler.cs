using FluentResults;
using MediatR;

namespace Woidbua.Cqrs;

public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>
{
}
