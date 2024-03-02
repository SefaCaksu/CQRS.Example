

using CQRS.Example.MediatR_CQRS.Queries.Requests;
using CQRS.Example.MediatR_CQRS.Queries.Responses;
using CQRS.Example.Models;
using MediatR;

namespace CQRS.Example.MediatR_CQRS.Handlers.QueryHandler
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, List<GetAllProductQueryResponse>>
    {
        public async Task<List<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            return ApplicationDbContext.ProductList.Select(c => new GetAllProductQueryResponse
            {
                Id = c.Id,
                CreateTime = c.CreateTime,
                Name = c.Name,
                Price = c.Price,
                Quantity = c.Quantity
            }).ToList();
        }
    }
}

