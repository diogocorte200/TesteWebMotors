using Hangfire;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using System;
using TesteWebMotors.Client;
using TesteWebMotors.Domain.Aggregate;
using TesteWebMotors.Domain.Mapping;
using TesteWebMotors.Domain.Service;
using TesteWebMotors.Domain.Service.Generic;
using TesteWebMotors.Entity.Context;
using TesteWebMotors.Entity.Repositories;
using TesteWebMotors.Entity.Repositories.Interfaces;
using TesteWebMotors.Entity.UnitofWork;

namespace TesteWebMotors
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                      new OpenApiInfo
                      {
                          Title = "Webservices anuncios",
                          Version = "v1",
                          Description = "Webservices anuncios",
                          Contact = new OpenApiContact
                          {
                              Name = "Diogo Rodrigues",
                          }
                      });

            });


            services.AddHangfire(config =>
            {
                config.UseSqlServerStorage(Configuration["ConnectionStrings:webMotorsDB"]);
                config.UseSerializerSettings(new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
            });


            if (Configuration["ConnectionStrings:UseInMemoryDatabase"] == "True")
                services.AddDbContext<WebMotorsContext>(opt => opt.UseInMemoryDatabase("TestDB-" + Guid.NewGuid().ToString()));
            else
                services.AddDbContext<WebMotorsContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:webMotorsDB"]));


            services.AddTransient<IUnitOfWork, UnitOfWork>();



            services.AddTransient(typeof(AnuncioService<,>), typeof(AnuncioService<,>));


            services.AddTransient(typeof(IServiceAsync<,>), typeof(GenericServiceAsync<,>));
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

            services.AddTransient<IAnuncioRepository, AnuncionRepository>();

            services.AddTransient<IWebMotorsClient,WebMotorsClient>();
            services.AddHttpClient<IWebMotorsClient,WebMotorsClient>();

            services.AddAutoMapper(typeof(MappingProfile));
            services.AddHttpContextAccessor();
            #region "CORS"
            // include support for CORS
            // More often than not, we will want to specify that our API accepts requests coming from other origins (other domains). When issuing AJAX requests, browsers make preflights to check if a server accepts requests from the domain hosting the web app. If the response for these preflights don't contain at least the Access-Control-Allow-Origin header specifying that accepts requests from the original domain, browsers won't proceed with the real requests (to improve security).
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy-public",
                    builder => builder.AllowAnyOrigin()   //WithOrigins and define a specific origin to be allowed (e.g. https://mydomain.com)
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                //.AllowCredentials()
                .Build());
            });
            #endregion


            services.AddControllers();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseCors("CorsPolicy-public");  //apply to every request
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json",
                    "Webservices clientes");
            });
        }
    }
}
