using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using PoolSaison2019.Models;
using PoolSaison2019.Controllers;
using PoolSaison2019.Data;

namespace PoolSaison2019
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

            services.AddDbContext<PoolSaison2019Context>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("PoolSaison2019Context")));


            services.AddSingleton<IRepository<Joueur>, MockJoueurRepository>(); //Doit être en commentaire pour les tests d'intégration Travis
            //services.AddSingleton<IRepository<Joueur>, RepositoryPattern<Joueur>>();

            services.AddSingleton<IRepository<Participant>, MockParticipantRepository>();    //Doit être en commentaire pour les tests d'intégration Travis
            //services.AddSingleton<IRepository<Participant>, RepositoryPattern<Participant>>();

            services.AddSingleton<IRepository<Signature>, MockSignatureRepository>();   //Doit être en commentaire pour les tests d'intégration Travis
            //services.AddSingleton<IRepository<Signature>, RepositoryPattern<Signature>>();
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
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
