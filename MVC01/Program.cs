internal class Program
{
    public static void Main(string[] args)
    {
        //dev
        var builder = WebApplication.CreateBuilder(args);
        
        var app = builder.Build();
        app.UseRouting();



        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGet("/", async context =>
            {
                await context.Response.WriteAsync("You are In  Page");

            });


            endpoints.MapGet("/Home", async context =>
            {
             
                await context.Response.WriteAsync("You are In Home Page");

            });

            endpoints.MapPost("/Product", async context =>
            {

                await context.Response.WriteAsync("You are In Product Page");

            });


            


        });


        app.Run(HttpContext=>HttpContext.Response.WriteAsync("Your Request Page Not Found"));

        app.Run();

    }
}