using Microsoft.OpenApi.Models;
using SolarMetrics.Infrastructure.Persistence.Repositories;
using SolarMetrics.UseCase;
using SolarMetrics.Utils;

namespace SolarMetrics;

using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        
        var swaggerConfig = builder
            .Configuration
            .GetSection("Swagger")
            .Get<SwaggerConfig>();

        // Adiciona serviços ao container
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(swagger =>
            {
                swagger.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = swaggerConfig.Title,
                    Version = "v1",
                    Description = swaggerConfig.Description,
                    Contact = swaggerConfig.Contact
                });
                
                swagger.EnableAnnotations();

                foreach (var server in swaggerConfig.Servers)
                {
                    swagger.AddServer(new OpenApiServer
                        {
                         Url   = server.Url,
                         Description = server.Name
                        });
                }
            }
            );

        builder.Services.AddDbContext<SolarMetricsContext>(options =>
            options.UseOracle(builder.Configuration.GetConnectionString("OracleDb"))
        );
        
        builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
        builder.Services.AddScoped<IClienteUseCase, ClienteUseCase>();
        
        var app = builder.Build();

        // Configuração do pipeline HTTP
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(ui =>
                {
                    ui.SwaggerEndpoint("/swagger/v1/swagger.json", "SolarMetrics.API v1");
                    ui.RoutePrefix = string.Empty;
                }            
            );
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.UseRouting();
        app.MapControllers();
        app.Run();
    }
}
