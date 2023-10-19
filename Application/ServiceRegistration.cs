using Application.Features.Account.AccountQueries;
using Application.Features.Category.CategoryCommands;
using Application.Features.Category.CategoryQueries;
using Application.Features.Product.ProductCommands;
using Application.Features.Shops.ShopsCommands;
using AutoMapper;
using Domain.Entities;
using Domain.Entities.Identity;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Application.Features.Account.AccountCommands.AccountCommands;
using static Application.Features.Shops.ShopsQueries.AllShopQueries;

namespace Application
{
    public static class ServiceRegistration
    {
        public class RegisterMapper : Profile
        {
            public RegisterMapper()
            {
                //mapping for Products

                CreateMap<CreateProduct, Product>();
                CreateMap<UpdateProduct, Product>();

                //mapping for Shops

                CreateMap<CreateShops, Shops>();
                CreateMap<UpdateShops, Shops>();
                CreateMap<Shops, GetShopMapper>();

                //mapping for Register

                CreateMap<RegisterCommand, RegisterUser>();
               // CreateMap<DeleteUser, DeleteUserResponse>();

                //mapping for Category
                CreateMap<CreateCategory, Category>();
                CreateMap<UpdateCategory, Category>();
                CreateMap<Category, GetCategoryMapper>();
               


            }
        }
        public static void AddMapperServices(this IServiceCollection services)
        {
            var mapperConfiguration = new MapperConfiguration(config =>
            {
                config.AddProfile<RegisterMapper>();
            });

            var mapper = mapperConfiguration.CreateMapper();
            services.AddSingleton(mapper);
        }
        public static void AddApplicationServices(this IServiceCollection collection)
        {
            collection.AddMediatR(typeof(ServiceRegistration));
        }
    }
}
