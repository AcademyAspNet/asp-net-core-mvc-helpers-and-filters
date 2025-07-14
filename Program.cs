using AspNetCoreMvcHelpers.Filters;

namespace AspNetCoreMvcHelpers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<LogActionFilter>();

            var app = builder.Build();

            app.MapControllerRoute("default", "{controller=Home}/{action=Index}");
            app.UseStaticFiles();

            app.Run();
        }
    }
}
