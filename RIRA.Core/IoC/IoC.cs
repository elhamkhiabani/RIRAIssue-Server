using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using RIRA.Core.CRUD;
using RIRA.Core.Repositories;
using RIRA.Core.Services;
using RIRA.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIRA.Core.IoC
{
    public static class IoC
    {
        public static void Injector(this IServiceCollection services)
        {
            services.AddScoped(typeof(ICRUD<>),typeof(CRUD<>));
            services.AddScoped(typeof(IRepository<,>),typeof(Repository<,>));
            services.AddScoped<IUserService,UserService>();
           

        }
    }
}
