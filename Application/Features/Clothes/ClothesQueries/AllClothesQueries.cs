using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Clothes.ClothesQueries
{
    public class GetClothes : IRequest<GetClothesResponse>
    {

    }
    public class GetClothesResponse
    {
        public object Products { get; set; }
    }
    public class GetClothesById : IRequest<GetClothesByIdResponse>
    {
        public string ClothesId { get; set; }
    }
    public class GetClothesByIdResponse
    {
        public object Clothes { get; set; }
    }
}
