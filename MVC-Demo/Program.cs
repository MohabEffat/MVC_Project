namespace MVC_Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.UseRouting();
            
            app.UseStaticFiles();

            #region MyRegion
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/Home", async context =>
            //    {
            //        await context.Response.WriteAsync("You Are At Home Page");
            //    });

            //    endpoints.MapGet("/Prodcuts/{id:ing?}", async context =>
            //    {
            //        var idData = context.Request.RouteValues["id"];
            //        if (idData is not null)
            //        {
            //            int id = Convert.ToInt32(idData);
            //            await context.Response.WriteAsync($"id={id}");
            //        }
            //        else
            //            await context.Response.WriteAsync("You Are At Product Page")
            //    });

            //    endpoints.MapGet("/Books/{id}/{author:alpha:minlength(4):maxlength(6)}", async context =>
            //    {
            //        int id = Convert.ToInt32(context.Request.RouteValues["id"]);
            //        string author = context.Request.RouteValues["author"].ToString();
            //    });

            //}); 
            #endregion

            //app.MapGet("/", () => "Hello World!");

            app.MapControllerRoute(
                name: "default",
                pattern: "/{Controller=Home}/{Action=Index}",
                defaults: new { Controller = "Home", Action = "Index" }
            );

            app.Run();
        }
    }
}