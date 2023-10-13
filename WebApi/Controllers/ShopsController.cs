using Application.Features.Shops.ShopsCommands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Application.Features.Shops.ShopsQueries.AllShopQueries;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiVersion("2.0")]
    [ApiController]
    public class ShopsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ShopsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("GetShops")]
        public async Task<IActionResult> ShopsList([FromQuery] GetShops query)
        {
            GetShopsResponse response = await _mediator.Send(query);
            return Ok(response);
        }

        [HttpPost("CreateShops")]
        public async Task<IActionResult> CreateShop([FromBody] CreateShops query)
        {
            CreateShopResponse response = await _mediator.Send(query);
            return Ok(response);
        }
        [HttpPut("UpdateShops")]
        public async Task<IActionResult> UpdateShop([FromBody] UpdateShops query)
        {
            UpdateShopResponse response = await _mediator.Send(query);
            return Ok(response);
        }
        [HttpDelete("DeleteShops")]
        public async Task<IActionResult> RemoveShop([FromQuery] DeleteCommand query)
        {
            DeleteCommandResponse response = await _mediator.Send(query);
            return Ok(response);
        }

    }
}
