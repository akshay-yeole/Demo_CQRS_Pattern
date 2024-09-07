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
    }
}
