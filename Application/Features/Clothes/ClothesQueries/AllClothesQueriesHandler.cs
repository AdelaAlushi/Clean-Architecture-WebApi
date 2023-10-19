using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Clothes.ClothesQueries
{
    public class AllClothesQueriesHandler:
    
        IRequestHandler<GetClothes, GetClothesResponse>
      
    {
        readonly IClothesRepository _clothesRepo;

        public AllClothesQueriesHandler(IClothesRepository clothesRepo)
        {
            _clothesRepo = clothesRepo;
        }

        public async Task<GetClothesResponse> Handle(GetClothes request, CancellationToken cancellationToken)
        {
            var clothes = _clothesRepo.GetAll().ToList();
            return new() { Clothes = clothes };
        }

        public async Task<GetClothesByIdResponse> Handle(GetClothesById request, CancellationToken cancellationToken)
        {
            var clothes = await _clothesRepo.GetByIdAsync(request.ClothesId);
            return new() { Clothes = clothes };
        }
    }
}
