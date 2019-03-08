using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using WebApplication1.Model.Context;
using WebApplication1.Repository;
using WebApplication1.Repository.Generic;
using WebApplication1.Repository.Impl;
using WebApplication1.Services;
using WebApplication1.Services.Impl;

namespace API_Rest
{
    public class Startup
    {
        private readonly ILogger _logger;
        
        public Startup(IConfiguration configuration, ILogger<Startup> logger)
        {
            _logger = logger;
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEntityFrameworkNpgsql().AddDbContext<PostgresContext>(
                options => options.UseNpgsql(
                    Configuration.GetConnectionString("Base")));

            
            //Configurando versionamento das apis.
            services.AddApiVersioning();

            //Injeção de dependências dos serviços
            services.AddScoped<IPersonService, PersonServiceImpl>();
            services.AddScoped<IBookService, BookServiceImpl>();

            //Injeção de dependências dos repositórios especialistas
            services.AddScoped<IPersonRepository, PersonRepositoryImpl>();
            services.AddScoped<IBookRepository, BookRepositoryImpl>();

            //Injeção do repositório genérico
            services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
