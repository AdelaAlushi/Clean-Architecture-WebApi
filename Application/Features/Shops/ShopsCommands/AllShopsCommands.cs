using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Shops.ShopsCommands
{
    public class CreateShops : IRequest<CreateShopResponse>
    {
        public string ShopId { get; set; }

        public string ShopName { get; set; }

        public string ShopAddress { get; set; }

    }
    public class CreateShopResponse
    {

    }

    public class UpdateShops : IRequest<UpdateShopResponse>
    {
        public string ShopId { get; set; }

        public string ShopName { get; set; }

        public string ShopAddress { get; set; }

    }
    public class UpdateShopResponse
    {
        public string ResponseMsg { get; set; }
    }

    public class DeleteCommand : IRequest<DeleteCommandResponse>
    {
        public string Id { get; set; }
    }
    public class DeleteCommandResponse
    {

    }
    public class GetShopsById : IRequest<GetShopsById>
    {
        public string ShopId { get; set; }

    }
}
