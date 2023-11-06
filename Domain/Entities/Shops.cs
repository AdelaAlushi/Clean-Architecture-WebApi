using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Shops : BaseEntity
    {
        public string ShopId { get; set; }

        public string ShopName { get; set; }

        public string Location { get; set; }

        public bool IsAvailable { get; set; }


    }
}
