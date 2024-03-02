using System;
using CQRS.Example.MediatR_CQRS.Commands.Requests;
using CQRS.Example.MediatR_CQRS.Commands.Responses;
using CQRS.Example.Models;
using MediatR;

namespace CQRS.Example.MediatR_CQRS.Handlers.CommandHandler
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommendRequest, CreateProductCommendResponse>
    {

        public async Task<CreateProductCommendResponse> Handle(CreateProductCommendRequest request, CancellationToken cancellationToken)
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

