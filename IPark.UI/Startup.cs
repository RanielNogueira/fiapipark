using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ipark.Service.Repository;
using IPark.Domain;
using IPark.Service.Data;
using IPark.UI.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace IPark.UI
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ParkContext>(
                    options => options.UseSqlServer(
                        Configuration.GetConnectionString("connectionIPark")));

            services.AddHttpContextAccessor();
            services.TryAddSingleton<IActionContextAccessor, ActionContextAccessor>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddScoped<Service.Interfaces.IAgendamentoRepository, AgendamentoRepository>();
            services.AddScoped<Service.Interfaces.IAgendaRepository, AgendaRepository>();
            services.AddScoped<Service.Interfaces.IClienteLocatarioRepository, ClienteLocatarioRepository>();
            services.AddScoped<Service.Interfaces.IClienteRepository, ClienteRepository>();
            services.AddScoped<Service.Interfaces.ILocatarioRepository, LocatarioRepository>();
            services.AddScoped<Service.Interfaces.IVagaRepository, VagaRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
