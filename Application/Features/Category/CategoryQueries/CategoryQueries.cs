using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Category.CategoryQueries
{
    public class GetCategories : IRequest<GetCategoryResponse>
    {

    }
    public class GetCategoryResponse
    {
        public object Categories { get; set; }
    }

    public class GetCategoryById : IRequest<GetCategoryByIdResponse>
    {
        public string CategoryId { get; set; }
    }
    public class GetCategoryByIdResponse
    {
        public object Category { get; set; }
    }

    public class GetCategoryMapper
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
