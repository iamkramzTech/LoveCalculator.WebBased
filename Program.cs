using Microsoft.AspNetCore.Builder;

namespace LoveCalculator.WebBased
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //builder.Services.AddAntiforgery(options => options.HeaderName = "X-XSRF-TOKEN");  // This line allows you to configure or bypass token validation.

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
               app.UseHttpsRedirection();
            }

            app.UseStaticFiles();
            // Use the antiforgery middleware
            /*app.UseAntiforgery();*/ // This will bypass the token validation, but note that it’s not the most secure solution,
            app.UseRouting(); // Routing should come after antiforgery middleware
            app.UseAuthorization();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );

            //app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
