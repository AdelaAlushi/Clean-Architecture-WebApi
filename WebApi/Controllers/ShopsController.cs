using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Application.Features.Shops.ShopsQueries.AllShopQueries;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
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

        
       
    }
}
