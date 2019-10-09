using AspNetCoreBase.Data;
using AspNetCoreBase.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreBase
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
            services.AddMvc();
            var connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=pilaodb;Trusted_Connection=True;MultipleActiveResultSets=true";
            //var connectionString = _configuration.GetConnectionString("DefaulConnection");
            //services.AddSingleton<IPessoaService, PessoaServiceMemory>();
            services.AddDbContext<Context>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequiredLength = 10;
                options.Password.RequiredUniqueChars = 3;
                options.Password.RequireNonAlphanumeric = false;
            });
            services.AddScoped<IPessoaService,PessoaServiceEF>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
