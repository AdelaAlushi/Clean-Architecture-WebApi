using Application.Features;
using Application.Features.Category.CategoryCommands;
using Application.Features.Category.CategoryQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiVersion("2.0")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetCategories")]
        public async Task<IActionResult> GetCategories([FromQuery] GetCategories query)
        {
            GetCategoryResponse response = await _mediator.Send(query);
            return Ok(response);
        }

        [HttpGet("GetCategoryById")]
        public async Task<IActionResult> GetCategoryById([FromQuery] GetCategoryById query)
        {
            GetCategoryByIdResponse response = await _mediator.Send(query);
            return Ok(response);
        }

        [HttpPost("CreateCategory")]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategory query)
        {
            CreateCategoryResponse response = await _mediator.Send(query);
            return Ok(response);
        }
        [HttpPut("UpdateProduct")]
        public async Task<IActionResult> UpdateCategory([FromBody] UpdateCategory query)
        {
            UpdateCategoryResponse response = await _mediator.Send(query);
            return Ok(response);
        }
        [HttpDelete("DeleteCategory")]
        public async Task<IActionResult> DeleteCategory([FromQuery] DeleteCommand query)
        {
            DeleteCommandResponse response = await _mediator.Send(query);
            return Ok(response);
        }
    }
}
