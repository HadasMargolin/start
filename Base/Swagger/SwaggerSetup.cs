using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Solus.Microservice.Base.Swagger
{
    public static class SwaggerSetup
    {
        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services, string title)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = title, Version = "v1" });
            });
            return services;
        }
    }
}