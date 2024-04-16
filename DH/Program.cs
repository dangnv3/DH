using DH.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DH
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
           /* builder.Services.AddControllersWithViews();*/
            builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation(); //AddRazorRuntimeCompilation change html css Page Not Refreshing After Changes
            builder.Services.AddDbContext<DataDbcontext>(conn => conn.UseSqlServer(builder.Configuration.GetConnectionString("sqlconnection")));
            /*builder.Services.AddAuthentication(options =>
                {
                    options.AddPolicy("RequireAdminRole", policy => policy.RequireRole("Admin"));
                    options.AddPolicy("RequireUserRole", policy => policy.RequireRole("User"));
                }
            );*/
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}