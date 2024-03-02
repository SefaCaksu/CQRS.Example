using CQRS.Example.Manual_CQRS.Commands.Requests;
using CQRS.Example.Manual_CQRS.Handlers.CommandHandler;
using CQRS.Example.Manual_CQRS.Handlers.QueryHandler;
using CQRS.Example.Manual_CQRS.Queries.Requests;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CQRS.Example.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        readonly CreateProductCommandHandler _createProductCommandHandler;
        readonly DeleteProductCommandHandler _deleteProductCommandHandler;
        readonly GetAllProductQueryHandler _getAllProductQueryHandler;
        readonly GetByIdProductQueryHandler _getByIdProductQueryHandler;

        public ProductController(CreateProductCommandHandler createProductCommandHandler, DeleteProductCommandHandler deleteProductCommandHandler, GetAllProductQueryHandler getAllProductQueryHandler, GetByIdProductQueryHandler getByIdProductQueryHandler)
        {
            _createProductCommandHandler = createProductCommandHandler;
            _deleteProductCommandHandler = deleteProductCommandHandler;
            _getAllProductQueryHandler = getAllProductQueryHandler;
            _getByIdProductQueryHandler = getByIdProductQueryHandler;
        }

        //[HttpGet]
        //public IActionResult Get([FromQuery] GetAllProductQueryRequest request)
        //{
        //    var response = _getAllProductQueryHandler.GetAllProduct(request);
        //    return Ok(response);
        //}

        //[HttpGet("{ProductId}")]
        //public IActionResult Get([FromRoute] GetByIdProductRequest request)
        //{
        //    var response = _getByIdProductQueryHandler.GetByIdProduct(request);
        //    return Ok(response);
        //}

        //[HttpPost]
        //public IActionResult Post([FromBody] CreateProductCommendRequest request)
        //{
        //    var response = _createProductCommandHandler.CreateProduct(request);
        //    return Ok(response);
        //}

        //[HttpDelete("{ProductId}")]
        //public IActionResult Delete([FromRoute] DeleteProductCommendRequest request)
        //{
        //    var response = _deleteProductCommandHandler.DeleteProduct(request);
        //    return Ok(response);
        //}
    }
}

