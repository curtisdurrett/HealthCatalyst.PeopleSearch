using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using HealthCatalyst.Data;
using HealthCatalyst.Data.Repository;
using HealthCatalyst.Services;

namespace HealthCatalyst.Web.Api
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

            // TODO:  Change to be more secure
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAny", builder => builder.AllowAnyOrigin()
                                                                .AllowAnyMethod()
                                                                .AllowAnyHeader()
                                                                .AllowCredentials());
            });

            services.AddMvc();

            // TODO: Move the connection string to configuration value
            services.AddDbContext<DatabaseContext>(options => options.UseSqlite("Data Source=healthcatalyst.db"));

            // DI the services
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IPersonSearchService, PersonSearchService>();
            services.AddScoped<IPersonDataSeederService, PersonDataSeederService>();

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
