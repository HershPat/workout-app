
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace WorkoutApi.API.Extensions
{
    public static class ServiceExtension
    {
        public static void AddSwagger(this IServiceCollection iservice)
        {
            iservice.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Workout App",
                    Version = "v1",
                    Description = "Workout Web - Version 1",
                    Contact = new OpenApiContact
                    {
                        Name = "Workout Web - API",
                        Email = ""
                    }
                });
                c.CustomSchemaIds(type => type.ToString());

                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

            iservice.AddSwaggerGenNewtonsoftSupport();
        }
    }
}
