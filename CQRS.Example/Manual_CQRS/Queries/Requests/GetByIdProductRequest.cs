using System;
namespace CQRS.Example.Manual_CQRS.Queries.Requests
{
    public class GetByIdProductRequest
    {
        public Guid ProductId { get; set; }
    }
}

