using SimpleAPI.Extensions;
namespace SimpleAPI;
public class Program {
    public static void Main(string[] args) {
        var builder = WebApplication.CreateBuilder();
        // Add services to the container.
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        var app = builder.Build();
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {

        }
        app.UseHttpsRedirection();
        app.UseSwagger();
        app.UseSwaggerUI();
        app.MapEndpoints();
        app.Run();
    }

}
