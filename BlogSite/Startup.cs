using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogSite.Interfaces;
using BlogSite.Mocks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BlogSite
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IAllPosts, MockPosts>();
            services.AddTransient<IPostsCategory, MockCategory>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("about", "{controller=Home}/{action=About}");

                endpoints.MapControllerRoute("blog", "{controller=BlogPage}/{action=Index}/{id?}");               

                endpoints.MapControllerRoute("article", "{controller=Article}/{action=Index}/{id}");
            });
        }
    }
}
