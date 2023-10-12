using Application.Features.Product.ProductCommands;
using AutoMapper;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Shops.ShopsCommands
{
    public class ShopsCommandHandler : IRequestHandler<CreateShops, CreateShopResponse>,
           IRequestHandler<UpdateShops, UpdateShopResponse>,
           IRequestHandler<Shops.ShopsCommands.DeleteCommand, DeleteCommandResponse>
    {

        private readonly IShopRepository _shopRepo;
        private readonly IMapper _mapper;


        //public AllShopsCommands(IShopRepository shopRepo, IMapper mapper)
        //{
        //    _shopRepo = shopRepo;
        //    _mapper = mapper;
        //}

        public async Task<DeleteCommandResponse> Handle(DeleteCommand request, CancellationToken cancellationToken)
        {
            await _shopRepo.RemoveAsync(request.Id);
            return new DeleteCommandResponse();
        }

        public async Task<UpdateShopResponse> Handle(UpdateShops request, CancellationToken cancellationToken)
        {
            var shops = _mapper.Map<Domain.Entities.Shops>(request);

            var is_updated = _shopRepo.Update(shops);

            return new UpdateShopResponse() { ResponseMsg = is_updated ? "Success" : "Error" };
        }

        public async Task<CreateShopResponse> Handle(CreateShops request, CancellationToken cancellationToken)
        {
            var shops = _mapper.Map<Domain.Entities.Shops>(request);

            await _shopRepo.AddAsync(shops);
            return new CreateShopResponse();
        }
    }
}
