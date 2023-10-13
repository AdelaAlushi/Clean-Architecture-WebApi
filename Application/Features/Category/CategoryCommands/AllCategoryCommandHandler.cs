using AutoMapper;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Category.CategoryCommands
{
    public class AllCategoryCommandHandlers :
           IRequestHandler<CreateCategory, CreateCategoryResponse>,
           IRequestHandler<UpdateCategory, UpdateCategoryResponse>,
           IRequestHandler<DeleteCommand, DeleteCommandResponse>
    {
        private readonly ICategoryRepository _categoryRepo;
        private readonly IMapper _mapper;

        public AllCategoryCommandHandlers(ICategoryRepository categoryRepo, IMapper mapper)
        {
            _categoryRepo = categoryRepo;
            _mapper = mapper;
        }

        public async Task<DeleteCommandResponse> Handle(DeleteCommand request, CancellationToken cancellationToken)
        {
            await _categoryRepo.RemoveAsync(request.Id);
            return new DeleteCommandResponse();
        }

        public async Task<UpdateCategoryResponse> Handle(UpdateCategory request, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Domain.Entities.Category>(request);

            var is_updated = _categoryRepo.Update(category);

            return new UpdateCategoryResponse() { ResponseMsg = is_updated ? "Success" : "Error" };
        }

        public async Task<CreateCategoryResponse> Handle(CreateCategory request, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Domain.Entities.Category>(request);

            await _categoryRepo.AddAsync(category);
            return new CreateCategoryResponse();
        }
    }
}
