using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Models;
using Services;
using Repositories;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ARealmContext>(
                options => options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddCors();
            services.AddMvc();

            //dependency injection
            services.AddScoped<SessionRepository>();
            services.AddScoped<TeamRepository>();
            services.AddScoped<DistrictRepository>();
            services.AddScoped<PhotoTaskRepository>();
            services.AddScoped<LocationTaskRepository>();
            services.AddScoped<PuzzleTaskRepository>();
            services.AddScoped<LockedDistrictsRepository>();
            services.AddScoped<SessionCodeRepository>();

            services.AddScoped<SessionService>();
            services.AddScoped<TeamService>();
            services.AddScoped<DistrictService>();
            services.AddScoped<PhotoTaskService>();
            services.AddScoped<LocationTaskService>();
            services.AddScoped<PuzzleTaskService>();
            services.AddScoped<SessionCodeService>();
            services.AddScoped<PhotoValidationService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ARealmContext aRealmContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder =>
           builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseMvc();

            DBInitializer.Initialize(aRealmContext);
        }
    }
}
