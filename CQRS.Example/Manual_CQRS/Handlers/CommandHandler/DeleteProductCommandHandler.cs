using CQRS.Example.Manual_CQRS.Commands.Requests;
using CQRS.Example.Manual_CQRS.Commands.Responses;
using CQRS.Example.Models;

namespace CQRS.Example.Manual_CQRS.Handlers.CommandHandler
{
    public class DeleteProductCommandHandler
    {
        public DeleteProductCommendResponse DeleteProduct(DeleteProductCommendRequest request)
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

