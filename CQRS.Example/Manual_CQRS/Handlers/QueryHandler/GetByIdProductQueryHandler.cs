using System;
using CQRS.Example.Manual_CQRS.Queries.Requests;
using CQRS.Example.Manual_CQRS.Queries.Responses;
using CQRS.Example.Models;
namespace CQRS.Example.Manual_CQRS.Handlers.QueryHandler
{
    public class GetByIdProductQueryHandler
    {
        public GetByIdProductResponse GetByIdProduct(GetByIdProductRequest request)
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

