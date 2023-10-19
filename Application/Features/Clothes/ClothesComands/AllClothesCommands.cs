using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Clothes.ClothesComands
{
    public class CreateClothes : IRequest<CreateClothesResponse>
    {
        public string Name { get; set; }

        public int Id { get; set; }
        public bool IsActive { get; set; }

    }
    public class CreateClothesResponse
    {

    }

    public class UpdateClothes : IRequest<UpdateClothesResponse>
    {
        public string Name { get; set; } 

        public int Id { get; set; }
        public bool IsActive { get; set; }

    }
    public class UpdateClothesResponse
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
