﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azurepeakswebcomic.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Azurepeakswebcomic.Models.Identity;
using Microsoft.EntityFrameworkCore;

namespace Azurepeakswebcomic
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
            services.AddDbContext<Azurepeakswebcomic.Models.ApplicationDbContext>(options => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TewnTownWebComic"));
            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<Azurepeakswebcomic.Models.ApplicationDbContext>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    // Startside når der skal deployes:
                    // template: "{controller=Comic}/{action=Entry}/{id=1}");
                    template: "{controller=Account}/{action=Login}/{id?}");
            });
        }
    }
}
