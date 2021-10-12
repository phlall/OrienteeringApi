using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OrienteeringApi.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace OrienteeringApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                    );
            });
            services.AddControllers();
            services.AddScoped<IOrienteeringRepository, OrienteeringRepository>();
            services.AddScoped<ILessonGroupRepository, LessonGroupRepositiory>();
            services.AddScoped<ILessonGroupSessionRepository, LessonGroupSessionRepository>();
            services.AddScoped<IQaRepository, QaRepository>();
            services.AddScoped<ISubjectRepository, SubjectRepository>();
            services.AddScoped<ISchoolRepository, SchoolRepository>();
            services.AddScoped<IMapRepository, MapRepository>();
            services.AddScoped<IMapImageRepository, MapImageRepository>();
            services.AddAutoMapper(typeof(Startup));
            services.AddDbContext<OrienteeringContext>(options =>
         options.UseNpgsql(Configuration.GetConnectionString("OrienteeringConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseCors("CorsPolicy");
         
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
