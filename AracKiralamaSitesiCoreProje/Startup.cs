using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AracKiralamaSitesiCoreProje.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AracKiralamaSitesiCoreProje
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
            services.AddControllersWithViews();
            services.AddScoped<IAracRepository, AracRepository>();
            services.AddScoped<IMusteriRepository,MusteriRepository>();
            services.AddScoped<IMusaitAraclarRepository, MusaitAraclarRepository>();
            services.AddScoped<IKiralamaRepository,KiralamaRepository>();
            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("IsmailConnection")));
        }

        private void options(DbContextOptionsBuilder builder)
        {
            throw new NotImplementedException();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                  // pattern: "{controller=Home}/{action=Index}/{id?}");
                  // pattern: "{controller=Arac}/{action=Index}/{id?}");
                  pattern: "{controller=Login}/{action=Login}/{id?}");
            });
        }
    }
}
