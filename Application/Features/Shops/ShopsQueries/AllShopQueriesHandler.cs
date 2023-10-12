using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Application.Features.Shops.ShopsQueries.AllShopQueries;

namespace Application.Features.Shops.ShopsQueries
{
    public class AllShopQueriesHandlers :
       IRequestHandler<GetShops, GetShopsResponse>,
       IRequestHandler<GetShopById, GetShopsByIdResponse>
       
    {
        readonly IShopRepository _shopRepo;

        public AllShopQueriesHandlers(IShopRepository shopRepo)
        {
            _shopRepo = shopRepo;
        }

        public async Task<GetShopsResponse> Handle(GetShops request, CancellationToken cancellationToken)
        {
            var shops = _shopRepo.GetAll().ToList();
            return new() { Shops = shops };
        }

        public async Task<GetShopsByIdResponse> Handle(GetShopById request, CancellationToken cancellationToken)
        {
            var shops = await _shopRepo.GetByIdAsync(request.ShopId);
            return new() { Shops = shops };
        }

    }
}
