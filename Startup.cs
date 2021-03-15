using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MongoDriver.Repository;
using MongoDriver.Repository.Cliente;

namespace MongoDriver
{
    public class Startup
    {
     
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddSingleton<IConnection,Connection>()
                .AddScoped<IClienteRepo, ClienteRepo>();

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
