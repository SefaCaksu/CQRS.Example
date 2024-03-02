using CQRS.Example.MediatR_CQRS.Commands.Requests;
using CQRS.Example.MediatR_CQRS.Queries.Requests;
using CQRS.Example.MediatR_CQRS.Queries.Responses;
using CQRS.Example.MediatR_CQRS.Commands.Responses;

using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CQRS.Example.Controllers
{
    [Route("api/[controller]")]
    public class ProductMediatRController : Controller
    {
        readonly IMediator _mediator;
        public ProductMediatRController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllProductQueryRequest request)
        {
            List<GetAllProductQueryResponse> result = await _mediator.Send(request);
            return Ok(result);
        }

        [HttpGet("{ProductId}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdProductRequest request)
        {
            GetByIdProductResponse result = await _mediator.Send(request);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateProductCommendRequest request)
        {
            CreateProductCommendResponse result = await _mediator.Send(request);
            return Ok(result);
        }

        [HttpDelete("{ProductId}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteProductCommendRequest request)
        {
            DeleteProductCommendResponse result = await _mediator.Send(request);
            return Ok(result);
        }
    }
}

