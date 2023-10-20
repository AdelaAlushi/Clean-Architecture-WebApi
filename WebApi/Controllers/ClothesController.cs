using Application.Features.Clothes.ClothesComands;
using Application.Features.Clothes.ClothesQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiVersion("2.0")]
    [ApiController]
    public class ClothesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClothesController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("GetClothes")]
        public async Task<IActionResult> ClothesList([FromQuery] GetClothes query)
        {
            GetClothesResponse response = await _mediator.Send(query);
            return Ok(response);
        }

        [HttpGet("GetClothesById")]
        public async Task<IActionResult> GetProductById([FromQuery] GetClothesById query)
        {
            GetClothesByIdResponse response = await _mediator.Send(query);
            return Ok(response);
        }

        [HttpPost("CreateClothes")]
        public async Task<IActionResult> CreateClothes([FromBody] CreateClothes query)
        {
            CreateClothesResponse response = await _mediator.Send(query);
            return Ok(response);
        }
        [HttpPut("UpdateClothes")]
        public async Task<IActionResult> UpdateProduct([FromBody] UpdateClothes query)
        {
            UpdateClothesResponse response = await _mediator.Send(query);
            return Ok(response);
        }
        [HttpDelete("RemoveClothes")]
        public async Task<IActionResult> RemoveProduct([FromQuery] DeleteCommand query)
        {
            DeleteCommandResponse response = await _mediator.Send(query);
            return Ok(response);
        }
    }
}
