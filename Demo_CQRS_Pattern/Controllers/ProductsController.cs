using Demo_CQRS_Pattern.Quries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Demo_CQRS_Pattern.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ISender _sender;

        public ProductsController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet("", Name = "GetProducts")]
        public async Task<IActionResult> GetProductsAsync() {
            var query = new GetProductsQuery();
            var result = await _sender.Send(query); 
            return Ok(result);
        }

        [HttpGet("{id}", Name ="GetProductById")]
        public async Task<IActionResult> GetProductsAsync(int id)
        {
            var query = new GetProductsById(id);
            var result = await _sender.Send(query);
            return Ok(result);
        }
    }
}
