using System;
using CQRS.Example.MediatR_CQRS.Queries.Responses;
using MediatR;

namespace CQRS.Example.MediatR_CQRS.Queries.Requests
{
    public class GetAllProductQueryRequest : IRequest<List<GetAllProductQueryResponse>>
    {
    }
}

