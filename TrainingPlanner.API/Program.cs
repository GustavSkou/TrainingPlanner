using Microsoft.AspNetCore.Mvc.ApplicationParts;

public partial class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddCors(options =>
            options.AddDefaultPolicy(p =>
                p.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));
        builder.WebHost.UseUrls("http://localhost:5027");

        var mvcBuilder = builder.Services.AddControllers();
        
        var app = builder.Build();
        app.UseCors();
        app.MapControllers();

        app.Run();
    }
}