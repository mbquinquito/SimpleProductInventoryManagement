using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SimpleProductInventoryManagement.Application.Features.ProductEntity.Commands.CreateProductEntity;
using SimpleProductInventoryManagement.Application.Features.ProductEntity.Commands.DeleteProductEntity;
using SimpleProductInventoryManagement.Application.Features.ProductEntity.Commands.UpdateProductEntity;
using SimpleProductInventoryManagement.Application.Features.ProductEntity.Queries.GetAllProductEntities;
using SimpleProductInventoryManagement.Application.Features.ProductEntity.Queries.GetProductDetails;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleProductInventoryManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize] // Ensure that the controller requires authentication
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(IMediator mediator, ILogger<ProductsController> logger)
        {
            this._mediator = mediator;
            this._logger = logger;
            Console.WriteLine("=== ProductsController loaded ===");
        }
        // GET: api/<productsController>
        [HttpGet]
        public async Task<List<ProductEntityDto>> Get()
        {
            var authHeader = Request.Headers["Authorization"].FirstOrDefault();
            _logger.LogInformation("Authorization header received: {AuthHeader}", authHeader);
            var products = await _mediator.Send(new GetProductEntitiesQuery());
            return products;
        }

        // GET api/<productsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDetailsDto>> Get(int id)
        {
            var products = await _mediator.Send(new GetProductDetailsQuery(id));
            return Ok(products);
        }

        // POST api/<productsController>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Post([FromBody] CreateProductEntityCommand productEntity)
        {
            var response = await _mediator.Send(productEntity);
            return CreatedAtAction(nameof(Get), new { id = response });
        }

        // PUT api/<productsController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Put(UpdateProductEntityCommand productEntity)
        {
            await _mediator.Send(productEntity);
            return NoContent();
        }

        // DELETE api/<productsController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteProductEntityCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
