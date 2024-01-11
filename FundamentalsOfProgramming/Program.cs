
using Adapters;
using Services.Interfaces;
using Services.Services;

namespace FundamentalsOfProgramming
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddScoped<IImageService, ImageService> ();
            builder.Services.AddScoped<IImageAdapter, ImageAdapter>();

            builder.Services.AddScoped<IFactorialService, FactorialService>();

            builder.Services.AddScoped<IReverseSentenceService, ReverseSentenceService>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
