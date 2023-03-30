using CleanApp.API.Filters;
using CleanApp.API.Swagger;
using CleanApp.Application;
using CleanApp.Persistence;
using FluentValidation.AspNetCore;
using MicroElements.Swashbuckle.FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Swashbuckle.AspNetCore.SwaggerUI;
using System;
using System.IO;

namespace CleanApp.API
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });

            services.AddApplication();
            services.AddPersistence(_configuration);

            services.AddRouting(options => options.LowercaseUrls = true);

            services.AddSwaggerGen(options =>
            {
                options.CustomSchemaIds(CustomSwaggerOptions.SchemaIdStrategy);

                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Clean App",
                    Version = "v1",
                });

                var filePath = Path.Combine(AppContext.BaseDirectory, "CleanApp.API.xml");
                options.IncludeXmlComments(filePath);
            });

            services.AddSwaggerGenNewtonsoftSupport();

            services.AddFluentValidationRulesToSwagger();

            services.AddControllers(option =>
            {
                option.Filters.Add<ApiExceptionFilterAttribute>();
            }).AddFluentValidation(option =>
            {
                option.DisableDataAnnotationsValidation = true;
                option.RegisterValidatorsFromAssemblyContaining<Startup>();
            }).AddNewtonsoftJson(option =>
            {
                option.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                option.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            });

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(
                      options =>
                      {
                          options.SwaggerEndpoint("/swagger/v1/swagger.json", "Clean App");
                          options.DocExpansion(DocExpansion.None);
                      });
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseRouting();
            app.UseCors();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
