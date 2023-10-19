using Application.Features.Clothes.ClothesQueries;
using AutoMapper;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Clothes.ClothesComands
{
    public class AllClothesCommandHandlers :
          IRequestHandler<GetClothesById, GetClothesByIdResponse>,
          IRequestHandler<CreateClothes, CreateClothesResponse>,
          IRequestHandler<UpdateClothes, UpdateClothesResponse>,
          IRequestHandler<DeleteCommand, DeleteCommandResponse>
    {
        private readonly IClothesRepository _categoryRepo;
        private readonly IMapper _mapper;

        public AllClothesCommandHandlers(IClothesRepository categoryRepo, IMapper mapper)
        {
            _categoryRepo = categoryRepo;
            _mapper = mapper;
        }

        public async Task<DeleteCommandResponse> Handle(DeleteCommand request, CancellationToken cancellationToken)
        {
            await _categoryRepo.RemoveAsync(request.Id);
            return new DeleteCommandResponse();
        }

        public async Task<UpdateClothesResponse> Handle(UpdateClothes request, CancellationToken cancellationToken)
        {
            var clothes = _mapper.Map<Domain.Entities.Clothes>(request);

            var is_updated = _categoryRepo.Update(clothes);

            return new UpdateClothesResponse() { ResponseMsg = is_updated ? "Success" : "Error" };
        }

        public async Task<CreateClothesResponse> Handle(CreateClothes request, CancellationToken cancellationToken)
        {
            var clothes = _mapper.Map<Domain.Entities.Clothes>(request);

            await _categoryRepo.AddAsync(clothes);
            return new CreateClothesResponse();
        }

        public async Task<GetClothesByIdResponse> Handle(GetClothesById request, CancellationToken cancellationToken)
        {
            var clothes = await _categoryRepo.GetByIdAsync(request.ClothesId);
            return new() { Clothes = clothes };
         }

        }
    }

