namespace WebApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}"
                );

            app.MapControllerRoute(
                  name: "privacy",
                  pattern: "{controller=PrivacyPolicy}/{action=Index}"
              );


            app.Run();
        }
    }
}