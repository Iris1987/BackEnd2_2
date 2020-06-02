using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Repository.Interface;
using Repository.Repositories;
using Service;
using Service.Interface;

namespace API
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddCors(c => c.AddPolicy("AllowCors", /*"AllowOrigin"*/
               builder =>
               {
                   builder.AllowAnyOrigin()
                       //.WithMethods("GET", "PUT", "POST", "DELETE")
                       .AllowAnyMethod()
                       .AllowAnyHeader();
               })
            );
            

            services.AddDbContext<SensorContext>(options =>
            options.UseNpgsql(Configuration.GetConnectionString("SourceConnection")));

            //Repository
            services.AddTransient<IControllerRepo, ControllerRepository>();
            services.AddTransient<IControllerSensorRepo, ControllerSensorRepository>();
            services.AddTransient<ISensorRepo, SensorRepository>();
            services.AddTransient<ITypeValueRepo, TypeValueRepository>();
             services.AddTransient<ISensorDataVWRepo, SensorDataVWRepository>();
            services.AddTransient<IDatasensorRepo, DataSensorRepository>();


            //Services
            //services.AddTransient<IGetService<Datasensor>, RoomTest>();
            services.AddTransient<IRoom, RoomTest>();
            services.AddTransient<IControllerTest, ControllerTest>();
            services.AddTransient<IControllerSensorService, ControllerSensorService>();



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("AllowCors");
            //app.UseRouting();

            app.UseHttpsRedirection();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseMvc();
        }
    }
}
