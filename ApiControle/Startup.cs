using ApiControle.Model;
using AutoMapper;
using Data.Repository;
using Domain.Entities;
using Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;
using Service.Services;
using System.Configuration;
using System.Reflection;

namespace ApiControle
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
            services.AddControllers();

            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Api" , Version = "v1", });
            });

            services.AddDbContext<Data.Context.DbContext>(
                options => options.UseLazyLoadingProxies().UseSqlServer(Configuration.GetConnectionString("Connection")));

            services.AddScoped<IBaseRepository<Licitacao>, BaseRepository<Licitacao>>();
            services.AddScoped<ILicitacaoRepository, LicitacaoRepository>();

            services.AddScoped<IBaseService<Licitacao>, BaseService<Licitacao>>();
            services.AddScoped<ILicitacaoService, LicitacaoService>();

            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<LicitacaoModel, Licitacao>();
                config.CreateMap<Licitacao, LicitacaoModel>();
            }).CreateMapper());
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();

            app.UseSwaggerUI(c => {
                c.RoutePrefix = "swagger";
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });
        }
    }
}
