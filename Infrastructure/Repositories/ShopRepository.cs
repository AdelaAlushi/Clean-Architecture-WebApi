using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ShopRepository : GenericRepository<Shops>, IShopRepository
    {
        private EFDBContext db;
        public ShopRepository(EFDBContext context) : base(context)
        {
            db = context;
        }

        public async Task<ICollection<Shops>> GetAllShops()
        {
            var shops = await db.Shops.ToListAsync();
            return shops;
        }


    }
}
