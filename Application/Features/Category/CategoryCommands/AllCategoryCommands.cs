using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Category.CategoryCommands
{
    public class CreateCategory : IRequest<CreateCategoryResponse>
    {
        public string Name { get; set; }
        
        public int Id { get; set; }
        public bool IsActive { get; set; }
       
    }
    public class CreateCategoryResponse
    {

    }

    public class UpdateCategory : IRequest<UpdateCategoryResponse>
    {
        public string Name { get; set; }

        public int Id { get; set; }
        public bool IsActive { get; set; }

    }
    public class UpdateCategoryResponse
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
}
