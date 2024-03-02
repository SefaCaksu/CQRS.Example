using System;
using CQRS.Example.MediatR_CQRS.Commands.Responses;
using MediatR;

namespace CQRS.Example.MediatR_CQRS.Commands.Requests
{
	public class DeleteProductCommendRequest : IRequest<DeleteProductCommendResponse>
    {
        public Guid ProductId { get; set; }
    }
}

