using System;
using CQRS.Example.MediatR_CQRS.Queries.Responses;
using MediatR;

namespace CQRS.Example.MediatR_CQRS.Queries.Requests
{
	public class GetByIdProductRequest : IRequest<GetByIdProductResponse>
	{
        public Guid ProductId { get; set; }

    }
}

