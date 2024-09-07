using Demo_CQRS_Pattern.Commands;
using Demo_CQRS_Pattern.Notifications;
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
        public async Task<IActionResult> GetProductsAsync()
        {
            var query = new GetProductsQuery();
            var result = await _sender.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}", Name = "GetProductById")]
        public async Task<IActionResult> GetProductsAsync(int id)
        {
            var query = new GetProductsById(id);
            var result = await _sender.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddProductsAsync(Product product)
        {
            var query = new AddProductCommand(product);
            var result = await _sender.Send(query);

            return CreatedAtRoute("GetProductById", new { id = result.Id }, result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProductAsync(int id, [FromBody] string productName)
        {
            var query = new UpdateProductCommand(id, productName);
            await _sender.Send(query);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductAsync(int id)
        {
            var query = new DeleteProductCommand(id);
            await _sender.Send(query);
            return NoContent();
        }
    }
}
