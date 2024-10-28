using Ecommerce.Data;
using Ecommerce.Models.Entities.Identity;
using Ecommerce.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var connectionString = builder.Configuration.GetConnectionString("Ecommerce") ?? throw new InvalidOperationException("Connection string 'Ecommerce' not found.");
            builder.Services.AddDbContext<EcommerceContext>(options =>
                options.UseSqlServer(connectionString)
             );
            builder.Services.AddIdentity<User, Role>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = true;
                options.Password.RequiredUniqueChars = 4;
            })
            .AddEntityFrameworkStores<EcommerceContext>();

            builder.Services.ConfigureApplicationCookie(options =>
            {
                // If the LoginPath isn't set, ASP.NET Core defaults the path to /Account/Login.
                options.LoginPath = "/Account/Login"; // Set your login path here
                options.AccessDeniedPath = "/Account/AccessDenied";
            });

            // Register repositories
            builder.Services.AddScoped<IAccountRepository, AccountRepository>();
            builder.Services.AddScoped<IAdminRepository, AdminRepository>();
            builder.Services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();

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
