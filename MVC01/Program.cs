internal class Program
{
    public static void Main(string[] args)
    {
        //dev
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();
        
        var app = builder.Build();
        app.UseRouting();
        app.UseStaticFiles();

        #region MyRegion

        //app.Use(async (context, next) => {
        //    Endpoint endpoint = context.GetEndpoint();

        //    if(endpoint is null)
        //        await context.Response.WriteAsync("=====");


        //    await next();



        //});



        //app.UseEndpoints(endpoints =>
        //{
        //    endpoints.MapGet("/", async context =>
        //    {
        //        await context.Response.WriteAsync("You are In  Page");

        //    });


        //    endpoints.MapGet("/Home", async context =>
        //    {

        //        await context.Response.WriteAsync("You are In Home Page");

        //    });

        //    endpoints.MapGet("/Product", async context =>
        //    {

        //        await context.Response.WriteAsync("You are In Product Page");

        //    });

        //    endpoints.MapGet("/Product/{id}", async context =>
        //    {
        //        var id = context.Request.RouteValues["id"];
        //        await context.Response.WriteAsync($"You are In Product Id => {id}");

        //    }); 




        //    endpoints.MapGet("/Books/{id}/{name}", async context =>
        //    {
        //        var id = context.Request.RouteValues["id"];
        //        var name = context.Request.RouteValues["Name"];

        //        await context.Response.WriteAsync($"Your Book Id =>{id} , Name => {name}");

        //    });

        //    endpoints.MapGet("/Books/{id:int?}", async context =>
        //    {
        //        var idData = context.Request.RouteValues["id"];

        //        if (idData is not null)
        //        {
        //            int id = Convert.ToInt32(idData);
        //          await context.Response.WriteAsync($"Your Book Id =>{id}");
        //        }
        //        else
        //            await context.Response.WriteAsync("Your Book Id Is Empty");

        //    });





        //});


        //app.Run(HttpContext=>HttpContext.Response.WriteAsync("Your Request Page Not Found"));

        //app.Run(); 
        #endregion


        app.MapControllerRoute(
            name: "defult",
            pattern: "/{Controller=Home}/{Action=Index}",
            defaults: new {Controller="Home" ,Action="Index"}


            );


        app.Run();



    }
}