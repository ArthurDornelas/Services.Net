using HackatonApp.Data;
using HackatonApp.Data.Repositories;
using HackatonApp.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HackatonApp.Configuration
{
    public static class Injector
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<DataContext>();

            services.AddScoped<ICandidatoRepository, CandidatoRepository>();

            services.AddScoped<ICandidatoService, CandidatoService>();
        }
    }
}
