using System;
using CQRS.Example.MediatR_CQRS.Commands.Requests;
using CQRS.Example.MediatR_CQRS.Commands.Responses;
using CQRS.Example.Models;
using MediatR;

namespace CQRS.Example.MediatR_CQRS.Handlers.CommandHandler
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommendRequest, DeleteProductCommendResponse>
    {

        public async Task<DeleteProductCommendResponse> Handle(DeleteProductCommendRequest request, CancellationToken cancellationToken)
        {
            var product = ApplicationDbContext.ProductList.FirstOrDefault(c => c.Id == request.ProductId);

            if (product != null)
            {
                ApplicationDbContext.ProductList.Remove(product);
            }

            return new DeleteProductCommendResponse { IsSuccess = true };
        }
    }
}

