using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ClothesRepository : GenericRepository<Clothes>, IClothesRepository
    {
        private EFDBContext db;
        public ClothesRepository(EFDBContext context) : base(context)
        {
            db = context;
        }

     
    }
}
