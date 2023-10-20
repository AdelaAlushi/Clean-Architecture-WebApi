using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Application.Features.Shops.ShopsQueries.AllShopQueries;

namespace Application.Features.Shops.ShopsQueries
{
    public class AllShopQueries
    {

        public class GetShops : IRequest<GetShopsResponse>
        {

        }
        public class GetShopsResponse
        {
            public object Shops { get; set; }
        }

       
        public class GetShopById : IRequest<GetShopsByIdResponse>
        {
            public string ShopId { get; set; }
        }
        public class GetShopsByIdResponse
        {
            public object Shops { get; set; }
        }

        public class GetShopMapper
        {
            public string ShopId { get; set; }
            public string ShopName { get; set; }
            public string Location { get; set; }

        }
    }
}
