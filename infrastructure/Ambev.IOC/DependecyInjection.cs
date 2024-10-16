using Ambev.Application.Interfaces;
using Ambev.Application.Services;
using Ambev.Application.Mappings;
using Ambev.Application.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ambev.IOC
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddInfra(this IServiceCollection services, IConfiguration config)
        {

            services.AddScoped<IVendaRepository, VendaRepository>();
            services.AddScoped<IVendaService, VendaService>();
            services.AddAutoMapper(typeof(DomainMapDto));

            return services;
        }
    }
}
