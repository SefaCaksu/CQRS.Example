using System;
using CQRS.Example.Manual_CQRS.Queries.Requests;
using CQRS.Example.Manual_CQRS.Queries.Responses;
using CQRS.Example.Models;

namespace CQRS.Example.Manual_CQRS.Handlers.QueryHandler
{
    public class GetAllProductQueryHandler
    {
        public List<GetAllProductQueryResponse> GetAllProduct(GetAllProductQueryRequest request)
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

