using Microsoft.OpenApi.Models;

namespace n2SuperFatorial
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Configuração do CORS
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAnyOrigin",
                    builder => builder.AllowAnyOrigin()
                                      .AllowAnyHeader()
                                      .AllowAnyMethod());
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "SUPER FATORIAL API",
                    Version = "",
                });
            });

            // Resto das configurações do serviço
        }

        public void Configure(IApplicationBuilder app)
        {
            // Habilita o CORS
            app.UseCors("AllowAnyOrigin");

            // Resto das configurações do aplicativo
        }
    }
}
