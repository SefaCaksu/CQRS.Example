using System;
using CQRS.Example.MediatR_CQRS.Queries.Requests;
using CQRS.Example.MediatR_CQRS.Queries.Responses;
using CQRS.Example.Models;
using MediatR;

namespace CQRS.Example.MediatR_CQRS.Handlers.QueryHandler
{
	public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductRequest, GetByIdProductResponse>
    {
        public async Task<GetByIdProductResponse> Handle(GetByIdProductRequest request, CancellationToken cancellationToken)
        {
            var product = ApplicationDbContext.ProductList.FirstOrDefault(c => c.Id == request.ProductId);

            return new GetByIdProductResponse
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,
                CreateTime = product.CreateTime
            };
        }
    }
}

