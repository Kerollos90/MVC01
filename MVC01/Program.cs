internal class Program
{
    public static void Main(string[] args)
    {
        //dev
        var builder = WebApplication.CreateBuilder(args);
        
        var app = builder.Build();
        app.UseRouting();


        app.Use(async (context, next) => {
            Endpoint endpoint = context.GetEndpoint();

            if(endpoint is null)
                await context.Response.WriteAsync("=====");


            await next();
         
        
        
        });



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

            endpoints.MapGet("/Product", async context =>
            {

                await context.Response.WriteAsync("You are In Product Page");

            });

            endpoints.MapGet("/Product/{id}", async context =>
            {
                var id = context.Request.RouteValues["id"];
                await context.Response.WriteAsync($"You are In Product Id => {id}");

            });
            
            endpoints.MapGet("/Books/{id}/{name}", async context =>
            {
                var id = context.Request.RouteValues["id"];
                var name = context.Request.RouteValues["Name"];

                await context.Response.WriteAsync($"Your Book Id =>{id} , Name => {name}");

            });

            endpoints.MapGet("/Books/{id}", async context =>
            {
                var id = context.Request.RouteValues["id"];

                await context.Response.WriteAsync($"Your Book Id =>{id}");

            });


            


        });


        app.Run(HttpContext=>HttpContext.Response.WriteAsync("Your Request Page Not Found"));

        app.Run();

    }
}