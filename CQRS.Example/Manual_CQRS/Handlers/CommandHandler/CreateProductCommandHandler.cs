using System;
using CQRS.Example.Manual_CQRS.Commands.Requests;
using CQRS.Example.Manual_CQRS.Commands.Responses;
using CQRS.Example.Models;

namespace CQRS.Example.Manual_CQRS.Handlers.CommandHandler
{
    public class CreateProductCommandHandler
    {
        public CreateProductCommendResponse CreateProduct(CreateProductCommendRequest request)
        {
            var id = Guid.NewGuid();
            ApplicationDbContext.ProductList.Add(new()
            {
                Id = id,
                Name = request.Name,
                CreateTime = DateTime.Now,
                Price = request.Price,
                Quantity = request.Quantity
            });

            return new() { ProductId = id, IsSuccess = true };
        }
    }
}

