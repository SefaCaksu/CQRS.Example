using System;
namespace CQRS.Example.MediatR_CQRS.Commands.Responses
{
	public class CreateProductCommendResponse
    {
		
		public Guid ProductId { get; set; }
        public bool IsSuccess { get; set; }
    }
}

